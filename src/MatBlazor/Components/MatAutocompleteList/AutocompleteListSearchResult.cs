﻿using System.Collections.Generic;

namespace ITMS.External.MatBlazor.Components.MatAutocompleteList
{
    internal class AutocompleteListSearchResult<TItem>
    {
        public List<MatAutocompleteListItem<TItem>> ListResult { get; set; }
        
        public IEnumerable<TItem> Items { get; set; }

        public string SearchText { get; set; }
    }
}
