﻿using System.IO;

// Sonic '06 Mod Manager is licensed under the MIT License:
/*
 * MIT License

 * Copyright (c) 2020 Knuxfan24 & HyperPolygon64

 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:

 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.

 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

namespace Unify.Serialisers
{
    class INI
    {
        /// <summary>
        /// If the specified key is found in the specified INI, return its value as a string. If it's not found, return N/A.
        /// </summary>
        public static string DeserialiseKey(string key, string ini) {
            string line, entryValue = string.Empty;

            using (StreamReader configFile = new StreamReader(ini))
                try {
                    while ((line = configFile.ReadLine()) != null) {
                        if (line.StartsWith(key)) {
                            entryValue = line.Substring(line.IndexOf("=") + 2);
                            entryValue = entryValue.Remove(entryValue.Length - 1);
                        }
                    }
                } catch { }

            return entryValue;
        }
    }
}
