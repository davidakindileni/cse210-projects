/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W04 Online Ordering Programn - Address Class
    
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

/// <summary>
/// Represents a customer's address.
/// Responsibility: store address fields, return combined address string, and tell whether it is in the USA.
/// </summary>
class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public string Street
    {
        get => _street;
        set => _street = value ?? throw new ArgumentNullException(nameof(Street));
    }

    public string City
    {
        get => _city;
        set => _city = value ?? throw new ArgumentNullException(nameof(City));
    }

    public string StateOrProvince
    {
        get => _stateOrProvince;
        set => _stateOrProvince = value ?? throw new ArgumentNullException(nameof(StateOrProvince));
    }

    public string Country
    {
        get => _country;
        set => _country = value ?? throw new ArgumentNullException(nameof(Country));
    }

    // Constructor
    public Address(string street, string city, string stateOrProvince, string country)
    {
        Street = street;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    /// <summary>
    /// Returns true if the address is in the USA. This method is made robust by accepting
    /// common variants such as "USA", "US", "United States", "United States of America".
    /// Comparison is case-insensitive and whitespace-trimmed.
    /// </summary>
    public bool IsInUSA()
    {
        string normalized = (Country ?? string.Empty).Trim().ToLowerInvariant();
        return normalized == "usa"
                || normalized == "us"
                || normalized == "united states"
                || normalized == "united states of america"
                || normalized == "u.s.a."
                || normalized == "u.s.";
    }

    /// <summary>
    /// Returns a multi-line string containing the full address (suitable for a shipping label).
    /// Example:
    /// 123 Main St
    /// Anytown, WA
    /// USA
    /// </summary>
    public override string ToString()
    {
        // Format: Street \n City, StateOrProvince \n Country
        return $"{Street}\n{City}, {StateOrProvince}\n{Country}";
    }
}
