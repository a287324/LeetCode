#include <iostream>
#include <unordered_map>
#include <vector>

using namespace std;

class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
			unordered_map<int, int> repeat;
			for(int i = 0; i < nums.size(); ++i) {
				if(!repeat.count(nums[i])) {
					repeat[nums[i]] = 0;
				} else {
					return true;
				}
			}
			return false;
    }
};
int main(void) {
	// vector<int> nums = {1,2,3,1};
	// vector<int> nums = {1,2,3,4};
	vector<int> nums = {1,1,1,3,3,4,3,2,4,2};
	Solution Obj;

	if(Obj.containsDuplicate(nums)) {
		printf("true\n");
	} else {
		printf("false\n");
	}
	return 0;
}