using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trueend_tf : MonoBehaviour
{
    public GameObject txtobj_prefab;
    private GameObject txtobj;
    public GameObject canvas;
    public static int bonusyes;
      
    void Awake()
    {
        if (control2d.trueend == 3)
        {
            txtobj = Instantiate(txtobj_prefab, new Vector3(1354,668,0), Quaternion.identity);
            txtobj.transform.SetParent(canvas.transform);
            bonusyes = 1;
        }
        else
        {
            bonusyes = 0;
        }
    }

}
