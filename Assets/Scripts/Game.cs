using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    [SerializeField]
    Block block;

    [SerializeField]
    int max = 10;

    [SerializeField]
    TextMeshProUGUI text;

    int point = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(var i = 0; i < max; i++)
        {
            var x = -3.0f + ((i%4) * 2.0f);
            var z = 5.0f - ((i/4) * 1.5f);
            var obj = Block.Instantiate(block, transform);
            obj.transform.position = new Vector3(x, 1, z);

            var type = (int)Random.Range(0, 5);
            obj.SetInit(type, () =>
            {
                point += 10;
                text.text = point.ToString();
                GameObject.Destroy(obj.gameObject);
            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
