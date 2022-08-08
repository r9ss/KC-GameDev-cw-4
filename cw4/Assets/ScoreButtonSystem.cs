using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class ScoreButtonSystem : MonoBehaviour
{
public float score = 0f;
public float inc = 1f;
public float Price = 5f;
public Text scoreText;
public Text incText;
public Text PriceText;
public AudioSource audioData;
public AudioSource audio;
public SoundFx script;
public RAIn scripts;

    // Start is called before the first frame update
    void Start()
    {
        incText.text = "inc: " + 1f;
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void scoreUp()
    {
        score += inc;
        scoreText.text = score.ToString();
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
    }

    public void Shop()
    {
        if(score >= Price)
        {
            score -= Price;
            inc += 1;
            Price += 15f;
            scoreText.text = score.ToString();
            incText.text = "Inc: " + inc;
            PriceText.text = "Price: " + Price;
            audio = GetComponent<AudioSource>();
        audio.Play(0);
           script.Sound();
           scripts.movedonuts = true;
           
        }
        
    }
    

    
    
    
}
