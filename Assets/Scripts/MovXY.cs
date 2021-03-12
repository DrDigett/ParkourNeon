using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovXY : MonoBehaviour
{
    public float xySpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //leyendo controles
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        LocalMove(h,v, xySpeed);
        ClampPosition();
    }

    void LocalMove(float x, float y, float speed)
    {
        transform.localPosition += new Vector3(x, y, 0) * speed * Time.deltaTime;
    }
    void ClampPosition()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
    
}
