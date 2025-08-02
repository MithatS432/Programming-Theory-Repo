using UnityEngine;
public class Lion : Animal
{
    void Start()
    {
        Name = "Lion";
        MakeSound();
        Move();
    }

    public override void MakeSound()
    {
        Debug.Log(Name + " ROAAAR diyor!");
    }
}
