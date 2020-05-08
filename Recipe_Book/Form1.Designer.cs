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
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Alfredo Sauce");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Deviled Eggs");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Meatloaf");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("PB&J");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Soupy Soup");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Watermelon Popcicles");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.recipeSearchTab = new System.Windows.Forms.TabPage();
            this.recipeTabContainer = new System.Windows.Forms.SplitContainer();
            this.searchRecipeContainer = new System.Windows.Forms.SplitContainer();
            this.searchButtonContainer = new System.Windows.Forms.SplitContainer();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.ingredientChecklist = new System.Windows.Forms.CheckedListBox();
            this.splitContainerRT2 = new System.Windows.Forms.SplitContainer();
            this.textSearchClearButton = new System.Windows.Forms.Button();
            this.textSearchBox = new System.Windows.Forms.TextBox();
            this.recipeSearchResults = new System.Windows.Forms.ListView();
            this.pictureSlim = new System.Windows.Forms.PictureBox();
            this.splitContainerRecipeSlim = new System.Windows.Forms.SplitContainer();
            this.editRecipeButton = new System.Windows.Forms.Button();
            this.fullRecipeButton = new System.Windows.Forms.Button();
            this.cookingModeButton = new System.Windows.Forms.Button();
            this.processTextSlim = new System.Windows.Forms.RichTextBox();
            this.tableExample = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shoppingListTab = new System.Windows.Forms.TabPage();
            this.kitchenStockTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.mainTitleText = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRT2)).BeginInit();
            this.splitContainerRT2.Panel1.SuspendLayout();
            this.splitContainerRT2.Panel2.SuspendLayout();
            this.splitContainerRT2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipeSlim)).BeginInit();
            this.splitContainerRecipeSlim.Panel1.SuspendLayout();
            this.splitContainerRecipeSlim.Panel2.SuspendLayout();
            this.splitContainerRecipeSlim.SuspendLayout();
            this.tableExample.SuspendLayout();
            this.shoppingListTab.SuspendLayout();
            this.kitchenStockTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.recipeSearchTab);
            this.Tabs.Controls.Add(this.shoppingListTab);
            this.Tabs.Controls.Add(this.kitchenStockTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1184, 766);
            this.Tabs.TabIndex = 0;
            // 
            // recipeSearchTab
            // 
            this.recipeSearchTab.Controls.Add(this.recipeTabContainer);
            this.recipeSearchTab.Location = new System.Drawing.Point(4, 26);
            this.recipeSearchTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipeSearchTab.Name = "recipeSearchTab";
            this.recipeSearchTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipeSearchTab.Size = new System.Drawing.Size(1176, 736);
            this.recipeSearchTab.TabIndex = 0;
            this.recipeSearchTab.Text = "Recipe Search";
            this.recipeSearchTab.UseVisualStyleBackColor = true;
            // 
            // recipeTabContainer
            // 
            this.recipeTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeTabContainer.Location = new System.Drawing.Point(3, 4);
            this.recipeTabContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.recipeTabContainer.Size = new System.Drawing.Size(1170, 728);
            this.recipeTabContainer.SplitterDistance = 616;
            this.recipeTabContainer.SplitterWidth = 5;
            this.recipeTabContainer.TabIndex = 6;
            // 
            // searchRecipeContainer
            // 
            this.searchRecipeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchRecipeContainer.Location = new System.Drawing.Point(0, 0);
            this.searchRecipeContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchRecipeContainer.Name = "searchRecipeContainer";
            // 
            // searchRecipeContainer.Panel1
            // 
            this.searchRecipeContainer.Panel1.Controls.Add(this.searchButtonContainer);
            // 
            // searchRecipeContainer.Panel2
            // 
            this.searchRecipeContainer.Panel2.Controls.Add(this.splitContainerRT2);
            this.searchRecipeContainer.Size = new System.Drawing.Size(616, 728);
            this.searchRecipeContainer.SplitterDistance = 205;
            this.searchRecipeContainer.SplitterWidth = 5;
            this.searchRecipeContainer.TabIndex = 4;
            // 
            // searchButtonContainer
            // 
            this.searchButtonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButtonContainer.Location = new System.Drawing.Point(0, 0);
            this.searchButtonContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.searchButtonContainer.Size = new System.Drawing.Size(205, 728);
            this.searchButtonContainer.SplitterDistance = 27;
            this.searchButtonContainer.SplitterWidth = 5;
            this.searchButtonContainer.TabIndex = 1;
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.clearSearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearSearchButton.Location = new System.Drawing.Point(0, 0);
            this.clearSearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(99, 27);
            this.clearSearchButton.TabIndex = 1;
            this.clearSearchButton.Text = "Clear";
            this.clearSearchButton.UseVisualStyleBackColor = false;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(0, 0);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(102, 27);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            "soy milk"});
            this.ingredientChecklist.Location = new System.Drawing.Point(0, 0);
            this.ingredientChecklist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ingredientChecklist.MultiColumn = true;
            this.ingredientChecklist.Name = "ingredientChecklist";
            this.ingredientChecklist.Size = new System.Drawing.Size(205, 696);
            this.ingredientChecklist.Sorted = true;
            this.ingredientChecklist.TabIndex = 1;
            // 
            // splitContainerRT2
            // 
            this.splitContainerRT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRT2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRT2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.splitContainerRT2.Size = new System.Drawing.Size(406, 728);
            this.splitContainerRT2.SplitterDistance = 27;
            this.splitContainerRT2.SplitterWidth = 5;
            this.splitContainerRT2.TabIndex = 1;
            // 
            // textSearchClearButton
            // 
            this.textSearchClearButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textSearchClearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.textSearchClearButton.Location = new System.Drawing.Point(270, 0);
            this.textSearchClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSearchClearButton.Name = "textSearchClearButton";
            this.textSearchClearButton.Size = new System.Drawing.Size(136, 27);
            this.textSearchClearButton.TabIndex = 2;
            this.textSearchClearButton.Text = "Clear";
            this.textSearchClearButton.UseVisualStyleBackColor = false;
            this.textSearchClearButton.Click += new System.EventHandler(this.textSearchClearButton_Click);
            // 
            // textSearchBox
            // 
            this.textSearchBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.textSearchBox.Location = new System.Drawing.Point(0, 0);
            this.textSearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSearchBox.Name = "textSearchBox";
            this.textSearchBox.Size = new System.Drawing.Size(343, 22);
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
            listViewItem13.StateImageIndex = 0;
            listViewItem14.StateImageIndex = 0;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.StateImageIndex = 0;
            listViewItem17.StateImageIndex = 0;
            listViewItem18.StateImageIndex = 0;
            this.recipeSearchResults.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18});
            this.recipeSearchResults.Location = new System.Drawing.Point(0, 0);
            this.recipeSearchResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipeSearchResults.Name = "recipeSearchResults";
            this.recipeSearchResults.Size = new System.Drawing.Size(406, 696);
            this.recipeSearchResults.TabIndex = 0;
            this.recipeSearchResults.TileSize = new System.Drawing.Size(250, 20);
            this.recipeSearchResults.UseCompatibleStateImageBehavior = false;
            this.recipeSearchResults.View = System.Windows.Forms.View.List;
            this.recipeSearchResults.SelectedIndexChanged += new System.EventHandler(this.recipeListView_SelectedIndexChanged);
            // 
            // pictureSlim
            // 
            this.pictureSlim.Location = new System.Drawing.Point(0, 0);
            this.pictureSlim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureSlim.Name = "pictureSlim";
            this.pictureSlim.Size = new System.Drawing.Size(567, 282);
            this.pictureSlim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSlim.TabIndex = 0;
            this.pictureSlim.TabStop = false;
            // 
            // splitContainerRecipeSlim
            // 
            this.splitContainerRecipeSlim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRecipeSlim.IsSplitterFixed = true;
            this.splitContainerRecipeSlim.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRecipeSlim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerRecipeSlim.Name = "splitContainerRecipeSlim";
            this.splitContainerRecipeSlim.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRecipeSlim.Panel1
            // 
            this.splitContainerRecipeSlim.Panel1.Controls.Add(this.editRecipeButton);
            this.splitContainerRecipeSlim.Panel1.Controls.Add(this.fullRecipeButton);
            this.splitContainerRecipeSlim.Panel1.Controls.Add(this.cookingModeButton);
            // 
            // splitContainerRecipeSlim.Panel2
            // 
            this.splitContainerRecipeSlim.Panel2.Controls.Add(this.processTextSlim);
            this.splitContainerRecipeSlim.Panel2.Controls.Add(this.tableExample);
            this.splitContainerRecipeSlim.Size = new System.Drawing.Size(549, 728);
            this.splitContainerRecipeSlim.SplitterDistance = 332;
            this.splitContainerRecipeSlim.SplitterWidth = 5;
            this.splitContainerRecipeSlim.TabIndex = 26;
            // 
            // editRecipeButton
            // 
            this.editRecipeButton.Location = new System.Drawing.Point(345, 290);
            this.editRecipeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editRecipeButton.Name = "editRecipeButton";
            this.editRecipeButton.Size = new System.Drawing.Size(117, 39);
            this.editRecipeButton.TabIndex = 3;
            this.editRecipeButton.Text = "Edit Recipe";
            this.editRecipeButton.UseVisualStyleBackColor = true;
            // 
            // fullRecipeButton
            // 
            this.fullRecipeButton.Location = new System.Drawing.Point(98, 290);
            this.fullRecipeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fullRecipeButton.Name = "fullRecipeButton";
            this.fullRecipeButton.Size = new System.Drawing.Size(117, 39);
            this.fullRecipeButton.TabIndex = 1;
            this.fullRecipeButton.Text = "See Full Recipe";
            this.fullRecipeButton.UseVisualStyleBackColor = true;
            // 
            // cookingModeButton
            // 
            this.cookingModeButton.Location = new System.Drawing.Point(222, 290);
            this.cookingModeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cookingModeButton.Name = "cookingModeButton";
            this.cookingModeButton.Size = new System.Drawing.Size(117, 39);
            this.cookingModeButton.TabIndex = 2;
            this.cookingModeButton.Text = "Cooking Mode";
            this.cookingModeButton.UseVisualStyleBackColor = true;
            // 
            // processTextSlim
            // 
            this.processTextSlim.AcceptsTab = true;
            this.processTextSlim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processTextSlim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.processTextSlim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processTextSlim.Location = new System.Drawing.Point(0, 170);
            this.processTextSlim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.processTextSlim.Name = "processTextSlim";
            this.processTextSlim.ReadOnly = true;
            this.processTextSlim.Size = new System.Drawing.Size(549, 221);
            this.processTextSlim.TabIndex = 24;
            this.processTextSlim.Text = resources.GetString("processTextSlim.Text");
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
            this.tableExample.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableExample.Location = new System.Drawing.Point(0, 0);
            this.tableExample.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableExample.Name = "tableExample";
            this.tableExample.RowCount = 2;
            this.tableExample.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableExample.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableExample.Size = new System.Drawing.Size(549, 66);
            this.tableExample.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Location = new System.Drawing.Point(177, 4);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "berries";
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Location = new System.Drawing.Point(363, 4);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "frozen";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 4);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 25);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "cups";
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(68, 37);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(103, 25);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "tbsp";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(177, 37);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(180, 15);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "butter";
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox6.Location = new System.Drawing.Point(363, 37);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(183, 22);
            this.textBox6.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "6";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "2 1/2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shoppingListTab
            // 
            this.shoppingListTab.BackColor = System.Drawing.Color.LightSlateGray;
            this.shoppingListTab.Controls.Add(this.label3);
            this.shoppingListTab.Location = new System.Drawing.Point(4, 26);
            this.shoppingListTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shoppingListTab.Name = "shoppingListTab";
            this.shoppingListTab.Size = new System.Drawing.Size(1176, 736);
            this.shoppingListTab.TabIndex = 2;
            this.shoppingListTab.Text = "Shopping List";
            // 
            // kitchenStockTab
            // 
            this.kitchenStockTab.BackColor = System.Drawing.Color.LightSlateGray;
            this.kitchenStockTab.Controls.Add(this.label4);
            this.kitchenStockTab.Location = new System.Drawing.Point(4, 26);
            this.kitchenStockTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitchenStockTab.Name = "kitchenStockTab";
            this.kitchenStockTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitchenStockTab.Size = new System.Drawing.Size(1176, 736);
            this.kitchenStockTab.TabIndex = 1;
            this.kitchenStockTab.Text = "Kitchen Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Engravers MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "COMING SOON!";
            // 
            // mainTitleText
            // 
            this.mainTitleText.AutoSize = true;
            this.mainTitleText.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleText.Location = new System.Drawing.Point(3, 0);
            this.mainTitleText.Name = "mainTitleText";
            this.mainTitleText.Size = new System.Drawing.Size(260, 45);
            this.mainTitleText.TabIndex = 0;
            this.mainTitleText.Text = "Kitchen Stuff";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainTitleText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Tabs);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 811);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.searchButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.clearSearchButton);
            this.splitContainer2.Size = new System.Drawing.Size(205, 27);
            this.splitContainer2.SplitterDistance = 102;
            this.splitContainer2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Engravers MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "COMING SOON!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 811);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.splitContainerRT2.Panel1.ResumeLayout(false);
            this.splitContainerRT2.Panel1.PerformLayout();
            this.splitContainerRT2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRT2)).EndInit();
            this.splitContainerRT2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlim)).EndInit();
            this.splitContainerRecipeSlim.Panel1.ResumeLayout(false);
            this.splitContainerRecipeSlim.Panel2.ResumeLayout(false);
            this.splitContainerRecipeSlim.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipeSlim)).EndInit();
            this.splitContainerRecipeSlim.ResumeLayout(false);
            this.tableExample.ResumeLayout(false);
            this.tableExample.PerformLayout();
            this.shoppingListTab.ResumeLayout(false);
            this.shoppingListTab.PerformLayout();
            this.kitchenStockTab.ResumeLayout(false);
            this.kitchenStockTab.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
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
        private System.Windows.Forms.Button editRecipeButton;
        private System.Windows.Forms.Button cookingModeButton;
        private System.Windows.Forms.Button fullRecipeButton;
        private System.Windows.Forms.RichTextBox processTextSlim;
        private System.Windows.Forms.SplitContainer splitContainer1;
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
    }
}

