/*
 * Oggi esercitazione sui file, ossia vi chiedo di prendere dimestichezza con quanto appena visto sui file in classe, in particolare nel live-coding di oggi.
In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe, e salvare tutti gli indirizzi
contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: 
vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.
*/
using ListaIndirizzi;
using System.Linq.Expressions;
using System.IO;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

List<indirizzo> ListaIndirizzi = new();
try {
    StreamReader file = File.OpenText(@"..\..\..\Indirizzi\addresses.csv");
    StreamWriter sw = new StreamWriter(@"..\..\..\Indirizzi\InvalidAddresses.csv");
    file.ReadLine();
    while (!file.EndOfStream) {
        string riga = file.ReadLine();


        string[] InformazioniIndirizzo = riga.Split(',');
        if (InformazioniIndirizzo.Length == 6 && CheckNull(InformazioniIndirizzo)) {

                string Name = InformazioniIndirizzo[0];
                string Surname = InformazioniIndirizzo[1];
                string Street = InformazioniIndirizzo[2];
                string City = InformazioniIndirizzo[3];
                string Province = InformazioniIndirizzo[4];
                string ZIP = InformazioniIndirizzo[5];
                indirizzo IndirizzoEstratto = new(Name, Surname, Street, City, Province, ZIP);
                ListaIndirizzi.Add(IndirizzoEstratto);
            
        } else {
            sw.WriteLine(riga);
        }
    }
    file.Close();
    sw.Close();
}
catch (Exception e) {
    Console.WriteLine(e);
}


foreach (var elemento in ListaIndirizzi) {
    Console.WriteLine(elemento);
}

bool CheckNull(string[] array) {
    for (int i = 0; i < array.Length; i++) {
        if (string.IsNullOrEmpty(array[i])) {
            return false;
        }
    }
    return true;
}