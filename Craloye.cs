namespace Craloye
{
    static class Craloye
    {
        [STAThread]
        static void Main()
        {
            // Enable visual styles and run the form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        private Button button;
        private Label label;

        public MainForm()
        {
            // Window title and size
            Text = "Craloye";
            Width = 416;
            Height = 416;

            // Create label
            label = new Label();
            label.Text = "";
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(174, 64);
            Controls.Add(label);

            // Create button
            button = new Button();
            button.Text = "Craloye";
            button.Location = new System.Drawing.Point(164, 164);
            button.Click += new EventHandler(Button_Click);
            Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            label.Text = "Craloye";
        }
    }
}
