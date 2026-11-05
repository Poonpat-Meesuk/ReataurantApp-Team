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

            ShowAllRestaurants(restaurants);
            ShowStatistics(restaurants);

            AddRestaurant(restaurants);        // A
            ShowGoodRating(restaurants);       // B
            ShowSummary(restaurants);          // C

            Console.WriteLine("โปรแกรมจัดการร้านอาหารเสร็จสมบูรณ์แล้ว");
        }

        static void ShowAllRestaurants(List<Restaurant> restaurants)
        {
            foreach (Restaurant restaurant in restaurants)
            {
                Console.WriteLine(
                    $"รหัส: {restaurant.Id}, " +
                    $"ชื่อ: {restaurant.Name}, " +
                    $"ประเภท: {restaurant.Type}, " +
                    $"คะแนน: {restaurant.Rating}");
            }

            Console.WriteLine("------------------------------");
        }

        static void ShowStatistics(List<Restaurant> restaurants)
        {
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
            Console.WriteLine("------------------------------");
        }
        static void AddRestaurant(List<Restaurant> restaurants)
        {
            Console.WriteLine("=== เพิ่มร้านอาหารใหม่ ===");

            string name;
            do
            {
                Console.Write("ชื่อร้าน: ");
                name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("ชื่อร้านห้ามว่าง");
                }
            } while (string.IsNullOrWhiteSpace(name));

            string type;
            do
            {
                Console.Write("ประเภท: ");
                type = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(type))
                {
                    Console.WriteLine("ประเภทห้ามว่าง");
                }
            } while (string.IsNullOrWhiteSpace(type));

            double rating;
            while (true)
            {
                Console.Write("คะแนน (0-5): ");
                if (double.TryParse(Console.ReadLine(), out rating) && rating >= 0 && rating <= 5)
                {
                    break;
                }
                Console.WriteLine("กรุณากรอกตัวเลข 0 ถึง 5");
            }

            int newId = restaurants.Count > 0 ? restaurants.Max(r => r.Id) + 1 : 1;
            restaurants.Add(new Restaurant(newId, name, type, rating));

            Console.WriteLine($"เพิ่มร้าน \"{name}\" เรียบร้อยแล้ว (รหัส {newId})");
            Console.WriteLine("------------------------------");
        }
        //B
        static void ShowGoodRating(List<Restaurant> restaurants)
        {
            Console.WriteLine("=== ร้านที่คะแนนตั้งแต่ 4.5 ขึ้นไป ===");


            int count = 0;


            foreach (Restaurant restaurant in restaurants)
            {
                if (restaurant.Rating >= 4.5)
                {
                    Console.WriteLine(
                        $"รหัส: {restaurant.Id}, " +
                        $"ชื่อ: {restaurant.Name}, " +
                        $"ประเภท: {restaurant.Type}, " +
                        $"คะแนน: {restaurant.Rating}");
                    count++;
                }
            }


            if (count == 0)
            {
                Console.WriteLine("ไม่พบร้านที่คะแนนตั้งแต่ 4.5 ขึ้นไป");
            }
            else
            {
                Console.WriteLine($"พบทั้งหมด {count} ร้าน");
            }


            Console.WriteLine("------------------------------");
        }
        //C
        static void ShowSummary(List<Restaurant> restaurants)
        {
        }
    }
}