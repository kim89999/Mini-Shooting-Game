using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScroll : MonoBehaviour
{

    Material mat; 
    float Yoffset = 0; //Y축의 오프셋 값
    float speed = 0.09f; // 배경이 스크롤 되는 속도

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Yoffset += speed * Time.deltaTime;
        mat.mainTextureOffset = new Vector2(0, Yoffset);
    }
}
