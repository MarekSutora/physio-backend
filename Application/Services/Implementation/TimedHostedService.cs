using Application.Services.Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Services.Implementation
{
    public class TimedHostedService : IHostedService, IDisposable
    {
        private readonly ILogger<TimedHostedService> _logger;
        private readonly IEmailService _emailService;
        private Timer _timer;

        public TimedHostedService(ILogger<TimedHostedService> logger, IEmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Hosted Service running.");

            if (!cancellationToken.IsCancellationRequested)
            {
                _logger.LogInformation("Timed Hosted Service is not stopping.");
                _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromHours(6)); // Spustenie každých 6 hodín
            }

            return Task.CompletedTask;
        }

        private async void DoWork(object state)
        {
            _logger.LogInformation("Timed Hosted Service is working.");
            await _emailService.SendReminderEmailsAsync();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
