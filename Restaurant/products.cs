using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseManangementProject
{
    class products
    {
        public string Name { get; set; }
        public decimal price { get; set; }
        public int Id { get; set; }
        
    }
    class number
    {
        public int no { get; set; }
    }
    class recipe
    {
        
        public int Amount_Piece { get; set; }
        public decimal Amount_KG { get; set; }
        public int Id_Material { get; set; }
    }
}
