using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
[RequireComponent(typeof(TextMeshPro))]
public class NumberField : MonoBehaviour {
    private float number;

    public float GetNumber() {
        return this.number;
    }

    public void SetNumber(float newNumber) {
        this.number = newNumber;
        GetComponent<TextMeshPro>().text = newNumber.ToString();
    }

    public void AddNumber(float toAdd) {
        SetNumber(this.number + toAdd);
    }
}
