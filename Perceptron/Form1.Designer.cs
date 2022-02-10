
namespace Perceptron
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
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.tbLearningRate = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLearningRate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudAges = new System.Windows.Forms.NumericUpDown();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbW0 = new System.Windows.Forms.Label();
            this.lbW1 = new System.Windows.Forms.Label();
            this.lbW2 = new System.Windows.Forms.Label();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLearningRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAges)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Location = new System.Drawing.Point(10, 19);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(200, 200);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseClick);
            // 
            // tbLearningRate
            // 
            this.tbLearningRate.Location = new System.Drawing.Point(300, 72);
            this.tbLearningRate.Maximum = 100;
            this.tbLearningRate.Name = "tbLearningRate";
            this.tbLearningRate.Size = new System.Drawing.Size(169, 45);
            this.tbLearningRate.SmallChange = 5;
            this.tbLearningRate.TabIndex = 1;
            this.tbLearningRate.TickFrequency = 5;
            this.tbLearningRate.ValueChanged += new System.EventHandler(this.tbLearningRate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Learning Rate";
            // 
            // lbLearningRate
            // 
            this.lbLearningRate.AutoSize = true;
            this.lbLearningRate.Location = new System.Drawing.Point(475, 81);
            this.lbLearningRate.Name = "lbLearningRate";
            this.lbLearningRate.Size = new System.Drawing.Size(13, 13);
            this.lbLearningRate.TabIndex = 3;
            this.lbLearningRate.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Epocas máximas";
            // 
            // nudAges
            // 
            this.nudAges.Location = new System.Drawing.Point(312, 118);
            this.nudAges.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAges.Name = "nudAges";
            this.nudAges.Size = new System.Drawing.Size(104, 20);
            this.nudAges.TabIndex = 6;
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(422, 115);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(75, 23);
            this.btnInitialize.TabIndex = 7;
            this.btnInitialize.Text = "Inicializar";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(71, 249);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbW0
            // 
            this.lbW0.AutoSize = true;
            this.lbW0.Location = new System.Drawing.Point(10, 227);
            this.lbW0.Name = "lbW0";
            this.lbW0.Size = new System.Drawing.Size(24, 13);
            this.lbW0.TabIndex = 9;
            this.lbW0.Text = "w0:";
            // 
            // lbW1
            // 
            this.lbW1.AutoSize = true;
            this.lbW1.Location = new System.Drawing.Point(91, 227);
            this.lbW1.Name = "lbW1";
            this.lbW1.Size = new System.Drawing.Size(27, 13);
            this.lbW1.TabIndex = 10;
            this.lbW1.Text = "w0: ";
            // 
            // lbW2
            // 
            this.lbW2.AutoSize = true;
            this.lbW2.Location = new System.Drawing.Point(168, 227);
            this.lbW2.Name = "lbW2";
            this.lbW2.Size = new System.Drawing.Size(27, 13);
            this.lbW2.TabIndex = 11;
            this.lbW2.Text = "w2: ";
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(283, 162);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 23);
            this.btnTrain.TabIndex = 12;
            this.btnTrain.Text = "Entrenar";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(364, 162);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluate.TabIndex = 14;
            this.btnEvaluate.Text = "Evaluar";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(258, 201);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 13);
            this.lbResult.TabIndex = 15;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 285);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.lbW2);
            this.Controls.Add(this.lbW1);
            this.Controls.Add(this.lbW0);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.nudAges);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLearningRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLearningRate);
            this.Controls.Add(this.Canvas);
            this.Name = "Form1";
            this.Text = "Implementación del perceptrón";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLearningRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.TrackBar tbLearningRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLearningRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudAges;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbW0;
        private System.Windows.Forms.Label lbW1;
        private System.Windows.Forms.Label lbW2;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Label lbResult;
    }
}

