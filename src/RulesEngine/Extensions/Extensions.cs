﻿using RulesEngine.Interfaces;
using RulesEngine.Models;

namespace RulesEngine.Extensions
{
    public static class Extensions
    {
        public static bool SatisfiesRules<T>(this T @this, IRulesManager<T> manager) where T : new() =>
            manager.ItemSatisfiesRules(@this);

        public static RulesCatalogApplicationResult SatisfiesRulesWithMessage<T>(this T @this, IRulesManager<T> manager) where T : new() =>
            manager.ItemSatisfiesRulesWithMessage(@this);
    }
}