using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    internal class Status
    {
       
        private static int  _id;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
       
        private DateTime _shareddata;
        public DateTime SharedDate { get; set; }

        public Status()
        {
     SharedDate = DateTime.Now;


        }

        public void GetStatusInfo()
        {
            Console.WriteLine($"{Title}: test tittle\n" +
                $"{Content} : test content {SharedDate.Second}  ");

        }
       
        public Status(string title , string content)
        {
            Title = title; Content = content;
            _id++;
        }





    }
}
