using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emissions
{
    public class Document
    {
        private DateTime date;
        public string name { get; set; }
        private User u;
        private List<ICalc> list;
        
        public void Print()
        {
            //create pdf
            //
        }
        void AddCalc(ICalc calc)
        {
            list.Add(calc);
        }
        void SetUser(User user)
        {
            u = user;
        }
        void Clear()
        {
            list.Clear();
            u = null;
            name = null;

        }
    }
}
