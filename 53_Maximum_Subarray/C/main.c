#include <stdio.h>
#include <stdbool.h>

int maxSubArray(int* nums, int numsSize){
	int curr = -10e5;
	int max = -10e5;
	int reg;
	for(int i = 0; i < numsSize; ++i) {
		reg = curr + nums[i];
		curr = (reg < nums[i]) ? (nums[i]) : (reg);
		if(max < curr) {
			max = curr;
		}
	}
	return max;
}

int main () {
	int nums[] = {-2,1,-3,4,-1,2,1,-5,4};
	// int nums[] = {1};
	// int nums[] = {5,4,-1,7,8};
	int numsSize = sizeof(nums) / sizeof(int);
	printf("%d\n", maxSubArray(nums, numsSize));

	return 0;
}