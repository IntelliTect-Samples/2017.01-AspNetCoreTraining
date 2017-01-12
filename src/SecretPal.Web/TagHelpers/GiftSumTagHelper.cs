using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using SecretPal.Data;
using System.Threading.Tasks;

namespace SecretPal.Web.TagHelpers
{
    public class GiftSumTagHelper : TagHelper
    {
        private AppDbContext DataContext { get; }

        /// <summary>
        /// Divide the sum by this number
        /// </summary>
        public decimal MultiplicationFactor { get; set; }

        public GiftSumTagHelper(AppDbContext dataContext)
        {
            // This gets Dependency Injected
            DataContext = dataContext;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "p";
            var sum = await DataContext.Gifts.SumAsync(f => f.Cost);
            output.Content.SetContent($"Total Gifts: {sum * MultiplicationFactor}");
        }
    }
}
