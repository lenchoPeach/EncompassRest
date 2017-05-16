﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.LoanPipeline
{
    [JsonObject(ItemRequired = Required.Always)]
    public sealed class LoanPipelineData
    {
        private Dictionary<string, string> _fields;

        public string LoanGuid { get; set; }

        public Dictionary<string, string> Fields
        {
            get
            {
                return _fields;
            }
            set
            {
                _fields = value?.Comparer == StringComparer.OrdinalIgnoreCase ? value : new Dictionary<string, string>(value, StringComparer.OrdinalIgnoreCase);
            }
        }
    }
}