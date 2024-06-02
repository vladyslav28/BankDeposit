namespace BankDeposit.Forms
{
    partial class BankAccountAddForm
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
            panelAdd = new Panel();
            labelInfoCategory = new Label();
            labelErrorCategory = new Label();
            buttonOk = new Button();
            labelInfoSum = new Label();
            labelInfoName = new Label();
            labelErrorSum = new Label();
            labelErrorName = new Label();
            label4 = new Label();
            buttonCancel = new Button();
            dateTimePickerLastOperation = new DateTimePicker();
            dateTimePickerBirth = new DateTimePicker();
            nameBox = new TextBox();
            labelId = new Label();
            labelName = new Label();
            labelDateLastOperation = new Label();
            idBox = new TextBox();
            labelDateBirth = new Label();
            labelCategory = new Label();
            sumBox = new TextBox();
            categoryBox = new ComboBox();
            labelSum = new Label();
            panelAdd.SuspendLayout();
            SuspendLayout();
            // 
            // panelAdd
            // 
            panelAdd.Anchor = AnchorStyles.Top;
            panelAdd.BorderStyle = BorderStyle.FixedSingle;
            panelAdd.Controls.Add(labelInfoCategory);
            panelAdd.Controls.Add(labelErrorCategory);
            panelAdd.Controls.Add(buttonOk);
            panelAdd.Controls.Add(labelInfoSum);
            panelAdd.Controls.Add(labelInfoName);
            panelAdd.Controls.Add(labelErrorSum);
            panelAdd.Controls.Add(labelErrorName);
            panelAdd.Controls.Add(label4);
            panelAdd.Controls.Add(buttonCancel);
            panelAdd.Controls.Add(dateTimePickerLastOperation);
            panelAdd.Controls.Add(dateTimePickerBirth);
            panelAdd.Controls.Add(nameBox);
            panelAdd.Controls.Add(labelId);
            panelAdd.Controls.Add(labelName);
            panelAdd.Controls.Add(labelDateLastOperation);
            panelAdd.Controls.Add(idBox);
            panelAdd.Controls.Add(labelDateBirth);
            panelAdd.Controls.Add(labelCategory);
            panelAdd.Controls.Add(sumBox);
            panelAdd.Controls.Add(categoryBox);
            panelAdd.Controls.Add(labelSum);
            panelAdd.Location = new Point(12, 14);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(626, 283);
            panelAdd.TabIndex = 0;
            // 
            // labelInfoCategory
            // 
            labelInfoCategory.AutoSize = true;
            labelInfoCategory.Font = new Font("Segoe UI", 8.5F);
            labelInfoCategory.ForeColor = Color.Red;
            labelInfoCategory.Location = new Point(85, 193);
            labelInfoCategory.Name = "labelInfoCategory";
            labelInfoCategory.Size = new Size(0, 20);
            labelInfoCategory.TabIndex = 73;
            labelInfoCategory.Visible = false;
            // 
            // labelErrorCategory
            // 
            labelErrorCategory.AutoSize = true;
            labelErrorCategory.ForeColor = Color.Red;
            labelErrorCategory.Location = new Point(284, 170);
            labelErrorCategory.Name = "labelErrorCategory";
            labelErrorCategory.Size = new Size(15, 20);
            labelErrorCategory.TabIndex = 72;
            labelErrorCategory.Text = "*";
            labelErrorCategory.Visible = false;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.None;
            buttonOk.Location = new Point(196, 246);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(116, 29);
            buttonOk.TabIndex = 6;
            buttonOk.Text = "Oк";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // labelInfoSum
            // 
            labelInfoSum.AutoSize = true;
            labelInfoSum.Font = new Font("Segoe UI", 8.5F);
            labelInfoSum.ForeColor = Color.Red;
            labelInfoSum.Location = new Point(85, 140);
            labelInfoSum.Name = "labelInfoSum";
            labelInfoSum.Size = new Size(0, 20);
            labelInfoSum.TabIndex = 70;
            labelInfoSum.Visible = false;
            // 
            // labelInfoName
            // 
            labelInfoName.AutoSize = true;
            labelInfoName.Font = new Font("Segoe UI", 8.5F);
            labelInfoName.ForeColor = Color.Red;
            labelInfoName.Location = new Point(85, 89);
            labelInfoName.Name = "labelInfoName";
            labelInfoName.Size = new Size(0, 20);
            labelInfoName.TabIndex = 69;
            labelInfoName.Visible = false;
            // 
            // labelErrorSum
            // 
            labelErrorSum.AutoSize = true;
            labelErrorSum.ForeColor = Color.Red;
            labelErrorSum.Location = new Point(284, 113);
            labelErrorSum.Name = "labelErrorSum";
            labelErrorSum.Size = new Size(15, 20);
            labelErrorSum.TabIndex = 68;
            labelErrorSum.Text = "*";
            labelErrorSum.Visible = false;
            // 
            // labelErrorName
            // 
            labelErrorName.AutoSize = true;
            labelErrorName.ForeColor = Color.Red;
            labelErrorName.Location = new Point(284, 62);
            labelErrorName.Name = "labelErrorName";
            labelErrorName.Size = new Size(15, 20);
            labelErrorName.TabIndex = 67;
            labelErrorName.Text = "*";
            labelErrorName.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Location = new Point(255, 113);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 66;
            label4.Text = "₴";
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(321, 247);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(116, 29);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerLastOperation
            // 
            dateTimePickerLastOperation.Format = DateTimePickerFormat.Custom;
            dateTimePickerLastOperation.Location = new Point(410, 147);
            dateTimePickerLastOperation.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerLastOperation.Name = "dateTimePickerLastOperation";
            dateTimePickerLastOperation.Size = new Size(184, 27);
            dateTimePickerLastOperation.TabIndex = 5;
            dateTimePickerLastOperation.ValueChanged += dateTimePickerLastOperation_ValueChanged;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirth.Location = new Point(410, 62);
            dateTimePickerBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(184, 27);
            dateTimePickerBirth.TabIndex = 4;
            dateTimePickerBirth.ValueChanged += dateTimePickerBirth_ValueChanged;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(85, 59);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(193, 27);
            nameBox.TabIndex = 1;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(57, 18);
            labelId.Name = "labelId";
            labelId.Size = new Size(22, 20);
            labelId.TabIndex = 28;
            labelId.Text = "Id";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(46, 57);
            labelName.Name = "labelName";
            labelName.Size = new Size(33, 20);
            labelName.TabIndex = 29;
            labelName.Text = "ПІБ";
            // 
            // labelDateLastOperation
            // 
            labelDateLastOperation.AutoSize = true;
            labelDateLastOperation.Location = new Point(411, 104);
            labelDateLastOperation.Name = "labelDateLastOperation";
            labelDateLastOperation.Size = new Size(178, 20);
            labelDateLastOperation.TabIndex = 37;
            labelDateLastOperation.Text = "Дата останньої операції";
            // 
            // idBox
            // 
            idBox.Enabled = false;
            idBox.Location = new Point(85, 15);
            idBox.Name = "idBox";
            idBox.Size = new Size(193, 27);
            idBox.TabIndex = 1;
            idBox.TabStop = false;
            // 
            // labelDateBirth
            // 
            labelDateBirth.AutoSize = true;
            labelDateBirth.Location = new Point(411, 25);
            labelDateBirth.Name = "labelDateBirth";
            labelDateBirth.Size = new Size(133, 20);
            labelDateBirth.TabIndex = 36;
            labelDateBirth.Text = "Дата народження";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(3, 166);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(76, 20);
            labelCategory.TabIndex = 32;
            labelCategory.Text = "Категорія";
            // 
            // sumBox
            // 
            sumBox.Location = new Point(85, 110);
            sumBox.Name = "sumBox";
            sumBox.Size = new Size(193, 27);
            sumBox.TabIndex = 2;
            sumBox.TextChanged += sumBox_TextChanged;
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Location = new Point(85, 162);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(193, 28);
            categoryBox.TabIndex = 3;
            categoryBox.SelectedIndexChanged += categoryBox_SelectedIndexChanged;
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Location = new Point(35, 113);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(44, 20);
            labelSum.TabIndex = 34;
            labelSum.Text = "Сума";
            // 
            // BankAccountAddForm
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(655, 315);
            Controls.Add(panelAdd);
            MinimumSize = new Size(673, 362);
            Name = "BankAccountAddForm";
            Text = "Додання акаунта";
            Load += BankAccountAddForm_Load;
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAdd;
        private TextBox nameBox;
        private Label labelId;
        private Label labelName;
        private Label labelDateLastOperation;
        private TextBox idBox;
        private Label labelDateBirth;
        private Label labelCategory;
        private TextBox sumBox;
        private ComboBox categoryBox;
        private Label labelSum;
        private DateTimePicker dateTimePickerBirth;
        private DateTimePicker dateTimePickerLastOperation;
        private Button buttonCancel;
        private Label label4;
        private Label labelInfoSum;
        private Label labelInfoName;
        private Label labelErrorSum;
        private Label labelErrorName;
        private Button buttonOk;
        private Label labelInfoCategory;
        private Label labelErrorCategory;
    }
}