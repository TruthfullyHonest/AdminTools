﻿using Exiled.API.Interfaces;
using Exiled.Loader;

namespace AdminTools
{
    public class Config : IConfig
    {
        public bool GodTuts { get; set; } = true;
        public bool IsEnabled { get; set; } = true;
    }
}