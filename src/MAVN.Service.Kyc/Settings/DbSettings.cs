﻿using Lykke.SettingsReader.Attributes;

namespace MAVN.Service.Kyc.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }

        [SqlCheck]
        public string DbConnString { get; set; }
    }
}
