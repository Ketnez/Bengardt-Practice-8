using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengardt_Practice_8
{
    internal class Worker
    {
        public string First { get; set; }
        public string Second { get; set; }
        public string Patronymic { get; set; }

        public Worker(string first, string second, string patronymic)
        {
            First = first;
            Second = second;
            Patronymic = patronymic;
        }

        public string WorkerInformation()
        {
            return $"{First} {Second} {Patronymic}";
        }
    }
}
