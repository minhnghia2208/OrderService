﻿namespace OrderService.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public void tostring()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Amount: " + Amount);
        }
    }
}
