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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Soy Milk");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("DAIRY", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Lettuce");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("PRODUCE", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Peanut Butter");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("CONDIMENTS", new System.Windows.Forms.TreeNode[] {
            treeNode5});
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
            this.searchButton = new System.Windows.Forms.Button();
            this.treeSearchIngredients = new System.Windows.Forms.TreeView();
            this.recipeSearchResults = new System.Windows.Forms.ListView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.amountIngredientTextBox = new System.Windows.Forms.TextBox();
            this.editRecipeButton = new System.Windows.Forms.Button();
            this.cookingModeButton = new System.Windows.Forms.Button();
            this.fullRecipeButton = new System.Windows.Forms.Button();
            this.pbjpgImage = new System.Windows.Forms.PictureBox();
            this.shoppingListTab = new System.Windows.Forms.TabPage();
            this.kitchenStockTab = new System.Windows.Forms.TabPage();
            this.mainTitleText = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbjpgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.recipeSearchTab);
            this.Tabs.Controls.Add(this.shoppingListTab);
            this.Tabs.Controls.Add(this.kitchenStockTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1204, 677);
            this.Tabs.TabIndex = 0;
            // 
            // recipeSearchTab
            // 
            this.recipeSearchTab.Controls.Add(this.recipeTabContainer);
            this.recipeSearchTab.Location = new System.Drawing.Point(4, 22);
            this.recipeSearchTab.Name = "recipeSearchTab";
            this.recipeSearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.recipeSearchTab.Size = new System.Drawing.Size(1196, 651);
            this.recipeSearchTab.TabIndex = 0;
            this.recipeSearchTab.Text = "Recipe Search";
            this.recipeSearchTab.UseVisualStyleBackColor = true;
            // 
            // recipeTabContainer
            // 
            this.recipeTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeTabContainer.Location = new System.Drawing.Point(3, 3);
            this.recipeTabContainer.Name = "recipeTabContainer";
            // 
            // recipeTabContainer.Panel1
            // 
            this.recipeTabContainer.Panel1.Controls.Add(this.searchRecipeContainer);
            // 
            // recipeTabContainer.Panel2
            // 
            this.recipeTabContainer.Panel2.Controls.Add(this.richTextBox1);
            this.recipeTabContainer.Panel2.Controls.Add(this.textBox10);
            this.recipeTabContainer.Panel2.Controls.Add(this.textBox11);
            this.recipeTabContainer.Panel2.Controls.Add(this.textBox12);
            this.recipeTabContainer.Panel2.Controls.Add(this.textBox13);
            this.recipeTabContainer.Panel2.Controls.Add(this.textBox14);
            this.recipeTabContainer.Panel2.Controls.Add(this.textBox9);
            this.recipeTabContainer.Panel2.Controls.Add(this.textBox8);
            this.recipeTabContainer.Panel2.Controls.Add(this.textBox7);
            this.recipeTabContainer.Panel2.Controls.Add(this.textBox6);
            this.recipeTabContainer.Panel2.Controls.Add(this.comboBox5);
            this.recipeTabContainer.Panel2.Controls.Add(this.comboBox4);
            this.recipeTabContainer.Panel2.Controls.Add(this.comboBox3);
            this.recipeTabContainer.Panel2.Controls.Add(this.comboBox2);
            this.recipeTabContainer.Panel2.Controls.Add(this.comboBox1);
            this.recipeTabContainer.Panel2.Controls.Add(this.textBox5);
            this.recipeTabContainer.Panel2.Controls.Add(this.textBox4);
            this.recipeTabContainer.Panel2.Controls.Add(this.textBox3);
            this.recipeTabContainer.Panel2.Controls.Add(this.textBox2);
            this.recipeTabContainer.Panel2.Controls.Add(this.textBox1);
            this.recipeTabContainer.Panel2.Controls.Add(this.amountIngredientTextBox);
            this.recipeTabContainer.Panel2.Controls.Add(this.editRecipeButton);
            this.recipeTabContainer.Panel2.Controls.Add(this.cookingModeButton);
            this.recipeTabContainer.Panel2.Controls.Add(this.fullRecipeButton);
            this.recipeTabContainer.Panel2.Controls.Add(this.pbjpgImage);
            this.recipeTabContainer.Size = new System.Drawing.Size(1190, 645);
            this.recipeTabContainer.SplitterDistance = 700;
            this.recipeTabContainer.TabIndex = 6;
            // 
            // searchRecipeContainer
            // 
            this.searchRecipeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchRecipeContainer.Location = new System.Drawing.Point(0, 0);
            this.searchRecipeContainer.Name = "searchRecipeContainer";
            // 
            // searchRecipeContainer.Panel1
            // 
            this.searchRecipeContainer.Panel1.Controls.Add(this.searchButtonContainer);
            // 
            // searchRecipeContainer.Panel2
            // 
            this.searchRecipeContainer.Panel2.Controls.Add(this.recipeSearchResults);
            this.searchRecipeContainer.Size = new System.Drawing.Size(700, 645);
            this.searchRecipeContainer.SplitterDistance = 233;
            this.searchRecipeContainer.TabIndex = 4;
            // 
            // searchButtonContainer
            // 
            this.searchButtonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButtonContainer.Location = new System.Drawing.Point(0, 0);
            this.searchButtonContainer.Name = "searchButtonContainer";
            this.searchButtonContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // searchButtonContainer.Panel1
            // 
            this.searchButtonContainer.Panel1.Controls.Add(this.searchButton);
            // 
            // searchButtonContainer.Panel2
            // 
            this.searchButtonContainer.Panel2.Controls.Add(this.treeSearchIngredients);
            this.searchButtonContainer.Size = new System.Drawing.Size(233, 645);
            this.searchButtonContainer.SplitterDistance = 25;
            this.searchButtonContainer.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchButton.Location = new System.Drawing.Point(0, 0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(233, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // treeSearchIngredients
            // 
            this.treeSearchIngredients.CheckBoxes = true;
            this.treeSearchIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSearchIngredients.Location = new System.Drawing.Point(0, 0);
            this.treeSearchIngredients.Name = "treeSearchIngredients";
            treeNode1.Name = "soymilkLeaf";
            treeNode1.Text = "Soy Milk";
            treeNode2.Name = "dairyRoot";
            treeNode2.Text = "DAIRY";
            treeNode3.Name = "lettuceLeaf";
            treeNode3.Text = "Lettuce";
            treeNode4.Name = "produceRoot";
            treeNode4.Text = "PRODUCE";
            treeNode5.Name = "peanutbutterLeaf";
            treeNode5.Text = "Peanut Butter";
            treeNode6.Name = "condimentsRoot";
            treeNode6.Text = "CONDIMENTS";
            this.treeSearchIngredients.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6});
            this.treeSearchIngredients.Size = new System.Drawing.Size(233, 616);
            this.treeSearchIngredients.TabIndex = 0;
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
            this.recipeSearchResults.MultiSelect = false;
            this.recipeSearchResults.Name = "recipeSearchResults";
            this.recipeSearchResults.Size = new System.Drawing.Size(463, 645);
            this.recipeSearchResults.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.recipeSearchResults.TabIndex = 0;
            this.recipeSearchResults.TileSize = new System.Drawing.Size(250, 20);
            this.recipeSearchResults.UseCompatibleStateImageBehavior = false;
            this.recipeSearchResults.View = System.Windows.Forms.View.Tile;
            this.recipeSearchResults.SelectedIndexChanged += new System.EventHandler(this.recipeListView_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(20, 437);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(385, 164);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(243, 309);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(150, 13);
            this.textBox10.TabIndex = 23;
            this.textBox10.Text = "finely chopped";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(243, 333);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(150, 13);
            this.textBox11.TabIndex = 22;
            this.textBox11.Text = "finely chopped";
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(243, 359);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(150, 13);
            this.textBox12.TabIndex = 21;
            this.textBox12.Text = "finely chopped";
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Location = new System.Drawing.Point(243, 386);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(150, 13);
            this.textBox13.TabIndex = 20;
            this.textBox13.Text = "finely chopped";
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Location = new System.Drawing.Point(243, 285);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(150, 13);
            this.textBox14.TabIndex = 19;
            this.textBox14.Text = "finely chopped";
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(163, 309);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(150, 13);
            this.textBox9.TabIndex = 18;
            this.textBox9.Text = "mixed berries";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(163, 333);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(150, 13);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "mixed berries";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(163, 359);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(150, 13);
            this.textBox7.TabIndex = 16;
            this.textBox7.Text = "mixed berries";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(163, 386);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 13);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "mixed berries";
            // 
            // comboBox5
            // 
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "cups",
            "tbsp",
            "tsp"});
            this.comboBox5.Location = new System.Drawing.Point(91, 306);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(50, 21);
            this.comboBox5.TabIndex = 14;
            this.comboBox5.Text = "cups";
            // 
            // comboBox4
            // 
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "cups",
            "tbsp",
            "tsp"});
            this.comboBox4.Location = new System.Drawing.Point(91, 330);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(50, 21);
            this.comboBox4.TabIndex = 13;
            this.comboBox4.Text = "cups";
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "cups",
            "tbsp",
            "tsp"});
            this.comboBox3.Location = new System.Drawing.Point(91, 356);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(50, 21);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.Text = "cups";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "cups",
            "tbsp",
            "tsp"});
            this.comboBox2.Location = new System.Drawing.Point(91, 382);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(50, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.Text = "cups";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "cups",
            "tbsp",
            "tsp"});
            this.comboBox1.Location = new System.Drawing.Point(91, 282);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(50, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "cups";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(163, 285);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 13);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "mixed berries";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(45, 309);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 13);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "12 1/2";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(45, 331);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(40, 13);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "12 1/2";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(45, 357);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 13);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "12 1/2";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(45, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 13);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "12 1/2";
            // 
            // amountIngredientTextBox
            // 
            this.amountIngredientTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountIngredientTextBox.Location = new System.Drawing.Point(45, 285);
            this.amountIngredientTextBox.Name = "amountIngredientTextBox";
            this.amountIngredientTextBox.Size = new System.Drawing.Size(40, 13);
            this.amountIngredientTextBox.TabIndex = 4;
            this.amountIngredientTextBox.Text = "12 1/2";
            // 
            // editRecipeButton
            // 
            this.editRecipeButton.Location = new System.Drawing.Point(269, 231);
            this.editRecipeButton.Name = "editRecipeButton";
            this.editRecipeButton.Size = new System.Drawing.Size(100, 30);
            this.editRecipeButton.TabIndex = 3;
            this.editRecipeButton.Text = "Edit Recipe";
            this.editRecipeButton.UseVisualStyleBackColor = true;
            // 
            // cookingModeButton
            // 
            this.cookingModeButton.Location = new System.Drawing.Point(163, 231);
            this.cookingModeButton.Name = "cookingModeButton";
            this.cookingModeButton.Size = new System.Drawing.Size(100, 30);
            this.cookingModeButton.TabIndex = 2;
            this.cookingModeButton.Text = "Cooking Mode";
            this.cookingModeButton.UseVisualStyleBackColor = true;
            // 
            // fullRecipeButton
            // 
            this.fullRecipeButton.Location = new System.Drawing.Point(57, 231);
            this.fullRecipeButton.Name = "fullRecipeButton";
            this.fullRecipeButton.Size = new System.Drawing.Size(100, 30);
            this.fullRecipeButton.TabIndex = 1;
            this.fullRecipeButton.Text = "See Full Recipe";
            this.fullRecipeButton.UseVisualStyleBackColor = true;
            // 
            // pbjpgImage
            // 
            this.pbjpgImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbjpgImage.Location = new System.Drawing.Point(0, 0);
            this.pbjpgImage.Name = "pbjpgImage";
            this.pbjpgImage.Size = new System.Drawing.Size(486, 225);
            this.pbjpgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbjpgImage.TabIndex = 0;
            this.pbjpgImage.TabStop = false;
            // 
            // shoppingListTab
            // 
            this.shoppingListTab.Location = new System.Drawing.Point(4, 22);
            this.shoppingListTab.Name = "shoppingListTab";
            this.shoppingListTab.Size = new System.Drawing.Size(1196, 651);
            this.shoppingListTab.TabIndex = 2;
            this.shoppingListTab.Text = "Shopping List";
            this.shoppingListTab.UseVisualStyleBackColor = true;
            // 
            // kitchenStockTab
            // 
            this.kitchenStockTab.Location = new System.Drawing.Point(4, 22);
            this.kitchenStockTab.Name = "kitchenStockTab";
            this.kitchenStockTab.Padding = new System.Windows.Forms.Padding(3);
            this.kitchenStockTab.Size = new System.Drawing.Size(1196, 651);
            this.kitchenStockTab.TabIndex = 1;
            this.kitchenStockTab.Text = "Kitchen Stock";
            this.kitchenStockTab.UseVisualStyleBackColor = true;
            // 
            // mainTitleText
            // 
            this.mainTitleText.AutoSize = true;
            this.mainTitleText.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleText.Location = new System.Drawing.Point(3, 0);
            this.mainTitleText.Name = "mainTitleText";
            this.mainTitleText.Size = new System.Drawing.Size(243, 42);
            this.mainTitleText.TabIndex = 0;
            this.mainTitleText.Text = "Kitchen Stuff";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Size = new System.Drawing.Size(1204, 726);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1204, 726);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabs.ResumeLayout(false);
            this.recipeSearchTab.ResumeLayout(false);
            this.recipeTabContainer.Panel1.ResumeLayout(false);
            this.recipeTabContainer.Panel2.ResumeLayout(false);
            this.recipeTabContainer.Panel2.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbjpgImage)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage recipeSearchTab;
        private System.Windows.Forms.TabPage kitchenStockTab;
        private System.Windows.Forms.SplitContainer recipeTabContainer;
        private System.Windows.Forms.TabPage shoppingListTab;
        private System.Windows.Forms.SplitContainer searchRecipeContainer;
        private System.Windows.Forms.TreeView treeSearchIngredients;
        private System.Windows.Forms.Label mainTitleText;
        private System.Windows.Forms.ListView recipeSearchResults;
        private System.Windows.Forms.PictureBox pbjpgImage;
        private System.Windows.Forms.Button editRecipeButton;
        private System.Windows.Forms.Button cookingModeButton;
        private System.Windows.Forms.Button fullRecipeButton;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox amountIngredientTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer searchButtonContainer;
        private System.Windows.Forms.Button searchButton;
    }
}

