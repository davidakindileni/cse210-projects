/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W04 Online Ordering Programn - Customer Class
    
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

/// <summary>
/// Represents a customer with a name and an Address object.
/// Responsibility: report whether the customer lives in the USA (delegates to Address).
/// </summary>
class Customer
{
    private string _name;
    private Address _address;

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(Name));
    }

    public Address Address
    {
        get => _address;
        set => _address = value ?? throw new ArgumentNullException(nameof(Address));
    }

    // Constructor
    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    /// <summary>
    /// Returns true if the customer's address is in the USA.
    /// Delegates to Address.IsInUSA().
    /// </summary>
    public bool LivesInUSA()
    {
        return Address.IsInUSA();
    }
}
