
namespace license_maker
{
    partial class LicenseMakerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.NumericUpDown();
            this.txtPeriodo = new System.Windows.Forms.ComboBox();
            this.txtSoftware = new System.Windows.Forms.ComboBox();
            this.txtSerialPC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha_Caducidad = new System.Windows.Forms.DateTimePicker();
            this.btnCrearLicencia = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblGuardarEn = new System.Windows.Forms.Label();
            this.xmlParte2 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.XMLparte1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(159, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial PC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(175, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Periodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(165, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Software";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(292, 106);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(43, 20);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumero.ValueChanged += new System.EventHandler(this.txtNumero_ValueChanged);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.FormattingEnabled = true;
            this.txtPeriodo.Items.AddRange(new object[] {
            "mes (es)",
            "año (s)",
            "dia (s)"});
            this.txtPeriodo.Location = new System.Drawing.Point(341, 106);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(127, 21);
            this.txtPeriodo.TabIndex = 4;
            this.txtPeriodo.Text = "mes (es)";
            // 
            // txtSoftware
            // 
            this.txtSoftware.FormattingEnabled = true;
            this.txtSoftware.Items.AddRange(new object[] {
            "AdminKey",
            "RestauranteMX",
            "GymFit"});
            this.txtSoftware.Location = new System.Drawing.Point(292, 159);
            this.txtSoftware.Name = "txtSoftware";
            this.txtSoftware.Size = new System.Drawing.Size(121, 21);
            this.txtSoftware.TabIndex = 5;
            this.txtSoftware.Text = "AdminKey";
            this.txtSoftware.SelectedIndexChanged += new System.EventHandler(this.txtSoftware_SelectedIndexChanged);
            // 
            // txtSerialPC
            // 
            this.txtSerialPC.Location = new System.Drawing.Point(292, 48);
            this.txtSerialPC.Name = "txtSerialPC";
            this.txtSerialPC.Size = new System.Drawing.Size(224, 20);
            this.txtSerialPC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(121, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "F. Caducidad";
            // 
            // txtFecha_Caducidad
            // 
            this.txtFecha_Caducidad.Enabled = false;
            this.txtFecha_Caducidad.Location = new System.Drawing.Point(292, 210);
            this.txtFecha_Caducidad.Name = "txtFecha_Caducidad";
            this.txtFecha_Caducidad.Size = new System.Drawing.Size(200, 20);
            this.txtFecha_Caducidad.TabIndex = 8;
            // 
            // btnCrearLicencia
            // 
            this.btnCrearLicencia.BackColor = System.Drawing.Color.Indigo;
            this.btnCrearLicencia.FlatAppearance.BorderSize = 0;
            this.btnCrearLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearLicencia.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCrearLicencia.Location = new System.Drawing.Point(292, 367);
            this.btnCrearLicencia.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrearLicencia.Name = "btnCrearLicencia";
            this.btnCrearLicencia.Size = new System.Drawing.Size(176, 41);
            this.btnCrearLicencia.TabIndex = 11;
            this.btnCrearLicencia.Text = "Crear Licencia";
            this.btnCrearLicencia.UseVisualStyleBackColor = false;
            this.btnCrearLicencia.Click += new System.EventHandler(this.btnCrearLicencia_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(292, 321);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(224, 20);
            this.txtRuta.TabIndex = 12;
            // 
            // lblGuardarEn
            // 
            this.lblGuardarEn.AutoSize = true;
            this.lblGuardarEn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGuardarEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardarEn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblGuardarEn.Location = new System.Drawing.Point(289, 302);
            this.lblGuardarEn.Name = "lblGuardarEn";
            this.lblGuardarEn.Size = new System.Drawing.Size(78, 16);
            this.lblGuardarEn.TabIndex = 13;
            this.lblGuardarEn.Text = "Guardar en:";
            this.lblGuardarEn.Click += new System.EventHandler(this.lblGuardarEn_Click);
            // 
            // xmlParte2
            // 
            this.xmlParte2.AutoSize = true;
            this.xmlParte2.Location = new System.Drawing.Point(15, 91);
            this.xmlParte2.Name = "xmlParte2";
            this.xmlParte2.Size = new System.Drawing.Size(79, 13);
            this.xmlParte2.TabIndex = 14;
            this.xmlParte2.Text = "\"></database>";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.XMLparte1);
            this.panelContainer.Controls.Add(this.xmlParte2);
            this.panelContainer.Location = new System.Drawing.Point(550, 96);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(186, 30);
            this.panelContainer.TabIndex = 15;
            // 
            // XMLparte1
            // 
            this.XMLparte1.AutoSize = true;
            this.XMLparte1.Location = new System.Drawing.Point(15, 40);
            this.XMLparte1.Name = "XMLparte1";
            this.XMLparte1.Size = new System.Drawing.Size(232, 13);
            this.XMLparte1.TabIndex = 15;
            this.XMLparte1.Text = "<?xml version=\"1.0\"?><database DBcnString=\"";
            // 
            // LicenseMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.lblGuardarEn);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnCrearLicencia);
            this.Controls.Add(this.txtFecha_Caducidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSerialPC);
            this.Controls.Add(this.txtSoftware);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LicenseMakerForm";
            this.Text = "License Maker Local";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtNumero;
        private System.Windows.Forms.ComboBox txtPeriodo;
        private System.Windows.Forms.ComboBox txtSoftware;
        private System.Windows.Forms.TextBox txtSerialPC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtFecha_Caducidad;
        private System.Windows.Forms.Button btnCrearLicencia;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblGuardarEn;
        private System.Windows.Forms.Label xmlParte2;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label XMLparte1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

