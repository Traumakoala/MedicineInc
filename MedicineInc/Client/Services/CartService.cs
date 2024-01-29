using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicineInc.Shared.Domain;

public class CartService
{
    private List<Cart> carts = new List<Cart>();

    public async Task<List<Cart>> GetCartsAsync()
    {
        return await Task.FromResult(carts);
    }

    public async Task AddToCartAsync(int customerId, Medicine medicine, int count)
    {
        var cart = carts.FirstOrDefault(c => c.CustomerId == customerId);

        if (cart == null)
        {
            cart = new Cart { CustomerId = customerId, CartItems = new List<Medicine>() };
            carts.Add(cart);
        }

        var existingCartItem = cart.CartItems.FirstOrDefault(m => m.Id == medicine.Id);

        if (existingCartItem != null)
        {
            existingCartItem.Count += count;
        }
        else
        {
            // Use a deep copy to avoid modifying the original medicine object
            var newCartItem = new Medicine
            {
                Id = medicine.Id,
                MediName = medicine.MediName,
                Price = medicine.Price,
                feat = medicine.feat,
                Count = count,
                Usage = medicine.Usage,
                ImageRef = medicine.ImageRef
            };
            cart.CartItems.Add(newCartItem);
        }
    }

    public async Task RemoveFromCartAsync(int customerId, int medicineId)
    {
        var cart = carts.FirstOrDefault(c => c.CustomerId == customerId);

        if (cart != null)
        {
            var cartItemToRemove = cart.CartItems.FirstOrDefault(m => m.Id == medicineId);

            if (cartItemToRemove != null)
            {
                cart.CartItems.Remove(cartItemToRemove);
            }
        }
    }

    public async Task ClearCartAsync(int customerId)
    {
        var cart = carts.FirstOrDefault(c => c.CustomerId == customerId);

        if (cart != null)
        {
            cart.CartItems.Clear();
        }
    }
}
