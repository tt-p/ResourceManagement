using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Group_27.IO
{
    public class ReadItemFactory
    {
        public static IReadItemContext CreateContext(String path)
        {
            string ext = System.IO.Path.GetExtension(path);
            ReadItemContext context = ext switch
            {
                ".csv" => new ReadItemContext(new ReadItemCsv(path)),
                ".txt" => new ReadItemContext(new ReadItemTxt(path)),
                _ => throw new FileFormatException("File is not in a readable"),
            };
            return context;
        }
    }
}
