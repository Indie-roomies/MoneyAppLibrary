using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
namespace MoneyAppLib
{
    public partial class TaskList<TItem> : ComponentBase
    {

        [Parameter]
        public object? Model { get; set; }

        [Parameter]
        public IEnumerable<TItem>? List { get; set;}
        
    }
}
