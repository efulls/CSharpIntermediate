using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class Installer
    {
        private readonly Logger _logger;

        public Installer (Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("We Are Installing the Application");
        }
    }
}
