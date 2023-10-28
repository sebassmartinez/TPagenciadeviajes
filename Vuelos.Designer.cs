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
            label1 = new Label();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            VuelosListView = new ListView();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            origenvuelo = new ColumnHeader();
            destinovuelo = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            salidavuelo = new ColumnHeader();
            arribovuelo = new ColumnHeader();
            duracionvuelo = new ColumnHeader();
            areolineavuelo = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 39);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Filtrar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(28, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 169);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aplicar filtros";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(78, 57);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 0;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(78, 83);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 1;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(78, 109);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(15, 14);
            checkBox3.TabIndex = 2;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(78, 136);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(15, 14);
            checkBox4.TabIndex = 3;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 57);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Economy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 83);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Premium";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 109);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 4;
            label4.Text = "Business";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 135);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 5;
            label5.Text = "First";
            // 
            // VuelosListView
            // 
            VuelosListView.Columns.AddRange(new ColumnHeader[] { origenvuelo, destinovuelo, columnHeader3, salidavuelo, arribovuelo, duracionvuelo, areolineavuelo });
            VuelosListView.Location = new Point(0, 38);
            VuelosListView.Name = "VuelosListView";
            VuelosListView.Size = new Size(423, 97);
            VuelosListView.TabIndex = 2;
            VuelosListView.UseCompatibleStateImageBehavior = false;
            VuelosListView.View = View.Details;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(VuelosListView);
            groupBox2.Location = new Point(330, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(442, 163);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Vuelos disponibles";
            // 
            // button1
            // 
            button1.Location = new Point(361, 266);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 4;
            button1.Text = "Agregar al  itinerario";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(501, 266);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Continuar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(614, 266);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Cancerlar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(150, 15);
            label6.TabIndex = 7;
            label6.Text = "Seleccione la clase deseada";
            // 
            // origenvuelo
            // 
            origenvuelo.Text = "Origen";
            // 
            // destinovuelo
            // 
            destinovuelo.Text = "Destino";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Paradas";
            // 
            // salidavuelo
            // 
            salidavuelo.Text = "Fecha de salida";
            // 
            // arribovuelo
            // 
            arribovuelo.Text = "Fecha de arribo";
            // 
            // duracionvuelo
            // 
            duracionvuelo.Text = "Duracion de vuelo ";
            // 
            // areolineavuelo
            // 
            areolineavuelo.Text = "Aerolinea";
            // 
            // Vuelos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Vuelos";
            Text = "Vuelos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ListView VuelosListView;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private ColumnHeader origenvuelo;
        private ColumnHeader destinovuelo;
        private ColumnHeader columnHeader3;
        private ColumnHeader salidavuelo;
        private ColumnHeader arribovuelo;
        private ColumnHeader duracionvuelo;
        private ColumnHeader areolineavuelo;
    }
}