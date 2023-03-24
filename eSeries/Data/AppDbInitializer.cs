using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSeries.Data.Enums;
using eSeries.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace eSeries.Data
{
    public class AppDbInitializer
    {
        //Used for our seeding of the Db
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();


                //Streamers
                if (!context.Streamers.Any()) //if there are no streamers in the db
                {
                    context.Streamers.AddRange(new List<Streamer>()
                    {
                        new Streamer()
                        {
                            Name = "Netflix",
                            LogoURL = "https://seeklogo.com/images/N/netflix-logo-B24AFC06E5-seeklogo.com.png",
                            Description = "Netflix, Inc. is an American media company based in Los Gatos, California. Founded in 1997, it operates the over-the-top subscription video on-demand service Netflix brand, which includes original films and television series commissioned or acquired by the company, and third-party content licensed from other distributors."
                        },
                        new Streamer()
                        {
                            Name = "HBO",
                            LogoURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/de/HBO_logo.svg/512px-HBO_logo.svg.png",
                            Description = "Home Box Office (HBO) is an American pay television network, which is the flagship property of namesake parent subsidiary Home Box Office, Inc., itself a unit owned by Warner Bros. Discovery. The overall Home Box Office business unit is based at Warner Bros."
                        },
                        new Streamer()
                        {
                            Name = "Crave",
                            LogoURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/Crave_2018_logo.svg/1280px-Crave_2018_logo.svg.png",
                            Description = "Crave (initially named CraveTV) is a Canadian subscription video on demand service owned by Bell Media. The service competes directly with other subscription-based over-the-top streaming services operating in Canada, primarily against American-based services."
                        },
                        new Streamer()
                        {
                            Name = "Hulu",
                            LogoURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Hulu_Logo.svg/330px-Hulu_Logo.svg.png",
                            Description = "Hulu (/ˈhuːluː/) is an American subscription streaming service majority-owned by The Walt Disney Company, with Comcast's NBCUniversal holding a minority stake (1:2). It was launched on October 29, 2007"
                        },
                        new Streamer()
                        {
                            Name = "YoutubeTV",
                            LogoURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f7/YouTube_TV_logo.svg/375px-YouTube_TV_logo.svg.png",
                            Description = "YouTube TV is an American streaming television service operated by YouTube, a wholly owned subsidiary of Google. Announced on February 28, 2017,[1] the virtual multichannel video programming distributor offers a selection of live linear channel feeds and on-demand content from more than 100 television networks"
                        },
                        new Streamer()
                        {
                            Name = "Amazon Prime Video",
                            LogoURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Amazon_Prime_Video_logo.svg/338px-Amazon_Prime_Video_logo.svg.png",
                            Description = "Amazon Prime Video, also known simply as Prime Video, is an American subscription video on-demand over-the-top streaming and rental service of Amazon offered as a standalone service or as part of Amazon's Prime subscription."
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any()) //if there are no streamers in the db
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Ana Taylor-Joy",
                            Bio = "Anya-Josephine Marie Taylor-Joy (/ˈænjə/ ANN-yə;[1] born 16 April 1996) is an actress.[a] She has won several accolades, including a Golden Globe Award and a Screen Actors Guild Award, in addition to nominations for a BAFTA Film Award and a Primetime Emmy Award.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c9/Anya_Taylor-Joy_by_Patrick_Lovell%2C_January_2019.jpg/330px-Anya_Taylor-Joy_by_Patrick_Lovell%2C_January_2019.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Pedro Pascal",
                            Bio = "José Pedro Balmaceda Pascal (Spanish pronunciation: [xoˈse ˈpeðɾo βalmaˈseða pasˈkal]; born 2 April 1975) is a Chilean-born American actor. After nearly two decades of taking small roles in film and television, Pascal rose to prominence for portraying Oberyn Martell during the fourth season of the HBO fantasy series Game of Thrones (2014) and Javier Peña in the Netflix crime series Narcos (2015–2017).",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/Pedro_Pascal_by_Gage_Skidmore.jpg/330px-Pedro_Pascal_by_Gage_Skidmore.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Cilian Murphy",
                            Bio = "Cillian Murphy (/ˈkɪliən/; born 25 May 1976) is an Irish actor. He made his professional debut in Enda Walsh's 1996 play Disco Pigs, and in the 2001 screen adaptation of the same name. His early notable film credits include Jim in the zombie horror 28 Days Later (2002), the dark comedy Intermission (2003), the action thriller Red Eye (2005), the Irish war drama The Wind That Shakes the Barley (2006), and the sci-fi thriller Sunshine (2007).",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Cillian_Murphy_Photo_Call_The_Party_Berlinale_2017_cropped.jpg/330px-Cillian_Murphy_Photo_Call_The_Party_Berlinale_2017_cropped.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Penn Bagdley",
                            Bio = "Penn Dayton Badgley (born November 1, 1986)[1] is an American actor. He is known for his roles as Dan Humphrey in the original run of The CW/HBO Max teen drama series Gossip Girl (2007–2012) and as Joe Goldberg in the Lifetime/Netflix thriller series You (2018–present).",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Penn_Badgley_TIFF_2012.jpg/330px-Penn_Badgley_TIFF_2012.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Henry Cavill",
                            Bio = "Henry William Dalgliesh Cavill (/ˈkævəl/ KAV-əl; born 5 May 1983) is a British actor. He is known for his portrayal of Charles Brandon in Showtime's The Tudors (2007–2010), DC Comics character Superman in the DC Extended Universe (2013–2022), Geralt of Rivia in the Netflix fantasy series The Witcher",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Henry_Cavill_%2848417913146%29_%28cropped%29.jpg/330px-Henry_Cavill_%2848417913146%29_%28cropped%29.jpg"
                        }
                    });
                context.SaveChanges();
            }
                //Producers
                if (!context.Producers.Any()) //if there are no streamers in the db
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Scott Frank",
                            Bio = "A. Scott Frank (born March 10, 1960) is an American film director, producer, screenwriter, and author. Frank has received two Academy Award nominations for Best Adapted Screenplay for Out of Sight (1998) and Logan (2017). His film work, credited and uncredited, extends to dozens of films.[1] In recent years, he has worked for Netflix on television miniseries, most prominently writing and directing The Queen's Gambit.",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Craig Mazin",
                            Bio = "Craig Mazin (born April 8, 1971) is an American screenwriter and film director. He is best known for creating the HBO miniseries Chernobyl, based on the Soviet nuclear disaster of the same name in 1986, and co-creating the HBO series The Last Of Us, based on the video game of the same name created by Neil Druckmann.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/51/Craig_Mazin%2C_MovieZine_interview_%28cropped%29.png/330px-Craig_Mazin%2C_MovieZine_interview_%28cropped%29.png"
                        },
                        new Producer()
                        {
                            FullName = "Steven Knight",
                            Bio = "Knight is also one of three creators of Who Wants to Be a Millionaire?, a game show that has been remade and aired in around 160 countries worldwide, and has written for BBC's Commercial Breakdown, The Detectives, Peaky Blinders, See and Taboo.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f9/Portrait_of_Steven_Knight_by_Taylor_Rooke%2C_March_5th_2020.jpg/330px-Portrait_of_Steven_Knight_by_Taylor_Rooke%2C_March_5th_2020.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Greg Berlanti",
                            Bio = "Gregory Berlanti (born May 24, 1972) is an American screenwriter, producer and director of film and television. He is known for his work on the television series Dawson's Creek, Brothers & Sisters, Everwood, Political Animals, Riverdale, Chilling Adventures of Sabrina and You, in addition to his contributions to DC Comics on film and television productions, including The CW's Arrowverse, Titans, and the Doom Patrol. In 2000, Berlanti founded the production company Berlanti Productions.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Greg_Berlanti_cropped.jpg/330px-Greg_Berlanti_cropped.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Lauren Schmidt Hissrich",
                            Bio = "Lauren Schmidt-Hissrich (/ˈhɪsrɪk/ HIS-rik[1][2] [3]) is an American television producer and screenwriter. She is the series creator of the television series The Witcher.[4]",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Lauren_Schmidt_Hissrich_by_Gage_Skidmore.jpg/330px-Lauren_Schmidt_Hissrich_by_Gage_Skidmore.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Series
                if (!context.Series.Any()) //if there are no streamers in the db
                {
                    context.Series.AddRange(new List<Serie>()
                    {
                        new Serie()
                        {
                            Name = "The Queen's gambit",
                            Description = "The Queen's Gambit follows the life of an orphan chess prodigy, Elizabeth Harmon, during her quest to become an elite chess player while struggling with emotional problems, drugs and alcohol dependency.",
                            Price = 8.00,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/1/12/The_Queen%27s_Gambit_%28miniseries%29.png",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            StreamerId = 3,
                            ProducerId = 3,
                            SerieCategory = SerieCategory.Drama
                        },
                        new Serie()
                        {
                            Name = "The Last Of Us",
                            Description = "he Last of Us is an American post-apocalyptic drama television series created by Craig Mazin and Neil Druckmann for HBO. Based on the 2013 video game developed by Naughty Dog, the series is set in 2023, twenty years into a pandemic caused by a mass fungal infection, which causes its hosts to transform into zombie-like creatures and collapses society. The series follows Joel (Pedro Pascal), a smuggler tasked with escorting the immune teenager Ellie (Bella Ramsey) across a post-apocalyptic United States.",
                            Price = 10.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/The_Last_of_Us_logo.svg/375px-The_Last_of_Us_logo.svg.png",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            StreamerId = 1,
                            ProducerId = 1,
                            SerieCategory = SerieCategory.Drama
                        },
                        new Serie()
                        {
                            Name = "Peaky Blinders",
                            Description = "Peaky Blinders is a British period crime drama television series created by Steven Knight. Set in Birmingham, it follows the exploits of the Peaky Blinders crime gang in the direct aftermath of the First World War. The fictional gang is loosely based on a real urban youth gang of the same name who were active in the city from the 1880s to the 1910s.",
                            Price = 15.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/e/e8/Peaky_Blinders_titlecard.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            StreamerId = 4,
                            ProducerId = 4,
                            SerieCategory = SerieCategory.Crime
                        },
                        new Serie()
                        {
                            Name = "YOU",
                            Description = "The first season follows the story of Joe Goldberg, a bookstore manager in New York, who upon meeting Guinevere Beck, an aspiring writer, becomes infatuated with her. He feeds his toxic obsession using social media and other technology to track her presence and watch her in her house and remove obstacles to their romance including her friends and ex-boyfriend.",
                            Price = 8.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/c/c1/You_%28TV_series%29_intertitle.png",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            StreamerId = 1,
                            ProducerId = 2,
                            SerieCategory = SerieCategory.Thriller
                        },
                        new Serie()
                        {
                            Name = "The Witcher",
                            Description = "The story begins with Geralt of Rivia, Crown Princess Ciri of Cintra, and the sorceress Yennefer of Vengerberg at different points of time, exploring formative events that shape their characters throughout the first season, before eventually merging into a single timeline.",
                            Price = 11.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/thumb/2/23/The_Witcher_Title_Card.png/375px-The_Witcher_Title_Card.png",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            StreamerId = 1,
                            ProducerId = 3,
                            SerieCategory = SerieCategory.Fantasy
                        },
                        new Serie()
                        {
                            Name = "Stranger Things",
                            Description = "Stranger Things is set in the fictional rural town of Hawkins, Indiana, during the 1980s. The nearby Hawkins National Laboratory ostensibly performs scientific research for the United States Department of Energy but secretly does experiments into the paranormal and supernatural, including those that involve human test subjects. Inadvertently, they have created a portal to an alternate dimension, \"the Upside Down\". ",
                            Price = 13.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/Stranger_Things_logo.png/375px-Stranger_Things_logo.png",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            StreamerId = 1,
                            ProducerId = 5,
                            SerieCategory = SerieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actor/Movies
                if (!context.Actor_Series.Any()) //if there are no streamers in the db
                {
                    context.Actor_Series.AddRange(new List<Actor_Serie>()
                    {
                        new Actor_Serie()
                        {
                            ActorId = 1,
                            SerieId = 1
                        },
                        new Actor_Serie()
                        {
                            ActorId = 3,
                            SerieId = 1
                        },

                         new Actor_Serie()
                        {
                            ActorId = 1,
                            SerieId = 2
                        },
                         new Actor_Serie()
                        {
                            ActorId = 4,
                            SerieId = 2
                        },

                        new Actor_Serie()
                        {
                            ActorId = 1,
                            SerieId = 3
                        },
                        new Actor_Serie()
                        {
                            ActorId = 2,
                            SerieId = 3
                        },
                        new Actor_Serie()
                        {
                            ActorId = 5,
                            SerieId = 3
                        },


                        new Actor_Serie()
                        {
                            ActorId = 2,
                            SerieId = 4
                        },
                        new Actor_Serie()
                        {
                            ActorId = 3,
                            SerieId = 4
                        },
                        new Actor_Serie()
                        {
                            ActorId = 4,
                            SerieId = 4
                        },


                        new Actor_Serie()
                        {
                            ActorId = 2,
                            SerieId = 5
                        },
                        new Actor_Serie()
                        {
                            ActorId = 3,
                            SerieId = 5
                        },
                        new Actor_Serie()
                        {
                            ActorId = 4,
                            SerieId = 5
                        },
                        new Actor_Serie()
                        {
                            ActorId = 5,
                            SerieId = 5
                        },


                        new Actor_Serie()
                        {
                            ActorId = 3,
                            SerieId = 6
                        },
                        new Actor_Serie()
                        {
                            ActorId = 4,
                            SerieId = 6
                        },
                        new Actor_Serie()
                        {
                            ActorId = 5,
                            SerieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        } 
    }
}
