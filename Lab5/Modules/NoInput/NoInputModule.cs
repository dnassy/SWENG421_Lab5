/*
 * @author TylerW
 * @author JackD
 * @author DemetriusN
 */
namespace Lab5;

public abstract class NoInputModule : Module
{
    public override void Execute()
    {
        PerformOperation();
    }

    protected abstract void PerformOperation();
}
