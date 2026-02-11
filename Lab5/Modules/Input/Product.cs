/*
 * @author TylerW
 * @author JackD
 * @author DemetriusN
 */
namespace Lab5;

public class Product : InputModule
{
    protected override void PerformOperation(double input)
    {
        context.SetValue(context.GetValue() * input);
    }
}
