﻿using SacramentMeeting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeeting.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SacramentMeetingContext context)
        {
            // context.Database.EnsureCreated();

            // Look for any Members
            if (context.Member.Any())
            {
                return; // Db already has data
            }
            var members = new Member[]
            {
                new Member{FirstName="Joseph",LastName="Smith"},
                new Member{FirstName="Emma",LastName="Smith"},
                new Member{FirstName="Jeffrey",LastName="Holland"},
                new Member{FirstName="Donnie",LastName="Osmond"},
                new Member{FirstName="Marie",LastName="Osmond"},
                new Member{FirstName="David",LastName="Archuletta"},
                new Member{FirstName="Katherine",LastName="Heigl"},
                new Member{FirstName="Glenn",LastName="Beck"},
                new Member{FirstName="Mitt",LastName="Romney"},
                new Member{FirstName="Julianne",LastName="Hough"},
                new Member{FirstName="Brandon",LastName="Flowers"},
                new Member{FirstName="Merlin",LastName="Olsen"},
                new Member{FirstName="Ricky",LastName="Schroder"},
                new Member{FirstName="Gladys",LastName="Knight"},
                new Member{FirstName="Jack",LastName="Dempsey"},
                new Member{FirstName="Danny",LastName="Ainge"}
            };
            foreach (Member m in members)
            {
                context.Member.Add(m);
            }
            context.SaveChanges();

            var callings = new Calling[]
            {
                new Calling{Title="Bishop",Organization=Organizations.Bishopric},
                new Calling{Title="1st Counselor",Organization=Organizations.Bishopric},
                new Calling{Title="2nd Counselor",Organization=Organizations.Bishopric},
                new Calling{Title="Organist",Organization=Organizations.Music},
                new Calling{Title="Choirister",Organization=Organizations.Music},
                new Calling{Title="2nd Counselor",Organization=Organizations.Young_Men},
                new Calling{Title="President",Organization=Organizations.Young_Men}
            };
            foreach (Calling c in callings)
            {
                context.Calling.Add(c);
            }
            context.SaveChanges();

            var currentCallings = new CurrentCalling[]
            {
                new CurrentCalling{MemberID=4,CallingID=1,DateCalled=DateTime.Parse("2018-3-01")},
                new CurrentCalling{MemberID=1,CallingID=2,DateCalled=DateTime.Parse("2018-3-01")},
                new CurrentCalling{MemberID=9,CallingID=3,DateCalled=DateTime.Parse("2018-3-01")},
                new CurrentCalling{MemberID=5,CallingID=4,DateCalled=DateTime.Parse("2002-9-05")},
                new CurrentCalling{MemberID=7,CallingID=5,DateCalled=DateTime.Parse("2017-4-19")},
                new CurrentCalling{MemberID=11,CallingID=6,DateCalled=DateTime.Parse("2015-8-13")},
                new CurrentCalling{MemberID=13,CallingID=7,DateCalled=DateTime.Parse("2015-8-06")},
            };
            foreach (CurrentCalling c in currentCallings)
            {
                context.CurrentCalling.Add(c);
            }
            context.SaveChanges();

            var songs = new Song[]
            {
                new Song{SongID=2,Title="The Spirit of God"},
                new Song{SongID=8,Title="Redeemer Of Israel"},
                new Song{SongID=19,Title="We Thank The O God For A Prophet"},
                new Song{SongID=26,Title="Joseph Smith's First Prayer"},
                new Song{SongID=35,Title="For The Strength Of The Hills"},
                new Song{SongID=41,Title="Let Zion In Her Beauty Rise"},
                new Song{SongID=58,Title="Come Ye Children Of The Lord"},
                new Song{SongID=66,Title="Rejoice, The Lord Is King"},
                new Song{SongID=85,Title="How Firm A Foundation"},
                new Song{SongID=89,Title="The Lord Is My Light"},
                new Song{SongID=92,Title="For The Beauty Of The Earth"},
                new Song{SongID=96,Title="Dearest Children God Is Near You"},
                new Song{SongID=97,Title="Lead Kindly Light"},
                new Song{SongID=98,Title="I Need Thee Every Hour"},
                new Song{SongID=116,Title="Come, Follow Me"},
                new Song{SongID=169,Title="As Now We Take The Sacrament"},
                new Song{SongID=173,Title="While Of These Emblems We Partake"},
                new Song{SongID=181,Title="Jesus Of Nazereth, Savior And King"},
                new Song{SongID=184,Title="Upon The Cross of Calvary"},
                new Song{SongID=185,Title="Reverently And Meekly Now"},
                new Song{SongID=188,Title="Thy Will O Lord, Be Done"},
                new Song{SongID=193,Title="I Stand All Amazed"},
                new Song{SongID=194,Title="There Is A Green Hill Far Away"},
                new Song{SongID=196,Title="Jesus, Once Of Humble Birth"}

            };
            foreach (Song s in songs)
            {
                context.Song.Add(s);
            }
            context.SaveChanges();

            var meetings = new Meeting[]
            {
                new Meeting{MeetingDate=DateTime.Parse("2019-12-9"),CallingID=1},
                new Meeting{MeetingDate=DateTime.Parse("2019-12-16"),CallingID=1},
                new Meeting{MeetingDate=DateTime.Parse("2019-12-23"),CallingID=1},
                new Meeting{MeetingDate=DateTime.Parse("2019-12-30"),CallingID=1},
            };
            foreach (Meeting m in meetings)
            {
                context.Meeting.Add(m);
            }
            context.SaveChanges();

            var songSelections = new SongSelection[]
            {
                new SongSelection{SongID=1,MeetingID=1,Schedule=SongPosition.Opening},
                new SongSelection{SongID=17,MeetingID=1,Schedule=SongPosition.Sacrament},
                new SongSelection{SongID=2,MeetingID=1,Schedule=SongPosition.Closing},
                new SongSelection{SongID=3,MeetingID=2,Schedule=SongPosition.Opening},
                new SongSelection{SongID=18,MeetingID=2,Schedule=SongPosition.Sacrament},
                new SongSelection{SongID=4,MeetingID=2,Schedule=SongPosition.Closing},
                new SongSelection{SongID=5,MeetingID=3,Schedule=SongPosition.Opening},
                new SongSelection{SongID=19,MeetingID=3,Schedule=SongPosition.Sacrament},
                new SongSelection{SongID=6,MeetingID=3,Schedule=SongPosition.Closing},
                new SongSelection{SongID=7,MeetingID=4,Schedule=SongPosition.Opening},
                new SongSelection{SongID=20,MeetingID=4,Schedule=SongPosition.Sacrament},
                new SongSelection{SongID=8,MeetingID=4,Schedule=SongPosition.Closing},
            };
            foreach (SongSelection s in songSelections)
            {
                context.SongSelection.Add(s);
            }
            context.SaveChanges();

            var prayers = new Prayer[]
            {
                new Prayer{MeetingID=1, MemberID=10,Schedule=PrayerPosition.Opening},
                new Prayer{MeetingID=1, MemberID=11,Schedule=PrayerPosition.Closing},
                new Prayer{MeetingID=2, MemberID=12,Schedule=PrayerPosition.Opening},
                new Prayer{MeetingID=2, MemberID=13,Schedule=PrayerPosition.Closing},
                new Prayer{MeetingID=3, MemberID=14,Schedule=PrayerPosition.Opening},
                new Prayer{MeetingID=3, MemberID=15,Schedule=PrayerPosition.Closing},
                new Prayer{MeetingID=4, MemberID=16,Schedule=PrayerPosition.Opening},
                new Prayer{MeetingID=4, MemberID=1,Schedule=PrayerPosition.Closing},

            };
            foreach (Prayer p in prayers)
            {
                context.Prayer.Add(p);
            }
            context.SaveChanges();

            var talks = new Talk[]
            {
                new Talk{ MeetingID=1, MemberID=1, Topic="Coming closer to Christ through Christmas traditions"},
                new Talk{ MeetingID=1, MemberID=2, Topic="Jesus in America"},
                new Talk{ MeetingID=1, MemberID=3, Topic="Prophets fortell of Jesus Birth"},
                new Talk{ MeetingID=2, MemberID=4, Topic="Forgiveness"},
                new Talk{ MeetingID=2, MemberID=5, Topic="Giving Service during the Holidays"},
                new Talk{ MeetingID=3, MemberID=6, Topic="Christ-Like Attributes"},
                new Talk{ MeetingID=3, MemberID=7, Topic="'Taking Upon Ourselves the Name of Jesus Christ' by Robert C Gay Oct.2018"},
            };
            foreach (Talk t in talks)
            {
                context.Talk.Add(t);
            }
            context.SaveChanges();
        }
 
    }
}
