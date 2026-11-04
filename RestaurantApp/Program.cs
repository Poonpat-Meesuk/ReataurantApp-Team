using RestaurantApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Restaurant
    {
        public string type { get; set; }
        public double score { get; set; }
        public int id { get; set; }              
    }
    public Restaurant(string type, double score, int id)
        {
            this.type = type;
            this.score = score;
            this.id = id;
            this.type = type;
        }
    public void เพิ่มข้อมูล()
        {
            Console.WriteLine($"รหัส:{id} | ประเภท: {type} | คะแนน: {score}");
        }

    public void Main(string[] args)
        {
            List<Restaurant> restaurantslist = new List<Restaurant>();
        }
    }
}
