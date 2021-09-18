
namespace Prueba_Borrar_Archivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_Info1 = new System.Windows.Forms.Label();
            this.lb_Info2 = new System.Windows.Forms.Label();
            this.lb_Info3 = new System.Windows.Forms.Label();
            this.lb_Info4 = new System.Windows.Forms.Label();
            this.lb_infoRuta = new System.Windows.Forms.Label();
            this.lb_fechaUltima = new System.Windows.Forms.Label();
            this.lb_Estado = new System.Windows.Forms.Label();
            this.lb_NumeroDeArchivos = new System.Windows.Forms.Label();
            this.lb_SiguienteFecha = new System.Windows.Forms.Label();
            this.txt_Ruta = new System.Windows.Forms.TextBox();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.ckb_BloquearCampoDeTexto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_Info1
            // 
            resources.ApplyResources(this.lb_Info1, "lb_Info1");
            this.lb_Info1.Name = "lb_Info1";
            // 
            // lb_Info2
            // 
            resources.ApplyResources(this.lb_Info2, "lb_Info2");
            this.lb_Info2.Name = "lb_Info2";
            // 
            // lb_Info3
            // 
            resources.ApplyResources(this.lb_Info3, "lb_Info3");
            this.lb_Info3.Name = "lb_Info3";
            // 
            // lb_Info4
            // 
            resources.ApplyResources(this.lb_Info4, "lb_Info4");
            this.lb_Info4.Name = "lb_Info4";
            // 
            // lb_infoRuta
            // 
            resources.ApplyResources(this.lb_infoRuta, "lb_infoRuta");
            this.lb_infoRuta.Name = "lb_infoRuta";
            // 
            // lb_fechaUltima
            // 
            resources.ApplyResources(this.lb_fechaUltima, "lb_fechaUltima");
            this.lb_fechaUltima.Name = "lb_fechaUltima";
            // 
            // lb_Estado
            // 
            resources.ApplyResources(this.lb_Estado, "lb_Estado");
            this.lb_Estado.Name = "lb_Estado";
            // 
            // lb_NumeroDeArchivos
            // 
            resources.ApplyResources(this.lb_NumeroDeArchivos, "lb_NumeroDeArchivos");
            this.lb_NumeroDeArchivos.Name = "lb_NumeroDeArchivos";
            // 
            // lb_SiguienteFecha
            // 
            resources.ApplyResources(this.lb_SiguienteFecha, "lb_SiguienteFecha");
            this.lb_SiguienteFecha.Name = "lb_SiguienteFecha";
            // 
            // txt_Ruta
            // 
            resources.ApplyResources(this.txt_Ruta, "txt_Ruta");
            this.txt_Ruta.Name = "txt_Ruta";
            // 
            // btn_Iniciar
            // 
            resources.ApplyResources(this.btn_Iniciar, "btn_Iniciar");
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // ckb_BloquearCampoDeTexto
            // 
            resources.ApplyResources(this.ckb_BloquearCampoDeTexto, "ckb_BloquearCampoDeTexto");
            this.ckb_BloquearCampoDeTexto.Name = "ckb_BloquearCampoDeTexto";
            this.ckb_BloquearCampoDeTexto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckb_BloquearCampoDeTexto);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.txt_Ruta);
            this.Controls.Add(this.lb_SiguienteFecha);
            this.Controls.Add(this.lb_NumeroDeArchivos);
            this.Controls.Add(this.lb_Estado);
            this.Controls.Add(this.lb_fechaUltima);
            this.Controls.Add(this.lb_infoRuta);
            this.Controls.Add(this.lb_Info4);
            this.Controls.Add(this.lb_Info3);
            this.Controls.Add(this.lb_Info2);
            this.Controls.Add(this.lb_Info1);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Info1;
        private System.Windows.Forms.Label lb_Info2;
        private System.Windows.Forms.Label lb_Info3;
        private System.Windows.Forms.Label lb_Info4;
        private System.Windows.Forms.Label lb_infoRuta;
        private System.Windows.Forms.Label lb_fechaUltima;
        private System.Windows.Forms.Label lb_Estado;
        private System.Windows.Forms.Label lb_NumeroDeArchivos;
        private System.Windows.Forms.Label lb_SiguienteFecha;
        private System.Windows.Forms.TextBox txt_Ruta;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.CheckBox ckb_BloquearCampoDeTexto;
    }
}

