#Calculate sum of the array
def SumOfTheArray():
    array = [5]
    sum = 0
    print("please enter 5 numbers:")
    for i in range(1,6):
        element = int(input())
        array.append(element)
        sum = sum + array[i]
    print(f"Sum of the array is : {sum}") 
SumOfTheArray()