using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Identity.Pages.Account
{
    public class Register : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public Register(
            UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
            [Display(Name = "First name")]
            public string FirstName { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
            [Display(Name = "Middle name")]
            public string MiddleName { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
            [Display(Name = "Last name")]
            public string LastName { get; set; }

            [Required]
            [StringLength(10, ErrorMessage = " The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
            [Display(Name = "EGN")]
            public string EGN { get; set; }

            [Required]
            [Display(Name = "Hire date")]
            public DateTime HireDate { get; set; }


            [Display(Name = "Activate")]
            public bool IsActive { get; set; }


            [Display(Name = "Make it administrator")]
            public bool IsAdmin { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }


            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [StringLength(10, ErrorMessage = " The {0} must be {2}")]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }



        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {
                var user = new User { Id = Guid.NewGuid().ToString(), UserName = Input.Email, Email = Input.Email, FirstName = Input.FirstName, MiddleName = Input.MiddleName, LastName = Input.LastName, EGN = Input.EGN, HireDate = Input.HireDate, IsActive = Input.IsActive, IsAdmin = Input.IsAdmin, PhoneNumber = Input.PhoneNumber };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    {
                        return LocalRedirect(returnUrl);
                    }

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
