#Find Maximum and Minimum
def FindMaxAndMinIf():
    print(" enter 5 Numbers: ")
    num1 = int(input())
    num2 = int(input())
    num3 = int(input())
    num4 = int(input())
    num5 = int(input())

    max, min = num1
    for i in range(6):
        if max < num2:
            max = num2
        else:
            min = num2
        if max < num3:
            max = num3
        if min > num3:
            min = num3
        if max < num4:
            max = num4
        if min > num4:
            min = num4
        if max < num5:
            max = num5
        if min > num5:
            min = num5
    print(f"Maximum is {max}")
    print(f"Minimum is {min}")

def FindMaxAndMinArray():
    entry = []

    print("Enter 5 numbers: ")

    for i in range(5):
        element = int(input())
        entry.append(element)
    max = min = entry[1]

    for j in range(1,6):
        if max < entry[i]:
            max = entry[i]
        if min > entry[i]:
            min = entry[i]
        
    print(f"Maximum is {max}")
    print(f"Minimum is {min}")
#FindMaxAndMinIf()
FindMaxAndMinArray()
        