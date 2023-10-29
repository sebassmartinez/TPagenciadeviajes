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
            Seleccionservicio = new GroupBox();
            listadoservicios = new GroupBox();
            Presupuestar = new Button();
            Guardarreserva = new Button();
            Cancerlarreserva = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            listView1 = new ListView();
            listView2 = new ListView();
            button4 = new Button();
            button5 = new Button();
            label2 = new Label();
            label4 = new Label();
            Precio = new ColumnHeader();
            Pasajero = new ColumnHeader();
            Destino = new ColumnHeader();
            Preciohotel = new ColumnHeader();
            cuidad = new ColumnHeader();
            Pasajeroshotel = new ColumnHeader();
            Seleccionservicio.SuspendLayout();
            listadoservicios.SuspendLayout();
            SuspendLayout();
            // 
            // Numitirnerario
            // 
            Numitirnerario.Location = new Point(53, 52);
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
            // Seleccionservicio
            // 
            Seleccionservicio.Controls.Add(button3);
            Seleccionservicio.Controls.Add(button1);
            Seleccionservicio.Location = new Point(49, 133);
            Seleccionservicio.Name = "Seleccionservicio";
            Seleccionservicio.Size = new Size(287, 116);
            Seleccionservicio.TabIndex = 3;
            Seleccionservicio.TabStop = false;
            Seleccionservicio.Text = "Seleccionar servicio";
            // 
            // listadoservicios
            // 
            listadoservicios.Controls.Add(label4);
            listadoservicios.Controls.Add(label2);
            listadoservicios.Controls.Add(button5);
            listadoservicios.Controls.Add(button4);
            listadoservicios.Controls.Add(listView1);
            listadoservicios.Controls.Add(listView2);
            listadoservicios.Controls.Add(Presupuestar);
            listadoservicios.Location = new Point(345, 34);
            listadoservicios.Name = "listadoservicios";
            listadoservicios.Size = new Size(443, 276);
            listadoservicios.TabIndex = 5;
            listadoservicios.TabStop = false;
            listadoservicios.Text = "Servicios Seleccionados";
            // 
            // Presupuestar
            // 
            Presupuestar.Location = new Point(159, 207);
            Presupuestar.Name = "Presupuestar";
            Presupuestar.Size = new Size(111, 42);
            Presupuestar.TabIndex = 5;
            Presupuestar.Text = "Presupuestar";
            Presupuestar.UseVisualStyleBackColor = true;
            // 
            // Guardarreserva
            // 
            Guardarreserva.Location = new Point(361, 367);
            Guardarreserva.Name = "Guardarreserva";
            Guardarreserva.Size = new Size(127, 41);
            Guardarreserva.TabIndex = 6;
            Guardarreserva.Text = "Guardar Itinerario";
            Guardarreserva.UseVisualStyleBackColor = true;
            // 
            // Cancerlarreserva
            // 
            Cancerlarreserva.Location = new Point(545, 367);
            Cancerlarreserva.Name = "Cancerlarreserva";
            Cancerlarreserva.Size = new Size(127, 41);
            Cancerlarreserva.TabIndex = 7;
            Cancerlarreserva.Text = "Cancelar";
            Cancerlarreserva.UseVisualStyleBackColor = true;
            Cancerlarreserva.Click += Cancerlarreserva_Click;
            // 
            // button2
            // 
            button2.Location = new Point(181, 52);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 9;
            button2.Text = "Buscar/Nuevo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(33, 53);
            button1.Name = "button1";
            button1.Size = new Size(102, 42);
            button1.TabIndex = 0;
            button1.Text = "Vuelos ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(160, 53);
            button3.Name = "button3";
            button3.Size = new Size(102, 42);
            button3.TabIndex = 1;
            button3.Text = "Hoteleria";
            button3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Preciohotel, cuidad, Pasajeroshotel });
            listView1.Location = new Point(240, 59);
            listView1.Name = "listView1";
            listView1.Size = new Size(197, 97);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { Precio, Pasajero, Destino });
            listView2.Location = new Point(28, 59);
            listView2.Name = "listView2";
            listView2.Size = new Size(176, 97);
            listView2.TabIndex = 7;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // button4
            // 
            button4.Location = new Point(52, 162);
            button4.Name = "button4";
            button4.Size = new Size(91, 23);
            button4.TabIndex = 8;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(304, 162);
            button5.Name = "button5";
            button5.Size = new Size(91, 23);
            button5.TabIndex = 9;
            button5.Text = "Eliminar ";
            button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 41);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 10;
            label2.Text = "Vuelos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 41);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 12;
            label4.Text = "Hotel";
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            // 
            // Pasajero
            // 
            Pasajero.Text = "Pasajero";
            // 
            // Destino
            // 
            Destino.Text = "Destino";
            // 
            // Preciohotel
            // 
            Preciohotel.Text = "Precio";
            // 
            // cuidad
            // 
            cuidad.Text = "Hotal-Cuidad";
            cuidad.Width = 75;
            // 
            // Pasajeroshotel
            // 
            Pasajeroshotel.Text = "Pasajero";
            // 
            // Itinerario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(Cancerlarreserva);
            Controls.Add(Guardarreserva);
            Controls.Add(listadoservicios);
            Controls.Add(Seleccionservicio);
            Controls.Add(label1);
            Controls.Add(Numitirnerario);
            Name = "Itinerario";
            Text = "Itinerario";
            Load += Itinerario_Load;
            Seleccionservicio.ResumeLayout(false);
            listadoservicios.ResumeLayout(false);
            listadoservicios.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Numitirnerario;
        private Label label1;
        private GroupBox Seleccionservicio;
        private GroupBox listadoservicios;
        private Button Presupuestar;
        private Button Guardarreserva;
        private Button Cancerlarreserva;
        private Button button2;
        private Button button3;
        private Button button1;
        private ListView listView2;
        private ListView listView1;
        private Button button5;
        private Button button4;
        private Label label4;
        private Label label2;
        private ColumnHeader Precio;
        private ColumnHeader Pasajero;
        private ColumnHeader Destino;
        private ColumnHeader Preciohotel;
        private ColumnHeader cuidad;
        private ColumnHeader Pasajeroshotel;
    }
}