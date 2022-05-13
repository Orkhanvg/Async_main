using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    internal class User
    {



      
        public int Id { get; set; }
        List<Status> Statuses;
        public User()
        {
            Statuses = new List<Status>();
        }

        public void ShareStatus(Status status)
        {

            Statuses.Add(status);   
        }
      
        public void GetStatusById(int ? id)
        {
            foreach (var item in Statuses)
            {
                if (id==item.Id)
                {
                    item.GetStatusInfo();
                }

            }

        }
      
        public void GetAllStatuses()
        {
            foreach (var item in Statuses)
            {
                //Statuses.Find(id => id == item.id);
            }
            
        }
        
            public void FilterStatusByDate(int ? id , DateTime date)
        { date= DateTime.Now;

            foreach (var item in Statuses)
            {
                if (date>item.SharedDate)
                {
                    item.GetStatusInfo();

                }

            }
           
        } 





    }
}
