// 001_bmi.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.


#include <stdio.h>

int main()
{
    float h, w; //h : 키 , w : 몸무게
    printf("키 입력(cm) : m로 입력하지 마세요. ");
    scanf_s("%f", &h);

    printf("체중 입력(kg) : ");
    scanf_s("%f", &w);
    
    float m = h / 100; // m = 변환
    float a = w / (h * h); // a : BMI를 나타내는 변수

    printf("따라서 BMI는 %.2f 입니다.", a);
}

//도구 - 설정 - 글꼴 - Consolas