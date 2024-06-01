using System.Data;
using System.Windows.Forms;

namespace BankDeposit.Forms
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            додатиЕлементToolStripMenuItem = new ToolStripMenuItem();
            редагуватиToolStripMenuItem = new ToolStripMenuItem();
            видалитиЕлементToolStripMenuItem = new ToolStripMenuItem();
            фінансовіОпераціїToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            helpWithTypeToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panelSearch = new Panel();
            label4 = new Label();
            erorrInfoSumLabel = new Label();
            errorInfoNameLabel = new Label();
            errorInfoIdLabel = new Label();
            errorIdLabel = new Label();
            errorNameLabel = new Label();
            errorSumLabel = new Label();
            buttonReset = new Button();
            buttonSearch = new Button();
            dateTimePickerLastOperation = new DateTimePicker();
            dateTimePickerBirth = new DateTimePicker();
            labelDateLastOperation = new Label();
            labelDateBirth = new Label();
            sumBox = new TextBox();
            labelSum = new Label();
            categoryBox = new ComboBox();
            labelCategory = new Label();
            nameBox = new TextBox();
            idBox = new TextBox();
            labelName = new Label();
            labelId = new Label();
            resultList = new ListBox();
            bankAccountBindingSource = new BindingSource(components);
            buttonEdit = new Button();
            showBox = new TextBox();
            panelShow = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            buttonDelete = new Button();
            buttonMoney = new Button();
            labelCount = new Label();
            buttonAdd = new Button();
            toolStripSeparator2 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bankAccountBindingSource).BeginInit();
            panelShow.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(224, 26);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "&Вийти";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem, toolStripSeparator2, фінансовіОпераціїToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { додатиЕлементToolStripMenuItem, редагуватиToolStripMenuItem, видалитиЕлементToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(225, 26);
            optionsToolStripMenuItem.Text = "&Операції з даними";
            // 
            // додатиЕлементToolStripMenuItem
            // 
            додатиЕлементToolStripMenuItem.Name = "додатиЕлементToolStripMenuItem";
            додатиЕлементToolStripMenuItem.Size = new Size(224, 26);
            додатиЕлементToolStripMenuItem.Text = "Додати акаунт";
            додатиЕлементToolStripMenuItem.Click += додатиЕлементToolStripMenuItem_Click;
            // 
            // редагуватиToolStripMenuItem
            // 
            редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            редагуватиToolStripMenuItem.Size = new Size(224, 26);
            редагуватиToolStripMenuItem.Text = "Редагувати акаунт";
            редагуватиToolStripMenuItem.Click += редагуватиToolStripMenuItem_Click;
            // 
            // видалитиЕлементToolStripMenuItem
            // 
            видалитиЕлементToolStripMenuItem.Name = "видалитиЕлементToolStripMenuItem";
            видалитиЕлементToolStripMenuItem.Size = new Size(224, 26);
            видалитиЕлементToolStripMenuItem.Text = "Видалити акаунт";
            видалитиЕлементToolStripMenuItem.Click += видалитиToolStripMenuItem_Click;
            // 
            // фінансовіОпераціїToolStripMenuItem
            // 
            фінансовіОпераціїToolStripMenuItem.Name = "фінансовіОпераціїToolStripMenuItem";
            фінансовіОпераціїToolStripMenuItem.Size = new Size(225, 26);
            фінансовіОпераціїToolStripMenuItem.Text = "&Фінансові операції";
            фінансовіОпераціїToolStripMenuItem.Click += фінансовіОпераціїToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpWithTypeToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.ShortcutKeys = Keys.F1;
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(221, 6);
            // 
            // helpWithTypeToolStripMenuItem
            // 
            helpWithTypeToolStripMenuItem.Name = "helpWithTypeToolStripMenuItem";
            helpWithTypeToolStripMenuItem.ShortcutKeys = Keys.F1;
            helpWithTypeToolStripMenuItem.Size = new Size(224, 26);
            helpWithTypeToolStripMenuItem.Text = "&Help with data";
            helpWithTypeToolStripMenuItem.Click += helpWithTypeToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "&About program";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // panelSearch
            // 
            panelSearch.Anchor = AnchorStyles.Top;
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(label4);
            panelSearch.Controls.Add(erorrInfoSumLabel);
            panelSearch.Controls.Add(errorInfoNameLabel);
            panelSearch.Controls.Add(errorInfoIdLabel);
            panelSearch.Controls.Add(errorIdLabel);
            panelSearch.Controls.Add(errorNameLabel);
            panelSearch.Controls.Add(errorSumLabel);
            panelSearch.Controls.Add(buttonReset);
            panelSearch.Controls.Add(buttonSearch);
            panelSearch.Controls.Add(dateTimePickerLastOperation);
            panelSearch.Controls.Add(dateTimePickerBirth);
            panelSearch.Controls.Add(labelDateLastOperation);
            panelSearch.Controls.Add(labelDateBirth);
            panelSearch.Controls.Add(sumBox);
            panelSearch.Controls.Add(labelSum);
            panelSearch.Controls.Add(categoryBox);
            panelSearch.Controls.Add(labelCategory);
            panelSearch.Controls.Add(nameBox);
            panelSearch.Controls.Add(idBox);
            panelSearch.Controls.Add(labelName);
            panelSearch.Controls.Add(labelId);
            panelSearch.Location = new Point(102, 30);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(579, 270);
            panelSearch.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Location = new Point(246, 121);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 66;
            label4.Text = "₴";
            // 
            // erorrInfoSumLabel
            // 
            erorrInfoSumLabel.AutoSize = true;
            erorrInfoSumLabel.Font = new Font("Segoe UI", 7F);
            erorrInfoSumLabel.ForeColor = Color.Red;
            erorrInfoSumLabel.Location = new Point(88, 148);
            erorrInfoSumLabel.Name = "erorrInfoSumLabel";
            erorrInfoSumLabel.Size = new Size(0, 15);
            erorrInfoSumLabel.TabIndex = 19;
            erorrInfoSumLabel.Visible = false;
            // 
            // errorInfoNameLabel
            // 
            errorInfoNameLabel.AutoSize = true;
            errorInfoNameLabel.Font = new Font("Segoe UI", 7F);
            errorInfoNameLabel.ForeColor = Color.Red;
            errorInfoNameLabel.Location = new Point(88, 95);
            errorInfoNameLabel.Name = "errorInfoNameLabel";
            errorInfoNameLabel.Size = new Size(0, 15);
            errorInfoNameLabel.TabIndex = 18;
            errorInfoNameLabel.Visible = false;
            // 
            // errorInfoIdLabel
            // 
            errorInfoIdLabel.AutoSize = true;
            errorInfoIdLabel.Font = new Font("Segoe UI", 7F);
            errorInfoIdLabel.ForeColor = Color.Red;
            errorInfoIdLabel.Location = new Point(88, 42);
            errorInfoIdLabel.Name = "errorInfoIdLabel";
            errorInfoIdLabel.Size = new Size(0, 15);
            errorInfoIdLabel.TabIndex = 17;
            errorInfoIdLabel.Visible = false;
            // 
            // errorIdLabel
            // 
            errorIdLabel.AutoSize = true;
            errorIdLabel.Font = new Font("Segoe UI", 9F);
            errorIdLabel.ForeColor = Color.Red;
            errorIdLabel.Location = new Point(269, 15);
            errorIdLabel.Name = "errorIdLabel";
            errorIdLabel.Size = new Size(15, 20);
            errorIdLabel.TabIndex = 16;
            errorIdLabel.Text = "*";
            errorIdLabel.Visible = false;
            // 
            // errorNameLabel
            // 
            errorNameLabel.AutoSize = true;
            errorNameLabel.ForeColor = Color.Red;
            errorNameLabel.Location = new Point(269, 68);
            errorNameLabel.Name = "errorNameLabel";
            errorNameLabel.Size = new Size(15, 20);
            errorNameLabel.TabIndex = 15;
            errorNameLabel.Text = "*";
            errorNameLabel.Visible = false;
            // 
            // errorSumLabel
            // 
            errorSumLabel.AutoSize = true;
            errorSumLabel.ForeColor = Color.Red;
            errorSumLabel.Location = new Point(269, 121);
            errorSumLabel.Name = "errorSumLabel";
            errorSumLabel.Size = new Size(15, 20);
            errorSumLabel.TabIndex = 14;
            errorSumLabel.Text = "*";
            errorSumLabel.Visible = false;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = SystemColors.ControlLight;
            buttonReset.ForeColor = Color.CornflowerBlue;
            buttonReset.Location = new Point(304, 233);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(252, 32);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "Скинути пошукові налаштування";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(182, 235);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(116, 30);
            buttonSearch.TabIndex = 6;
            buttonSearch.Text = "Пошук";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dateTimePickerLastOperation
            // 
            dateTimePickerLastOperation.Checked = false;
            dateTimePickerLastOperation.Format = DateTimePickerFormat.Custom;
            dateTimePickerLastOperation.Location = new Point(339, 130);
            dateTimePickerLastOperation.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerLastOperation.Name = "dateTimePickerLastOperation";
            dateTimePickerLastOperation.ShowCheckBox = true;
            dateTimePickerLastOperation.Size = new Size(179, 27);
            dateTimePickerLastOperation.TabIndex = 5;
            dateTimePickerLastOperation.ValueChanged += dateTimePickerLastOperation_ValueChanged;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Checked = false;
            dateTimePickerBirth.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirth.Location = new Point(339, 51);
            dateTimePickerBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.ShowCheckBox = true;
            dateTimePickerBirth.Size = new Size(179, 27);
            dateTimePickerBirth.TabIndex = 4;
            dateTimePickerBirth.ValueChanged += dateTimePickerBirth_ValueChanged;
            // 
            // labelDateLastOperation
            // 
            labelDateLastOperation.AutoSize = true;
            labelDateLastOperation.Location = new Point(339, 98);
            labelDateLastOperation.Name = "labelDateLastOperation";
            labelDateLastOperation.Size = new Size(178, 20);
            labelDateLastOperation.TabIndex = 9;
            labelDateLastOperation.Text = "Дата останньої операції";
            // 
            // labelDateBirth
            // 
            labelDateBirth.AutoSize = true;
            labelDateBirth.Location = new Point(339, 19);
            labelDateBirth.Name = "labelDateBirth";
            labelDateBirth.Size = new Size(133, 20);
            labelDateBirth.TabIndex = 8;
            labelDateBirth.Text = "Дата народження";
            // 
            // sumBox
            // 
            sumBox.Location = new Point(82, 118);
            sumBox.Name = "sumBox";
            sumBox.Size = new Size(187, 27);
            sumBox.TabIndex = 2;
            sumBox.TextChanged += sumBox_TextChanged;
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Location = new Point(23, 118);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(44, 20);
            labelSum.TabIndex = 6;
            labelSum.Text = "Сума";
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Location = new Point(82, 171);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(187, 28);
            categoryBox.TabIndex = 3;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(3, 171);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(76, 20);
            labelCategory.TabIndex = 4;
            labelCategory.Text = "Категорія";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(82, 65);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(187, 27);
            nameBox.TabIndex = 1;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // idBox
            // 
            idBox.Location = new Point(82, 12);
            idBox.Name = "idBox";
            idBox.Size = new Size(187, 27);
            idBox.TabIndex = 0;
            idBox.TextChanged += idBox_TextChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(34, 65);
            labelName.Name = "labelName";
            labelName.Size = new Size(33, 20);
            labelName.TabIndex = 1;
            labelName.Text = "ПІБ";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(45, 12);
            labelId.Name = "labelId";
            labelId.Size = new Size(22, 20);
            labelId.TabIndex = 0;
            labelId.Text = "Id";
            // 
            // resultList
            // 
            resultList.DataSource = bankAccountBindingSource;
            resultList.DisplayMember = "Name";
            resultList.Font = new Font("Segoe UI", 8.5F);
            resultList.FormattingEnabled = true;
            resultList.ItemHeight = 19;
            resultList.Location = new Point(3, 29);
            resultList.Name = "resultList";
            resultList.Size = new Size(150, 175);
            resultList.TabIndex = 1;
            resultList.ValueMember = "Id";
            // 
            // bankAccountBindingSource
            // 
            bankAccountBindingSource.DataSource = typeof(Models.BankAccount);
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(48, 111);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(116, 29);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Редагувати";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // showBox
            // 
            showBox.DataBindings.Add(new Binding("Text", bankAccountBindingSource, "CustomDisplay", true));
            showBox.Font = new Font("Segoe UI", 8.5F);
            showBox.Location = new Point(159, 72);
            showBox.Multiline = true;
            showBox.Name = "showBox";
            showBox.Size = new Size(240, 132);
            showBox.TabIndex = 4;
            showBox.TabStop = false;
            // 
            // panelShow
            // 
            panelShow.Anchor = AnchorStyles.Top;
            panelShow.BorderStyle = BorderStyle.FixedSingle;
            panelShow.Controls.Add(label1);
            panelShow.Controls.Add(panel1);
            panelShow.Controls.Add(labelCount);
            panelShow.Controls.Add(buttonAdd);
            panelShow.Controls.Add(showBox);
            panelShow.Controls.Add(resultList);
            panelShow.Location = new Point(80, 307);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(623, 246);
            panelShow.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 49);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 9;
            label1.Text = "Обраний елемент:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonMoney);
            panel1.Location = new Point(406, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 184);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.3F);
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(199, 19);
            label2.TabIndex = 10;
            label2.Text = "Робота з обраним елементом";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(48, 146);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(116, 33);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonMoney
            // 
            buttonMoney.Location = new Point(48, 57);
            buttonMoney.Name = "buttonMoney";
            buttonMoney.Size = new Size(116, 48);
            buttonMoney.TabIndex = 3;
            buttonMoney.Text = "Фінансові операції";
            buttonMoney.UseVisualStyleBackColor = true;
            buttonMoney.Click += buttonMoney_Click;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 8.5F);
            labelCount.Location = new Point(3, 5);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(0, 20);
            labelCount.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 210);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 30);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Додати елемент";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(222, 6);
            // 
            // MainForm
            // 
            FormClosing += MainForm_FormClosing;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 563);
            Controls.Add(panelShow);
            Controls.Add(panelSearch);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 610);
            Name = "MainForm";
            Text = "Банк";
          
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bankAccountBindingSource).EndInit();
            panelShow.ResumeLayout(false);
            panelShow.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel panelSearch;
        private Label labelName;
        private Label labelId;
        private TextBox nameBox;
        private TextBox idBox;
        private Label labelCategory;
        private ComboBox categoryBox;
        private TextBox sumBox;
        private Label labelSum;
        private Label labelDateBirth;
        private DateTimePicker dateTimePickerLastOperation;
        private DateTimePicker dateTimePickerBirth;
        private Label labelDateLastOperation;
        private Button buttonSearch;
        private ListBox resultList;
        private BindingSource bankAccountBindingSource;
        private Button buttonEdit;
        private TextBox showBox;
        private Panel panelShow;
        private Button buttonDelete;
        private Button buttonAdd;
        private Label labelCount;
        private Button buttonReset;
        private Button buttonMoney;
        private Label errorSumLabel;
        private Label errorIdLabel;
        private Label errorNameLabel;
        private ToolStripMenuItem додатиЕлементToolStripMenuItem;
        private ToolStripMenuItem видалитиЕлементToolStripMenuItem;
        private ToolStripMenuItem редагуватиToolStripMenuItem;
        private ToolStripMenuItem фінансовіОпераціїToolStripMenuItem;
        private Label errorInfoNameLabel;
        private Label errorInfoIdLabel;
        private Label erorrInfoSumLabel;
        private Label label4;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem helpWithTypeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
    }
}