using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CrmTav_V2.Utilities
{
    public static class MethodRepo
    {
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string DayOfWeak(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Saturday:
                    return "شنبه";
                case DayOfWeek.Sunday:
                    return "یکشنبه";
                case DayOfWeek.Monday:
                    return "دوشنبه";
                case DayOfWeek.Tuesday:
                    return "سه شنبه";
                case DayOfWeek.Wednesday:
                    return "چهارشنبه";
                case DayOfWeek.Thursday:
                    return "پنجشنبه";
                case DayOfWeek.Friday:
                    return "جمعه";
                default:
                    return null;
            }
        }

        public static async Task<bool> SendSms(string PhonNumber, string Message, string Temp)
        {
            var receptor = PhonNumber;
            var message = Message;
            var api = new Kavenegar.KavenegarApi("4D4B66616C686B64534544333856706F7A6A35793647497735395A79496C59485644345257546C615137303D");
            api.VerifyLookup(receptor, Message, Temp);
            return await Task.FromResult(true);
        }
    }
}
