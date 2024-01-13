using MedicineInc.Shared.Domain;
using System.Collections.Generic;

public class CartService
{
    public List<Medicine> CartItems { get; set; } = new List<Medicine>();

    public void AddToCart(Medicine product)
    {
        CartItems.Add(product);
    }

    public void RemoveFromCart(Medicine product)
    {
        var existingProduct = CartItems.FirstOrDefault(item => item.Id == product.Id);

        if (existingProduct != null)
        {
            if (existingProduct.Count > 1)
            {
                existingProduct.Count--;
            }
            else
            {
                CartItems.Remove(existingProduct);
            }
        }
    }

    public void ClearCart()
    {
        CartItems.Clear();
    }
}
