
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text textMeshPro;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        double getScore = player.position.z;
        getScore += 58.16;
        textMeshPro.text = getScore.ToString("0");
    }
}
