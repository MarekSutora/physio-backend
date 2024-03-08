﻿using Application.Common.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(EmailRequest emailRequest);
    }
}