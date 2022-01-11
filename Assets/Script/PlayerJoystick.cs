using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerJoystick : MonoBehaviour
{

    public GameObject Car;
    public Transform Player;        // �÷��̾�.
    public Transform Stick;         // ���̽�ƽ.

    private Vector3 StickFirstPos;  // ���̽�ƽ�� ó�� ��ġ.
    private Vector3 JoyVec;         // ���̽�ƽ�� ����(����)
    private float Radius;           // ���̽�ƽ ����� �� ����.
    private bool MoveFlag;          // �÷��̾� ������ ����ġ.

    public GameObject GameClearUI;

    private void Awake()
    {
        GameClearUI = GameObject.Find("GameClear");
        Car = GameObject.Find("Player");
        Player = Car.GetComponent<Transform>();
    }

    void Start()
    {
        
        Radius = GetComponent<RectTransform>().sizeDelta.y * 0.5f;
        StickFirstPos = Stick.transform.position;

        // ĵ���� ũ�⿡���� ������ ����.
        float Can = transform.parent.GetComponent<RectTransform>().localScale.x;
        Radius *= Can;

        MoveFlag = false;
    }

    void Update()
    {
        
        if (MoveFlag)
            Player.transform.Translate(Vector3.forward * Time.deltaTime * 10f);

        if (Singleton.GetInstance.ScoerCount >= 30)
        {
            Invoke("GameClear", 0.3f);
        }
    }

    // �巡��
    public void Drag(BaseEventData _Data)
    {
        MoveFlag = true;
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

        Player.eulerAngles = new Vector3(0, Mathf.Atan2(JoyVec.x, JoyVec.y) * Mathf.Rad2Deg, 0);
    }


    private void GameClear()
    {
        GameClearUI.SetActive(true);
    }

    // �巡�� ��.
    public void DragEnd()
    {
        Stick.position = StickFirstPos; // ��ƽ�� ������ ��ġ��.
        JoyVec = Vector3.zero;          // ������ 0����.
        MoveFlag = false;
    }
}
