
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace MoneyAppLib.Components
{
    public partial class TaxCard
    {
        [Parameter]
        public int Id { get; set; }

        [Parameter]
        public string? NameExpense { get; set; }

        [Parameter] 
        public decimal Value { get; set; }

        [Parameter]

        public object? ModelTax { get; set; }

        
        
    }
}
