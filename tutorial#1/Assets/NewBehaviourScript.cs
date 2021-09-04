using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string title = "전설의";
    string playerName = "복실이";
    int level = 5;
    float strength = 15.5f;
    int exp = 1500;
    int health = 30;
    int mana = 25;
    bool isFullLevel = false;

    // Start is called before the first frame update
    void Start()
    {
        // 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };

        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        List<string> items = new List<string>(); // Generic
        items.Add("생명물약30");
        items.Add("마나물약30");
        items.Add("필요없는 물약");
        items.RemoveAt(2); // Array와 다르게 List는 삭제 가능 -> 인덱스 에러 주의

        // 연산자
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        int nextExp = 300 - (exp % 300); // 다음 레벨까지 남은 경험치 (나머지 연산자 사용)

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        //Debug.Log("복실이 .. 만렙인가 .. ? " + isFullLevel);

        bool isEndTutorial = level > 10;
        //Debug.Log("복실이 이제 가는거야 .. ? " + isEndTutorial);

        int mana = 25;
        bool isBadCondition = health <= 50 && mana <= 20;
        string condition = isBadCondition ? "나쁨" : "좋음";

        if (condition == "나쁨") {
            //Debug.Log("복실이 지금 혐생이니까 nct 내놔");
        } else {
            //Debug.Log("복실이 지금 말짱함 ^_^");
        }

        if (isBadCondition && items[0] == "생명물약30") {
            items.RemoveAt(0);
            health += 30;
            //Debug.Log("생명포션 사용함 .");
        } else if (isBadCondition && items[0] == "마나물약30") {
            items.RemoveAt(0);
            mana += 30;
            //Debug.Log("마나포션 사용했음 .");
        }

        string monsterAlarm;
        switch (monsters[1]) {
            case "슬라임":
            case "사막뱀":
                monsterAlarm = "! 소형 몬스터 출현 !";
                break;
            case "악ㅁ":
                monsterAlarm = "! 중현 몬스터 출현 !";
                break;
            case "골룸":
                monsterAlarm = "! 대형 몬스터 출현 !";
                break;
            default:
                break;
        }

        while (health > 0)
        {
            health--;
            if (health > 0 )
            {
                //Debug.Log("독 데미지 입었음 .. " + health);
            } else
            {
                //Debug.Log("죽음 ..");
            }

            if (health == 10)
            {
                //Debug.Log("해독제 먹어!!!");
                break;
            }
        }

        for (int count = 0; count < 10; count++)
        {
            health++;
            //Debug.Log("--치료중--" + health);
        }


        // foreach : for의 그룹형 변수 탐색 특화
        foreach (string monster in monsters)
        {
            //Debug.Log("여기 있는 몬스터 : " + monster);
        }

        // 함수 이용
        Heal();

        for (int index = 0; index < monsters.Length; index++)
        {
            //Debug.Log("용사는" + monsters[index] + "에게"
            //    + Battle(monsterLevel[index]));
        }

        // 클래스 -> 하나의 사물(오브젝트)와 대응하는 로직
        Player player = new Player(); // instance 생성 (인스턴스화: 클래스를 변수로 만들기)
        player.id = 0;
        player.name = "보리";
        player.title = "귀여운";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은" + player.level + "입니다");

        Debug.Log(player.move());
    }

    // 함수 생성
    void Heal()
    {
        health += 10;
        //Debug.Log("힐을 받았음. " + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "이겼습니다.";
        else
            result = "졌습니다.";
        return result;
    }

}
