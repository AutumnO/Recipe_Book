April 22nd, 2020
I created a repository for a Recipe Book application and organized and wrote out my goals. I’m not sure how to approach this project in Unity but due to the hard deadline and my previous knowledge it seems like my best bet at this time. I wrote some short term goals for the scope of this project that I will revise as I begin working on the application.

April 24th, 2020
I had my lab meeting with Adam today to discuss my plans for the final project. He showed me the basics with WinForms and after seeing what the program has to offer I believe it will be worth learning for this project as it is more applicable to my goals for the Recipe Book.

April 30th, 2020
I began the project by playing around in WinForms and checking out the options for a recipe search tab and the general layout. I’m finding it difficult to understand the objects and the layout of the features, but really starting to get an idea of the resources available to me. I have a space at the top of the form where I would ideally place a logo or image, and tabs below that for each of the pages. I’m playing with using a split view with the searching and results on the left and the full recipe if one is selected on the right.
My current goal is to map out the first tab (searching and recipe viewing) so I can get an idea of the elements I want to use and the formatting I need. This is also going to help dictate what is currently possible and refine my goals to appropriately fit the timeframe.
	(x) Crude formatting of elements for recipe search page
	(x) Add treeView with checkboxes for ingredient search terms
	(x) Crude formatting of elements for recipe display page
	(x) Tabs should fill window but appear under title

May 1st, 2020
I spent my lab with Adam recovering the project files and changing the .gitignore that was preventing them from directly committing.

May 5th, 2020
Today I began by creating a class for recipes, with a basic scale ingredients function and a function that returns the amount of a particular ingredient in the given recipe. I also brainstormed how to store recipes and decided on a text file as that is what I’m currently most familiar with, so I created a function that read the recipes file and created recipe instances. The path for the text document is specific to my machine which I need to figure out. I still need to write a function when the program ends that re-writes the file with changes or additions.
	(x) Add recipe class with ingredient scaler
	(x) hasIngredient function
	(x) Create text document for recipes
	(x) Load function to read from text document and populate recipes list

May 6th, 2020
I used get current directory to access the local directory and added \Recipes.txt, with a few other tweaks this seemed to work, although I’m not sure how it will function on other machines. I also fixed some exceptions and decided making the recipe array a list instead was more effective with what I was trying to do. My next step was adding the full list of recipes to the list view on the search page, which I soon realized would work better as its own function so it could be used to update the results with any list. Finally I finished up the searching capabilities and the search clear buttons. These were particularly difficult to implement as separate entities so I decided the ingredient clear should clear both the ingredients and the text search, while the text search clear should only clear the text search. I still need to fix the functions that return ingredient searches, that is my next goal.
	(x) More general way to get recipe text, maybe using get directory
	(x) Add recipe list to list view upon load
	(x) Add text search capabilities to recipe list

May 7th, 2020
I reorganized by code a bit to make it easier to work with, and renamed a few variables and functions as well. I realized part of the reason my ingredient search was getting an error was the checkmarks on the root values, and I ended up changing the tree view to just a plain checked list sorted alphabetically, in the future I may change this to be grouped again but at this point the checked list works better. I finally got that working and tested it with the text search and clear buttons and everything is now in working order.
Coming back to the code, I set out to implement the slim recipe view when a recipe is clicked upon. Most of these components were pretty straightforward, but the ingredient creation was something of a mountain to climb. I quickly realized I would need to somehow create elements without knowing how many elements I wanted to create, and then be able to delete those elements when a new recipe needed to take its place. After playing around a bit I figured out that I could add elements into a list without naming them, but I still needed a way to put each of them on the page and change their properties individually, the most important being the objects’ locations. After more poking about and playing with other features I realized that when I deleted an element that held other elements, the interior elements would be deleted. I also found that formatting was a lot easier if I use a table layout panel, which would also add new rows for each ingredient, and size itself appropriately. This meant I only needed to access the individual objects once, upon creation. All in all getting the slim recipe view to work took a lot of fiddling and patience as I’m still not totally familiar with the methods and properties available, but I got it working and it looks good with the recipes currently available.
	(x) Fix ingredient search
	(x) Clicking recipe should prompt small view of full recipe
	(x) Hide recipe page until an item in the recipe list is activated
	(x) Images on recipes should stretch to fit image box
