using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    private static PoolManager _instance;
    public static PoolManager Instance
    {
        get
        {
            if(_instance == null)
                Debug.LogError("Pool Manager is NUll.");
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
    }
    [SerializeField]
    private GameObject _bulletContainer;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private List<GameObject> _bulletPool;
    void Start()
    {
       // call this to create pool
       // _bulletPool = GenerateBullets(1);
    }

    void Update()
    {
        
    }
/*    
    // generating the pool isn't needed if the pool is dynamic...
    // remove the loop to Instantiate the first bullet 
    List<GameObject> GenerateBullets(int bulletCount)
    {
        for (int i = 0; i < bulletCount; i++)
        {
            GameObject bullet = Instantiate(_bulletPrefab);
            bullet.transform.parent = _bulletContainer.transform;
            bullet.SetActive(false);
            _bulletPool.Add(bullet);
        }
        return _bulletPool;
    }
*/
    public GameObject RequestBullet()
    {
        foreach (var bullet in _bulletPool)
        {
            if (bullet.activeInHierarchy == false)
            {
                bullet.SetActive(true);
                return bullet;
            }
        }
        GameObject extraBullet = Instantiate(_bulletPrefab);
        extraBullet.transform.parent = _bulletContainer.transform;
        _bulletPool.Add(extraBullet);
        return extraBullet;
    }
}
