namespace BankDeposit.Forms
{
    partial class MoneyOperationForm
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
            panelMoney = new Panel();
            buttonCancel = new Button();
            label4 = new Label();
            buttonOk = new Button();
            errorInfoAmountLabel = new Label();
            errorSumLabel = new Label();
            applyInterest = new Button();
            buttonDeposit = new Button();
            buttonWithdraw = new Button();
            textBoxAmount = new TextBox();
            buttonIdSearch = new Button();
            label3 = new Label();
            sumLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            categoryLabel = new Label();
            nameLabel = new Label();
            dateTimePickerLastOperation = new DateTimePicker();
            labelId = new Label();
            labelName = new Label();
            labelDateLastOperation = new Label();
            idBox = new TextBox();
            labelCategory = new Label();
            labelSum = new Label();
            panelMoney.SuspendLayout();
            SuspendLayout();
            // 
            // panelMoney
            // 
            panelMoney.Anchor = AnchorStyles.Top;
            panelMoney.BorderStyle = BorderStyle.FixedSingle;
            panelMoney.Controls.Add(buttonCancel);
            panelMoney.Controls.Add(label4);
            panelMoney.Controls.Add(buttonOk);
            panelMoney.Controls.Add(errorInfoAmountLabel);
            panelMoney.Controls.Add(errorSumLabel);
            panelMoney.Controls.Add(applyInterest);
            panelMoney.Controls.Add(buttonDeposit);
            panelMoney.Controls.Add(buttonWithdraw);
            panelMoney.Controls.Add(textBoxAmount);
            panelMoney.Controls.Add(buttonIdSearch);
            panelMoney.Controls.Add(label3);
            panelMoney.Controls.Add(sumLabel);
            panelMoney.Controls.Add(label2);
            panelMoney.Controls.Add(label1);
            panelMoney.Controls.Add(categoryLabel);
            panelMoney.Controls.Add(nameLabel);
            panelMoney.Controls.Add(dateTimePickerLastOperation);
            panelMoney.Controls.Add(labelId);
            panelMoney.Controls.Add(labelName);
            panelMoney.Controls.Add(labelDateLastOperation);
            panelMoney.Controls.Add(idBox);
            panelMoney.Controls.Add(labelCategory);
            panelMoney.Controls.Add(labelSum);
            panelMoney.Location = new Point(29, 30);
            panelMoney.Name = "panelMoney";
            panelMoney.Size = new Size(484, 281);
            panelMoney.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(232, 248);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(116, 30);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Location = new Point(258, 146);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 65;
            label4.Text = "₴";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(99, 248);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(116, 30);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "Oк";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // errorInfoAmountLabel
            // 
            errorInfoAmountLabel.AutoSize = true;
            errorInfoAmountLabel.Font = new Font("Segoe UI", 6F);
            errorInfoAmountLabel.ForeColor = Color.Red;
            errorInfoAmountLabel.Location = new Point(114, 173);
            errorInfoAmountLabel.Name = "errorInfoAmountLabel";
            errorInfoAmountLabel.Size = new Size(0, 12);
            errorInfoAmountLabel.TabIndex = 64;
            errorInfoAmountLabel.Visible = false;
            // 
            // errorSumLabel
            // 
            errorSumLabel.AutoSize = true;
            errorSumLabel.ForeColor = Color.Red;
            errorSumLabel.Location = new Point(281, 146);
            errorSumLabel.Name = "errorSumLabel";
            errorSumLabel.Size = new Size(15, 20);
            errorSumLabel.TabIndex = 63;
            errorSumLabel.Text = "*";
            errorSumLabel.Visible = false;
            // 
            // applyInterest
            // 
            applyInterest.Location = new Point(3, 143);
            applyInterest.Name = "applyInterest";
            applyInterest.Size = new Size(105, 62);
            applyInterest.TabIndex = 61;
            applyInterest.Text = "Нарахувати відсоток";
            applyInterest.UseVisualStyleBackColor = true;
            applyInterest.Click += applyInterest_Click;
            // 
            // buttonDeposit
            // 
            buttonDeposit.Location = new Point(302, 146);
            buttonDeposit.Name = "buttonDeposit";
            buttonDeposit.Size = new Size(116, 30);
            buttonDeposit.TabIndex = 60;
            buttonDeposit.Text = "Поповнити";
            buttonDeposit.UseVisualStyleBackColor = true;
            buttonDeposit.Click += buttonDeposit_Click;
            // 
            // buttonWithdraw
            // 
            buttonWithdraw.Location = new Point(302, 115);
            buttonWithdraw.Name = "buttonWithdraw";
            buttonWithdraw.Size = new Size(116, 30);
            buttonWithdraw.TabIndex = 59;
            buttonWithdraw.Text = "Зняти";
            buttonWithdraw.UseVisualStyleBackColor = true;
            buttonWithdraw.Click += buttonWithdraw_Click;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(114, 143);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(166, 27);
            textBoxAmount.TabIndex = 58;
            textBoxAmount.TextChanged += textBoxAmount_TextChanged;
            // 
            // buttonIdSearch
            // 
            buttonIdSearch.Location = new Point(153, 3);
            buttonIdSearch.Name = "buttonIdSearch";
            buttonIdSearch.Size = new Size(116, 27);
            buttonIdSearch.TabIndex = 57;
            buttonIdSearch.Text = "пошук";
            buttonIdSearch.UseVisualStyleBackColor = true;
            buttonIdSearch.Click += buttonIdSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 95);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 56;
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Location = new Point(81, 95);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new Size(0, 20);
            sumLabel.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 65);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 35);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 54;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(85, 65);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(0, 20);
            categoryLabel.TabIndex = 55;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(81, 35);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(0, 20);
            nameLabel.TabIndex = 54;
            // 
            // dateTimePickerLastOperation
            // 
            dateTimePickerLastOperation.Enabled = false;
            dateTimePickerLastOperation.Format = DateTimePickerFormat.Custom;
            dateTimePickerLastOperation.Location = new Point(283, 35);
            dateTimePickerLastOperation.Name = "dateTimePickerLastOperation";
            dateTimePickerLastOperation.Size = new Size(191, 27);
            dateTimePickerLastOperation.TabIndex = 53;
            dateTimePickerLastOperation.ValueChanged += dateTimePickerLastOperation_ValueChanged;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(53, 6);
            labelId.Name = "labelId";
            labelId.Size = new Size(22, 20);
            labelId.TabIndex = 40;
            labelId.Text = "Id";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(42, 35);
            labelName.Name = "labelName";
            labelName.Size = new Size(33, 20);
            labelName.TabIndex = 41;
            labelName.Text = "ПІБ";
            // 
            // labelDateLastOperation
            // 
            labelDateLastOperation.AutoSize = true;
            labelDateLastOperation.Location = new Point(283, 10);
            labelDateLastOperation.Name = "labelDateLastOperation";
            labelDateLastOperation.Size = new Size(178, 20);
            labelDateLastOperation.TabIndex = 49;
            labelDateLastOperation.Text = "Дата останньої операції";
            // 
            // idBox
            // 
            idBox.Location = new Point(85, 3);
            idBox.Name = "idBox";
            idBox.Size = new Size(62, 27);
            idBox.TabIndex = 42;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(3, 65);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(76, 20);
            labelCategory.TabIndex = 44;
            labelCategory.Text = "Категорія";
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Location = new Point(14, 95);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(61, 20);
            labelSum.TabIndex = 46;
            labelSum.Text = "Баланс:";
            // 
            // MoneyOperationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 339);
            Controls.Add(panelMoney);
            MinimumSize = new Size(558, 386);
            Name = "MoneyOperationForm";
            Text = "MoneyOperationForm";
            panelMoney.ResumeLayout(false);
            panelMoney.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMoney;
        private Label labelId;
        private Label labelName;
        private Label labelDateLastOperation;
        private TextBox idBox;
        private Label labelCategory;
        private Label labelSum;
        private DateTimePicker dateTimePickerLastOperation;
        private Label nameLabel;
        private Label categoryLabel;
        private Label sumLabel;
        private Button buttonIdSearch;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonWithdraw;
        private TextBox textBoxAmount;
        private Button buttonDeposit;
        private Button applyInterest;
        private Button buttonOk;
        private Button buttonCancel;
        private Label errorSumLabel;
        private Label errorInfoAmountLabel;
        private Label label4;
    }
}