/*
 * @author TylerW
 * @author JackD
 * @author DemetriusN
 */
namespace Lab5;

partial class COMP_GUI
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code


    private void InitializeComponent()
    {
        modulesListBox = new ListBox();
        executeButton = new Button();
        reloadButton = new Button();
        currentValueTitleLabel = new Label();
        currentValueLabel = new Label();
        modulesTitleLabel = new Label();
        SuspendLayout();
        //
        // modulesListBox
        //
        modulesListBox.FormattingEnabled = true;
        modulesListBox.ItemHeight = 15;
        modulesListBox.Location = new Point(24, 52);
        modulesListBox.Name = "modulesListBox";
        modulesListBox.Size = new Size(286, 244);
        modulesListBox.TabIndex = 0;
        //
        // executeButton
        //
        executeButton.Location = new Point(338, 52);
        executeButton.Name = "executeButton";
        executeButton.Size = new Size(172, 38);
        executeButton.TabIndex = 1;
        executeButton.Text = "Execute Selected Module";
        executeButton.UseVisualStyleBackColor = true;
        executeButton.Click += executeButton_Click;
        //
        // reloadButton
        //
        reloadButton.Location = new Point(338, 103);
        reloadButton.Name = "reloadButton";
        reloadButton.Size = new Size(172, 38);
        reloadButton.TabIndex = 2;
        reloadButton.Text = "Reload Modules";
        reloadButton.UseVisualStyleBackColor = true;
        reloadButton.Click += reloadButton_Click;
        //
        // currentValueTitleLabel
        //
        currentValueTitleLabel.AutoSize = true;
        currentValueTitleLabel.Location = new Point(338, 176);
        currentValueTitleLabel.Name = "currentValueTitleLabel";
        currentValueTitleLabel.Size = new Size(82, 15);
        currentValueTitleLabel.TabIndex = 3;
        currentValueTitleLabel.Text = "Current Value:";
        //
        // currentValueLabel
        //
        currentValueLabel.AutoSize = true;
        currentValueLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        currentValueLabel.Location = new Point(338, 200);
        currentValueLabel.Name = "currentValueLabel";
        currentValueLabel.Size = new Size(26, 30);
        currentValueLabel.TabIndex = 4;
        currentValueLabel.Text = "0";
        //
        // modulesTitleLabel
        //
        modulesTitleLabel.AutoSize = true;
        modulesTitleLabel.Location = new Point(24, 25);
        modulesTitleLabel.Name = "modulesTitleLabel";
        modulesTitleLabel.Size = new Size(102, 15);
        modulesTitleLabel.TabIndex = 5;
        modulesTitleLabel.Text = "Available Modules";
        //
        // COMP_GUI
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(540, 340);
        Controls.Add(modulesTitleLabel);
        Controls.Add(currentValueLabel);
        Controls.Add(currentValueTitleLabel);
        Controls.Add(reloadButton);
        Controls.Add(executeButton);
        Controls.Add(modulesListBox);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "COMP_GUI";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "COMP GUI";
        Load += COMP_GUI_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox modulesListBox;
    private Button executeButton;
    private Button reloadButton;
    private Label currentValueTitleLabel;
    private Label currentValueLabel;
    private Label modulesTitleLabel;
}
