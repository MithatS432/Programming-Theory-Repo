using UnityEngine;

public class Bird : Animal
{
    void Start()
    {
        Name = "Bird";
        MakeSound();
        Move();
    }

    public override void MakeSound()
    {
        Debug.Log(Name + " cik cik diyor!");
    }
}
