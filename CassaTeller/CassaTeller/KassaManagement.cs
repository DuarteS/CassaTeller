using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaTeller
{
    class KassaManagement
    {
        private readonly DBaccess DBaccess;
        public KassaManagement()
        {
            DBaccess = DBaccess.Instance;
            //KassaItem item = new KassaItem(DateTime.Now.AddDays(2), 1,12.3m,true,"Test1");
            //KassaItem item2 = new KassaItem(DateTime.Now.AddDays(2), 1, 13.55, false, "Test2");
            //KassaItem item3 = new KassaItem(DateTime.Now.AddDays(2), 1, 1322.55, false, "duarte");
            //KassaAddItem(item);
            //KassaAddItem(item2);
            //KassaAddItem(item3);
            //GetDayItems(DateTime.Now);
            //DayDifference(DateTime.Now, DateTime.Now.AddDays(1));
        }

        public void KassaAddItem(KassaItem cassaItem)
        {
            if (cassaItem.InKassa)
            {
                DBaccess.UpdateDayKassa(cassaItem);
            }
            else
            {
                DBaccess.AddKassaItem(cassaItem);
            }
        }

        public decimal DayDifference(DateTime day1, DateTime day2)
        {
            if (!DateKassaCompleted(GetDayItems(day1)))
            {
                throw new Exception("Day 1 cassa not complete");
            }
            if (!DateKassaCompleted(GetDayItems(day2)))
            {
                throw new Exception("Day 2 cassa not complete");
            }

            bool bFirstKassa = false;
            bool bLastKassa = false;
            decimal dFirstKassa = 0;
            decimal dLastKassa = 0;
            decimal dOutKassa = 0;
            KassaItem[] itemRange = DBaccess.GetKassaItemRange(day1,day2);

            itemRange = SortItems(itemRange);

            foreach (KassaItem item in itemRange)
            {
                if (!bLastKassa)
                {
                    if (item.DateTime.Date == day1.Date && item.InKassa)
                    {
                        bFirstKassa = true;
                        dFirstKassa = item.Total;
                    }

                    if (bFirstKassa)
                    {
                        if (!item.InKassa)
                        {
                            dOutKassa += item.Total;
                        }else if (item.InKassa && item.DateTime.Date == day2.Date)
                        {
                            dLastKassa = item.Total;
                            bLastKassa = true;
                        }
                    }
                }
            }

            decimal dTotal =  (dLastKassa + dOutKassa) - dFirstKassa;


            return dTotal;
        }

        public KassaItem[] GetDayItems(DateTime day)
        {
            //get list of database items for this day
            List<KassaItem> cassaItems = DBaccess.GetKassaDayItems(day).ToList();

            //sort by time then return

            return SortItems(cassaItems.ToArray());

        }

        private KassaItem[] SortItems(KassaItem[] cassaItems)
        {
            List<KassaItem> SortedList = cassaItems.OrderBy(o => o.DateTime.Date).ThenBy(o => o.DateTime.TimeOfDay).ToList();

            return SortedList.ToArray();
        }
        

        public bool DateKassaCompleted(KassaItem[] cassaItems)
        {
            foreach (KassaItem cassaItem in cassaItems)
            {
                if (cassaItem.InKassa)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
