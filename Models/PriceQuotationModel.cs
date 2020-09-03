using System;
using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "Please enter a subtotal.")]
        [Range(0.01, Double.MaxValue, ErrorMessage = "Subtotal must be greater than 0")]
        public double? Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount percentage.")]
        [Range(0, 100, ErrorMessage = "Discount percentage must be between 0 and 100")]
        public int? DiscountPercent { get; set; }

        public double? CalculateDiscount()
        {
            double? discount = DiscountPercent * 0.01;
            return Subtotal * discount;
        }

        public double? CalculateTotal()
        {
            return Subtotal - CalculateDiscount();
        }
    }
}
