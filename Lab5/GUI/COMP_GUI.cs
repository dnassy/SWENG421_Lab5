/*
 * @author TylerW
 * @author JackD
 * @author DemetriusN
 */
using System.Globalization;

namespace Lab5;

public partial class COMP_GUI : Form
{
    private readonly List<string> modules = new();
    private readonly ModuleFactory moduleFactory = new();

    public COMP_GUI()
    {
        InitializeComponent();
    }

    public void LoadModules()
    {
        string modulePath = Path.Combine(AppContext.BaseDirectory, "modules.txt");
        if (!File.Exists(modulePath))
        {
            throw new FileNotFoundException("modules.txt was not found in the application directory.", modulePath);
        }

        modules.Clear();
        modules.AddRange(
            File.ReadLines(modulePath)
                .Select(line => line.Trim())
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(line => line, StringComparer.OrdinalIgnoreCase));
    }

    public void DisplayModules()
    {
        modulesListBox.DataSource = null;
        modulesListBox.DataSource = modules;
    }

    public void ExecuteSelectedModule()
    {
        if (modulesListBox.SelectedItem is not string moduleName)
        {
            MessageBox.Show("Select a module before executing.", "No Module Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            Module module = moduleFactory.CreateModule(moduleName);
            module.Execute();
            UpdateCurrentValue();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void COMP_GUI_Load(object sender, EventArgs e)
    {
        try
        {
            LoadModules();
            DisplayModules();
            UpdateCurrentValue();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void executeButton_Click(object sender, EventArgs e)
    {
        ExecuteSelectedModule();
    }

    private void reloadButton_Click(object sender, EventArgs e)
    {
        try
        {
            LoadModules();
            DisplayModules();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Reload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void UpdateCurrentValue()
    {
        double current = ComputationContext.GetInstance().GetValue();
        currentValueLabel.Text = current.ToString(CultureInfo.InvariantCulture);
    }
}
