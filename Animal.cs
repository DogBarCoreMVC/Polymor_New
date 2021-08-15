using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor_New
{
    public class Animal
    {
        public void Goes()
        {
            Console.WriteLine("Gose like an Animal");
        }
    }
    public class Dog : Animal
    {
        /*public void Goes()//การสร้าง method มาแบบนี้จะเป็นการสร้าง method ออกมาซ้ำกันกับ method ที่อยู่ในคลาสแม่ (แต่ทำการรันได้ตามปกติไม่มี error) ข้อแนะนำของ visual studio คือการให้ใส่ key word "new" นำหน้า void 
        {
            Console.WriteLine("Class Dog Woof!!");
        }*///ตามตัวอย่าง

        public new void Goes()
        {
            Console.WriteLine("Class Dog Woof!!");
        }
    }

}
