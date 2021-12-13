using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengardt_Practice_8
{
    class FAMworker : Worker, ICloneable, IHuman, Icomparison
    {
        public FAMworker(string firstname, string secondname, string patronymic) : base(firstname, secondname, patronymic)
        {
            First = firstname;
            Second = secondname;
            Patronymic = patronymic;
        }

        public bool CompareTo(object worker)
        {
            FAMworker firstworker = (FAMworker)worker;
            if (Second == firstworker.Second)
            {
                return true;
            }
            else
                return false;
        }

        public FAMworker ShallowClone()
        {
            return (FAMworker)this.MemberwiseClone();
        }

        public object Clone()
        {
            return new FAMworker(First, Second, Patronymic);
        }

        public string ShowInfoOfFamilyWorker()
        {
            return WorkerInformation();
        }

        public string WorkerFamilyInformation()
        {
            throw new NotImplementedException();
        }

        public bool Comparison(object worker)
        {
            throw new NotImplementedException();
        }
    }
}