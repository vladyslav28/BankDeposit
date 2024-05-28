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
            buttonAdd = new Button();
            panelAdd.SuspendLayout();
            SuspendLayout();
            // 
            // panelAdd
            // 
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
            panelAdd.Controls.Add(buttonAdd);
            panelAdd.Location = new Point(69, 40);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(623, 256);
            panelAdd.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(338, 216);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(76, 27);
            buttonCancel.TabIndex = 40;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerLastOperation
            // 
            dateTimePickerLastOperation.Format = DateTimePickerFormat.Custom;
            dateTimePickerLastOperation.Location = new Point(362, 147);
            dateTimePickerLastOperation.MaxDate = new DateTime(2024, 5, 28, 0, 0, 0, 0);
            dateTimePickerLastOperation.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerLastOperation.Name = "dateTimePickerLastOperation";
            dateTimePickerLastOperation.Size = new Size(184, 27);
            dateTimePickerLastOperation.TabIndex = 39;
            dateTimePickerLastOperation.Value = new DateTime(2024, 5, 28, 0, 0, 0, 0);
            dateTimePickerLastOperation.ValueChanged += dateTimePickerLastOperation_ValueChanged;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirth.Location = new Point(362, 62);
            dateTimePickerBirth.MaxDate = new DateTime(2024, 5, 28, 0, 0, 0, 0);
            dateTimePickerBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(184, 27);
            dateTimePickerBirth.TabIndex = 38;
            dateTimePickerBirth.Value = new DateTime(2024, 5, 28, 0, 0, 0, 0);
            dateTimePickerBirth.ValueChanged += dateTimePickerBirth_ValueChanged;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(106, 57);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(187, 27);
            nameBox.TabIndex = 31;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(69, 18);
            labelId.Name = "labelId";
            labelId.Size = new Size(22, 20);
            labelId.TabIndex = 28;
            labelId.Text = "Id";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(58, 57);
            labelName.Name = "labelName";
            labelName.Size = new Size(33, 20);
            labelName.TabIndex = 29;
            labelName.Text = "ПІБ";
            // 
            // labelDateLastOperation
            // 
            labelDateLastOperation.AutoSize = true;
            labelDateLastOperation.Location = new Point(363, 104);
            labelDateLastOperation.Name = "labelDateLastOperation";
            labelDateLastOperation.Size = new Size(178, 20);
            labelDateLastOperation.TabIndex = 37;
            labelDateLastOperation.Text = "Дата останньої операції";
            // 
            // idBox
            // 
            idBox.Enabled = false;
            idBox.Location = new Point(106, 18);
            idBox.Name = "idBox";
            idBox.Size = new Size(187, 27);
            idBox.TabIndex = 30;
            // 
            // labelDateBirth
            // 
            labelDateBirth.AutoSize = true;
            labelDateBirth.Location = new Point(363, 25);
            labelDateBirth.Name = "labelDateBirth";
            labelDateBirth.Size = new Size(133, 20);
            labelDateBirth.TabIndex = 36;
            labelDateBirth.Text = "Дата народження";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(27, 96);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(76, 20);
            labelCategory.TabIndex = 32;
            labelCategory.Text = "Категорія";
            // 
            // sumBox
            // 
            sumBox.Location = new Point(106, 138);
            sumBox.Name = "sumBox";
            sumBox.Size = new Size(187, 27);
            sumBox.TabIndex = 35;
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Location = new Point(106, 96);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(187, 28);
            categoryBox.TabIndex = 33;
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Location = new Point(47, 138);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(44, 20);
            labelSum.TabIndex = 34;
            labelSum.Text = "Сума";
            // 
            // buttonAdd
            // 
            buttonAdd.DialogResult = DialogResult.OK;
            buttonAdd.Location = new Point(246, 216);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(73, 27);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Ok";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // BankAccountAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAdd);
            Name = "BankAccountAddForm";
            Text = "BankAccountAddForm";
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAdd;
        private Button buttonAdd;
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