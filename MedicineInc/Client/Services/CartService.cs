using MedicineInc.Shared.Domain;
using System.Collections.Generic;
namespace MedicineInc.Client.Services;
public class CartService
{
    public List<Medicine> CartItems { get; set; } = new List<Medicine>();

    public void AddToCart(Medicine medicine)
    {
        CartItems.Add(medicine);
    }

    public void RemoveFromCart(Medicine medicine)
    {
        var existingmedicine = CartItems.FirstOrDefault(item => item.Id == medicine.Id);

        if (existingmedicine != null)
        {
            if (existingmedicine.Count > 1)
            {
                existingmedicine.Count--;
            }
            else
            {
                CartItems.Remove(existingmedicine);
            }
        }
    }

    public void ClearCart()
    {
        CartItems.Clear();
    }
}
