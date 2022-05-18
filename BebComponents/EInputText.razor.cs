using Microsoft.AspNetCore.Components;
using System;
using System.Linq.Expressions;

namespace BebComponents
{
    public partial class EInputText
    {
        [Parameter, EditorRequired]
        public Expression<Func<string>> ValidationFor { get; set; } = default!;

        [Parameter]
        public string? Id { get; set; } = "EInputText";

        [Parameter]
        public string? Label { get; set; }

        [Parameter]
        public bool? FloatingLabel { get; set; } = false;

        protected override bool TryParseValueFromString(string? value, out string result, out string validationErrorMessage)
        {
            result = value;
            validationErrorMessage = null;
            return true;
        }
    }
}
