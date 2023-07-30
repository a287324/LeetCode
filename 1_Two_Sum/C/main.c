#include <stdio.h>
#include <stdlib.h>

// sub-function
int* twoSum(int* nums, int numsSize, int target, int* returnSize){
	*returnSize=2;
	int *ans = (int*)malloc(2*sizeof(int));
	for(int i = 0; i < numsSize; i++) {
		for(int j = i+1; j < numsSize; j++) {
			if((nums[i] + nums[j]) == target) {
				ans[0] = i;
				ans[1] = j;
				return ans;
			}
		}
	}
	return ans;
}

// main function
int main(void) {
	int nums[] = {2, 11, 15, 7};
	int target = 9;
	int returnSize;
	int *res;
	
	// two sum
	res = twoSum(nums, 4, target, &returnSize);
	
	// check
	for(int i = 0; i < returnSize; ++i) {
		printf("res[%d] = %d\n", i, res[i]);
	}
	
	return 0;
}
