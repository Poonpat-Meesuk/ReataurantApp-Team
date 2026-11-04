using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantApp
{
    internal class Program
    {
        public class Restaurant
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public double Rating { get; set; }


            public Restaurant(int id, string name, string type, double rating)
            {
                Id = id;
                Name = name;
                Type = type;
                Rating = rating;
            }
        }


        static void Main(string[] args)
        {
            List<Restaurant> restaurants = new List<Restaurant>
            {
            new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
            new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
            new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
            new Restaurant(4, "Haidilao Hot Pot", "Hot Pot", 4.8),
            new Restaurant(5, "Peking Garden", "Chinese Cuisine", 4.4)
            };


            foreach (Restaurant restaurant in restaurants)
            {
                Console.WriteLine(
                    $"รหัส: {restaurant.Id}, " +
                    $"ชื่อ: {restaurant.Name}, " +
                    $"ประเภท: {restaurant.Type}, " +
                    $"คะแนน: {restaurant.Rating}");
            }


            Console.WriteLine("------------------------------");


            Console.WriteLine($"จำนวนร้านทั้งหมด: {restaurants.Count}");


            double averageRating = 0;


            if (restaurants.Count > 0)
            {
                double totalRating = 0;


                foreach (Restaurant restaurant in restaurants)
                {
                    totalRating += restaurant.Rating;
                }


                averageRating = totalRating / restaurants.Count;
            }


            Console.WriteLine($"คะแนนเฉลี่ย: {averageRating:F2}");
            Console.WriteLine("โปรแกรมจัดการร้านอาหารเสร็จสมบูรณ์แล้ว");


        }
    }
}