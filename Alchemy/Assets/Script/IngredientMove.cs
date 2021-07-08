using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientMove : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform panelPosition;
    [SerializeField] private float speed;
    public static bool isChoise = false;
    void Start()
    {
        panelPosition = GameObject.Find("Canvas/Panel").GetComponent<Transform>();
    }
    void Update()
    {
        
    }
    public void TP()
    {
        isChoise = true;
        GetComponent<Animator>().SetTrigger("Destroy");
        Instantiate(prefab, panelPosition);
        StartCoroutine (Destroy());
    }
    public IEnumerator Destroy()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
