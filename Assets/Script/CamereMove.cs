using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamereMove : MonoBehaviour
{
    private GameObject Target;


    private Vector3 Offset;

    private void Awake()
    {
        Target = GameObject.Find("Player");
    }

    void Start()
    {
        Offset = new Vector3(0.0f, 12.0f, -10.0f);

        this.transform.position = new Vector3(
            Offset.x + Target.transform.position.x,
            Offset.y + Target.transform.position.y,
            Offset.z + Target.transform.position.z);

        this.transform.rotation = Quaternion.LookRotation(
            (Target.transform.position - this.transform.position).normalized);
    }

    void Update()
    {
        FolloingCamera();
    }

    void FolloingCamera()
    {
        // ** ī�޶� ��ǥ�������� �̵��ϴ� �ð��� ����.
        // ** Vector3.Lerp(������, ������, �ð�)
        Vector3 SmoothFolloingPosition = Vector3.Lerp(
            this.transform.position, Target.transform.position + Offset, Time.deltaTime * 5.0f);

        // ** ������ ���õ� ��ġ�� ����.d
        this.transform.position = SmoothFolloingPosition;
    }
}
