/*
 * @author TylerW
 * @author JackD
 * @author DemetriusN
 */
namespace Lab5;

public abstract class InputModule : Module
{
    public override void Execute()
    {
        if (!InputDialog.TryGetInputDouble(GetType().Name, out double inputValue))
        {
            return;
        }

        PerformOperation(inputValue);
    }

    protected abstract void PerformOperation(double input);
}
