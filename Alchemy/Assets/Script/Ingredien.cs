using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ingredien : MonoBehaviour
{
    private static List<string> ordersName = new List<string> {"Battle Potion", "Invisibility Potion", "Love Potion", "Poison", "Recovery Potion", "Sleep Potion"};
    [SerializeField] private Text ing1, ing2, ing3, ing4, recipeName;
    [SerializeField] private int nameRecipe;
    void Start()
    {
        recipeName = GameObject.Find("Canvas/Recipe/Text").GetComponent<Text>();
        ing1 = GameObject.Find("Canvas/Recipe/Ingredient1").GetComponent<Text>();
        ing2 = GameObject.Find("Canvas/Recipe/Ingredient2").GetComponent<Text>();
        ing3 = GameObject.Find("Canvas/Recipe/Ingredient3").GetComponent<Text>();
        ing4 = GameObject.Find("Canvas/Recipe/Ingredient4").GetComponent<Text>();
    }
    void Update()
    {
        nameRecipe = PlayerPrefs.GetInt("RecipeName");
        if (nameRecipe == 1)
        {
            recipeName.text = ordersName[0];
            ing1.text = ("Griffin Blood");
            ing2.text = ("Pearl");
            ing3.text = ("Snake Bile");
            ing4.text = ("Mandrake Root");
        }
        else if(nameRecipe == 2)
        {
            recipeName.text = ordersName[1];
            ing1.text = ("Glowing Dust");
            ing2.text = ("Griffin Blood");
            ing3.text = ("Pearl");
            ing4.text = ("Butterfly Wing");
        }
        else if(nameRecipe == 3)
        {
            recipeName.text = ordersName[2];
            ing1.text = ("Butterfly Wing");
            ing2.text = ("Pearl");
            ing3.text = ("Glowing Dust");
            ing4.text = ("Dry Violets");
        }
        else if(nameRecipe == 4)
        {
            recipeName.text = ordersName[3];
            ing1.text = ("Toads Tongue");
            ing2.text = ("Rat Tail");
            ing3.text = ("Mandrake Root");
            ing4.text = ("Snake Bile");
        }
        else if(nameRecipe == 5)
        {
            recipeName.text = ordersName[4];
            ing1.text = ("Mandrake Root");
            ing2.text = ("Griffin Blood");
            ing3.text = ("Pearl");
            ing4.text = ("Butterfly Wing");
        }
        else if(nameRecipe == 6)
        {
            recipeName.text = ordersName[5];
            ing1.text = ("Glowing Dust");
            ing2.text = ("Toads Tongue");
            ing3.text = ("Mandrake Root");
            ing4.text = ("Dry Violets");
        }
    }
}
