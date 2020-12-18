using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassaTeller
{
    class CassaItem
    {
        DateTime dateTime;
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Date or time cant be null");
                }
                dateTime = value;
            }
        }

        int worker;
        public int Worker
        {
            get
            {
                return worker;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Worker id cant be lower that 0");
                }
                worker = value;
            }
        }

        double total;
        public double Total
        {
            get
            {
                return total;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Total cant be negitave");
                }
                total = value;
            }
        }

        bool inCassa;
        public bool InCassa
        {
            get
            {
                return inCassa;
            }
            private set
            {
                inCassa = value;
            }
        }

        string description;
        public string Description
        {
            get
            {
                return description;
            }
            private set
            {
                description = value;
            }
        }

        public CassaItem(DateTime dateTime,int worker,double total,bool inCassa,string description)
        {
            DateTime = dateTime;
            Worker = worker;
            Total = total;
            InCassa = inCassa;
            Description = description;
        }
    }
}
