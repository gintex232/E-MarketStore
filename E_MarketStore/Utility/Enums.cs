﻿namespace E_MarketStore.Utility
{
    public class Enums
    {
        public static string CouponAPIBase { get; set; }
        public static string AuthAPIBase { get; set; }
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
