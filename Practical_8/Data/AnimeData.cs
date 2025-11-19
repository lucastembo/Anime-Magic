namespace Practical_8.Data
{
    using Practical_8.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="AnimeData" />
    /// </summary>
    public static class AnimeData
    {
        /// <summary>
        /// The GetAnimeList
        /// </summary>
        /// <returns>The <see cref="List{Anime}"/></returns>
        public static List<Anime> GetAnimeList()
        {
            return new List<Anime>
            {
                new Anime
{
    Id = "1",
    Name = "bleach",
    Image = new AnimeImage
    {
        Original = "https://m.media-amazon.com/images/M/MV5BZjE0YjVjODQtZGY2NS00MDcyLThhMDAtZGQwMTZiOWNmNjRiXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_FMjpg_UX1000_.jpg"
    },
    Kind = "TV",
    Episodes = 366,
    EpisodesAired = 366,
    Score = "7.92"
},
new Anime
{
    Id = "2",
    Name = "black_clover",
    Image = new AnimeImage
    {
        Original = "https://m.media-amazon.com/images/M/MV5BNTAzYTlkMWEtOTNjZC00ZDU0LWI5ODUtYTRmYzY0MTAzYWZlXkEyXkFqcGdeQXVyMzgxODM4NjM@._V1_FMjpg_UX1000_.jpg"
    },
    Kind = "TV",
    Episodes = 170,
    EpisodesAired = 170,
    Score = "7.16"
},
new Anime
{
    Id = "3",
    Name = "dragon_ball",
    Image = new AnimeImage
    {
        Original = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTVN0C6cr6Vti7SE4pme2hj46fdHN2nrfQJHg&s"
    },
    Kind = "TV",
    Episodes = 153,
    EpisodesAired = 153,
    Score = "8.68"
},
new Anime
{
    Id = "4",
    Name = "jujutsu_kaisen",
    Image = new AnimeImage
    {
        Original = "https://wallpapercave.com/wp/wp9365774.jpg"
    },
    Kind = "TV",
    Episodes = 24,
    EpisodesAired = 24,
    Score = "8.78"
},
new Anime
{
    Id = "5",
    Name = "fma_brotherhood",
    Image = new AnimeImage
    {
        Original = "https://m.media-amazon.com/images/M/MV5BZmEzN2YzOTItMDI5MS00MGU4LWI1NWQtOTg5ZThhNGQwYTEzXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_.jpg"
    },
    Kind = "TV",
    Episodes = 64,
    EpisodesAired = 64,
    Score = "9.24"
},
new Anime
{
    Id = "6",
    Name = "naruto",
    Image = new AnimeImage
    {
        Original = "https://m.media-amazon.com/images/M/MV5BZmQ5NGFiNWEtMmMyMC00MDdiLTg4YjktOGY5Yzc2MDUxMTE1XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_.jpg"
    },
    Kind = "TV",
    Episodes = 220,
    EpisodesAired = 220,
    Score = "8.3"
},
new Anime
{
    Id = "7",
    Name = "gintama",
    Image = new AnimeImage
    {
        Original = "https://m.media-amazon.com/images/M/MV5BMDkxZTJjZTEtMDRjMy00Yzk1LWI5YjItMjIwYmVlYzhlZWZhXkEyXkFqcGdeQXVyNDQxNjcxNQ@@._V1_FMjpg_UX1000_.jpg"
    },
    Kind = "TV",
    Episodes = 367,
    EpisodesAired = 367,
    Score = "9.0"
},
new Anime
{
    Id = "9",
    Name = "one_piece",
    Image = new AnimeImage
    {
        Original = "https://m.media-amazon.com/images/M/MV5BODcwNWE3OTMtMDc3MS00NDFjLWE1OTAtNDU3NjgxODMxY2UyXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg"
    },
    Kind = "TV",
    Episodes = 1030,
    EpisodesAired = 1030,
    Score = "8.58"
},
new Anime
{
    Id = "10",
    Name = "demon_slayer",
    Image = new AnimeImage
    {
        Original = "https://m.media-amazon.com/images/M/MV5BZjZjNzI5MDctY2Y4YS00NmM4LTljMmItZTFkOTExNGI3ODRhXkEyXkFqcGdeQXVyNjc3MjQzNTI@._V1_.jpg"
    },
    Kind = "TV",
    Episodes = 26,
    EpisodesAired = 26,
    Score = "8.6"
},
new Anime
{
    Id = "11",
    Name = "attack_on_titan",
    Image = new AnimeImage
    {
        Original = "https://flxt.tmsimg.com/assets/p10701949_b_v8_ah.jpg"
    },
    Kind = "TV",
    Episodes = 75,
    EpisodesAired = 75,
    Score = "9.16"
},
new Anime
{
    Id = "12",
    Name = "hunter_x_hunter",
    Image = new AnimeImage
    {
        Original = "https://m.media-amazon.com/images/M/MV5BZjNmZDhkN2QtNDYyZC00YzJmLTg0ODUtN2FjNjhhMzE3ZmUxXkEyXkFqcGdeQXVyNjc2NjA5MTU@._V1_FMjpg_UX1000_.jpg"
    },
    Kind = "TV",
    Episodes = 148,
    EpisodesAired = 148,
    Score = "9.1"
},
new Anime
{
    Id = "13",
    Name = "boku_no_hero_academia",
    Image = new AnimeImage
    {
        Original = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRx1rA7Ffz4yON_6TnG2oNo_9NQOlBN1V3LzQ&s"
    },
    Kind = "TV",
    Episodes = 114,
    EpisodesAired = 114,
    Score = "8.39"
}

                // Add the rest of the data similarly here...
            };
        }


        public static List<Description> GetDescriptionList()
        {
            return new List<Description>
    {
        new Description
        {
            Id = "1",
            AnimeId = "1", // ID of "bleach"
            LongText = "Bleach follows the story of Ichigo Kurosaki, a teenager who accidentally acquires the powers of a Soul Reaper—a death personification entity tasked with defending humans from evil spirits and guiding departed souls to the afterlife. With his newfound powers, Ichigo must protect the living world from dangerous spirits known as Hollows and uncover the mysteries behind his abilities."
        },
        new Description
        {
            Id = "2",
            AnimeId = "2", // ID of "black_clover"
            LongText = "Black Clover centers around Asta, a boy born without any magical powers in a world where magic is everything. Alongside his childhood rival and friend Yuno, who possesses incredible magic, Asta strives to become the Wizard King, facing numerous challenges, battling powerful foes, and uncovering the truth behind his lack of magic."
        },
        new Description
        {
            Id = "3",
            AnimeId = "3", // ID of "dragon_ball"
            LongText = "Dragon Ball follows the adventures of Goku, a young boy with a monkey tail who embarks on a quest to find the Dragon Balls, magical orbs that grant wishes. Along the way, he encounters friends, foes, and powerful adversaries as he trains in martial arts and seeks to protect Earth from various threats."
        },
        new Description
        {
            Id = "4",
            AnimeId = "4", // ID of "jujutsu_kaisen"
            LongText = "Jujutsu Kaisen follows Yuji Itadori, a high school student who joins a secret organization of Jujutsu Sorcerers after swallowing a cursed object containing the powerful demon Sukuna. He battles cursed spirits and learns to harness his own cursed energy while navigating the complexities of life and death."
        },
        new Description
        {
            Id = "5",
            AnimeId = "5", // ID of "fma_brotherhood"
            LongText = "Fullmetal Alchemist: Brotherhood follows the journey of two brothers, Edward and Alphonse Elric, who use alchemy in an attempt to bring their mother back to life. The disastrous consequences lead to Edward losing an arm and Alphonse losing his entire body. They seek the Philosopher's Stone to restore their bodies and uncover deep truths about alchemy."
        },
        new Description
        {
            Id = "6",
            AnimeId = "6", // ID of "naruto"
            LongText = "Naruto follows the journey of Naruto Uzumaki, a young ninja with dreams of becoming the Hokage, the leader of his village. Despite being ostracized due to the Nine-Tails fox sealed within him, Naruto perseveres through various challenges, befriends fellow ninjas, and uncovers deep-rooted conspiracies while striving for acceptance and recognition."
        },
        new Description
        {
            Id = "7",
            AnimeId = "7", // ID of "gintama"
            LongText = "Gintama is set in an alternate-history Edo period where aliens have invaded Japan. The story follows Gintoki Sakata, a silver-haired samurai, as he takes on odd jobs while dealing with various threats and hilarious situations. The series blends comedy, action, and drama with satirical takes on various genres."
        },
        new Description
        {
            Id = "9",
            AnimeId = "9", // ID of "one_piece"
            LongText = "One Piece tells the adventurous tale of Monkey D. Luffy, a young pirate who dreams of finding the One Piece, the legendary treasure of the Pirate King, Gol D. Roger. As he gathers a diverse crew, known as the Straw Hat Pirates, Luffy navigates the Grand Line, facing powerful enemies and uncovering mysteries while pursuing his dream of becoming the King of the Pirates."
        },
        new Description
        {
            Id = "10",
            AnimeId = "10", // ID of "demon_slayer"
            LongText = "Demon Slayer: Kimetsu no Yaiba follows Tanjiro Kamado, a kind-hearted boy who becomes a demon slayer after his family is slaughtered by demons, and his sister Nezuko is turned into one. Tanjiro sets out on a journey to avenge his family and find a cure for his sister, facing powerful demons and uncovering the secrets of the Demon Slayer Corps along the way."
        },
        new Description
        {
            Id = "11",
            AnimeId = "11", // ID of "attack_on_titan"
            LongText = "Attack on Titan is set in a world where humanity resides within enormous walled cities to protect themselves from Titans, gigantic humanoid creatures. The story follows Eren Yeager, who vows to eradicate the Titans after witnessing the destruction of his hometown and the death of his mother. Alongside his friends Mikasa and Armin, he joins the military to fight against these monstrous beings."
        },
        new Description
        {
            Id = "12",
            AnimeId = "12", // ID of "hunter_x_hunter"
            LongText = "Hunter x Hunter follows Gon Freecss, a young boy who learns that his long-lost father is a legendary Hunter. Determined to become a Hunter himself, Gon embarks on a journey filled with challenges, meeting friends and foes alike. As he learns about the responsibilities of being a Hunter, he faces dangerous beasts, intricate games, and the complexities of human nature."
        },
        new Description
        {
            Id = "13",
            AnimeId = "13", // ID of "boku_no_hero_academia"
            LongText = "My Hero Academia follows Izuku Midoriya, a boy born without superpowers in a world where they are the norm. Despite this, he dreams of becoming a hero. After a chance encounter with the legendary hero All Might, he inherits his powers and enrolls in U.A. High School, where he trains to become a professional hero and faces various challenges, including villainous threats."
        }
    };
        }



    }

}
