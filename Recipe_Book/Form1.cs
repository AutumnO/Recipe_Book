using Recipe_Book.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBook
{
    public partial class Form1 : Form
    {
        Recipe[] recipes;
        int num_recipes;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadRecipes();
        }

        private void loadRecipes()
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\ao191\Desktop\bin\Recipe_Book\Recipe_Book\Recipes.txt");    //how do I access specific resource file
            string line;
            bool end = false;
            // may want to refactor in the future
            while (!file.EndOfStream)
            {
                // create each recipe, populate variables
                Recipe a_recipe = new Recipe();
                line = file.ReadLine();
                a_recipe.name = line;
                line = file.ReadLine();
                a_recipe.image = line;
                // ingredient amounts
                line = file.ReadLine();
                string[] str_amounts = line.Split(',');
                double[] amounts = { };
                for (int i = 0; i < str_amounts.Length; i++)
                    amounts[i] = Convert.ToDouble(str_amounts[i]);
                a_recipe.amounts = amounts;
                // ingredient units
                line = file.ReadLine();
                string[] units = line.Split(',');
                a_recipe.units = units;
                // ingredients
                line = file.ReadLine();
                string[] ingredients = line.Split(',');
                a_recipe.ingredient_list = ingredients;
                // ingredient notes
                line = file.ReadLine();
                string[] ing_notes = line.Split(',');
                a_recipe.ing_notes = ing_notes;
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
                        line += "/n";
                    full_process += line;
                }
                a_recipe.process = full_process;
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
                        line += "/n";
                    full_notes += line;
                }
                a_recipe.add_notes = line;
                end = false;

                // add recipe to root list
                recipes[num_recipes] = a_recipe;
                num_recipes++;
            }
        }

        private void recipeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when recipe is selected from list
        }

        private void searchButton_Click(object sender, EventArgs e)     //search button pressed
        {
            // get checked ingredients and add to array
            string[] checked_ing = {};
            int num_checked = 0;

            for (int i = 0; i < treeSearchIngredients.Nodes.Count; i++)
            {
                if (treeSearchIngredients.Nodes[i].Checked)
                {
                    checked_ing[num_checked] = treeSearchIngredients.Nodes[i].Text;
                    num_checked++;
                }
            }
            var recipe_list = searchRecipes(checked_ing, num_checked); //currently returns list of recipes with ingredient, TODO: sort the list
            // display recipe_list recipes in list of returned recipes
            recipeSearchResults.Items.Clear();
            for (int i = 0; i < recipe_list.Count; i++)
            {
                recipeSearchResults.Items.Add(recipe_list[i].Key.name, i);
            }
        }

        List<KeyValuePair<Recipe, double>> searchRecipes(string[] ing_list, int ing_total)
        {
            // search for checked ingredients
            var ing_pairs = new List<KeyValuePair<Recipe, double>>();

            for(int i = 0; i < num_recipes; i++)
            {
                for (int j = 0; j < ing_total; j++)
                {
                    double amount = recipes[i].hasIngredient(ing_list[j]);
                    if (amount > 0)
                        ing_pairs.Add(new KeyValuePair<Recipe, double> (recipes[i], amount));
                }
            }
            return ing_pairs;
        }
    }

    public class Recipe
    {
        public string name;
        public string image;
        public double[] amounts;
        public string[] units;
        public string[] ingredient_list;
        public string[] ing_notes;
        public string process;
        public string add_notes;


        public void drawRecipeSmall()
        {
            // image
            // buttons (visible enabled / invisible unenabled)
            // name
            // ingredients
            // process
            // notes
        }

        public double hasIngredient(string ingredient)
        {
            for (int i = 0; i < ingredient_list.Length; i++)
            {
                if (ingredient_list[i] == ingredient)
                {
                    return amounts[i];
                }
            }
            return 0;
        }

        public void scaleRecipe(double factor)
        {          
            for (int i = 0; i < amounts.Length; i++)
            {
                amounts[i] = amounts[i] * factor;
            }
        }
    }
}
