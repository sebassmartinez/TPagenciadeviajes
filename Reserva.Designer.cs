namespace TPagenciadeviajes
{
    partial class Reserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button2 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            listView2 = new ListView();
            groupBox3 = new GroupBox();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(45, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 114);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(207, 85);
            button2.Name = "button2";
            button2.Size = new Size(139, 23);
            button2.TabIndex = 2;
            button2.Text = "Cancelar pre reserva";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(78, 85);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 0;
            button1.Text = "Armar prereserva";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(45, 262);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(381, 133);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(207, 90);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(78, 90);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Confirmar";
            button3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(18, 32);
            listView1.Name = "listView1";
            listView1.Size = new Size(318, 42);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre cliente";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Metodo de pago";
            columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Producto";
            columnHeader3.Width = 110;
            // 
            // listView2
            // 
            listView2.Location = new Point(49, 22);
            listView2.Name = "listView2";
            listView2.Size = new Size(121, 97);
            listView2.TabIndex = 2;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(listView2);
            groupBox3.Location = new Point(523, 230);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(219, 165);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Comprobante";
            // 
            // button5
            // 
            button5.Location = new Point(78, 136);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "Imprimir";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, -18);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingresar numero de prereserva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 17);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 4;
            label2.Text = "Ingrese numero de prereserva";
            // 
            // Reserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Reserva";
            Text = "Reserva";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox2;
        private Button button4;
        private Button button3;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView listView2;
        private GroupBox groupBox3;
        private Button button5;
        private Label label1;
        private Label label2;
    }
}