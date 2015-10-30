using UnityEngine;
using System.Collections;

public class Spring : MonoBehaviour {

    //private BoxCollider boxCollider;
    private float xSpringScale;
    private float xSpringPos;
    private float xCollider;
    private float xValue;
    private bool onKeyDown = false;
    
	
	void Start () {
        //boxCollider = GetComponent<BoxCollider>();
	}

    // Getters & Setters
        public bool OnKeyDown
        {
            get { return onKeyDown; }
            set { onKeyDown = value; }
        }
    //


    void FixedUpdate () {
        //boxCollider.size = new Vector3(xValue, 1f, 1f);
        //boxCollider.center = new Vector3(xCollider, 0f, 0f);
        transform.localScale = new Vector3(xSpringScale, 1f, 1f);
        transform.localPosition = new Vector3(xSpringPos, 173f, -91.4f);
        
        if (onKeyDown)
        {
            if (xValue > 5f) {
                xValue -= 0.2f;
            }

            if (xCollider > -2.15f)
            {
                xCollider -= 0.01f;
            }

            if (xSpringScale > 0.4f) {
                xSpringScale -= 0.002f;
            }

            if (xSpringPos < 138.33f) {
                xSpringPos += 0.01f;
            }
        }
        else {
            xValue = 8.08f;
            xCollider = -0.1f;
            xSpringScale = 0.8f;
            xSpringPos = 134.8f;
        }//0.06f
	}
}
