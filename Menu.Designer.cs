﻿namespace TPagenciadeviajes
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Itinerario = new Button();
            Prereserva = new Button();
            Reserva = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // Itinerario
            // 
            Itinerario.Location = new Point(147, 75);
            Itinerario.Name = "Itinerario";
            Itinerario.Size = new Size(75, 23);
            Itinerario.TabIndex = 0;
            Itinerario.Text = "Itinerario";
            Itinerario.UseVisualStyleBackColor = true;
            // 
            // Prereserva
            // 
            Prereserva.Location = new Point(300, 75);
            Prereserva.Name = "Prereserva";
            Prereserva.Size = new Size(75, 23);
            Prereserva.TabIndex = 1;
            Prereserva.Text = "Preserva";
            Prereserva.UseVisualStyleBackColor = true;
            Prereserva.Click += Prereserva_Click;
            // 
            // Reserva
            // 
            Reserva.Location = new Point(434, 75);
            Reserva.Name = "Reserva";
            Reserva.Size = new Size(75, 23);
            Reserva.TabIndex = 2;
            Reserva.Text = "Completar reserva";
            Reserva.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(547, 269);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(Reserva);
            Controls.Add(Prereserva);
            Controls.Add(Itinerario);
            Name = "Menu";
            Text = "Menu ";
            ResumeLayout(false);
        }

        #endregion

        private Button Itinerario;
        private Button Prereserva;
        private Button Reserva;
        private Button button4;
    }
}