namespace RecipeBook
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Alfredo Sauce");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Deviled Eggs");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Meatloaf");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("PB&J");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Soupy Soup");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Watermelon Popcicles");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.recipeSearchTab = new System.Windows.Forms.TabPage();
            this.recipeTabContainer = new System.Windows.Forms.SplitContainer();
            this.searchRecipeContainer = new System.Windows.Forms.SplitContainer();
            this.searchButtonContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.ingredientChecklist = new System.Windows.Forms.CheckedListBox();
            this.splitContainerRT2 = new System.Windows.Forms.SplitContainer();
            this.textSearchClearButton = new System.Windows.Forms.Button();
            this.textSearchBox = new System.Windows.Forms.TextBox();
            this.recipeSearchResults = new System.Windows.Forms.ListView();
            this.pictureSlim = new System.Windows.Forms.PictureBox();
            this.splitContainerRecipeSlim = new System.Windows.Forms.SplitContainer();
            this.fullRecipeButton = new System.Windows.Forms.Button();
            this.slimProcessSplit = new System.Windows.Forms.SplitContainer();
            this.tableExample = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.processTextSlim = new System.Windows.Forms.RichTextBox();
            this.shoppingListTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.kitchenStockTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.mainTitleText = new System.Windows.Forms.Label();
            this.mainSplit = new System.Windows.Forms.SplitContainer();
            this.Tabs.SuspendLayout();
            this.recipeSearchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeTabContainer)).BeginInit();
            this.recipeTabContainer.Panel1.SuspendLayout();
            this.recipeTabContainer.Panel2.SuspendLayout();
            this.recipeTabContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchRecipeContainer)).BeginInit();
            this.searchRecipeContainer.Panel1.SuspendLayout();
            this.searchRecipeContainer.Panel2.SuspendLayout();
            this.searchRecipeContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonContainer)).BeginInit();
            this.searchButtonContainer.Panel1.SuspendLayout();
            this.searchButtonContainer.Panel2.SuspendLayout();
            this.searchButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRT2)).BeginInit();
            this.splitContainerRT2.Panel1.SuspendLayout();
            this.splitContainerRT2.Panel2.SuspendLayout();
            this.splitContainerRT2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipeSlim)).BeginInit();
            this.splitContainerRecipeSlim.Panel1.SuspendLayout();
            this.splitContainerRecipeSlim.Panel2.SuspendLayout();
            this.splitContainerRecipeSlim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slimProcessSplit)).BeginInit();
            this.slimProcessSplit.Panel1.SuspendLayout();
            this.slimProcessSplit.Panel2.SuspendLayout();
            this.slimProcessSplit.SuspendLayout();
            this.tableExample.SuspendLayout();
            this.shoppingListTab.SuspendLayout();
            this.kitchenStockTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
            this.mainSplit.Panel1.SuspendLayout();
            this.mainSplit.Panel2.SuspendLayout();
            this.mainSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.recipeSearchTab);
            this.Tabs.Controls.Add(this.shoppingListTab);
            this.Tabs.Controls.Add(this.kitchenStockTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1284, 813);
            this.Tabs.TabIndex = 0;
            // 
            // recipeSearchTab
            // 
            this.recipeSearchTab.Controls.Add(this.recipeTabContainer);
            this.recipeSearchTab.Location = new System.Drawing.Point(4, 29);
            this.recipeSearchTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeSearchTab.Name = "recipeSearchTab";
            this.recipeSearchTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeSearchTab.Size = new System.Drawing.Size(1276, 780);
            this.recipeSearchTab.TabIndex = 0;
            this.recipeSearchTab.Text = "Recipe Search";
            this.recipeSearchTab.UseVisualStyleBackColor = true;
            // 
            // recipeTabContainer
            // 
            this.recipeTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeTabContainer.IsSplitterFixed = true;
            this.recipeTabContainer.Location = new System.Drawing.Point(4, 5);
            this.recipeTabContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeTabContainer.Name = "recipeTabContainer";
            // 
            // recipeTabContainer.Panel1
            // 
            this.recipeTabContainer.Panel1.Controls.Add(this.searchRecipeContainer);
            // 
            // recipeTabContainer.Panel2
            // 
            this.recipeTabContainer.Panel2.Controls.Add(this.pictureSlim);
            this.recipeTabContainer.Panel2.Controls.Add(this.splitContainerRecipeSlim);
            this.recipeTabContainer.Size = new System.Drawing.Size(1268, 770);
            this.recipeTabContainer.SplitterDistance = 677;
            this.recipeTabContainer.SplitterWidth = 6;
            this.recipeTabContainer.TabIndex = 6;
            // 
            // searchRecipeContainer
            // 
            this.searchRecipeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchRecipeContainer.Location = new System.Drawing.Point(0, 0);
            this.searchRecipeContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchRecipeContainer.Name = "searchRecipeContainer";
            // 
            // searchRecipeContainer.Panel1
            // 
            this.searchRecipeContainer.Panel1.Controls.Add(this.searchButtonContainer);
            // 
            // searchRecipeContainer.Panel2
            // 
            this.searchRecipeContainer.Panel2.Controls.Add(this.splitContainerRT2);
            this.searchRecipeContainer.Size = new System.Drawing.Size(677, 770);
            this.searchRecipeContainer.SplitterDistance = 225;
            this.searchRecipeContainer.SplitterWidth = 6;
            this.searchRecipeContainer.TabIndex = 4;
            // 
            // searchButtonContainer
            // 
            this.searchButtonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButtonContainer.Location = new System.Drawing.Point(0, 0);
            this.searchButtonContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButtonContainer.Name = "searchButtonContainer";
            this.searchButtonContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // searchButtonContainer.Panel1
            // 
            this.searchButtonContainer.Panel1.Controls.Add(this.splitContainer2);
            // 
            // searchButtonContainer.Panel2
            // 
            this.searchButtonContainer.Panel2.Controls.Add(this.ingredientChecklist);
            this.searchButtonContainer.Size = new System.Drawing.Size(225, 770);
            this.searchButtonContainer.SplitterDistance = 31;
            this.searchButtonContainer.SplitterWidth = 6;
            this.searchButtonContainer.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.searchButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.clearSearchButton);
            this.splitContainer2.Size = new System.Drawing.Size(225, 31);
            this.splitContainer2.SplitterDistance = 110;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(0, 0);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(110, 31);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.clearSearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearSearchButton.Location = new System.Drawing.Point(0, 0);
            this.clearSearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(110, 31);
            this.clearSearchButton.TabIndex = 1;
            this.clearSearchButton.Text = "Clear";
            this.clearSearchButton.UseVisualStyleBackColor = false;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // ingredientChecklist
            // 
            this.ingredientChecklist.CheckOnClick = true;
            this.ingredientChecklist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientChecklist.FormattingEnabled = true;
            this.ingredientChecklist.Items.AddRange(new object[] {
            "bread",
            "jam",
            "lettuce",
            "milk",
            "mustard",
            "peanut butter",
            "soy milk",
            "vegetable soup"});
            this.ingredientChecklist.Location = new System.Drawing.Point(0, 0);
            this.ingredientChecklist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ingredientChecklist.MultiColumn = true;
            this.ingredientChecklist.Name = "ingredientChecklist";
            this.ingredientChecklist.Size = new System.Drawing.Size(225, 733);
            this.ingredientChecklist.Sorted = true;
            this.ingredientChecklist.TabIndex = 1;
            // 
            // splitContainerRT2
            // 
            this.splitContainerRT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRT2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRT2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainerRT2.Name = "splitContainerRT2";
            this.splitContainerRT2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRT2.Panel1
            // 
            this.splitContainerRT2.Panel1.Controls.Add(this.textSearchClearButton);
            this.splitContainerRT2.Panel1.Controls.Add(this.textSearchBox);
            // 
            // splitContainerRT2.Panel2
            // 
            this.splitContainerRT2.Panel2.Controls.Add(this.recipeSearchResults);
            this.splitContainerRT2.Size = new System.Drawing.Size(446, 770);
            this.splitContainerRT2.SplitterDistance = 31;
            this.splitContainerRT2.SplitterWidth = 6;
            this.splitContainerRT2.TabIndex = 1;
            // 
            // textSearchClearButton
            // 
            this.textSearchClearButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textSearchClearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.textSearchClearButton.Location = new System.Drawing.Point(271, 0);
            this.textSearchClearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSearchClearButton.Name = "textSearchClearButton";
            this.textSearchClearButton.Size = new System.Drawing.Size(175, 31);
            this.textSearchClearButton.TabIndex = 2;
            this.textSearchClearButton.Text = "Clear";
            this.textSearchClearButton.UseVisualStyleBackColor = false;
            this.textSearchClearButton.Click += new System.EventHandler(this.textSearchClearButton_Click);
            // 
            // textSearchBox
            // 
            this.textSearchBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.textSearchBox.Location = new System.Drawing.Point(0, 0);
            this.textSearchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSearchBox.Name = "textSearchBox";
            this.textSearchBox.Size = new System.Drawing.Size(440, 26);
            this.textSearchBox.TabIndex = 0;
            this.textSearchBox.Text = "Search...";
            this.textSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearchEnterKeyHandler);
            // 
            // recipeSearchResults
            // 
            this.recipeSearchResults.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.recipeSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeSearchResults.GridLines = true;
            this.recipeSearchResults.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            this.recipeSearchResults.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.recipeSearchResults.Location = new System.Drawing.Point(0, 0);
            this.recipeSearchResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeSearchResults.Name = "recipeSearchResults";
            this.recipeSearchResults.Size = new System.Drawing.Size(446, 733);
            this.recipeSearchResults.TabIndex = 0;
            this.recipeSearchResults.TileSize = new System.Drawing.Size(250, 20);
            this.recipeSearchResults.UseCompatibleStateImageBehavior = false;
            this.recipeSearchResults.View = System.Windows.Forms.View.List;
            this.recipeSearchResults.SelectedIndexChanged += new System.EventHandler(this.recipeListView_SelectedIndexChanged);
            // 
            // pictureSlim
            // 
            this.pictureSlim.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureSlim.Location = new System.Drawing.Point(0, 0);
            this.pictureSlim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureSlim.Name = "pictureSlim";
            this.pictureSlim.Size = new System.Drawing.Size(585, 332);
            this.pictureSlim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSlim.TabIndex = 0;
            this.pictureSlim.TabStop = false;
            // 
            // splitContainerRecipeSlim
            // 
            this.splitContainerRecipeSlim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRecipeSlim.IsSplitterFixed = true;
            this.splitContainerRecipeSlim.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRecipeSlim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainerRecipeSlim.Name = "splitContainerRecipeSlim";
            this.splitContainerRecipeSlim.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRecipeSlim.Panel1
            // 
            this.splitContainerRecipeSlim.Panel1.Controls.Add(this.fullRecipeButton);
            // 
            // splitContainerRecipeSlim.Panel2
            // 
            this.splitContainerRecipeSlim.Panel2.Controls.Add(this.slimProcessSplit);
            this.splitContainerRecipeSlim.Size = new System.Drawing.Size(585, 770);
            this.splitContainerRecipeSlim.SplitterDistance = 396;
            this.splitContainerRecipeSlim.SplitterWidth = 6;
            this.splitContainerRecipeSlim.TabIndex = 26;
            // 
            // fullRecipeButton
            // 
            this.fullRecipeButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fullRecipeButton.Location = new System.Drawing.Point(213, 343);
            this.fullRecipeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fullRecipeButton.Name = "fullRecipeButton";
            this.fullRecipeButton.Size = new System.Drawing.Size(150, 46);
            this.fullRecipeButton.TabIndex = 1;
            this.fullRecipeButton.Text = "See Full Recipe";
            this.fullRecipeButton.UseVisualStyleBackColor = false;
            this.fullRecipeButton.Click += new System.EventHandler(this.fullRecipeButton_Click);
            // 
            // slimProcessSplit
            // 
            this.slimProcessSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slimProcessSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.slimProcessSplit.Location = new System.Drawing.Point(0, 0);
            this.slimProcessSplit.Name = "slimProcessSplit";
            this.slimProcessSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // slimProcessSplit.Panel1
            // 
            this.slimProcessSplit.Panel1.Controls.Add(this.tableExample);
            // 
            // slimProcessSplit.Panel2
            // 
            this.slimProcessSplit.Panel2.Controls.Add(this.processTextSlim);
            this.slimProcessSplit.Size = new System.Drawing.Size(585, 368);
            this.slimProcessSplit.SplitterDistance = 80;
            this.slimProcessSplit.TabIndex = 26;
            // 
            // tableExample
            // 
            this.tableExample.AutoSize = true;
            this.tableExample.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableExample.ColumnCount = 4;
            this.tableExample.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableExample.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableExample.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableExample.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableExample.Controls.Add(this.textBox2, 2, 0);
            this.tableExample.Controls.Add(this.textBox3, 3, 0);
            this.tableExample.Controls.Add(this.comboBox1, 1, 0);
            this.tableExample.Controls.Add(this.comboBox2, 1, 1);
            this.tableExample.Controls.Add(this.textBox5, 2, 1);
            this.tableExample.Controls.Add(this.textBox6, 3, 1);
            this.tableExample.Controls.Add(this.label1, 0, 1);
            this.tableExample.Controls.Add(this.label2, 0, 0);
            this.tableExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableExample.Location = new System.Drawing.Point(0, 0);
            this.tableExample.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableExample.Name = "tableExample";
            this.tableExample.RowCount = 2;
            this.tableExample.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableExample.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableExample.Size = new System.Drawing.Size(585, 80);
            this.tableExample.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Location = new System.Drawing.Point(191, 5);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "berries";
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Location = new System.Drawing.Point(389, 5);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 26);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "frozen";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 5);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "cups";
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(74, 45);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(109, 28);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "tbsp";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(191, 45);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 19);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "butter";
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox6.Location = new System.Drawing.Point(389, 45);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(192, 26);
            this.textBox6.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "6";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "2 1/2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // processTextSlim
            // 
            this.processTextSlim.AcceptsTab = true;
            this.processTextSlim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processTextSlim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processTextSlim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processTextSlim.Location = new System.Drawing.Point(0, 0);
            this.processTextSlim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processTextSlim.Name = "processTextSlim";
            this.processTextSlim.ReadOnly = true;
            this.processTextSlim.Size = new System.Drawing.Size(585, 284);
            this.processTextSlim.TabIndex = 24;
            this.processTextSlim.Text = resources.GetString("processTextSlim.Text");
            // 
            // shoppingListTab
            // 
            this.shoppingListTab.BackColor = System.Drawing.Color.LightSlateGray;
            this.shoppingListTab.Controls.Add(this.label3);
            this.shoppingListTab.Location = new System.Drawing.Point(4, 22);
            this.shoppingListTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shoppingListTab.Name = "shoppingListTab";
            this.shoppingListTab.Size = new System.Drawing.Size(1276, 787);
            this.shoppingListTab.TabIndex = 2;
            this.shoppingListTab.Text = "Shopping List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Engravers MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "COMING SOON!";
            // 
            // kitchenStockTab
            // 
            this.kitchenStockTab.BackColor = System.Drawing.Color.LightSlateGray;
            this.kitchenStockTab.Controls.Add(this.label4);
            this.kitchenStockTab.Location = new System.Drawing.Point(4, 22);
            this.kitchenStockTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kitchenStockTab.Name = "kitchenStockTab";
            this.kitchenStockTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kitchenStockTab.Size = new System.Drawing.Size(1276, 787);
            this.kitchenStockTab.TabIndex = 1;
            this.kitchenStockTab.Text = "Kitchen Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Engravers MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "COMING SOON!";
            // 
            // mainTitleText
            // 
            this.mainTitleText.AutoSize = true;
            this.mainTitleText.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mainTitleText.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleText.Location = new System.Drawing.Point(4, 0);
            this.mainTitleText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainTitleText.Name = "mainTitleText";
            this.mainTitleText.Size = new System.Drawing.Size(260, 45);
            this.mainTitleText.TabIndex = 0;
            this.mainTitleText.Text = "Kitchen Stuff";
            // 
            // mainSplit
            // 
            this.mainSplit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit.IsSplitterFixed = true;
            this.mainSplit.Location = new System.Drawing.Point(0, 0);
            this.mainSplit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainSplit.Name = "mainSplit";
            this.mainSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplit.Panel1
            // 
            this.mainSplit.Panel1.Controls.Add(this.mainTitleText);
            // 
            // mainSplit.Panel2
            // 
            this.mainSplit.Panel2.Controls.Add(this.Tabs);
            this.mainSplit.Size = new System.Drawing.Size(1284, 861);
            this.mainSplit.SplitterDistance = 42;
            this.mainSplit.SplitterWidth = 6;
            this.mainSplit.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1284, 861);
            this.Controls.Add(this.mainSplit);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Scruptious.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabs.ResumeLayout(false);
            this.recipeSearchTab.ResumeLayout(false);
            this.recipeTabContainer.Panel1.ResumeLayout(false);
            this.recipeTabContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recipeTabContainer)).EndInit();
            this.recipeTabContainer.ResumeLayout(false);
            this.searchRecipeContainer.Panel1.ResumeLayout(false);
            this.searchRecipeContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchRecipeContainer)).EndInit();
            this.searchRecipeContainer.ResumeLayout(false);
            this.searchButtonContainer.Panel1.ResumeLayout(false);
            this.searchButtonContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonContainer)).EndInit();
            this.searchButtonContainer.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainerRT2.Panel1.ResumeLayout(false);
            this.splitContainerRT2.Panel1.PerformLayout();
            this.splitContainerRT2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRT2)).EndInit();
            this.splitContainerRT2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlim)).EndInit();
            this.splitContainerRecipeSlim.Panel1.ResumeLayout(false);
            this.splitContainerRecipeSlim.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipeSlim)).EndInit();
            this.splitContainerRecipeSlim.ResumeLayout(false);
            this.slimProcessSplit.Panel1.ResumeLayout(false);
            this.slimProcessSplit.Panel1.PerformLayout();
            this.slimProcessSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slimProcessSplit)).EndInit();
            this.slimProcessSplit.ResumeLayout(false);
            this.tableExample.ResumeLayout(false);
            this.tableExample.PerformLayout();
            this.shoppingListTab.ResumeLayout(false);
            this.shoppingListTab.PerformLayout();
            this.kitchenStockTab.ResumeLayout(false);
            this.kitchenStockTab.PerformLayout();
            this.mainSplit.Panel1.ResumeLayout(false);
            this.mainSplit.Panel1.PerformLayout();
            this.mainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).EndInit();
            this.mainSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage recipeSearchTab;
        private System.Windows.Forms.TabPage kitchenStockTab;
        private System.Windows.Forms.SplitContainer recipeTabContainer;
        private System.Windows.Forms.TabPage shoppingListTab;
        private System.Windows.Forms.SplitContainer searchRecipeContainer;
        private System.Windows.Forms.Label mainTitleText;
        private System.Windows.Forms.ListView recipeSearchResults;
        private System.Windows.Forms.PictureBox pictureSlim;
        private System.Windows.Forms.Button fullRecipeButton;
        private System.Windows.Forms.RichTextBox processTextSlim;
        private System.Windows.Forms.SplitContainer mainSplit;
        private System.Windows.Forms.SplitContainer searchButtonContainer;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.SplitContainer splitContainerRT2;
        private System.Windows.Forms.TextBox textSearchBox;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.Button textSearchClearButton;
        private System.Windows.Forms.CheckedListBox ingredientChecklist;
        private System.Windows.Forms.SplitContainer splitContainerRecipeSlim;
        private System.Windows.Forms.TableLayoutPanel tableExample;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer slimProcessSplit;
    }
}

