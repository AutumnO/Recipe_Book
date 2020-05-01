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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.recipeSearchTab = new System.Windows.Forms.TabPage();
            this.recipeTabContainer = new System.Windows.Forms.SplitContainer();
            this.searchRecipeContainer = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.shoppingListTab = new System.Windows.Forms.TabPage();
            this.kitchenStockTab = new System.Windows.Forms.TabPage();
            this.mainTitleText = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.recipeColumnHead1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.recipeColumnHead2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tabs.SuspendLayout();
            this.recipeSearchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeTabContainer)).BeginInit();
            this.recipeTabContainer.Panel1.SuspendLayout();
            this.recipeTabContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchRecipeContainer)).BeginInit();
            this.searchRecipeContainer.Panel1.SuspendLayout();
            this.searchRecipeContainer.Panel2.SuspendLayout();
            this.searchRecipeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.recipeSearchTab);
            this.Tabs.Controls.Add(this.shoppingListTab);
            this.Tabs.Controls.Add(this.kitchenStockTab);
            this.Tabs.Location = new System.Drawing.Point(-1, 54);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1205, 671);
            this.Tabs.TabIndex = 0;
            // 
            // recipeSearchTab
            // 
            this.recipeSearchTab.Controls.Add(this.recipeTabContainer);
            this.recipeSearchTab.Location = new System.Drawing.Point(4, 22);
            this.recipeSearchTab.Name = "recipeSearchTab";
            this.recipeSearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.recipeSearchTab.Size = new System.Drawing.Size(1197, 645);
            this.recipeSearchTab.TabIndex = 0;
            this.recipeSearchTab.Text = "Recipe Search";
            this.recipeSearchTab.UseVisualStyleBackColor = true;
            // 
            // recipeTabContainer
            // 
            this.recipeTabContainer.Location = new System.Drawing.Point(0, 0);
            this.recipeTabContainer.Name = "recipeTabContainer";
            // 
            // recipeTabContainer.Panel1
            // 
            this.recipeTabContainer.Panel1.Controls.Add(this.searchRecipeContainer);
            this.recipeTabContainer.Size = new System.Drawing.Size(1197, 649);
            this.recipeTabContainer.SplitterDistance = 768;
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
            this.searchRecipeContainer.Panel1.Controls.Add(this.treeView1);
            // 
            // searchRecipeContainer.Panel2
            // 
            this.searchRecipeContainer.Panel2.Controls.Add(this.listView1);
            this.searchRecipeContainer.Size = new System.Drawing.Size(768, 649);
            this.searchRecipeContainer.SplitterDistance = 256;
            this.searchRecipeContainer.TabIndex = 4;
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
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
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(256, 649);
            this.treeView1.TabIndex = 0;
            // 
            // shoppingListTab
            // 
            this.shoppingListTab.Location = new System.Drawing.Point(4, 22);
            this.shoppingListTab.Name = "shoppingListTab";
            this.shoppingListTab.Size = new System.Drawing.Size(1197, 645);
            this.shoppingListTab.TabIndex = 2;
            this.shoppingListTab.Text = "Shopping List";
            this.shoppingListTab.UseVisualStyleBackColor = true;
            // 
            // kitchenStockTab
            // 
            this.kitchenStockTab.Location = new System.Drawing.Point(4, 22);
            this.kitchenStockTab.Name = "kitchenStockTab";
            this.kitchenStockTab.Padding = new System.Windows.Forms.Padding(3);
            this.kitchenStockTab.Size = new System.Drawing.Size(1197, 645);
            this.kitchenStockTab.TabIndex = 1;
            this.kitchenStockTab.Text = "Kitchen Stock";
            this.kitchenStockTab.UseVisualStyleBackColor = true;
            // 
            // mainTitleText
            // 
            this.mainTitleText.AutoSize = true;
            this.mainTitleText.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleText.Location = new System.Drawing.Point(5, 5);
            this.mainTitleText.Name = "mainTitleText";
            this.mainTitleText.Size = new System.Drawing.Size(243, 42);
            this.mainTitleText.TabIndex = 0;
            this.mainTitleText.Text = "Kitchen Stuff";
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.recipeColumnHead1,
            this.recipeColumnHead2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(508, 649);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.TileSize = new System.Drawing.Size(15, 15);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // recipeColumnHead1
            // 
            this.recipeColumnHead1.Width = 250;
            // 
            // recipeColumnHead2
            // 
            this.recipeColumnHead2.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 726);
            this.Controls.Add(this.mainTitleText);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabs.ResumeLayout(false);
            this.recipeSearchTab.ResumeLayout(false);
            this.recipeTabContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recipeTabContainer)).EndInit();
            this.recipeTabContainer.ResumeLayout(false);
            this.searchRecipeContainer.Panel1.ResumeLayout(false);
            this.searchRecipeContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchRecipeContainer)).EndInit();
            this.searchRecipeContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage recipeSearchTab;
        private System.Windows.Forms.TabPage kitchenStockTab;
        private System.Windows.Forms.SplitContainer recipeTabContainer;
        private System.Windows.Forms.TabPage shoppingListTab;
        private System.Windows.Forms.SplitContainer searchRecipeContainer;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label mainTitleText;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader recipeColumnHead1;
        private System.Windows.Forms.ColumnHeader recipeColumnHead2;
    }
}

