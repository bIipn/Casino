using System;

namespace CasinoExamples
{
    public static class SkuParser
    {
        // SKU format: <product #>-<2-letter color code>-<size code>
        // Example: "01-MN-L"
        public static string Parse(string sku)
        {
            if (string.IsNullOrWhiteSpace(sku)) return "Invalid SKU";

            var product = sku.Split('-');
            if (product.Length != 3) return "SKU not in expected format";

            string type = product[0] switch
            {
                "01" => "Sweatshirt",
                "02" => "T-Shirt",
                "03" => "Sweatpants",
                _ => "Other"
            };

            string color = product[1] switch
            {
                "BL" => "Black",
                "BK" => "Black",
                "MN" => "Maroon",
                _ => "White"
            };

            string size = product[2] switch
            {
                "S" => "Small",
                "M" => "Medium",
                "L" => "Large",
                _ => "One Size Fits All"
            };

            return $"Product: {size} {color} {type}";
        }
    }
}
