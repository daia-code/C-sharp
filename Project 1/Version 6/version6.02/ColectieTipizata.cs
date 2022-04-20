using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class ColectieTipizata : CollectionBase
    {
        public ProdusAbstract this[int index]
        {
            get
            {
                return (ProdusAbstract)List[index];
            }
            set
            {
                List[index] = value;
            }
        }
        public void Add(ProdusAbstract value)
        {
            List.Add(value);
        }
        public int IndexOf(ProdusAbstract value)
        {
            return (List.IndexOf(value));
        }
        public void Insert(int index, ProdusAbstract value)
        {
            List.Insert(index, value);
        }
        public void Remove(ProdusAbstract value)
        {
            List.Remove(value);
        }
        public bool Contains(ProdusAbstract value)
        {
            return (List.Contains(value));
        }
    }
}
