using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform firePoint;

    Camera mainCamera;


    void Awake()
    {
        mainCamera = Camera.main;
    }

    public void OnFire(InputValue value)
    {
        if (!value.isPressed) return;
        Shoot();
    }

    private void Shoot ()
    {

        Vector2 mouseScreenPos = Mouse.current.position.ReadValue();
        Vector3 mouseWorldPos = mainCamera.ScreenToWorldPoint(mouseScreenPos);
        mouseWorldPos.z = 0f;

        Vector2 direction = mouseWorldPos - firePoint.position;

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        bullet.GetComponent<Bullet>().SetDirection(direction);
    }

}
