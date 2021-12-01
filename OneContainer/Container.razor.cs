using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneContainer
{
    public partial class Container // : ComponentBase
    {
        [Parameter]
        public List<Type> Components { get; set; } = new List<Type>();

        public void Accept<T>() where T: ComponentBase
        {
            this.Components.Add(typeof(T));
            StateHasChanged();
        }
    }
}
