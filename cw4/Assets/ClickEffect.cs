using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEffect : MonoBehaviour
{
    public bool clicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    
   public void ClickScaleEffect()
   {
     StartCoroutine(TimeDelay());
         clicked = false;
  
        
   }
   public IEnumerator TimeDelay()
   {
      
      transform.localScale = new Vector3(2.534001f,5.992334f,1.874435f);
      yield return new WaitForSeconds(0.2f);
      transform.localScale = new Vector3(1.96815634f,5.15469551f,1.87443471f);
      clicked = false;
   }
}
