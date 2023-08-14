using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace MoneyAppLib
{
    public partial class Component1
    {
        [Parameter]
        public string Name { get; set; }
    }
}
