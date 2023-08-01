#include <stdio.h>
#include <string.h>
#include <stdbool.h>

bool isValid(char * s){
	char stack[10000];
	int flag = -1;
	for(int i = 0; i < strlen(s); ++i) {
		switch (s[i]) {
			case ')':
				if(!(flag > -1 && stack[flag--] == '(')) return false;
				break;
			case ']':
				if(!(flag > -1 && stack[flag--] == '[')) return false;
				break;
			case '}':
				if(!(flag > -1 && stack[flag--] == '{')) return false;
				break;
			default:
				stack[++flag] = s[i];
		}
	}
	return (flag == -1) ? (true) : (false);
}

int main () {
	// char s[] = "()";
	// char s[] = "()[]{}";
	// char s[] = "(]";
	// char s[] = "(";
	char s[] = ")";
	// char s[] = "{[]}";

	if(isValid(s)) {
		printf("True\n");
	} else {
		printf("False\n");
	}

	return 0;
}