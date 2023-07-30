#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

// sub-function (ps: 此方法無法通過leetcode的測資,因為超過時間限制,他的時間複雜度是O(n^2))
int containsDuplicate(int* nums, int numsSize){
	for(int i = 0; i < numsSize; ++i) {
		for(int j = i+1; j < numsSize; ++j) {
			if(nums[i] == nums[j]) {
				return 1;
			}
		}
	}
	return 0;
}

// main function
int main(void) {
	// int nums[] = {1,2,3,1};
	int nums[] = {1,2,3,4};
	// int nums[] = {1,1,1,3,3,4,3,2,4,2};
	int numsSize = sizeof(nums) / sizeof(int);

	if(containsDuplicate(nums, numsSize)) {
		printf("True\n");
	} else {
		printf("False\n");
	}
	return 0;
}
