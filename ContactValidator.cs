using System;
using System.Text.RegularExpressions;

namespace ContactValidationLibrary
{
    public static class ContactValidator
    {
        public static bool IsValidFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return false;

            // Проверка, что строка содержит только буквы и пробелы
            return Regex.IsMatch(fullName, @"^[А-Яа-яA-Za-z\s]+$");
        }

        public static bool IsValidAge(string age)
        {
            if (string.IsNullOrWhiteSpace(age))
                return false;

            // Проверка, что строка состоит только из цифр
            return int.TryParse(age, out int ageValue) && ageValue > 0 && ageValue < 150;
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            // Проверка, что телефон соответствует формату
            return Regex.IsMatch(phoneNumber, @"^(\+380\d{9}|0\d{9})$");
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Проверка формата email
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
