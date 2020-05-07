using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace banana_library {
    public class Main {
        public int[] getTextBoxInfo(String text) {
            int[] ret = new int[3];

            int chars = text.Length;
            int words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int lines = text.Split('\n').Length;

            ret[0] = chars;
            ret[1] = words;
            ret[2] = lines;

            return ret;
        }

        public String addSaveMark(String title, bool isSaved) {
            String ret = title;

            if (isSaved) {
                if (title[0] == '*') {
                    ret = title.Remove(0, 1);
                }
            }
            else {
                if (title[0] != '*') {
                    ret = title.Insert(0, "*");
                }
            }

            return ret;
        }

        public bool rightToLeftToBool(RightToLeft righToLeft) {
            if (righToLeft == RightToLeft.Yes)
                return true;
            else
                return false;
        }
    }
}
