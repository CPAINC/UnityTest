using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    [SerializeField] private Text speedCube;
    [SerializeField] private Text distanceCube;
    [SerializeField] private Text timeCreateNewCube;

    public void UpdateInformationLastCube(float distance, float speed, float timerSpawn) // Update information about the current cube in the information panel
    {
        speedCube.text = $"�������� ����: {speed}";
        distanceCube.text = $"��������� ����: {distance}";
        timeCreateNewCube.text = $"�������� ������ ����: {timerSpawn}";
    }
}
