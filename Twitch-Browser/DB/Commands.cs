using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Linq;
using System.Text;
using System.Diagnostics;
using SQLite;
using Twitch_API.Twitch;

namespace Stream_Browser.DB
{
    class Commands
    {
        // TODO : Will probably change this to 15 minutes
        protected const int purge_time = 15;

        protected static bool create_db(SQLiteConnection db)
        {            
            db.CreateTable<Stream>();
            return true;
        }

        protected static SQLiteConnection acquire_db_conn()
        {
            return new SQLiteConnection("stream_cache.db");
        }

        // Make sure the local cache DB exists, if it doesn't, create it. If it can't be created
        public static bool is_db_created()
        {
            var db = acquire_db_conn();
            try 
            {
                db.Query<Stream> ("select id from Stream where id= ?", 1);
                return true;
            }
            catch (SQLiteException e)
            {
                // If the streams table doesn't exist, create it
                if (e.Message == "no such table: Stream")
                {
                    if (create_db(db))
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }        

        public static bool insert_twitch_stream(TwitchStream stream)
        {
            SQLiteConnection db = acquire_db_conn();
            var s = db.Insert(new Stream()
            {
                // Mapping TwitchStream class properties to the DB
                Game = stream.Game,
                Broadcaster = stream.Broadcaster,
                Url = stream.StreamUrl,
                Title = stream.Title,
                Viewers = stream.Viewers,
                PreviewImage = stream.image_url,
                // TODO : Implement subscription for subscribed channels.
                isSubscribed = false,
                created = DateTime.Now
                
            });
            return true;
        }

        public static IEnumerable<Stream> QueryStreams(string game_name)
        {
            SQLiteConnection db = acquire_db_conn();
            return db.Query<Stream>("select * from Stream where Game = ?", game_name);
        }

        public static bool streams_require_rebuilding(string game_name)
        {
            SQLiteConnection db = acquire_db_conn();
            
            // Cheap DB Query - Indexed on game
            List<Stream> result = db.Query<Stream>("select * from Stream where Game = ?", game_name);

            // Use LINQ to perform datetime calculation to find any stream records that are older than 20 minutes.
            // IF even one DB record for a game is past purge time then they will all be purged and re-pulled.
            var res = from s in result
                      where DateTime.Now > s.created.AddMinutes(purge_time)
                      select s;

            if (res.ToArray().Length >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool has_enough_streams(string game_name)
        {
            SQLiteConnection db = acquire_db_conn();
            if (db.Query<int>("select id from Stream where Game = ?", game_name).ToArray().Length >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        internal static void delete_outdated_streams(string game)
        {
            SQLiteConnection db = acquire_db_conn();
            db.Execute("delete from Stream where Game = ?", game);
        }
    }
}
