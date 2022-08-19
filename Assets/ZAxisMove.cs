using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAxisMove : MonoBehaviour
{
    private bool back = false;

    // Update is called once per frame
    void Update()
    {
        if (this.transform.localPosition == new Vector3(2.7f, 0.0f, 10.0f))
        {
            back = true;
        }
        else if (this.transform.localPosition == new Vector3(2.7f, 0.0f, 0.0f))
        {
            back = false;
        }

        if (back)
        {
            this.transform.localPosition -= new Vector3(0.0f, 0.0f, 0.05f);
        }
        else
        {
            this.transform.localPosition += new Vector3(0.0f, 0.0f, 0.05f);
        }
        
    }
}
