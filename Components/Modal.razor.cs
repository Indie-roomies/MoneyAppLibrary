using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace MoneyAppLib.Components
{
    public partial class Modal
    {

        [Parameter]
        public bool IsOpen { get;set; }

        [Parameter]
        public RenderFragment? DomContent { get; set; }
    }
}
