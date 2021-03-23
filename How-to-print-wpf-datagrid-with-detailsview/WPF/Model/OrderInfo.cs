
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SfDataGridDemo
{
public class OrderInfo
{
    int orderID;
    string customerId;
    string country;
    string customerName;
    string shippingCity;
    List<ProductInfo> productDetails;
        

    public int OrderID
    {
        get { return orderID; }
        set { orderID = value; }
    }

    public string CustomerID
    {
        get { return customerId; }
        set { customerId = value; }
    }

    public string CustomerName
    {
        get { return customerName; }
        set { customerName = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string ShipCity
    {
        get { return shippingCity; }
        set { shippingCity = value; }
    }

    public List<ProductInfo> ProductDetails
    {
        get { return productDetails; }
        set { productDetails = value; }
    }
    public OrderInfo(int orderId, string customerName, string country, string
    customerId, string shipCity, List<ProductInfo> productdetails)
    {
        this.OrderID = orderId;
        this.CustomerName = customerName;
        this.Country = country;
        this.CustomerID = customerId;
        this.ShipCity = shipCity;
        this.ProductDetails = productdetails;
    }
}

}
