﻿namespace ServiceHR.UserInterface.Forms.Employees
{
    partial class EmployeesForm
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
            this.components = new System.ComponentModel.Container();
            this.tlpEmployees = new System.Windows.Forms.TableLayoutPanel();
            this.pEmployees = new System.Windows.Forms.Panel();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
            this.tlpEmployees.SuspendLayout();
            this.pEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpEmployees
            // 
            this.tlpEmployees.ColumnCount = 1;
            this.tlpEmployees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployees.Controls.Add(this.pEmployees, 0, 0);
            this.tlpEmployees.Controls.Add(this.dgvEmployees, 0, 1);
            this.tlpEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmployees.Location = new System.Drawing.Point(0, 0);
            this.tlpEmployees.Name = "tlpEmployees";
            this.tlpEmployees.RowCount = 2;
            this.tlpEmployees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpEmployees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployees.Size = new System.Drawing.Size(800, 450);
            this.tlpEmployees.TabIndex = 0;
            // 
            // pEmployees
            // 
            this.pEmployees.BackColor = System.Drawing.Color.White;
            this.pEmployees.Controls.Add(this.btnSendEmail);
            this.pEmployees.Controls.Add(this.btnRefresh);
            this.pEmployees.Controls.Add(this.btnRemove);
            this.pEmployees.Controls.Add(this.btnDismiss);
            this.pEmployees.Controls.Add(this.btnModify);
            this.pEmployees.Controls.Add(this.btnCreate);
            this.pEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEmployees.Location = new System.Drawing.Point(3, 3);
            this.pEmployees.Name = "pEmployees";
            this.pEmployees.Size = new System.Drawing.Size(794, 34);
            this.pEmployees.TabIndex = 0;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.Color.White;
            this.btnSendEmail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendEmail.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSendEmail.Image = global::ServiceHR.UserInterface.Properties.Resources.email;
            this.btnSendEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendEmail.Location = new System.Drawing.Point(684, 0);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnSendEmail.Size = new System.Drawing.Size(110, 34);
            this.btnSendEmail.TabIndex = 5;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendEmail.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::ServiceHR.UserInterface.Properties.Resources.refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(360, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnRefresh.Size = new System.Drawing.Size(90, 34);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Image = global::ServiceHR.UserInterface.Properties.Resources.remove;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(270, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnRemove.Size = new System.Drawing.Size(90, 34);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnDismiss
            // 
            this.btnDismiss.BackColor = System.Drawing.Color.White;
            this.btnDismiss.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDismiss.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDismiss.Image = global::ServiceHR.UserInterface.Properties.Resources.dismiss;
            this.btnDismiss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDismiss.Location = new System.Drawing.Point(180, 0);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDismiss.Size = new System.Drawing.Size(90, 34);
            this.btnDismiss.TabIndex = 2;
            this.btnDismiss.Text = "Dismiss";
            this.btnDismiss.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDismiss.UseVisualStyleBackColor = false;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Image = global::ServiceHR.UserInterface.Properties.Resources.edit_1_;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(90, 0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnModify.Size = new System.Drawing.Size(90, 34);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modify";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreate.Image = global::ServiceHR.UserInterface.Properties.Resources.add_1_;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnCreate.Size = new System.Drawing.Size(90, 34);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoGenerateColumns = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colLastName,
            this.colFirstName,
            this.colCode,
            this.colPosition,
            this.colStatus});
            this.dgvEmployees.DataSource = this.bsEmployees;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(3, 43);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(794, 404);
            this.dgvEmployees.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.ToolTipText = "Last name of employee";
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.ToolTipText = "First name of employee";
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.ToolTipText = "Employee code";
            // 
            // colPosition
            // 
            this.colPosition.DataPropertyName = "Position";
            this.colPosition.HeaderText = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            this.colPosition.ToolTipText = "Actual position of employee";
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.ToolTipText = "Employee status";
            // 
            // bsEmployees
            // 
            this.bsEmployees.DataSource = typeof(ServiceHR.DataAccessLayer.ViewModel.EmployeeViewModel);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpEmployees);
            this.Name = "EmployeesForm";
            this.Text = "Employees";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeesForm_FormClosed);
            this.tlpEmployees.ResumeLayout(false);
            this.pEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEmployees;
        private System.Windows.Forms.Panel pEmployees;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.BindingSource bsEmployees;
    }
}