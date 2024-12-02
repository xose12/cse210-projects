using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double TotalPrice()
    {
        double totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.TotalCost();
        }

        double shippingCost = customer.LivesInUSA() ? 5.00 : 35.00;
        return totalCost + shippingCost;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in products)
        {
            label += $"{product.GetName()} (Product ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        string label = $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().FullAddress()}";
        return label;
    }
}
