using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Bai_Lam_Nhom_LTHDT
{
    public static class Validator
    {
        // Kiểm tra rỗng
        public static bool IsEmpty(string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        // Độ dài tối thiểu
        public static bool HasMinLength(string text, int min)
        {
            return text.Trim().Length >= min;
        }

        // Độ dài tối đa
        public static bool HasMaxLength(string text, int max)
        {
            return text.Trim().Length <= max;
        }

        // Khoảng độ dài
        public static bool HasLength(string text, int min, int max)
        {
            int length = text.Trim().Length;
            return length >= min && length <= max;
        }

        // Chỉ chứa số
        public static bool IsNumber(string text)
        {
            return int.TryParse(text, out _);
        }

        // Số nguyên dương
        public static bool IsPositiveInteger(string text)
        {
            return int.TryParse(text, out int value) && value > 0;
        }

        // Số thực
        public static bool IsDouble(string text)
        {
            return double.TryParse(text, out _);
        }

        // Email
        public static bool IsEmail(string email)
        {
            return Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Số điện thoại Việt Nam
        public static bool IsPhoneNumber(string phone)
        {
            return Regex.IsMatch(phone, @"^0\d{9}$");
        }

        // Chỉ chứa chữ
        public static bool IsLetter(string text)
        {
            return Regex.IsMatch(text, @"^[\p{L}\s]+$");
        }

        // Chữ hoặc số
        public static bool IsLetterOrDigit(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Z0-9]+$");
        }

        // Kiểm tra ngày
        public static bool IsDate(string text)
        {
            return DateTime.TryParse(text, out _);
        }

        // Trong khoảng
        public static bool IsInRange(int value, int min, int max)
        {
            return value >= min && value <= max;
        }

        // Regex tùy ý
        public static bool MatchRegex(string text, string pattern)
        {
            return Regex.IsMatch(text, pattern);
        }
    }
}
