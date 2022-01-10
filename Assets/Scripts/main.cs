using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class main : MonoBehaviour
{
    public float g = 1.62f;
    public float height;
    public float fMass, sFlMass; // fuel Mass - масса топлива, start Fuel Mass - начальная масса топлива
    private float fall; // скорость падения под действием силы тяжести
    public float fWaste; // fuel Waste расход топлива
    public float maxFlWaste; // max Fuel Waste маскимальный расход топлива
    private float fV; // скорость выброса топлива
    private float rMass; // rocket Mass масса ракеты (без топлива)
    public float rV; //rocket Velocity скорость ракеты
    public float landingVelocity; // посадочная скорость
    public TextOutput h, v, m, p, d;
    public float delta;
    public GameObject Success, Failure;
    public ParticleSystem exhaust;


    void Start()
    {
        height = PlayerPrefs.GetFloat("height");
        rMass = PlayerPrefs.GetFloat("rocketMass");
        fMass = PlayerPrefs.GetFloat("fuelMass");
        maxFlWaste = PlayerPrefs.GetFloat("maxFuelWaste");
        fV = PlayerPrefs.GetFloat("fuelVelocity");
        landingVelocity = PlayerPrefs.GetFloat("landingVelocity");
        sFlMass = fMass;
    }

    // Update is called once per frame
    
    public float Micher_accel()
    {
        // Ускорение по формуле Мещерского.
        return fV * fWaste / ((rMass + fMass) - fWaste);
    }
    public float Tsial(float dt)
    {
        // Циолковский.
        return fV * Mathf.Log((rMass + sFlMass) / ((rMass + fMass))) - g * dt;
    }
    public float Accel()
    {
        // Общее ускорение.
        return -g + Micher_accel();
    }
    public float Velocity(float dt)
    {
        // Общая скорость.
        return fall + rV;
    }
    public float Height(float dt)
    {
        return height + Velocity(dt) * dt + ((Accel() * dt * dt) / 2);
    }
    public float Fall(float dt)
    {
        return g * dt;
    }
    void Update()
    {   
        float dt = Time.deltaTime;
        if (transform.position.y > 0)
        {
            rV += Micher_accel() * dt;

            fall -= Fall(dt);

            height += Velocity(dt) * dt + (0.5f * Accel() * dt * dt);

            transform.position = new Vector3(0, height, 0);
            if (fMass > 0)
            {
                fMass -= fWaste * dt;
            }
            else fWaste = 0;
            
            // delta = Tsial(dt) / rV - 1; // Погрешность

            h.textout((int)height);
            v.textout((int)Velocity(dt));
            m.textout((int)fMass);
            p.textout((int)((fWaste / maxFlWaste) * 100));
            
            // d.textout((float)delta);
        }

        if(transform.position.y <= 0 && Velocity(dt) >= -landingVelocity)
        {

            Success.SetActive(true);

            exhaust.gameObject.SetActive(false);

        }

        if(transform.position.y <= 0 && Velocity(dt) < -landingVelocity)
        {
            Failure.SetActive(true);

            exhaust.gameObject.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            if(fWaste < maxFlWaste)

            fWaste += maxFlWaste * 0.05f;

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(fWaste > 0.1)

            fWaste -= maxFlWaste * 0.05f;

        }

        if (fWaste > 0)
        {

            exhaust.gameObject.SetActive(true);

        }
        else
        {

            exhaust.gameObject.SetActive(false);

        }

        if (Input.GetKey(KeyCode.R))
        {      

            SceneManager.LoadScene(1);

        }

        if (Input.GetKey(KeyCode.M))
        {      

            SceneManager.LoadScene(0);
            
        }
    }
}
