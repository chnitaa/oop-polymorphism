using System;
public class HelloWorld
{
    static public void Main ()
    {
     familyhobi ak = new familyhobi();
     familyhobi ayah = new Ayah();
     familyhobi ibu = new Ibu();
     familyhobi anak = new Anak();
     
     familydata ayahku = new familydata("M.kholil",55,08135923382);
    familydata ibuku = new familydata("Sayuni",53,08818489151);
    familydata aku = new familydata("Chonita Asyia",16,0895630258863);
     Console.WriteLine("DATA AYAH:\n"+ayahku.nama+"\n"+ayahku.umur+"\n"+ayahku.nohp);
     ayah.Hobi();
   Console.WriteLine("DATA IBU:\n"+ibuku.nama+"\n"+ibuku.umur+"\n"+ibuku.nohp);
     ibu.Hobi();
     Console.WriteLine("DATA ANAK:\n"+aku.nama+"\n"+aku.umur+"\n"+aku.nohp);
     anak.Hobi();
    }
    class familydata
    {
        public string nama;
        public int umur;
        public long nohp;
        public familydata(string Nama,int Umur,long Nohp)
        {
            nama = Nama;
            umur = Umur;
            nohp = Nohp;
        }
    }
    class familyhobi 
    {
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class Ayah:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Olahraga");
        }
    }
    class Ibu:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Memasak");
        }
    }
    class Anak:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("bulutangkis");
        }
    }
}
