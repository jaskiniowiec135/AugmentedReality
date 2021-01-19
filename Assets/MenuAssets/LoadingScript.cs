using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScript : MonoBehaviour
{
    public Transform LoadingBar;
    [SerializeField] private float currentAmount;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
            Debug.Log((int)currentAmount);
        }
        else
        {
            Application.LoadLevel("MainMenu");
        }

        LoadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;

    }
}
