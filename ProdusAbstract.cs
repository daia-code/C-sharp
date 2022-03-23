﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
    public abstract class ProdusAbstract
    {
        private long Id;
        private String Nume;
        private String CodIntern;

        public long Id1 { get => Id; set => Id = value; }
        public string Nume1 { get => Nume; set => Nume = value; }
        public string CodIntern1 { get => CodIntern; set => CodIntern = value; }

        public ProdusAbstract(long unId, string unNume, string unCodIntern)
        {
            this.Id1 = unId;
            this.Nume1 = unNume;
            this.CodIntern1 = unCodIntern;
        }
        public abstract void Descriere();
        public virtual void AltaDescriere()
        {
          
        }
    }
}
