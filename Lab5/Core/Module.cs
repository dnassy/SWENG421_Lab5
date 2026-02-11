/*
 * @author TylerW
 * @author JackD
 * @author DemetriusN
 */
namespace Lab5;

public abstract class Module
{
    protected readonly ComputationContext context = ComputationContext.GetInstance();

    public abstract void Execute();
}
