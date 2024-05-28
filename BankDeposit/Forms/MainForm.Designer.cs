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
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
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
            aboutToolStripMenuItem = new ToolStripMenuItem();
            виконавСтгрПЗПІ23УсВладиславToolStripMenuItem = new ToolStripMenuItem();
            panelSearch = new Panel();
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
            labelCount = new Label();
            buttonMoney = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            menuStrip1.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bankAccountBindingSource).BeginInit();
            panelShow.SuspendLayout();
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(181, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(178, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(181, 26);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(181, 26);
            exitToolStripMenuItem.Text = "&Вийти";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem, фінансовіОпераціїToolStripMenuItem });
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
            додатиЕлементToolStripMenuItem.Size = new Size(217, 26);
            додатиЕлементToolStripMenuItem.Text = "Додати акаунт";
            додатиЕлементToolStripMenuItem.Click += додатиЕлементToolStripMenuItem_Click;
            // 
            // редагуватиToolStripMenuItem
            // 
            редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            редагуватиToolStripMenuItem.Size = new Size(217, 26);
            редагуватиToolStripMenuItem.Text = "Редагувати акаунт";
            редагуватиToolStripMenuItem.Click += редагуватиToolStripMenuItem_Click;
            // 
            // видалитиЕлементToolStripMenuItem
            // 
            видалитиЕлементToolStripMenuItem.Name = "видалитиЕлементToolStripMenuItem";
            видалитиЕлементToolStripMenuItem.Size = new Size(217, 26);
            видалитиЕлементToolStripMenuItem.Text = "Видалити акаунт";
            видалитиЕлементToolStripMenuItem.Click += видалитиToolStripMenuItem_Click;
            // 
            // фінансовіОпераціїToolStripMenuItem
            // 
            фінансовіОпераціїToolStripMenuItem.Name = "фінансовіОпераціїToolStripMenuItem";
            фінансовіОпераціїToolStripMenuItem.Size = new Size(225, 26);
            фінансовіОпераціїToolStripMenuItem.Text = "Фінансові операції";
            фінансовіОпераціїToolStripMenuItem.Click += фінансовіОпераціїToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(139, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { виконавСтгрПЗПІ23УсВладиславToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(142, 26);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // виконавСтгрПЗПІ23УсВладиславToolStripMenuItem
            // 
            виконавСтгрПЗПІ23УсВладиславToolStripMenuItem.Name = "виконавСтгрПЗПІ23УсВладиславToolStripMenuItem";
            виконавСтгрПЗПІ23УсВладиславToolStripMenuItem.Size = new Size(356, 26);
            виконавСтгрПЗПІ23УсВладиславToolStripMenuItem.Text = "Виконав ст.гр.ПЗПІ-23-6 Ус Владислав";
            // 
            // panelSearch
            // 
            panelSearch.Anchor = AnchorStyles.Top;
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
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
            panelSearch.Location = new Point(120, 31);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(561, 270);
            panelSearch.TabIndex = 1;
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
            buttonReset.TabIndex = 13;
            buttonReset.Text = "Скинути пошукові налаштування";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(192, 233);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(92, 32);
            buttonSearch.TabIndex = 12;
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
            dateTimePickerLastOperation.TabIndex = 11;
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
            dateTimePickerBirth.TabIndex = 10;
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
            sumBox.TabIndex = 7;
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
            categoryBox.TabIndex = 5;
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
            nameBox.TabIndex = 3;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // idBox
            // 
            idBox.Location = new Point(82, 12);
            idBox.Name = "idBox";
            idBox.Size = new Size(187, 27);
            idBox.TabIndex = 2;
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
            resultList.DisplayMember = "CustomDisplay";
            resultList.FormattingEnabled = true;
            resultList.Location = new Point(3, 28);
            resultList.Name = "resultList";
            resultList.Size = new Size(150, 184);
            resultList.TabIndex = 2;
            resultList.ValueMember = "Id";
            // 
            // bankAccountBindingSource
            // 
            bankAccountBindingSource.DataSource = typeof(Models.BankAccount);
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(426, 76);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(116, 29);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Редагувати";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // showBox
            // 
            showBox.DataBindings.Add(new Binding("Text", bankAccountBindingSource, "CustomDisplay1", true));
            showBox.Location = new Point(172, 28);
            showBox.Multiline = true;
            showBox.Name = "showBox";
            showBox.Size = new Size(212, 184);
            showBox.TabIndex = 4;
            showBox.TextChanged += showBox_TextChanged;
            // 
            // panelShow
            // 
            panelShow.Anchor = AnchorStyles.Top;
            panelShow.BorderStyle = BorderStyle.FixedSingle;
            panelShow.Controls.Add(labelCount);
            panelShow.Controls.Add(buttonMoney);
            panelShow.Controls.Add(buttonAdd);
            panelShow.Controls.Add(buttonDelete);
            panelShow.Controls.Add(showBox);
            panelShow.Controls.Add(buttonEdit);
            panelShow.Controls.Add(resultList);
            panelShow.Location = new Point(120, 307);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(561, 224);
            panelShow.TabIndex = 4;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(3, 0);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(29, 20);
            labelCount.TabIndex = 5;
            labelCount.Text = "ffff";
            // 
            // buttonMoney
            // 
            buttonMoney.Location = new Point(404, 150);
            buttonMoney.Name = "buttonMoney";
            buttonMoney.Size = new Size(152, 28);
            buttonMoney.TabIndex = 7;
            buttonMoney.Text = "Фінансові операції";
            buttonMoney.UseVisualStyleBackColor = true;
            buttonMoney.Click += buttonMoney_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(426, 40);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(116, 30);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(426, 111);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(116, 33);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(panelShow);
            Controls.Add(panelSearch);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 600);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bankAccountBindingSource).EndInit();
            panelShow.ResumeLayout(false);
            panelShow.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
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
        private ToolStripMenuItem виконавСтгрПЗПІ23УсВладиславToolStripMenuItem;
        private ToolStripMenuItem фінансовіОпераціїToolStripMenuItem;
        private Label errorInfoNameLabel;
        private Label errorInfoIdLabel;
        private Label erorrInfoSumLabel;
    }
}