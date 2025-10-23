

namespace Rentpanel.Helpers;

internal static class NationalCodeHelper
{
    public static bool IsValidPhoneNumber(string phoneNumber)
    {
        if (!string.IsNullOrWhiteSpace(phoneNumber))
        { return true; }
        else { return false; }
    }
    public static string FormatToValidPhoneNumber(string phoneNumber)
    {
        return phoneNumber;

    }


}