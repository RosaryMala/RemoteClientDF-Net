using System;
// ReSharper disable InconsistentNaming

/*
    SDL - Simple DirectMedia Layer
    Copyright (C) 1997-2009 Sam Lantinga

    This library is free software; you can redistribute it and/or
    modify it under the terms of the GNU Lesser General Public
    License as published by the Free Software Foundation; either
    version 2.1 of the License, or (at your option) any later version.

    This library is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
    Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public
    License along with this library; if not, write to the Free Software
    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA

    Sam Lantinga
    slouken@libsdl.org
*/

// Fake - only structs. Shamelessly pilfered from the SDL library.
// Needed for processing its event types without polluting our namespaces with C garbage

namespace SDL
{
    /** What we really want is a mapping of every raw key on the keyboard.
     *  To support international keyboards, we use the range 0xA1 - 0xFF
     *  as international virtual keycodes.  We'll follow in the footsteps of X11...
     *  @brief The names of the keys
     */
    enum Key
    {
        /** @name ASCII mapped keysyms
         *  The keyboard syms have been cleverly chosen to map to ASCII
         */
        /*@{*/
        KUnknown = 0,
        KFirst = 0,
        KBackspace = 8,
        KTab = 9,
        KClear = 12,
        KReturn = 13,
        KPause = 19,
        KEscape = 27,
        KSpace = 32,
        KExclaim = 33,
        KQuotedbl = 34,
        KHash = 35,
        KDollar = 36,
        KAmpersand = 38,
        KQuote = 39,
        KLeftparen = 40,
        KRightparen = 41,
        KAsterisk = 42,
        KPlus = 43,
        KComma = 44,
        KMinus = 45,
        KPeriod = 46,
        KSlash = 47,
        K0 = 48,
        K1 = 49,
        K2 = 50,
        K3 = 51,
        K4 = 52,
        K5 = 53,
        K6 = 54,
        K7 = 55,
        K8 = 56,
        K9 = 57,
        KColon = 58,
        KSemicolon = 59,
        KLess = 60,
        KEquals = 61,
        KGreater = 62,
        KQuestion = 63,
        KAt = 64,
        /*
           Skip uppercase letters
         */
        KLeftbracket = 91,
        KBackslash = 92,
        KRightbracket = 93,
        KCaret = 94,
        KUnderscore = 95,
        KBackquote = 96,
        KA = 97,
        KB = 98,
        KC = 99,
        KD = 100,
        KE = 101,
        KF = 102,
        KG = 103,
        KH = 104,
        KI = 105,
        KJ = 106,
        KK = 107,
        KL = 108,
        KM = 109,
        KN = 110,
        KO = 111,
        KP = 112,
        KQ = 113,
        KR = 114,
        KS = 115,
        KT = 116,
        KU = 117,
        KV = 118,
        KW = 119,
        KX = 120,
        KY = 121,
        KZ = 122,
        KDelete = 127,
        /* End of ASCII mapped keysyms */
        /*@}*/

