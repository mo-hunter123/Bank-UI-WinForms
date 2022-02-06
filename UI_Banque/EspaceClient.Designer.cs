
namespace UI_Banque
{
    partial class EspaceClient
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saluteUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createAccount = new System.Windows.Forms.Button();
            this.runOperation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.accountsList = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 449);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // saluteUser
            // 
            this.saluteUser.AutoSize = true;
            this.saluteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saluteUser.Location = new System.Drawing.Point(67, 38);
            this.saluteUser.Name = "saluteUser";
            this.saluteUser.Size = new System.Drawing.Size(64, 25);
            this.saluteUser.TabIndex = 1;
            this.saluteUser.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(245, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(555, 449);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vos comptes";
            // 
            // createAccount
            // 
            this.createAccount.Location = new System.Drawing.Point(293, 337);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(111, 23);
            this.createAccount.TabIndex = 4;
            this.createAccount.Text = "creer un compte";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // runOperation
            // 
            this.runOperation.Location = new System.Drawing.Point(684, 337);
            this.runOperation.Name = "runOperation";
            this.runOperation.Size = new System.Drawing.Size(75, 23);
            this.runOperation.TabIndex = 5;
            this.runOperation.Text = "operation";
            this.runOperation.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Realised Operations";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // accountsList
            // 
            this.accountsList.HideSelection = false;
            this.accountsList.Location = new System.Drawing.Point(293, 78);
            this.accountsList.Name = "accountsList";
            this.accountsList.Size = new System.Drawing.Size(203, 206);
            this.accountsList.TabIndex = 7;
            this.accountsList.UseCompatibleStateImageBehavior = false;
            this.accountsList.SelectedIndexChanged += new System.EventHandler(this.accountsList_SelectedIndexChanged);
            // 
            // EspaceClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accountsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.runOperation);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.saluteUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EspaceClient";
            this.Text = "EspaceClient";
            this.Load += new System.EventHandler(this.EspaceClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label saluteUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.Button runOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView accountsList;
    }
}