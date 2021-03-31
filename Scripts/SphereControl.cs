using UnityEngine;

public class SphereControl : MonoBehaviour
{
    [SerializeField]
    // Получение параметра Transform выбранного объекта
    Transform center;

    [SerializeField]
    public float speed = 2f; // Скорость перемещения сферы
    float R; // Радиус 
    float angle = 0f; // Угол поворота
    private float x1, z1; // Координаты x и z

    void Start() // Функция запуска
    {
        // Вычисление радиуса
        R = Mathf.Sqrt(Mathf.Pow(transform.position.x - 0, 2) + Mathf.Pow(transform.position.z - 0, 2));
    }

    void FixedUpdate() // Функция обновления кадров
    {
        // Получение координаты следующего щага
        x1 = center.position.x + (R * Mathf.Cos(angle));
        z1 = center.position.z + (R * Mathf.Sin(angle));

        // Задаем координаты текущему объекту
        transform.position = new Vector3(x1, 0.5f, z1);

        // Меняем угол
        angle = angle + Time.deltaTime * speed;

        // Условие обновления угла
        if (angle > 360f)
            angle = 0f;
    }
}
