namespace ProyectoFinalProgramacion
{
    partial class CRUD
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
            this.components = new System.ComponentModel.Container();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.BuscarTxt = new System.Windows.Forms.TextBox();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.InsertarBtn = new System.Windows.Forms.Button();
            this.EditarBtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.Estado = new System.Windows.Forms.StatusBarPanel();
            this.TimeBar = new System.Windows.Forms.StatusBarPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // DataView
            // 
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(12, 87);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(776, 255);
            this.DataView.TabIndex = 0;
            // 
            // BuscarTxt
            // 
            this.BuscarTxt.Location = new System.Drawing.Point(572, 57);
            this.BuscarTxt.Name = "BuscarTxt";
            this.BuscarTxt.Size = new System.Drawing.Size(105, 22);
            this.BuscarTxt.TabIndex = 1;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBtn.Location = new System.Drawing.Point(683, 54);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(105, 27);
            this.BuscarBtn.TabIndex = 2;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // InsertarBtn
            // 
            this.InsertarBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertarBtn.Location = new System.Drawing.Point(461, 370);
            this.InsertarBtn.Name = "InsertarBtn";
            this.InsertarBtn.Size = new System.Drawing.Size(105, 35);
            this.InsertarBtn.TabIndex = 3;
            this.InsertarBtn.Text = "Insertar";
            this.InsertarBtn.UseVisualStyleBackColor = true;
            this.InsertarBtn.Click += new System.EventHandler(this.InsertarBtn_Click);
            // 
            // EditarBtn
            // 
            this.EditarBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarBtn.Location = new System.Drawing.Point(572, 370);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(105, 35);
            this.EditarBtn.TabIndex = 4;
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBtn.Location = new System.Drawing.Point(683, 370);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(105, 35);
            this.EliminarBtn.TabIndex = 5;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tabla de datos";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.Estado,
            this.TimeBar});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 7;
            this.statusBar.Text = "statusBar";
            // 
            // Estado
            // 
            this.Estado.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Estado.Name = "Estado";
            this.Estado.Text = "Usuario: logueado";
            // 
            // TimeBar
            // 
            this.TimeBar.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Width = 685;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.EditarBtn);
            this.Controls.Add(this.InsertarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.BuscarTxt);
            this.Controls.Add(this.DataView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.TextBox BuscarTxt;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Button InsertarBtn;
        private System.Windows.Forms.Button EditarBtn;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.StatusBarPanel Estado;
        internal System.Windows.Forms.StatusBarPanel TimeBar;
        private System.Windows.Forms.Timer timer1;
    }
}