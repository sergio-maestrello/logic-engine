﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RulesEngine.Models
{
    public class RulesSet
    {
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "rules")]
        public IEnumerable<Rule> Rules { get; set; }
    }
}