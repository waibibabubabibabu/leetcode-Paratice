using System.Text;
public class Solution21{
    public string Multiply(string num1, string num2) {
        if ("0".Equals(num1) || "0".Equals(num2)) {
            return "0";
        }
        string product = "0";
        int m = num1.Length, n = num2.Length;
        for (int i = n - 1; i >= 0; i--) {
            StringBuilder sb = new StringBuilder();
            int multiplicator = num2[i] - '0';
            for (int j = n - 1; j > i; j--) {
                sb.Append("0");
            }
            for (int j = m - 1, carry = 0; j >= 0 || carry != 0; j--) {
                int multiplicand = j >= 0 ? num1[j] - '0' : 0;
                int val = multiplicand * multiplicator + carry;
                sb.Append(val % 10);
                carry = val / 10;
            }
            product = AddStrings(product, sb.ToString());
        }
        StringBuilder sb2 = new StringBuilder();
        for (int i = product.Length - 1; i >= 0; i--) {
            sb2.Append(product[i]);
        }
        return sb2.ToString();
    }

    public string AddStrings(string num1, string num2) {
        StringBuilder sb = new StringBuilder();
        int m = num1.Length, n = num2.Length;
        int index1 = 0, index2 = 0;
        int carry = 0;
        while (index1 < m || index2 < n || carry != 0) {
            int digit1 = index1 < m ? num1[index1] - '0' : 0;
            int digit2 = index2 < n ? num2[index2] - '0' : 0;
            int sum = digit1 + digit2 + carry;
            sb.Append(sum % 10);
            carry = sum / 10;
            index1++;
            index2++;
        }
        return sb.ToString();
    }
}