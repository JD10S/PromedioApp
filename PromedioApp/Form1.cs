using Logica;


namespace PromedioApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            Num1txt = new TextBox();
            Num2txt = new TextBox();
            Num3txt = new TextBox();
            Nota1 = new Label();
            Nota2 = new Label();
            Nota3 = new Label();
            PromedioTxt = new TextBox();
            TxtPromedio = new Label();
            CalcularP = new Button();
            SuspendLayout();
            // 
            // Num1txt
            // 
            Num1txt.Location = new Point(75, 46);
            Num1txt.Name = "Num1txt";
            Num1txt.Size = new Size(60, 23);
            Num1txt.TabIndex = 0;
            // 
            // Num2txt
            // 
            Num2txt.Location = new Point(75, 75);
            Num2txt.Name = "Num2txt";
            Num2txt.Size = new Size(60, 23);
            Num2txt.TabIndex = 1;
            // 
            // Num3txt
            // 
            Num3txt.Location = new Point(75, 104);
            Num3txt.Name = "Num3txt";
            Num3txt.Size = new Size(60, 23);
            Num3txt.TabIndex = 2;
            // 
            // Nota1
            // 
            Nota1.AutoSize = true;
            Nota1.Location = new Point(31, 49);
            Nota1.Name = "Nota1";
            Nota1.Size = new Size(42, 15);
            Nota1.TabIndex = 3;
            Nota1.Text = "Nota 1";
            // 
            // Nota2
            // 
            Nota2.AutoSize = true;
            Nota2.Location = new Point(31, 78);
            Nota2.Name = "Nota2";
            Nota2.Size = new Size(42, 15);
            Nota2.TabIndex = 4;
            Nota2.Text = "Nota 2";
            // 
            // Nota3
            // 
            Nota3.AutoSize = true;
            Nota3.Location = new Point(31, 107);
            Nota3.Name = "Nota3";
            Nota3.Size = new Size(42, 15);
            Nota3.TabIndex = 5;
            Nota3.Text = "Nota 3";
            // 
            // PromedioTxt
            // 
            PromedioTxt.Location = new Point(247, 75);
            PromedioTxt.Name = "PromedioTxt";
            PromedioTxt.Size = new Size(100, 23);
            PromedioTxt.TabIndex = 6;
            // 
            // TxtPromedio
            // 
            TxtPromedio.AutoSize = true;
            TxtPromedio.Location = new Point(182, 78);
            TxtPromedio.Name = "TxtPromedio";
            TxtPromedio.Size = new Size(59, 15);
            TxtPromedio.TabIndex = 7;
            TxtPromedio.Text = "Promedio";
            // 
            // CalcularP
            // 
            CalcularP.Location = new Point(182, 107);
            CalcularP.Name = "CalcularP";
            CalcularP.Size = new Size(75, 23);
            CalcularP.TabIndex = 0;
            CalcularP.Text = "Calcular";
            CalcularP.Click += CalcularP_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(422, 176);
            Controls.Add(CalcularP);
            Controls.Add(TxtPromedio);
            Controls.Add(PromedioTxt);
            Controls.Add(Nota3);
            Controls.Add(Nota2);
            Controls.Add(Nota1);
            Controls.Add(Num3txt);
            Controls.Add(Num2txt);
            Controls.Add(Num1txt);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox Num1txt;
        private TextBox Num2txt;
        private TextBox Num3txt;
        private TextBox PromedioTxt;
        private Label Nota1;
        private Label Nota2;
        private Label Nota3;
        private Label TxtPromedio;
        private Button CalcularP;

        private void CalcularP_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(Num1txt.Text, out int Num1) &&
               int.TryParse(Num2txt.Text, out int Num2) &&
               int.TryParse(Num3txt.Text, out int Num3))
            {
                double promedio = NotasCalculator.CalcularPromedio(Num1, Num2, Num3);
                PromedioTxt.Text = promedio.ToString();
                string resultado = NotasCalculator.DeterminarResultado(promedio);
                MessageBox.Show($"El promedio de las notas es: {promedio}. El estudiante {resultado} la asignatura.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese notas v�lidas en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


    
