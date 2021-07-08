using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recipe : MonoBehaviour
{
    [SerializeField] private List<string> battlePotion = new List<string> {"Griffin Blood", "Pearl", "Snake Bile", "Mandrake Root"};
    [SerializeField] private List<string>  invisibilityPotion = new List<string> {"Glowing Dust", "Griffin Blood", "Pearl", "Butterfly Wing"};
    [SerializeField] private List<string> lovePotion = new List<string> {"Butterfly Wing", "Pearl", "Glowing Dust", "Dry Violets"};
    [SerializeField] private List<string> poison = new List<string> {"Toads Tongue", "Rat Tail", "Mandrake Root", "Snake Bile"};
    [SerializeField] private List<string> recoveryPotion = new List<string> {"Mandrake Root", "Griffin Blood", "Pearl", "Butterfly Wing"};
    [SerializeField] private List<string> sleepPotion = new List<string> {"Glowing Dust", "Toads Tongue", "Mandrake Root", "Dry Violets"};
    [SerializeField] private Color right, wrong, original;
    [SerializeField] private GameObject vessel;
    [SerializeField] private Text nameRecipe;
    private string battlePotionName = "Battle Potion"; 
    private string invisibilityPotionName = "Invisibility Potion"; 
    private string lovePotionName = "Love Potion"; 
    private string poisonName = "Poison"; 
    private string recoveryPotionName = "Recovery Potion"; 
    private string sleepPotionName = "Sleep Potion";
    private int a;
    void Start()
    {
        nameRecipe = GameObject.Find("Canvas/Recipe/Text").GetComponent<Text>();
        Debug.Log(battlePotionName.ToString());
    }
    public void Choise(GameObject button)
    {
        if(IngredientMove.isChoise)
        {
            if(battlePotion.Contains(button.GetComponent<Text>().text) && nameRecipe.text == battlePotionName.ToString())
            {
                a++;
            }
            else
            {
                a = 0;
            }
            if(a==4)
            {
                vessel.GetComponent<Animator>().SetTrigger("Moving");
            }  
            if(invisibilityPotion.Contains(button.GetComponent<Text>().text) && nameRecipe.text == invisibilityPotionName.ToString())
            {
                a++;
            }
            else
            {
                a = 0;
            }
            if(a==4)
            {
                vessel.GetComponent<Animator>().SetTrigger("Moving");
            }  
            if(lovePotion.Contains(button.GetComponent<Text>().text) && nameRecipe.text == lovePotionName.ToString())
            {
                a++;
            }
            else
            {
                a = 0;
            }
            if(a==4)
            {
                vessel.GetComponent<Animator>().SetTrigger("Moving");
            }  
            if(poison.Contains(button.GetComponent<Text>().text) && nameRecipe.text == poisonName.ToString())
            {
                a++;
            }
            else
            {
                a = 0;
            }
            if(a==4)
            {
                vessel.GetComponent<Animator>().SetTrigger("Moving");
            }  
            if(recoveryPotion.Contains(button.GetComponent<Text>().text) && nameRecipe.text == recoveryPotionName.ToString())
            {
                a++;
            }
            else
            {
                a = 0;
            }
            if(a==4)
            {
                vessel.GetComponent<Animator>().SetTrigger("Moving");
            }  
            if(sleepPotion.Contains(button.GetComponent<Text>().text) && nameRecipe.text == sleepPotionName.ToString())
            {
                a++;
            }
            else
            {
                a = 0;
            }
            if(a==4)
            {
                vessel.GetComponent<Animator>().SetTrigger("Moving");
            }
        }
    }
}
