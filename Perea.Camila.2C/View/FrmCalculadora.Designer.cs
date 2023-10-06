namespace MiCalculadora
{
    partial class FrmCalculadora : Form
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
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            cmbOperacion = new ComboBox();
            rdbDecimal = new RadioButton();
            rdbBinario = new RadioButton();
            lblOperacion = new Label();
            txtPrimerOperando = new TextBox();
            txtSegundoOperando = new TextBox();
            grpSistema = new GroupBox();
            lblResultado = new Label();
            lblPrimerOperador = new Label();
            lblSegundoOperador = new Label();
            lstHistorial = new ListBox();
            lblHistorial = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.BackColor = Color.White;
            btnOperar.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(105, 336);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(184, 53);
            btnOperar.TabIndex = 3;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = false;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(306, 336);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(184, 53);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(507, 336);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(184, 53);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // cmbOperacion
            // 
            cmbOperacion.BackColor = SystemColors.Window;
            cmbOperacion.DropDownHeight = 110;
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.IntegralHeight = false;
            cmbOperacion.Location = new Point(306, 279);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(184, 32);
            cmbOperacion.TabIndex = 1;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(13, 28);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(92, 25);
            rdbDecimal.TabIndex = 6;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(13, 59);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(84, 25);
            rdbBinario.TabIndex = 6;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.Location = new Point(306, 258);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(86, 18);
            lblOperacion.TabIndex = 1;
            lblOperacion.Text = "Operación:";
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperando.Location = new Point(63, 279);
            txtPrimerOperando.Multiline = true;
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.PlaceholderText = "Ingrese el primer número";
            txtPrimerOperando.Size = new Size(226, 32);
            txtPrimerOperando.TabIndex = 0;
            txtPrimerOperando.KeyPress += txtPrimerOperando_KeyPress;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperando.Location = new Point(507, 279);
            txtSegundoOperando.Multiline = true;
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.PlaceholderText = "Ingrese el segundo número";
            txtSegundoOperando.Size = new Size(226, 32);
            txtSegundoOperando.TabIndex = 2;
            txtSegundoOperando.KeyPress += txtSegundoOperando_KeyPress;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            grpSistema.Location = new Point(284, 122);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(235, 100);
            grpSistema.TabIndex = 6;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("ARCO", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(51, 52);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(281, 42);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado:";
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(63, 258);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(128, 18);
            lblPrimerOperador.TabIndex = 0;
            lblPrimerOperador.Text = "Primer operador:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(507, 258);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(145, 18);
            lblSegundoOperador.TabIndex = 2;
            lblSegundoOperador.Text = "Segundo operador:";
            // 
            // lstHistorial
            // 
            lstHistorial.BorderStyle = BorderStyle.FixedSingle;
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(773, 45);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(402, 392);
            lstHistorial.TabIndex = 8;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblHistorial.Location = new Point(773, 22);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(71, 18);
            lblHistorial.TabIndex = 9;
            lblHistorial.Text = "Historial:";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1187, 450);
            Controls.Add(lblHistorial);
            Controls.Add(lstHistorial);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblPrimerOperador);
            Controls.Add(lblResultado);
            Controls.Add(grpSistema);
            Controls.Add(txtSegundoOperando);
            Controls.Add(txtPrimerOperando);
            Controls.Add(lblOperacion);
            Controls.Add(cmbOperacion);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(1203, 489);
            MinimizeBox = false;
            MinimumSize = new Size(1203, 489);
            Name = "FrmCalculadora";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Camila Perea";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private ComboBox cmbOperacion;
        private RadioButton rdbDecimal;
        private RadioButton rdbBinario;
        private Label lblOperacion;
        private TextBox txtPrimerOperando;
        private TextBox txtSegundoOperando;
        private GroupBox grpSistema;
        private Label lblResultado;
        private Label lblPrimerOperador;
        private Label lblSegundoOperador;
        private ListBox lstHistorial;
        private Label lblHistorial;
    }
}