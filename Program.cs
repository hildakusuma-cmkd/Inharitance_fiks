Siswa siswaObj = new Siswa("Hilda", "Hilda@gmail.com", "1111", "Siswa", "XPG2");
Guru guruObj = new Guru("Furina", "Furina@gmail.com", "3333", "Guru", "Pkn");

siswaObj.TampilkanInfo();
siswaObj.SubmitTugas();

Console.WriteLine();

guruObj.TampilkanInfo();
guruObj.NilaiTugas();
class User
{
    public string Nama;
    public string Email;
    public string Password;
    public string Role;

    public User(string nama, string email, string password, string role)
    {
        Nama = nama;
        Email = email;
        Password = password;
        Role = role;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine("Menampilkan info user...");
        Console.WriteLine($"Nama: {Nama}");
        Console.WriteLine($"Role: {Role}");
    }
}

class Siswa : User
{
    public string ClassName;

    public Siswa(string nama, string email, string password, string role, string Classname) : base(nama, email, password, role)
    {
        ClassName = Classname;
    }
    public void SubmitTugas()
    {
        Console.WriteLine($"Siswa {Nama} sudah mengumpulkan semua tugas");
    }
}

class Guru : User
{
    public string Mapel;
    public Guru(string nama, string email, string password, string role, string mapel) : base(nama, email, password, role)
    {
        Mapel = mapel;
    }
    public void NilaiTugas()
    {
        Console.WriteLine($"Siswa {Nama} sudah menilai semua tugas {Mapel}");
    }
}
