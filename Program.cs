Console.Clear();
Random r = new Random();

int employeeNumbers = 1000;
string [] conss = new string [] {"b","c","d","f","g","h","j","k","l","m","n","p","q","r","s","t","v","w","x", "y","z"};
string [] vowel = new string []{"a", "e", "i", "o", "u"};
string [] names = new string [1000];
double [] wage = new double [1000];
for(int x=0;x<employeeNumbers;x++) {
bool validName = false;
string tempName = "";
while (!validName) {

int ConJ = r.Next(0,20);
int vowO = r.Next(0,5);
int ConH = r.Next(0,20);
int ConN = r.Next(0,20);
int ConS = r.Next(0,20);
string J = conss[ConJ];
string O = vowel[vowO];
string h = conss[ConH];
string n = conss[ConN];
string s = conss[ConS];

int D = r.Next(0,20);
int O2 = r.Next(0,5);
int E = r.Next(0,20);
string middleNames = conss[D]+vowel[O2]+conss[E];

int S = r.Next(0,20);
int M = r.Next(0,5);
int i= r.Next(0,5);
int T = r.Next(0,20);
int H = r.Next(0,20);
int y = r.Next(0,20);
string lastNames = conss[S]+vowel[M]+vowel[i]+conss[T]+conss[H]+conss[y];

tempName = J + O + h + n + s + " " + middleNames + " " + lastNames;
//Console.WriteLine($"temp name is {tempName}");
//confriming name is unique
validName = true;
for (int z = 0; z < names.Length; z++ ) {
    if (String.Equals(names[i], tempName)) {
        validName = false;
    }

}
//Console.WriteLine($"new name is {tempName}");
} 
names[x]=tempName;

int salery =r.Next(700, 900);
double actualSalary = salery/100.00;
wage[x]= actualSalary;
//Console.WriteLine($"{x+1}: {names[x]} salary: ${wage[x]} yearly: ${wage[x]*2080}");
}
for(int i =0; i < employeeNumbers; i++) {
    Console.WriteLine($"{i+1}: {names[i]} salary: ${wage[i]:0.00} yearly: ${wage[i]*2080:0.00}");
}
