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
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panelSearch = new Panel();
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
            buttonMoney = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            labelCount = new Label();
            menuStrip1.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bankAccountBindingSource).BeginInit();
            panelShow.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(658, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(181, 26);
            newToolStripMenuItem.Text = "&New";
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
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(181, 26);
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(178, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(181, 26);
            printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
            printPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(181, 26);
            printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(181, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(179, 26);
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(179, 26);
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(176, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(179, 26);
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(179, 26);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(179, 26);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(176, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(179, 26);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(161, 26);
            customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(161, 26);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size(150, 26);
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(150, 26);
            indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(150, 26);
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(147, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(150, 26);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // panelSearch
            // 
            panelSearch.Anchor = AnchorStyles.Top;
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
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
            panelSearch.Location = new Point(58, 31);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(534, 212);
            panelSearch.TabIndex = 1;
            // 
            // errorIdLabel
            // 
            errorIdLabel.AutoSize = true;
            errorIdLabel.ForeColor = Color.Red;
            errorIdLabel.Location = new Point(284, 15);
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
            errorNameLabel.Location = new Point(284, 56);
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
            errorSumLabel.Location = new Point(284, 134);
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
            buttonReset.Location = new Point(3, 178);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(281, 29);
            buttonReset.TabIndex = 13;
            buttonReset.Text = "Скинути пошукові налаштування";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(350, 182);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(93, 28);
            buttonSearch.TabIndex = 12;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dateTimePickerLastOperation
            // 
            dateTimePickerLastOperation.Checked = false;
            dateTimePickerLastOperation.Format = DateTimePickerFormat.Custom;
            dateTimePickerLastOperation.Location = new Point(339, 130);
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
            dateTimePickerBirth.MaxDate = new DateTime(2222, 12, 31, 0, 0, 0, 0);
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
            sumBox.Location = new Point(82, 132);
            sumBox.Name = "sumBox";
            sumBox.Size = new Size(187, 27);
            sumBox.TabIndex = 7;
            sumBox.TextChanged += sumBox_TextChanged;
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Location = new Point(23, 132);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(44, 20);
            labelSum.TabIndex = 6;
            labelSum.Text = "Сума";
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Location = new Point(82, 90);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(187, 28);
            categoryBox.TabIndex = 5;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(3, 90);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(76, 20);
            labelCategory.TabIndex = 4;
            labelCategory.Text = "Категорія";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(82, 51);
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
            labelName.Location = new Point(34, 51);
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
            resultList.Location = new Point(0, 3);
            resultList.Name = "resultList";
            resultList.Size = new Size(135, 184);
            resultList.TabIndex = 2;
            resultList.ValueMember = "Id";
            // 
            // bankAccountBindingSource
            // 
            bankAccountBindingSource.DataSource = typeof(Models.BankAccount);
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(418, 33);
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
            showBox.Location = new Point(152, 3);
            showBox.Multiline = true;
            showBox.Name = "showBox";
            showBox.Size = new Size(245, 184);
            showBox.TabIndex = 4;
            // 
            // panelShow
            // 
            panelShow.Controls.Add(buttonMoney);
            panelShow.Controls.Add(buttonAdd);
            panelShow.Controls.Add(buttonDelete);
            panelShow.Controls.Add(showBox);
            panelShow.Controls.Add(buttonEdit);
            panelShow.Controls.Add(resultList);
            panelShow.Location = new Point(58, 269);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(534, 217);
            panelShow.TabIndex = 4;
            // 
            // buttonMoney
            // 
            buttonMoney.Location = new Point(379, 189);
            buttonMoney.Name = "buttonMoney";
            buttonMoney.Size = new Size(152, 25);
            buttonMoney.TabIndex = 7;
            buttonMoney.Text = "Робота з грошима";
            buttonMoney.UseVisualStyleBackColor = true;
            buttonMoney.Click += buttonMoney_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(418, 68);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(116, 30);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(418, 104);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(116, 33);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(62, 246);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(0, 20);
            labelCount.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 498);
            Controls.Add(labelCount);
            Controls.Add(panelShow);
            Controls.Add(panelSearch);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(675, 545);
            Name = "MainForm";
            Text = "MainForm";
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
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
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
    }
}