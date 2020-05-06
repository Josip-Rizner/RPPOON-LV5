using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace RPPOON_LV5
{
    class DataConsolePrinter
    {

        public DataConsolePrinter() { }
        
        public void PrintData(IDataset dataset)
        {
            ReadOnlyCollection<List<string>> data = dataset.GetData();

            if(data == null)
            {
                Exception exception = new Exception("Can't find data");
                throw exception;
            }
            else
            {
                for(int i=0; i < data.Count; i++)
                {
                    foreach(string dataPart in data[i])
                    {
                        Console.Write(dataPart + " ");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
