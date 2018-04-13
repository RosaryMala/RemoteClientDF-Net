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

}