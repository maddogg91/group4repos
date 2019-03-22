using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Ticket
    {
        public string T_id { get; set; }
        public string Status { get; set; }
        public string E_id { get; set; }
        public string Priority { get; set; }
        public string Task { get; set; }
        public string C_id { get; set; }
        public string Date_created { get; set; }
        public Ticket(string id, string status, string employee, string priority, string task, string customer, string date)
        {
            T_id = id;
            Status = status;
            E_id = employee;
            Priority = priority;
            Task = task;
            C_id = customer;
            Date_created = date;
        }
        //Creates primary key for Ticket
        public static string GeneratePrimaryKey()
        {
            Random rand = new Random();
            int num = rand.Next(0, 99999);
            string pk = num.ToString("D5");
            return pk;
        }
        //Create Default ticket when submit ticket is selected

        //Selects the status of the ticket
        public static string SelectStatus()
        {
            string status;
            bool run = false;

            if (run == true)
            {
                status = "closed";
            }

            else
            {
                status = "open";

            }
            switch (status)
            {
                case "closed":
                    {
                        string closed = "closed";
                        return closed;

                    }
                case "resolved":
                    {
                        string resolved = "resolved";
                        return resolved;
                    }
                default:
                    {
                        string open = "open";
                        return open;

                    }
            }
        }


    }
}
