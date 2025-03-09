using System;
using tpmodul4_103022300029;


class MainKodePos
{
    static void Main()
    {
        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();
        Console.WriteLine($"Kode Pos {kelurahan}: {KodePos.GetKodePos(kelurahan)}");

        Console.WriteLine("\n---\n");

        DoorMachine doorMachine = new DoorMachine();

        doorMachine.reaksi();
        doorMachine.putarKunci();
        doorMachine.reaksi();
    }
}