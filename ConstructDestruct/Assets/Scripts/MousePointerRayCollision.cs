using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MousePointerRayCollision : MonoBehaviour
{
    public GameObject InGamePointer;
    public bool IsOn;
    public Vector3 Offset;
    public GameObject spawnable;

    //private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Toggle using g key
        if(Input.GetKeyDown(KeyCode.G))
        {
            IsOn = !IsOn;
        }

        if (IsOn)
        {
            Ray pos = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(pos, out hit))
            {
                if (hit.collider.gameObject != InGamePointer)
                {
                    print(hit.point);
                    InGamePointer.transform.position = hit.point + Offset;
                }
            }

            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(spawnable, InGamePointer.transform.position,Quaternion.identity);
            }
            
            //InGamePointer.transform.position = Camera.main.ScreenToWorldPoint(pos);
        }
    }
}
