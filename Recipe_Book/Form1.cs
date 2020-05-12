using Recipe_Book.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RecipeBook
{
    public partial class Form1 : Form
    {
        public int num_recipes = 0;
        public List<Recipe> recipes = new List<Recipe>();
        public List<Recipe> current_search_results = new List<Recipe>();
        public List<Recipe> ing_search_results = new List<Recipe>();
        public Recipe selected_recipe = null;
        public SplitContainer fullRecipeSplit = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadRecipes();
            initializeSmallRecipeView();
        }


        private void loadRecipes()
        {
            string path = Directory.GetCurrentDirectory();
            path = path.Remove(path.Length - 10);
            path += @"\Resources\recipes.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);    //how do I access specific resource file
            string line;                                
            bool end = false;
            // may want to refactor in the future
            while (!file.EndOfStream)
            {
                // create each recipe, populate variables
                Recipe a_recipe = new Recipe();
                line = file.ReadLine();
                a_recipe.setName(line);
                line = file.ReadLine();
                a_recipe.setImagePath(line);
                // ingredient amounts
                line = file.ReadLine();
                string[] str_amounts = line.Split(',');
                double[] amounts = new double[str_amounts.Length];
                for (int i = 0; i < str_amounts.Length; i++)
                    amounts[i] = Convert.ToDouble(str_amounts[i]);
                a_recipe.setAmounts(amounts);
                // ingredient units
                line = file.ReadLine();
                string[] units = line.Split(',');
                a_recipe.setUnits(units);
                // ingredients
                line = file.ReadLine();
                string[] ingredients = line.Split(',');
                a_recipe.setIngredients(ingredients);
                // ingredient notes
                line = file.ReadLine();
                string[] ing_notes = line.Split(',');
                a_recipe.setIngNotes(ing_notes);
                // process
                string full_process = "";
                while (!end)    // read full process until last line (which starts with *)
                {
                    line = file.ReadLine();
                    if (line[0] == '*')
                    {
                        end = true;
                        line = line.Substring(1);   // do I want to keep the * in the string for re-writing?
                    }
                    else
                        line += "\r\n\n";
                    full_process += line;
                }
                a_recipe.setProcess(full_process);
                end = false;
                // additional notes
                string full_notes = "";
                while (!end)    // read full notes until last line (which starts with *)
                {
                    line = file.ReadLine();
                    if (line[0] == '*')
                    {
                        end = true;
                        line = line.Substring(1);   // do I want to keep the * in the string for re-writing?
                    }
                    else
                        line += "\r\n\n";
                    full_notes += line;
                }
                a_recipe.setNotes(line);
                end = false;

                // add recipe to root list
                recipes.Add(a_recipe);
                num_recipes++;
            }
            file.Close();
            ing_search_results = recipes;
            updateSearchResults(recipes);
        }

        private void initializeSmallRecipeView()
        {
            pictureSlim.Visible = false;
            fullRecipeButton.Visible = false;
            processTextSlim.Visible = false;
            tableExample.Visible = false;
        }

        private void updateSearchResults(List<Recipe> search_results)
        {
            // add recipes to listview, position in current search results added as item tag
            recipeSearchResults.Items.Clear();
            current_search_results = search_results;
            for (int i = 0; i < search_results.Count(); i++)
            {
                ListViewItem item = new ListViewItem(search_results[i]._name);
                item.Tag = i;
                recipeSearchResults.Items.Add(item);
            } 
        }

        private void textSearch (string text)
        {
            // update search results
            List<Recipe> matching_recipes = new List<Recipe>();
            ListViewItem item = recipeSearchResults.FindItemWithText(text);
            while (item != null)
            {
                matching_recipes.Add(current_search_results[Convert.ToInt32(item.Tag)]);
                recipeSearchResults.Items.Remove(item);
                item = recipeSearchResults.FindItemWithText(text);
            }
            updateSearchResults(matching_recipes);
        }

        List<Recipe> ingredientSearch(List<string> ing_list)
        {
            // search for checked ingredients
            var ing_pairs = new List<KeyValuePair<Recipe, double>>();
            List<Recipe> result = new List<Recipe>();

            for(int i = 0; i < num_recipes; i++)
            {
                for (int j = 0; j < ing_list.Count(); j++)
                {
                    double amount = recipes[i].hasIngredient(ing_list[j]);
                    if (amount > 0)
                        ing_pairs.Add(new KeyValuePair<Recipe, double> (recipes[i], amount));
                }
            }
            // TODO: sort ing_pairs by amount (second parameter), then return array of sorted recipes
            for (int i = 0; i < ing_pairs.Count(); i++)
            {
                result.Add(ing_pairs[i].Key);
            }
            return result;
        }

        private void drawRecipeSlim(Recipe recipe)
        {
            foreach (TableLayoutPanel table_instance in splitContainerRecipeSlim.Panel2.Controls.OfType<TableLayoutPanel>())
            {
                splitContainerRecipeSlim.Panel2.Controls.Remove(table_instance);
                table_instance.Dispose();
            }

            pictureSlim.Visible = true;
            pictureSlim.Image = recipe._image;
            fullRecipeButton.Visible = true;

            TableLayoutPanel table = new TableLayoutPanel();
            table.Parent = splitContainerRecipeSlim.Panel2;
            table.Dock = DockStyle.Top;

            populateIngrTable(table, recipe);

            // process
            processTextSlim.Visible = true;
            processTextSlim.Text = recipe._process;
            // notes?
        }

        private void populateIngrTable(TableLayoutPanel table, Recipe recipe)
        {
            table.ColumnCount = 4;
            table.RowCount = recipe._ingredient_list.Length;

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));

            table.AutoSize = true;
            table.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // ingredients

            for (int i = 0; i < recipe._ingredient_list.Length; i++)
            {
                Label item_amount = new Label();
                item_amount.Text = recipe._amounts[i].ToString();
                item_amount.BorderStyle = BorderStyle.None;
                item_amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                item_amount.Dock = DockStyle.Fill;
                table.Controls.Add(item_amount, 0, i);
            }

            for (int i = 0; i < recipe._ingredient_list.Length; i++)
            {
                ComboBox item_unit = new ComboBox();
                item_unit.Text = recipe._units[i];
                item_unit.FlatStyle = FlatStyle.Flat;
                table.Controls.Add(item_unit, 1, i);
            }

            for (int i = 0; i < recipe._ingredient_list.Length; i++)
            {
                TextBox item_ing = new TextBox();
                item_ing.Text = recipe._ingredient_list[i];
                item_ing.BorderStyle = BorderStyle.None;
                item_ing.Dock = DockStyle.Fill;
                table.Controls.Add(item_ing, 2, i);
            }

            for (int i = 0; i < recipe._ingredient_list.Length; i++)
            {
                TextBox item_notes = new TextBox();
                item_notes.Text = recipe._ing_notes[i];
                item_notes.BorderStyle = BorderStyle.None;
                item_notes.Dock = DockStyle.Fill;
                table.Controls.Add(item_notes, 3, i);
            }
        }

        private void createButton(Button button, string text)
        {
            button.Width = 115; 
            button.Height = 40;
            button.Text = text;
        }

        // event handlers
        private void recipeListView_SelectedIndexChanged(object sender, EventArgs e)    // when recipe is selected from list
        {
            var s = recipeSearchResults.SelectedItems;
            if (s.Count > 0)
            {
                var i = s[0].Tag;
                int selection_index = Convert.ToInt32(i.ToString());
                Recipe selection = current_search_results[selection_index];
                selected_recipe = selection;
                drawRecipeSlim(selection);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)     //ingredient search button pressed
        {
            // get checked ingredients and add to list
            CheckedListBox.CheckedItemCollection checked_obj = ingredientChecklist.CheckedItems;
            List<string> checked_list = new List<string>();

            foreach (object item in checked_obj)
            {
                checked_list.Add(item.ToString());
            }
            List<Recipe> recipe_list = ingredientSearch(checked_list); //currently returns unsorted list of recipes
            ing_search_results = recipe_list;
            updateSearchResults(ing_search_results);
        }

        private void textSearchEnterKeyHandler(object sender, KeyEventArgs e)   // user typed text search term into search bar and pressed enter
        {
             if (e.KeyCode == Keys.Enter)
                textSearch(textSearchBox.Text);
        }

        // search clears
        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            textSearchBox.Text = "Search...";
            for(int i = 0; i < ingredientChecklist.Items.Count; i++)
                ingredientChecklist.SetItemCheckState(i, CheckState.Unchecked);
            updateSearchResults(recipes);
        }

        private void textSearchClearButton_Click(object sender, EventArgs e)
        {
            // resets text search, doesn't clear ingredient search
            textSearchBox.Text = "Search...";
            updateSearchResults(ing_search_results);
        }

        private void fullRecipeButton_Click(object sender, EventArgs e)
        {
            // create new split container, pic and ingredients on left, name process and notes on right
            // full page splitter
            recipeTabContainer.Visible = false;
            fullRecipeSplit = new SplitContainer();
            fullRecipeSplit.Parent = recipeSearchTab;
            fullRecipeSplit.Dock = DockStyle.Fill;
            fullRecipeSplit.Orientation = Orientation.Vertical;
            fullRecipeSplit.SplitterDistance = 565;
            // Panel 1
            // image/ingredients splitter
            SplitContainer fullImgIngrSplit = new SplitContainer();
            fullImgIngrSplit.Parent = fullRecipeSplit.Panel1;
            fullImgIngrSplit.Dock = DockStyle.Fill;
            fullImgIngrSplit.Orientation = Orientation.Horizontal;
            fullImgIngrSplit.SplitterDistance = 300;
            // image
            PictureBox full_picture = new PictureBox();
            full_picture.Parent = fullImgIngrSplit.Panel1;
            full_picture.Height = 325;
            full_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            full_picture.Dock = DockStyle.Top;
            full_picture.Image = selected_recipe._image;
            // ingredients
            TableLayoutPanel ing_table = new TableLayoutPanel();
            ing_table.Parent = fullImgIngrSplit.Panel2;
            ing_table.Dock = DockStyle.Top;
            populateIngrTable(ing_table, selected_recipe);

            // Panel 2
            // 3 split containers
            // 1st sections off the buttons
            SplitContainer buttonSplit = new SplitContainer();
            buttonSplit.Parent = fullRecipeSplit.Panel2;
            buttonSplit.Dock = DockStyle.Fill;
            buttonSplit.Orientation = Orientation.Horizontal;
            buttonSplit.SplitterDistance = 50;
            buttonSplit.IsSplitterFixed = true;

            // 2nd splits off recipe name
            SplitContainer nameSplit = new SplitContainer();
            nameSplit.Parent = buttonSplit.Panel2;
            nameSplit.Dock = DockStyle.Fill;
            nameSplit.Orientation = Orientation.Horizontal;
            nameSplit.SplitterDistance = 100;

            // 3rd splits process and notes
            SplitContainer processSplit = new SplitContainer();
            processSplit.Parent = nameSplit.Panel2;
            processSplit.Dock = DockStyle.Fill;
            processSplit.Orientation = Orientation.Horizontal;
            processSplit.BackColor = ColorTranslator.FromHtml("#FFB0C4DE");

            // edit/cooking mode/exit buttons
            Button editButton = new Button();
            editButton.Parent = buttonSplit.Panel1;
            createButton(editButton, "Edit Recipe");
            editButton.Dock = DockStyle.Left;
            // editButton.BackColor = ColorTranslator.FromHtml("#FFB0C4DE");
            editButton.Enabled = false;                                 // delete me when implementing edit recipe, and uncomment previous
                // TODO: fix and implement cooking mode button
            /*Button cookingModeButton = new Button();
            cookingModeButton.Parent = buttonSplit.Panel1;
            createButton(cookingModeButton, "Cooking Mode");
            cookingModeButton.Anchor = AnchorStyles.None;*/
            Button exitButton = new Button();
            exitButton.Parent = buttonSplit.Panel1;
            createButton(exitButton, "Exit");
            exitButton.Dock = DockStyle.Right;
            exitButton.BackColor = ColorTranslator.FromHtml("#FFB0C4DE");
            editButton.Click += new EventHandler(editButton_Click);
            exitButton.Click += new EventHandler(exitButton_Click);

            // recipe name label
            Label name = new Label();
            name.UseMnemonic = false;
            name.Text = selected_recipe._name;
            name.Font = new Font("Elephant", 20);
            name.Parent = nameSplit.Panel1;
            name.Dock = DockStyle.Fill;
            name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // process text box
            TextBox processBox = new TextBox();
            processBox.Multiline = true;
            processBox.Text = selected_recipe._process;
            processBox.Parent = processSplit.Panel1;
            processBox.Dock = DockStyle.Fill;
            processBox.BackColor = ColorTranslator.FromHtml("#FFB0C4DE");
            processBox.BorderStyle = BorderStyle.None;
            processBox.ReadOnly = true;
            // recipe notes text box
            TextBox notesBox = new TextBox();
            notesBox.Multiline = true;
            notesBox.Text = selected_recipe._add_notes;
            notesBox.Parent = processSplit.Panel2;
            notesBox.Dock = DockStyle.Fill;
            notesBox.BackColor = ColorTranslator.FromHtml("#FFB0C4DE");
            notesBox.BorderStyle = BorderStyle.None;
            notesBox.ReadOnly = true;
        }

        private void editButton_Click(object sender, EventArgs e)   //TODO: implement editing
        {
            // in fullRecipeButton_Click delete line making edit button enabled false
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            recipeSearchTab.Controls.Remove(fullRecipeSplit);
            fullRecipeSplit.Dispose();
            recipeTabContainer.Visible = true;
        }
    }

    public class Recipe
    {
        public string _name;
        public Image _image;
        public double[] _amounts;
        public string[] _units;
        public string[] _ingredient_list;
        public string[] _ing_notes;
        public string _process;
        public string _add_notes;
        // write getters if making ing private

        public void setName(string name)
        {
            _name = name;
        }

        public void setImagePath(string file_name)
        {
            string path = Directory.GetCurrentDirectory();
            path = path.Remove(path.Length - 10);
            path += @"\Resources\" + file_name;
            _image = Image.FromFile(path);
        }

        public void setAmounts(double[] amounts)
        {
            _amounts = amounts;
        }
        
        public void setUnits(string[] units)
        {
            _units = units;
        }

        public void setIngredients(string[] ingredients)
        {
            _ingredient_list = ingredients;
        }

        public void setIngNotes(string[] notes)
        {
            _ing_notes = notes;
        }

        public void setProcess(string process)
        {
            _process = process;
        }

        public void setNotes(string notes)
        {
            _add_notes = notes;
        }

        public double hasIngredient(string ingredient)
        {
            for (int i = 0; i < _ingredient_list.Length; i++)
            {
                if (_ingredient_list[i] == ingredient)
                {
                    return _amounts[i];
                }
            }
            return 0;
        }

        public void scaleRecipe(double factor)
        {          
            for (int i = 0; i < _amounts.Length; i++)
            {
                _amounts[i] = _amounts[i] * factor;
            }
        }
    }
}
