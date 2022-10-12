namespace ToDoListApp
{
    partial class MainForm
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
            this.gbAddNewTask = new System.Windows.Forms.GroupBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTaskList = new System.Windows.Forms.GroupBox();
            this.dgvTaskList = new System.Windows.Forms.DataGridView();
            this.gbAddNewTask.SuspendLayout();
            this.gbTaskList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddNewTask
            // 
            this.gbAddNewTask.Controls.Add(this.btnAddTask);
            this.gbAddNewTask.Controls.Add(this.txtTaskName);
            this.gbAddNewTask.Controls.Add(this.label1);
            this.gbAddNewTask.Location = new System.Drawing.Point(13, 13);
            this.gbAddNewTask.Name = "gbAddNewTask";
            this.gbAddNewTask.Size = new System.Drawing.Size(278, 179);
            this.gbAddNewTask.TabIndex = 0;
            this.gbAddNewTask.TabStop = false;
            this.gbAddNewTask.Text = "Add Task";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(11, 128);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(256, 35);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(11, 68);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(256, 29);
            this.txtTaskName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Name";
            // 
            // gbTaskList
            // 
            this.gbTaskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTaskList.Controls.Add(this.dgvTaskList);
            this.gbTaskList.Location = new System.Drawing.Point(297, 13);
            this.gbTaskList.Name = "gbTaskList";
            this.gbTaskList.Size = new System.Drawing.Size(272, 416);
            this.gbTaskList.TabIndex = 1;
            this.gbTaskList.TabStop = false;
            this.gbTaskList.Text = "Task List";
            // 
            // dgvTaskList
            // 
            this.dgvTaskList.AllowUserToAddRows = false;
            this.dgvTaskList.AllowUserToDeleteRows = false;
            this.dgvTaskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaskList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaskList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTaskList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskList.GridColor = System.Drawing.SystemColors.Control;
            this.dgvTaskList.Location = new System.Drawing.Point(7, 29);
            this.dgvTaskList.MultiSelect = false;
            this.dgvTaskList.Name = "dgvTaskList";
            this.dgvTaskList.RowHeadersVisible = false;
            this.dgvTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaskList.Size = new System.Drawing.Size(261, 387);
            this.dgvTaskList.TabIndex = 0;
            this.dgvTaskList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTaskList_CellMouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(577, 435);
            this.Controls.Add(this.gbTaskList);
            this.Controls.Add(this.gbAddNewTask);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(593, 474);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To-Do List App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.gbAddNewTask.ResumeLayout(false);
            this.gbAddNewTask.PerformLayout();
            this.gbTaskList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddNewTask;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTaskList;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.DataGridView dgvTaskList;
    }
}

