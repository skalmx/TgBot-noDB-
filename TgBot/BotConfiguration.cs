using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace TgBot
{
    internal  class BotCongiguration
    {
        public readonly static string botToken = ConfigurationManager.AppSettings["token"]!;
        
    }
}
