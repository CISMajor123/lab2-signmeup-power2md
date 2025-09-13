using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
namespace lab2_signmeup_power2md.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string GuestName { get; set; } = string.Empty;

        [BindProperty]
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; } = string.Empty;

        [BindProperty]
        [Required(ErrorMessage = "Please select your academic year")]
        public string AcademicYear { get; set; } = string.Empty;

        [BindProperty]
        [StringLength(100, ErrorMessage = "Major should not be more than 100 characters")]
        public string? Major { get; set; } = string.Empty;

        [BindProperty]
        [Required(ErrorMessage = "Please select yes/no")]
        public string RSVP { get; set; } = string.Empty;

        [BindProperty]  
        public string? Tshirt { get; set; } = string.Empty;

        // We'll add properties here in the next step

        public void OnGet()
        {
            // This runs when someone visits the page
        }
        public IActionResult OnPost()
        {
            // Check if all validation rules passed
            if (!ModelState.IsValid)
            {
                // If validation failed, stay on the same page and show errors
                return Page();
            }
            // If we get here, all validation passed!
            // Create a confirmation message
            var confirmationMessage = $"Thank you {GuestName}! If you selected a t-shirt you will be able to pick it up before the event." +
        $" We'll send details to {Email}.";
            ViewData["SuccessMessage"] = confirmationMessage;
            // Clear the form after successful submission
            ClearForm();
            return Page();
        }
        // Helper method to clear all form fields
        private void ClearForm()
        {
            GuestName = string.Empty;
            Email = string.Empty;
            AcademicYear = string.Empty;
            Major = string.Empty;  
            RSVP = string.Empty;
            Tshirt = string.Empty;
        }

    }
}