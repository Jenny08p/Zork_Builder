using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Zork_Common;

namespace Zork_Builder

{
    public class WorldViewModel : INotifyPropertyChanged
    {
           public event PropertyChangedEventHandler PropertyChanged;

         
          public string Filename { get; set; }

           public BindingList<Room> Rooms { get; set; }


           public World World
           {
               set
               {
                   if (mWorld != value)
                   {
                       mWorld = value;
                       if (mWorld != null)
                       {
                        //Rooms = new BindingList<Room>(mWorld.Rooms);
                     //  Descriptions = new BindingList<Description>(mWorld.Descriptions);
                       }
                       else
                       {
                        // Rooms = new BindingList<Room>(Array.Empty<Room>());
                     //  Descriptions = new BindingList<Description>(Array.Empty<Description>());
                       }
                   }
               }
           }

        public Game Game { get; internal set; }

        public WorldViewModel(World world = null) => World = world;

           public void SaveWorld()
           {
               if (string.IsNullOrEmpty(Filename))
               {
                   throw new InvalidProgramException("Filename expected.");
               }

               JsonSerializer serializer = new JsonSerializer
               {
                   Formatting = Formatting.Indented
               };
               using (StreamWriter streamWriter = new StreamWriter(Filename))
               using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
               {
                   serializer.Serialize(jsonWriter, mWorld);
               }
           }

           private World mWorld;
        
       }
    }
   
