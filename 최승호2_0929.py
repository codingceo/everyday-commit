# 6-3 시작값과 종료값을 입력받아 홀수 합계와 갯수 구하기

i, hap = 0, 0
num1, num2 = 0, 0
cnt = 0

num1 = int(input("시작값 : "))
num2 = int(input("종료값 : "))

for i in range(num1, num2,1):
    if (i % 2 ==1):
        hap += i
        cnt += 1

print("%d ~ %d 홀수 합계 : %d, 갯수 : %d " %(num1, num2, hap, cnt))
        
# 6-4 시작값과 종료값을 입력받아 그 사이의 홀수 출력 

i = 0
num1, num2 = 0, 0

num1 = int(input("시작값 : "))
num2 = int(input("종료값 : "))

for i in range(num1, num2, 1):
    if(i % 2 == 1) :
        print("%d" %i, end =" ")
