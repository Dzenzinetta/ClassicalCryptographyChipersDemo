using ChipersUtility;
using System.Collections.Generic;

namespace ChiperVerticalShift
{
    public class VerticalShiftCiperMenu : ConsoleMenuBase, IConsoleMenuBase
    {
        public override string ProgramTitle { get; } = "Vertical Shift";

        public override List<string> Options { get; set; }

        public override void FillMenuList()
        {
            Options = new List<string>();
            Options.Add("Encryption algorithm");
            Options.Add("Decryption algorithm");
            Options.Add("Go Back");
        }

        public override void MenuSelector()
        {
            Utility.ResetCursorVisible();

            //switch (SelectedOption)
            //{
            //    case 0:
            //        {
            //            _starter = AffineCiperFactory.CreateEnctyptorStarter();
            //            _starter.StartAffineCiperProgramm();
            //            break;
            //        }
            //    case 1:
            //        {
            //            _starter = AffineCiperFactory.CreateDectyptorStarter();
            //            _starter.StartAffineCiperProgramm();
            //            break;
            //        }
            //}
        }
    }
}
