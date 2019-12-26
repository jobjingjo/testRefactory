using System;
using System.Linq;
using WebApplication.Services.Abstract;

namespace WebApplication.Services.Concrete
{
    public class StringService : IStringService
    {
        public bool IsPalindrome(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) {
                return false;
            }
            var reversedString = value.Reverse();
            return value.SequenceEqual(reversedString);
        }

        public string ReverseWords(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) {
                return value;
            }
            var items = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var reversedItems = items.Reverse();
            return string.Join(' ', reversedItems);
        }
    }
}
