
namespace RegexPablo
{
    partial class formMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tpLeftTop = new System.Windows.Forms.TableLayoutPanel();
            this.txRegex = new System.Windows.Forms.TextBox();
            this.rtTextInput = new System.Windows.Forms.RichTextBox();
            this.rbRightLeft = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tpLeft.SuspendLayout();
            this.tpLeftTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tpLeft);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.rbRightLeft);
            this.scMain.Size = new System.Drawing.Size(904, 450);
            this.scMain.SplitterDistance = 692;
            this.scMain.TabIndex = 0;
            // 
            // tpLeft
            // 
            this.tpLeft.ColumnCount = 1;
            this.tpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpLeft.Controls.Add(this.tpLeftTop, 0, 0);
            this.tpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpLeft.Location = new System.Drawing.Point(0, 0);
            this.tpLeft.Name = "tpLeft";
            this.tpLeft.RowCount = 1;
            this.tpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tpLeft.Size = new System.Drawing.Size(692, 450);
            this.tpLeft.TabIndex = 0;
            // 
            // tpLeftTop
            // 
            this.tpLeftTop.ColumnCount = 1;
            this.tpLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpLeftTop.Controls.Add(this.txRegex, 0, 0);
            this.tpLeftTop.Controls.Add(this.rtTextInput, 0, 1);
            this.tpLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpLeftTop.Location = new System.Drawing.Point(3, 3);
            this.tpLeftTop.Name = "tpLeftTop";
            this.tpLeftTop.RowCount = 2;
            this.tpLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tpLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpLeftTop.Size = new System.Drawing.Size(686, 444);
            this.tpLeftTop.TabIndex = 0;
            // 
            // txRegex
            // 
            this.txRegex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txRegex.Location = new System.Drawing.Point(3, 3);
            this.txRegex.Name = "txRegex";
            this.txRegex.Size = new System.Drawing.Size(680, 26);
            this.txRegex.TabIndex = 0;
            this.txRegex.TextChanged += new System.EventHandler(this.txRegex_TextChanged);
            // 
            // rtTextInput
            // 
            this.rtTextInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtTextInput.Location = new System.Drawing.Point(3, 41);
            this.rtTextInput.Name = "rtTextInput";
            this.rtTextInput.Size = new System.Drawing.Size(680, 400);
            this.rtTextInput.TabIndex = 1;
            this.rtTextInput.Text = resources.GetString("rtTextInput.Text");
            // 
            // rbRightLeft
            // 
            this.rbRightLeft.AutoSize = true;
            this.rbRightLeft.Location = new System.Drawing.Point(25, 44);
            this.rbRightLeft.Name = "rbRightLeft";
            this.rbRightLeft.Size = new System.Drawing.Size(178, 24);
            this.rbRightLeft.TabIndex = 0;
            this.rbRightLeft.TabStop = true;
            this.rbRightLeft.Text = "Derecha a Izquierda";
            this.rbRightLeft.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.scMain);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: REGEX TESTER BY PABLO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.tpLeft.ResumeLayout(false);
            this.tpLeftTop.ResumeLayout(false);
            this.tpLeftTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.TableLayoutPanel tpLeft;
        private System.Windows.Forms.TableLayoutPanel tpLeftTop;
        private System.Windows.Forms.TextBox txRegex;
        private System.Windows.Forms.RichTextBox rtTextInput;
        private System.Windows.Forms.RadioButton rbRightLeft;
    }
}

