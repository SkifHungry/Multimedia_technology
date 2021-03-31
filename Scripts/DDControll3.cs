using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class DDControll3 : MonoBehaviour
{
    public GameObject ob1;
    public GameObject ob2;
    public GameObject ob3;

    public GameObject obj;

    void Start() { }

    void Update()
    {

    }

    // Получаем объекты dropdown
    public void ValueChanged()
    {
        // myPrefabs mp = new myPrefabs();

        Mesh sph = Resources.Load<Mesh>("Sphere");
        // Получаем объекты dropdown
        Dropdown dd1 = GameObject.Find("Dropdown1").GetComponent<Dropdown>();
        Dropdown dd2 = GameObject.Find("Dropdown2").GetComponent<Dropdown>();
        Dropdown dd3 = GameObject.Find("Dropdown3").GetComponent<Dropdown>();
        // Получаем материалы
        Material[] colors = { Resources.Load<Material>("S1"), Resources.Load<Material>("Plane"), Resources.Load<Material>("S2") };
        GameObject go;

        // Меняем форму объекта
        if (dd1.value == 0)
        {
            go = GameObject.FindGameObjectWithTag("Ob1");

            if (dd3.value == 0)
            {

                Destroy(go);
                go = Instantiate(ob1, new Vector3(-2.82f, 0.5f, 0f), transform.rotation);
                go.GetComponent<MeshRenderer>().material = colors[dd2.value];
                go.tag = "Ob1";
            }
            else if (dd3.value == 1)
            {
                Destroy(go);
                go = Instantiate(ob2, new Vector3(-2.82f, 0.5f, 0f), transform.rotation);
                go.GetComponent<MeshRenderer>().material = colors[dd2.value];
                go.tag = "Ob1";
            }
            else if (dd3.value == 2)
            {
                Destroy(go);
                go = Instantiate(ob3, new Vector3(-2.82f, 0.5f, 0f), transform.rotation);
                go.GetComponent<MeshRenderer>().material = colors[dd2.value];
                go.tag = "Ob1";
            }

        }
        if (dd1.value == 1)
        {
            go = GameObject.FindGameObjectWithTag("Ob2");

            if (dd3.value == 0)
            {
                Destroy(go);
                go = Instantiate(ob1, new Vector3(0.213643f, 0.5f, 0f), transform.rotation);
                go.GetComponent<MeshRenderer>().material = colors[dd2.value];
                go.tag = "Ob2";
            }
            else if (dd3.value == 1)
            {
                Destroy(go);
                go = Instantiate(ob2, new Vector3(0.213643f, 0.5f, 0f), transform.rotation);
                go.GetComponent<MeshRenderer>().material = colors[dd2.value];
                go.tag = "Ob2";
            }
            else if (dd3.value == 2)
            {
                Destroy(go);
                go = Instantiate(ob3, new Vector3(0.213643f, 0.5f, 0f), transform.rotation);
                go.GetComponent<MeshRenderer>().material = colors[dd2.value];
                go.tag = "Ob2";
            }
        }
        if (dd1.value == 2)
        {
            go = GameObject.FindGameObjectWithTag("Ob3");

            if (dd3.value == 0)
            {
                Destroy(go);
                go = Instantiate(ob1, new Vector3(2.8f, 0.5f, 0f), transform.rotation);
                go.GetComponent<MeshRenderer>().material = colors[dd2.value];
                go.tag = "Ob3";
            }
            else if (dd3.value == 1)
            {
                Destroy(go);
                go = Instantiate(ob2, new Vector3(2.8f, 0.5f, 0f), transform.rotation);
                go.GetComponent<MeshRenderer>().material = colors[dd2.value];
                go.tag = "Ob3";
            }
            else if (dd3.value == 2)
            {
                Destroy(go);
                go = Instantiate(ob3, new Vector3(2.8f, 0.5f, 0f), transform.rotation);
                go.GetComponent<MeshRenderer>().material = colors[dd2.value];
                go.tag = "Ob3";
            }
        }
    }
}
