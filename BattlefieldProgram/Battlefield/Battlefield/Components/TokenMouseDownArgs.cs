namespace Battlefield.Components
{
    using Battlefield.Models;
    using Microsoft.AspNetCore.Components.Web;

    public class TokenMouseDownArgs
    {
        public MouseEventArgs? E { get; set; }
        public Token? Token { get; set; }
    }
}