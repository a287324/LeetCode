#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

int* productExceptSelf(int* nums, int numsSize, int* returnSize){
	*returnSize = numsSize;
	int *ans = (int*)calloc(numsSize, sizeof(int));	// calloc分配記憶體空間的同時，也會將陣列的數值初始化成0
	// 計算所有乘積
	int product = 1;
	int flag0 = 0;
	int flag0_index = -1;
	for(int i = 0; i < numsSize; ++i) {
		if(nums[i] != 0) {
			product *= nums[i];
		} else {
			flag0++;	// 計算0的個數
			flag0_index = i;	// 紀錄等於0的位置,只需要紀錄一個就好,因為如果有複數個,那結果會全部都是0
			if(flag0 > 1) {
				return ans;
			}
		}
	}
	// 計算結果
	if(flag0 == 1) {
		ans[flag0_index] = product;
		return ans;
	}
	for(int i = 0; i < numsSize; ++i) {
		ans[i] = product / nums[i];
	}
	return ans;
}

int main () {
	int nums[] = {1,2,3,4};
	// int nums[] = {-1,1,0,-3,3};
	int numsSize = sizeof(nums) / sizeof(int);
	int returnSize;

	int *res = productExceptSelf(nums, numsSize, &returnSize);

	for(int i = 0; i < returnSize; ++i) {
		printf("%5d", res[i]);
	}
	return 0;
}