﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace ITMS.External.MatBlazor
{
    public class BaseMatSelectValue<TValue, TItem> : CoreMatSelectValue<TValue, TItem>
    {
        [Parameter]
        public Func<TItem, TValue> ValueSelector { get; set; }

        private static readonly EqualityComparer<TValue> _comparer = EqualityComparer<TValue>.Default;

        protected override int GetKeyFromValue(TValue value)
        {
            return Items.FindIndex(item => _comparer.Equals(value, ValueSelector(item)));
        }

        protected override TValue GetValueFromKey(int key)
        {
            // return Items[key];
            return ValueSelector(Items[key]);
        }
    }
}