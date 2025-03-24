namespace SuperMegaApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnTransparency;
        private Button btnBackgroundColor;
        private Button btnHelloWorld;
        private Button btnSetOfActions;
        private CheckBox chkTransparency;
        private CheckBox chkBackgroundColor;
        private CheckBox chkHelloWorld;

        private void InitializeComponent()
        {
            this.btnTransparency = new Button();
            this.btnBackgroundColor = new Button();
            this.btnHelloWorld = new Button();
            this.btnSetOfActions = new Button();
            this.chkTransparency = new CheckBox();
            this.chkBackgroundColor = new CheckBox();
            this.chkHelloWorld = new CheckBox();

            // 
            // btnTransparency
            // 
            this.btnTransparency.Location = new Point(20, 20);
            this.btnTransparency.Name = "btnTransparency";
            this.btnTransparency.Size = new Size(120, 40);
            this.btnTransparency.Text = "Прозорість";
            this.btnTransparency.Click += new EventHandler(this.btnTransparency_Click);

            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new Point(20, 70);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new Size(120, 40);
            this.btnBackgroundColor.Text = "Колір тла";
            this.btnBackgroundColor.Click += new EventHandler(this.btnBackgroundColor_Click);

            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.Location = new Point(20, 120);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new Size(120, 40);
            this.btnHelloWorld.Text = "Hello World";
            this.btnHelloWorld.Click += new EventHandler(this.btnHelloWorld_Click);

            // 
            // btnSetOfActions
            // 
            this.btnSetOfActions.Location = new Point(20, 170);
            this.btnSetOfActions.Name = "btnSetOfActions";
            this.btnSetOfActions.Size = new Size(120, 40);
            this.btnSetOfActions.Text = "Супермегакнопка";
            this.btnSetOfActions.Click += new EventHandler(this.btnSetOfActions_Click);

            // 
            // chkTransparency
            // 
            this.chkTransparency.Location = new Point(150, 20);
            this.chkTransparency.Text = "Прозорість";

            // 
            // chkBackgroundColor
            // 
            this.chkBackgroundColor.Location = new Point(150, 70);
            this.chkBackgroundColor.Text = "Колір тла";

            // 
            // chkHelloWorld
            // 
            this.chkHelloWorld.Location = new Point(150, 120);
            this.chkHelloWorld.Text = "Hello World";

            // 
            // Form1
            // 
            this.ClientSize = new Size(300, 250);
            this.Controls.Add(this.btnTransparency);
            this.Controls.Add(this.btnBackgroundColor);
            this.Controls.Add(this.btnHelloWorld);
            this.Controls.Add(this.btnSetOfActions);
            this.Controls.Add(this.chkTransparency);
            this.Controls.Add(this.chkBackgroundColor);
            this.Controls.Add(this.chkHelloWorld);
            this.Name = "Form1";
            this.Text = "СуперМегаApp";
        }
    }
}
