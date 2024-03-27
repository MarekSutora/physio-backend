﻿using Application.Services.Interfaces;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Shared.DTO.Statistics.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementation
{
    public class StatisticsService : IStatisticsService
    {

        private readonly ApplicationDbContext _context;

        public StatisticsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ServiceTypeMonthlyStatisticsDto>> GetServiceTypesFinishedAppointmentsCountsAsync()
        {
            return await _context.BookedAppointments
                .Where(ba => ba.IsFinished)
                .GroupBy(ba => new
                {
                    Year = ba.AppointmentBookedDate.Year,
                    Month = ba.AppointmentBookedDate.Month,
                    ServiceTypeName = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.Name,
                    HexColor = ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.HexColor
                })
                .Select(g => new ServiceTypeMonthlyStatisticsDto
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    ServiceTypeName = g.Key.ServiceTypeName,
                    FinishedAppointmentsCount = g.Count(),
                    HexColor = g.Key.HexColor
                })
                .OrderBy(s => s.Year).ThenBy(s => s.Month)
                .ToListAsync();
        }


        public async Task<IEnumerable<RevenueStatisticsDto>> GetTotalRevenueStatisticsAsync()
        {
            var revenueStats = await _context.BookedAppointments
                .Where(ba => ba.IsFinished)
                .GroupBy(ba => new
                {
                    Year = ba.AppointmentBookedDate.Year,
                    Month = ba.AppointmentBookedDate.Month
                })
                .Select(g => new RevenueStatisticsDto
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    TotalRevenue = g.Sum(ba => ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.DurationCost.Cost)
                })
                .OrderBy(rs => rs.Year).ThenBy(rs => rs.Month)
                .ToListAsync();

            return revenueStats;
        }

        public async Task<IEnumerable<NewClientsStatisticsDto>> GetNewClientsTrendAsync()
        {
            var newClientsTrend = await _context.ApplicationUsers
                .GroupBy(u => new
                {
                    Year = u.RegisteredDate.Year,
                    Month = u.RegisteredDate.Month
                })
                .Select(g => new NewClientsStatisticsDto
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    NewClientsCount = g.Count()
                })
                .OrderBy(s => s.Year).ThenBy(s => s.Month)
                .ToListAsync();

            return newClientsTrend;
        }

        public async Task<IEnumerable<BlogPostViewsStatsDto>> GetBlogPostViewsStatsAsync()
        {
            var blogPostViewsStats = await _context.BlogPosts
                .GroupBy(bp => new
                {
                    Year = bp.DatePublished.Year,
                    Month = bp.DatePublished.Month
                })
                .Select(g => new BlogPostViewsStatsDto
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    TotalViews = g.Sum(bp => bp.ViewCount)
                })
                .OrderBy(s => s.Year).ThenBy(s => s.Month)
                .ToListAsync();

            return blogPostViewsStats;
        }
    }
}
