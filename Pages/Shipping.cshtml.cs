using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;  
using myfirstproject.Models;

namespace myfirstproject.Pages
{
    public class ShippingModel : PageModel
    {
        public ShippingModel(ShippingDBContext shippingcontext)
        {
            _shippingdbcontext = shippingcontext;
        }

        //create property for DBContext instance
        private readonly ShippingDBContext _shippingdbcontext;


        [BindProperty]
        public Shipping Shipping { get; set; }

        public List<Shipping> Shippings = new List<Shipping>();
            
        public void OnGet()
        {
            Shippings = _shippingdbcontext.Shippings.ToList();
        }
        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                Shippings = _shippingdbcontext.Shippings.ToList();
                return Page();
            }
            _shippingdbcontext.Shippings.Add(Shipping);
            _shippingdbcontext.SaveChanges();
            return Redirect("/index");  
        }
    }
}
