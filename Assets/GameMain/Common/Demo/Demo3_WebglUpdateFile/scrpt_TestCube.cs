using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt_TestCube : MonoBehaviour
{
    private Material m_Material;
    // Start is called before the first frame update
    void Start()
    {
        m_Material = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
        m_Material.color = RandomColor();
    }
    public Color RandomColor()
    {
        float r = Random.Range(0f,1f);
        float g = Random.Range(0f,1f);
        float b = Random.Range(0f,1f);
        Color color = new Color(r,g,b);
        return color;
    }
}