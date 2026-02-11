/*
 * @author TylerW
 * @author JackD
 * @author DemetriusN
 */
namespace Lab5;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new COMP_GUI());
    }
}
