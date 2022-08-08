using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAIn1 : MonoBehaviour
{   
    [SerializeField] Transform[] Posistions;
    [SerializeField] float ObjectSpeed;

    int NextPosIndex;
    Transform NextPos;
    public bool movedonuts = false;
    // Start is called before the first frame update
    void Start()
    {
        NextPos = Posistions[0];
    }

    // Update is called once per frame
    void Update()
    {
        
        
            MoveGameObject();
           
        
        
    }
    void MoveGameObject()
    {if (transform.position == NextPos.position)
    {
        NextPosIndex++;
        if(NextPosIndex >= Posistions.Length)
        {
            NextPosIndex = 0;
        }
        NextPos = Posistions[NextPosIndex];

    }
    else 
    {
        transform.position = Vector3.MoveTowards(transform.position, NextPos.position, ObjectSpeed * Time.deltaTime);
    }
    }

}
