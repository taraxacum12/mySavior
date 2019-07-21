using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class changeInstructions : MonoBehaviour {


    public Text txt;
    public int time = 8;
    private string text;
    private int cnt = 0;

	void Start () {



        Invoke("func", (float)time);

    }

    // 2 7 5 3  1 100

     public void func()
    {
        switch (cnt)
        {
            case 0: { txt.text = "подойдите к машине, откройте капот"; time = 4; } break;
            case 1: { txt.text = "откройте капот"; time = 2; } break;
            case 2: { txt.text = "используте песок, чтобы потушить пожар"; time = 7; } break;
            case 3: { txt.text = "проверьте состояние водителя"; time = 6; } break;
            case 4: { txt.text = "откроте багажник"; time = 6; } break;
            case 5: { txt.text = "возьмите аптечку"; time = 3; } break;
            case 6: { txt.text = "окажите человеку первую помощь"; time = 5; } break;
            case 7: { txt.text = "вы спасли чью-то жизнь!"; time = 100; } break;
            default:
                break;
        }

        cnt++;
        Invoke("func", time);
    }
}
