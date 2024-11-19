namespace Pilas_Colas_Listas_Enlazadas
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
            txtInput = new TextBox();
            btnPush = new Button();
            btnQueue = new Button();
            btnAddFirst = new Button();
            btnRemove = new Button();
            btnAddLast = new Button();
            btnDequeue = new Button();
            btnPop = new Button();
            lstDisplay = new ListBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(32, 263);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(283, 34);
            txtInput.TabIndex = 0;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(32, 36);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(130, 29);
            btnPush.TabIndex = 1;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btnQueue
            // 
            btnQueue.Location = new Point(32, 83);
            btnQueue.Name = "btnQueue";
            btnQueue.Size = new Size(130, 29);
            btnQueue.TabIndex = 2;
            btnQueue.Text = "Queue";
            btnQueue.UseVisualStyleBackColor = true;
            // 
            // btnAddFirst
            // 
            btnAddFirst.Location = new Point(32, 138);
            btnAddFirst.Name = "btnAddFirst";
            btnAddFirst.Size = new Size(130, 29);
            btnAddFirst.TabIndex = 3;
            btnAddFirst.Text = "Add First";
            btnAddFirst.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(32, 184);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(130, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAddLast
            // 
            btnAddLast.Location = new Point(190, 138);
            btnAddLast.Name = "btnAddLast";
            btnAddLast.Size = new Size(125, 29);
            btnAddLast.TabIndex = 5;
            btnAddLast.Text = "Add Last";
            btnAddLast.UseVisualStyleBackColor = true;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(190, 83);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(125, 29);
            btnDequeue.TabIndex = 6;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(190, 36);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(125, 29);
            btnPop.TabIndex = 7;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            // 
            // lstDisplay
            // 
            lstDisplay.FormattingEnabled = true;
            lstDisplay.Location = new Point(326, 13);
            lstDisplay.Name = "lstDisplay";
            lstDisplay.Size = new Size(701, 604);
            lstDisplay.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 656);
            Controls.Add(lstDisplay);
            Controls.Add(btnPop);
            Controls.Add(btnDequeue);
            Controls.Add(btnAddLast);
            Controls.Add(btnRemove);
            Controls.Add(btnAddFirst);
            Controls.Add(btnQueue);
            Controls.Add(btnPush);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnPush;
        private Button btnQueue;
        private Button btnAddFirst;
        private Button btnRemove;
        private Button btnAddLast;
        private Button btnDequeue;
        private Button btnPop;
        private ListBox lstDisplay;
    }
}
