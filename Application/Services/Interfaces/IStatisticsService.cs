﻿using Shared.DTO.Statistics.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IStatisticsService
    {

        Task<IEnumerable<ServiceTypeMonthlyStatisticsDto>> GetServiceTypeMonthlyFinishedAppointmentsCountsAsync(int year);

    }
}
