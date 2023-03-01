using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PointController : MonoBehaviour
{
    [SerializeField]
    private int pointRed, pointBlue, pointYellow, point, HP, highestPoint;

    [SerializeField]
    private TextMeshProUGUI textRed, textBlue, textYellow, textPoint, textHP, textkMypoint, textHighestPoint;

    [SerializeField]
    private GameObject panelGameOver;



    int  getHightestPoint()
    {
        highestPoint = PlayerPrefs.GetInt("point", 0);
        return highestPoint;
    }    
    void setHightestPoint(int point)
    {
        PlayerPrefs.SetInt("point", point);
        PlayerPrefs.Save();
    }    

    private void Start()
    {

        SetHP(3);
        SetPointRed(10);
        SetPointBlue(0);
        SetPointYellow(0);
        SetPoint(0);
        panelGameOver.active=(false);

    }



    public void SetPointRed(int i)
    {
       
        pointRed = Mathf.Min(pointRed += i, 30);
        textRed.text = "" + pointRed;
    }
    public void SetPointBlue(int i)
    {
        pointBlue = Mathf.Min(pointBlue += i, 30);
        textBlue.text = "" + pointBlue;
    }
    public void SetPointYellow(int i)
    {
        pointYellow = Mathf.Min(pointYellow += i, 30);
        textYellow.text = "" + pointYellow;
    }
    public void SetPoint(int i)
    {
        point += i;
        textPoint.text = "" + point;
    }

    public void SetHP(int i)
    {
        HP = Mathf.Min(HP += i, 15);
        textHP.text = "" + HP;
        if (HP<=0)
        {
            panelGameOver.active = (true);
            if (point >= getHightestPoint() )
            {             
                setHightestPoint(point);
                Debug.Log("có cao hơn");
            }
            textkMypoint.text = "Điểm của bạn:" + point;
            textHighestPoint.text= "Điểm cao nhất là:" + getHightestPoint();

        }    
    }

    public int GetPointRed()
    {
        return this.pointRed;
    }
    public int GetPointBlue()
    {
        return pointBlue;
    }
    public int GetPointYellow()
    {
        return pointYellow;
    }
    public int GetPoint()
    {
        return point;
    }
    public int GetHP()
    {
        return HP;
    }
}
