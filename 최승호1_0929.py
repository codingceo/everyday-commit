# 6-1 사용자가 입력한 값까지의 홀수 합계 구하기

i, hap = 0, 0
num = 0

num = int(input(" 값 : "))

for i in range(1, num, 2):
    hap += i


	 
print("1 ~ %d 합계 : %d" % (num, hap))


# 6-2 사용자가 입력한 값까지의 홀수 합계와 갯수 구하기

i, hap = 0, 0
num = 0
cnt = 0

num = int(input("값 : "))
for i in range(1, num, 2):
    hap +=i
    cnt +=1
print("1 ~ %d 합계 : %d, 갯수 : %d" %(num, hap, cnt))
