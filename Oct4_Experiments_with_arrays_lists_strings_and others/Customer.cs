﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Customer
{
    public int Id;
    public string Name;
    public List<Order> Orders;
    public Customer()
    {
        Orders = new List<Order>();
    }
    public Customer(int id) : this() // here this is used to specify any
                                     // of the other constructors
    {
        this.Id = id;

    }

    public Customer(int id, string name) : this(id)
    {
        this.Id = id;
        this.Name = name;
    }

}
