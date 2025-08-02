using UnityEngine;

public class ZooManager : MonoBehaviour
{
    public Animal[] animals;

    void Start()
    {
        animals = FindObjectsOfType<Animal>();

        foreach (Animal a in animals)
        {
            a.MakeSound();
            a.Move();
        }
    }
}
