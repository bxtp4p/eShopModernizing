﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace eShopModernizedMVC
{
    public class CatalogConfiguration
    {
        private static readonly string configConnectionName = "CatalogDBContext";

        public static string ConnectionString
        {
            get
            {
                var envConnectionString = Environment.GetEnvironmentVariable("ConnectionString");
                return envConnectionString ?? $"name={configConnectionName}";
            }
        }
        public static bool UseMockData
        {
            get
            {
                var environmentValue = Environment.GetEnvironmentVariable("UseMockData");
                return environmentValue != null ?
                    bool.Parse(environmentValue) :
                    bool.Parse(ConfigurationManager.AppSettings["UseMockData"]);
            }
        }

        public static bool UseCustomizationData
        {
            get
            {
                var environmentValue = Environment.GetEnvironmentVariable("UseCustomizationData");
                return environmentValue != null ?
                    bool.Parse(environmentValue) :
                    bool.Parse(ConfigurationManager.AppSettings["UseCustomizationData"]);
            }
        }

        public static string PicBaseUrl
        {
            get
            {
                return Environment.GetEnvironmentVariable("PicBaseUrl");
            }
        }
    }
}