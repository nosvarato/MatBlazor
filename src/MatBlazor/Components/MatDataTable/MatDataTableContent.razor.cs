﻿using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace ITMS.External.MatBlazor
{
    public partial class MatDataTableContent<TItem>
    {
        [Parameter]
        public IEnumerable<TItem> Items { get; set; }
        
        [Parameter]
        public RenderFragment<TItem> ChildContent { get; set; }
    }
}