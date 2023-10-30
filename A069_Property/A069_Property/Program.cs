using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A069_Property
{
    class Rectangle //방법1
    {
        private double width;
        private double height;
       
        public double GetWidth() //getter 값을가져옴
        {
            return width;
        }

        public double GetHeight() 
        {
            return height;
        }

        public void SetWidth(double width) //setter 값을 일방적으로 설정함
        {
            if(width > 0)
                this.width = width;
        }

        public void SetHeight(double height)
        {
            if(height > 0)
                this.height = height;
        }
    }

        class RectWithProp //방법2
        {
            public double Width { get; set; } //속성
            public double Height { get; set; }        
        }
        
        class RectWithPropFull //방법3
        {
            private double width;
            
            public double Width
            {
                get { return width; }
                set { if(value > 0) width = value; }
            }
            
            private double height;
            public double Height
            {
                get { return height; }
                set { if(value > 0) height = value;}
            }
        }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.SetWidth(10.0);
            r.SetHeight(10.0);
            Console.WriteLine("r의 면적은 {0}",r.GetWidth() * r.GetHeight());
            
            RectWithProp r1 = new RectWithProp();
            r1.Width = 10.0;
            r1.Height = 10.0;
            Console.WriteLine("r1의 면적은 {0}",r1.Width * r1.Height);
            
            RectWithPropFull r2 = new RectWithPropFull();
            r2.Width = 10.0;
            r2.Height = 10.0;
            Console.WriteLine("r2의 면적은 {0}", r2.Width * r2.Height);
        
            RectWithPropFull r3 = new RectWithPropFull();
            r3.Width = 10.0;
            r3.Height = -10.0;
            Console.WriteLine("r3의 면적은 {0}", r3.Width * r3.Height);
        }
    }
}
