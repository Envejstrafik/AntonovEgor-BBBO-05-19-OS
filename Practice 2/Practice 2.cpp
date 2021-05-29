#define _CRT_SECURE_NO_WARNINGS
#pragma comment(lib, "C:\\CryptoLib\\Win32\\Output\\Debug\\cryptlib.lib")

#include <iostream>
#include <thread>
#include <string>
#include <cctype>
#include <C:\CryptoLib\sha.h>
#include <C:\CryptoLib\hex.h>

using namespace std;

mutex mu;

void tBrootforce(int streamStart, int streamStop);
/*
    Аргумент: указатель на строку с хэшем
    Возвращаемое значение: ...

*/


string hasheOne = "1115DD800FEAACEFDF481F1F9070374A2A81E27880F187396DB67958B207CBAD";
string hasheTwo = "3A7BD3E2360A3D29EEA436FCFB7E44C735D117C42D1C1835420B6B9942DD4F1B";
string hasheThree = "74E1BB62F8DABB8125A58852B63BDF6EAEF667CB56AC7F7CDBA6D7305C50A22F";


int main()
{
    /*thread tAlpha(run, "Alpha");
    thread tBetta(run, "Betta");*/

    setlocale(LC_ALL, "Rus"); // Установка новой локали

    cout << "Будет выполнен брутфорс паролей по следующим хешам:" << endl;
    cout << "1. " << hasheOne << endl;
    cout << "2. " << hasheTwo << endl;
    cout << "3. " << hasheThree << endl;
    cout << endl;
    cout << "Выберите количество потоков (от 2 до 7, рекомендуемое количество - " << thread::hardware_concurrency() << "): ";
    int *choise = new int;
    while (1) {
        cin >> *choise;
        if (*choise > 1 && *choise < 8) break;
    }

    switch(*choise) {
        case 2:
            thread one(tBrootforce, 97, 109);
            thread two(tBrootforce, 110, 122);
            break;
        case 3:
            thread one(tBrootforce, 97, 105);
            thread two(tBrootforce, 106, 114);
            thread three(tBrootforce, 115, 122);
            break;
        case 4:
            thread one(tBrootforce, 97, 102);
            thread two(tBrootforce, 103, 108);
            thread three(tBrootforce, 109, 115);
            thread four(tBrootforce, 116, 122);
            break;
        case 5:
            thread one(tBrootforce, 97, 101);
            thread two(tBrootforce, 102, 106);
            thread three(tBrootforce, 107, 111);
            thread four(tBrootforce, 112, 116);
            thread five(tBrootforce, 117, 122);
            break;
        case 6://ДОДЕЛАТЬ!
            thread one(tBrootforce, 97, 100);
            thread two(tBrootforce, 101, 104);
            thread three(tBrootforce, 105, 111);
            thread four(tBrootforce, 112, 116);
            thread five(tBrootforce, 117, 122);
            thread six(tBrootforce, 117, 122);

    }
    
    
    delete choise;
    
    system("pause");
    system("cls"); // Очистка консоли
 //   tBrootforce();

    return 0;
}

string SHA256(string data)
{
    unsigned char const* pbData = (unsigned char*)data.data();
    unsigned int nDataLen = data.size();
    unsigned char abDigest[CryptoPP::SHA256::DIGESTSIZE];

    CryptoPP::SHA256().CalculateDigest(abDigest, pbData, nDataLen);

    CryptoPP::HexEncoder encoder;
    string output;
    encoder.Attach(new CryptoPP::StringSink(output));
    encoder.Put(abDigest, sizeof(abDigest));
    encoder.MessageEnd();

    return output;
}


void tBrootforce(int streamStart, int streamStop) {
    char* pass = new char[6];
    pass[5] = '\0';
    
    string* newHash = new string;
  
    for (int i = streamStart; i <= streamStop; i++) {
        for (int j = 97+12; j <= 122; j++) {
            for (int k = 97; k <= 122; k++) {
                for (int l = 97; l <= 122; l++) {
                    for (int m = 97; m <= 122; m++) {
                        

                        pass[0] = char(i);
                        pass[1] = char(j);
                        pass[2] = char(k);
                        pass[3] = char(l);
                        pass[4] = char(m);
                        
                        string* strPassword;
                        strPassword = new string(pass);
    
                        *newHash = SHA256(*strPassword);
                        delete strPassword;
                        if (*newHash == hasheOne || *newHash == hasheTwo || *newHash == hasheThree) {
                            mu.lock();
                            cout << "pass: " << pass << endl;
                            cout << "hash: " << *newHash << endl;
                            cout << "pwned!" << endl;
                            mu.unlock();
                            return;
                        }
                        

                    }
                }
            }
        }
    }
    delete newHash;
    delete[] pass;
}

/*void hashToLowerCase(string* str) {

    char* character = new char [64];
    string* strHash;

    strcpy(character, str[0].c_str());
    system("pause");
    
    for (int i = 0; i < 64; i++) {
        character[i] = (char)tolower(character[i]);
    }
    system("pause");
    strHash = new string(character);

    *str = *strHash;

    delete[] character;
    delete strHash;

}*/