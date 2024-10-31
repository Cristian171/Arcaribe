using UnityEngine;

public class ChangeColorOnTouch : MonoBehaviour
{
    private void Update()
    {
        // Detectar el toque en pantalla
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                // Crear un rayo desde la cámara a la posición del toque
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                // Hacer un raycast y comprobar si se ha tocado este objeto
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform == transform)
                    {
                        ChangeColor();
                    }
                }
            }
        }
    }

    private void ChangeColor()
    {
        // Cambiar el color del cubo a un color aleatorio
        Color newColor = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = newColor;

        Debug.Log("¡Cubo tocado y color cambiado!");
    }
}
