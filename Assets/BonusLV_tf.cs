using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusLV_tf : MonoBehaviour
{
    public GameObject bonusbutton_prefab;
    private GameObject bonusbutton;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        if (trueend_tf.bonusyes == 1)
        {
            bonusbutton = Instantiate(bonusbutton_prefab, new Vector3 (960,169,0), Quaternion.identity);
            bonusbutton.transform.SetParent(canvas.transform);
        }
    }
}
