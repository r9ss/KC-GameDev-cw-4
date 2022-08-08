using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class ColourEffecttext : MonoBehaviour
{
    public bool startColorChange = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ColorEffect());
        
    }

    public IEnumerator ColorEffect()
   { 
      if(startColorChange == true)
      {
        startColorChange = false;
       GetComponent<Text>().color = Color.gray;
       yield return new WaitForSeconds(0.1f);
        GetComponent<Text>().color = Color.white;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Text>().color = Color.red;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Text>().color = Color.blue;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Text>().color = Color.green;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Text>().color = Color.black;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Text>().color = Color.yellow;
        yield return new WaitForSeconds(0.09f);
        startColorChange = true; 
      }
      else if(startColorChange == false)
      {

      }
      
   }
}
