namespace BankDeposit.Forms
{
    partial class BankAccountEditForm
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
            panelEdit = new Panel();
            buttonOk = new Button();
            labelInfoCategory = new Label();
            labelInfoSum = new Label();
            labelInfoName = new Label();
            labelErrorCategory = new Label();
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
            panelEdit.SuspendLayout();
            SuspendLayout();
            // 
            // panelEdit
            // 
            panelEdit.Anchor = AnchorStyles.Top;
            panelEdit.BorderStyle = BorderStyle.FixedSingle;
            panelEdit.Controls.Add(buttonOk);
            panelEdit.Controls.Add(labelInfoCategory);
            panelEdit.Controls.Add(labelInfoSum);
            panelEdit.Controls.Add(labelInfoName);
            panelEdit.Controls.Add(labelErrorCategory);
            panelEdit.Controls.Add(labelErrorSum);
            panelEdit.Controls.Add(labelErrorName);
            panelEdit.Controls.Add(label4);
            panelEdit.Controls.Add(buttonCancel);
            panelEdit.Controls.Add(dateTimePickerLastOperation);
            panelEdit.Controls.Add(dateTimePickerBirth);
            panelEdit.Controls.Add(nameBox);
            panelEdit.Controls.Add(labelId);
            panelEdit.Controls.Add(labelName);
            panelEdit.Controls.Add(labelDateLastOperation);
            panelEdit.Controls.Add(idBox);
            panelEdit.Controls.Add(labelDateBirth);
            panelEdit.Controls.Add(labelCategory);
            panelEdit.Controls.Add(sumBox);
            panelEdit.Controls.Add(categoryBox);
            panelEdit.Controls.Add(labelSum);
            panelEdit.Location = new Point(13, 14);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(671, 272);
            panelEdit.TabIndex = 0;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(230, 236);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(116, 33);
            buttonOk.TabIndex = 6;
            buttonOk.Text = "Oк";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // labelInfoCategory
            // 
            labelInfoCategory.AutoSize = true;
            labelInfoCategory.Font = new Font("Segoe UI", 8.5F);
            labelInfoCategory.ForeColor = Color.Red;
            labelInfoCategory.Location = new Point(130, 190);
            labelInfoCategory.Name = "labelInfoCategory";
            labelInfoCategory.Size = new Size(0, 20);
            labelInfoCategory.TabIndex = 76;
            labelInfoCategory.Visible = false;
            // 
            // labelInfoSum
            // 
            labelInfoSum.AutoSize = true;
            labelInfoSum.Font = new Font("Segoe UI", 8.5F);
            labelInfoSum.ForeColor = Color.Red;
            labelInfoSum.Location = new Point(130, 136);
            labelInfoSum.Name = "labelInfoSum";
            labelInfoSum.Size = new Size(0, 20);
            labelInfoSum.TabIndex = 75;
            labelInfoSum.Visible = false;
            // 
            // labelInfoName
            // 
            labelInfoName.AutoSize = true;
            labelInfoName.Font = new Font("Segoe UI", 8.5F);
            labelInfoName.ForeColor = Color.Red;
            labelInfoName.Location = new Point(130, 83);
            labelInfoName.Name = "labelInfoName";
            labelInfoName.Size = new Size(0, 20);
            labelInfoName.TabIndex = 74;
            labelInfoName.Visible = false;
            // 
            // labelErrorCategory
            // 
            labelErrorCategory.AutoSize = true;
            labelErrorCategory.ForeColor = Color.Red;
            labelErrorCategory.Location = new Point(323, 162);
            labelErrorCategory.Name = "labelErrorCategory";
            labelErrorCategory.Size = new Size(15, 20);
            labelErrorCategory.TabIndex = 73;
            labelErrorCategory.Text = "*";
            labelErrorCategory.Visible = false;
            // 
            // labelErrorSum
            // 
            labelErrorSum.AutoSize = true;
            labelErrorSum.ForeColor = Color.Red;
            labelErrorSum.Location = new Point(323, 111);
            labelErrorSum.Name = "labelErrorSum";
            labelErrorSum.Size = new Size(15, 20);
            labelErrorSum.TabIndex = 69;
            labelErrorSum.Text = "*";
            labelErrorSum.Visible = false;
            // 
            // labelErrorName
            // 
            labelErrorName.AutoSize = true;
            labelErrorName.ForeColor = Color.Red;
            labelErrorName.Location = new Point(323, 53);
            labelErrorName.Name = "labelErrorName";
            labelErrorName.Size = new Size(15, 20);
            labelErrorName.TabIndex = 68;
            labelErrorName.Text = "*";
            labelErrorName.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Location = new Point(300, 111);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 66;
            label4.Text = "₴";
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(352, 236);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(116, 33);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerLastOperation
            // 
            dateTimePickerLastOperation.Format = DateTimePickerFormat.Custom;
            dateTimePickerLastOperation.Location = new Point(467, 131);
            dateTimePickerLastOperation.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerLastOperation.Name = "dateTimePickerLastOperation";
            dateTimePickerLastOperation.Size = new Size(184, 27);
            dateTimePickerLastOperation.TabIndex = 5;
            dateTimePickerLastOperation.ValueChanged += dateTimePickerLastOperation_ValueChanged;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirth.Location = new Point(467, 48);
            dateTimePickerBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(184, 27);
            dateTimePickerBirth.TabIndex = 4;
            dateTimePickerBirth.ValueChanged += dateTimePickerBirth_ValueChanged;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(130, 50);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(193, 27);
            nameBox.TabIndex = 1;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(93, 9);
            labelId.Name = "labelId";
            labelId.Size = new Size(22, 20);
            labelId.TabIndex = 13;
            labelId.Text = "Id";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(82, 48);
            labelName.Name = "labelName";
            labelName.Size = new Size(33, 20);
            labelName.TabIndex = 14;
            labelName.Text = "ПІБ";
            // 
            // labelDateLastOperation
            // 
            labelDateLastOperation.AutoSize = true;
            labelDateLastOperation.Location = new Point(467, 97);
            labelDateLastOperation.Name = "labelDateLastOperation";
            labelDateLastOperation.Size = new Size(178, 20);
            labelDateLastOperation.TabIndex = 22;
            labelDateLastOperation.Text = "Дата останньої операції";
            // 
            // idBox
            // 
            idBox.Enabled = false;
            idBox.Location = new Point(130, 9);
            idBox.Name = "idBox";
            idBox.Size = new Size(193, 27);
            idBox.TabIndex = 15;
            idBox.TabStop = false;
            // 
            // labelDateBirth
            // 
            labelDateBirth.AutoSize = true;
            labelDateBirth.Location = new Point(467, 18);
            labelDateBirth.Name = "labelDateBirth";
            labelDateBirth.Size = new Size(133, 20);
            labelDateBirth.TabIndex = 21;
            labelDateBirth.Text = "Дата народження";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(39, 162);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(76, 20);
            labelCategory.TabIndex = 17;
            labelCategory.Text = "Категорія";
            // 
            // sumBox
            // 
            sumBox.Location = new Point(130, 106);
            sumBox.Name = "sumBox";
            sumBox.Size = new Size(193, 27);
            sumBox.TabIndex = 2;
            sumBox.TextChanged += sumBox_TextChanged;
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Location = new Point(130, 159);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(193, 28);
            categoryBox.TabIndex = 3;
            categoryBox.SelectedIndexChanged += categoryBox_SelectedIndexChanged;
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Location = new Point(71, 106);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(44, 20);
            labelSum.TabIndex = 19;
            labelSum.Text = "Сума";
            // 
            // BankAccountEditForm
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(698, 300);
            Controls.Add(panelEdit);
            MinimumSize = new Size(716, 347);
            Name = "BankAccountEditForm";
            Text = "Редагування акаунта";
            panelEdit.ResumeLayout(false);
            panelEdit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEdit;
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
        private Label labelErrorName;
        private Label labelErrorSum;
        private Label labelErrorCategory;
        private Label labelInfoName;
        private Label labelInfoSum;
        private Label labelInfoCategory;
        private Button buttonOk;
    }
}