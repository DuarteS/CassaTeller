using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaTeller
{
    class KassaItem
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

        decimal total;
        public decimal Total
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

        bool inKassa;
        public bool InKassa
        {
            get
            {
                return inKassa;
            }
            private set
            {
                inKassa = value;
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

        public KassaItem(DateTime dateTime,int worker,decimal total,bool inKassa,string description)
        {
            DateTime = dateTime;
            Worker = worker;
            Total = total;
            InKassa = inKassa;
            Description = description;
        }
    }
}
