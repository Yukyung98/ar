using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class PlaceOnPlane : MonoBehaviour
{
    public ARRaycastManager raycastManager; // 우리가 생성한 오브젝트에 레이저를 쏠때만 작동된다.
    public GameObject prefab; // 우리가 생성할 게임오브젝트를 외부에서 받아온다.


    void Update()
    {
        if(Input.touchCount == 0) return; // 화면에서의 터치가 없는 경우 return을 하여 아래 내용들을 실행되지 않게 한다.

        var touch = Input.GetTouch(index:0);// 현재 터치 상태를 받아주고, index: 0 은 터치가 0이면 첫번째 잇푼값을 의미하고 1,2,3 증가할 수 있다. 즉 첫번째 터치 값을 가져오겠다는 소리다.
        if(touch.phase != TouchPhase.Began) return; // 터치가 바로 눌렸을때 began일 때 함수가 동작하게 해준다.
        var hits = new List<ARRaycastHit>();   // 이후에 Raycast 함수를 작성하려고 하는데 거기서 input을 ARRaycastHit List를 받게 되어 있다.
        if(raycastManager.Raycast(screenPoint: touch.position, hits,TrackableType.PlaneWithinPolygon))
        // 우리가 터치한 지점에 2d 좌표를 넣어주어서 플레인에 레이저를 쏜다음 3d 좌표를 가져오고
        {
            var pose = hits[0].pose; // 우리가 터치했을때 그 위에 여러종류의 평면이나 face 값들이 있다보니 hits 값들이 많다. 그 중에 우리는 0번쨰를 가져올 것이다.
            Instantiate(prefab,pose.position, pose.rotation); // 3d 좌표에 v포지션과 로테이션 값을 가진  프리팹 생성
        }   

        //RayCast 함수는 우리가 터치한 지점을 지정해준다고 가정할 경우 스크린에서 우리가 터치한 경우 우리가 지정한 평면으로까지 레이저를 쏜다고 보면 되고 닿는 부분이 무엇인가 닿는 부분의 포지션이 무엇인가에 대한 결과를 알려준다.
        //TrackableType은 plane에 관한 값들이 많다.
        
    }
}
