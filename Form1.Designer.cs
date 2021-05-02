namespace EditorTextos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.EdicionRehacer = new System.Windows.Forms.ToolStripMenuItem();
            this.EdicionDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.EdicionCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.EdicionCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.EdicionPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionesFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.OpFuCouriernew = new System.Windows.Forms.ToolStripMenuItem();
            this.OpFuArial = new System.Windows.Forms.ToolStripMenuItem();
            this.OpFuPredeterminada = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionesTam = new System.Windows.Forms.ToolStripMenuItem();
            this.OpTam16 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpTam24 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpTamPredeterminado = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraDeEstado = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btbarCortar = new System.Windows.Forms.ToolStripButton();
            this.btbarCopiar = new System.Windows.Forms.ToolStripButton();
            this.btbarPegar = new System.Windows.Forms.ToolStripButton();
            this.ctEditor = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.SaveFileDialog();
            this.Abrir = new System.Windows.Forms.OpenFileDialog();
            this.etbarestPpal = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.BarraDeEstado.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuEdicion,
            this.menuOpciones});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "&Archivo";
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirArchivoToolStripMenuItem.Text = "&Abrir";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.ArchivoAbrir_Click);
            this.abrirArchivoToolStripMenuItem.MouseEnter += new System.EventHandler(this.Abrir_MouseEnter);
            this.abrirArchivoToolStripMenuItem.MouseLeave += new System.EventHandler(this.Abrir_MouseLeave);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            this.guardarToolStripMenuItem.MouseEnter += new System.EventHandler(this.Guardar_MouseEnter);
            this.guardarToolStripMenuItem.MouseLeave += new System.EventHandler(this.Guardar_MouseLeave);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            this.salirToolStripMenuItem.MouseEnter += new System.EventHandler(this.ArchivoSalir_MouseEnter);
            this.salirToolStripMenuItem.MouseLeave += new System.EventHandler(this.ArchivoSalir_MouseLeave);
            // 
            // menuEdicion
            // 
            this.menuEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EdicionRehacer,
            this.EdicionDeshacer,
            this.EdicionCortar,
            this.EdicionCopiar,
            this.EdicionPegar});
            this.menuEdicion.Name = "menuEdicion";
            this.menuEdicion.Size = new System.Drawing.Size(58, 20);
            this.menuEdicion.Text = "&Edición";
            this.menuEdicion.DropDownOpening += new System.EventHandler(this.menuEdicion_DropDownOpening);
            // 
            // EdicionRehacer
            // 
            this.EdicionRehacer.Name = "EdicionRehacer";
            this.EdicionRehacer.Size = new System.Drawing.Size(180, 22);
            this.EdicionRehacer.Text = "Rehacer";
            this.EdicionRehacer.Click += new System.EventHandler(this.EdicionRehacer_Click);
            // 
            // EdicionDeshacer
            // 
            this.EdicionDeshacer.Image = global::EditorTextos.Properties.Resources.FontAwesome_f0e2_0__16;
            this.EdicionDeshacer.Name = "EdicionDeshacer";
            this.EdicionDeshacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.EdicionDeshacer.Size = new System.Drawing.Size(180, 22);
            this.EdicionDeshacer.Text = "Deshacer";
            this.EdicionDeshacer.Click += new System.EventHandler(this.EdicionDeshacer_Click);
            // 
            // EdicionCortar
            // 
            this.EdicionCortar.Image = ((System.Drawing.Image)(resources.GetObject("EdicionCortar.Image")));
            this.EdicionCortar.Name = "EdicionCortar";
            this.EdicionCortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.EdicionCortar.Size = new System.Drawing.Size(180, 22);
            this.EdicionCortar.Text = "Cor&tar";
            this.EdicionCortar.Click += new System.EventHandler(this.EdicionCortar_Click);
            // 
            // EdicionCopiar
            // 
            this.EdicionCopiar.Image = ((System.Drawing.Image)(resources.GetObject("EdicionCopiar.Image")));
            this.EdicionCopiar.Name = "EdicionCopiar";
            this.EdicionCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.EdicionCopiar.Size = new System.Drawing.Size(180, 22);
            this.EdicionCopiar.Text = "&Copiar";
            this.EdicionCopiar.Click += new System.EventHandler(this.EdicionCopiar_Click);
            // 
            // EdicionPegar
            // 
            this.EdicionPegar.Image = ((System.Drawing.Image)(resources.GetObject("EdicionPegar.Image")));
            this.EdicionPegar.Name = "EdicionPegar";
            this.EdicionPegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.EdicionPegar.Size = new System.Drawing.Size(180, 22);
            this.EdicionPegar.Text = "&Pegar";
            this.EdicionPegar.Click += new System.EventHandler(this.EdicionPegar_Click);
            // 
            // menuOpciones
            // 
            this.menuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcionesFuente,
            this.OpcionesTam});
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(69, 20);
            this.menuOpciones.Text = "&Opciones";
            // 
            // OpcionesFuente
            // 
            this.OpcionesFuente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpFuCouriernew,
            this.OpFuArial,
            this.OpFuPredeterminada});
            this.OpcionesFuente.Name = "OpcionesFuente";
            this.OpcionesFuente.Size = new System.Drawing.Size(180, 22);
            this.OpcionesFuente.Text = "&Fuente";
            // 
            // OpFuCouriernew
            // 
            this.OpFuCouriernew.Name = "OpFuCouriernew";
            this.OpFuCouriernew.Size = new System.Drawing.Size(180, 22);
            this.OpFuCouriernew.Text = "Courier new";
            this.OpFuCouriernew.Click += new System.EventHandler(this.OpFuCouriernew_Click);
            // 
            // OpFuArial
            // 
            this.OpFuArial.Name = "OpFuArial";
            this.OpFuArial.Size = new System.Drawing.Size(180, 22);
            this.OpFuArial.Text = "Arial";
            this.OpFuArial.Click += new System.EventHandler(this.OpFuArial_Click);
            // 
            // OpFuPredeterminada
            // 
            this.OpFuPredeterminada.Name = "OpFuPredeterminada";
            this.OpFuPredeterminada.Size = new System.Drawing.Size(180, 22);
            this.OpFuPredeterminada.Text = "Predeterminada";
            this.OpFuPredeterminada.Click += new System.EventHandler(this.OpFuPredeterminada_Click);
            // 
            // OpcionesTam
            // 
            this.OpcionesTam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpTam16,
            this.OpTam24,
            this.OpTamPredeterminado});
            this.OpcionesTam.Name = "OpcionesTam";
            this.OpcionesTam.Size = new System.Drawing.Size(180, 22);
            this.OpcionesTam.Text = "&Tamaño";
            // 
            // OpTam16
            // 
            this.OpTam16.Name = "OpTam16";
            this.OpTam16.Size = new System.Drawing.Size(180, 22);
            this.OpTam16.Text = "16";
            this.OpTam16.Click += new System.EventHandler(this.OpTam16_Click);
            // 
            // OpTam24
            // 
            this.OpTam24.Name = "OpTam24";
            this.OpTam24.Size = new System.Drawing.Size(180, 22);
            this.OpTam24.Text = "24";
            this.OpTam24.Click += new System.EventHandler(this.OpTam24_Click);
            // 
            // OpTamPredeterminado
            // 
            this.OpTamPredeterminado.Name = "OpTamPredeterminado";
            this.OpTamPredeterminado.Size = new System.Drawing.Size(180, 22);
            this.OpTamPredeterminado.Text = "Predeterminado";
            this.OpTamPredeterminado.Click += new System.EventHandler(this.OpTamPredeterminado_Click);
            // 
            // BarraDeEstado
            // 
            this.BarraDeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etbarestPpal});
            this.BarraDeEstado.Location = new System.Drawing.Point(0, 438);
            this.BarraDeEstado.Name = "BarraDeEstado";
            this.BarraDeEstado.Size = new System.Drawing.Size(740, 22);
            this.BarraDeEstado.TabIndex = 1;
            this.BarraDeEstado.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btbarCortar,
            this.btbarCopiar,
            this.btbarPegar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btbarCortar
            // 
            this.btbarCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btbarCortar.Image = ((System.Drawing.Image)(resources.GetObject("btbarCortar.Image")));
            this.btbarCortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btbarCortar.Name = "btbarCortar";
            this.btbarCortar.Size = new System.Drawing.Size(23, 22);
            this.btbarCortar.Text = "toolStripButton1";
            this.btbarCortar.ToolTipText = "Cortar";
            this.btbarCortar.Click += new System.EventHandler(this.BtbarCortar_Click);
            this.btbarCortar.MouseEnter += new System.EventHandler(this.Cortar_MouseEnter);
            this.btbarCortar.MouseLeave += new System.EventHandler(this.Cortar_MouseLeave);
            // 
            // btbarCopiar
            // 
            this.btbarCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btbarCopiar.Image = ((System.Drawing.Image)(resources.GetObject("btbarCopiar.Image")));
            this.btbarCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btbarCopiar.Name = "btbarCopiar";
            this.btbarCopiar.Size = new System.Drawing.Size(23, 22);
            this.btbarCopiar.Text = "toolStripButton1";
            this.btbarCopiar.ToolTipText = "Copiar";
            this.btbarCopiar.Click += new System.EventHandler(this.BtbarCopiar_Click);
            this.btbarCopiar.MouseEnter += new System.EventHandler(this.Copiar_MouseEnter);
            this.btbarCopiar.MouseLeave += new System.EventHandler(this.Copiar_MouseLeave);
            // 
            // btbarPegar
            // 
            this.btbarPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btbarPegar.Image = ((System.Drawing.Image)(resources.GetObject("btbarPegar.Image")));
            this.btbarPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btbarPegar.Name = "btbarPegar";
            this.btbarPegar.Size = new System.Drawing.Size(23, 22);
            this.btbarPegar.Text = "toolStripButton1";
            this.btbarPegar.ToolTipText = "Pegar";
            this.btbarPegar.Click += new System.EventHandler(this.BtbarPegar_Click);
            this.btbarPegar.MouseEnter += new System.EventHandler(this.Pegar_MouseEnter);
            this.btbarPegar.MouseLeave += new System.EventHandler(this.Pegar_MouseLeave);
            // 
            // ctEditor
            // 
            this.ctEditor.AcceptsReturn = true;
            this.ctEditor.AcceptsTab = true;
            this.ctEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctEditor.Location = new System.Drawing.Point(0, 49);
            this.ctEditor.Multiline = true;
            this.ctEditor.Name = "ctEditor";
            this.ctEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctEditor.Size = new System.Drawing.Size(740, 389);
            this.ctEditor.TabIndex = 2;
            // 
            // Guardar
            // 
            this.Guardar.FileName = "SaveFileDialog";
            // 
            // Abrir
            // 
            this.Abrir.FileName = "openFileDialog";
            // 
            // etbarestPpal
            // 
            this.etbarestPpal.Name = "etbarestPpal";
            this.etbarestPpal.Size = new System.Drawing.Size(32, 17);
            this.etbarestPpal.Text = "Listo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 460);
            this.Controls.Add(this.ctEditor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BarraDeEstado);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EditorFG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BarraDeEstado.ResumeLayout(false);
            this.BarraDeEstado.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip BarraDeEstado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox ctEditor;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem menuEdicion;
        private System.Windows.Forms.ToolStripMenuItem EdicionCortar;
        private System.Windows.Forms.ToolStripMenuItem EdicionCopiar;
        private System.Windows.Forms.ToolStripMenuItem EdicionPegar;
        private System.Windows.Forms.ToolStripMenuItem menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem OpcionesFuente;
        private System.Windows.Forms.ToolStripMenuItem OpFuCouriernew;
        private System.Windows.Forms.ToolStripMenuItem OpFuArial;
        private System.Windows.Forms.ToolStripMenuItem OpFuPredeterminada;
        private System.Windows.Forms.ToolStripMenuItem OpcionesTam;
        private System.Windows.Forms.ToolStripMenuItem OpTam16;
        private System.Windows.Forms.ToolStripMenuItem OpTam24;
        private System.Windows.Forms.ToolStripMenuItem OpTamPredeterminado;
        private System.Windows.Forms.ToolStripButton btbarCortar;
        private System.Windows.Forms.ToolStripButton btbarCopiar;
        private System.Windows.Forms.ToolStripButton btbarPegar;
        private System.Windows.Forms.ToolStripMenuItem EdicionDeshacer;
        private System.Windows.Forms.ToolStripMenuItem EdicionRehacer;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog Guardar;
        private System.Windows.Forms.OpenFileDialog Abrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel etbarestPpal;
    }
}