        /** @name International keyboard syms */
        /*@{*/
        KWorld0 = 160,      /* 0xA0 */
        KWorld1 = 161,
        KWorld2 = 162,
        KWorld3 = 163,
        KWorld4 = 164,
        KWorld5 = 165,
        KWorld6 = 166,
        KWorld7 = 167,
        KWorld8 = 168,
        KWorld9 = 169,
        KWorld10 = 170,
        KWorld11 = 171,
        KWorld12 = 172,
        KWorld13 = 173,
        KWorld14 = 174,
        KWorld15 = 175,
        KWorld16 = 176,
        KWorld17 = 177,
        KWorld18 = 178,
        KWorld19 = 179,
        KWorld20 = 180,
        KWorld21 = 181,
        KWorld22 = 182,
        KWorld23 = 183,
        KWorld24 = 184,
        KWorld25 = 185,
        KWorld26 = 186,
        KWorld27 = 187,
        KWorld28 = 188,
        KWorld29 = 189,
        KWorld30 = 190,
        KWorld31 = 191,
        KWorld32 = 192,
        KWorld33 = 193,
        KWorld34 = 194,
        KWorld35 = 195,
        KWorld36 = 196,
        KWorld37 = 197,
        KWorld38 = 198,
        KWorld39 = 199,
        KWorld40 = 200,
        KWorld41 = 201,
        KWorld42 = 202,
        KWorld43 = 203,
        KWorld44 = 204,
        KWorld45 = 205,
        KWorld46 = 206,
        KWorld47 = 207,
        KWorld48 = 208,
        KWorld49 = 209,
        KWorld50 = 210,
        KWorld51 = 211,
        KWorld52 = 212,
        KWorld53 = 213,
        KWorld54 = 214,
        KWorld55 = 215,
        KWorld56 = 216,
        KWorld57 = 217,
        KWorld58 = 218,
        KWorld59 = 219,
        KWorld60 = 220,
        KWorld61 = 221,
        KWorld62 = 222,
        KWorld63 = 223,
        KWorld64 = 224,
        KWorld65 = 225,
        KWorld66 = 226,
        KWorld67 = 227,
        KWorld68 = 228,
        KWorld69 = 229,
        KWorld70 = 230,
        KWorld71 = 231,
        KWorld72 = 232,
        KWorld73 = 233,
        KWorld74 = 234,
        KWorld75 = 235,
        KWorld76 = 236,
        KWorld77 = 237,
        KWorld78 = 238,
        KWorld79 = 239,
        KWorld80 = 240,
        KWorld81 = 241,
        KWorld82 = 242,
        KWorld83 = 243,
        KWorld84 = 244,
        KWorld85 = 245,
        KWorld86 = 246,
        KWorld87 = 247,
        KWorld88 = 248,
        KWorld89 = 249,
        KWorld90 = 250,
        KWorld91 = 251,
        KWorld92 = 252,
        KWorld93 = 253,
        KWorld94 = 254,
        KWorld95 = 255,      /* 0xFF */
        /*@}*/

        /** @name Numeric keypad */
        /*@{*/
        KKp0 = 256,
        KKp1 = 257,
        KKp2 = 258,
        KKp3 = 259,
        KKp4 = 260,
        KKp5 = 261,
        KKp6 = 262,
        KKp7 = 263,
        KKp8 = 264,
        KKp9 = 265,
        KKpPeriod = 266,
        KKpDivide = 267,
        KKpMultiply = 268,
        KKpMinus = 269,
        KKpPlus = 270,
        KKpEnter = 271,
        KKpEquals = 272,
        /*@}*/

        /** @name Arrows + Home/End pad */
        /*@{*/
        KUp = 273,
        KDown = 274,
        KRight = 275,
        KLeft = 276,
        KInsert = 277,
        KHome = 278,
        KEnd = 279,
        KPageup = 280,
        KPagedown = 281,
        /*@}*/

        /** @name Function keys */
        /*@{*/
        KF1 = 282,
        KF2 = 283,
        KF3 = 284,
        KF4 = 285,
        KF5 = 286,
        KF6 = 287,
        KF7 = 288,
        KF8 = 289,
        KF9 = 290,
        KF10 = 291,
        KF11 = 292,
        KF12 = 293,
        KF13 = 294,
        KF14 = 295,
        KF15 = 296,
        /*@}*/

        /** @name Key state modifier keys */
        /*@{*/
        KNumlock = 300,
        KCapslock = 301,
        KScrollock = 302,
        KRshift = 303,
        KLshift = 304,
        KRctrl = 305,
        KLctrl = 306,
        KRalt = 307,
        KLalt = 308,
        KRmeta = 309,
        KLmeta = 310,
        KLsuper = 311,      /**< Left "Windows" key */
        KRsuper = 312,      /**< Right "Windows" key */
        KMode = 313,      /**< "Alt Gr" key */
        KCompose = 314,      /**< Multi-key compose key */
        /*@}*/

        /** @name Miscellaneous function keys */
        /*@{*/
        KHelp = 315,
        KPrint = 316,
        KSysreq = 317,
        KBreak = 318,
        KMenu = 319,
        KPower = 320,      /**< Power Macintosh power key */
        KEuro = 321,      /**< Some european keyboards */
        KUndo = 322,      /**< Atari keyboard has Undo */
        /*@}*/

