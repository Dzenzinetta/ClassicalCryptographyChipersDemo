﻿using AffineCiper;
using ChipersUtility;

namespace ChiperAffine
{
    public class Programm
    {
        //public AffineProcessBase AffineEncryption = new AffineDecryptionProcess();

        
        public static void Main()
        {

            Console.WriteLine("Hello World");
            Console.ReadKey();

            //IAffineProcessBase encryptionBase = new

            IAffineProcessBase affineEncryption = Factory.CreateEncryptionProcess();

            affineEncryption.AdditiveKeyObject = Factory.CreateAdditiveKey();
            affineEncryption.MultiplicativeKeyObject = Factory.CreateMultiplicativeKey();
            affineEncryption.AffineProcessObject = Factory.GetAffineEncryptor();
            affineEncryption.Model = Factory.CreateAffineModel();
            affineEncryption.ConsoleInput = UtilityControl.CreateInputFromConsole();

            affineEncryption.AffineMainProcess();


        }

    }


}


