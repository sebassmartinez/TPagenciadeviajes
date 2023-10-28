namespace TPagenciadeviajes
{
    partial class Hoteleria
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
            label5 = new Label();
            comboBox3 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            listView1 = new ListView();
            nombrehotel = new ColumnHeader();
            ciudadhotel = new ColumnHeader();
            direccionhotel = new ColumnHeader();
            calificacionhotel = new ColumnHeader();
            disponibilidadhotel = new ColumnHeader();
            button1 = new Button();
            hotelcontinuar = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(49, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aplicar filtros";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 113);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 6;
            label5.Text = "Fecha desde - hasta";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(121, 110);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 110);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(121, 71);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 74);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Tarifa diaria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Capacidad maxima";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(121, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 288);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 5;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { nombrehotel, ciudadhotel, direccionhotel, calificacionhotel, disponibilidadhotel });
            listView1.Location = new Point(353, 176);
            listView1.Name = "listView1";
            listView1.Size = new Size(371, 97);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // nombrehotel
            // 
            nombrehotel.Text = "Nombre";
            // 
            // ciudadhotel
            // 
            ciudadhotel.Text = "Ciudad";
            // 
            // direccionhotel
            // 
            direccionhotel.Text = "Direccion";
            // 
            // calificacionhotel
            // 
            calificacionhotel.Text = "Calificacion";
            calificacionhotel.Width = 90;
            // 
            // disponibilidadhotel
            // 
            disponibilidadhotel.Text = "Disponibilidad";
            disponibilidadhotel.Width = 90;
            // 
            // button1
            // 
            button1.Location = new Point(370, 317);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 7;
            button1.Text = "Agregar itinerario";
            button1.UseVisualStyleBackColor = true;
            // 
            // hotelcontinuar
            // 
            hotelcontinuar.Location = new Point(511, 317);
            hotelcontinuar.Name = "hotelcontinuar";
            hotelcontinuar.Size = new Size(75, 23);
            hotelcontinuar.TabIndex = 8;
            hotelcontinuar.Text = "Continuar";
            hotelcontinuar.UseVisualStyleBackColor = true;
            hotelcontinuar.Click += hotelcontinuar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(617, 317);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Hoteleria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(hotelcontinuar);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "Hoteleria";
            Text = "Hoteleria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private ComboBox comboBox3;
        private Label label3;
        private ComboBox comboBox2;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label4;
        private ListView listView1;
        private ColumnHeader nombrehotel;
        private ColumnHeader ciudadhotel;
        private ColumnHeader direccionhotel;
        private ColumnHeader calificacionhotel;
        private ColumnHeader disponibilidadhotel;
        private Button button1;
        private Button hotelcontinuar;
        private Button button3;
    }
}