using FP_Group_27.ERMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Group_27.IO
{
    class ReadItemContext : IReadItemContext
    {
        private IReadItemStrategy _strategy;

        public ReadItemContext(IReadItemStrategy readItemStrategy)
        {
            _strategy = readItemStrategy;
        }
        public IList<Item> Read()
        {
            return _strategy.Read();
        }
    }
}
