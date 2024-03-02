using Application.Services.Interfaces;
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
        private readonly ILogger<StatisticsService> _logger;

        public StatisticsService(ApplicationDbContext context, ILogger<StatisticsService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<ServiceTypeMonthlyStatisticsDto>> GetServiceTypesFinishedAppointmentsCountsAsync(int startYear)
        {
            var currentYear = DateTime.Now.Year;
            return await _context.BookedAppointments
                .Where(ba => ba.IsFinished && ba.AppointmentBookedDate.Year >= startYear && ba.AppointmentBookedDate.Year <= currentYear)
                .GroupBy(ba => new
                {
                    Year = ba.AppointmentBookedDate.Year,
                    Month = ba.AppointmentBookedDate.Month,
                    ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.Name,
                    ba.AppointmentServiceTypeDurationCost.ServiceTypeDurationCost.ServiceType.HexColor
                })
                .Select(g => new ServiceTypeMonthlyStatisticsDto
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    ServiceTypeName = g.Key.Name,
                    FinishedAppointmentsCount = g.Count(),
                    HexColor = g.Key.HexColor
                })
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
            var newClientsTrend = await _context.ApplicationUsers // Use ApplicationUser entity
                .GroupBy(u => new
                {
                    Year = u.RegisteredDate.Year, // Directly use RegisteredDate.Year
                    Month = u.RegisteredDate.Month // Directly use RegisteredDate.Month
                })
                .Select(g => new NewClientsStatisticsDto
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    NewClientsCount = g.Count()
                })
                .OrderBy(n => n.Year).ThenBy(n => n.Month)
                .ToListAsync();

            return newClientsTrend;
        }
    }
}
