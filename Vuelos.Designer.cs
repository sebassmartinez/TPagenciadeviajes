namespace TPagenciadeviajes
{
    partial class Vuelos
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
            VuelosListView = new ListView();
            origenvuelo = new ColumnHeader();
            destinovuelo = new ColumnHeader();
            salidavuelo = new ColumnHeader();
            arribovuelo = new ColumnHeader();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            Hasta = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            Buscarvuelo = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            groupBox4 = new GroupBox();
            asiento = new ColumnHeader();
            precio = new ColumnHeader();
            Clase = new ColumnHeader();
            Pasajero = new ColumnHeader();
            button5 = new Button();
            columnHeader1 = new ColumnHeader();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // VuelosListView
            // 
            VuelosListView.Columns.AddRange(new ColumnHeader[] { asiento, origenvuelo, destinovuelo, salidavuelo, arribovuelo, precio, Clase, Pasajero, columnHeader1 });
            VuelosListView.Location = new Point(41, 38);
            VuelosListView.Name = "VuelosListView";
            VuelosListView.Size = new Size(581, 97);
            VuelosListView.TabIndex = 2;
            VuelosListView.UseCompatibleStateImageBehavior = false;
            VuelosListView.View = View.Details;
            // 
            // origenvuelo
            // 
            origenvuelo.Text = "Origen";
            origenvuelo.Width = 65;
            // 
            // destinovuelo
            // 
            destinovuelo.Text = "Destino";
            destinovuelo.Width = 65;
            // 
            // salidavuelo
            // 
            salidavuelo.Text = "Fecha de salida";
            salidavuelo.Width = 65;
            // 
            // arribovuelo
            // 
            arribovuelo.Text = "Fecha de arribo";
            arribovuelo.Width = 65;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(VuelosListView);
            groupBox2.Location = new Point(269, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(659, 163);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Vuelos disponibles";
            // 
            // button2
            // 
            button2.Location = new Point(631, 428);
            button2.Name = "button2";
            button2.Size = new Size(98, 47);
            button2.TabIndex = 5;
            button2.Text = "Continuar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(739, 428);
            button3.Name = "button3";
            button3.Size = new Size(98, 47);
            button3.TabIndex = 6;
            button3.Text = "Cancerlar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 19);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Destino";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 67);
            label6.Name = "label6";
            label6.Size = new Size(150, 15);
            label6.TabIndex = 7;
            label6.Text = "Seleccione la clase deseada";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(Hasta);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(0, 314);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(235, 106);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Fecha";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 32);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 1;
            label7.Text = "Desde";
            // 
            // Hasta
            // 
            Hasta.AutoSize = true;
            Hasta.Location = new Point(11, 68);
            Hasta.Name = "Hasta";
            Hasta.Size = new Size(37, 15);
            Hasta.TabIndex = 3;
            Hasta.Text = "Hasta";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(78, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(106, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(78, 68);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(106, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // Buscarvuelo
            // 
            Buscarvuelo.Location = new Point(109, 440);
            Buscarvuelo.Name = "Buscarvuelo";
            Buscarvuelo.Size = new Size(75, 23);
            Buscarvuelo.TabIndex = 10;
            Buscarvuelo.Text = "Buscar";
            Buscarvuelo.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 75);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 19);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Infante";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 48);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 19);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Menor";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(61, 19);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.Text = "Adulto";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 85);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(75, 19);
            radioButton4.TabIndex = 15;
            radioButton4.TabStop = true;
            radioButton4.Text = "Economy";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton7);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(Buscarvuelo);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 469);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aplicar filtros";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 110);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(74, 19);
            radioButton5.TabIndex = 16;
            radioButton5.TabStop = true;
            radioButton5.Text = "Premium";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 135);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(70, 19);
            radioButton6.TabIndex = 17;
            radioButton6.TabStop = true;
            radioButton6.Text = "Business";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(6, 160);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(47, 19);
            radioButton7.TabIndex = 18;
            radioButton7.TabStop = true;
            radioButton7.Text = "First";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton3);
            groupBox4.Controls.Add(radioButton2);
            groupBox4.Controls.Add(radioButton1);
            groupBox4.Location = new Point(28, 220);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(235, 100);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pasajeros";
            // 
            // asiento
            // 
            asiento.Text = "Asiento Nº";
            asiento.Width = 65;
            // 
            // precio
            // 
            precio.DisplayIndex = 7;
            precio.Text = "Precio";
            precio.Width = 65;
            // 
            // Clase
            // 
            Clase.DisplayIndex = 5;
            Clase.Text = "Clase ";
            // 
            // Pasajero
            // 
            Pasajero.DisplayIndex = 6;
            Pasajero.Text = "Pasajero";
            // 
            // button5
            // 
            button5.Location = new Point(330, 226);
            button5.Name = "button5";
            button5.Size = new Size(126, 35);
            button5.TabIndex = 11;
            button5.Text = "Agregar itinerario";
            button5.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cod vuelo";
            columnHeader1.Width = 70;
            // 
            // Vuelos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 493);
            Controls.Add(button5);
            Controls.Add(groupBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Vuelos";
            Text = "Vuelos";
            Load += Vuelos_Load;
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView VuelosListView;
        private GroupBox groupBox2;
        private Button button2;
        private Button button3;
        private ColumnHeader origenvuelo;
        private ColumnHeader destinovuelo;
        private ColumnHeader salidavuelo;
        private ColumnHeader arribovuelo;
        private ColumnHeader asiento;
        private ColumnHeader precio;
        private ColumnHeader Clase;
        private ColumnHeader Pasajero;
        private Label label1;
        private Label label6;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label Hasta;
        private Label label7;
        private Button Buscarvuelo;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox1;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private GroupBox groupBox4;
        private Button button5;
        private ColumnHeader columnHeader1;
    }
}