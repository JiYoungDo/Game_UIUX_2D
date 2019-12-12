using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartprefab : MonoBehaviour
{
    public GameObject heart_prefab;
  

    // Start is called before the first frame update
    void Start()
    {
        for (int i = -7; i <= 7; i += 2)
        {
            for (int j = -7; j <= 7; j += 2)
            {
                GameObject _obj = Instantiate(heart_prefab) as GameObject;
                _obj.transform.localPosition = new Vector3(i, j, 0f);
                
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
