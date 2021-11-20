using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20190140104
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Matematika : IMatematika
    {
        public int Bagi(int a, int b)            
        {
            try
            {
                return a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Input yang Anda Masukan Salah";
                mf.Pesan = "Masukan Input yang Benar";
                throw new FaultException<MathFault>(mf);
            }
            
        }

        public int Kali(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Input yang Anda Masukan Salah";
                mf.Pesan = "Masukan Input yang Benar";
                throw new FaultException<MathFault>(mf);
            }
            
        }

        public int Kurang(int a, int b)
        {            
            try
            {
                return a - b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Input yang Anda Masukan Salah";
                mf.Pesan = "Masukan Input yang Benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        public int Tambah(int a, int b)
        {            
            try
            {
                return a + b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Input yang Anda Masukan Salah";
                mf.Pesan = "Masukan Input yang Benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {           
            try
            {
                Koordinat hasil = new Koordinat();
                hasil.X = a.X + b.X;
                hasil.Y = a.Y + b.Y;
                return hasil;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Input yang Anda Masukan Salah";
                mf.Pesan = "Masukan Input yang Benar";
                throw new FaultException<MathFault>(mf);
            }
        }
    }
}
