using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    readonly float defaultShakeStrength = 75f;
    readonly float defaultShakeSpeed = 0.2f;

    readonly float defaultparticle1Size = 75f;
    readonly float defaultparticle1Mass = 0.5f;
    readonly int defaultparticle1Count = 10;

    readonly float defaultparticle2Size = 15f;
    readonly float defaultparticle2Mass = 0.5f;
    readonly int defaultparticle2Count = 1000;

    readonly float defaultSimulationPrecision = 20f;


    public Slider shakeStrength;
    public Text shakeStrengthValue;
    public Slider shakeSpeed;
    public Text shakeSpeedValue;

    public Slider particle1Size;
    public Text particle1SizeValue;
    public Slider particle1Mass;
    public Text particle1MassValue;
    public Slider particle1Count;
    public Text particle1CountValue;

    public Slider particle2Size;
    public Text particle2SizeValue;
    public Slider particle2Mass;
    public Text particle2MassValue;
    public Slider particle2Count;
    public Text particle2CountValue;

    public Slider simulationPrecision;
    public Text simulationPrecisionValue;

    public Button simulationStartButton;
    public Button simulationStopButton;

    void Start()
    {
        shakeStrength.value = defaultShakeStrength;
        shakeSpeed.value = defaultShakeSpeed;

        particle1Size.value = defaultparticle1Size;
        particle1Mass.value = defaultparticle1Mass;
        particle1Count.value = defaultparticle1Count;

        particle2Size.value = defaultparticle2Size;
        particle2Mass.value = defaultparticle2Mass;
        particle2Count.value = defaultparticle2Count;

        simulationPrecision.value = defaultSimulationPrecision;
    }

    void Update()
    {
        shakeStrengthValue.text = shakeStrength.value.ToString();
        shakeSpeedValue.text = shakeSpeed.value.ToString("F1");

        particle1SizeValue.text = particle1Size.value.ToString();
        particle1MassValue.text = particle1Mass.value.ToString("F1");
        particle1CountValue.text = particle1Count.value.ToString();

        particle2SizeValue.text= particle2Size.value.ToString();
        particle2MassValue.text= particle2Mass.value.ToString("F1");
        particle2CountValue.text = particle2Count.value.ToString();

        simulationPrecisionValue.text = simulationPrecision.value.ToString();
    }

    public void StartButtonOnClick()
    {
        Physics2D.velocityIterations = (int)simulationPrecision.value;
        Physics2D.positionIterations = (int)simulationPrecision.value;

        Shake.ShakeSet(shakeStrength.value, shakeSpeed.value);
        Shake.ShakeStart();
        ParticleManagement.CreateParticle(particle1Size.value, particle1Mass.value, (int)particle1Count.value, particle2Size.value, particle2Mass.value, (int)particle2Count.value);

        shakeStrength.interactable = false;
        shakeSpeed.interactable = false;

        particle1Size.interactable = false;
        particle1Mass.interactable = false;
        particle1Count.interactable = false;

        particle2Size.interactable= false;
        particle2Mass.interactable = false;
        particle2Count.interactable = false;

        simulationPrecision.interactable = false;
        simulationStartButton.interactable = false;
        
        simulationStopButton.interactable = true;
    }

    public void StopButtonOnClick()
    {
        Shake.ShakeStop();
        ParticleManagement.DestroyParticle();

        shakeStrength.interactable = true;
        shakeSpeed.interactable = true;

        particle1Size.interactable = true;
        particle1Mass.interactable = true;
        particle1Count.interactable = true;

        particle2Size.interactable = true;
        particle2Mass.interactable = true;
        particle2Count.interactable = true;

        simulationPrecision.interactable = true;
        simulationStartButton.interactable = true;

        simulationStopButton.interactable = false;
    }
}
