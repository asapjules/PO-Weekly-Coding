using System;

namespace Smoothie
{
    public class Smoothie
    {
        public string Ingredients;
        private string[] IngredientsList;
        private double cost;
        public Smoothie(string[] ingredients){
        IngredientsList = ingredients;
            foreach(var ingredient in IngredientsList){
                if (ingredient == "Banana"){
                    cost += 0.50;
                }
                else if(ingredient == "Strawberries"){
                    cost+=1.00;
                }
                else if(ingredient == "Mango"){
                    cost+= 2.50;
                }
                else if(ingredient == "Blueberries"){
                    cost+= 1.00;
                }
                else if(ingredient == "Raspberries"){
                    cost+= 1.00;
                }
                else if (ingredient == "Apple"){
                    cost += 1.75;
                }
                else if( ingredient == "Pineapple"){
                    cost += 3.5;
                }
                else{
                    cost +=0;
                }
            }
        Ingredients = string.Join(" ", ingredients);
        Ingredients = "{ "+ Ingredients + " }";
        }
        public double GetCost(){
            return cost;
        }
        public double GetPrice(){
            double initial = this.GetCost();
            return Math.Round(initial + initial*1.5, 2);
        }
        public string GetName(){
            string name = "";
            foreach(var ingredient in IngredientsList){
                if (ingredient == "Banana"){
                    name += "Banana ";
                }
                else if(ingredient == "Strawberries"){
                    name += "Strawberry ";
                }
                else if(ingredient == "Mango"){
                    name += "Mango ";
                }
                else if(ingredient == "Blueberries"){
                    name += "Blueberry ";
                }
                else if(ingredient == "Raspberries"){
                    name += "Raspberry ";
                }
                else if (ingredient == "Apple"){
                    name += "Apple ";
                }
                else if( ingredient == "Pineapple"){
                    name += "Pineapple ";
                }
            }
            if(Ingredients.Length > 1){
                name += "Fusion";
            }
            else{
                name += "Smoothie";
            }
            return name;
        }
    }

}
