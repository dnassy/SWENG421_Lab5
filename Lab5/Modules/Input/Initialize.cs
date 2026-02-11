/*
 * @author TylerW
 * @author JackD
 * @author DemetriusN
 */
namespace Lab5;

public class Initialize : InputModule
{
    protected override void PerformOperation(double input)
    {
        context.SetValue(input);
    }
}
