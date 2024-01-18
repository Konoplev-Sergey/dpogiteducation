using UnityEngine;

public class OOP : MonoBehaviour
{
    private void Start()
    {

    }

}
/*1. �������� ����������� ����� `Animal` � ���������� ���������� `name` � �������������, ������� ��������� ��� ���������. 
 * �������� ����������� ����� `MakeSound`, ������� ����� ������������� � �������� �������.

2. �������� ����� `Dog`, ������� ��������� �� `Animal`. � ���� ������ �������� ����������� ���������� `dogCount` � �����������,
������� ����������� `dogCount` ��� �������� ������ ������� `Dog`. �������������� ����� `MakeSound` ��� ������ `Dog`.
�������� ����������� ����� `HowManyDogs`, ������� ������� ���������� ��������� �������� `Dog`.

3. �������� ��������� `ISwimming` � ������� `Swim`.

4. �������� ����� `Duck`, ������� ��������� �� `Animal` � ��������� ��������� `ISwimming`.
�������������� ����� `MakeSound` � ���������� ����� `Swim` ��� ������ `Duck`.

5. � ������� ������ ��������� �������� ������� `Dog` � `Duck`, �������� �� ������ `MakeSound` � `Swim` (��� `Duck`),
� ����� ����������� ����� `HowManyDogs` ������ `Dog`.
*/
public abstract class Animal
{
    protected string name;

    public Animal(string name)
    {
    this.name = name;
    }
    public virtual void MakeSound()
    {
        Debug.Log($"{name} makes a sound.");
    }
}
public class Dog : Animal
{
    public static int dogCount = 0;
    public Dog(string name): base(name)
    {
        dogCount++;
    }
    public override void MakeSound()
    {
        Debug.Log($"{name} barks.");
    }
    public static void HowManyDogs()
    {
        Debug.Log($"There are{dogCount} dogs.");
    }
}
public interface ISwimming
{
    void Swim();
}
public class Duck : Animal,ISwimming
{
    public Duck(string name): base(name) { }
    public override void MakeSound() 
    {
        Debug.Log($"{name} quaks.");
    }
    public void Swim()
    {
        Debug.Log($"{name} swims.");
    }
}