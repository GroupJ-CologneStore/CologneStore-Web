using CologneStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ItemsController : Controller
{
    private readonly FirestoreService _firestoreService;

    public ItemsController()
    {
        // Initialize Firestore service
        _firestoreService = new FirestoreService();
    }

    public async Task<IActionResult> Index()
    {
        // Retrieve items from Firestore
        List<ItemModel> items = await _firestoreService.GetItemsAsync("Orders");

        // Pass the items to the view
        return View(items);
    }
}
