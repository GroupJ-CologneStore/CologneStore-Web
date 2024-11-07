using CologneStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace CologneStore.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly FirestoreService _firestoreService;

        public ReviewsController()
        {
            // Initialize Firestore service
            _firestoreService = new FirestoreService();
        }
        public async Task<IActionResult> Index()
        {
            // Retrieve items from Firestore
            List<ReviewModel> reviews = await _firestoreService.GetReviewsAsync("Reviews");

            // Pass the items to the view
            return View(reviews);
        }
    }
}
