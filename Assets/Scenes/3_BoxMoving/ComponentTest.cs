using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 컴포넌트를 가져오는 방법
public class ComponentTest : MonoBehaviour
{
    //일반적으로 컴포넌트를 얻어오는 방법으로는 퍼블릭으로 선언해주는 것이다. 가장 효율적인 방법
    public Collider collider;  //외부에서 해당 컴포넌트를 받아온다. 유니티 스피어 오브젝트에 이 스크립트를 넣은 후 Collider에 스피어 오브젝트를 넣는다.
    // Start is called before the first frame update
    void Start()
    {
       collider = GetComponent<Collider>(); // 콜라이더를 얻어오는 방법
       var cols = GetComponentsInChildren<Collider>(); // 오브젝트 하위에 있는 오브젝트들의 콜라이더를 가져오는 방법, 시스템 부하를 일으킴
       GameObject.Find("Cube"); // Cube라는 이름의 오브젝트 가져오기. 시스템 부하를 일으킴

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
