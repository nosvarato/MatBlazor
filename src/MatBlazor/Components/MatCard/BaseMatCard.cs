﻿using Microsoft.AspNetCore.Components;

namespace MatBlazor
{
    /// <summary>
    /// Card component for Blazor contain content and actions about a single subject. 
    /// </summary>
    public class BaseMatCard : BaseMatDomComponent
    {
        public BaseMatCard()
        {
            ClassMapper
                .Add("mat-card")
                .Add("mdc-card")
                .If("mdc-card--stroked", () => this.Stroke);
        }

        [Parameter]
        public bool Stroke
        {
            get => _stroke;
            set { _stroke = value; }
        }

        [Parameter]
        public RenderFragment ChildContent { get; set; }


        private bool _stroke;
    }
}