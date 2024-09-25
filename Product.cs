using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productmanager
{
    public class Product
    {
        private int proId;
        private string? proName;
        private double proPrice;

        public Product(){}
        public Product(int proId, string proName, double proPrice)
        {
            this.proId = proId;
            this.proName = proName;
            this.proPrice = proPrice;
        }    
        public int ProId { get => proId; set => proId = value;}
        public string? ProName { get => proName; set => proName = value;}

        public double ProPrice { get => proPrice; set => proPrice = value;}
    }
}