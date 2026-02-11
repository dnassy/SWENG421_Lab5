/*
 * @author TylerW
 * @author JackD
 * @author DemetriusN
 */
namespace Lab5;

public class Log : NoInputModule
{
    protected override void PerformOperation()
    {
        double current = context.GetValue();
        if (current <= 0)
        {
            throw new InvalidOperationException("Log is only defined for values greater than 0.");
        }

        context.SetValue(Math.Log(current));
    }
}
