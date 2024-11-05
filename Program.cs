//*****************************************************************************
//** 67. Add Binary     leetcode easy                                        **
//*****************************************************************************

char* addBinary(char* a, char* b) {
    int lenA = strlen(a);
    int lenB = strlen(b);
    int maxLen = lenA > lenB ? lenA : lenB;
    char* ans = (char*)malloc(maxLen + 2);
    int carry = 0;
    int i = lenA - 1;
    int j = lenB - 1;
    int k = 0;

    while (i >= 0 || j >= 0 || carry) {
        if (i >= 0)
            carry += a[i--] - '0';
        if (j >= 0)
            carry += b[j--] - '0';

        ans[k++] = (carry % 2) + '0';
        carry /= 2;
    }

    for (int l = 0, r = k - 1; l < r; ++l, --r) {
        char temp = ans[l];
        ans[l] = ans[r];
        ans[r] = temp;
    }

    ans[k] = '\0';
    return ans;
}