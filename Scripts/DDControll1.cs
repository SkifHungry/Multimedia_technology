using UnityEngine;
using UnityEngine.UI;

public class DDControll1 : MonoBehaviour
{
    GameObject gOb;

    void Start() { }

    void Update() { }

    public void ValueChanged()
    {
        // Получаем объекты dropdown
        Dropdown dd1 = GameObject.Find("Dropdown1").GetComponent<Dropdown>();
        Dropdown dd2 = GameObject.Find("Dropdown2").GetComponent<Dropdown>();
        Dropdown dd3 = GameObject.Find("Dropdown3").GetComponent<Dropdown>();
        GameObject go = GameObject.FindGameObjectWithTag("Ob1");

        // Получаем выбранный объект пользователем
        if (dd1.value == 0)
        {
            go = GameObject.FindGameObjectWithTag("Ob1");
        }
        else if (dd1.value == 1)
        {
            go = GameObject.FindGameObjectWithTag("Ob2");
        }
        else if (dd1.value == 2)
        {
            go = GameObject.FindGameObjectWithTag("Ob3");
        }

        // Получение материала объекта
        Renderer rndr = go.GetComponent<Renderer>();

        // Меняем значение в dropdown2 (Цвета)
        if (rndr.material.name.ToString().Split(' ')[0] == "S1")
        {
            GameObject.Find("Dropdown2").GetComponent<Dropdown>().value = 0;
        }
        else if (rndr.material.name.ToString().Split(' ')[0] == "Plane")
        {
            GameObject.Find("Dropdown2").GetComponent<Dropdown>().value = 1;
        }
        else if (rndr.material.name.ToString().Split(' ')[0] == "S2")
        {
            GameObject.Find("Dropdown2").GetComponent<Dropdown>().value = 2;
        }

        // Меняем значение в dropdown3 (Форма объекта)
        if (go.GetComponent<MeshFilter>().sharedMesh.ToString().Split(' ')[0] == "Sphere")
        {
            GameObject.Find("Dropdown3").GetComponent<Dropdown>().value = 0;
        }
        else if (go.GetComponent<MeshFilter>().sharedMesh.ToString().Split(' ')[0] == "Capsule")
        {
            GameObject.Find("Dropdown3").GetComponent<Dropdown>().value = 1;
        }
        else if (go.GetComponent<MeshFilter>().sharedMesh.ToString().Split(' ')[0] == "Cube")
        {
            GameObject.Find("Dropdown3").GetComponent<Dropdown>().value = 2;
        }
    }
}
