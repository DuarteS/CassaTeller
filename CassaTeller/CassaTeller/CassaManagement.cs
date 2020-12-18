using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassaTeller
{
    class CassaManagement
    {
        private readonly DBaccess DBaccess;
        public CassaManagement()
        {
            DBaccess = DBaccess.Instance;
            //CassaItem item = new CassaItem(DateTime.Now.AddDays(2), 1,12.3,true,"Test1");
            //CassaItem item2 = new CassaItem(DateTime.Now.AddDays(2), 1, 13.55, false, "Test2");
            //CassaItem item3 = new CassaItem(DateTime.Now.AddDays(2), 1, 1322.55, false, "This TRUE xxx");
            //CassaAddItem(item);
            //CassaAddItem(item2);
            //CassaAddItem(item3);
            //GetDayItems(DateTime.Now);
            DayDifference(DateTime.Now.AddDays(-3), DateTime.Now.AddDays(2));
        }

        public void CassaAddItem(CassaItem cassaItem)
        {
            if (cassaItem.InCassa)
            {
                DBaccess.UpdateDayCassa(cassaItem);
            }
            else
            {
                DBaccess.AddCassaItem(cassaItem);
            }
        }

        public double DayDifference(DateTime day1, DateTime day2)
        {
            if (!DateCassaCompleted(GetDayItems(day1)))
            {
                throw new Exception("Day 1 cassa not complete");
            }
            if (!DateCassaCompleted(GetDayItems(day2)))
            {
                throw new Exception("Day 2 cassa not complete");
            }

            bool bFirstCassa = false;
            bool bLastCassa = false;
            double dFirstCassa = 0.00;
            double dLastCassa = 0.00;
            double dOutCassa = 0.00;
            CassaItem[] itemRange = DBaccess.GetCassaItemRange(day1,day2);

            itemRange = SortItems(itemRange);

            foreach (CassaItem item in itemRange)
            {
                if (!bLastCassa)
                {
                    if (item.DateTime.Date == day1.Date && item.InCassa)
                    {
                        bFirstCassa = true;
                        dFirstCassa = item.Total;
                    }

                    if (bFirstCassa)
                    {
                        if (!item.InCassa)
                        {
                            dOutCassa += item.Total;
                        }else if (item.InCassa && item.DateTime.Date == day2.Date)
                        {
                            dLastCassa = item.Total;
                            bLastCassa = true;
                        }
                    }
                }
            }

            double dTotal =  (dLastCassa + dOutCassa) - dFirstCassa;


            return dTotal;
        }

        public CassaItem[] GetDayItems(DateTime day)
        {
            //get list of database items for this day
            List<CassaItem> cassaItems = DBaccess.GetCassaDayItems(day).ToList();

            //sort by time then return

            return SortItems(cassaItems.ToArray());

        }

        private CassaItem[] SortItems(CassaItem[] cassaItems)
        {
            List<CassaItem> SortedList = cassaItems.OrderBy(o => o.DateTime.Date).ThenBy(o => o.DateTime.TimeOfDay).ToList();

            return SortedList.ToArray();
        }
        

        public bool DateCassaCompleted(CassaItem[] cassaItems)
        {
            foreach (CassaItem cassaItem in cassaItems)
            {
                if (cassaItem.InCassa)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
