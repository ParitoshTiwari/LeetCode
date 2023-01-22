public class Solution {
    
    public int RomanToInt(string s) {
        char[] individual = s.ToCharArray();
        bool check = false;
        int number = 0;
            for(int v=0; v<individual.Length; v++){
                check = false;
                if(v+1 < individual.Length){
                    if((individual[v].ToString() + individual[v+1].ToString()) == "IV"){
                        number = number + 4;
                        v++;
                        check = true;
                    }
                    else if((individual[v].ToString() + individual[v+1].ToString()) == "IX"){
                        number = number + 9;
                        v++;
                        check = true;
                    }
                    else if((individual[v].ToString() + individual[v+1].ToString()) == "XL"){
                        number = number + 40;
                        v++;
                        check = true;
                    }
                    else if((individual[v].ToString() + individual[v+1].ToString()) == "XC"){
                        number = number + 90;
                        v++;
                        check = true;
                    }
                    else if((individual[v].ToString() + individual[v+1].ToString()) == "CD"){
                        number = number + 400;
                        v++;
                        check = true;
                    }
                    else if((individual[v].ToString() + individual[v+1].ToString()) == "CM"){
                        number = number + 900;
                        v++;
                        check = true;
                    }
                    else if(!check){
                        number = number + GetNumberFromCharacter(individual[v]);
                    } 
                }
                else{
                    number = number + GetNumberFromCharacter(individual[v]);
                } 
            }
        
        return number; 
    }

    public static int GetNumberFromCharacter(char s){
        int n = 0;
        switch(s){
            case 'I':
                    n = 1;
                    break;
            case 'V':
                    n = 5;
                    break;
            case 'X':
                    n = 10;
                    break;
            case 'L':
                    n = 50;
                    break;
            case 'C':
                    n = 100;
                    break;
            case 'D':
                    n = 500;
                    break;
            case 'M':
                    n = 1000;
                    break;
        }
        return n;
    }
}
