using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    class Box {
        private int width;
        private int height;

        public Box(int w, int h) {
            Width = w;
            Height = h;
        }

        public int Width {
            get {
                return width;
            }
            set {
                if(value < 0) {
                    throw new Exception("너비는 0이상 숫자여야 합니다");
                } else {
                    width = value;
                }
            }
        }

        public int Height {
            get {
                return height;
            }
            set {
                if (value < 0) {
                    throw new Exception("높이는 0이상 숫자여야 합니다");
                } else {
                    height = value;
                }
            }
        }

        public int CalcArea() {
            return width * height;
        }
    }
}
