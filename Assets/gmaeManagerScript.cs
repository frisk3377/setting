using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gmaeManagerScript : MonoBehaviour
{
    // Start is called before the first frame update

    int[] map;
    void Start()
    {
        map = new int[] {0,0,0,1,0,0,0,0,0 };

        String debugText = "";
        for (int i = 0; i < map.Length; i++) 
        {
            debugText += map[i].ToString()+",";
        }
        Debug.Log(debugText);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            int playerindex = -1;
            for (int i = 0;i < map.Length;i++)
            {
                if (map[i] == 1)
                {
                    playerindex = i;
                    break;
                }
            }

            if (playerindex < map.Length - 1)
            {
                map[playerindex+1] = 1;
                map[playerindex] = 0;
            }

            String debugText = "";
            for (int i = 0; i < map.Length; i++)
            {
                debugText += map[i].ToString() + ",";
            }
            Debug.Log(debugText);

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            int playerindex = 1;
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] == 1)
                {
                    playerindex = i;
                    break;
                }
            }

            if (playerindex < map.Length - 1)
            {
                map[playerindex - 1] = 1;
                map[playerindex] = 0;
            }

            String debugText = "";
            for (int i = 0; i < map.Length; i++)
            {
                debugText += map[i].ToString() + ",";
            }
            Debug.Log(debugText);

        }
    }
}
