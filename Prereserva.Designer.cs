namespace TPagenciadeviajes
{
    partial class Prereserva
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
            PersonasListView = new ListView();
            nombreHd = new ColumnHeader();
            apellidohd = new ColumnHeader();
            Dnidh = new ColumnHeader();
            edadhd = new ColumnHeader();
            SuspendLayout();
            // 
            // PersonasListView
            // 
            PersonasListView.Columns.AddRange(new ColumnHeader[] { nombreHd, apellidohd, Dnidh, edadhd });
            PersonasListView.Location = new Point(203, 178);
            PersonasListView.Name = "PersonasListView";
            PersonasListView.Size = new Size(245, 71);
            PersonasListView.TabIndex = 0;
            PersonasListView.UseCompatibleStateImageBehavior = false;
            PersonasListView.View = View.Details;
            // 
            // nombreHd
            // 
            nombreHd.Text = "Nombre";
            // 
            // apellidohd
            // 
            apellidohd.Text = "Apellido";
            // 
            // Dnidh
            // 
            Dnidh.Text = "Dni";
            // 
            // edadhd
            // 
            edadhd.Text = "Edad";
            // 
            // Prereserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PersonasListView);
            Name = "Prereserva";
            Text = "Prereserva";
            Load += Prereserva_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView PersonasListView;
        private ColumnHeader nombreHd;
        private ColumnHeader apellidohd;
        private ColumnHeader Dnidh;
        private ColumnHeader edadhd;
    }
}