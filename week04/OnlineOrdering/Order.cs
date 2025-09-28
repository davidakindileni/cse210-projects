/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W04 Online Ordering Programn - Order Class
    
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

/// <summary>
/// Represents an order containing a list of products and a customer.
/// Responsibilities:
/// - calculate total cost (sum of products + one-time shipping).
/// - return packing label (product name and id).
/// - return shipping label (customer name and address).
/// </summary>
class Order
{
    // Private backing fields
    private List<Product> _products;
    private Customer _customer;

    // Constants for shipping cost rules
    private const decimal ShippingCostDomestic = 5.00m;
    private const decimal ShippingCostInternational = 35.00m;

    // Public read-only accessors for products and customer
    public IReadOnlyList<Product> Products => _products.AsReadOnly();
    public Customer Customer => _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer ?? throw new ArgumentNullException(nameof(customer));
        _products = new List<Product>();
    }

    /// <summary>
    /// Adds a product to this order.
    /// </summary>
    public void AddProduct(Product product)
    {
        if (product == null) throw new ArgumentNullException(nameof(product));
        _products.Add(product);
    }

    /// <summary>
    /// Calculates the one-time shipping cost based on whether the customer lives in the USA.
    /// </summary>
    private decimal CalculateShippingCost()
    {
        return Customer.LivesInUSA() ? ShippingCostDomestic : ShippingCostInternational;
    }

    /// <summary>
    /// Calculates the total price: sum of each product's total cost (price * qty) plus one-time shipping.
    /// </summary>
    public decimal CalculateTotalPrice()
    {
        decimal subtotal = 0m;
        foreach (var p in _products)
        {
            subtotal += p.GetTotalCost();
        }

        decimal shipping = CalculateShippingCost();
        return subtotal + shipping;
    }

    /// <summary>
    /// Builds and returns the packing label string.
    /// The packing label lists each product's name and product id.
    /// Example:
    /// Packing Label:
    /// - Book (ID: B001)
    /// - Pen (ID: P002)
    /// </summary>
    public string GetPackingLabel()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Packing Label:");
        foreach (var p in _products)
        {
            sb.AppendLine($"- {p.Name} (ID: {p.ProductId})");
        }
        return sb.ToString().TrimEnd();
    }

    /// <summary>
    /// Builds and returns the shipping label.
    /// The shipping label includes the customer's name followed by the address lines.
    /// </summary>
    public string GetShippingLabel()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Shipping Label:");
        sb.AppendLine(Customer.Name);
        sb.AppendLine(Customer.Address.ToString());
        return sb.ToString().TrimEnd();
    }
}
