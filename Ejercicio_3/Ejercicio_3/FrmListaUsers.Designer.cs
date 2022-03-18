namespace Ejercicio_3
{
    partial class FrmListaUsers
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
            this.ListaUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListaUsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaUsersDataGridView
            // 
            this.ListaUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaUsersDataGridView.Location = new System.Drawing.Point(22, 30);
            this.ListaUsersDataGridView.Name = "ListaUsersDataGridView";
            this.ListaUsersDataGridView.Size = new System.Drawing.Size(551, 209);
            this.ListaUsersDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de usuarios";
            // 
            // FrmListaUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(595, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaUsersDataGridView);
            this.Name = "FrmListaUsers";
            this.Text = "FrmListaUsers";
            this.Load += new System.EventHandler(this.FrmListaUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaUsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaUsersDataGridView;
        private System.Windows.Forms.Label label1;
    }
}