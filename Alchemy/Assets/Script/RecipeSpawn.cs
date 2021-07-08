using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeSpawn : MonoBehaviour
{
    public static List<string> ordersName = new List<string> { "Battle Potion", "Invisibility Potion", "Love Potion", "Poison", "Recovery Potion", "Sleep Potion" };
    public static GameObject orderPrefab;
    public static Transform orderPosition;
    private static int size = 6;
    void Start()
    {
        orderPrefab = Resources.Load("Recipe") as GameObject;
        orderPosition = GameObject.Find("Canvas/Orders").GetComponent<Transform>();
        GenerateOrder();
    }
    public static void GenerateOrder()
    {
        for (int i = 0; i < size; i++)
        {
            orderPrefab.GetComponent<Text>().text = ordersName[Random.Range(0, ordersName.Count)];
            Instantiate(orderPrefab, orderPosition);
        }
    }
}
