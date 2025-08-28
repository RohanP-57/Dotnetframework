using System;
using System.Collections.Generic;
using System.IO;

namespace billgenerate
{
    public delegate void PrintSection();
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPrice => Price * Quantity;
    }
    public class Customer
    {
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Country { get; set; }

        public string GetAddress()
        {
            return $"Shipping Address:\n{Name}\n{AddressLine1}\n{AddressLine2}\n{Country}\n";
        }
    }

    public class Order
    {
        public string OrderId { get; set; }
        public string PlacedBy { get; set; }
        public string PaidBy { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public string PaymentMethod { get; set; }
        public List<Item> Items { get; set; }
        public Customer Customer { get; set; }

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.TotalPrice;
            }
            return total;
        }

        public void PrintBill()
        {
            Console.WriteLine(GetBillText());
        }

        public string GetBillText()
        {
            string bill = "";
            bill += "Amazon.com\n";
            bill += "------------------------------------------------------------\n";
            bill += $"Final Details for Order #{OrderId}\n\n";
            bill += $"Paid By: {PaidBy}\n";
            bill += $"Placed By: {PlacedBy}\n";
            bill += $"Order Placed: {OrderDate:MMMM dd, yyyy}\n";
            bill += $"Amazon.com order number: {OrderId}\n";
            bill += $"Order Total: ${GetTotal()}\n";
            bill += "------------------------------------------------------------\n";
            bill += $"Shipped on {ShipDate:MMMM dd, yyyy}\n\n";

            bill += "Items Ordered:\n";
            foreach (var item in Items)
            {
                bill += $"{item.Quantity} of: {item.Name}\n";
                bill += $"Price: ${item.Price}\n\n";
            }

            bill += Customer.GetAddress();
            bill += "------------------------------------------------------------\n";
            bill += "Shipping Speed: One-Day Shipping\n\n";
            bill += $"Item(s) Subtotal:   ${GetTotal()}\n";
            bill += "Shipping & Handling: $0.00\n";
            bill += $"Total before tax:   ${GetTotal()}\n";
            bill += "Sales Tax:           $0.00\n";
            bill += "------------------------------------------------------------\n";
            bill += $"Total for This Shipment: ${GetTotal()}\n\n";

            bill += "Payment Information:\n";
            bill += $"Payment Method: {PaymentMethod}\n";
            bill += "------------------------------------------------------------\n";
            bill += $"Grand Total: ${GetTotal()}\n";

            return bill;
        }
        public void SaveBillToFile(string filePath)
        {
            File.WriteAllText(filePath, GetBillText());
            Console.WriteLine($"✅ Bill saved to file: {filePath}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                OrderId = "113-6135300",
                PlacedBy = "TortolaExpress",
                PaidBy = "AeropostEIS",
                OrderDate = new DateTime(2020, 3, 10),
                ShipDate = new DateTime(2020, 3, 11),
                PaymentMethod = "MasterCard | Last digits: XXXX",
                Items = new List<Item>
                {
                    new Item
                    {
                        Name = "JEEUE 1/4\" to 3.5mm Headphones Adapter for Audio Connector Cables, " +
                               "Upgrade 6.35mm(1/4\") Male - 3.5mm Female Socket Stereo Pure Copper Jack Adaptor Bring You Professional Sound (RED-1PCS)",
                        Price = 5.68m,
                        Quantity = 1
                    }
                },
                Customer = new Customer
                {
                    Name = "Colin Rathbun",
                    AddressLine1 = "1 AEROPOST WAY EIS-",
                    AddressLine2 = "MIAMI, FL 33206-3206",
                    Country = "United States"
                }
            };
            order.PrintBill();
            string filePath = "AmazonOrderBill.txt";
            order.SaveBillToFile(filePath);
            Console.ReadLine();
        }
    }
}
