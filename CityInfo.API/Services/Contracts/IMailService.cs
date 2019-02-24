using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services.Contracts
{
    public interface IMailService
    {
        void Send(string subject, string message);
    }
}
