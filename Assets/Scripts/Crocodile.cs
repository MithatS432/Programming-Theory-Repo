using UnityEngine;
public class Crocodile : Animal
{
    void Start()
    {
        name = "Crocodile";
        MakeSound();
        Move();

    }

    public override void MakeSound()
    {
        Debug.Log(name + "grrrrrrrrrr diyor");
    }
}
