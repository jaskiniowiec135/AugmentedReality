using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetVisibilty : MonoBehaviour
{
    // Start is called before the first frame update
    public Text infoText;
    public Button infoButton;
    
    public void Start()
    {
        infoText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void ShowInfo()
    {
        infoText.gameObject.SetActive(true);
        DeactivateInfo();
    }
    public void DeactivateInfo()
    {
        StartCoroutine(RemoveAfterSeconds(4));
    }
    IEnumerator RemoveAfterSeconds(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        infoText.gameObject.SetActive(false);
    }

}
