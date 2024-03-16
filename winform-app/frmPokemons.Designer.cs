
namespace winform_app
{
    partial class frmPokemons
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
            this.dgvPokemons = new System.Windows.Forms.DataGridView();
            this.pbxPokemon = new System.Windows.Forms.PictureBox();
            this.dgvElementos = new System.Windows.Forms.DataGridView();
            this.lblElementos = new System.Windows.Forms.Label();
            this.lblPokemon = new System.Windows.Forms.Label();
            this.btnAgregarPokemon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemons
            // 
            this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokemons.Location = new System.Drawing.Point(92, 55);
            this.dgvPokemons.MultiSelect = false;
            this.dgvPokemons.Name = "dgvPokemons";
            this.dgvPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemons.Size = new System.Drawing.Size(610, 232);
            this.dgvPokemons.TabIndex = 0;
            this.dgvPokemons.SelectionChanged += new System.EventHandler(this.dgvPokemons_SelectionChanged);
            // 
            // pbxPokemon
            // 
            this.pbxPokemon.Location = new System.Drawing.Point(800, 55);
            this.pbxPokemon.Name = "pbxPokemon";
            this.pbxPokemon.Size = new System.Drawing.Size(240, 232);
            this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemon.TabIndex = 1;
            this.pbxPokemon.TabStop = false;
            this.pbxPokemon.Click += new System.EventHandler(this.pbxPokemon_Click);
            // 
            // dgvElementos
            // 
            this.dgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElementos.Location = new System.Drawing.Point(92, 390);
            this.dgvElementos.Name = "dgvElementos";
            this.dgvElementos.Size = new System.Drawing.Size(240, 150);
            this.dgvElementos.TabIndex = 2;
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.Location = new System.Drawing.Point(89, 364);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(100, 13);
            this.lblElementos.TabIndex = 3;
            this.lblElementos.Text = "Tabla de elementos";
            // 
            // lblPokemon
            // 
            this.lblPokemon.AutoSize = true;
            this.lblPokemon.Location = new System.Drawing.Point(89, 28);
            this.lblPokemon.Name = "lblPokemon";
            this.lblPokemon.Size = new System.Drawing.Size(81, 13);
            this.lblPokemon.TabIndex = 4;
            this.lblPokemon.Text = "Tabla pokemon";
            // 
            // btnAgregarPokemon
            // 
            this.btnAgregarPokemon.Location = new System.Drawing.Point(275, 305);
            this.btnAgregarPokemon.Name = "btnAgregarPokemon";
            this.btnAgregarPokemon.Size = new System.Drawing.Size(233, 40);
            this.btnAgregarPokemon.TabIndex = 5;
            this.btnAgregarPokemon.Text = "Agregar Pokemon";
            this.btnAgregarPokemon.UseVisualStyleBackColor = true;
            this.btnAgregarPokemon.Click += new System.EventHandler(this.btnAgregarPokemon_Click);
            // 
            // frmPokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1269, 637);
            this.Controls.Add(this.btnAgregarPokemon);
            this.Controls.Add(this.lblPokemon);
            this.Controls.Add(this.lblElementos);
            this.Controls.Add(this.dgvElementos);
            this.Controls.Add(this.pbxPokemon);
            this.Controls.Add(this.dgvPokemons);
            this.Name = "frmPokemons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiPrimerWinForm";
            this.Load += new System.EventHandler(this.frmPokemons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemons;
        private System.Windows.Forms.PictureBox pbxPokemon;
        private System.Windows.Forms.DataGridView dgvElementos;
        private System.Windows.Forms.Label lblElementos;
        private System.Windows.Forms.Label lblPokemon;
        private System.Windows.Forms.Button btnAgregarPokemon;
    }
}

