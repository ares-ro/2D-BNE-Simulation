using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    float defaultShakeStrength = 20f;
    float defaultShakeSpeed = 0.5f;
    float defaultparticle1Size = 50f;
    float defaultparticle1Mass = 1f;
    float defaultparticle2Size = 10f;
    float defaultparticle2Mass = 1f;
    float defaultSimulationPrecision = 20f;


    public Slider shakeStrength;
    public Text shakeStrengthValue;
    public Slider shakeSpeed;
    public Text shakeSpeedValue;

    public Slider particle1Size;
    public Text particle1SizeValue;
    public Slider particle1Mass;
    public Text particle1MassValue;
    public Slider particle2Size;
    public Text particle2SizeValue;
    public Slider particle2Mass;
    public Text particle2MassValue;
    public Slider simulationPrecision;
    public Text simulationPrecisionValue;

    void Start()
    {
        shakeStrength.value = defaultShakeStrength;
        shakeSpeed.value = defaultShakeSpeed;
        particle1Size.value = defaultparticle1Size;
        particle1Mass.value = defaultparticle1Mass;
        particle2Size.value = defaultparticle2Size;
        particle2Mass.value = defaultparticle2Mass;
        simulationPrecision.value = defaultSimulationPrecision;
    }

    void Update()
    {
        shakeStrengthValue.text = shakeStrength.value.ToString();
        shakeSpeedValue.text = shakeSpeed.value.ToString("F1");

        particle1SizeValue.text = particle1Size.value.ToString();
        particle1MassValue.text = particle1Mass.value.ToString();
        particle2SizeValue.text= particle2Size.value.ToString();
        particle2MassValue.text= particle2Mass.value.ToString();
        simulationPrecisionValue.text = simulationPrecision.value.ToString();
    }

    public void StartButtonOnClick()
    {
        Physics2D.velocityIterations = (int)simulationPrecision.value;
        Physics2D.positionIterations = (int)simulationPrecision.value;

        Shake.SetAndRun(shakeStrength.value, shakeSpeed.value, true);
        ParticleManagement.CreateParticle(particle1Size.value, particle1Mass.value, particle2Size.value, particle2Mass.value);
    }

    public void StopButtonOnClick()
    {
        ParticleManagement.DestroyParticle();
        Shake.Stop();
    }
}
