using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Application.Common
{
    public static class MappingUtilities
    {
        public static string GenerateSlug(string input)
        {
            string normalizedString = input.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            string slug = stringBuilder.ToString().Normalize(NormalizationForm.FormC).ToLower();
            slug = Regex.Replace(slug, @"[^a-z0-9\s-]", "");
            slug = Regex.Replace(slug, @"\s+", " ").Trim();
            slug = Regex.Replace(slug, @"\s", "-");

            return slug;
        }
    }
}
