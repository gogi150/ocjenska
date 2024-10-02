using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocjenska
{
    internal class Lista
    {
        string Model;
        int Godina, BrojKotača;

        public Lista() { }

        public Lista(string Model, int Godina, int BrojKotača) {
        
            this.Model1 = Model;
            this.Godina1 = Godina;
            this.BrojKotača1 = BrojKotača;
        }

        public string Model1 { get => Model; set => Model = value; }
        public int Godina1 { get => Godina; set => Godina = value; }
        public int BrojKotača1 { get => BrojKotača; set => BrojKotača = value; }

        public override string ToString()
        {
            string ispis = $"{this.Model}, {this.Godina}, {this.BrojKotača}";
            return base.ToString();
        }
    }
    }


