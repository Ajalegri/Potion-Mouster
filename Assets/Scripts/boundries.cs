using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundries : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds= Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewPos = transform.position;
        //viewPos.x = Mathf.Clamp(viewPos.x)
    }
}
