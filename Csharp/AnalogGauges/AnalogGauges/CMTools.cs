using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace AnalogGauges
{
    class CMTools
    {
        public static string[] GetCommPortList()
        {
            string[] temp = SerialPort.GetPortNames();
            Array.Sort(temp);
            return temp;
        }

        public static string[] GetCNCRouterPorts()
        {
            List<string> results = new List<string>();
            string[] temp = SerialPort.GetPortNames();
            Array.Sort(temp);
            // "Ping" each port and save the ones that "Acknowledge" 
            //    w/ a supported FW version to the "results" list.

            return temp;
        }

        #region General Tools

        public static byte getByteFromPercent(int percentage)
        {
            if (percentage < 1)
                percentage = 1;
            return (byte)(((percentage / 100.0) * 64.0) - 1.0);
        }

        /// <summary>
        /// Creates a byte array from the hexadecimal string. Each two characters are combined
        /// to create one byte. First two hexadecimal characters become first byte in returned array.
        /// Non-hexadecimal characters are ignored. 
        /// </summary>
        /// <param name="hexString">string to convert to byte array</param>
        /// <param name="discarded">number of characters in string ignored</param>
        /// <returns>byte array, in the same left-to-right order as the hexString</returns>
        public static byte[] GetBytes(string hexString, out int discarded)
        {
            discarded = 0;
            string newString = "";
            char c;
            // remove all none A-F, 0-9, characters
            for (int i = 0; i < hexString.Length; i++)
            {
                c = hexString[i];
                if (IsHexDigit(c))
                    newString += c;
                else
                    discarded++;
            }
            // if odd number of characters, pad start with a 0
            if (newString.Length % 2 != 0)
            {
                newString = "0" + newString;
            }

            int byteLength = newString.Length / 2;
            byte[] bytes = new byte[byteLength];
            string hex;
            int j = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                hex = new String(new Char[] { newString[j], newString[j + 1] });
                bytes[i] = HexToByte(hex);
                j = j + 2;
            }
            return bytes;
        }

        /// <summary>
        /// Converts a byte array to a hex string.
        /// </summary>
        /// <param name="bytes">Array of bytes to convert.</param>
        /// <returns>String of 0-9, A-F characters representing a Hex number.</returns>
        public static string BytesToHex(byte[] bytes)
        {
            string hexString = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                hexString += bytes[i].ToString("X2");
            }
            return hexString;
        }

        /// <summary>
        /// Returns true is c is a hexadecimal digit (A-F, a-f, 0-9)
        /// </summary>
        /// <param name="c">Character to test</param>
        /// <returns>true if hex digit, false if not</returns>
        private static bool IsHexDigit(Char c)
        {
            int numChar;
            int numA = Convert.ToInt32('A');
            int num1 = Convert.ToInt32('0');
            c = Char.ToUpper(c);
            numChar = Convert.ToInt32(c);
            if (numChar >= numA && numChar < (numA + 6))
                return true;
            if (numChar >= num1 && numChar < (num1 + 10))
                return true;
            return false;
        }

        //TODO: HexToByte check test runs for this function.
        /// <summary>
        /// Converts 1 or 2 character string into equivalant byte value
        /// </summary>
        /// <param name="hex">1 or 2 character string</param>
        /// <returns>byte</returns>
        private static byte HexToByte(string hex)
        {
            if (hex.Length > 2 || hex.Length <= 0)
                throw new ArgumentException("hex must be 1 or 2 characters in length");
            byte newByte = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            return newByte;
        }
        #endregion

        #region Parity Generation Functions
        public static void generateParity(ref byte[] serialBytes)
        {
            // Look at creating a combined ParityBits parityByte
            generateParityBits(ref serialBytes, serialBytes.Length - 1);
            generateParityByte(ref serialBytes);
        }
        /// <summary>
        /// Generates the final parity byte by counting the number of bits in
        /// each column.
        /// </summary>
        /// <param name="serialBytes">
        /// This parameter is passed by reference, the final byte in the array
        /// is used for the parity byte.  serialBytes must be at least two bytes.
        /// </param>
        public static void generateParityByte(ref byte[] serialBytes)
        {
            //TODO: generateParityByte: Look into generating both the row & column parity bits here.
            if (serialBytes.Length < 2)
                throw new ArgumentOutOfRangeException("serialBytes",
                    "serialBytes must be at least two bytes long.");

            // Set the final byte, the parity byte, to 0.
            int z = serialBytes.Length - 1;
            serialBytes[z] = 0;

            // Create a sliding binary '1' to filter for binary
            // digits in each byte.
            for (UInt16 i = 1; i <= 255; i <<= 1)
            {
                // Count the number of '1' digits in each column.
                // z is the number of actual data bytes (no parity byte)
                int numOnes = 0;
                for (int j = 0; j < z; j++)
                {
                    if ((serialBytes[j] & i) != 0)
                        numOnes++;
                }
                // Check to see if numOnes is odd, if so ignore it (its already 0)
                //              if numOnes is even, set that bit to 1.
                if ((numOnes & 1) == 1)
                {
                    serialBytes[z] |= Convert.ToByte(i);
                }
            }
        }

        /// <summary>
        /// Takes an array of bytes and generates their parity bits.
        /// </summary>
        /// <param name="serialBytes">Array of bytes to generate parity bits for.</param>
        private static void generateParityBits(ref byte[] serialBytes, int numberBytes)
        {
            for (int i = 0; i < numberBytes; i++)
            {
                generateParityBit(ref serialBytes[i]);
            }
        }

        /// <summary>
        /// Takes an array of bytes and generates their parity bits.
        /// </summary>
        /// <param name="serialBytes">Array of bytes to generate parity bits for.</param>
        public static void generateParityBits(ref byte[] serialBytes)
        {
            generateParityBits(ref serialBytes, serialBytes.Length);
        }

        /// <summary>
        /// Counts the number of '1' bits in the passed in byte, then fills in
        /// the final parity bit.
        /// 
        /// Odd number of 1's  = 0 parity
        /// Even number of 1's = 1 parity
        /// </summary>
        /// <param name="serialByte">Byte to generate and fill parity.</param>
        public static void generateParityBit(ref byte serialByte)
        {
            int numOnes = 0;
            // Clear the lowest bit.
            serialByte = Convert.ToByte(serialByte & 254);
            // Set the temp byte.
            byte tempByte = serialByte;
            // Count the 1 bits
            while (tempByte != 0)
            {
                numOnes += tempByte & 0x1;
                tempByte >>= 1;
            }
            // Set the parity bit.
            // If numOnes is odd
            serialByte |= Convert.ToByte(numOnes & 1);
        }
        #endregion

        #region Parity Validation Functions
        /// <summary>
        /// Checks the value of the parity bit.  Returns false if the check fails.
        /// </summary>
        /// <param name="serialByte">Serial Byte to validate.</param>
        /// <returns>True if check succeeds, false if check fails.</returns>
        public static bool validateParityBit(byte serialByte)
        {
            // Create copy of the passed in byte.
            byte tempByte = serialByte;
            // Generate the parity for the received byte.
            generateParityBit(ref tempByte);
            // Validate the generated is the same as the received.
            if (serialByte != tempByte)
                return false;   // if it is not, fail the parity check.

            return true;    // Passed parity check.
        }

        /// <summary>
        /// Checks the value of all of the parity bits in the passed in array.
        /// Array must be at least two bytes long.  Returns true if it passes
        /// the parity check.
        /// </summary>
        /// <param name="serialBytes">Array of serial data with parity bits.
        /// Must be at least two bytes long.</param>
        /// <returns>True if it passes the parity check, false if it fails.</returns>
        public static bool validateParityBytes(byte[] serialBytes)
        {
            //TODO: validateParityBytes: Validate that this works.
            // serialBytes must be at least two bytes long.
            if (serialBytes.Length < 2)
                throw new ArgumentOutOfRangeException("serialBytes",
                    "serialBytes must be at least two bytes long.");

            // Create a copy of the passed in serial data.
            byte[] tempBytes = new byte[serialBytes.Length];
            Array.Copy(serialBytes, tempBytes, serialBytes.Length);

            // Validate the parity values of each byte in the array.
            // (length - 1 because last byte is a parity byte)
            for (int i = 0; i < serialBytes.Length - 1; i++)
            {
                if (!validateParityBit(serialBytes[i])) // Check the parity of the byte.
                    return false; // Parity check failed.
            }

            // Re-generate the parity byte on the copy.
            generateParityByte(ref tempBytes);

            // Validate the generated = the received
            if (tempBytes[tempBytes.Length - 1] != serialBytes[serialBytes.Length - 1])
                return false; // Parity check failed.

            return true; // Parity check passed.
        }

        //TODO: validateParityByte - Write test case.
        /// <summary>
        /// Validates ONLY the parity byte of a serialData array.
        /// </summary>
        /// <param name="serialBytes">Array of serial data for which to validate
        /// the parity byte.</param>
        /// <returns>True if the parity byte passes the check.</returns>
        public static bool validateParityByte(byte[] serialBytes)
        {
            // Create a copy of the passed in array.
            byte[] tempBytes = new byte[serialBytes.Length];
            Array.Copy(serialBytes, tempBytes, serialBytes.Length);

            // Generate the parity byte for the copy.
            generateParityByte(ref tempBytes);

            // Check to make sure copy and original have same parity byte.
            if (serialBytes[serialBytes.Length - 1] != tempBytes[tempBytes.Length - 1])
                return false;
            return true;
        }

        #endregion
    }
}
