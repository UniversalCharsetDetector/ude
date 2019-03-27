﻿/* ***** BEGIN LICENSE BLOCK *****
 * Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Mozilla Communicator client code.
 *
 * The Initial Developer of the Original Code is
 * Netscape Communications Corporation.
 * Portions created by the Initial Developer are Copyright (C) 1998
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 *
 * ***** END LICENSE BLOCK ***** */

/*
* The following part was imported from https://gitlab.freedesktop.org/uchardet/uchardet
* The implementation of this feature was originally done on https://gitlab.freedesktop.org/uchardet/uchardet/blob/master/src/LangModels/LangArabicModel.cpp
* and adjusted to language specific support.
*/

namespace UtfUnknown.Core.Models.SingleByte.Arabic
{
    public class Iso_8859_6_ArabicModel : ArabicModel
    {
        // Generated by BuildLangModel.py
        // On: 2015-12-13 18:33:58.848027

        // Character Mapping Table:
        // ILL: illegal character.
        // CTR: control character specific to the charset.
        // RET: carriage/return.
        // SYM: symbol (punctuation) that does not belong to word.
        // NUM: 0 - 9.

        // Other characters are ordered by probabilities
        // (0 is the most common character in the language).

        // Orders are generic to a language. So the codepoint with order X in
        // CHARSET1 maps to the same character as the codepoint with the same
        // order X in CHARSET2 for the same language.
        // As such, it is possible to get missing order. For instance the
        // ligature of 'o' and 'e' exists in ISO-8859-15 but not in ISO-8859-1
        // even though they are both used for French. Same for the euro sign.

        private static byte[] CHAR_TO_ORDER_MAP = {
          CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,RET,CTR,CTR,RET,CTR,CTR, /* 0X */
          CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR, /* 1X */
          SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM, /* 2X */
          NUM,NUM,NUM,NUM,NUM,NUM,NUM,NUM,NUM,NUM,SYM,SYM,SYM,SYM,SYM,SYM, /* 3X */
          SYM, 52, 72, 61, 68, 74, 69, 59, 78, 60, 90, 86, 67, 65, 71, 75, /* 4X */
           64, 85, 76, 55, 57, 79, 81, 70, 82, 87, 91,SYM,SYM,SYM,SYM,SYM, /* 5X */
          SYM, 37, 58, 49, 47, 38, 54, 66, 46, 39, 88, 63, 45, 51, 43, 40, /* 6X */
           62, 89, 42, 44, 41, 50, 77, 73, 83, 56, 80,SYM,SYM,SYM,SYM,CTR, /* 7X */
          CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR, /* 8X */
          CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR,CTR, /* 9X */
          SYM,ILL,ILL,ILL,SYM,ILL,ILL,ILL,ILL,ILL,ILL,ILL,SYM,SYM,ILL,ILL, /* AX */
          ILL,ILL,ILL,ILL,ILL,ILL,ILL,ILL,ILL,ILL,ILL,SYM,ILL,ILL,ILL,SYM, /* BX */
          ILL, 32, 34, 15, 35, 22, 31,  0,  9,  8,  7, 27, 19, 18, 25, 11, /* CX */
           30,  5, 26, 12, 21, 23, 28,SYM, 33, 10, 29,ILL,ILL,ILL,ILL,ILL, /* DX */
           36, 13, 14, 17,  1,  3,  6, 16,  4, 24,  2,SYM,SYM,SYM,SYM,SYM, /* EX */
          SYM,SYM,SYM,ILL,ILL,ILL,ILL,ILL,ILL,ILL,ILL,ILL,ILL,ILL,ILL,ILL, /* FX */
        };
        /*X0  X1  X2  X3  X4  X5  X6  X7  X8  X9  XA  XB  XC  XD  XE  XF */

        public Iso_8859_6_ArabicModel() : base(CHAR_TO_ORDER_MAP, "ISO-8859-6")
        {
        }
    }
}
