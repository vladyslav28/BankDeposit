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
            buttonCancel = new Button();
            dateTimePickerLastOperation = new DateTimePicker();
            dateTimePickerBirth = new DateTimePicker();
            buttonEditOk = new Button();
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
            panelEdit.Controls.Add(buttonCancel);
            panelEdit.Controls.Add(dateTimePickerLastOperation);
            panelEdit.Controls.Add(dateTimePickerBirth);
            panelEdit.Controls.Add(buttonEditOk);
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
            panelEdit.Location = new Point(60, 29);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(671, 272);
            panelEdit.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(323, 229);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(95, 40);
            buttonCancel.TabIndex = 28;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerLastOperation
            // 
            dateTimePickerLastOperation.Format = DateTimePickerFormat.Custom;
            dateTimePickerLastOperation.Location = new Point(387, 129);
            dateTimePickerLastOperation.MaxDate = new DateTime(2024, 5, 28, 0, 0, 0, 0);
            dateTimePickerLastOperation.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerLastOperation.Name = "dateTimePickerLastOperation";
            dateTimePickerLastOperation.Size = new Size(184, 27);
            dateTimePickerLastOperation.TabIndex = 27;
            dateTimePickerLastOperation.Value = new DateTime(2024, 5, 28, 0, 0, 0, 0);
            dateTimePickerLastOperation.ValueChanged += dateTimePickerLastOperation_ValueChanged;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirth.Location = new Point(387, 46);
            dateTimePickerBirth.MaxDate = new DateTime(2024, 5, 28, 0, 0, 0, 0);
            dateTimePickerBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(184, 27);
            dateTimePickerBirth.TabIndex = 26;
            dateTimePickerBirth.Value = new DateTime(2024, 5, 28, 0, 0, 0, 0);
            dateTimePickerBirth.ValueChanged += dateTimePickerBirth_ValueChanged;
            // 
            // buttonEditOk
            // 
            buttonEditOk.DialogResult = DialogResult.OK;
            buttonEditOk.Location = new Point(222, 229);
            buttonEditOk.Name = "buttonEditOk";
            buttonEditOk.Size = new Size(95, 40);
            buttonEditOk.TabIndex = 25;
            buttonEditOk.Text = "Ok";
            buttonEditOk.UseVisualStyleBackColor = true;
            buttonEditOk.Click += buttonEditOk_Click;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(130, 48);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(187, 27);
            nameBox.TabIndex = 16;
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
            labelDateLastOperation.Location = new Point(387, 95);
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
            idBox.Size = new Size(187, 27);
            idBox.TabIndex = 15;
            // 
            // labelDateBirth
            // 
            labelDateBirth.AutoSize = true;
            labelDateBirth.Location = new Point(387, 16);
            labelDateBirth.Name = "labelDateBirth";
            labelDateBirth.Size = new Size(133, 20);
            labelDateBirth.TabIndex = 21;
            labelDateBirth.Text = "Дата народження";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(51, 87);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(76, 20);
            labelCategory.TabIndex = 17;
            labelCategory.Text = "Категорія";
            // 
            // sumBox
            // 
            sumBox.Location = new Point(130, 129);
            sumBox.Name = "sumBox";
            sumBox.Size = new Size(187, 27);
            sumBox.TabIndex = 20;
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Location = new Point(130, 87);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(187, 28);
            categoryBox.TabIndex = 18;
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Location = new Point(71, 129);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(44, 20);
            labelSum.TabIndex = 19;
            labelSum.Text = "Сума";
            // 
            // BankAccountEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelEdit);
            Name = "BankAccountEditForm";
            Text = "BankAccountEditForm";
            panelEdit.ResumeLayout(false);
            panelEdit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEdit;
        private Button buttonEditOk;
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
    }
}