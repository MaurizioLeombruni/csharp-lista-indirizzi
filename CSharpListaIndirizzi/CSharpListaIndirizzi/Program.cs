/* ESERCIZIO: Lista Indirizzi
 Oggi esercitazione sui file, ossia vi chiedo di prendere dimestichezza con quanto appena visto sui file in classe,
 in particolare nel live-coding di oggi.
 In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe,
 e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire
 dalla classe Indirizzo.
 Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo
 genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.
 */

using CSharpListaIndirizzi;
using System;
using System.IO;

List<Address> addresses = new List<Address>();

try
{
    //Prendiamo il file da leggere con il suo path relativo.

    StreamReader fileToRead = File.OpenText("../../../../addresses.csv");

    //Un ciclo while permette di scorrere tutte le linee del file.

    while (!fileToRead.EndOfStream)
    {
        //Prendiamo la riga e la splittiamo in base alle separazioni con virgola.

        string line = fileToRead.ReadLine();

        string[] addressInfo = line.Split(",");

        //Invertiamo l'array. Sappiamo che ci sono degli indirizzi scritti in modo sbagliato, e che le ultime
        //informazioni sono sempre presenti, quindi compiliamo a partire dall'ultimo elemento.
        //Se l'indirizzo è scritto in modo corretto non succede sostanzialmente nulla - anche se in un file scritto
        //bene questa operazione sarebbe evitabile.

        Array.Reverse(addressInfo);

        //Alcuni indirizzi presentano elementi mancanti, portando alla creazione di una stringa array più corta.
        //Se la stringa array (in questo caso una sola) compiliamo le informazioni strettamente necessarie.
        //Anche questa operazione sarebbe inutile se il file fosse steso in modo corretto (o banalmente si usa un database...)

        if(addressInfo.Length >= 5)
        {
            string newZip = addressInfo[0];
            string newProvince = addressInfo[1];
            string newCity = addressInfo[2];
            string newStreet = addressInfo[3];
            string newSurname = addressInfo[4];
            string newName = addressInfo[5];

            Address newAddress = new Address(newName, newSurname, newStreet, newCity, newProvince, newZip);

            addresses.Add(newAddress);

            //C'è un elemento della lista che riporta più nomi; il programma qui prende solo l'ultimo dichiarato.
            //Volendo si più fare un elenco di nomi facendo un ciclo for con gli indici rimanenti, ma non sapendo quali sono le
            //informazioni ripetute si rischia di incappare in indirizzi scritti male. Meglio rimanere sul sicuro e
            //stampare un solo nome; d'altronde il referente di solito è uno solo.
        }
        else
        {
            //Questa sezione stampa solo alcune informazioni cruciali, ma non è neanche il modo corretto di farlo.
            //Non sappiamo quali sono le informazioni mancanti (qui sì perché l'ho visto io programmatore), ma non ho trovato un
            //metodo efficiente per riconosce le informazioni errate se non quello di frustare i data entry affinché mandino un
            //file scritto correttamente.

            string newZip = addressInfo[0];
            string newProvince = addressInfo[1];
            string newCity = addressInfo[2];
            string newName = addressInfo[3];

            Address newAddress = new Address(newName, "", "", newCity, newProvince, newZip);

            addresses.Add(newAddress);
        }
    }

    //Printiamo le informazioni per ogni indirizzo.
    //Il foreach stampa anche l'indirizzo che contiene le categorie, quindi si usa un for che parte dall'indice 1.
    //DA RIVEDERE: Impedire al programma di compilare la prima riga.

    /*foreach(Address element in addresses)
    {
        element.PrintAddress();
    }*/

    for(int i=1; i<addresses.Count; i++)
    {
        addresses[i].PrintAddress();
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

