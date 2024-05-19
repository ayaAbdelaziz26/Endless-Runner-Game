using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class add : MonoBehaviour
{
    public Dropdown dd;
    public InputField If;
    public Text tx;

    public static string playerName;
    public static int playerIndex;

    //static List<string> itms =new List<string>();

    static List<string> itms = list.items;
    public List<int> score = list.score;

    void Start()
    {

        foreach (var itm in itms)
        {
            dd.options.Add(new Dropdown.OptionData() { text = itm });

        }
    }

    public void addPlayer()
    {

        tx.text = If.text;

        dd.options.Add(new Dropdown.OptionData() { text = If.text });

        itms.Add(If.text);
        score.Add(0);



        /* foreach (var itm in itms)
         {
             dd.options.Add(new Dropdown.OptionData() { text = itm });
             //Debug.Log(itm);

         }*/

    }
    public void goToPlay()
    {

        int index = dd.value;

        string selectdName = dd.options[index].text;

        add.playerIndex = index;
        add.playerName = selectdName;


        Application.LoadLevel(1);

    }
}
