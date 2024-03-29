﻿using Models.Shopping;

namespace SampleData;

public static class Shopping
{
    public static List<Customer> GetCustomers()
    {
        return
        [
            new("Normal Customer1"),
            new("Normal Customer2"),
            new("Normal Customer3"),
            new("Normal Customer4"),
            new VIPCustomer("VIP1", EnMembershipType.Bronze),
            new VIPCustomer("VIP2", EnMembershipType.CIP),
            new ForeignCustomer("Ching Chang", EnMembershipType.Gold, "CHINA")
        ];
    }


    public static List<Product> GetProducts()
    {
        return
        [
            new Product { Title = "Title1", Price = 1000 },
            new Product { Title = "Title2", Price = 2000 },
            new Product { Title = "Title3", Price = 3000 },
            new Product { Title = "Title4", Price = 4000 },
        ];
    }


    public static List<Order> GetOrders()
    {
        return
        [
            new()
            {
                CustomerObject = GetCustomers()[0],
                OrderDate = DateTime.Now,
                OrderDetails =
                   [
                       new OrderDetail
                       {
                           ProductObject = GetProducts()[0],
                           Qty = 1
                       }
                   ]
            },
            new Order
            {
                CustomerObject = GetCustomers()[1],
                OrderDate = DateTime.Now,
                OrderDetails =
                   [
                       new OrderDetail
                       {
                           ProductObject = GetProducts()[0],
                           Qty = 1
                       },
                       new OrderDetail
                       {
                           ProductObject = GetProducts()[1],
                           Qty = 2
                       }
                   ]
            },

            new Order
            {
                CustomerObject = GetCustomers()[3],
                OrderDate = DateTime.Now,
                OrderDetails =
                   [
                       new OrderDetail
                       {
                           ProductObject = GetProducts()[3],
                           Qty = 100
                       },
                       new OrderDetail
                       {
                           ProductObject = GetProducts()[2],
                           Qty = 100
                       }
                   ]
            },

            new Order
            {
                CustomerObject = GetCustomers()[4],
                OrderDate = DateTime.Now,
                OrderDetails =
                   [
                       new OrderDetail
                       {
                           ProductObject = GetProducts()[3],
                           Qty = 100
                       },
                       new OrderDetail
                       {
                           ProductObject = GetProducts()[2],
                           Qty = 100
                       }
                   ]
            },

            new Order
            {
                CustomerObject = GetCustomers()[5],
                OrderDate = DateTime.Now,
                OrderDetails =
                   [
                       new OrderDetail
                       {
                           ProductObject = GetProducts()[3],
                           Qty = 100
                       },
                       new OrderDetail
                       {
                           ProductObject = GetProducts()[2],
                           Qty = 100
                       }
                   ]
            },

            new Order
            {
                CustomerObject = GetCustomers()[6],
                OrderDate = DateTime.Now,
                OrderDetails =
                   [
                       new OrderDetail
                       {
                           ProductObject = GetProducts()[3],
                           Qty = 100
                       },
                       new OrderDetail
                       {
                           ProductObject = GetProducts()[2],
                           Qty = 100
                       }
                   ]
            },
        ];
    }

}
