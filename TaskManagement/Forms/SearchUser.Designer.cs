namespace TaskManagement.Forms
{
    partial class SearchUser
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
            this.AllUserGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RerunButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_All = new System.Windows.Forms.TabPage();
            this.tab_Id = new System.Windows.Forms.TabPage();
            this.RunButton = new System.Windows.Forms.Button();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.FoundUserGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AllUserGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab_All.SuspendLayout();
            this.tab_Id.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoundUserGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllUserGridView
            // 
            this.AllUserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllUserGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.AllUserGridView.Location = new System.Drawing.Point(6, 6);
            this.AllUserGridView.Name = "AllUserGridView";
            this.AllUserGridView.RowTemplate.Height = 21;
            this.AllUserGridView.Size = new System.Drawing.Size(244, 426);
            this.AllUserGridView.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // RerunButton
            // 
            this.RerunButton.Location = new System.Drawing.Point(256, 6);
            this.RerunButton.Name = "RerunButton";
            this.RerunButton.Size = new System.Drawing.Size(75, 23);
            this.RerunButton.TabIndex = 1;
            this.RerunButton.Text = "Rerun";
            this.RerunButton.UseVisualStyleBackColor = true;
            this.RerunButton.Click += new System.EventHandler(this.RerunButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_All);
            this.tabControl1.Controls.Add(this.tab_Id);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(346, 543);
            this.tabControl1.TabIndex = 2;
            // 
            // tab_All
            // 
            this.tab_All.Controls.Add(this.AllUserGridView);
            this.tab_All.Controls.Add(this.RerunButton);
            this.tab_All.Location = new System.Drawing.Point(4, 22);
            this.tab_All.Name = "tab_All";
            this.tab_All.Padding = new System.Windows.Forms.Padding(3);
            this.tab_All.Size = new System.Drawing.Size(338, 517);
            this.tab_All.TabIndex = 0;
            this.tab_All.Text = "All";
            this.tab_All.UseVisualStyleBackColor = true;
            // 
            // tab_Id
            // 
            this.tab_Id.Controls.Add(this.RunButton);
            this.tab_Id.Controls.Add(this.UserIdTextBox);
            this.tab_Id.Controls.Add(this.FoundUserGridView);
            this.tab_Id.Location = new System.Drawing.Point(4, 22);
            this.tab_Id.Name = "tab_Id";
            this.tab_Id.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Id.Size = new System.Drawing.Size(338, 517);
            this.tab_Id.TabIndex = 1;
            this.tab_Id.Text = "Id";
            this.tab_Id.UseVisualStyleBackColor = true;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(251, 6);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 5;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(129, 8);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(116, 19);
            this.UserIdTextBox.TabIndex = 4;
            this.UserIdTextBox.Text = "Please Enter User Id";
            // 
            // FoundUserGridView
            // 
            this.FoundUserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoundUserGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.FoundUserGridView.Location = new System.Drawing.Point(8, 33);
            this.FoundUserGridView.Name = "FoundUserGridView";
            this.FoundUserGridView.RowTemplate.Height = 21;
            this.FoundUserGridView.Size = new System.Drawing.Size(245, 150);
            this.FoundUserGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // SearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "SearchUser";
            this.Text = "SearchAllUser";
            ((System.ComponentModel.ISupportInitialize)(this.AllUserGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab_All.ResumeLayout(false);
            this.tab_Id.ResumeLayout(false);
            this.tab_Id.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoundUserGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllUserGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button RerunButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_All;
        private System.Windows.Forms.TabPage tab_Id;
        private System.Windows.Forms.DataGridView FoundUserGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.Button RunButton;
    }
}