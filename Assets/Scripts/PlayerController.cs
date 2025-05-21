using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField] private int _hp;
    private Inventory _inventory;

    private void Awake() => Init();

    private void OnTriggerEnter(Collider other)
    {
        // 충돌한게 아이템이 맞는지는 당연히 체크해야됩니다.
        _inventory.GetItem(other.GetComponent<ItemObject>().Data);
        other.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _inventory.UseItem(0);
        }
    }

    private void Init()
    {
        _inventory = GetComponent<Inventory>();
    }

    public void Recover(int value)
    {
        _hp += value;
    }
}
