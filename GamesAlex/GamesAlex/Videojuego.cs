using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GamesAlex
{
    internal class Videojuego
    {
        //Hola maestro, a todo el codigo le puse comentarios para que se pueda entender mejor, espero que no se vea feo con mucho comentario que le puse 

        //Esta etiqueta le dice a MongoDB que esta propiedad es la "Llave Primaria" (ID único)
        [BsonId]
        //Esto sirve para que el ID de MongoDB se pueda leer como un texto normal en C#
        [BsonRepresentation(BsonType.ObjectId)]

        //El ID invisible que usa el programa para no confundir juegos
        public string Id { get; set; }


        //Las propiedades básicas del videojuego
        public string Nombre { get; set; }
        public string Plataforma { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public string Categoria { get; set; }
    }
}
