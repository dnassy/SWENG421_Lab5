/*
 * @author TylerW
 * @author JackD
 * @author DemetriusN
 */
namespace Lab5;

public class Power : InputModule
{
    protected override void PerformOperation(double input)
    {
        context.SetValue(Math.Pow(context.GetValue(), input));
    }
}
