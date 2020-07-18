
/*
 * @lc app=leetcode.cn id=66 lang=csharp
 *
 * [66] 加一
 */

// @lc code=start
  public int[] PlusOne(int[] digits) {
    var  stack = new Stack<int>();
    bool  isPlusOne = false;
       int length = digits.Length;
    for (int i = 0; i < length; i++)
    {
        if (i == 0) isPlusOne = true;
        if (digits[length -1- i] == 9)
        {
            var value =  isPlusOne ? 0: 9;
            stack.Push(value);
            isPlusOne = value == 0 ? true:false;
            continue;
        }else{
              int value = isPlusOne ? digits[length - 1 - i] + 1 : digits[length - 1 - i];
              stack.Push(value);
              isPlusOne = false;
              continue;
        }
    }
    if (isPlusOne)  stack.Push(1);
    var arr = new int[stack.Count];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = stack.Pop();
           return arr;
    }
}
// @lc code=end

