using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StateInput : MonoBehaviour
{
    public GameObject inputHeight,inputFuelMass,inputMaxFuelWaste,inputFuelVelocity,inputRocketMass,inputLandingVelocity;
    public float height,fuelMass,maxFuelWaste,fuelVelocity,rocketMass,landingVelocity; 
    // Start is called before the first frame update
    public void storeName()
    {
        if (inputFuelMass.GetComponent<Text>().text != string.Empty)
        {
            fuelMass = float.Parse(inputFuelMass.GetComponent<Text>().text);    
        } 
        else fuelMass = 1000;
        if (inputHeight.GetComponent<Text>().text != string.Empty)
        {
            height = float.Parse(inputHeight.GetComponent<Text>().text);        
        } else height = 100;
        if (inputHeight.GetComponent<Text>().text != string.Empty)
        {
            maxFuelWaste = float.Parse(inputMaxFuelWaste.GetComponent<Text>().text);
        } else maxFuelWaste = 100;
        if (inputFuelVelocity.GetComponent<Text>().text != string.Empty)
        {
            fuelVelocity = float.Parse(inputFuelVelocity.GetComponent<Text>().text);
        } else fuelVelocity = 100;
        if (inputRocketMass.GetComponent<Text>().text != string.Empty)
        {
            rocketMass = float.Parse(inputRocketMass.GetComponent<Text>().text);
        } else rocketMass = 100;
        if (inputLandingVelocity.GetComponent<Text>().text != string.Empty)
        {        
            landingVelocity = float.Parse(inputLandingVelocity.GetComponent<Text>().text);
        } else landingVelocity = 10;
        
        PlayerPrefs.SetFloat("height",height);
        PlayerPrefs.SetFloat("fuelMass",fuelMass);
        PlayerPrefs.SetFloat("maxFuelWaste",maxFuelWaste);
        PlayerPrefs.SetFloat("fuelVelocity",fuelVelocity);
        PlayerPrefs.SetFloat("rocketMass",rocketMass);
        PlayerPrefs.SetFloat("landingVelocity",landingVelocity);

    }
}
