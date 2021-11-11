using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace InputBaseRepro.Shared
{
    public class FixedInputText : InputText
    {
        public override Task SetParametersAsync(ParameterView parameters)
        {
            var t = base.SetParametersAsync(parameters);
            FieldIdentifier = FieldIdentifier.Create(ValueExpression);
            return t;
        }
    }
}