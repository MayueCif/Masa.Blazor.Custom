using Microsoft.AspNetCore.Components;

namespace Masa.Blazor.Custom.Shared.Presets
{
    public partial class ColorGroup
    {
        [Parameter]
        public List<string> Colors { get; set; } = new();

        [Parameter]
        public string Value { get; set; } = string.Empty;

        [Parameter]
        public EventCallback<string> ValueChanged { get; set; }

        [Parameter]
        public string? Class { get; set; }

        [Parameter]
        public string? Style { get; set; }

        [Parameter]
        public int Size { get; set; } = 24;

        [Parameter]
        public RenderFragment<string>? ItemAppendContent { get; set; }

        protected override void OnParametersSet()
        {
            if (Colors.Any())
            {
                Value = Colors.First();
            }
            base.OnParametersSet();
        }
    }
}
