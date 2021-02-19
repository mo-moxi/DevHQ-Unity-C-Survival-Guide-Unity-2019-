using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Player_Pool : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletPrefab;

    private GameObject bullet;
    
    public static Action<Vector3> OnFireBullet; 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Damage()
    {
        Vector3 pos = transform.position;
        if (OnFireBullet != null)
            OnFireBullet(pos);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bullet = PoolManager.Instance.RequestBullet();
            bullet.transform.position = transform.position;
        }
    }
}
