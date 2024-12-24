using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public Slider shakeStrength;
    public Text shakeStrengthValue;
    public Slider shakeSpeed;
    public Text shakeSpeedValue;

    public Slider particle1Size;
    public Text particle1SizeValue;
    public Slider particle1Density;
    public Text particle1DensityValue;
    public Slider particle2Size;
    public Text particle2SizeValue;
    public Slider particle2Density;
    public Text particle2DensityValue;
    public Slider simulationPrecision;
    public Text simulationPrecisionValue;

    void Start()
    {
        
    }

    void Update()
    {
        shakeStrengthValue.text = shakeStrength.value.ToString();
        shakeSpeedValue.text = shakeSpeed.value.ToString();

        particle1SizeValue.text = particle1Size.value.ToString();
        particle1DensityValue.text = particle1Density.value.ToString();
        particle2SizeValue.text= particle2Size.value.ToString();
        particle2DensityValue.text= particle2Density.value.ToString();
        simulationPrecisionValue.text = simulationPrecision.value.ToString();
    }

    public void StartButtonOnClick()
    {
        Physics2D.velocityIterations = (int)simulationPrecision.value;
        Physics2D.positionIterations = (int)simulationPrecision.value;
        Shake.SetAndRun(shakeStrength.value, shakeSpeed.value, true);
    }

    public void StopButtonOnClick()
    {

    }
}
