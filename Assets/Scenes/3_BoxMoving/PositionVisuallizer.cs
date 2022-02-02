using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionVisuallizer : MonoBehaviour
{
   private void OnGUI()   // 주로 디버깅 할떄 사용하는 함수이다. 화면상에  UI를 스크립트로 바로 구현해줄수 있는 코드이다.
   {
       void Show(string text, TextAnchor align)   // input으로는 string으로 받고, 위치를 표현해주기 위해 TextAnchor를 넣고 이를 align이라는 이름으로 받는다.
       {
           var rect = new Rect(x:0,y:100,Screen.width,height:Screen.height*2/100);  // 화면상의 위치로 폭은 스크린의 가로로받고 높이는 스크린 높이의 두배로 하고난 후 100으로 나눈다.
           var style = new GUIStyle  // 스타일을 받은 다음에 보여줄 라벨의 형식을 정해준다.
           {
               alignment = align, fontSize = (int) rect.height, normal = {textColor=Color.red}
               //alignment값은 두번쨰 파라미터로 받은 함수값이 align 값을 넣어준다.
               //폰트사이즈는 rect의 height값, noraml에서는 폰트색깔을 정할 수 있다.
           };
           GUI.Label(rect,text,style); 
           // 라벨을 만들어서 화면에 보여주는 것이다. 영역은 rect 값, 어떤 string을 넣어주고 어떤 스타일을 넣어줄것인지 입력한다.
       }
        Show(text: $"{transform.position}",align: TextAnchor.UpperLeft);
        //string을 가공하기 위해 $값을 입력하고 transform.position은 카메라가 지금 어느 위치에 있는지 표현
        // 그 위치 표현은 왼쪽 위로 표현해준다.
   }
}
