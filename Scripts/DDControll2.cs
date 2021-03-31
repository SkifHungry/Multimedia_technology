using UnityEngine;
using UnityEngine.UI;

public class DDControll2 : MonoBehaviour
{
    void Start() { }

    void Update() { }

    // Получаем объекты dropdown
    public void ValueChanged()
    {
        // Получаем объекты dropdown
        Dropdown dd1 = GameObject.Find("Dropdown1").GetComponent<Dropdown>();
        Dropdown dd2 = GameObject.Find("Dropdown2").GetComponent<Dropdown>();

        // Получаем материалы
        Material[] colors = { Resources.Load<Material>("S1"), Resources.Load<Material>("Plane"), Resources.Load<Material>("S2") };
        GameObject go = GameObject.FindGameObjectWithTag("Ob1");

        // Получаем выбранный объект пользователем
        if (dd1.value == 0)
        {
            go = GameObject.FindGameObjectWithTag("Ob1");
            go.GetComponent<MeshRenderer>().material = colors[dd2.value];
        }
        else if (dd1.value == 1)
        {
            go = GameObject.FindGameObjectWithTag("Ob2");
            go.GetComponent<MeshRenderer>().material = colors[dd2.value];
        }
        else if (dd1.value == 2)
        {
            go = GameObject.FindGameObjectWithTag("Ob3");
            go.GetComponent<MeshRenderer>().material = colors[dd2.value];
        }
    }
}
