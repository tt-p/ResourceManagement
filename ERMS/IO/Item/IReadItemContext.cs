using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP_Group_27.ERMS.Model;

namespace FP_Group_27.IO
{
    public interface IReadItemContext
    {
        IList<Item> Read();
    }
}
