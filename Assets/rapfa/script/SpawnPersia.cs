using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPersia : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRange = 0.45f;
    [SerializeField] private GameObject _persia;

    private float _timer;

////////////////////////////
    void Start()
    {
        SpawnPersiaa();
    }
////////////////////////////
    void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnPersiaa();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }
///////////////////////////////

    private void SpawnPersiaa()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject persia = Instantiate(_persia, spawnPos, Quaternion.identity);

        Destroy(persia, 10f);

    }
}
