/*
 * @author TylerW
 * @author JackD
 * @author DemetriusN
 */
using System.Reflection;

namespace Lab5;

public class ModuleFactory
{
    private readonly Dictionary<string, Type> moduleTypes;

    public ModuleFactory()
    {
        moduleTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(type => !type.IsAbstract && typeof(Module).IsAssignableFrom(type))
            .ToDictionary(type => type.Name, StringComparer.OrdinalIgnoreCase);
    }

    public Module CreateModule(string name)
    {
        string trimmedName = name.Trim();
        if (!moduleTypes.TryGetValue(trimmedName, out Type? moduleType))
        {
            throw new InvalidOperationException($"Module \"{trimmedName}\" was not found.");
        }

        if (Activator.CreateInstance(moduleType) is not Module module)
        {
            throw new InvalidOperationException($"Module \"{trimmedName}\" could not be created.");
        }

        return module;
    }
}
