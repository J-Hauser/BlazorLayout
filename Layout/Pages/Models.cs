using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Layout.Pages
{
    public class BaseViewModel<T> : ComponentBase
    {
        [CascadingParameter] public EditContext EditContext { get; set; }

        public override Task SetParametersAsync(ParameterView parameters)
        {
            var dict = parameters.ToDictionary();
            Debug.Assert(dict.Values.Any() && ((EditContext)dict.Values.First()).Model.GetType() == typeof(T));
            return base.SetParametersAsync(parameters);
        }
    }

    public class Model1
    {

    }

    public class Model2
    {

    }
}
