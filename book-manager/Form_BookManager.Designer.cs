﻿namespace book_manager
{
    partial class Form_BookManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BookManager));
            dataGridView1 = new DataGridView();
            Label_BookManagement = new Label();
            Button_Save = new Button();
            Button_Reload = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            // 
            // Label_BookManagement
            // 
            resources.ApplyResources(Label_BookManagement, "Label_BookManagement");
            Label_BookManagement.Name = "Label_BookManagement";
            // 
            // Button_Save
            // 
            resources.ApplyResources(Button_Save, "Button_Save");
            Button_Save.Name = "Button_Save";
            Button_Save.UseVisualStyleBackColor = true;
            Button_Save.Click += Botton_Save_Click;
            // 
            // Button_Reload
            // 
            resources.ApplyResources(Button_Reload, "Button_Reload");
            Button_Reload.Name = "Button_Reload";
            Button_Reload.UseVisualStyleBackColor = true;
            Button_Reload.Click += Button_Reload_Click;
            // 
            // Form_BookManager
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Button_Reload);
            Controls.Add(Button_Save);
            Controls.Add(Label_BookManagement);
            Controls.Add(dataGridView1);
            Name = "Form_BookManager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label Label_BookManagement;
        private Button Button_Save;
        private Button Button_Reload;
    }
}
