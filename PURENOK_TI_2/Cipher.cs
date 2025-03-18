using System.Collections;

namespace PURENOK_TI_2;

public class Cipher
{
  
    public BitArray LfsrRegister { get; private set; }

    public BitArray GeneratedKey { get; private set; }

    public BitArray PlainText { get; set; }

    public BitArray CipherBit { get; private set; }

    
    public void InitializeLfsrRegister(string initialRegisterState)
    {
        LfsrRegister = new BitArray(initialRegisterState.Length);
        for (int i = 0; i < initialRegisterState.Length; i++)
            LfsrRegister[i] = initialRegisterState[i] == '1';
    }

    public void GenerateKey(int keyLength)
    {
        GeneratedKey = new BitArray(keyLength);
        for (int i = 0; i < keyLength; i++)
        {
           
            GeneratedKey[i] = LfsrRegister[0];

        
            int registerLength = LfsrRegister.Length;
            bool newBit = LfsrRegister[registerLength - 36] ^ LfsrRegister[registerLength - 11];

            
            for (int j = 0; j < LfsrRegister.Length - 1; j++)
            {
                LfsrRegister[j] = LfsrRegister[j + 1];
            }

            LfsrRegister[LfsrRegister.Length - 1] = newBit;
        }
    }

    public void CipherFunc() => CipherBit = GeneratedKey.Xor(PlainText);
}