using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography;
using System.Text;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Commons;

public static class Security
{
    public static string EncryptTextCardNumber(this string input)
    {
        return input;
    }

    public static string DecryptTextCardNumber(this string input)
    {
        return input;
    }
}

