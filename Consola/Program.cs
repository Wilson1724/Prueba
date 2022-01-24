using ModeloPrueba.Entidades;
using System;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            staff Dario = new staff()
            {
                first_name = "Dario",
                last_name = "Rodriguez",
                address_id = 2324,
                email = "d@gmail.com",
                store_id = 1234,
                active = "yes",
                username = "dar",
                password = "5678",
                last_update = "24/01/2022",
                picture = "1",

                storestaff = new store()
            };
            staff Mario = new staff()
            {
                first_name = "Mario",
                last_name = "Rodriguez",
                address_id = 2325,
                email = "m@gmail.com",
                store_id = 1235,
                active = "yes",
                username = "mar",
                password = "5679",
                last_update = "24/01/2022",
                picture = "2",

                storestaff = new store()
            };
            staff Marco = new staff()
            {
                first_name = "Marco",
                last_name = "Perez",
                address_id = 2326,
                email = "dmr@gmail.com",
                store_id = 1236,
                active = "no",
                username = "marc",
                password = "5670",
                last_update = "24/01/2022",
                picture = "3",

                storestaff = new store()
            };
            staff Juan = new staff()
            {
                first_name = "Juan",
                last_name = "Perez",
                address_id = 2327,
                email = "j@gmail.com",
                store_id = 1237,
                active = "no",
                username = "juan",
                password = "5671",
                last_update = "24/01/2022",
                picture = "4",

                storestaff = new store()
            };
            staff Jorge = new staff()
            {
                first_name = "Jorge",
                last_name = "Morales",
                address_id = 2328,
                email = "jr@gmail.com",
                store_id = 1238,
                active = "yes",
                username = "jor",
                password = "5672",
                last_update = "24/01/2022",
                picture = "5",

                storestaff = new store()
            };
            staff Maria = new staff()
            {
                first_name = "María",
                last_name = "Mercedez",
                address_id = 2329,
                email = "maria@gmail.com",
                store_id = 1239,
                active = "no",
                username = "mari",
                password = "5673",
                last_update = "24/01/2022",
                picture = "6",

                storestaff = new store()
            };
            staff Diego = new staff()
            {
                first_name = "Diego",
                last_name = "Reyes",
                address_id = 2320,
                email = "dmr@gmail.com",
                store_id = 1230,
                active = "no",
                username = "dieg",
                password = "5674",
                last_update = "24/01/2022",
                picture = "7",

                storestaff = new store()
            };
            staff Rodrigo = new staff()
            {
                first_name = "Rodrigo",
                last_name = "Cervantez",
                address_id = 2321,
                email = "ro@gmail.com",
                store_id = 1231,
                active = "yes",
                username = "rod",
                password = "5675",
                last_update = "24/01/2022",
                picture = "8",

                storestaff = new store()
            };
            staff Alex = new staff()
            {
                first_name = "Alex",
                last_name = "Reyes",
                address_id = 2322,
                email = "dmr@gmail.com",
                store_id = 1232,
                active = "yes",
                username = "al",
                password = "5676",
                last_update = "24/01/2022",
                picture = "9",

                storestaff = new store()
            };
            staff Victor = new staff()
            {
                first_name = "Victor",
                last_name = "Rodriguez",
                address_id = 2323,
                email = "dmr@gmail.com",
                store_id = 1233,
                active = "yes",
                username = "vic",
                password = "5677",
                last_update = "24/01/2022",
                picture = "10",

                storestaff = new store()
            };

            store Tía = new store()
            {
                address_id ="323412",
                last_update = "24/01/2022",
                staffstore = new staff()
            };
            store Comisariato = new store()
            {
                address_id = "323413",
                last_update = "24/01/2022",
                staffstore = new staff()
            };
            store Supermaxi = new store()
            {
                address_id = "323414",
                last_update = "24/01/2022",
                staffstore = new staff()
            };
            store Megamaxi = new store()
            {
                address_id = "323415",
                last_update = "24/01/2022",
                staffstore = new staff()
            };
            store SantaMaria = new store()
            {
                address_id = "323416",
                last_update = "24/01/2022",
                staffstore = new staff()
            };
            store Pika = new store()
            {
                address_id = "323417",
                last_update = "24/01/2022",
                staffstore = new staff()
            };

        }
    }
}
