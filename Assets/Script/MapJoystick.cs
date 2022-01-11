using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MapJoystick : MonoBehaviour
{
    public Transform MapCamera;        // ��ī�޶�
    public Transform Stick;         // ���̽�ƽ.

    private Vector3 StickFirstPos;  // ���̽�ƽ�� ó�� ��ġ.
    private Vector3 JoyVec;         // ���̽�ƽ�� ����(����)
    private float Radius;           // ���̽�ƽ ����� �� ����.

    private bool DragCheck;

    private Camera pCamera;
    private Camera mCamera;

    private void Awake()
    {
        pCamera = GameObject.Find("PlayerCamera").GetComponent<Camera>();
        mCamera = GameObject.Find("MapCamera").GetComponent<Camera>();
    }

    void Start()
    {
        pCamera.enabled = true;
        mCamera.enabled = false;

        DragCheck = false;
        Radius = GetComponent<RectTransform>().sizeDelta.y * 0.5f;
        StickFirstPos = Stick.transform.position;

        // ĵ���� ũ�⿡���� ������ ����.
        float Can = transform.parent.GetComponent<RectTransform>().localScale.x;
        Radius *= Can;

    }
    private void Update()
    {
        CamCheck();
    }

    // �巡��
    public void Drag(BaseEventData _Data)
    {
        DragCheck = true;
        //MoveFlag = true;
        PointerEventData Data = _Data as PointerEventData;
        Vector3 Pos = Data.position;

        // ���̽�ƽ�� �̵���ų ������ ����.(������,����,��,�Ʒ�)
        JoyVec = (Pos - StickFirstPos).normalized;

        // ���̽�ƽ�� ó�� ��ġ�� ���� ���� ��ġ�ϰ��ִ� ��ġ�� �Ÿ��� ���Ѵ�.
        float Dis = Vector3.Distance(Pos, StickFirstPos);

        // �Ÿ��� ���������� ������ ���̽�ƽ�� ���� ��ġ�ϰ� �ִ� ������ �̵�.
        if (Dis < Radius)
            Stick.position = StickFirstPos + JoyVec * Dis;
        // �Ÿ��� ���������� Ŀ���� ���̽�ƽ�� �������� ũ�⸸ŭ�� �̵�.
        else
            Stick.position = StickFirstPos + JoyVec * Radius;

        MapCamera.eulerAngles = new Vector3(55, Mathf.Atan2(JoyVec.x, JoyVec.y) * Mathf.Rad2Deg, 0);
    }

    // �巡�� ��.
    public void DragEnd()
    {
        Stick.position = StickFirstPos; // ��ƽ�� ������ ��ġ��.
        JoyVec = Vector3.zero;          // ������ 0����.
        DragCheck = false;
    }
    
    public void CamCheck()
    {
        if (DragCheck)
        {
            pCamera.enabled = false;
            mCamera.enabled = true;
        }
        else
        {
            pCamera.enabled = true;
            mCamera.enabled = false;
        }
    }
}