        /* Add any other keys here */

        KLast
    };

    /** Enumeration of valid key mods (possibly OR'd together) */
    [Flags]
    enum Mod
    {
        KmodNone = 0x0000,
        KmodLshift = 0x0001,
        KmodRshift = 0x0002,
        KmodLctrl = 0x0040,
        KmodRctrl = 0x0080,
        KmodLalt = 0x0100,
        KmodRalt = 0x0200,
        KmodLmeta = 0x0400,
        KmodRmeta = 0x0800,
        KmodNum = 0x1000,
        KmodCaps = 0x2000,
        KmodMode = 0x4000,
        KmodReserved = 0x8000,
        KmodCtrl = (KmodLctrl | KmodRctrl),
        KmodShift = (KmodLshift | KmodRshift),
        KmodAlt = (KmodLalt | KmodRalt),
        KmodMeta = (KmodLmeta | KmodRmeta)
    };

    public class SdlKeycodes
    {
        static Key ConvertKeycode(UnityEngine.KeyCode inputCode)
        {
            switch (inputCode)
            {
                case UnityEngine.KeyCode.None:
                    return Key.KUnknown;
                case UnityEngine.KeyCode.Backspace:
                    return Key.KBackspace;
                case UnityEngine.KeyCode.Delete:
                    return Key.KDelete;
                case UnityEngine.KeyCode.Tab:
                    return Key.KTab;
                case UnityEngine.KeyCode.Clear:
                    return Key.KUnknown;
                case UnityEngine.KeyCode.Return:
                    return Key.KReturn;
                case UnityEngine.KeyCode.Pause:
                    return Key.KPause;
                case UnityEngine.KeyCode.Escape:
                    return Key.KEscape;
                case UnityEngine.KeyCode.Space:
                    return Key.KSpace;
                case UnityEngine.KeyCode.Keypad0:
                    return Key.KKp0;
                case UnityEngine.KeyCode.Keypad1:
                    return Key.KKp1;
                case UnityEngine.KeyCode.Keypad2:
                    return Key.KKp2;
                case UnityEngine.KeyCode.Keypad3:
                    return Key.KKp3;
                case UnityEngine.KeyCode.Keypad4:
                    return Key.KKp4;
                case UnityEngine.KeyCode.Keypad5:
                    return Key.KKp5;
                case UnityEngine.KeyCode.Keypad6:
                    return Key.KKp6;
                case UnityEngine.KeyCode.Keypad7:
                    return Key.KKp7;
                case UnityEngine.KeyCode.Keypad8:
                    return Key.KKp8;
                case UnityEngine.KeyCode.Keypad9:
                    return Key.KKp9;
                case UnityEngine.KeyCode.KeypadPeriod:
                    return Key.KKpPeriod;
                case UnityEngine.KeyCode.KeypadDivide:
                    return Key.KKpDivide;
                case UnityEngine.KeyCode.KeypadMultiply:
                    return Key.KKpMultiply;
                case UnityEngine.KeyCode.KeypadMinus:
                    return Key.KKpMinus;
                case UnityEngine.KeyCode.KeypadPlus:
                    return Key.KKpPlus;
                case UnityEngine.KeyCode.KeypadEnter:
                    return Key.KKpEnter;
                case UnityEngine.KeyCode.KeypadEquals:
                    return Key.KKpEquals;
                case UnityEngine.KeyCode.UpArrow:
                    return Key.KUp;
                case UnityEngine.KeyCode.DownArrow:
                    return Key.KDown;
                case UnityEngine.KeyCode.RightArrow:
                    return Key.KRight;
                case UnityEngine.KeyCode.LeftArrow:
                    return Key.KLeft;
                case UnityEngine.KeyCode.Insert:
                    return Key.KInsert;
                case UnityEngine.KeyCode.Home:
                    return Key.KHome;
                case UnityEngine.KeyCode.End:
                    return Key.KEnd;
                case UnityEngine.KeyCode.PageUp:
                    return Key.KPageup;
                case UnityEngine.KeyCode.PageDown:
                    return Key.KPagedown;
                case UnityEngine.KeyCode.F1:
                    return Key.KF1;
                case UnityEngine.KeyCode.F2:
                    return Key.KF2;
                case UnityEngine.KeyCode.F3:
                    return Key.KF3;
                case UnityEngine.KeyCode.F4:
                    return Key.KF4;
                case UnityEngine.KeyCode.F5:
                    return Key.KF5;
                case UnityEngine.KeyCode.F6:
                    return Key.KF6;
                case UnityEngine.KeyCode.F7:
                    return Key.KF7;
                case UnityEngine.KeyCode.F8:
                    return Key.KF8;
                case UnityEngine.KeyCode.F9:
                    return Key.KF9;
                case UnityEngine.KeyCode.F10:
                    return Key.KF10;
                case UnityEngine.KeyCode.F11:
                    return Key.KF11;
                case UnityEngine.KeyCode.F12:
                    return Key.KF12;
                case UnityEngine.KeyCode.F13:
                    return Key.KF13;
                case UnityEngine.KeyCode.F14:
                    return Key.KF14;
                case UnityEngine.KeyCode.F15:
                    return Key.KF15;
                case UnityEngine.KeyCode.Alpha0:
                    return Key.K0;
                case UnityEngine.KeyCode.Alpha1:
                    return Key.K1;
                case UnityEngine.KeyCode.Alpha2:
                    break;
                case UnityEngine.KeyCode.Alpha3:
                    break;
                case UnityEngine.KeyCode.Alpha4:
                    break;
                case UnityEngine.KeyCode.Alpha5:
                    break;
                case UnityEngine.KeyCode.Alpha6:
                    break;
                case UnityEngine.KeyCode.Alpha7:
                    break;
                case UnityEngine.KeyCode.Alpha8:
                    break;
                case UnityEngine.KeyCode.Alpha9:
                    break;
                case UnityEngine.KeyCode.Exclaim:
                    break;
                case UnityEngine.KeyCode.DoubleQuote:
                    break;
                case UnityEngine.KeyCode.Hash:
                    break;
                case UnityEngine.KeyCode.Dollar:
                    break;
                case UnityEngine.KeyCode.Ampersand:
                    break;
                case UnityEngine.KeyCode.Quote:
                    break;
                case UnityEngine.KeyCode.LeftParen:
                    break;
                case UnityEngine.KeyCode.RightParen:
                    break;
                case UnityEngine.KeyCode.Asterisk:
                    break;
                case UnityEngine.KeyCode.Plus:
                    break;
                case UnityEngine.KeyCode.Comma:
                    break;
                case UnityEngine.KeyCode.Minus:
                    break;
                case UnityEngine.KeyCode.Period:
                    break;
                case UnityEngine.KeyCode.Slash:
                    break;
                case UnityEngine.KeyCode.Colon:
                    break;
                case UnityEngine.KeyCode.Semicolon:
                    break;
                case UnityEngine.KeyCode.Less:
                    break;
                case UnityEngine.KeyCode.Equals:
                    break;
                case UnityEngine.KeyCode.Greater:
                    break;
                case UnityEngine.KeyCode.Question:
                    break;
                case UnityEngine.KeyCode.At:
                    break;
                case UnityEngine.KeyCode.LeftBracket:
                    break;
                case UnityEngine.KeyCode.Backslash:
                    break;
                case UnityEngine.KeyCode.RightBracket:
                    break;
                case UnityEngine.KeyCode.Caret:
                    break;
                case UnityEngine.KeyCode.Underscore:
                    break;
                case UnityEngine.KeyCode.BackQuote:
                    break;
                case UnityEngine.KeyCode.A:
                    break;
                case UnityEngine.KeyCode.B:
                    break;
                case UnityEngine.KeyCode.C:
                    break;
                case UnityEngine.KeyCode.D:
                    break;
                case UnityEngine.KeyCode.E:
                    break;
                case UnityEngine.KeyCode.F:
                    break;
                case UnityEngine.KeyCode.G:
                    break;
                case UnityEngine.KeyCode.H:
                    break;
                case UnityEngine.KeyCode.I:
                    break;
                case UnityEngine.KeyCode.J:
                    break;
                case UnityEngine.KeyCode.K:
                    break;
                case UnityEngine.KeyCode.L:
                    break;
                case UnityEngine.KeyCode.M:
                    break;
                case UnityEngine.KeyCode.N:
                    break;
                case UnityEngine.KeyCode.O:
                    break;
                case UnityEngine.KeyCode.P:
                    break;
                case UnityEngine.KeyCode.Q:
                    break;
                case UnityEngine.KeyCode.R:
                    break;
                case UnityEngine.KeyCode.S:
                    break;
                case UnityEngine.KeyCode.T:
                    break;
                case UnityEngine.KeyCode.U:
                    break;
                case UnityEngine.KeyCode.V:
                    break;
                case UnityEngine.KeyCode.W:
                    break;
                case UnityEngine.KeyCode.X:
                    break;
                case UnityEngine.KeyCode.Y:
                    break;
                case UnityEngine.KeyCode.Z:
                    break;
                case UnityEngine.KeyCode.Numlock:
                    break;
                case UnityEngine.KeyCode.CapsLock:
                    break;
                case UnityEngine.KeyCode.ScrollLock:
                    break;
                case UnityEngine.KeyCode.RightShift:
                    break;
                case UnityEngine.KeyCode.LeftShift:
                    break;
                case UnityEngine.KeyCode.RightControl:
                    break;
                case UnityEngine.KeyCode.LeftControl:
                    break;
                case UnityEngine.KeyCode.RightAlt:
                    break;
                case UnityEngine.KeyCode.LeftAlt:
                    break;
                case UnityEngine.KeyCode.LeftCommand:
                    break;
                case UnityEngine.KeyCode.LeftWindows:
                    break;
                case UnityEngine.KeyCode.RightCommand:
                    break;
                case UnityEngine.KeyCode.RightWindows:
                    break;
                case UnityEngine.KeyCode.AltGr:
                    break;
                case UnityEngine.KeyCode.Help:
                    break;
                case UnityEngine.KeyCode.Print:
                    break;
                case UnityEngine.KeyCode.SysReq:
                    break;
                case UnityEngine.KeyCode.Break:
                    break;
                case UnityEngine.KeyCode.Menu:
                    break;
                case UnityEngine.KeyCode.Mouse0:
                    break;
                case UnityEngine.KeyCode.Mouse1:
                    break;
                case UnityEngine.KeyCode.Mouse2:
                    break;
                case UnityEngine.KeyCode.Mouse3:
                    break;
                case UnityEngine.KeyCode.Mouse4:
                    break;
                case UnityEngine.KeyCode.Mouse5:
                    break;
                case UnityEngine.KeyCode.Mouse6:
                    break;
                case UnityEngine.KeyCode.JoystickButton0:
                    break;
                case UnityEngine.KeyCode.JoystickButton1:
                    break;
                case UnityEngine.KeyCode.JoystickButton2:
                    break;
                case UnityEngine.KeyCode.JoystickButton3:
                    break;
                case UnityEngine.KeyCode.JoystickButton4:
                    break;
                case UnityEngine.KeyCode.JoystickButton5:
                    break;
                case UnityEngine.KeyCode.JoystickButton6:
                    break;
                case UnityEngine.KeyCode.JoystickButton7:
                    break;
                case UnityEngine.KeyCode.JoystickButton8:
                    break;
                case UnityEngine.KeyCode.JoystickButton9:
                    break;
                case UnityEngine.KeyCode.JoystickButton10:
                    break;
                case UnityEngine.KeyCode.JoystickButton11:
                    break;
                case UnityEngine.KeyCode.JoystickButton12:
                    break;
                case UnityEngine.KeyCode.JoystickButton13:
                    break;
                case UnityEngine.KeyCode.JoystickButton14:
                    break;
                case UnityEngine.KeyCode.JoystickButton15:
                    break;
                case UnityEngine.KeyCode.JoystickButton16:
                    break;
                case UnityEngine.KeyCode.JoystickButton17:
                    break;
                case UnityEngine.KeyCode.JoystickButton18:
                    break;
                case UnityEngine.KeyCode.JoystickButton19:
                    break;
                case UnityEngine.KeyCode.Joystick1Button0:
                    break;
                case UnityEngine.KeyCode.Joystick1Button1:
                    break;
                case UnityEngine.KeyCode.Joystick1Button2:
                    break;
                case UnityEngine.KeyCode.Joystick1Button3:
                    break;
                case UnityEngine.KeyCode.Joystick1Button4:
                    break;
                case UnityEngine.KeyCode.Joystick1Button5:
                    break;
                case UnityEngine.KeyCode.Joystick1Button6:
                    break;
                case UnityEngine.KeyCode.Joystick1Button7:
                    break;
                case UnityEngine.KeyCode.Joystick1Button8:
                    break;
                case UnityEngine.KeyCode.Joystick1Button9:
                    break;
                case UnityEngine.KeyCode.Joystick1Button10:
                    break;
                case UnityEngine.KeyCode.Joystick1Button11:
                    break;
                case UnityEngine.KeyCode.Joystick1Button12:
                    break;
                case UnityEngine.KeyCode.Joystick1Button13:
                    break;
                case UnityEngine.KeyCode.Joystick1Button14:
                    break;
                case UnityEngine.KeyCode.Joystick1Button15:
                    break;
                case UnityEngine.KeyCode.Joystick1Button16:
                    break;
                case UnityEngine.KeyCode.Joystick1Button17:
                    break;
                case UnityEngine.KeyCode.Joystick1Button18:
                    break;
                case UnityEngine.KeyCode.Joystick1Button19:
                    break;
                case UnityEngine.KeyCode.Joystick2Button0:
                    break;
                case UnityEngine.KeyCode.Joystick2Button1:
                    break;
                case UnityEngine.KeyCode.Joystick2Button2:
                    break;
                case UnityEngine.KeyCode.Joystick2Button3:
                    break;
                case UnityEngine.KeyCode.Joystick2Button4:
                    break;
                case UnityEngine.KeyCode.Joystick2Button5:
                    break;
                case UnityEngine.KeyCode.Joystick2Button6:
                    break;
                case UnityEngine.KeyCode.Joystick2Button7:
                    break;
                case UnityEngine.KeyCode.Joystick2Button8:
                    break;
                case UnityEngine.KeyCode.Joystick2Button9:
                    break;
                case UnityEngine.KeyCode.Joystick2Button10:
                    break;
                case UnityEngine.KeyCode.Joystick2Button11:
                    break;
                case UnityEngine.KeyCode.Joystick2Button12:
                    break;
                case UnityEngine.KeyCode.Joystick2Button13:
                    break;
                case UnityEngine.KeyCode.Joystick2Button14:
                    break;
                case UnityEngine.KeyCode.Joystick2Button15:
                    break;
                case UnityEngine.KeyCode.Joystick2Button16:
                    break;
                case UnityEngine.KeyCode.Joystick2Button17:
                    break;
                case UnityEngine.KeyCode.Joystick2Button18:
                    break;
                case UnityEngine.KeyCode.Joystick2Button19:
                    break;
                case UnityEngine.KeyCode.Joystick3Button0:
                    break;
                case UnityEngine.KeyCode.Joystick3Button1:
                    break;
                case UnityEngine.KeyCode.Joystick3Button2:
                    break;
                case UnityEngine.KeyCode.Joystick3Button3:
                    break;
                case UnityEngine.KeyCode.Joystick3Button4:
                    break;
                case UnityEngine.KeyCode.Joystick3Button5:
                    break;
                case UnityEngine.KeyCode.Joystick3Button6:
                    break;
                case UnityEngine.KeyCode.Joystick3Button7:
                    break;
                case UnityEngine.KeyCode.Joystick3Button8:
                    break;
                case UnityEngine.KeyCode.Joystick3Button9:
                    break;
                case UnityEngine.KeyCode.Joystick3Button10:
                    break;
                case UnityEngine.KeyCode.Joystick3Button11:
                    break;
                case UnityEngine.KeyCode.Joystick3Button12:
                    break;
                case UnityEngine.KeyCode.Joystick3Button13:
                    break;
                case UnityEngine.KeyCode.Joystick3Button14:
                    break;
                case UnityEngine.KeyCode.Joystick3Button15:
                    break;
                case UnityEngine.KeyCode.Joystick3Button16:
                    break;
                case UnityEngine.KeyCode.Joystick3Button17:
                    break;
                case UnityEngine.KeyCode.Joystick3Button18:
                    break;
                case UnityEngine.KeyCode.Joystick3Button19:
                    break;
                case UnityEngine.KeyCode.Joystick4Button0:
                    break;
                case UnityEngine.KeyCode.Joystick4Button1:
                    break;
                case UnityEngine.KeyCode.Joystick4Button2:
                    break;
                case UnityEngine.KeyCode.Joystick4Button3:
                    break;
                case UnityEngine.KeyCode.Joystick4Button4:
                    break;
                case UnityEngine.KeyCode.Joystick4Button5:
                    break;
                case UnityEngine.KeyCode.Joystick4Button6:
                    break;
                case UnityEngine.KeyCode.Joystick4Button7:
                    break;
                case UnityEngine.KeyCode.Joystick4Button8:
                    break;
                case UnityEngine.KeyCode.Joystick4Button9:
                    break;
                case UnityEngine.KeyCode.Joystick4Button10:
                    break;
                case UnityEngine.KeyCode.Joystick4Button11:
                    break;
                case UnityEngine.KeyCode.Joystick4Button12:
                    break;
                case UnityEngine.KeyCode.Joystick4Button13:
                    break;
                case UnityEngine.KeyCode.Joystick4Button14:
                    break;
                case UnityEngine.KeyCode.Joystick4Button15:
                    break;
                case UnityEngine.KeyCode.Joystick4Button16:
                    break;
                case UnityEngine.KeyCode.Joystick4Button17:
                    break;
                case UnityEngine.KeyCode.Joystick4Button18:
                    break;
                case UnityEngine.KeyCode.Joystick4Button19:
                    break;
                case UnityEngine.KeyCode.Joystick5Button0:
                    break;
                case UnityEngine.KeyCode.Joystick5Button1:
                    break;
                case UnityEngine.KeyCode.Joystick5Button2:
                    break;
                case UnityEngine.KeyCode.Joystick5Button3:
                    break;
                case UnityEngine.KeyCode.Joystick5Button4:
                    break;
                case UnityEngine.KeyCode.Joystick5Button5:
                    break;
                case UnityEngine.KeyCode.Joystick5Button6:
                    break;
                case UnityEngine.KeyCode.Joystick5Button7:
                    break;
                case UnityEngine.KeyCode.Joystick5Button8:
                    break;
                case UnityEngine.KeyCode.Joystick5Button9:
                    break;
                case UnityEngine.KeyCode.Joystick5Button10:
                    break;
                case UnityEngine.KeyCode.Joystick5Button11:
                    break;
                case UnityEngine.KeyCode.Joystick5Button12:
                    break;
                case UnityEngine.KeyCode.Joystick5Button13:
                    break;
                case UnityEngine.KeyCode.Joystick5Button14:
                    break;
                case UnityEngine.KeyCode.Joystick5Button15:
                    break;
                case UnityEngine.KeyCode.Joystick5Button16:
                    break;
                case UnityEngine.KeyCode.Joystick5Button17:
                    break;
                case UnityEngine.KeyCode.Joystick5Button18:
                    break;
                case UnityEngine.KeyCode.Joystick5Button19:
                    break;
                case UnityEngine.KeyCode.Joystick6Button0:
                    break;
                case UnityEngine.KeyCode.Joystick6Button1:
                    break;
                case UnityEngine.KeyCode.Joystick6Button2:
                    break;
                case UnityEngine.KeyCode.Joystick6Button3:
                    break;
                case UnityEngine.KeyCode.Joystick6Button4:
                    break;
                case UnityEngine.KeyCode.Joystick6Button5:
                    break;
                case UnityEngine.KeyCode.Joystick6Button6:
                    break;
                case UnityEngine.KeyCode.Joystick6Button7:
                    break;
                case UnityEngine.KeyCode.Joystick6Button8:
                    break;
                case UnityEngine.KeyCode.Joystick6Button9:
                    break;
                case UnityEngine.KeyCode.Joystick6Button10:
                    break;
                case UnityEngine.KeyCode.Joystick6Button11:
                    break;
                case UnityEngine.KeyCode.Joystick6Button12:
                    break;
                case UnityEngine.KeyCode.Joystick6Button13:
                    break;
                case UnityEngine.KeyCode.Joystick6Button14:
                    break;
                case UnityEngine.KeyCode.Joystick6Button15:
                    break;
                case UnityEngine.KeyCode.Joystick6Button16:
                    break;
                case UnityEngine.KeyCode.Joystick6Button17:
                    break;
                case UnityEngine.KeyCode.Joystick6Button18:
                    break;
                case UnityEngine.KeyCode.Joystick6Button19:
                    break;
                case UnityEngine.KeyCode.Joystick7Button0:
                    break;
                case UnityEngine.KeyCode.Joystick7Button1:
                    break;
                case UnityEngine.KeyCode.Joystick7Button2:
                    break;
                case UnityEngine.KeyCode.Joystick7Button3:
                    break;
                case UnityEngine.KeyCode.Joystick7Button4:
                    break;
                case UnityEngine.KeyCode.Joystick7Button5:
                    break;
                case UnityEngine.KeyCode.Joystick7Button6:
                    break;
                case UnityEngine.KeyCode.Joystick7Button7:
                    break;
                case UnityEngine.KeyCode.Joystick7Button8:
                    break;
                case UnityEngine.KeyCode.Joystick7Button9:
                    break;
                case UnityEngine.KeyCode.Joystick7Button10:
                    break;
                case UnityEngine.KeyCode.Joystick7Button11:
                    break;
                case UnityEngine.KeyCode.Joystick7Button12:
                    break;
                case UnityEngine.KeyCode.Joystick7Button13:
                    break;
                case UnityEngine.KeyCode.Joystick7Button14:
                    break;
                case UnityEngine.KeyCode.Joystick7Button15:
                    break;
                case UnityEngine.KeyCode.Joystick7Button16:
                    break;
                case UnityEngine.KeyCode.Joystick7Button17:
                    break;
                case UnityEngine.KeyCode.Joystick7Button18:
                    break;
                case UnityEngine.KeyCode.Joystick7Button19:
                    break;
                case UnityEngine.KeyCode.Joystick8Button0:
                    break;
                case UnityEngine.KeyCode.Joystick8Button1:
                    break;
                case UnityEngine.KeyCode.Joystick8Button2:
                    break;
                case UnityEngine.KeyCode.Joystick8Button3:
                    break;
                case UnityEngine.KeyCode.Joystick8Button4:
                    break;
                case UnityEngine.KeyCode.Joystick8Button5:
                    break;
                case UnityEngine.KeyCode.Joystick8Button6:
                    break;
                case UnityEngine.KeyCode.Joystick8Button7:
                    break;
                case UnityEngine.KeyCode.Joystick8Button8:
                    break;
                case UnityEngine.KeyCode.Joystick8Button9:
                    break;
                case UnityEngine.KeyCode.Joystick8Button10:
                    break;
                case UnityEngine.KeyCode.Joystick8Button11:
                    break;
                case UnityEngine.KeyCode.Joystick8Button12:
                    break;
                case UnityEngine.KeyCode.Joystick8Button13:
                    break;
                case UnityEngine.KeyCode.Joystick8Button14:
                    break;
                case UnityEngine.KeyCode.Joystick8Button15:
                    break;
                case UnityEngine.KeyCode.Joystick8Button16:
                    break;
                case UnityEngine.KeyCode.Joystick8Button17:
                    break;
                case UnityEngine.KeyCode.Joystick8Button18:
                    break;
                case UnityEngine.KeyCode.Joystick8Button19:
                    break;
                default:
                    return Key.KUnknown;
            }
            return Key.KUnknown;
        }
    }
}