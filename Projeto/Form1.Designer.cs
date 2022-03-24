namespace Projeto
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pb_clube1 = new System.Windows.Forms.PictureBox();
            this.pb_clube2 = new System.Windows.Forms.PictureBox();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.lbl_nomeClube1 = new System.Windows.Forms.Label();
            this.lbl_nomeClube2 = new System.Windows.Forms.Label();
            this.lbl_resultado2 = new System.Windows.Forms.Label();
            this.lbl_resultado1 = new System.Windows.Forms.Label();
            this.btn_mais2 = new System.Windows.Forms.Button();
            this.btn_menos2 = new System.Windows.Forms.Button();
            this.btn_menos1 = new System.Windows.Forms.Button();
            this.btn_mais1 = new System.Windows.Forms.Button();
            this.cronometro = new System.Windows.Forms.Timer(this.components);
            this.lbl_parte = new System.Windows.Forms.Label();
            this.btn_comecar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clube1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clube2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_clube1
            // 
            this.pb_clube1.Location = new System.Drawing.Point(22, 22);
            this.pb_clube1.Name = "pb_clube1";
            this.pb_clube1.Size = new System.Drawing.Size(144, 150);
            this.pb_clube1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_clube1.TabIndex = 0;
            this.pb_clube1.TabStop = false;
            // 
            // pb_clube2
            // 
            this.pb_clube2.Location = new System.Drawing.Point(463, 22);
            this.pb_clube2.Name = "pb_clube2";
            this.pb_clube2.Size = new System.Drawing.Size(144, 150);
            this.pb_clube2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_clube2.TabIndex = 1;
            this.pb_clube2.TabStop = false;
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("SimSun-ExtB", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_timer.Location = new System.Drawing.Point(260, 79);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(140, 47);
            this.lbl_timer.TabIndex = 2;
            this.lbl_timer.Text = "00:00";
            // 
            // lbl_nomeClube1
            // 
            this.lbl_nomeClube1.AutoSize = true;
            this.lbl_nomeClube1.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nomeClube1.Location = new System.Drawing.Point(62, 190);
            this.lbl_nomeClube1.Name = "lbl_nomeClube1";
            this.lbl_nomeClube1.Size = new System.Drawing.Size(68, 28);
            this.lbl_nomeClube1.TabIndex = 3;
            this.lbl_nomeClube1.Text = "Grêmio";
            // 
            // lbl_nomeClube2
            // 
            this.lbl_nomeClube2.AutoSize = true;
            this.lbl_nomeClube2.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nomeClube2.Location = new System.Drawing.Point(481, 190);
            this.lbl_nomeClube2.Name = "lbl_nomeClube2";
            this.lbl_nomeClube2.Size = new System.Drawing.Size(109, 28);
            this.lbl_nomeClube2.TabIndex = 4;
            this.lbl_nomeClube2.Text = "Internacional";
            // 
            // lbl_resultado2
            // 
            this.lbl_resultado2.AutoSize = true;
            this.lbl_resultado2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_resultado2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_resultado2.Location = new System.Drawing.Point(519, 232);
            this.lbl_resultado2.Name = "lbl_resultado2";
            this.lbl_resultado2.Size = new System.Drawing.Size(26, 30);
            this.lbl_resultado2.TabIndex = 5;
            this.lbl_resultado2.Text = "0";
            // 
            // lbl_resultado1
            // 
            this.lbl_resultado1.AutoSize = true;
            this.lbl_resultado1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_resultado1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_resultado1.Location = new System.Drawing.Point(79, 232);
            this.lbl_resultado1.Name = "lbl_resultado1";
            this.lbl_resultado1.Size = new System.Drawing.Size(26, 30);
            this.lbl_resultado1.TabIndex = 6;
            this.lbl_resultado1.Text = "0";
            // 
            // btn_mais2
            // 
            this.btn_mais2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mais2.Enabled = false;
            this.btn_mais2.Location = new System.Drawing.Point(496, 279);
            this.btn_mais2.Name = "btn_mais2";
            this.btn_mais2.Size = new System.Drawing.Size(30, 30);
            this.btn_mais2.TabIndex = 8;
            this.btn_mais2.Text = "+";
            this.btn_mais2.UseVisualStyleBackColor = true;
            this.btn_mais2.Click += new System.EventHandler(this.btn_mais2_Click);
            // 
            // btn_menos2
            // 
            this.btn_menos2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menos2.Enabled = false;
            this.btn_menos2.Location = new System.Drawing.Point(537, 279);
            this.btn_menos2.Name = "btn_menos2";
            this.btn_menos2.Size = new System.Drawing.Size(30, 30);
            this.btn_menos2.TabIndex = 9;
            this.btn_menos2.Text = "-";
            this.btn_menos2.UseVisualStyleBackColor = true;
            this.btn_menos2.Click += new System.EventHandler(this.btn_menos2_Click);
            // 
            // btn_menos1
            // 
            this.btn_menos1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menos1.Enabled = false;
            this.btn_menos1.Location = new System.Drawing.Point(97, 279);
            this.btn_menos1.Name = "btn_menos1";
            this.btn_menos1.Size = new System.Drawing.Size(30, 30);
            this.btn_menos1.TabIndex = 13;
            this.btn_menos1.Text = "-";
            this.btn_menos1.UseVisualStyleBackColor = true;
            this.btn_menos1.Click += new System.EventHandler(this.btn_menos1_Click);
            // 
            // btn_mais1
            // 
            this.btn_mais1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mais1.Enabled = false;
            this.btn_mais1.Location = new System.Drawing.Point(56, 279);
            this.btn_mais1.Name = "btn_mais1";
            this.btn_mais1.Size = new System.Drawing.Size(30, 30);
            this.btn_mais1.TabIndex = 12;
            this.btn_mais1.Text = "+";
            this.btn_mais1.UseVisualStyleBackColor = true;
            this.btn_mais1.Click += new System.EventHandler(this.btn_mais1_Click);
            // 
            // cronometro
            // 
            this.cronometro.Interval = 1;
            this.cronometro.Tick += new System.EventHandler(this.cronometro_Tick);
            // 
            // lbl_parte
            // 
            this.lbl_parte.AutoSize = true;
            this.lbl_parte.Location = new System.Drawing.Point(299, 143);
            this.lbl_parte.Name = "lbl_parte";
            this.lbl_parte.Size = new System.Drawing.Size(56, 15);
            this.lbl_parte.TabIndex = 14;
            this.lbl_parte.Text = "1º tempo";
            // 
            // btn_comecar
            // 
            this.btn_comecar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comecar.Location = new System.Drawing.Point(260, 195);
            this.btn_comecar.Name = "btn_comecar";
            this.btn_comecar.Size = new System.Drawing.Size(140, 23);
            this.btn_comecar.TabIndex = 15;
            this.btn_comecar.Text = "Começar Jogo";
            this.btn_comecar.UseVisualStyleBackColor = true;
            this.btn_comecar.Click += new System.EventHandler(this.btn_comecar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 330);
            this.Controls.Add(this.btn_comecar);
            this.Controls.Add(this.lbl_parte);
            this.Controls.Add(this.btn_menos1);
            this.Controls.Add(this.btn_mais1);
            this.Controls.Add(this.btn_menos2);
            this.Controls.Add(this.btn_mais2);
            this.Controls.Add(this.lbl_resultado1);
            this.Controls.Add(this.lbl_resultado2);
            this.Controls.Add(this.lbl_nomeClube2);
            this.Controls.Add(this.lbl_nomeClube1);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.pb_clube2);
            this.Controls.Add(this.pb_clube1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_clube1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clube2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_clube1;
        private PictureBox pb_clube2;
        private Label lbl_timer;
        private Label lbl_nomeClube1;
        private Label lbl_nomeClube2;
        private Label lbl_resultado2;
        private Label lbl_resultado1;
        private Button btn_mais2;
        private Button btn_menos2;
        private Button btn_menos1;
        private Button btn_mais1;
        private System.Windows.Forms.Timer cronometro;
        private Label lbl_parte;
        private Button btn_comecar;
    }
}