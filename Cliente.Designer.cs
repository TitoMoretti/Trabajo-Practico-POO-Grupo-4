﻿namespace Trabajo_POO_Grupo_4
{
    partial class Cliente
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
            this.BoxCliente = new System.Windows.Forms.GroupBox();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.btnTransacciones = new System.Windows.Forms.Button();
            this.btnComprarTickets = new System.Windows.Forms.Button();
            this.BoxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxCliente
            // 
            this.BoxCliente.BackColor = System.Drawing.Color.Transparent;
            this.BoxCliente.Controls.Add(this.btnCerrarSesión);
            this.BoxCliente.Controls.Add(this.btnTransacciones);
            this.BoxCliente.Controls.Add(this.btnComprarTickets);
            this.BoxCliente.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.BoxCliente.Location = new System.Drawing.Point(10, 11);
            this.BoxCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxCliente.Name = "BoxCliente";
            this.BoxCliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxCliente.Size = new System.Drawing.Size(581, 302);
            this.BoxCliente.TabIndex = 0;
            this.BoxCliente.TabStop = false;
            this.BoxCliente.Text = "Bienvenido! ¿Qué desea hacer?";
            this.BoxCliente.Enter += new System.EventHandler(this.BoxCliente_Enter);
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesión.Location = new System.Drawing.Point(5, 218);
            this.btnCerrarSesión.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(174, 64);
            this.btnCerrarSesión.TabIndex = 2;
            this.btnCerrarSesión.Text = "Cerrar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            this.btnCerrarSesión.Click += new System.EventHandler(this.btnCerrarSesión_Click);
            // 
            // btnTransacciones
            // 
            this.btnTransacciones.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.btnTransacciones.Location = new System.Drawing.Point(5, 120);
            this.btnTransacciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTransacciones.Name = "btnTransacciones";
            this.btnTransacciones.Size = new System.Drawing.Size(174, 64);
            this.btnTransacciones.TabIndex = 1;
            this.btnTransacciones.Text = "Ver Transacciones Anteriores";
            this.btnTransacciones.UseVisualStyleBackColor = true;
            // 
            // btnComprarTickets
            // 
            this.btnComprarTickets.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.btnComprarTickets.Location = new System.Drawing.Point(5, 25);
            this.btnComprarTickets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComprarTickets.Name = "btnComprarTickets";
            this.btnComprarTickets.Size = new System.Drawing.Size(174, 64);
            this.btnComprarTickets.TabIndex = 0;
            this.btnComprarTickets.Text = "Comprar Tickets";
            this.btnComprarTickets.UseVisualStyleBackColor = true;
            this.btnComprarTickets.Click += new System.EventHandler(this.btnComprarTickets_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabajo_POO_Grupo_4.Properties.Resources.Wallpaper3;
            this.ClientSize = new System.Drawing.Size(600, 325);
            this.Controls.Add(this.BoxCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.BoxCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxCliente;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Button btnTransacciones;
        private System.Windows.Forms.Button btnComprarTickets;
    }
}