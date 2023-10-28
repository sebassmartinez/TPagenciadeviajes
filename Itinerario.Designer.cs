namespace TPagenciadeviajes
{
    partial class Itinerario
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
            Numitirnerario = new TextBox();
            label1 = new Label();
            Personas = new GroupBox();
            Confirmarpersonas = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Seleccionservicio = new GroupBox();
            Buscarservicios = new Button();
            Hoteleria = new RadioButton();
            Vuelos = new RadioButton();
            listBox1 = new ListBox();
            listadoservicios = new GroupBox();
            Presupuestar = new Button();
            Guardarreserva = new Button();
            Cancerlarreserva = new Button();
            Personas.SuspendLayout();
            Seleccionservicio.SuspendLayout();
            listadoservicios.SuspendLayout();
            SuspendLayout();
            // 
            // Numitirnerario
            // 
            Numitirnerario.Location = new Point(49, 52);
            Numitirnerario.Name = "Numitirnerario";
            Numitirnerario.Size = new Size(100, 23);
            Numitirnerario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 34);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "Numero itinerario ";
            // 
            // Personas
            // 
            Personas.Controls.Add(Confirmarpersonas);
            Personas.Controls.Add(comboBox3);
            Personas.Controls.Add(comboBox2);
            Personas.Controls.Add(comboBox1);
            Personas.Controls.Add(label5);
            Personas.Controls.Add(label4);
            Personas.Controls.Add(label3);
            Personas.Controls.Add(label2);
            Personas.Location = new Point(49, 111);
            Personas.Name = "Personas";
            Personas.Size = new Size(388, 177);
            Personas.TabIndex = 2;
            Personas.TabStop = false;
            Personas.Text = "Personas";
            // 
            // Confirmarpersonas
            // 
            Confirmarpersonas.Location = new Point(240, 146);
            Confirmarpersonas.Name = "Confirmarpersonas";
            Confirmarpersonas.Size = new Size(75, 23);
            Confirmarpersonas.TabIndex = 7;
            Confirmarpersonas.Text = "Confirmar";
            Confirmarpersonas.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(89, 123);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(89, 78);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(89, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 131);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 126);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 2;
            label4.Text = "Menores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 81);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Infantes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 38);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Adultos ";
            // 
            // Seleccionservicio
            // 
            Seleccionservicio.Controls.Add(Buscarservicios);
            Seleccionservicio.Controls.Add(Hoteleria);
            Seleccionservicio.Controls.Add(Vuelos);
            Seleccionservicio.Location = new Point(59, 294);
            Seleccionservicio.Name = "Seleccionservicio";
            Seleccionservicio.Size = new Size(287, 100);
            Seleccionservicio.TabIndex = 3;
            Seleccionservicio.TabStop = false;
            Seleccionservicio.Text = "Seleccionar servicio";
            // 
            // Buscarservicios
            // 
            Buscarservicios.Location = new Point(195, 64);
            Buscarservicios.Name = "Buscarservicios";
            Buscarservicios.Size = new Size(75, 23);
            Buscarservicios.TabIndex = 8;
            Buscarservicios.Text = "Buscar";
            Buscarservicios.UseVisualStyleBackColor = true;
            // 
            // Hoteleria
            // 
            Hoteleria.AutoSize = true;
            Hoteleria.Location = new Point(24, 66);
            Hoteleria.Name = "Hoteleria";
            Hoteleria.Size = new Size(73, 19);
            Hoteleria.TabIndex = 1;
            Hoteleria.TabStop = true;
            Hoteleria.Text = "Hoteleria";
            Hoteleria.UseVisualStyleBackColor = true;
            // 
            // Vuelos
            // 
            Vuelos.AutoSize = true;
            Vuelos.Location = new Point(24, 32);
            Vuelos.Name = "Vuelos";
            Vuelos.Size = new Size(63, 19);
            Vuelos.TabIndex = 0;
            Vuelos.TabStop = true;
            Vuelos.Text = "Vuelos ";
            Vuelos.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Vuelo 1", "Vuelo 2 ", "Vuelo 3", "Vuelo 4 ", "Vuelo 5", "Vuelo 6", "Hotel 1 ", "Hotel 2 ", "Hotel 3", "Hotel 4", "Hotel 5", "Hotel 6" });
            listBox1.Location = new Point(17, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(229, 124);
            listBox1.TabIndex = 4;
            // 
            // listadoservicios
            // 
            listadoservicios.Controls.Add(Presupuestar);
            listadoservicios.Controls.Add(listBox1);
            listadoservicios.Location = new Point(511, 32);
            listadoservicios.Name = "listadoservicios";
            listadoservicios.Size = new Size(264, 225);
            listadoservicios.TabIndex = 5;
            listadoservicios.TabStop = false;
            listadoservicios.Text = "Servicios Disponibles";
            // 
            // Presupuestar
            // 
            Presupuestar.Location = new Point(119, 196);
            Presupuestar.Name = "Presupuestar";
            Presupuestar.Size = new Size(91, 23);
            Presupuestar.TabIndex = 5;
            Presupuestar.Text = "Presupuestar";
            Presupuestar.UseVisualStyleBackColor = true;
            // 
            // Guardarreserva
            // 
            Guardarreserva.Location = new Point(511, 360);
            Guardarreserva.Name = "Guardarreserva";
            Guardarreserva.Size = new Size(127, 25);
            Guardarreserva.TabIndex = 6;
            Guardarreserva.Text = "Guardar reseva";
            Guardarreserva.UseVisualStyleBackColor = true;
            // 
            // Cancerlarreserva
            // 
            Cancerlarreserva.Location = new Point(654, 360);
            Cancerlarreserva.Name = "Cancerlarreserva";
            Cancerlarreserva.Size = new Size(134, 25);
            Cancerlarreserva.TabIndex = 7;
            Cancerlarreserva.Text = "Cancerlar";
            Cancerlarreserva.UseVisualStyleBackColor = true;
            Cancerlarreserva.Click += Cancerlarreserva_Click;
            // 
            // Itinerario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cancerlarreserva);
            Controls.Add(Guardarreserva);
            Controls.Add(listadoservicios);
            Controls.Add(Seleccionservicio);
            Controls.Add(Personas);
            Controls.Add(label1);
            Controls.Add(Numitirnerario);
            Name = "Itinerario";
            Text = "Itinerario";
            Load += Itinerario_Load;
            Personas.ResumeLayout(false);
            Personas.PerformLayout();
            Seleccionservicio.ResumeLayout(false);
            Seleccionservicio.PerformLayout();
            listadoservicios.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Numitirnerario;
        private Label label1;
        private GroupBox Personas;
        private Button Confirmarpersonas;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox Seleccionservicio;
        private Button Buscarservicios;
        private RadioButton Hoteleria;
        private RadioButton Vuelos;
        private ListBox listBox1;
        private GroupBox listadoservicios;
        private Button Presupuestar;
        private Button Guardarreserva;
        private Button Cancerlarreserva;
    }
}