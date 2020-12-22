using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaTeller
{
    class WorkerManagment
    {
        private readonly DBaccess DBaccess;

        public WorkerManagment()
        {
            DBaccess = DBaccess.Instance;
        }

        public Worker[] GetWorkers()
        {
            return DBaccess.GetWorkers();
        }

        public void AddWorker(string firstName,string lastName)
        {
            DBaccess.addWorker(firstName, lastName);
        }

        public Worker GetWorkerByID(int ID)
        {
            return DBaccess.GetWorkerByID(ID);
        }

        public void WorkerUpdateInfo(int id,string firstName,string lastName)
        {
            DBaccess.UpdateWorkerInfo(id,firstName,lastName);
        }
    }
}
