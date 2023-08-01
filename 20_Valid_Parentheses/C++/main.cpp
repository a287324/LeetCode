#include <iostream>
#include <cstring>
#include <stack>
#include <algorithm>

using namespace std;

class Solution {
public:
    bool isValid(string s) {
        stack<char> stack;
		for(int i = 0; i < s.length(); ++i) {
			if((s[i] == '(') || (s[i] == '[') || s[i] == '{') {
				stack.push(s[i]);
			} else {
				if(stack.empty()) {
					return false;
				}
				if((s[i] == ')') && (stack.top() != '(')) {
					return false;
				}
				if((s[i] == ']') && (stack.top() != '[')) {
					return false;
				}
				if((s[i] == '}') && (stack.top() != '{')) {
					return false;
				}
				stack.pop();
			}
		}
		if(stack.empty()) {
			return true;
		} else {
			return false;
		}
    }
};
int main(void) {
	// string s = "()";
	string s = "()[]{}";
	// string s = "(]";
	// string s = "(";
	Solution obj;
	
	if(obj.isValid(s)) {
		printf("True\n");
	} else {
		printf("False\n");
	}
	return 0;
}