using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Mover : MonoBehaviour
{
    #region Inspector vars

    [SerializeField]
    private float Speed = 1.2f;

    #endregion
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        transform.Translate(xValue * Time.deltaTime * Speed, 0, 0);

        float zValue = Input.GetAxis("Vertical");
        transform.Translate(0, 0, zValue * Time.deltaTime * Speed);
    }
}
