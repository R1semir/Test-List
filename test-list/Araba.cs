using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_list
{
    internal class Araba
    {
        string Model;
        int Yıl;
        int maxhız;
        string Paket;
        string Vites;

        public string MODEL
        {
            get { return Model; }
            set { Model = value; }
        }
        public int YİL
        {
            get { return Yıl; }
            set { Yıl = value; }
        }
        public int MAXH
        {
            get { return maxhız; }
            set { maxhız = value; }
        }
        public string paket
        {
            get { return Paket; }
            set { Paket = value; }
        }
        public string VITES
        {
            get { return Vites; }
            set { Vites = value; }
        }

    }
}
