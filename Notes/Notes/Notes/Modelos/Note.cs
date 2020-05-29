using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
#pragma warning disable CS0105 // La directiva using para 'SQLite' aparece previamente en este espacio de nombres
using SQLite;
#pragma warning restore CS0105 // La directiva using para 'SQLite' aparece previamente en este espacio de nombres

namespace Notes.Modelos
{
     public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int  ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
