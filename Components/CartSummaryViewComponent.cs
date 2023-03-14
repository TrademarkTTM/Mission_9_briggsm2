using Microsoft.AspNetCore.Mvc;
using Mission_9_briggsm2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_9_briggsm2.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart; 

        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
