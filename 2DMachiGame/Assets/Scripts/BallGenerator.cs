using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject Ball;

    // Start is called before the first frame update
    private void Start()
    {


        for (int i = 0; i < 30; i++)
        {
            Instantiate(Ball,this.transform);




        }
    }


}
