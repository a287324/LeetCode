#include <iostream>
#include <cstring>
#include <vector>
#include <algorithm>

using namespace std;

class Solution {
public:
    bool isAnagram(string s, string t) {
		// check length
		if(s.length() != t.length()) {
			return false;
		}
		// check letter
		int count[26] = {0};
		for(int i = 0; i < s.length(); ++i) {
			count[s[i] - 'a']++;
			count[t[i] - 'a']--;
		}
		for(int i = 0; i < 26; ++i) {
			if(count[i] != 0) {
				return false;
			}
		}
        return true;
    }
};
int main(void) {
	string s = "anagram", t = "nagaram";
	// string s = "rat", t = "car";
	Solution obj;
	
	if(obj.isAnagram(s,t)) {
		printf("True\n");
	} else {
		printf("False\n");
	}
	return 0;
}