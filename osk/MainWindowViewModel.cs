using osk.Core;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using osk.KeyboardLayout;
using System.Diagnostics;
using UIAutomationClient;
using System.Threading;
using System.Net;
using System.IO;
using System.Text;

namespace osk
{
    public class MainWindowViewModel : ObservableObject
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        public static void PressKey(Keys key, bool up)
        {
            const int KEYEVENTF_EXTENDEDKEY = 0x1;
            const int KEYEVENTF_KEYUP = 0x2;
            if (up)
            {
                keybd_event((byte)key, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
            }
            {
                keybd_event((byte)key, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            }
        }


        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        #region BACKGROUND | BRUSH COLOR
        private string pressDOGColor;
        public string PressDOGColor
        {
            get { return pressDOGColor; }
            set { pressDOGColor = value; OnPropertyChanged(); }
        }
        private string pressÖBGColor;
        public string PressÖBGColor
        {
            get { return pressÖBGColor; }
            set { pressÖBGColor = value; OnPropertyChanged(); }
        }
        private string pressÖBBColor;
        public string PressÖBBColor
        {
            get { return pressÖBBColor; }
            set { pressÖBBColor = value; OnPropertyChanged(); }
        }

        private string pressÄBGColor;
        public string PressÄBGColor
        {
            get { return pressÄBGColor; }
            set { pressÄBGColor = value; OnPropertyChanged(); }
        }
        private string pressÄBBColor;
        public string PressÄBBColor
        {
            get { return pressÄBBColor; }
            set { pressÄBBColor = value; OnPropertyChanged(); }
        }

        private string pressÜBGColor;
        public string PressÜBGColor
        {
            get { return pressÜBGColor; }
            set { pressÜBGColor = value; OnPropertyChanged(); }
        }
        private string pressÜBBColor;
        public string PressÜBBColor
        {
            get { return pressÜBBColor; }
            set { pressÜBBColor = value; OnPropertyChanged(); }
        }

        private string pressßBGColor;
        public string PressßBGColor
        {
            get { return pressßBGColor; }
            set { pressßBGColor = value; OnPropertyChanged(); }
        }
        private string pressßBBColor;
        public string PressßBBColor
        {
            get { return pressßBBColor; }
            set { pressßBBColor = value; OnPropertyChanged(); }
        }

        private string pressQBGColor;
        public string PressQBGColor
        {
            get { return pressQBGColor; }
            set { pressQBGColor = value; OnPropertyChanged(); }
        }
        private string pressQBBColor;
        public string PressQBBColor
        {
            get { return pressQBBColor; }
            set { pressQBBColor = value; OnPropertyChanged(); }
        }

        private string pressWBGColor;
        public string PressWBGColor
        {
            get { return pressWBGColor; }
            set { pressWBGColor = value; OnPropertyChanged(); }
        }
        private string pressWBBColor;
        public string PressWBBColor
        {
            get { return pressWBBColor; }
            set { pressWBBColor = value; OnPropertyChanged(); }
        }

        private string pressEBGColor;
        public string PressEBGColor
        {
            get { return pressEBGColor; }
            set { pressEBGColor = value; OnPropertyChanged(); }
        }
        private string pressEBBColor;
        public string PressEBBColor
        {
            get { return pressEBBColor; }
            set { pressEBBColor = value; OnPropertyChanged(); }
        }

        private string pressRBGColor;
        public string PressRBGColor
        {
            get { return pressRBGColor; }
            set { pressRBGColor = value; OnPropertyChanged(); }
        }
        private string pressRBBColor;
        public string PressRBBColor
        {
            get { return pressRBBColor; }
            set { pressRBBColor = value; OnPropertyChanged(); }
        }

        private string pressTBGColor;
        private string PressTBGColor
        {
            get { return pressTBGColor; }
            set { pressTBGColor = value; OnPropertyChanged(); }
        }
        private string pressTBBColor;
        public string PressTBBColor
        {
            get { return pressTBBColor; }
            set { pressTBBColor = value; OnPropertyChanged(); }
        }

        private string pressYBGColor;
        public string PressYBGColor
        {
            get { return pressYBGColor; }
            set { pressYBGColor = value; OnPropertyChanged(); }
        }
        private string pressYBBColor;
        public string PressYBBColor
        {
            get { return pressYBBColor; }
            set { pressYBBColor = value; OnPropertyChanged(); }
        }

        private string pressUBGColor;
        public string PressUBGColor
        {
            get { return pressUBGColor; }
            set { pressUBGColor = value; OnPropertyChanged(); }
        }
        private string pressUBBColor;
        public string PressUBBColor
        {
            get { return pressUBBColor; }
            set { pressUBBColor = value; OnPropertyChanged(); }
        }

        private string pressIBGColor;
        public string PressIBGColor
        {
            get { return pressIBGColor; }
            set { pressIBGColor = value; OnPropertyChanged(); }
        }
        private string pressIBBColor;
        public string PressIBBColor
        {
            get { return pressIBBColor; }
            set { pressIBBColor = value; OnPropertyChanged(); }
        }

        private string pressOBGColor;
        public string PressOBGColor
        {
            get { return pressOBGColor; }
            set { pressOBGColor = value; OnPropertyChanged(); }
        }
        private string pressOBBColor;
        public string PressOBBColor
        {
            get { return pressOBBColor; }
            set { pressOBBColor = value; OnPropertyChanged(); }
        }

        private string pressPBGColor;
        public string PressPBGColor
        {
            get { return pressPBGColor; }
            set { pressPBGColor = value; OnPropertyChanged(); }
        }
        private string pressPBBColor;
        public string PressPBBColor
        {
            get { return pressPBBColor; }
            set { pressPBBColor = value; OnPropertyChanged(); }
        }

        private string pressABGColor;
        public string PressABGColor
        {
            get { return pressABGColor; }
            set { pressABGColor = value; OnPropertyChanged(); }
        }
        private string pressABBColor;
        public string PressABBColor
        {
            get { return pressABBColor; }
            set { pressABBColor = value; OnPropertyChanged(); }
        }

        private string pressSBGColor;
        public string PressSBGColor
        {
            get { return pressSBGColor; }
            set { pressSBGColor = value; OnPropertyChanged(); }
        }
        private string pressSBBColor;
        public string PressSBBColor
        {
            get { return pressSBBColor; }
            set { pressSBBColor = value; OnPropertyChanged(); }
        }

        private string pressDBGColor;
        public string PressDBGColor
        {
            get { return pressDBGColor; }
            set { pressDBGColor = value; OnPropertyChanged(); }
        }
        private string pressDBBColor;
        public string PressDBBColor
        {
            get { return pressDBBColor; }
            set { pressDBBColor = value; OnPropertyChanged(); }
        }

        private string pressFBGColor;
        public string PressFBGColor
        {
            get { return pressFBGColor; }
            set { pressFBGColor = value; OnPropertyChanged(); }
        }
        private string pressFBBColor;
        public string PressFBBColor
        {
            get { return pressFBBColor; }
            set { pressFBBColor = value; OnPropertyChanged(); }
        }

        private string pressGBGColor;
        private string PressGBGColor
        {
            get { return pressGBGColor; }
            set { pressGBGColor = value; OnPropertyChanged(); }
        }
        private string pressGBBColor;
        public string PressGBBColor
        {
            get { return pressGBBColor; }
            set { pressGBBColor = value; OnPropertyChanged(); }
        }

        private string pressHBGColor;
        public string PressHBGColor
        {
            get { return pressHBGColor; }
            set { pressHBGColor = value; OnPropertyChanged(); }
        }
        private string pressHBBColor;
        public string PressHBBColor
        {
            get { return pressHBBColor; }
            set { pressHBBColor = value; OnPropertyChanged(); }
        }

        private string pressJBGColor;
        public string PressJBGColor
        {
            get { return pressJBGColor; }
            set { pressJBGColor = value; OnPropertyChanged(); }
        }
        private string pressJBBColor;
        public string PressJBBColor
        {
            get { return pressJBBColor; }
            set { pressJBBColor = value; OnPropertyChanged(); }
        }

        private string pressKBGColor;
        public string PressKBGColor
        {
            get { return pressKBGColor; }
            set { pressKBGColor = value; OnPropertyChanged(); }
        }
        private string pressKBBColor;
        public string PressKBBColor
        {
            get { return pressKBBColor; }
            set { pressKBBColor = value; OnPropertyChanged(); }
        }

        private string pressLBGColor;
        public string PressLBGColor
        {
            get { return pressLBGColor; }
            set { pressLBGColor = value; OnPropertyChanged(); }
        }
        private string pressLBBColor;
        public string PressLBBColor
        {
            get { return pressLBBColor; }
            set { pressLBBColor = value; OnPropertyChanged(); }
        }

        private string pressZBGColor;
        public string PressZBGColor
        {
            get { return pressZBGColor; }
            set { pressZBGColor = value; OnPropertyChanged(); }
        }
        private string pressZBBColor;
        public string PressZBBColor
        {
            get { return pressZBBColor; }
            set { pressZBBColor = value; OnPropertyChanged(); }
        }
        private string pressXBBColor;
        public string PressXBBColor
        {
            get { return pressXBBColor; }
            set { pressXBBColor = value; OnPropertyChanged(); }
        }

        private string pressXBGColor;
        public string PressXBGColor
        {
            get { return pressXBGColor; }
            set { pressXBGColor = value; OnPropertyChanged(); }
        }
        private string pressCBBColor;
        public string PressCBBColor
        {
            get { return pressCBBColor; }
            set { pressCBBColor = value; OnPropertyChanged(); }
        }

        private string pressCBGColor;
        public string PressCBGColor
        {
            get { return pressCBGColor; }
            set { pressCBGColor = value; OnPropertyChanged(); }
        }
        private string pressVBBColor;
        public string PressVBBColor
        {
            get { return pressVBBColor; }
            set { pressVBBColor = value; OnPropertyChanged(); }
        }

        private string pressVBGColor;
        public string PressVBGColor
        {
            get { return pressVBGColor; }
            set { pressVBGColor = value; OnPropertyChanged(); }
        }
        private string pressBBBColor;
        public string PressBBBColor
        {
            get { return pressBBBColor; }
            set { pressBBBColor = value; OnPropertyChanged(); }
        }

        private string pressBBGColor;
        public string PressBBGColor
        {
            get { return pressBBGColor; }
            set { pressBBGColor = value; OnPropertyChanged(); }
        }
        private string pressNBBColor;
        public string PressNBBColor
        {
            get { return pressNBBColor; }
            set { pressNBBColor = value; OnPropertyChanged(); }
        }
        private string pressNBGColor;
        public string PressNBGColor
        {
            get { return pressNBGColor; }
            set { pressNBGColor = value; OnPropertyChanged(); }
        }
        private string pressMBBColor;
        public string PressMBBColor
        {
            get { return pressMBBColor; }
            set { pressMBBColor = value; OnPropertyChanged(); }
        }
        private string pressMBGColor;
        public string PressMBGColor
        {
            get { return pressMBGColor; }
            set { pressMBGColor = value; OnPropertyChanged(); }
        }
        private string pressCommaBBColor;
        public string PressCommaBBColor
        {
            get { return pressCommaBBColor; }
            set { pressCommaBBColor = value; OnPropertyChanged(); }
        }
        private string pressCommaBGColor;
        public string PressCommaBGColor
        {
            get { return pressCommaBGColor; }
            set { pressCommaBGColor = value; OnPropertyChanged(); }
        }
        private string pressPointBBColor;
        public string PressPointBBColor
        {
            get { return pressPointBBColor; }
            set { pressPointBBColor = value; OnPropertyChanged(); }
        }
        private string pressPointBGColor;
        public string PressPointBGColor
        {
            get { return pressPointBGColor; }
            set { pressPointBGColor = value; OnPropertyChanged(); }
        }
        private string pressChangeKeyboardBBColor;
        public string PressChangeKeyboardBBColor
        {
            get { return pressChangeKeyboardBBColor; }
            set { pressChangeKeyboardBBColor = value; OnPropertyChanged(); }
        }
        private string pressChangeKeyboardBGColor;
        public string PressChangeKeyboardBGColor
        {
            get { return pressChangeKeyboardBGColor; }
            set { pressChangeKeyboardBGColor = value; OnPropertyChanged(); }
        }
        private string pressBackSpaceBGColor;
        public string PressBackSpaceBGColor
        {
            get { return pressBackSpaceBGColor; }
            set { pressBackSpaceBGColor = value; OnPropertyChanged(); }
        }
        private string pressBackSpaceBBColor;
        public string PressBackSpaceBBColor
        {
            get { return pressBackSpaceBBColor; }
            set { pressBackSpaceBBColor = value; OnPropertyChanged(); }
        }
        private string pressEnterBGColor;
        public string PressEnterBGColor
        {
            get { return pressEnterBGColor; }
            set { pressEnterBGColor = value; OnPropertyChanged(); }
        }
        private string pressEnterBBColor;
        public string PressEnterBBColor
        {
            get { return pressEnterBBColor; }
            set { pressEnterBBColor = value; OnPropertyChanged(); }
        }
        private string pressSpaceBGColor;
        public string PressSpaceBGColor
        {
            get { return pressSpaceBGColor; }
            set { pressSpaceBGColor = value; OnPropertyChanged(); }
        }
        private string pressSpaceBBColor;
        public string PressSpaceBBColor
        {
            get { return pressSpaceBBColor; }
            set { pressSpaceBBColor = value; OnPropertyChanged(); }
        }
        private string pressHideBGColor;
        public string PressHideBGColor
        {
            get { return pressHideBGColor; }
            set { pressHideBGColor = value; OnPropertyChanged(); }
        }
        private string pressHideBBColor;
        public string PressHideBBColor
        {
            get { return pressHideBBColor; }
            set { pressHideBBColor = value; OnPropertyChanged(); }
        }
        private string pressDownPointBGColor;
        public string PressDownPointBGColor
        {
            get { return pressDownPointBGColor; }
            set { pressDownPointBGColor = value; OnPropertyChanged(); }
        }
        private string pressDownPointBBColor;
        public string PressDownPointBBColor
        {
            get { return pressDownPointBBColor; }
            set { pressDownPointBBColor = value; OnPropertyChanged(); }
        }
        #endregion




        #region ALL COMMANDS
        public RelayCommand PressA { get; set; }
        public RelayCommand PressB { get; set; }
        public RelayCommand PressC { get; set; }
        public RelayCommand PressD { get; set; }
        public RelayCommand PressE { get; set; }
        public RelayCommand PressF { get; set; }
        public RelayCommand PressG { get; set; }
        public RelayCommand PressH { get; set; }
        public RelayCommand PressI { get; set; }
        public RelayCommand PressJ { get; set; }
        public RelayCommand PressK { get; set; }
        public RelayCommand PressL { get; set; }
        public RelayCommand PressM { get; set; }
        public RelayCommand PressN { get; set; }
        public RelayCommand PressO { get; set; }
        public RelayCommand PressP { get; set; }
        public RelayCommand PressQ { get; set; }
        public RelayCommand PressR { get; set; }
        public RelayCommand PressS { get; set; }
        public RelayCommand PressT { get; set; }
        public RelayCommand PressU { get; set; }
        public RelayCommand PressV { get; set; }
        public RelayCommand PressW { get; set; }
        public RelayCommand PressX { get; set; }
        public RelayCommand PressY { get; set; }
        public RelayCommand PressZ { get; set; }
        public RelayCommand PressComma { get; set; }
        public RelayCommand PressPoint { get; set; }
        public RelayCommand PressDownPoint { get; set; }
        public RelayCommand PressÖ { get; set; }
        public RelayCommand PressÄ { get; set; }
        public RelayCommand PressÜ { get; set; }
        public RelayCommand Pressß { get; set; }
        public RelayCommand Press1 { get; set; }
        public RelayCommand Press2 { get; set; }
        public RelayCommand Press3 { get; set; }
        public RelayCommand Press4 { get; set; }
        public RelayCommand Press5 { get; set; }
        public RelayCommand Press6 { get; set; }
        public RelayCommand Press7 { get; set; }
        public RelayCommand Press8 { get; set; }
        public RelayCommand Press9 { get; set; }
        public RelayCommand Press0 { get; set; }
        public RelayCommand PressBackSpace { get; set; }
        public RelayCommand PressEnter { get; set; }
        public RelayCommand PressChangeKeyboardType { get; set; }
        public RelayCommand PressShift { get; set; }
        public RelayCommand PressSpace { get; set; }
        public RelayCommand PressDog { get; set; }
        public RelayCommand PressSharp { get; set; }
        public RelayCommand PressDollar { get; set; }
        public RelayCommand PressDownLine { get; set; }
        public RelayCommand PressMinus { get; set; }
        public RelayCommand PressPlus { get; set; }
        public RelayCommand PressMultiply { get; set; }
        public RelayCommand PressDivide { get; set; }
        public RelayCommand PressEqual { get; set; }
        public RelayCommand PressAmpersant { get; set; }
        public RelayCommand PressLeftScope { get; set; }
        public RelayCommand PressRightScope { get; set; }
        public RelayCommand PressDoublePoint { get; set; }
        public RelayCommand PressPointComma { get; set; }
        public RelayCommand PressOneQuotationMark { get; set; }
        public RelayCommand PressTwoQuotationMark { get; set; }
        public RelayCommand PressExclamationPoint { get; set; }
        public RelayCommand PressQuestion { get; set; }
        public RelayCommand CloseMainWindow { get; set; }
        public RelayCommand HideKeyboard { get; set; }
        #endregion
        private string _keyboardType;
        public string KeyboardType
        {
            get
            {
                return _keyboardType;
            }
            set
            {
                _keyboardType = value;
                OnPropertyChanged();
            }
        }

        #region ButtonsText

        private string _textÖ;
        public string TextÖ
        {
            get
            {
                return _textÖ;
            }
            set
            {
                _textÖ = value;
                OnPropertyChanged();
            }
        }
        private string _textÄ;
        public string TextÄ
        {
            get
            {
                return _textÄ;
            }
            set
            {
                _textÄ = value;
                OnPropertyChanged();
            }
        }
        private string _textÜ;
        public string TextÜ
        {
            get
            {
                return _textÜ;
            }
            set
            {
                _textÜ = value;
                OnPropertyChanged();
            }
        }
        private string _textß;
        public string Textß
        {
            get
            {
                return _textß;
            }
            set
            {
                _textß = value;
                OnPropertyChanged();
            }
        }

        private string _textQ;
        public string TextQ
        {
            get
            {
                return _textQ;
            }
            set
            {
                _textQ = value;
                OnPropertyChanged();
            }
        }

        private string _textW;
        public string TextW
        {
            get
            {
                return _textW;
            }
            set
            {
                _textW = value;
                OnPropertyChanged();
            }
        }

        private string _textE;
        public string TextE
        {
            get
            {
                return _textE;
            }
            set
            {
                _textE = value;
                OnPropertyChanged();
            }
        }

        private string _textR;
        public string TextR
        {
            get
            {
                return _textR;
            }
            set
            {
                _textR = value;
                OnPropertyChanged();
            }
        }
        private string _textT;
        public string TextT
        {
            get
            {
                return _textT;
            }
            set
            {
                _textT = value;
                OnPropertyChanged();
            }
        }
        private string _textY;
        public string TextY
        {
            get
            {
                return _textY;
            }
            set
            {
                _textY = value;
                OnPropertyChanged();
            }
        }
        private string _textU;
        public string TextU
        {
            get
            {
                return _textU;
            }
            set
            {
                _textU = value;
                OnPropertyChanged();
            }
        }
        private string _textI;
        public string TextI
        {
            get
            {
                return _textI;
            }
            set
            {
                _textI = value;
                OnPropertyChanged();
            }
        }
        private string _textO;
        public string TextO
        {
            get
            {
                return _textO;
            }
            set
            {
                _textO = value;
                OnPropertyChanged();
            }
        }
        private string _textP;
        public string TextP
        {
            get
            {
                return _textP;
            }
            set
            {
                _textP = value;
                OnPropertyChanged();
            }
        }
        private string _textA;
        public string TextA
        {
            get
            {
                return _textA;
            }
            set
            {
                _textA = value;
                OnPropertyChanged();
            }
        }
        private string _textS;
        public string TextS
        {
            get
            {
                return _textS;
            }
            set
            {
                _textS = value;
                OnPropertyChanged();
            }
        }
        private string _textD;
        public string TextD
        {
            get
            {
                return _textD;
            }
            set
            {
                _textD = value;
                OnPropertyChanged();
            }
        }
        private string _textF;
        public string TextF
        {
            get
            {
                return _textF;
            }
            set
            {
                _textF = value;
                OnPropertyChanged();
            }
        }
        private string _textG;
        public string TextG
        {
            get
            {
                return _textG;
            }
            set
            {
                _textG = value;
                OnPropertyChanged();
            }
        }
        private string _textH;
        public string TextH
        {
            get
            {
                return _textH;
            }
            set
            {
                _textH = value;
                OnPropertyChanged();
            }
        }
        private string _textJ;
        public string TextJ
        {
            get
            {
                return _textJ;
            }
            set
            {
                _textJ = value;
                OnPropertyChanged();
            }
        }
        private string _textK;
        public string TextK
        {
            get
            {
                return _textK;
            }
            set
            {
                _textK = value;
                OnPropertyChanged();
            }
        }
        private string _textL;
        public string TextL
        {
            get
            {
                return _textL;
            }
            set
            {
                _textL = value;
                OnPropertyChanged();
            }
        }
        private string _textZ;
        public string TextZ
        {
            get
            {
                return _textZ;
            }
            set
            {
                _textZ = value;
                OnPropertyChanged();
            }
        }
        private string _textX;
        public string TextX
        {
            get
            {
                return _textX;
            }
            set
            {
                _textX = value;
                OnPropertyChanged();
            }
        }
        private string _textC;
        public string TextC
        {
            get
            {
                return _textC;
            }
            set
            {
                _textC = value;
                OnPropertyChanged();
            }
        }
        private string _textV;
        public string TextV
        {
            get
            {
                return _textV;
            }
            set
            {
                _textV = value;
                OnPropertyChanged();
            }
        }
        private string _textB;
        public string TextB
        {
            get
            {
                return _textB;
            }
            set
            {
                _textB = value;
                OnPropertyChanged();
            }
        }
        private string _textN;
        public string TextN
        {
            get
            {
                return _textN;
            }
            set
            {
                _textN = value;
                OnPropertyChanged();
            }
        }
        private string _textM;
        public string TextM
        {
            get
            {
                return _textM;
            }
            set
            {
                _textM = value;
                OnPropertyChanged();
            }
        }
        private string _textComma;
        public string TextComma
        {
            get
            {
                return _textComma;
            }
            set
            {
                _textComma = value;
                OnPropertyChanged();
            }
        }
        private string _textPoint;
        public string TextPoint
        {
            get
            {
                return _textPoint;
            }
            set
            {
                _textPoint = value;
                OnPropertyChanged();
            }
        }
        #endregion

        private KeyboardLayouts _keyboardLayout;
        
        #region VISIBILITY OF CHOSEN KEYBOARD

        private string _textKeyboardVisibility;
        public string TextKeyboardVisibility
        {
            get
            {
                return _textKeyboardVisibility;
            }
            set
            {
                _textKeyboardVisibility = value;
                OnPropertyChanged();
            }
        }

        private string _textNumberKeyboardVisibility;
        public string TextNumberKeyboardVisibility
        {
            get
            {
                return _textNumberKeyboardVisibility;
            }
            set
            {
                _textNumberKeyboardVisibility = value;
                OnPropertyChanged();
           }
        }

        #endregion



        private bool _shiftPressed = true;
        
        private string _shiftColorBackground;
        private string _shiftColorBorderBrush;
        public string ShiftColorBackground
        {
            get
            {
                return _shiftColorBackground;
            }
            set
            {
                _shiftColorBackground = value;
                OnPropertyChanged();
            }
        }
        public string ShiftColorBorderBrush
        {
            get
            {
                return _shiftColorBorderBrush;
            }
            set
            {
                _shiftColorBorderBrush = value;
                OnPropertyChanged();
            }
        }

        private int WindowNumber;

        public MainWindowViewModel()
        {

        }

        public MainWindowViewModel(int WindowNumber)
        {
            if (WindowNumber == 0)
            {
                _httpListener.Prefixes.Add("http://localhost:7000/coordinates/");
                _httpListener.Prefixes.Add("http://localhost:7000/keyboardhealth/");
                _httpListener.Prefixes.Add("http://localhost:7000/hidekeyboard/");
                _httpListener.Start();
                Thread serverThread = new Thread(ResponseThread);
                serverThread.IsBackground = true;
                serverThread.Start();
                string myFavoritePath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                Automation = new CUIAutomation8();
                CloseMainWindow = new RelayCommand(o => { Process.GetProcessById(TOUCHINPUT_PROCID).Kill(); });
            }
            ActivateAllButtonCommands();
            DefaultKeyboardActivation();
        }
        public void DefaultKeyboardActivation()
        {
            //TextKeyboardVisibility = "Visible";
            //TextNumberKeyboardVisibility = "Hidden";
            //NumberKeyboardVisibility = "Hidden";
        }
        private void AnimationWord(string word)
        {
            switch(word)
            {
                case "Ö":
                    Thread threadÖ = new Thread(() =>
                    {
                        PressÖBGColor = "#FF36A1FF";
                        PressÖBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressÖBGColor = "White";
                        PressÖBBColor = "White";
                    });
                    threadÖ.IsBackground = true;
                    threadÖ.Start();
                    break;
                case "Ä":
                    Thread threadÄ = new Thread(() =>
                    {
                        PressÄBGColor = "#FF36A1FF";
                        PressÄBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressÄBGColor = "White";
                        PressÄBBColor = "White";
                    });
                    threadÄ.IsBackground = true;
                    threadÄ.Start();
                    break;
                case "Ü":
                    Thread threadÜ = new Thread(() =>
                    {
                        PressÜBGColor = "#FF36A1FF";
                        PressÜBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressÜBGColor = "White";
                        PressÜBBColor = "White";
                    });
                    threadÜ.IsBackground = true;
                    threadÜ.Start();
                    break;
                case "ß":
                    Thread threadß = new Thread(() =>
                    {
                        PressßBGColor = "#FF36A1FF";
                        PressßBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressßBGColor = "White";
                        PressßBBColor = "White";
                    });
                    threadß.IsBackground = true;
                    threadß.Start();
                    break;
                case "Q":
                    Thread threadQ = new Thread(() =>
                    {
                        PressQBGColor = "#FF36A1FF";
                        PressQBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressQBGColor = "White";
                        PressQBBColor = "White";
                    });
                    threadQ.IsBackground = true;
                    threadQ.Start();
                    break;
                case "W":
                    Thread threadW = new Thread(() =>
                    {
                        PressWBGColor = "#FF36A1FF";
                        PressWBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressWBGColor = "White";
                        PressWBBColor = "White";
                    });
                    threadW.IsBackground = true;
                    threadW.Start();
                    break;
                case "E":
                    Thread threadE = new Thread(() =>
                    {
                        PressEBGColor = "#FF36A1FF";
                        PressEBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressEBGColor = "White";
                        PressEBBColor = "White";
                    });
                    threadE.IsBackground = true;
                    threadE.Start();
                    break;
                case "R":
                    Thread threadR = new Thread(() =>
                    {
                        PressRBGColor = "#FF36A1FF";
                        PressRBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressRBGColor = "White";
                        PressRBBColor = "White";
                    });
                    threadR.IsBackground = true;
                    threadR.Start();
                    break;
                case "T":
                    Thread threadT = new Thread(() =>
                    {
                        PressTBGColor = "#FF36A1FF";
                        PressTBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressTBGColor = "White";
                        PressTBBColor = "White";
                    });
                    threadT.IsBackground = true;
                    threadT.Start();
                    break;
                case "Y":
                    Thread threadY = new Thread(() =>
                    {
                        PressYBGColor = "#FF36A1FF";
                        PressYBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressYBGColor = "White";
                        PressYBBColor = "White";
                    });
                    threadY.IsBackground = true;
                    threadY.Start();
                    break;
                case "U":
                    Thread threadU = new Thread(() =>
                    {
                        PressUBGColor = "#FF36A1FF";
                        PressUBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressUBGColor = "White";
                        PressUBBColor = "White";
                    });
                    threadU.IsBackground = true;
                    threadU.Start();
                    break;
                case "I":
                    Thread threadI = new Thread(() =>
                    {
                        PressIBGColor = "#FF36A1FF";
                        PressIBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressIBGColor = "White";
                        PressIBBColor = "White";
                    });
                    threadI.IsBackground = true;
                    threadI.Start();
                    break;
                case "O":
                    Thread threadO = new Thread(() =>
                    {
                        PressOBGColor = "#FF36A1FF";
                        PressOBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressOBGColor = "White";
                        PressOBBColor = "White";
                    });
                    threadO.IsBackground = true;
                    threadO.Start();
                    break;
                case "P":
                    Thread threadP = new Thread(() =>
                    {
                        PressPBGColor = "#FF36A1FF";
                        PressPBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressPBGColor = "White";
                        PressPBBColor = "White";
                    });
                    threadP.IsBackground = true;
                    threadP.Start();
                    break;
                case "A":
                    Thread threadA = new Thread(() =>
                    {
                        PressABGColor = "#FF36A1FF";
                        PressABBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressABGColor = "White";
                        PressABBColor = "White";
                    });
                    threadA.IsBackground = true;
                    threadA.Start();
                    break;
                case "S":
                    Thread threadS = new Thread(() =>
                    {
                        PressSBGColor = "#FF36A1FF";
                        PressSBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressSBGColor = "White";
                        PressSBBColor = "White";
                    });
                    threadS.IsBackground = true;
                    threadS.Start();
                    break;
                case "D":
                    Thread threadD = new Thread(() =>
                    {
                        PressDBGColor = "#FF36A1FF";
                        PressDBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressDBGColor = "White";
                        PressDBBColor = "White";
                    });
                    threadD.IsBackground = true;
                    threadD.Start();
                    break;
                case "F":
                    Thread threadF = new Thread(() =>
                    {
                        PressFBGColor = "#FF36A1FF";
                        PressFBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressFBGColor = "White";
                        PressFBBColor = "White";
                    });
                    threadF.IsBackground = true;
                    threadF.Start();
                    break;
                case "G":
                    Thread threadG = new Thread(() =>
                    {
                        PressGBGColor = "#FF36A1FF";
                        PressGBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressGBGColor = "White";
                        PressGBBColor = "White";
                    });
                    threadG.IsBackground = true;
                    threadG.Start();
                    break;
                case "H":
                    Thread threadH = new Thread(() =>
                    {
                        PressHBGColor = "#FF36A1FF";
                        PressHBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressHBGColor = "White";
                        PressHBBColor = "White";
                    });
                    threadH.IsBackground = true;
                    threadH.Start();
                    break;
                case "J":
                    Thread threadJ = new Thread(() =>
                    {
                        PressJBGColor = "#FF36A1FF";
                        PressJBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressJBGColor = "White";
                        PressJBBColor = "White";
                    });
                    threadJ.IsBackground = true;
                    threadJ.Start();
                    break;
                case "K":
                    Thread threadK = new Thread(() =>
                    {
                        PressKBGColor = "#FF36A1FF";
                        PressKBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressKBGColor = "White";
                        PressKBBColor = "White";
                    });
                    threadK.IsBackground = true;
                    threadK.Start();
                    break;
                case "L":
                    Thread threadL = new Thread(() =>
                    {
                        PressLBGColor = "#FF36A1FF";
                        PressLBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressLBGColor = "White";
                        PressLBBColor = "White";
                    });
                    threadL.IsBackground = true;
                    threadL.Start();
                    break;
                case "Z":
                    Thread threadZ = new Thread(() =>
                    {
                        PressZBGColor = "#FF36A1FF";
                        PressZBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressZBGColor = "White";
                        PressZBBColor = "White";
                    });
                    threadZ.IsBackground = true;
                    threadZ.Start();
                    break;
                case "X":
                    Thread threadX = new Thread(() =>
                    {
                        PressXBGColor = "#FF36A1FF";
                        PressXBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressXBGColor = "White";
                        PressXBBColor = "White";
                    });
                    threadX.IsBackground = true;
                    threadX.Start();
                    break;
                case "C":
                    Thread threadC = new Thread(() =>
                    {
                        PressCBGColor = "#FF36A1FF";
                        PressCBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressCBGColor = "White";
                        PressCBBColor = "White";
                    });
                    threadC.IsBackground = true;
                    threadC.Start();
                    break;
                case "V":
                    Thread threadV = new Thread(() =>
                    {
                        PressVBGColor = "#FF36A1FF";
                        PressVBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressVBGColor = "White";
                        PressVBBColor = "White";
                    });
                    threadV.IsBackground = true;
                    threadV.Start();
                    break;
                case "B":
                    Thread threadB = new Thread(() =>
                    {
                        PressBBGColor = "#FF36A1FF";
                        PressBBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressBBGColor = "White";
                        PressBBBColor = "White";
                    });
                    threadB.IsBackground = true;
                    threadB.Start();
                    break;
                case "N":
                    Thread threadN = new Thread(() =>
                    {
                        PressNBGColor = "#FF36A1FF";
                        PressNBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressNBGColor = "White";
                        PressNBBColor = "White";
                    });
                    threadN.IsBackground = true;
                    threadN.Start();
                    break;
                case "M":
                    Thread threadM = new Thread(() =>
                    {
                        PressMBGColor = "#FF36A1FF";
                        PressMBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressMBGColor = "White";
                        PressMBBColor = "White";
                    });
                    threadM.IsBackground = true;
                    threadM.Start();
                    break;
                case "Comma":
                    Thread threadComma = new Thread(() =>
                    {
                        PressCommaBGColor = "#FF36A1FF";
                        PressCommaBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressCommaBGColor = "White";
                        PressCommaBBColor = "White";
                    });
                    threadComma.IsBackground = true;
                    threadComma.Start();
                    break;
                case "Point":
                    Thread threadPoint = new Thread(() =>
                    {
                        PressPointBGColor = "#FF36A1FF";
                        PressPointBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressPointBGColor = "White";
                        PressPointBBColor = "White";
                    });
                    threadPoint.IsBackground = true;
                    threadPoint.Start();
                    break;
                case "DownPoint":
                    Thread threadDownPoint = new Thread(() =>
                    {
                        PressDownPointBGColor = "#FF36A1FF";
                        PressDownPointBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressDownPointBGColor = "White";
                        PressDownPointBBColor = "White";
                    });
                    threadDownPoint.IsBackground = true;
                    threadDownPoint.Start();
                    break;
                case "BackSpace":
                    Thread threadBackSpace = new Thread(() =>
                    {
                        PressBackSpaceBGColor = "#FF36A1FF";
                        PressBackSpaceBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressBackSpaceBGColor = "White";
                        PressBackSpaceBBColor = "White";
                    });
                    threadBackSpace.IsBackground = true;
                    threadBackSpace.Start();
                    break;
                case "Hide":
                    Thread threadHide = new Thread(() =>
                    {
                        PressHideBGColor = "#FF36A1FF";
                        PressHideBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressHideBGColor = "White";
                        PressHideBBColor = "White";
                    });
                    threadHide.IsBackground = true;
                    threadHide.Start();
                    break;
                case "Space":
                    Thread threadSpace = new Thread(() =>
                    {
                        PressSpaceBGColor = "#FF36A1FF";
                        PressSpaceBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressSpaceBGColor = "White";
                        PressSpaceBBColor = "White";
                    });
                    threadSpace.IsBackground = true;
                    threadSpace.Start();
                    break;
                case "Enter":
                    Thread threadEnter = new Thread(() =>
                    {
                        PressEnterBGColor = "#FF36A1FF";
                        PressEnterBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressEnterBGColor = "White";
                        PressEnterBBColor = "White";
                    });
                    threadEnter.IsBackground = true;
                    threadEnter.Start();
                    break;
                case "ChangeKeyboard":
                    Thread threadChangeKeyboard = new Thread(() =>
                    {
                        PressChangeKeyboardBGColor = "#FF36A1FF";
                        PressChangeKeyboardBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressChangeKeyboardBGColor = "White";
                        PressChangeKeyboardBBColor = "White";
                    });
                    threadChangeKeyboard.IsBackground = true;
                    threadChangeKeyboard.Start();
                    break;
                case "Dog":
                    Thread threadDog = new Thread(() =>
                    {
                        PressDOGColor = "#FF36A1FF";
                        //PressChangeKeyboardBBColor = "#FF167CD6";
                        Thread.Sleep(100);
                        PressDOGColor = "White";
                    });
                    threadDog.IsBackground = true;
                    threadDog.Start();
                    break;
            }
        }
        public void ActivateAllButtonCommands()
        {
            _keyboardLayout = KeyboardLayouts.Text;
            switch (_keyboardLayout)
            {
                case KeyboardLayouts.Text:
                    KeyboardType = "123";
                    TextNumberKeyboardVisibility = "Collapsed";
                    TextKeyboardVisibility = "Visible";
                    break;
                case KeyboardLayouts.Number:
                    KeyboardType = "ABC";
                    TextNumberKeyboardVisibility = "Visible";
                    TextKeyboardVisibility = "Collapsed";
                    break;
            }
            switch(_shiftPressed)
            {
                case false:
                    ShiftColorBackground = "#FF36A1FF";
                    ShiftColorBorderBrush = "#FF167CD6";
                    TextÄ = "Ä";
                    TextÜ = "Ü";
                    TextÖ = "Ö";
                    TextQ = "Q";
                    Textß = "ß";
                    TextW = "W";
                    TextE = "E";
                    TextR = "R";
                    TextT = "T";
                    TextY = "Y";
                    TextU = "U";
                    TextI = "I";
                    TextO = "O";
                    TextP = "P";
                    TextA = "A";
                    TextS = "S";
                    TextD = "D";
                    TextF = "F";
                    TextG = "G";
                    TextH = "H";
                    TextJ = "J";
                    TextK = "K";
                    TextL = "L";
                    TextZ = "Z";
                    TextX = "X";
                    TextC = "C";
                    TextV = "V";
                    TextB = "B";
                    TextN = "N";
                    TextM = "M";
                    TextComma = "<";
                    TextPoint = ">";
                    break;
                case true:
                    ShiftColorBackground = "White";
                    ShiftColorBorderBrush = "White";
                    PressQBBColor = "White";
                    PressQBGColor = "White";
                    PressWBBColor = "White";
                    PressWBGColor = "White";
                    PressEBGColor = "White";
                    PressEBBColor = "White";
                    PressRBBColor = "White";
                    PressRBGColor = "White";
                    PressTBGColor = "White";
                    PressTBBColor = "White";
                    PressYBBColor = "White";
                    PressYBGColor = "White";
                    PressUBBColor = "White";
                    PressUBGColor = "White";
                    PressIBGColor = "White";
                    PressIBBColor = "White";
                    PressOBBColor = "White";
                    PressOBGColor = "White";
                    PressPBGColor = "White";
                    PressPBBColor = "White";
                    PressABBColor = "White";
                    PressABGColor = "White";
                    PressSBBColor = "White";
                    PressSBGColor = "White";
                    PressDBGColor = "White";
                    PressDBBColor = "White";
                    PressFBBColor = "White";
                    PressFBGColor = "White";
                    PressGBGColor = "White";
                    PressGBBColor = "White";
                    PressHBBColor = "White";
                    PressHBGColor = "White";
                    PressJBBColor = "White";
                    PressJBGColor = "White";
                    PressKBGColor = "White";
                    PressKBBColor = "White";
                    PressLBBColor = "White";
                    PressLBGColor = "White";
                    PressZBGColor = "White";
                    PressZBBColor = "White";
                    PressXBGColor = "White";
                    PressXBBColor = "White";
                    PressCBBColor = "White";
                    PressCBGColor = "White";
                    PressVBGColor = "White";
                    PressVBBColor = "White";
                    PressBBBColor = "White";
                    PressBBGColor = "White";
                    PressNBBColor = "White";
                    PressNBGColor = "White";
                    PressMBGColor = "White";
                    PressMBBColor = "White";
                    PressCommaBBColor = "White";
                    PressCommaBGColor = "White";
                    PressPointBGColor = "White";
                    PressPointBBColor = "White";
                    PressBackSpaceBBColor = "White";
                    PressBackSpaceBGColor = "White";
                    PressSpaceBGColor = "White";
                    PressSpaceBBColor = "White";
                    PressEnterBGColor = "White";
                    PressEnterBBColor = "White";
                    PressChangeKeyboardBGColor = "White";
                    PressChangeKeyboardBBColor = "White";
                    PressHideBGColor = "White";
                    PressHideBBColor = "White";
                    PressDownPointBBColor = "White";
                    PressDownPointBGColor = "White";
                    PressßBGColor = "White";
                    PressßBBColor = "White";
                    PressÜBBColor = "White";
                    PressÜBGColor = "White";
                    PressÖBBColor = "White";
                    PressÖBGColor = "White";
                    PressÄBBColor = "White";
                    PressÄBGColor = "White";
                    PressDOGColor = "White";
                    TextÄ = "ä";
                    TextÜ = "ü";
                    TextÖ = "ö";
                    TextQ = "Q";
                    Textß = "ß";
                    TextQ = "q";
                    TextW = "w";
                    TextE = "e";
                    TextR = "r";
                    TextT = "t";
                    TextY = "y";
                    TextU = "u";
                    TextI = "i";
                    TextO = "o";
                    TextP = "p";
                    TextA = "a";
                    TextS = "s";
                    TextD = "d";
                    TextF = "f";
                    TextG = "g";
                    TextH = "h";
                    TextJ = "j";
                    TextK = "k";
                    TextL = "l";
                    TextZ = "z";
                    TextX = "x";
                    TextC = "c";
                    TextV = "v";
                    TextB = "b";
                    TextN = "n";
                    TextM = "m";
                    TextComma = ",";
                    TextPoint = ".";
                    break;
            }
            #region TextButtons
            Pressß = new RelayCommand(o =>
            {
                AnimationWord("ß");
                if (_shiftPressed)
                    SendKeys.SendWait("ß");
                else
                    SendKeys.SendWait("ß");
                SendKeys.Flush();
            });
            PressÖ = new RelayCommand(o =>
            {
                AnimationWord("Ö");
                if (_shiftPressed)
                    SendKeys.SendWait("ö");
                else
                    SendKeys.SendWait("Ö");
                SendKeys.Flush();
            });
            PressÄ = new RelayCommand(o =>
            {
                AnimationWord("Ä");
                if (_shiftPressed)
                    SendKeys.SendWait("ä");
                else
                    SendKeys.SendWait("Ä");
                SendKeys.Flush();
            });
            PressÜ = new RelayCommand(o =>
            {
                AnimationWord("Ü");
                if (_shiftPressed)
                    SendKeys.SendWait("ü");
                else
                    SendKeys.SendWait("Ü");
                SendKeys.Flush();
            });
            PressA = new RelayCommand(o => 
            {
                AnimationWord("A");
                if (_shiftPressed)
                    SendKeys.SendWait("a");
                else
                    SendKeys.SendWait("A");
                SendKeys.Flush();
            });
            PressB = new RelayCommand(o => 
            {
                AnimationWord("B");
                if (_shiftPressed)
                    SendKeys.SendWait("b");
                else
                    SendKeys.SendWait("B");
                SendKeys.Flush();
            });
            PressC = new RelayCommand(o => 
            { 
                AnimationWord("C");
                if (_shiftPressed)
                    SendKeys.SendWait("c");
                else
                    SendKeys.SendWait("C");
                SendKeys.Flush();
            });
            PressD = new RelayCommand(o => 
            { 
                AnimationWord("D");
                if (_shiftPressed)
                    SendKeys.SendWait("d");
                else
                    SendKeys.SendWait("D");
                SendKeys.Flush();
            });
            PressE = new RelayCommand(o => 
            {
                AnimationWord("E");
                if (_shiftPressed)
                    SendKeys.SendWait("e");
                else
                    SendKeys.SendWait("E");
                SendKeys.Flush();
            });
            PressF = new RelayCommand(o => 
            { 
                AnimationWord("F");
                if (_shiftPressed)
                    SendKeys.SendWait("f");
                else
                    SendKeys.SendWait("F");
                SendKeys.Flush();
            });
            PressG = new RelayCommand(o => 
            { 
                AnimationWord("G");
                if (_shiftPressed)
                    SendKeys.SendWait("g");
                else
                    SendKeys.SendWait("G");
                SendKeys.Flush();
            });
            PressH = new RelayCommand(o => 
            { 
                AnimationWord("H");
                if (_shiftPressed)
                    SendKeys.SendWait("h");
                else
                    SendKeys.SendWait("H");
                SendKeys.Flush();
            });
            PressI = new RelayCommand(o => 
            {
                AnimationWord("I");
                if (_shiftPressed)
                    SendKeys.SendWait("i");
                else
                    SendKeys.SendWait("I");
                SendKeys.Flush();
            });
            PressJ = new RelayCommand(o => 
            { 
                AnimationWord("J");
                if (_shiftPressed)
                    SendKeys.SendWait("j");
                else
                    SendKeys.SendWait("J");
                SendKeys.Flush();
            });
            PressK = new RelayCommand(o => 
            { 
                AnimationWord("K");
                if (_shiftPressed)
                    SendKeys.SendWait("k");
                else
                    SendKeys.SendWait("K");
                SendKeys.Flush();
            });
            PressL = new RelayCommand(o => 
            { 
                AnimationWord("L");
                if (_shiftPressed)
                    SendKeys.SendWait("l");
                else
                    SendKeys.SendWait("L");
                SendKeys.Flush();
            });
            PressM = new RelayCommand(o => 
            {
                AnimationWord("M");
                if (_shiftPressed)
                    SendKeys.SendWait("m");
                else
                    SendKeys.SendWait("M");
                SendKeys.Flush();
            });
            PressN = new RelayCommand(o => 
            {
                AnimationWord("N");
                if (_shiftPressed)
                    SendKeys.SendWait("n");
                else
                    SendKeys.SendWait("N");
                SendKeys.Flush();
            });
            PressO = new RelayCommand(o => 
            { 
                AnimationWord("O");
                if (_shiftPressed)
                    SendKeys.SendWait("o");
                else
                    SendKeys.SendWait("O");
                SendKeys.Flush();
            });
            PressP = new RelayCommand(o => 
            { 
                AnimationWord("P");
                if (_shiftPressed)
                    SendKeys.SendWait("p");
                else
                    SendKeys.SendWait("P");
                SendKeys.Flush();
            });
            PressQ = new RelayCommand(o => 
            { 
                AnimationWord("Q");
                if (_shiftPressed)
                    SendKeys.SendWait("q");
                else
                    SendKeys.SendWait("Q");
                SendKeys.Flush();
            });
            PressR = new RelayCommand(o => 
            { 
                AnimationWord("R");
                if (_shiftPressed)
                    SendKeys.SendWait("r");
                else
                    SendKeys.SendWait("R");
                SendKeys.Flush();
            });
            PressS = new RelayCommand(o => 
            { 
                AnimationWord("S");
                if (_shiftPressed)
                    SendKeys.SendWait("s");
                else
                    SendKeys.SendWait("S");
                SendKeys.Flush();
            });
            PressT = new RelayCommand(o => 
            { 
                AnimationWord("T");
                if (_shiftPressed)
                    SendKeys.SendWait("t");
                else
                    SendKeys.SendWait("T");
                SendKeys.Flush();
            });
            PressU = new RelayCommand(o => 
            { 
                AnimationWord("U");
                if (_shiftPressed)
                    SendKeys.SendWait("u");
                else
                    SendKeys.SendWait("U");
                SendKeys.Flush();
            });
            PressV = new RelayCommand(o => 
            {
                AnimationWord("V");
                if (_shiftPressed)
                    SendKeys.SendWait("v");
                else
                    SendKeys.SendWait("V");
                SendKeys.Flush();
            });
            PressW = new RelayCommand(o => 
            { 
                AnimationWord("W");
                if (_shiftPressed)
                    SendKeys.SendWait("w");
                else
                    SendKeys.SendWait("W");
                SendKeys.Flush();
            });
            PressX = new RelayCommand(o => 
            { 
                AnimationWord("X");
                if (_shiftPressed)
                    SendKeys.SendWait("x");
                else
                    SendKeys.SendWait("X");
                SendKeys.Flush();
            });
            PressY = new RelayCommand(o => 
            { 
                AnimationWord("Y");
                if (_shiftPressed)
                    SendKeys.SendWait("y");
                else
                    SendKeys.SendWait("Y");
                SendKeys.Flush();
            });
            PressZ = new RelayCommand(o => 
            {
                AnimationWord("Z");
                if (_shiftPressed)
                    SendKeys.SendWait("z");
                else
                    SendKeys.SendWait("Z");
                SendKeys.Flush();
            });
            PressComma = new RelayCommand(o => 
            { 
                AnimationWord("Comma");
                if (_shiftPressed)
                    SendKeys.SendWait(",");
                else
                    SendKeys.SendWait("<");
                SendKeys.Flush();
            });
            PressPoint = new RelayCommand(o => 
            { 
                AnimationWord("Point");
                SendKeys.SendWait(".");
                SendKeys.Flush();
            });
            PressDownPoint = new RelayCommand(o => 
            { 
                AnimationWord("DownPoint");
                if (_shiftPressed)
                    SendKeys.SendWait(".");
                else
                    SendKeys.SendWait(">");
                SendKeys.Flush();
            });
            #endregion
            #region Number Buttons
            Press1 = new RelayCommand(o => { AnimationWord("Q"); SendKeys.SendWait("1"); SendKeys.Flush(); });
            Press2 = new RelayCommand(o => { AnimationWord("W"); SendKeys.SendWait("2"); SendKeys.Flush(); });
            Press3 = new RelayCommand(o => { AnimationWord("E"); SendKeys.SendWait("3"); SendKeys.Flush(); });
            Press4 = new RelayCommand(o => { AnimationWord("R"); SendKeys.SendWait("4"); SendKeys.Flush(); });
            Press5 = new RelayCommand(o => { AnimationWord("T"); SendKeys.SendWait("5"); SendKeys.Flush(); });
            Press6 = new RelayCommand(o => { AnimationWord("Y"); SendKeys.SendWait("6"); SendKeys.Flush(); });
            Press7 = new RelayCommand(o => { AnimationWord("U"); SendKeys.SendWait("7"); SendKeys.Flush(); });
            Press8 = new RelayCommand(o => { AnimationWord("I"); SendKeys.SendWait("8"); SendKeys.Flush(); });
            Press9 = new RelayCommand(o => { AnimationWord("O"); SendKeys.SendWait("9"); SendKeys.Flush(); });
            Press0 = new RelayCommand(o => { AnimationWord("P"); SendKeys.SendWait("0"); SendKeys.Flush(); });
            #endregion
            #region SymbolButtons
            PressDog = new RelayCommand(o => { AnimationWord("Dog"); SendKeys.SendWait("@"); SendKeys.Flush(); });
            PressSharp = new RelayCommand(o => { AnimationWord("S"); SendKeys.SendWait("#"); SendKeys.Flush(); });
            PressDollar = new RelayCommand(o => { AnimationWord("D"); SendKeys.SendWait("$"); SendKeys.Flush(); ; });
            PressDownLine = new RelayCommand(o => { AnimationWord("F"); SendKeys.SendWait("_"); SendKeys.Flush(); });
            PressMinus = new RelayCommand(o => { AnimationWord("G"); SendKeys.SendWait("-"); SendKeys.Flush(); });
            PressPlus = new RelayCommand(o => { AnimationWord("H"); SendKeys.SendWait("{+}"); });
            PressMultiply = new RelayCommand(o => { AnimationWord("J"); SendKeys.SendWait("*"); SendKeys.Flush(); });
            PressDivide = new RelayCommand(o => { AnimationWord("K"); SendKeys.SendWait("/"); SendKeys.Flush(); });
            PressEqual = new RelayCommand(o => { AnimationWord("L"); SendKeys.SendWait("="); SendKeys.Flush(); });
            PressAmpersant = new RelayCommand(o => { AnimationWord("Z"); SendKeys.SendWait("&"); SendKeys.Flush(); });
            PressLeftScope = new RelayCommand(o => { AnimationWord("X"); SendKeys.SendWait("{(}"); SendKeys.Flush(); });
            PressRightScope = new RelayCommand(o => { AnimationWord("C"); SendKeys.SendWait("{)}"); SendKeys.Flush(); });
            PressPointComma = new RelayCommand(o => { AnimationWord("V"); SendKeys.SendWait(";"); SendKeys.Flush(); });
            PressDoublePoint = new RelayCommand(o => { AnimationWord("B"); SendKeys.SendWait(":"); SendKeys.Flush(); });
            PressOneQuotationMark = new RelayCommand(o => { AnimationWord("N"); SendKeys.SendWait("'"); SendKeys.Flush(); });
            PressTwoQuotationMark = new RelayCommand(o => { AnimationWord("M"); SendKeys.SendWait("''"); SendKeys.Flush(); });
            PressExclamationPoint = new RelayCommand(o => { AnimationWord("Comma"); SendKeys.SendWait("!"); SendKeys.Flush(); });
            PressQuestion = new RelayCommand(o => { AnimationWord("DownPoint"); SendKeys.SendWait("?"); SendKeys.Flush(); });
            #endregion
            PressBackSpace = new RelayCommand(o => { AnimationWord("BackSpace"); SendKeys.SendWait("{BACKSPACE}"); SendKeys.Flush(); });
            PressEnter = new RelayCommand(o => { AnimationWord("Enter"); SendKeys.SendWait("{ENTER}"); SendKeys.Flush(); });
            PressChangeKeyboardType = new RelayCommand(o =>
            {
                AnimationWord("ChangeKeyboard");
                switch (_keyboardLayout)
                {
                    case KeyboardLayouts.Text:
                        _keyboardLayout = KeyboardLayouts.Number;
                        KeyboardType = "ABC";
                        TextNumberKeyboardVisibility = "Visible";
                        TextKeyboardVisibility = "Collapsed";
                        break;
                    case KeyboardLayouts.Number:
                        _keyboardLayout = KeyboardLayouts.Text;
                        KeyboardType = "123";
                        TextNumberKeyboardVisibility = "Collapsed";
                        TextKeyboardVisibility = "Visible";
                        break;
                }
            });
            PressShift = new RelayCommand(o =>
            {
                if (!_shiftPressed)
                {
                    ShiftColorBackground = "White";
                    ShiftColorBorderBrush = "White";
                    TextÄ = "ä";
                    TextÜ = "ü";
                    TextÖ = "ö";
                    TextQ = "Q";
                    Textß = "ß";
                    TextW = "w";
                    TextE = "e";
                    TextR = "r";
                    TextT = "t";
                    TextY = "y";
                    TextU = "u";
                    TextI = "i";
                    TextO = "o";
                    TextP = "p";
                    TextA = "a";
                    TextS = "s";
                    TextD = "d";
                    TextF = "f";
                    TextG = "g";
                    TextH = "h";
                    TextJ = "j";
                    TextK = "k";
                    TextL = "l";
                    TextZ = "z";
                    TextX = "x";
                    TextC = "c";
                    TextV = "v";
                    TextB = "b";
                    TextN = "n";
                    TextM = "m";
                    TextComma = ",";
                    TextPoint = ".";
                }
                else
                {
                    ShiftColorBackground = "#FF36A1FF";
                    ShiftColorBorderBrush = "#FF167CD6";
                    TextÄ = "Ä";
                    TextÜ = "Ü";
                    TextÖ = "Ö";
                    TextQ = "Q";
                    Textß = "ß";
                    TextW = "W";
                    TextE = "E";
                    TextR = "R";
                    TextT = "T";
                    TextY = "Y";
                    TextU = "U";
                    TextI = "I";
                    TextO = "O";
                    TextP = "P";
                    TextA = "A";
                    TextS = "S";
                    TextD = "D";
                    TextF = "F";
                    TextG = "G";
                    TextH = "H";
                    TextJ = "J";
                    TextK = "K";
                    TextL = "L";
                    TextZ = "Z";
                    TextX = "X";
                    TextC = "C";
                    TextV = "V";
                    TextB = "B";
                    TextN = "N";                                      
                    TextM = "M";
                    TextComma = "<";
                    TextPoint = ">";                                  
                }
                _shiftPressed = !_shiftPressed;
            });
            PressSpace = new RelayCommand(o =>{ AnimationWord("Space"); PressKey(Keys.Space, false); });
            HideKeyboard = new RelayCommand(o => { AnimationWord("Hide"); App.Current.MainWindow.Hide(); });
        }


        #region VIRTUAL KEYBOARD OPEN/HIDE CONDITIONS
        /// <summary>
        /// Listener for localhost
        /// </summary>
        private static HttpListener _httpListener = new HttpListener();

        private bool EDITFIELD_FOUND = false;

        private int TOUCHINPUT_PROCID = 0;

        /// <summary>
        /// Coordinates of User Touch
        /// </summary>
        private int X, Y;

        /// <summary>
        /// Automation client who is getting information about current control element (On the cursor and focused element...)
        /// </summary>
        private CUIAutomation8 Automation;

        private IUIAutomationElement element, elementByTouch;

        /// <summary>
        /// Localhost thread
        /// </summary>
        private void ResponseThread()
        {
            while (true)
            {
                HttpListenerContext context = _httpListener.GetContext(); // get a context
                                                                          // Now, you'll find the request URL in context.Request.Url
                switch (context.Request.RawUrl)
                {
                    case "/coordinates":
                        using (var reader = new StreamReader(context.Request.InputStream))
                        {
                            OpenVirtualKeyboard(reader.ReadToEnd());
                        }
                        break;
                    case "/hidekeyboard":
                        App.Current.Dispatcher.Invoke(new Action(() => { App.Current.MainWindow.Hide(); MainWindow.numberKeyboardWindow.Hide(); }));
                        string responseStr = "Keyboard Hide";
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseStr);
                        context.Response.ContentLength64 = buffer.Length;
                        context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                        break;
                }
                context.Response.KeepAlive = false;
                context.Response.Close();
            }
        }

        private void OpenVirtualKeyboard(string message)
        {
            switch(message)
            {
                case "OPEN_TEXTKEYBOARD":
                    App.Current.Dispatcher.Invoke(new Action(() => { App.Current.MainWindow.Show(); MainWindow.numberKeyboardWindow.Hide(); }));
                    break;
                case "OPEN_NUMBERKEYBOARD":
                    App.Current.Dispatcher.Invoke(new Action(() => { App.Current.MainWindow.Hide(); MainWindow.numberKeyboardWindow.Show(); }));
                    break;
                case "HIDE":
                    App.Current.Dispatcher.Invoke(new Action(() => { App.Current.MainWindow.Hide(); MainWindow.numberKeyboardWindow.Hide(); }));
                    break;
            }
        }

        #endregion

    }
}