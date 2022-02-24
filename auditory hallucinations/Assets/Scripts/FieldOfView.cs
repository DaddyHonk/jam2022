using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class FieldOfView : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    private Mesh mesh;
    public GameObject Player;

    private void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        //transform.position = Player.transform.position;
        
    }

    private void Update()
    {
        float fov = 365;
        Vector3 origin = transform.localPosition;
        int rayCount = 365;
        float angle = 0f;
        float angleIncrease = fov / rayCount;
        float viewDistance = 50f;


        //setup: verticies, uv, triangles
        Vector3[] verticies = new Vector3[rayCount + 1 + 1];
        Vector2[] uv = new Vector2[verticies.Length];
        int[] triangles = new int[rayCount * 3];
        
        verticies[0] = origin;
        
        int vertexIndex = 1;
        int triangleIndax = 0;
        //sicle through all array's and locate thhem on the correct position
        for (int i = 0; i <= rayCount; i++)
        {
            Vector3 vertex; 
            RaycastHit2D raycastHit2D = Physics2D.Raycast(origin, UtilsClass.GetVectorFromAngle(angle), viewDistance, layerMask);
            
            if (raycastHit2D.collider == null)
            {
                vertex = origin + UtilsClass.GetVectorFromAngle(angle) * viewDistance; //no hit
            }
            else
            {
                //hit object
                vertex = raycastHit2D.point;
                Debug.DrawRay(origin, raycastHit2D.point);  
            }
            verticies[vertexIndex] = vertex;

            //generate all the triangles
            if (i > 0)
            {
                triangles[triangleIndax + 0] = 0;
                triangles[triangleIndax + 1] = vertexIndex - 1;
                triangles[triangleIndax + 2] = vertexIndex;
        
                triangleIndax += 3;
        
            }
            //move to next angle for next sicle
            vertexIndex++;
            angle -= angleIncrease;
        }

        mesh.vertices = verticies;
        mesh.uv = uv;
        mesh.triangles = triangles;

    }
}
