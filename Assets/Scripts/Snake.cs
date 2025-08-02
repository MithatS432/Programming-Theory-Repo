using UnityEngine;

public class Snake : Animal
{
    void Start()
    {
        Name = "Snake";
        MakeSound();
        Move();
    }

    public override void MakeSound()
    {
        Debug.Log(Name + " ssssss diyor!");
    }
}
