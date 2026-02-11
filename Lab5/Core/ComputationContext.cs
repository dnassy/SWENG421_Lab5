/*
 * @author TylerW
 * @author JackD
 * @author DemetriusN
 */
namespace Lab5;

public class ComputationContext
{
    private static readonly ComputationContext Instance = new ComputationContext();
    private double currentValue;

    private ComputationContext()
    {
        currentValue = 0;
    }

    public static ComputationContext GetInstance()
    {
        return Instance;
    }

    public double GetValue()
    {
        return currentValue;
    }

    public void SetValue(double value)
    {
        currentValue = value;
    }
}
