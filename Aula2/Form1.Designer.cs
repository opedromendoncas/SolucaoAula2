
namespace Aula2
{
    partial class FormPokemon
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rbtCharmander = new System.Windows.Forms.RadioButton();
            this.rbtSquirtle = new System.Windows.Forms.RadioButton();
            this.rbtBullbasaur = new System.Windows.Forms.RadioButton();
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(12, 21);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(271, 25);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Escolha seu Pokémon:";
            // 
            // rbtCharmander
            // 
            this.rbtCharmander.AutoSize = true;
            this.rbtCharmander.Checked = true;
            this.rbtCharmander.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCharmander.Location = new System.Drawing.Point(17, 63);
            this.rbtCharmander.Name = "rbtCharmander";
            this.rbtCharmander.Size = new System.Drawing.Size(136, 22);
            this.rbtCharmander.TabIndex = 1;
            this.rbtCharmander.TabStop = true;
            this.rbtCharmander.Text = "Charmander";
            this.rbtCharmander.UseVisualStyleBackColor = true;
            this.rbtCharmander.CheckedChanged += new System.EventHandler(this.rbtCharmander_CheckedChanged);
            // 
            // rbtSquirtle
            // 
            this.rbtSquirtle.AutoSize = true;
            this.rbtSquirtle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSquirtle.Location = new System.Drawing.Point(17, 114);
            this.rbtSquirtle.Name = "rbtSquirtle";
            this.rbtSquirtle.Size = new System.Drawing.Size(93, 22);
            this.rbtSquirtle.TabIndex = 2;
            this.rbtSquirtle.Text = "Squirtle";
            this.rbtSquirtle.UseVisualStyleBackColor = true;
            this.rbtSquirtle.CheckedChanged += new System.EventHandler(this.rbtSquirtle_CheckedChanged);
            // 
            // rbtBullbasaur
            // 
            this.rbtBullbasaur.AutoSize = true;
            this.rbtBullbasaur.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBullbasaur.Location = new System.Drawing.Point(17, 172);
            this.rbtBullbasaur.Name = "rbtBullbasaur";
            this.rbtBullbasaur.Size = new System.Drawing.Size(118, 22);
            this.rbtBullbasaur.TabIndex = 3;
            this.rbtBullbasaur.Text = "Bullbasaur";
            this.rbtBullbasaur.UseVisualStyleBackColor = true;
            this.rbtBullbasaur.CheckedChanged += new System.EventHandler(this.rbtBullbasaur_CheckedChanged);
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.Image = global::Aula2.Properties.Resources.charmander;
            this.pictureBoxPokemon.Location = new System.Drawing.Point(245, 63);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(475, 475);
            this.pictureBoxPokemon.TabIndex = 4;
            this.pictureBoxPokemon.TabStop = false;
            // 
            // FormPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 598);
            this.Controls.Add(this.pictureBoxPokemon);
            this.Controls.Add(this.rbtBullbasaur);
            this.Controls.Add(this.rbtSquirtle);
            this.Controls.Add(this.rbtCharmander);
            this.Controls.Add(this.lblDescricao);
            this.Name = "FormPokemon";
            this.Text = "O Programa Pokémon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RadioButton rbtCharmander;
        private System.Windows.Forms.RadioButton rbtSquirtle;
        private System.Windows.Forms.RadioButton rbtBullbasaur;
        private System.Windows.Forms.PictureBox pictureBoxPokemon;
    }
}

