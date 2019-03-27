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
* The implementation of this feature was originally done on https://gitlab.freedesktop.org/uchardet/uchardet/blob/master/src/LangModels/LangPolishModel.cpp
* and adjusted to language specific support.
*/

namespace UtfUnknown.Core.Models.SingleByte.Polish
{
    public class Ibm852_PolishModel : PolishModel
    {
        // Generated by BuildLangModel.py
        // On: 2016-09-21 17:21:04.405363

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
          SYM,  0, 20, 11, 14,  3, 26, 21, 22,  1, 18,  7, 15, 16,  5,  2, /* 4X */
           13, 36,  4,  6, 10, 17, 31,  9, 33, 12,  8,SYM,SYM,SYM,SYM,SYM, /* 5X */
          SYM,  0, 20, 11, 14,  3, 26, 21, 22,  1, 18,  7, 15, 16,  5,  2, /* 6X */
           13, 36,  4,  6, 10, 17, 31,  9, 33, 12,  8,SYM,SYM,SYM,SYM,CTR, /* 7X */
           47, 39, 34, 54, 40, 78, 30, 47, 19, 58, 49, 49, 77, 32, 40, 30, /* 8X */
           34, 79, 80, 55, 38, 74, 74, 28, 28, 38, 39, 76, 76, 19,SYM, 44, /* 9X */
           35, 37, 24, 51, 25, 25, 45, 45, 23, 23,SYM, 32, 44, 56,SYM,SYM, /* AX */
          SYM,SYM,SYM,SYM,SYM, 35, 54, 46, 56,SYM,SYM,SYM,SYM, 27, 27,SYM, /* BX */
          SYM,SYM,SYM,SYM,SYM,SYM, 53, 53,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM, /* CX */
           70, 70, 69, 58, 69, 81, 37, 77, 46,SYM,SYM,SYM,SYM, 65, 82,SYM, /* DX */
           24, 57, 55, 29, 29, 83, 41, 41, 84, 51, 85, 86, 60, 60, 65,SYM, /* EX */
          SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM,SYM, 87, 50, 50,SYM,SYM, /* FX */
        };
        /*X0  X1  X2  X3  X4  X5  X6  X7  X8  X9  XA  XB  XC  XD  XE  XF */

        public Ibm852_PolishModel() : base(CHAR_TO_ORDER_MAP, "IBM852")
        {
        }
    }
}
