using UnityEngine;

//列舉
public enum Season
{
    Spring, Summer, Fall, Winter
}

public class Class5 : MonoBehaviour
{
    public GameObject Wall;
    public int cc = (int)90.5f;
    private short[] scores = { 10,50,20,1,5,9,8,6,7};

    public Season season = Season.Fall;

    public string prop;
    void Start()
    {

        //巢狀迴圈初始值不可一樣
        for (int j = 0; j <= 10; j++)
        {
            for (int i = 0; i <= 3; i++)
            {
                //實例化物件
                //多載 (物件，座標，角度)
                //Quaternion 四元(x, y, z, w)
                //Quaternion.identity 零角度
                Instantiate(Wall, new Vector3(i * 1.5f, j * 1.5f, 0), Quaternion.identity);
            }
        }
        
        for(int i= 1; i <= 9; i++)
        {
            for(int j = 1; j<=9; j++)
            {
                Debug.Log("<color=#a52a2aff><b><i>" + i+" x "+j + " = " + i*j + "</i></b></color>");
            }
        }
        //使用FOR
        for(int i = 0; i< scores.Length; i++)
        {
            Debug.Log("FOR迴圈分數" + scores[i]);
        }

        //使用foreach
        foreach(var s in scores)
        {
            Debug.Log("Foreach迴圈分數" + s);
        }
        
        //使用goto
        for (int i = 0; i < scores.Length; i++)
        {
            if (i == 5) goto Talk;
            Debug.Log("goto迴圈分數" + scores[i]);
        }


    //標記
    Talk:
        Debug.Log("我在標記內");
    }

    void Update()
    {
        //Swich
        switch(prop)
        {
            case "紅水":
                print("回復HP+10");
                break;
            case "藍水":
                print("回復MP+5");
                break;
            default:
                print("這不能吃");
                break;
        }

        switch(season)
        {
            case Season.Fall:
                Debug.Log("AA");
                break;
            case Season.Spring:
                Debug.Log("BB");
                break;
            case Season.Summer:
                Debug.Log("CC");
                break;
            case Season.Winter:
                Debug.Log("DD");
                break;
        }
    }
}
