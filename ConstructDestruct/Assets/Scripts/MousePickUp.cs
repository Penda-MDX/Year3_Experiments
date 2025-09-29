using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePickUp : MonoBehaviour
{
    public GameObject InGamePointer;
    public Vector3 Offset;
    public bool isDragging; 
    public bool canDrag;
    public GameObject CanDragObject;
    public GameObject draggedObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray pos = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if (Physics.Raycast(pos, out hit))
        {
            if (hit.collider.gameObject != InGamePointer)
            {
                print(hit.point);
                InGamePointer.transform.position = hit.point + Offset;

                if (isDragging)
                {
                    draggedObject.transform.position = hit.point + Offset;
                }

                if(hit.collider.gameObject.tag == "Draggable" && !isDragging)
                {
                    canDrag = true;
                    CanDragObject = hit.collider.gameObject;
                }

            }
        }

        if (Input.GetMouseButtonDown(0) && canDrag)
        {
            //Instantiate(spawnable, InGamePointer.transform.position, Quaternion.identity);
            isDragging = !isDragging;

            if (isDragging)
            {
                draggedObject = CanDragObject;
            }

        }
    }
}
