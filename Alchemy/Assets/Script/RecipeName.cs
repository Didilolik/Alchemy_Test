using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeName : MonoBehaviour
{
    [SerializeField] private Text time;
    private bool isChoise = false;
    private float maxTime = 5;
    private int nameRecipe;
    private int size = 6;
    private List<string> ordersName;
    private Transform orderPosition;
    private GameObject orderPrefab;
    private void Start()
    {
        orderPosition = RecipeSpawn.orderPosition;
        orderPrefab = RecipeSpawn.orderPrefab;
        ordersName = RecipeSpawn.ordersName;
    }
    private void Update()
    {
        if(isChoise == true)
        {
            if (maxTime > 0)
            {
                time.text = maxTime.ToString();
                maxTime -= Time.deltaTime;
                time.text = Mathf.Round(maxTime).ToString();
            }
            else 
            {
                maxTime = 0;
                Destroy(gameObject);
                size--;
            }
        }
        if(size < 6)
        {
            orderPrefab.GetComponent<Text>().text = ordersName[Random.Range(0, ordersName.Count)];
            Instantiate(orderPrefab, orderPosition);
        }
    }
    public void Choice(GameObject button)
    {
        isChoise = true;

        if (button.GetComponent<Text>().text == "Battle Potion")
        {
            nameRecipe = 1;
            PlayerPrefs.SetInt("RecipeName", nameRecipe);
        }
        else if (button.GetComponent<Text>().text == "Invisibility Potion")
        {
            nameRecipe = 2;
            PlayerPrefs.SetInt("RecipeName", nameRecipe);
        }
        else if (button.GetComponent<Text>().text == "Love Potion")
        {
            nameRecipe = 3;
            PlayerPrefs.SetInt("RecipeName", nameRecipe);
        }
        else if (button.GetComponent<Text>().text == "Poison")
        {
            nameRecipe = 4;
            PlayerPrefs.SetInt("RecipeName", nameRecipe);
        }
        else if (button.GetComponent<Text>().text == "Recovery Potion")
        {
            nameRecipe = 5;
            PlayerPrefs.SetInt("RecipeName", nameRecipe);
        }
        else if (button.GetComponent<Text>().text == "Sleep Potion")
        {
            nameRecipe = 6;
            PlayerPrefs.SetInt("RecipeName", nameRecipe);
        }
    }
}
