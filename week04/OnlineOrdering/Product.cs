/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W04 Online Ordering Programn - Product Class
    
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

/// <summary>
/// Represents a product in an order.
/// Responsibility: store product data and compute its total cost (price * quantity).
/// </summary>
class Product
{
    // Private backing fields (encapsulation)
    private string _name;
    private string _productId;
    private decimal _pricePerUnit;
    private int _quantity;

    // Public properties for controlled access
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(Name));
    }

    public string ProductId
    {
        get => _productId;
        set => _productId = value ?? throw new ArgumentNullException(nameof(ProductId));
    }

    public decimal PricePerUnit
    {
        get => _pricePerUnit;
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(PricePerUnit), "Price cannot be negative.");
            _pricePerUnit = value;
        }
    }

    public int Quantity
    {
        get => _quantity;
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(Quantity), "Quantity cannot be negative.");
            _quantity = value;
        }
    }

    // Constructor to initialize all required fields
    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        Name = name;
        ProductId = productId;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    /// <summary>
    /// Calculates the total cost for this product (price per unit * quantity).
    /// </summary>
    public decimal GetTotalCost()
    {
        return PricePerUnit * Quantity;
    }
}
