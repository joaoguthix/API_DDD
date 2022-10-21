﻿using Domain.Interfaces;
using Domain.Interfaces.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceMessage : IServiceMessage
    {
        private readonly IMessage _Imessage;

        public ServiceMessage(IMessage Imessage)
        {
            _Imessage = Imessage;
        }
    }
}
