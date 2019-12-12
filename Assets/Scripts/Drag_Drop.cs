using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag_Drop : MonoBehaviour,IBeginDragHandler,IEndDragHandler,IDragHandler
{
    //드래그하고 드롭하면 다시 원위치로 돌려보내기 위한 변수
    public static Vector2 defaultposition;
  
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData) //드래그 시작할 때
    {
        defaultposition = this.transform.position;
        //처음 위치로 다시 돌려 보내기 위해서 처음위치의 좌표 저장
    }

    void IDragHandler.OnDrag(PointerEventData eventData) //드래그 중일 때
    {
        Vector2 currentPos = Input.mousePosition;
        this.transform.position = currentPos;
        //드래그 중일 때 현재 위치를 마우스나 터치 지점을 따라가기 위해서
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData) // 드래그 끝났을 때
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 currentPos1 = Input.mousePosition;

        if(445 <= currentPos1.x && currentPos1.x <=630 && 250<=currentPos1.y && currentPos1.y <=465)
        {
            this.transform.position = currentPos1;
        }
        else
        {
            this.transform.position = defaultposition;
        }
        //드래그 끝났을 때 다시 원위치로 돌려 보내기 위해서 
    }

      
    }
    

