using Microsoft.AspNetCore.Components;

namespace TelerikTesting.Models
{
    public class GridFragment
    {
        public int Id { get; set; }
        public RenderFragment fragment { get; set; }
        public int PositionIndex { get; set; }
    }
}
