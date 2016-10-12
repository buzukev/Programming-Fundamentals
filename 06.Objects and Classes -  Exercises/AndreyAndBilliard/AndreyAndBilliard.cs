using System;
using System.Collections.Generic;
using System.Linq;


public class AndreyAndBilliard
{
    public static void Main()
    {
        Dictionary<string, decimal> productsPrice = new Dictionary<string, decimal>();
        int productsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < productsCount; i++)
        {
            string[] input = Console.ReadLine().Split('-');
            string productName = input[0];
            decimal productPrice = decimal.Parse(input[1]);

            if (!productsPrice.ContainsKey(productName))
            {
                productsPrice.Add(productName, productPrice);
            }
            productsPrice[productName] = productPrice;
        }

        string inputLine = Console.ReadLine();

        List<Customer> customers = new List<Customer>();

        while (!inputLine.Equals("end of clients"))
        {
            string[] customerInfo = inputLine.Split('-', ',');
            string customerName = customerInfo[0];
            string customerProduct = customerInfo[1];
            int quantity = int.Parse(customerInfo[2]);

            if (!productsPrice.ContainsKey(customerProduct))
            {
                inputLine = Console.ReadLine();
                continue;
            }

            if (customers.Any(x => x.Name == customerName))
            {
                Customer customer = customers.First(x => x.Name == customerName);

                if (!customer.OrdersPrice.ContainsKey(customerProduct))
                {
                    customer.OrdersPrice.Add(customerProduct, quantity);
                }
                else
                {
                    customer.OrdersPrice[customerProduct] += quantity;
                }

                customer.Bill += quantity * productsPrice[customerProduct];
            }

            else
            {
                Customer customer = new Customer();
                customer.Name = customerName;
                customer.OrdersPrice = new Dictionary<string, int>();
                customer.OrdersPrice.Add(customerProduct, quantity);
                customer.Bill += quantity * productsPrice[customerProduct];
                customers.Add(customer);
            }

            inputLine = Console.ReadLine();
        }

        foreach (Customer customer in customers.OrderBy(x => x.Name))
        {
            Console.WriteLine(customer.Name);

            foreach (KeyValuePair<string, int> cutomerOrderes in customer.OrdersPrice)
            {
                Console.WriteLine($"-- {cutomerOrderes.Key} - {cutomerOrderes.Value}");
            }
            Console.WriteLine($"Bill: {customer.Bill:f2}");
        }
        decimal totalBill = customers.Sum(x => x.Bill);
        Console.WriteLine($"Total bill: {totalBill:f2}");
    }
    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> OrdersPrice { get; set; }
        public decimal Bill { get; set; }
    }
}