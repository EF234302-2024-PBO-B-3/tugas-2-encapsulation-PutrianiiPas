/*
 * Tuliskan spesifikasi soal Anda disini. 
 * Kelas yang dibuat, atribut apa saja yang dibutuhkan, metode apa saja yang dibutuhkan, validasi atau aturan apa yang harus dilakukan.
 */

/*
 * Buatlah sebuah kelas publik yang bernama 'Idols' yang memiliki enam atribut private yaitu _groupName (tipe String), _debuteYear (tipe int), _totalMembers (tipe int), _totalAlbums (tipe int), _totalSongs (tipe int), dan _totalStreams (tipe double).
 * Sediakan properti publik dengan metode set dan metode get untuk masing-masing atribut GroupName, DebuteYear, TotalMembers, TotalAlbums, TotalSongs, and TotalStreams.
 * Pastikan GroupName tidak null/string kosong. Jika input parameter GroupName null/string kosong maka set variabel tersebut dengan value "Group Unknown" dan otomatis variabel lain bernilai 0.
 * Pastikan TotalMembers lebih dari 1. Jika kurang atau sama dengan 1 dan negatif, maka set value menjadi 0.
 * Pastikan juga DebuteYear, TotalAlbums dan TotalSongs tidak bernilai negatif. Jika negatif maka set value menjadi 0.
 * Pastikan input TotalStreams tidak bernilai negatif. Jika negatif maka set value menjadi 0.0.
 * Sediakan sebuah konstruktor yang menginisialisasi keempat atribut tersebut. Pastikan parameter2 input divalidasi di konstruktor sesuai dengan aturan.
 * Buat sebuah metode publik AllSongs yang menghitung total songs sesuai dengan banyaknya album. Setiap 1 album mengandung 10 songs.
 * Buat metode publik GetInfoGroup yang menampilkan informasi group secara keseluruhan.
 * Tulis sebuah kelas publik bernama Program yang berisi metode statik Main yang mendemonstrasikan kemampuan dari kelas 'Idols'.
 */


/*
 * Implementasikan solusi kelas dari soal Anda disini dan eksekusi implementasinya di Program.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Extra
{
    public class Idols
    {
        // Deklarasi atribut private
        private string _groupName;
        private int _debuteYear;
        private int _totalMembers;
        private int _totalAlbums;
        private int _totalSongs;
        private double _totalStreams;

        // Properti public berisi metode set dan get
        public string GroupName
        {
            get { return _groupName; }
            set
            {
                // Validasi
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _groupName = value;
                }
                else
                {
                    _groupName = "Group Unknown";
                    _debuteYear = 0;
                    _totalMembers = 0;
                    _totalAlbums = 0;
                    _totalSongs = 0;
                    _totalStreams = 0.0;
                }
            }
        }
        public int DebuteYear
        {
            get { return _debuteYear; }
            set
            {
                // Validasi
                if (value >= 0)
                {
                    _debuteYear = value;
                }
                else
                {
                    _debuteYear = 0;
                }
            }
        }
        public int TotalMembers
        {
            get { return _totalMembers; }
            set
            {
                // Validasi
                if (value > 1)
                {
                    _totalMembers = value;
                }
                else
                {
                    _totalMembers = 0;
                }
            }
        }
        public int TotalAlbums
        {
            get { return _totalAlbums; }
            set
            {
                // Validasi
                if (value >= 0)
                {
                    _totalAlbums = value;
                }
                else
                {
                    _totalAlbums = 0;
                }
            }
        }
        public int TotalSongs
        {
            get { return _totalSongs; }
            set
            {
                // Validasi
                if (value > 0)
                {
                    _totalSongs = value;
                }
                else
                {
                    _totalSongs = 0;
                }
            }
        }
        public double TotalStreams
        {
            get { return _totalStreams; }
            set
            {
                // Validasi
                if (value >= 0)
                {
                    _totalStreams = value;
                }
                else
                {
                    _totalStreams = 0.0;
                }
            }
        }

        // Konstruktor
        public Idols(string groupName, int debuteYear, int totalMembers, int totalAlbums, int totalSongs, double totalStreams)
        {
            GroupName = groupName;
            DebuteYear = debuteYear;
            TotalMembers = totalMembers;
            TotalAlbums = totalAlbums;
            TotalSongs = totalSongs;
            TotalStreams = totalStreams;
        }

        public int AllSongs()
        {
            int calculateSongs = TotalAlbums * 10;
            TotalSongs = calculateSongs;
            return TotalSongs;
        }

        public void GetInfoGroup()
        {
            Console.WriteLine($"=========== Idol Groups Identity ===========");
            Console.WriteLine($"Group Name: {GroupName} -- Members: {TotalMembers}");
            Console.WriteLine($"Debute Year: {DebuteYear}");
            Console.WriteLine($"All Albums: {TotalAlbums} -- All Songs: {TotalSongs}");
            Console.WriteLine($"Total Streams: {TotalStreams}");
        }
    }
}