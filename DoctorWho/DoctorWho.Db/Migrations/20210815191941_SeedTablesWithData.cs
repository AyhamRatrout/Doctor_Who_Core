using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class SeedTablesWithData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Anthony Coburn" },
                    { 77, "Matthew Graham" },
                    { 76, "Matt Jones" },
                    { 75, "Tom MacRae" },
                    { 74, "Toby Whithouse" },
                    { 73, "Steven Moffat" },
                    { 72, "Paul Cornell" },
                    { 71, "Robert Shearman" },
                    { 70, "Mark Gatiss" },
                    { 69, "Russell T Davies" },
                    { 68, "Matthew Jacobs" },
                    { 78, "Gareth Roberts" },
                    { 66, "Marc Platt" },
                    { 64, "Graeme Curry" },
                    { 63, "Ben Aaronovitch" },
                    { 62, "Ian Briggs" },
                    { 61, "Malcolm Kohll" },
                    { 60, "Stephen Wyatt" },
                    { 59, "Glen McCoy" },
                    { 58, "Paula Moore" },
                    { 57, "Pip and Jane Baker" },
                    { 56, "Philip Martin" },
                    { 55, "Anthony Steven" },
                    { 65, "Kevin Clarke" },
                    { 54, "Eric Pringle" },
                    { 79, "Helen Raynor" },
                    { 81, "Chris Chibnall" },
                    { 103, "Maxine Alderton" },
                    { 102, "Charlene James" },
                    { 101, "Nina Metivier" },
                    { 100, "Ed Hime" },
                    { 99, "Joy Wilkinson" },
                    { 98, "Pete McTighe" },
                    { 97, "Vinay Patel" },
                    { 96, "Malorie Blackman" },
                    { 95, "Mike Bartlett" },
                    { 94, "Sarah Dollard" },
                    { 80, "Stephen Greenhorn" },
                    { 93, "Catherine Tregenna" },
                    { 91, "Jamie Mathieson" },
                    { 90, "Peter Harness" },
                    { 89, "Neil Cross" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 88, "Neil Gaiman" },
                    { 87, "Stephen Thompson" },
                    { 86, "Richard Curtis" },
                    { 85, "Simon Nye" },
                    { 84, "Phil Ford" },
                    { 83, "Keith Temple" },
                    { 82, "James Moran" },
                    { 92, "Frank Cottrell-Boyce" },
                    { 53, "Barbara Clegg" },
                    { 67, "Rona Munro" },
                    { 51, "Eric Saward" },
                    { 24, "Victor Pemberton" },
                    { 23, "Henry Lincoln" },
                    { 22, "Mervyn Haisman" },
                    { 21, "Malcolm Hulke" },
                    { 20, "David Ellis" },
                    { 19, "Geoffrey Orme " },
                    { 18, "Kit Pedler" },
                    { 17, "Gerry Davis" },
                    { 16, "Ian Stuart Black" },
                    { 15, "Donald Tosh" },
                    { 14, "Brian Hayles" },
                    { 13, "Lesley Scott" },
                    { 52, "Peter Grimwade" },
                    { 11, "Donald Cotton" },
                    { 10, "William Emms" },
                    { 9, "Glyn Jones" },
                    { 8, "Bill Strutton" },
                    { 7, "Louis Marks" },
                    { 6, "Dennis Spooner" },
                    { 5, "Peter R. Newman" },
                    { 4, "John Lucarotti" },
                    { 3, "David Whitaker" },
                    { 2, "Terry Nation" },
                    { 25, "Norman Ashby" },
                    { 26, "Peter Ling" },
                    { 12, "Paul Erickson" },
                    { 28, "Robert Holmes" },
                    { 27, "Derrick Sherwin" },
                    { 50, "Christopher Bailey" },
                    { 49, "Terence Dudley" },
                    { 48, "Christopher H. Bidmead" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 47, "Johnny Byrne" },
                    { 46, "Stephen Gallagher" },
                    { 44, "Andrew McCulloch" },
                    { 43, "John Flanagan" },
                    { 42, "Anthony Read" },
                    { 41, "David Fisher" },
                    { 40, "Douglas Adams" },
                    { 45, "Andrew Smith" },
                    { 38, "Chris Boucher" },
                    { 29, "Terrance Dicks" },
                    { 39, "David Agnew" },
                    { 30, "Don Houghton" },
                    { 31, "Bob Baker" },
                    { 33, "Guy Leopold" },
                    { 32, "Dave Martin" },
                    { 35, "Robert Banks Stewart" },
                    { 36, "Stephen Harris" },
                    { 37, "Robin Bland" },
                    { 34, "Robert Sloman" }
                });

            migrationBuilder.InsertData(
                table: "Companions",
                columns: new[] { "CompanionId", "CompanionName", "WhoPlayed" },
                values: new object[,]
                {
                    { 46, "Rory Williams", "Arthur Darvill" },
                    { 43, "Adelaide Brooke", "Lindsay Duncan" },
                    { 45, "Amy Pond", "Karen Gillan" },
                    { 44, "Wilfred Mott", "Bernard Cribbins" },
                    { 47, "River Song", "Alex Kingston" },
                    { 42, "Lady Christina de Souza", "Michelle Ryan" },
                    { 38, "Donna Noble", "Catherine Tate" },
                    { 40, "Astrid Peth", "Kylie Minogue" },
                    { 39, "Martha Jones", "Freema Agyeman" },
                    { 37, "Mickey Smith", "Noel Clarke" },
                    { 48, "Craig Owens", "James Corden" },
                    { 35, "Adam Mitchell", "Bruno Langley" },
                    { 41, "Jackson Lake", "David Morrissey" },
                    { 49, "Clara Oswald", "Jenna Coleman" },
                    { 61, "Erimem", "Caroline Morris" },
                    { 51, "Bill Potts", "Pearl Mackie" },
                    { 52, "Graham O'Brien", "Bradley Walsh" },
                    { 53, "Ryan Sinclair", "Tosin Cole" },
                    { 54, "Yasmin Khan", "Mandip Gill" },
                    { 55, "Dan", "John Bishop" },
                    { 56, "Oliver Harper", "Tom Allen" },
                    { 57, "Anya Kingdom", "Jane Slavin" },
                    { 58, "Robert McIntosh", "Christian Coulson" }
                });

            migrationBuilder.InsertData(
                table: "Companions",
                columns: new[] { "CompanionId", "CompanionName", "WhoPlayed" },
                values: new object[,]
                {
                    { 59, "Thomas Brewster", "John Pickard" },
                    { 60, "Hannah Bartholomew", "Francesca Hunt" },
                    { 62, "Abby", "Ciara Janson" },
                    { 63, "Alayna", "Lisa Kay" },
                    { 64, "Brooke", "Joanna Horton" },
                    { 34, "Rose Tyler", "Billie Piper" },
                    { 50, "Nardole", "Matt Lucas" },
                    { 33, "Grace Holloway", "Daphne Ashbrook" },
                    { 36, "Captain Jack Harkness", "John Barrowman" },
                    { 31, "Mel Bush", "Bonnie Langford" },
                    { 1, "Susan Foreman", "Carole Ann Ford" },
                    { 2, "Barbara Wright", "Jacqueline Hill" },
                    { 3, "Ian Chesterton", "William Russell" },
                    { 4, "Vicki", "Maureen O'Brien" },
                    { 5, "Steven Taylor", "Peter Purves" },
                    { 6, "Katarina", "Adrienne Hill" },
                    { 7, "Sara Kingdom", "Jean Marsh" },
                    { 8, "Dodo Chaplet", "Jackie Lane" },
                    { 9, "Polly", "Anneke Wills" },
                    { 10, "Ben Jackson", "Michael Craze" },
                    { 11, "Jamie McCrimmon", "Frazer Hines" },
                    { 12, "Victoria Waterfield", "Deborah Watling" },
                    { 13, "Zoe Heriot", "Wendy Padbury" },
                    { 15, "Liz Shaw", "Caroline John" },
                    { 16, "Jo Grant", "Katy Manning" },
                    { 14, "Brigadier Lethbridge-Stewart", "Nicholas Courtney" },
                    { 18, "Sergeant John Benton", "John Levene" },
                    { 30, "Peri Brown", "Nicola Bryant" },
                    { 29, "Kamelion", "Gerald Flood" },
                    { 32, "Ace", "Sophie Aldred" },
                    { 28, "Vislor Turlough", "Mark Strickson" },
                    { 17, "Sarah Jane Smith", "Elisabeth Sladen" },
                    { 26, "Nyssa", "Sarah Sutton" },
                    { 25, "Adric", "Matthew Waterhouse" },
                    { 27, "Tegan Jovanka", "Janet Fielding" },
                    { 23, "Romana I", "Mary Tamm" },
                    { 22, "K-9", "John Leeson" },
                    { 21, "Leela", "Louise Jameson" },
                    { 20, "Harry Sullivan", "Ian Marter" },
                    { 19, "Captain Mike Yates", "Richard Franklin" },
                    { 24, "Romana II", "Lalla Ward" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "BirthDate", "DoctorName", "DoctorNumber", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { 9, new DateTime(1964, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher Eccleston", 9, new DateTime(2005, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "BirthDate", "DoctorName", "DoctorNumber", "FirstEpisodeDate" },
                values: new object[] { 13, new DateTime(1982, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jodie Whittaker", 13, new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "BirthDate", "DoctorName", "DoctorNumber", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[,]
                {
                    { 12, new DateTime(1958, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter Capaldi", 12, new DateTime(2014, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(1982, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matt Smith", 11, new DateTime(2010, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(1971, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "David Tennant", 10, new DateTime(2005, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(1959, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paul McGann", 8, new DateTime(1996, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1920, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrick Troughton", 2, new DateTime(1966, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(1943, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colin Baker", 6, new DateTime(1984, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1951, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter Davison", 5, new DateTime(1982, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1934, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom Baker", 4, new DateTime(1974, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1919, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jon Pertwee", 3, new DateTime(1970, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, new DateTime(1908, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "William Hartnell", 1, new DateTime(1963, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1966, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(1943, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sylvester McCoy", 7, new DateTime(1987, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Enemies",
                columns: new[] { "EnemyId", "Description", "EnemyName" },
                values: new object[,]
                {
                    { 70, "In seventeenth century Lancashire; there were literal witchhunts going on in the village of Bilehurst Cragg. One of the reasons for that was because the Morax were incarcerated inside nearby Pendle hill. Bilehurst means �sacred tree on a hill�. The tree in question was the lock that kept the Morax secure. When the tree was cut down the Morax started to ooze out and take over bodies � living or dead.", "Morax" },
                    { 51, "The Sisters of Plenitude were an order of Catkind nuns; devoted to helping the sick.", "Sisters of Plenitude (Hame; Jaff)" },
                    { 69, "Drahvins are a predominantly female species. Some males exist; but their numbers are kept low as chillingly; the men folk deemed surplus to requirements are killed. Female Drahvins are split into two groups. The largest is an underclass comprising individuals who were artificially created; cultured in test tubes. Theyre led by another group; the Drahvins ruling elite who are callous; militaristic and seemingly devoid of compassion.", "Drahvin" },
                    { 68, "Rutans are the bitter enemies of the Sontarans and both species have been locked in a war that stretches back centuries. The Doctor has even conjectured that the two races have forgotten the reason for their ongoing conflict! The Doctor encountered a Rutan scout on the island of Fang Rock in the early 1900s when it was revealed they were losing their relentless war and intended to use Earth as a strategic outpost against the Sontarans. Rutans share the Sontarans ruthlessness; caring little or nothing for other species. They can adopt different physical shapes and are able to kill with a single touch of their tendrils. But they are vulnerable to fire and can be destroyed using fairly crude weaponry. As a race they will stop at nothing  even the obliteration of Earth  in their quest to defeat the Sontarans.", "Rutans" },
                    { 67, "The Vashta Nerada are ravenous hunters able to strip the meat from a body with a frightening speed and efficiency. They tend to avoid light; often concealed in patches of dark that resemble shadows; hence the general warning to Stay out of the shadows if you suspect these creatures are close. Even species that are not consciously aware of the threat posed by the Vashta Nerada seem to sense their menace. As the Doctor once observed; Almost every species in the universe has an irrational fear of the dark. But theyre wrong. Because its not irrational. Its Vashta Nerada. In their natural state the Vashta Nerada are tiny but when they gather in large numbers theyre able to animate objects; including the remains of humans. Their adaptability is possibly one reason for their universality; they have encountered the Doctor in different centuries and their race has blighted numerous planets across the cosmos.", "Vashta Nerada" },
                    { 66, "There are also the Winders; half Smiler and half human; whove taken an oath to serve the system. And all together; these unhappy people and automatons are doing a terrible thing; which only the Doctor and Amy can save them from.", "Winder " },
                    { 65, "The Smilers are androids; mounted in booths all across the space faring version of Britain that left Earth in the 29th Century. They let people know whats good and whats bad. The terrified population keep them clean. Their heads can rotate to show three faces: happy; warning or very dangerous indeed. And if things get very dangerous; the Smilers can leave their booths and move around. Theyre actually androids; an extension of the starships security system.", "Smilers" },
                    { 64, "They have large lungs; powerful bodies and wear tough; black armour. The Judoon will punish physical assault with a judgement of death  implemented instantly and without compunction. They have a slavish obedience towards rules and when carrying out a law enforcement mission theyre singleminded to the point of brutality. The beings natural form is gelatinous; a snakelike mass of glowing tendrils with a mouth full of sharp teeth. Its capable of creating a perception filter to stop itself being seen; or to hide anything it wants to hide. Multiforms can live for millennia. This one has escaped from being the prisoner of the Atraxi. Prisoner Zero is so dangerous that; to stop it escaping again; theyre willing to destroy the world.", "Prisoner Zero" },
                    { 63, "The Dream Lord seems to know all about the Doctor. He seems to be an intangible being; with no physical form; a creator of deadly dreams and delusions; who delights in being offensive and annoying. He seems to be able to take the visions he creates from the imaginations of his victims. He seemed to have taken on the Doctor because he was a great challenge; and trapped him and his companions between two realities; daring them to guess which was real and which the dream. And he seemed to have cheated.", "Dream Lord" },
                    { 62, "The Teselecta is one of the most remarkable pieces of engineering the Doctor has ever encountered. Its purpose is grim: to travel through time; locate people deemed to have broken the law; and without killing them; send them to hell. But the technology behind these machines is awesome. Also known as Justice Department Vehicles; a Teselecta can adapt itself to resemble anyone whose likeness it has scanned. But more than this; it can transform itself to take on the appearance and functionality of nonliving matter; such as clothing or even a motorbike! The vehicle is staffed by a crew that have been miniaturised and kept in a Borrowerlike state by a compression field and the Teselecta the Doctor encountered in Berlin; 1938; was Justice Department Vehicle 6018. Deadly; powerful and almost unstoppable; it was only defeated when Amy forced its ruthless crew to abandon it.", "Teselecta" },
                    { 59, "The Minotaur encountered by the Doctor had been locked in a prison that resembled an Earth hotel. He was one of a race that invaded planets and set themselves up as gods to be worshipped. But when the indigenous population became secularised; they threw the aliens from their world. In the case of this Minotaur; it was jailed in an automated prison that drifted through space; snatching people with discernable belief systems. Their personal beliefs were then converted into food for the creature.", "The Minotaur" },
                    { 60, "The Peg Dolls inhabited the dolls house in Georges cupboard. But as the Doctor explained; it had become a psychic repository for all his fears which meant these were no ordinary dolls. They could move; speak and hunt! When Rory and Amy became trapped in the house; they stumbled across the dolls and at first believed they were harmless. But after the ghastly Purcell was captured by the dummylike creatures; they witnessed the horrifying transformation they force their victims to endure... It begins with the hands... Fingers stiffen and apparently turn to wood. And then the process spreads until the victim of the dolls has become like them. The Doctor called their state a living death but when Alexs unconditional love for his son allowed George to overcome his fears; the Peg Dolls were expelled from the house and reverted to their original form.", "Peg dolls" },
                    { 58, "The Headless Monks are deadly warriors; first encountered as they traded with Dorium in the Prequel to A Good Man Goes to War. They later assisted Madame Kovarian on Demons Run and were involved in the tragic battle that saw the deaths of both Strax and Lorna Bucket. It remains a Level One Heresy to lower the hood of a Headless Monk and some feared that even glancing beneath their cowls would result in execution. But on Demons Run; their hoods were turned back and we discovered that these enigmatic soldiers were literally headless!", "Headless Monks" },
                    { 57, "A great deal about these resolute robots remains a mystery. We dont even know their true designation as Handbots is simply their nickname. Theyre drones with no capacity for sympathy or rational thought; but they are not evil creatures. Theyre simply doing what they were programmed to do; even if it means keeping people on Apalapucia when they are desperate to escape.", "Handbots" },
                    { 56, "Walter Simeon�s life changed forever during one snowy day in 1842. As usual he was playing on his own; watched over by his fretting mother who remarked; �He never talks to anyone... He�s so alone.� But moments after she walked away; something incredible happened. Walter spoke to the snowman he was building and heard it reply. A sonorous voice concurred with his own thoughts. Don�t talk to them; the voice told him; they�re silly. Hadn�t he always said that? But still; the experience shook him� He began to run until the voice continued. �You don�t need anyone else!� Walter paused� Whether he realised it or not; his life had just become colder� Doctor Simeon appeared to be the Great Intelligence�s most important human servant and his devotion was absolute. �I serve you in this;� he once declared; �As in everything else.� Certainly; this misplaced loyalty was extraordinary and he was prepared to kill for the Intelligence; ruthlessly letting his army of deadly snowmen loose on unarmed workers. His dedication was all the more remarkable insofar as the ongoing plan entailed �the last winter of humankind�. But Simeon�s childhood disregard for other people had mutated into something more sinister and extreme; leaving him hellbent on the destruction of his fellow man.", "Dr Simeon" },
                    { 55, "The Doctor believed that the Shakri were a myth; a fiction to keep �the young of Gallifrey in their place�. But the Shakri exist: enigmatic; powerful and ruthless slaves to the Tally. The Shakri are a force steeped in mystery. They serve the Tally; but even the Doctor didn�t know precisely was this was; reflecting that some called it �Judgement Day� and others; �the Reckoning�. The Shakri implied it was an imperative which drove them to eliminate races that could be considered a contagion. Unfortunately; this was exactly how the Shakri viewed humanity; ignoring the species� achievements and seeing the people of Earth as a plague to be expunged before it spread into space.", "Shakri" },
                    { 54, "Multiforms can live for millennia. This one has escaped from being the prisoner of the Atraxi. Prisoner Zero is so dangerous that; to stop it escaping again; theyre willing to destroy the world. The Sea Devils travel long distances in submarine vessels; have developed heat ray weaponry that can be used underwater; and have used genetic engineering to create sea monsters such as the Myrka.", "Sea Devils" },
                    { 53, "The Tenth Doctor described Zygons as �Shape-shifting aliens from outer space!� Powerful; technologically advanced and with the ability to mimic the appearance of other living creatures; these horrors without a home had a deadly arsenal � everything from venom sacs in their mouths to the Loch Ness Monster!", "Zygons" },
                    { 52, "Lady Cassandra; was a former human in the far future. Along with other rich and powerful people of the universe; Cassandra was on Platform One; a space station orbiting Earth in the year 5;000;000;000; set to witness the destruction of the planet by the expansion of the Sun.", "Lady Cassandra" },
                    { 71, "The Pting is a small but mighty alien with sharp teeth; toxic skin; and can move faster than Usain Bolt. The creature is impossible to keep captive and can survive in the vacuum of space. The Doctor and friends got separated from the TARDIS and the Pting was eating the spaceship they were on � The Tsuranga. The Pting wasn�t malicious; but its natural behaviour would have caused the death of everyone on board the Tsuranga.", "Pting" },
                    { 61, "The Doctor has met many vile and brutal monsters during his travels but there was something chilling in Solomon�s total disregard for life  something so unspeakable that even the Doctor appeared unmoved by his terrible fate after leaving the Silurian ship. Solomon was a trader who tricked his way onto the Silurian spaceship. Once on board he realised the profit its cargo could bring and therefore ruthlessly killed its crew using two murderous robots he had bought cheaply from a concession on Illyria Seven. But things started to go wrong for Solomon when three raptors attacked him and injured his legs� Worse still; he found he couldn�t fly the spaceship and was therefore trapped with its precious cargo. When the Doctor and his friends boarded the ship; Solomon soon showed his callousness � ordering his robots to injure Brian because the Doctor questioned him. He demanded that the Time Lord repair his damaged limbs but making an enemy of the Doctor proved his undoing. When he tried to leave; abandoning the dinosaurs and kidnap Nefertiti in order to capitalise on her �value�; the Doctor placed a device in his craft that the ISA�s missile had locked onto. The Doctor rescued Nefertiti from the ship but left Solomon on board� Moments after the Doctor�s departure; the missiles found their mark and the vessel was destroyed in a fireball in space.", "Solomon" },
                    { 72, "There are around 45;000 species of Spiders on Earth. Spiders taste and smell through their feet. They give out pheromones and really like grime music. They aren�t responsible for what has happened to them. The spiders were just doing what came naturally. The Doctor taught her friends to respect the living creatures and preserve life wherever possible.", "Mutant Spiders" },
                    { 94, "Time zombies were versions of the Eleventh Doctor; Clara Oswald; and Gregor and Tricky Van Baalen from the near future. A tear in time caused them to appear within the Doctors TARDIS prior to their creation.", "Time Zombies" },
                    { 74, "The Monks were an alien race who used a virtual simulation of life on Earth in order to plan an invasion. Virtual constructs included simulations of the Twelfth Doctor; Nardole and Bill Potts. They were also able to see into the future through their simulation; and vowed to protect the Earth from the devastation they foresaw would occur in one year. However; they required genuine consent from people with power and were able to sense if their consent was true or they were acting out of fear or strategy. If their consent was not pure; the person would immediately be disintegrated.", "The Monks" },
                    { 95, "Mister Sweet was the wholly fictitious name that Winifred Gillyflower gave to a red leech she discovered in the year 1893. He resided on Gillyflowers chest; giving her his nectar. He was immediately recognised by Madame Vastra as being from the late Cretaceous Period; and a known menace to the Silurians. When Strax killed Gillyflower and Sweet tried to escape; Ada Gillyflower killed him with her cane.", "Mister Sweet" },
                    { 50, "Pig slaves were genetically alteredmutant humanpig hybrids. They were both the slaves and creations of the Cult of Skaro; following the Cults emergency temporal shift to New York City in the early 20th century. As servants; pig slaves were typically used for intense labour and strongarm work. When the pig slaves captured humans; the Daleks performed an intelligence scan on each of them. Humans of high intelligence were used for the Final Experiment; while those of low intelligence were turned into the pig slaves. One individual; Laszlo; was only partially transformed.", "Pig Slave" },
                    { 93, "The Crooked Man was a peculiarshaped creature trapped in a pocket universe. At some point; the Crooked Man became separated from his mate. He began chasing Hila Tacorien in the pocket universe; but the Eleventh Doctor; with the assistance of Emma Grayling; found her and took her to an echo of Caliburn House. The Doctor shut the Crooked Man behind a door in one of the echo houses rooms; but as Hila Tacorien was pulled to NSpace; the wormhole connecting the pocket universe to NSpace failed; and the Doctor was left behind.", "Crooked Man (Hide)" },
                    { 92, "The Whisper Men were a group of featureless beings that appeared to serve the Great Intelligence. They kidnapped the Paternoster Gang � Strax; Vastra and Jenny Flint � forcing the Eleventh Doctor to travel to Trenzalore and face his fate.", "The Whisper Men" },
                    { 91, "The creature was draconian in appearance; with four wings and a tail. Every hundred million years or so; the creature inside the Moon (which was really an egg) would hatch out and fly away into space. The creature would leave behind another egg or a new Moon that would continue to orbit Earth.", "The Moon Creature" },
                    { 90, "The Doctor described the Skovox Blitzer as one of the deadliest killing machines ever created; which is quite a claim; coming from someone who has faced Daleks; Quarks and a Raston Warrior Robot� When a single one of these hightech killers invaded modern day London it was enough to put the whole of humanity in danger. The Blitzer had enough explosives in its armoury to destroy the entire planet; meaning suddenly; nobody was safe.", "Skovox Blitzer " }
                });

            migrationBuilder.InsertData(
                table: "Enemies",
                columns: new[] { "EnemyId", "Description", "EnemyName" },
                values: new object[,]
                {
                    { 89, "The Teller was creature of awesome power able to telepathically sense guilt and turn a victim�s brain to �soup� without even touching them. These two abilities alone made him invaluable to the Bank of Karabraxos� ", "The Teller" },
                    { 88, "Madame Karabraxos was the Head of the Bank of Karabraxos; where she had a clone of herself in every facility; claiming it was the only way to control her own security. But despite placing faith in these myriad versions of herself; such as Ms Delphox (pictured); she was ruthless enough to burn them when she felt they had let her down.", "Madame Karabraxos" },
                    { 87, "The Foretold looks like an ancient; terrifying mummy  the kind of creature that has featured in scary stories and creaky horror movies for generations� But facts about the bandaged terror were scarce as the only ones who could see it were its victims; and a sighting of the creature meant only one thing for the witness: death! The Foretold was considered by many to be myth and according to the Doctor; tales about it first appeared over five thousand years ago. Some stories claimed that a secret riddle or a single word would stop it and he also mentioned that some victims tried to plead for their lives or attempted to buy their way out of trouble; but never with any success: Once someone had seen the Foretold; death would follow in exactly 66 seconds�", "Foretold" },
                    { 86, "The Boneless invasion seemed to begin and end in Bristol; England; where their victims were transformed into static; twodimensional images. The local community was baffled and the police appeared powerless to stop them. And then one day a young woman arrived who would help defeat these sinister monsters� A young woman who called herself the Doctor! The Boneless are aliens from beyond the known universe who have the ability to reduce threedimensional things; including humans; to twodimensional entities; barely distinguishable from paintings and murals.", "Boneless" },
                    { 85, "Colony Sarff was a servant to Davros. He was comprised of one large and many small sentient snakelike creatures. By working in unison; the snakes were able to mimic a single humanoid individual. However; each snake could act independently and the colony made decisions as a democracy.", "Colony Sarff" },
                    { 84, "Sandmen was the name given by Clara Oswald and the Twelfth Doctor to a carnivorous form of life created in the 38th century by human sleep dust after sleeping in a Morpheus pod. The pod changed the fundamental chemistry of the brain by sending a coded electronic signal to certain parts of it. The Sandmen could break apart into piles of sleep dust that were also released into the air that could gather information. The sandmen were also blind and relied on their hearing to hunt and consume their prey. The Sandmen absorbed their victims by reaching out branches of sleep dust to drag them into the Sandman itself.", "Sandman" },
                    { 83, "In the 38th century; Grunts were genetically created humans with low intelligence used for menial tasks. They could become fullgrown adults in less than five years. A Grunt numbered 474 was stationed on the Le Verrier space station. They were distinguished by markings on their faces; and due to their limited speech capacity; would be unable to articulate language very well and would frequently leave out words when speaking to someone. Grunts could also be programmed to respond to any physical threat.", "Grunt" },
                    { 82, "The Leonians were a lionesque humanoid race. They once attempted to invade Earth using the Eyes of Hades; an amuletlike device capable of opening rifts in space; delivered to the planet by their advance agent; Leandro.", "Leonians" },
                    { 81, "The Mire are one of the deadliest warrior races in the galaxy � a terrifying and technologically advanced army that is feared throughout the cosmos! The Mire augment their abilities with stolen technology from every race they conquer. They are heavily armoured with tech such as plasma cannons; holographic heads up displays and scanners; most of which is crammed into their helmets... But tech isn�t the only thing they steal from their conquests  by extracting testosterone; adrenaline; and other powerful human hormones from the Vikings; the Mire create �nectar� (or �warrior juice� as Clara calls it) which they carry in clear vials on their helmets and consume at high points of battle. Their helmets are therefore their biggest strength; and their biggest weakness.", "The Mire" },
                    { 80, "The Fisher King was a formidable warlord defeated by the Arcateenians and sent to be buried on Earth in the 1980s. But far from dead and determined to reassemble his armies; this warrior used an electromagnetic signal contained within a written message to communicate with his people. A message that turned anyone who laid eyes on it into a �ghost�� Strong; powerful and standing at over 8 foot tall; the Fisher King was an ancient alien warlord of unknown origin with a blaster incorporated into the arm on his armour. Standing at the head of a mighty army; he invaded the planet Tivoli and to the delight of the Tivolians; enslaved its inhabitants for ten years! Ultimately; the planet was liberated by the Arcateenians; and the Fisher King was believed to be killed in the onslaught. In accordance with Arcateenian custom; a barren savage outpost was chosen for the Fisher King�s burial: the planet Earth.", "Fisher King" },
                    { 79, "A LugalIrraKush was a humanoid species originating from one of the seven planets of the Sunsingers of Akhet. They could be identified by their long crests; large white eyes and small mouths. They attended the Festival of Offerings at the pyramid of the rings of Akhaten at least once.", "Lugal-Irra-Kush" },
                    { 78, "The Veil was a terrifying creature drawn from the Doctor�s own nightmares.", "The Veil" },
                    { 77, "Heather is haunted by something so strange; so out of the ordinary; so inexplicable; right at the heart of the university; that she just can�t shake it � an apparently simple puddle. And the striking defect in the shape of a star in her eye allows her to see what so many others have missed. That it isn�t an ordinary puddle at all. Her reflection just isn�t right.", "The Heather Creature" },
                    { 76, "Far in the future; when human technology has become super advanced and humans are living in small colonies on distant planets; it's no surprise that they have built artificially intelligent robots to do their work for them and keep everyone happy. And how do humans communicate with them? What aspects of human language might have survived over thousands of years? That's right; emoji!", "Emojibots" },
                    { 75, "Underneath the Thames; chained to the banks of the river; is an ancient creature of unknown origin. Alien or not; this giant sea snake has been responsible for the freezing of the Thames at regular intervals � none less so than during the last great Frost Fair of 1814!", "Thames river monster" },
                    { 73, "The Thijarians who met the Doctor were survivors of the destruction of their civilisation. They were not there at the end; to grieve of honour them. The Thijiarians did not come to Earth to kill. They watch over the victims of the fighting; and bore witness to those who died alone.", "The Thijarian" },
                    { 49, "Matron Casp was the leader of the Sisters of Plenitude. She controlled the experiments on the new humans in the Intensive Care Unit beneath New New York Hospital in the year 5;000;000;023. Casp used the experiments to cure other patients in New New York Hospital; where she was Matron. The hospital had great success in curing patients; but the existence of the new humans was kept a secret. Casp tried to divert the Tenth Doctor from the unit; but Cassandra OBrien; inhabiting the body of Rose Tyler; discovered the unit and led the Doctor to it. After rendering the Doctor unconscious with a noxious perfume; Cassandra demanded money from the Sisterhood in exchange for not informing the NNYPD about their criminal activities. Casp refused and responded to Cassandras threat by unsheathing her claws with a menacing hiss. In response; Cassandra let free the Intensive care patients. This resulted in the quick death of Casps colleague Sister Jatt.", "Matron Casp" },
                    { 26, "Once revered as the head of the Kaled Scientific Elite; Davros is now reviled throughout all the known galaxies as the creator of the Daleks! Davros was born during the Thousand Year War between the Kaleds and the Thals and although he did join the military; it was in a scientific capacity; aiming to create weapons that would destroy his people�s enemies forever.", "Davros" },
                    { 47, "Hoix had brown skin; sharp teeth; clawlike fingers and exposed gums. Hoix couldnt speak; they were only capable of growling and roaring.", "Hoix" },
                    { 20, "The body of an Ice Queen; but the heart and stomach of a fearsome Ice Warrior!", "Iraxxa" },
                    { 19, "Ice Warrior 'Friday' - so called because he reminded Colonel Godsacre and Captain Catchlove of Man Friday in Robinson Crusoe � was found injured and alone in a crashed spaceship on Earth in the 19th century.", "Friday" },
                    { 18, "The incredible bargain that the strange Landlord offers the house-hunting students seems too good to be true. And; to their horror; it turns out it is.", "The Landlord" },
                    { 17, "Congratulations on purchasing your Ganymede Systems series twelve smartsuit. Your life is in our hands! Oxygen is available at competitive prices. Please continue to breathe normally; and have your credit details ready!", "The Suits" },
                    { 16, "The minds of dead Time Lords uploaded to a living computer. Don�t get filed. Weirdly tall; gliding above the floor in their robes and headdresses with their faces unseen; the Cloister Wraiths were found in the Cloisters; a crypt beneath the capitol of Gallifrey; and were often referred to as �Sliders� by the Time Lords.", "Cloister Wraiths" },
                    { 15, "The self-confessed �Queen of Evil�. Turning good. Maybe. It�s really complicated� Missy is the latest incarnation of one of the Doctor�s oldest friends and quite possibly his most ruthless enemy - the Master. The Doctor was first reunited with this particular �version� of his old 'friend' when Missy allied herself with the Cybermen. She planned to convert the dead of planet Earth; �upgrading� the fallen into a vast army of silver soldiers. But unusually; she planned to give the Doctor this terrifying force; keen to see what he would do with such power. The Doctor shunned the opportunity; however; and Danny Pink was able to lead the �new born� Cybermen; meaning Missy�s scheme was defeated. But Clara wanted revenge on the Time Lady and seemed willing to kill her. The Doctor prevented this; although before we discovered what he himself would do; a solitary Cyberman � a figure which it later transpired could very well have been the Brigadier - appeared to destroy Missy.", "Missy" },
                    { 14, "A maitre d� who can make any problem disappear. Even if he has to digest passengers himself.", "Flemming" },
                    { 13, "Countless haunted house tales tell the story of a mysterious and spooky individual hiding in the attic; and the Landlord's creepy mansion is no exception. When Shireen and Bill stumble upon Eliza; a young woman formed entirely of wood and infested with woodlice creatures; they are seriously freaked out.", "Eliza " },
                    { 12, "Ever wondered why your floorboards creak as you make your way up to bed? Giant woodlice creatures; with two antennae and large pincers; they are alien insects which secretly inhabit the Earth. They can live inside wood; interacting with it on a cellular level; and inhabit the Landlord's huge wooden house - creaking around the floorboards; walls and furniture; waiting for human prey to suck into the wood with them.", "The Lice" },
                    { 11, "A malevolent cyborg known for ending battles by eating his enemies dead or alive. Don�t lose your head!", "Hydroflax" },
                    { 10, "A mythical Pictish Beast; discovered by the Doctor to be all too real�", "The Eaters of Light" },
                    { 9, "Leader of the Mire. The holographic face he presents to the Vikings reflects their belief in a god called Odin.", "Odin" },
                    { 8, "Leader of the rebel Zygon faction; Bonnie takes Clara�s form in order to infiltrate UNIT and advance the Zygon-rebel plan.", "Bonnie" },
                    { 7, "Technically a multi-nucleate organism; functioning as an infinitely adaptable; independently functioning; peripatetic central nervous system; each �brain� locked inside the brain vault at the heart of the Harmony Shoal building in New York is a tiny lifeform waiting for a compatible host. The only tell-tale sign that someone has been replaced by one of these brains is a faint scar running diagonally across the face and extremely bloodshot eyes. Sometimes blue liquid (in which the brains are stored) escapes from the host body. These creatures migrate from planet to planet�and now they have set their sights on the Earth.", "The Brains and Harmoney Shoal" },
                    { 6, "Lord Sutcliffe is rich; arrogant; untrustworthy and entitled. Some would say he�s a typical aristocrat. Big house. Huge staff. And a giant sea snake chained to the bottom of the Thames� evil.", "Lord Sutcliffe" },
                    { 5, "The Stenza are a warrior race and self-proclaimed conquerors of the Nine Systems.", "T'zim-Sha" },
                    { 4, "Krasko was released from prison and travelled back in time to change the past.", "Krasko" },
                    { 3, "The Postmen worked for a company called Kerblam � the biggest retailer in the galaxy. It picked; packed and delivered anything you could want.", "The Postmen" },
                    { 2, "The Antizone was a bleak; scary place; full of strange; deadly creatures. It landed here way back in the 9th century. After a long; deadly battle; The Dalek was defeated. It�s casing was destroyed; the creature inside was cut into three pieces so it could never reform.", "Creatures of the Antizone" },
                    { 1, "It landed here way back in the 9th century. After a long; deadly battle; The Dalek was defeated. It�s casing was destroyed; the creature inside was cut into three pieces so it could never reform. Two were successfully transported away and guarded by the order of the custodians. But one piece was left behind. It stayed in Sheffield; where it was found 12 centuries later and was accidentally woken up. You would think a squiddy thing like that couldn�t get far. But turns out it could hitch a ride on humans. It built it�s own casing from spare parts and bits of it�s original outer shell.", "Daleks" },
                    { 96, "Details regarding the Doctors earliest encounter with the Entity are sparse but its clear he was forced to imprison the creature as it was devouring its way through the universe. And so the Entity was trapped like a Genie in a bottle; until one day; Amy Pond broke the bottle and released it... The Entity feeds on time energy from the past and can therefore make its victim cease to exist. The Doctors dilemma was simple: he was reluctant to keep the Entity imprisoned but could not risk it consuming innocent people. He therefore unleashed the Entity on fourdimensional void creatures known as the Chronomites. The Entity could feed on their past; only to see them circle back in time unharmed.", "The Entity" },
                    { 21, "The Cybermen were originally human beings; but gradually they replaced their flesh with metal and plastic. In the process they lost their kindness; joy and every other emotion. They are now collaborating with Missy and have invaded Earth! As they swarm out of St. Paul�s Cathedral and across London; we look back on their history with the Doctor�", "Cybermen" },
                    { 48, "The Sycorax were a superstitious race of warriors and intergalactic plunderers.", "Sycorax (Fadros Pullujikaa)" }
                });

            migrationBuilder.InsertData(
                table: "Enemies",
                columns: new[] { "EnemyId", "Description", "EnemyName" },
                values: new object[,]
                {
                    { 22, "The Master is a Time Lord and like the Doctor; he�s from the planet Gallifrey in the constellation of Kasterborous. They were friends in their youth and both chose to ignore their people�s policy of nonintervention with other species; but unlike the Doctor; the Master chose to travel the universe causing chaos and revelling in wickedness on an epic scale.", "The Master " },
                    { 24, "The Ice Warriors are a mighty race hailing from Mars; the Red Planet. They are intelligent; powerful individuals and the Doctor has faced them at their most ruthless as they tried to wrestle Earth from humanity. But these hissing; menacing Martians have a code of honour and when the Third Doctor encountered them on Peladon he found they had abandoned their warlike ways in favour of a more peaceful; honourable approach to other species. The Ice Warriors are therefore capable of great good and terrible wickedness. Perhaps they are more like humanity than it would first appear�", "Ice Warriors" },
                    { 46, "According to the Master; he was an amalgamation of the Doctors darker sides from between his twelfth and final incarnations; who frequently menaced the Sixth Doctor so he could take the Doctors remaining lives.", "Atraxi" },
                    { 45, "The Valeyard was a sinister and mysterious Time Lordlike individual of uncertain origin.", "Valeyard" },
                    { 44, "Robot Yeti were servitors created by the Great Intelligence; originally as protectors before using them as an army.", "Yeti" },
                    { 43, "Sabalom Glitz was a rogue from the planet Salostopus in the galaxy of Andromeda. The morality of his activities was dubious even when their legality was not. Though Glitzs first love was money; he occasionally made uneasy alliances with the Doctor in his sixth and seventh incarnations; and also briefly worked with the Master.", "Sabalome Glitz" },
                    { 42, "The Nestene Consciousness; also known as the Nestenes; Crown Consciousness and Mother Consciousness to its Autons; (AUDIO: Brave New Town; PROSE: Revenge of the Nestenes) was a disembodied life force; a hive mind race and a singular entity existing as energy with the ability to possess plastic. The Third Doctor described the Nestenes as ruthlessly aggressive and intelligent. ", "Nestene Consciousness" },
                    { 41, "Ushas; better known as the Rani and known more formally as Ushas of Miasimia Goria; or; in other accounts; as simply Rani; was a renegade Time Lady and member of the Deca. A brilliant but cold neurochemist; she knew the Doctor and the Master when all three were young; and became an enemy of the former and an unwilling ally of the latter.", "Rani " },
                    { 40, "If you ever visit Mercy; as you near the town take a moment to scan the craggy hills and plains that surround it. That figure in the distance might just be a tourist; like you. Or maybe; just maybe; it�s the Gunslinger� Tasked with ending a long and bloody war; KahlerJex and a team of scientists created an army of deadly cyborgs. They took �volunteers� and told them they�d been selected for special training. But in reality these unwitting victims were experimented upon; their bodies fused with weaponry. And finally; they were programmed to kill. The cyborgs formed a devastating force that routed their enemy and ended the war in less than a week.", "The Gunslinger" },
                    { 39, "The Silence are a terrifying race who invaded Earth at an undetermined point in our history. They have powers of telepathy and can kill using a deadly discharge from their hands. But every Silent has a far eerier ability� Even if you see a Silent; you wont know youve spotted it as Silence somehow edit themselves from an observers memory. Glimpse one of these creatures and you may feel slightly unsettled the moment its out of view; but you wont remember anything about it. If and when you next see a Silent you may have a flashback to your first encounter; but again; when the Silent is out of view your mind will not recall ever seeing the alien.", "The Silence " },
                    { 38, "Possessing a natural and unique defence mechanism; the Angels are quantum locked. This means that they can only move when no other living creature; including their own kind; is looking at them. As soon as they are observed; they instantly turn to stone and cannot be killed. The Angels have the ability to send other beings into the past. This allows the Angels to feed on the potential time energy of what would have been the rest of their victims lives.", "Weeping Angels" },
                    { 37, "Roboforms were scavengers who travelled (as the Tenth Doctor said; like pilot fish) alongside invaders who took anything on the planet of value to them before the main threat (the metaphorical shark) arrived.", "Roboforms" },
                    { 36, "The Doctor described Judoon as policefor hire; adding; Theyre more like interplanetary thugs. They have large lungs; powerful bodies and wear tough; black armour. The Judoon will punish physical assault with a judgement of death  implemented instantly and without compunction. They have a slavish obedience towards rules and when carrying out a law enforcement mission theyre singleminded to the point of brutality.", "Judoon" },
                    { 35, "Fuldanquin Borusa was a notable and ultimately tragic figure in the history of the Time Lords of Gallifrey; and a very important figure in the life of the Doctor. At various points in his life; he assumed the ranks of Lord President; Cardinal and Chancellor of Gallifrey.", "Borusa" },
                    { 34, "The Doctor has faced several versions of the Cybermats; first encountering these small; deadly robots on Telos where they assisted their masters; the Cybermen; who were attempting to escape the confines of their icy tombs. These Cybermats; like later versions; were able to move silently; leap onto their victims and proved difficult to stop. Largely impervious to bullets; the Doctor defeated them using electricity. ?They later helped in the invasion of the Wheel and poisoned the crew of Nerva when Cybermen attempted to destroy Voga. The Eleventh Doctor encountered Cybermats in the Arctic and was attacked by another when he returned to England to visit his old friend; Craig.", "Cybermat" },
                    { 33, "The Autons were robots that resembled plastic shopwindow mannequins; animated by the Nestene Consciousness as soldiers. Though they were not the only creations of the Nestenes; they were the most easily identifiable and were utilised during every Earth invasion.", "Autons" },
                    { 32, "The Siren the Doctor encountered on the Fancy in the 17th Century was able to board the ship by using reflective surfaces as portals. She identified the ill and the injured and took skin samples from them. This process left a black spot on their palms. She then enticed the sailors to touch her  a task made easy by her beauty; seductive singing and mental hold over selected members of the crew. Finally; this touch allowed her to transport them to an incredibly advanced medical bay on a spaceship where they received hightech supervision. The Siren was misguided although not evil. She was terrifying but angelic; becoming demonic if you crossed her; yet ultimately she saved Rorys life and later allowed Amy to care for him. But only after shed signed a consent form.", "The Siren" },
                    { 31, "Ood are not monsters. They are a peaceful race; sophisticated and wise; and loyal friends of the Doctor. However; when they are taken over and controlled by evil entities they become monstrous creatures; acting against their instinct with lethal intent! The Ood known as Nephew was manipulated by the malevolent House and earlier; on Krop Tor; the Doctor encountered Ood possessed by an evil force that compelled them to attack humanity. When under the influence of others; Oodkind often undergo a change of eye colour; so watch out for Ood with red or green eyes! Ood individuals have two brains; communicate with each other using telepathy and although much about them remains a mystery; we have glimpsed their planet and marvelled at its majesty and beauty.", "The Ood" },
                    { 30, "We may never know precisely when; but Madame Kovarian was behind the kidnapping of Amy; shortly after she married Rory. She whisked her away and replaced her with a Flesh counterpart; took her baby and conditioned the child to kill the Doctor. Kovarian remains a mysterious figure but we know she has a strong connection with the Silence and was apparently in charge of events at the Battle of Demons Run. For reasons unknown she is desperate to destroy the Doctor and takes a terrible glee in his anguish.", "Madame Kovarian " },
                    { 29, "The Black Guardian; also known as the Guardian of Darkness and Chaos; was an anthropomorphic personification of the forces opposed to the powers of light; as embodied by the White Guardian. With the White Guardian and four others; he was part of the SixFold God known as the Guardians of Time.", "The Black Guardian" },
                    { 28, "The Great Intelligence is a deadly parasite � a malevolent force lacking corporeal form that uses human beings as its servants; sometimes willingly; but often against its victim�s wishes. Before racing away to find Clara; the Doctor stared at Doctor Simeon�s business card and the name printed on it stirred a memory. �The Great Intelligence�� he murmured. �Rings a bell...� The recollection is because the Time Lord has confronted the Intelligence on two previous occasions� ", "The Great Intelligence" },
                    { 27, "A CyberLeader was part of the hierarchy of the Cybermen originating on Mondas; Telos; and Planet 14.", "Cyber-leader" },
                    { 25, "The Silurians (Homo reptilia) were Earths first intelligent inhabitants; coldblood reptilians with a lifespan of over three centuries who developed a civilisation at least 300 million years before human beings evolved. Silurian astronomers predicated the arrival of a minor planet would devastate Earth; and so the species went into hibernation; with one genetic line being left as caretakers while the others slept. Time hid their cities underground; while the minor planet became Earths moon.", "Silurians" },
                    { 23, "Sontarans thrive on combat and delight in the rigours of warfare. They reproduce through cloning programmes meaning they can be created in huge numbers  ideal for a race of soldiers literally born to fight. They have one physical weakness  a small aperture at the rear of their thick; squat necks known as a probic vent. A blow to this can stun or even kill a Sontaran but with typical belligerence they believe it offers a kind of strength as it ensures they can never turn their back on opponents in battle. Their enduring enemies are a shapeshifting race known as the Rutans but Sontarans will; it seems; engage any species in battle. In the Fourth Doctors era they even had the temerity to attempt an invasion of Gallifrey itself. Their cunning and genius for warfare meant they almost succeeded and although they were narrowly defeated the Sontarans survived to indulge their passion for warfare throughout the universe.", "Sontarans" },
                    { 97, "Gangers were developed to work in environments too dangerous for people. Controlled remotely by a human operator they soon saved lives and money and most believed a Ganger was simply a tool; little more than a forklift truck. But the Doctor immediately recognised they were much more; insisting they had a mind and a soul. Gangers are formed from a type of flesh; once a reading has been taken it can be manipulated into anything; even replicating a living organism.", "The Gangers" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(1963, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 1, "An Unearthly Child (An Unearthly Child - Part One)" },
                    { 573, 51, 5, new DateTime(1982, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 19, "The Visitation - Part Two" },
                    { 574, 51, 5, new DateTime(1982, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 19, "The Visitation - Part Three" },
                    { 575, 51, 5, new DateTime(1982, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 19, "The Visitation - Part Four" },
                    { 576, 49, 5, new DateTime(1982, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 19, "Black Orchid - Part One" },
                    { 577, 49, 5, new DateTime(1982, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 19, "Black Orchid - Part Two" },
                    { 578, 51, 5, new DateTime(1982, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 19, "Earthshock - Part One" },
                    { 579, 51, 5, new DateTime(1982, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 19, "Earthshock - Part Two" },
                    { 580, 51, 5, new DateTime(1982, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 19, "Earthshock - Part Three" },
                    { 581, 51, 5, new DateTime(1982, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 19, "Earthshock - Part Four" },
                    { 582, 52, 5, new DateTime(1982, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 19, "Time-Flight - Part One" },
                    { 583, 52, 5, new DateTime(1982, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 19, "Time-Flight - Part Two" },
                    { 584, 52, 5, new DateTime(1982, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 19, "Time-Flight - Part Three" },
                    { 585, 52, 5, new DateTime(1982, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 19, "Time-Flight - Part Four" },
                    { 586, 47, 5, new DateTime(1983, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 20, "Arc of Infinity - Part One" },
                    { 587, 47, 5, new DateTime(1983, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 20, "Arc of Infinity - Part Two" },
                    { 588, 47, 5, new DateTime(1983, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 20, "Arc of Infinity - Part Three" },
                    { 589, 47, 5, new DateTime(1983, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 20, "Arc of Infinity - Part Four" },
                    { 590, 50, 5, new DateTime(1983, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 20, "Snakedance - Part One" },
                    { 591, 50, 5, new DateTime(1983, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 20, "Snakedance - Part Two" },
                    { 592, 50, 5, new DateTime(1983, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 20, "Snakedance - Part Three" },
                    { 593, 50, 5, new DateTime(1983, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 20, "Snakedance - Part Four" },
                    { 594, 52, 5, new DateTime(1983, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 20, "Mawdryn Undead - Part One" },
                    { 595, 52, 5, new DateTime(1983, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 20, "Mawdryn Undead - Part Two" },
                    { 572, 51, 5, new DateTime(1982, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 19, "The Visitation - Part One" },
                    { 596, 52, 5, new DateTime(1983, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 20, "Mawdryn Undead - Part Three" },
                    { 571, 50, 5, new DateTime(1982, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 19, "Kinda - Part Four" },
                    { 569, 50, 5, new DateTime(1982, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 19, "Kinda - Part Two" },
                    { 546, 29, 4, new DateTime(1980, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 18, "State of Decay - Part Three" },
                    { 547, 29, 4, new DateTime(1980, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 18, "State of Decay - Part Four" },
                    { 548, 46, 4, new DateTime(1981, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 18, "Warriors' Gate - Part One" },
                    { 549, 46, 4, new DateTime(1981, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 18, "Warriors' Gate - Part Two" },
                    { 550, 46, 4, new DateTime(1981, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 18, "Warriors' Gate - Part Three" },
                    { 551, 46, 4, new DateTime(1981, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 18, "Warriors' Gate - Part Four" },
                    { 552, 47, 4, new DateTime(1981, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 18, "The Keeper of Traken - Part One" },
                    { 553, 47, 4, new DateTime(1981, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 18, "The Keeper of Traken - Part Two" },
                    { 554, 47, 4, new DateTime(1981, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 18, "The Keeper of Traken - Part Three" },
                    { 555, 47, 4, new DateTime(1981, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 18, "The Keeper of Traken - Part Four" },
                    { 556, 48, 4, new DateTime(1981, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 18, "Logopolis - Part One" },
                    { 557, 48, 4, new DateTime(1981, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 18, "Logopolis - Part Two" },
                    { 558, 48, 4, new DateTime(1981, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Classic", "", 18, "Logopolis - Part Three" },
                    { 559, 48, 4, new DateTime(1981, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Classic", "", 18, "Logopolis - Part Four" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 560, 48, 5, new DateTime(1982, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 19, "Castrovalva - Part One" },
                    { 561, 48, 5, new DateTime(1982, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 19, "Castrovalva - Part Two" },
                    { 562, 48, 5, new DateTime(1982, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 19, "Castrovalva - Part Three" },
                    { 563, 48, 5, new DateTime(1982, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 19, "Castrovalva - Part Four" },
                    { 564, 49, 5, new DateTime(1982, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 19, "Four to Doomsday - Part One" },
                    { 565, 49, 5, new DateTime(1982, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 19, "Four to Doomsday - Part Two" },
                    { 566, 49, 5, new DateTime(1982, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 19, "Four to Doomsday - Part Three" },
                    { 567, 49, 5, new DateTime(1982, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 19, "Four to Doomsday - Part Four" },
                    { 568, 50, 5, new DateTime(1982, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 19, "Kinda - Part One" },
                    { 570, 50, 5, new DateTime(1982, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 19, "Kinda - Part Three" },
                    { 545, 29, 4, new DateTime(1980, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 18, "State of Decay - Part Two" },
                    { 597, 52, 5, new DateTime(1983, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 20, "Mawdryn Undead - Part Four" },
                    { 599, 46, 5, new DateTime(1983, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 20, "Terminus - Part Two" },
                    { 627, 28, 5, new DateTime(1984, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 21, "The Caves of Androzani - Part Three" },
                    { 628, 28, 5, new DateTime(1984, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 21, "The Caves of Androzani - Part Four" },
                    { 629, 55, 6, new DateTime(1984, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 21, "The Twin Dilemma - Part One" },
                    { 630, 55, 6, new DateTime(1984, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 21, "The Twin Dilemma - Part Two" },
                    { 631, 55, 6, new DateTime(1984, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 21, "The Twin Dilemma - Part Three" },
                    { 632, 55, 6, new DateTime(1984, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 21, "The Twin Dilemma - Part Four" },
                    { 633, 58, 6, new DateTime(1985, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 22, "Attack of the Cybermen - Part One " },
                    { 634, 58, 6, new DateTime(1985, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 22, "Attack of the Cybermen - Part Two " },
                    { 635, 56, 6, new DateTime(1985, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 22, "Vengeance on Varos - Part One " },
                    { 636, 56, 6, new DateTime(1985, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 22, "Vengeance on Varos - Part Two " },
                    { 637, 57, 6, new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 22, "The Mark of the Rani - Part One " },
                    { 638, 57, 6, new DateTime(1985, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 22, "The Mark of the Rani - Part Two " },
                    { 639, 28, 6, new DateTime(1985, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 22, "The Two Doctors - Part One " },
                    { 640, 28, 6, new DateTime(1985, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 22, "The Two Doctors - Part Two " },
                    { 641, 28, 6, new DateTime(1985, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 22, "The Two Doctors - Part Three " },
                    { 642, 59, 6, new DateTime(1985, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 22, "Timelash - Part One " },
                    { 643, 59, 6, new DateTime(1985, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 22, "Timelash - Part Two " },
                    { 644, 51, 6, new DateTime(1985, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 22, "Revelation of the Daleks - Part One " },
                    { 645, 51, 6, new DateTime(1985, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 22, "Revelation of the Daleks - Part Two " },
                    { 646, 28, 6, new DateTime(1986, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 23, "The Trial of a Time Lord - Part One (The Mysterious Planet)" },
                    { 647, 28, 6, new DateTime(1986, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 23, "The Trial of a Time Lord - Part Two (The Mysterious Planet)" },
                    { 648, 28, 6, new DateTime(1986, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 23, "The Trial of a Time Lord - Part Three (The Mysterious Planet)" },
                    { 649, 28, 6, new DateTime(1986, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 23, "The Trial of a Time Lord - Part Four (The Mysterious Planet)" },
                    { 626, 28, 5, new DateTime(1984, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 21, "The Caves of Androzani - Part Two" },
                    { 598, 46, 5, new DateTime(1983, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 20, "Terminus - Part One" },
                    { 625, 28, 5, new DateTime(1984, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 21, "The Caves of Androzani - Part One" },
                    { 623, 52, 5, new DateTime(1984, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 21, "Planet of Fire - Part Three" },
                    { 600, 46, 5, new DateTime(1983, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 20, "Terminus - Part Three" },
                    { 601, 46, 5, new DateTime(1983, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 20, "Terminus - Part Four" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 602, 53, 5, new DateTime(1983, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 20, "Enlightenment - Part One" },
                    { 603, 53, 5, new DateTime(1983, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 20, "Enlightenment - Part Two" },
                    { 604, 53, 5, new DateTime(1983, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 20, "Enlightenment - Part Three" },
                    { 605, 53, 5, new DateTime(1983, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 20, "Enlightenment - Part Four" },
                    { 606, 49, 5, new DateTime(1983, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 20, "The King's Demons - Part One" },
                    { 607, 49, 5, new DateTime(1983, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 20, "The King's Demons - Part Two" },
                    { 608, 29, 5, new DateTime(1983, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Special", "", 20, "The Five Doctors" },
                    { 609, 47, 5, new DateTime(1984, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 21, "Warriors of the Deep - Part One" },
                    { 610, 47, 5, new DateTime(1984, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 21, "Warriors of the Deep - Part Two" },
                    { 611, 47, 5, new DateTime(1984, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 21, "Warriors of the Deep - Part Three" },
                    { 612, 47, 5, new DateTime(1984, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 21, "Warriors of the Deep - Part Four" },
                    { 613, 54, 5, new DateTime(1984, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 21, "The Awakening - Part One" },
                    { 614, 54, 5, new DateTime(1984, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 21, "The Awakening - Part Two" },
                    { 615, 48, 5, new DateTime(1984, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 21, "Frontios - Part One" },
                    { 616, 48, 5, new DateTime(1984, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 21, "Frontios - Part Two" },
                    { 617, 48, 5, new DateTime(1984, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 21, "Frontios - Part Three" },
                    { 618, 48, 5, new DateTime(1984, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 21, "Frontios - Part Four" },
                    { 619, 51, 5, new DateTime(1984, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 21, "Resurrection of the Daleks - Part One" },
                    { 620, 51, 5, new DateTime(1984, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 21, "Resurrection of the Daleks - Part Two " },
                    { 621, 52, 5, new DateTime(1984, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 21, "Planet of Fire - Part One" },
                    { 622, 52, 5, new DateTime(1984, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 21, "Planet of Fire - Part Two" },
                    { 624, 52, 5, new DateTime(1984, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 21, "Planet of Fire - Part Four" },
                    { 544, 29, 4, new DateTime(1980, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 18, "State of Decay - Part One" },
                    { 543, 45, 4, new DateTime(1980, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 18, "Full Circle - Part Four" },
                    { 542, 45, 4, new DateTime(1980, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 18, "Full Circle - Part Three" },
                    { 464, 38, 4, new DateTime(1977, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 15, "Image of the Fendahl - Part Three" },
                    { 465, 38, 4, new DateTime(1977, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 15, "Image of the Fendahl - Part Four" },
                    { 466, 28, 4, new DateTime(1977, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 15, "The Sun Makers - Part One" },
                    { 467, 28, 4, new DateTime(1977, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 15, "The Sun Makers - Part Two" },
                    { 468, 28, 4, new DateTime(1977, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 15, "The Sun Makers - Part Three" },
                    { 469, 28, 4, new DateTime(1977, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 15, "The Sun Makers - Part Four" },
                    { 470, 31, 4, new DateTime(1978, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 15, "Underworld - Part One" },
                    { 471, 31, 4, new DateTime(1978, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 15, "Underworld - Part Two" },
                    { 472, 31, 4, new DateTime(1978, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 15, "Underworld - Part Three" },
                    { 473, 31, 4, new DateTime(1978, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 15, "Underworld - Part Four" },
                    { 474, 39, 4, new DateTime(1978, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 15, "The Invasion of Time - Part One" },
                    { 475, 39, 4, new DateTime(1978, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 15, "The Invasion of Time - Part Two" },
                    { 476, 39, 4, new DateTime(1978, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 15, "The Invasion of Time - Part Three" },
                    { 477, 39, 4, new DateTime(1978, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 15, "The Invasion of Time - Part Four" },
                    { 478, 39, 4, new DateTime(1978, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 15, "The Invasion of Time - Part Five" },
                    { 479, 39, 4, new DateTime(1978, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 15, "The Invasion of Time - Part Six" },
                    { 480, 28, 4, new DateTime(1978, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 16, "The Ribos Operation - Part One" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 481, 28, 4, new DateTime(1978, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 16, "The Ribos Operation - Part Two" },
                    { 482, 28, 4, new DateTime(1978, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 16, "The Ribos Operation - Part Three" },
                    { 483, 28, 4, new DateTime(1978, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 16, "The Ribos Operation - Part Four" },
                    { 484, 40, 4, new DateTime(1978, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 16, "The Pirate Planet - Part One" },
                    { 485, 40, 4, new DateTime(1978, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 16, "The Pirate Planet - Part Two" },
                    { 486, 40, 4, new DateTime(1978, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 16, "The Pirate Planet - Part Three" },
                    { 463, 38, 4, new DateTime(1977, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 15, "Image of the Fendahl - Part Two" },
                    { 487, 40, 4, new DateTime(1978, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 16, "The Pirate Planet - Part Four" },
                    { 462, 38, 4, new DateTime(1977, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 15, "Image of the Fendahl - Part One" },
                    { 460, 31, 4, new DateTime(1977, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 15, "The Invisible Enemy - Part Three" },
                    { 437, 28, 4, new DateTime(1976, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 14, "The Deadly Assassin - Part Two" },
                    { 438, 28, 4, new DateTime(1976, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 14, "The Deadly Assassin - Part Three" },
                    { 439, 28, 4, new DateTime(1976, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 14, "The Deadly Assassin - Part Four" },
                    { 440, 38, 4, new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 14, "The Face of Evil - Part One" },
                    { 441, 38, 4, new DateTime(1977, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 14, "The Face of Evil - Part Two" },
                    { 442, 38, 4, new DateTime(1977, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 14, "The Face of Evil - Part Three" },
                    { 443, 38, 4, new DateTime(1977, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 14, "The Face of Evil - Part Four" },
                    { 444, 38, 4, new DateTime(1977, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 14, "The Robots of Death - Part One" },
                    { 445, 38, 4, new DateTime(1977, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 14, "The Robots of Death - Part Two" },
                    { 446, 38, 4, new DateTime(1977, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 14, "The Robots of Death - Part Three" },
                    { 447, 38, 4, new DateTime(1977, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 14, "The Robots of Death - Part Four" },
                    { 448, 28, 4, new DateTime(1977, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 14, "The Talons of Weng-Chiang - Part One" },
                    { 449, 28, 4, new DateTime(1977, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 14, "The Talons of Weng-Chiang - Part Two" },
                    { 450, 28, 4, new DateTime(1977, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 14, "The Talons of Weng-Chiang - Part Three" },
                    { 451, 28, 4, new DateTime(1977, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 14, "The Talons of Weng-Chiang - Part Four" },
                    { 452, 28, 4, new DateTime(1977, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 14, "The Talons of Weng-Chiang - Part Five" },
                    { 453, 28, 4, new DateTime(1977, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 14, "The Talons of Weng-Chiang - Part Six" },
                    { 454, 29, 4, new DateTime(1977, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 15, "Horror of Fang Rock - Part One" },
                    { 455, 29, 4, new DateTime(1977, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 15, "Horror of Fang Rock - Part Two" },
                    { 456, 29, 4, new DateTime(1977, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 15, "Horror of Fang Rock - Part Three" },
                    { 457, 29, 4, new DateTime(1977, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 15, "Horror of Fang Rock - Part Four" },
                    { 458, 31, 4, new DateTime(1977, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 15, "The Invisible Enemy - Part One" },
                    { 459, 31, 4, new DateTime(1977, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 15, "The Invisible Enemy - Part Two" },
                    { 461, 31, 4, new DateTime(1977, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 15, "The Invisible Enemy - Part Four" },
                    { 488, 41, 4, new DateTime(1978, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 16, "The Stones of Blood - Part One" },
                    { 489, 41, 4, new DateTime(1978, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 16, "The Stones of Blood - Part Two" },
                    { 490, 41, 4, new DateTime(1978, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 16, "The Stones of Blood - Part Three" },
                    { 519, 31, 4, new DateTime(1979, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 17, "Nightmare of Eden - Part Two" },
                    { 520, 31, 4, new DateTime(1979, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 17, "Nightmare of Eden - Part Three" },
                    { 521, 31, 4, new DateTime(1979, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 17, "Nightmare of Eden - Part Four" },
                    { 522, 42, 4, new DateTime(1979, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 17, "The Horns of Nimon - Part One" },
                    { 523, 42, 4, new DateTime(1979, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 17, "The Horns of Nimon - Part Two" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 524, 42, 4, new DateTime(1980, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 17, "The Horns of Nimon - Part Three" },
                    { 525, 42, 4, new DateTime(1980, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 17, "The Horns of Nimon - Part Four" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 526, 40, 4, 21, "Classic", "", 17, "Shada - Part One" },
                    { 527, 40, 4, 22, "Classic", "", 17, "Shada - Part Two" },
                    { 528, 40, 4, 23, "Classic", "", 17, "Shada - Part Three" },
                    { 529, 40, 4, 24, "Classic", "", 17, "Shada - Part Four" },
                    { 530, 40, 4, 25, "Classic", "", 17, "Shada - Part Five" },
                    { 531, 40, 4, 26, "Classic", "", 17, "Shada - Part Six" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 532, 41, 4, new DateTime(1980, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 18, "The Leisure Hive - Part One" },
                    { 533, 41, 4, new DateTime(1980, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 18, "The Leisure Hive - Part Two" },
                    { 534, 41, 4, new DateTime(1980, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 18, "The Leisure Hive - Part Three" },
                    { 535, 41, 4, new DateTime(1980, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 18, "The Leisure Hive - Part Four" },
                    { 536, 43, 4, new DateTime(1980, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 18, "Meglos - Part One" },
                    { 537, 43, 4, new DateTime(1980, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 18, "Meglos - Part Two" },
                    { 538, 43, 4, new DateTime(1980, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 18, "Meglos - Part Three" },
                    { 539, 43, 4, new DateTime(1980, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 18, "Meglos - Part Four" },
                    { 540, 45, 4, new DateTime(1980, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 18, "Full Circle - Part One" },
                    { 541, 45, 4, new DateTime(1980, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 18, "Full Circle - Part Two" },
                    { 518, 31, 4, new DateTime(1979, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 17, "Nightmare of Eden - Part One" },
                    { 517, 41, 4, new DateTime(1979, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 17, "The Creature from the Pit - Part Four" },
                    { 516, 41, 4, new DateTime(1979, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 17, "The Creature from the Pit - Part Three" },
                    { 515, 41, 4, new DateTime(1979, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 17, "The Creature from the Pit - Part Two" },
                    { 491, 41, 4, new DateTime(1978, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 16, "The Stones of Blood - Part Four" },
                    { 492, 41, 4, new DateTime(1978, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 16, "The Androids of Tara - Part One" },
                    { 493, 41, 4, new DateTime(1978, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 16, "The Androids of Tara - Part Two" },
                    { 494, 41, 4, new DateTime(1978, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 16, "The Androids of Tara - Part Three" },
                    { 495, 41, 4, new DateTime(1978, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 16, "The Androids of Tara - Part Four" },
                    { 496, 28, 4, new DateTime(1978, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 16, "The Power of Kroll - Part One" },
                    { 497, 28, 4, new DateTime(1978, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 16, "The Power of Kroll - Part Two" },
                    { 498, 28, 4, new DateTime(1979, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 16, "The Power of Kroll - Part Three" },
                    { 499, 28, 4, new DateTime(1979, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 16, "The Power of Kroll - Part Four" },
                    { 500, 31, 4, new DateTime(1979, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 16, "The Armageddon Factor - Part One" },
                    { 501, 31, 4, new DateTime(1979, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 16, "The Armageddon Factor - Part Two" },
                    { 650, 56, 6, new DateTime(1986, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 23, "The Trial of a Time Lord - Part Five (Mindwarp)" },
                    { 502, 31, 4, new DateTime(1979, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 16, "The Armageddon Factor - Part Three" },
                    { 504, 31, 4, new DateTime(1979, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 16, "The Armageddon Factor - Part Five" },
                    { 505, 31, 4, new DateTime(1979, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 16, "The Armageddon Factor - Part Six" },
                    { 506, 2, 4, new DateTime(1979, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 17, "Destiny of the Daleks - Part One" },
                    { 507, 2, 4, new DateTime(1979, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 17, "Destiny of the Daleks - Part Two" },
                    { 508, 2, 4, new DateTime(1979, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 17, "Destiny of the Daleks - Part Three" },
                    { 509, 2, 4, new DateTime(1979, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 17, "Destiny of the Daleks - Part Four" },
                    { 510, 39, 4, new DateTime(1979, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 17, "City of Death - Part One" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 511, 39, 4, new DateTime(1979, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 17, "City of Death - Part Two" },
                    { 512, 39, 4, new DateTime(1979, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 17, "City of Death - Part Three" },
                    { 513, 39, 4, new DateTime(1979, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 17, "City of Death - Part Four" },
                    { 514, 41, 4, new DateTime(1979, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 17, "The Creature from the Pit - Part One" },
                    { 503, 31, 4, new DateTime(1979, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 16, "The Armageddon Factor - Part Four" },
                    { 436, 28, 4, new DateTime(1976, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 14, "The Deadly Assassin - Part One" },
                    { 651, 56, 6, new DateTime(1986, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 23, "The Trial of a Time Lord - Part Six (Mindwarp)" },
                    { 653, 56, 6, new DateTime(1986, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 23, "The Trial of a Time Lord - Part Eight (Mindwarp)" },
                    { 790, 73, 11, new DateTime(2011, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Special", "", 33, "The Doctor; the Window; and the Wardrobe" },
                    { 791, 73, 11, new DateTime(2012, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Revised", "", 33, "Asylum of the Daleks " },
                    { 792, 81, 11, new DateTime(2012, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Revised", "", 33, "Dinosaurs on a Spaceship " },
                    { 793, 74, 11, new DateTime(2012, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Revised", "", 33, "A Town Called Mercy " },
                    { 794, 81, 11, new DateTime(2012, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Revised", "", 33, "The Power of Three " },
                    { 795, 73, 11, new DateTime(2012, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Revised", "", 33, "The Angels Take Manhattan " },
                    { 796, 73, 11, new DateTime(2012, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Special", "", 33, "The Snowmen" },
                    { 797, 73, 11, new DateTime(2013, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Revised", "", 33, "The Bells of Saint John " },
                    { 798, 89, 11, new DateTime(2013, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Revised", "", 33, "The Rings of Akhaten " },
                    { 799, 70, 11, new DateTime(2013, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Revised", "", 33, "Cold War " },
                    { 800, 89, 11, new DateTime(2013, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Revised", "", 33, "Hide " },
                    { 801, 87, 11, new DateTime(2013, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Revised", "", 33, "Journey to the Centre of the TARDIS " },
                    { 802, 70, 11, new DateTime(2013, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Revised", "", 33, "The Crimson Horror " },
                    { 803, 88, 11, new DateTime(2013, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Revised", "", 33, "Nightmare in Silver " },
                    { 804, 73, 11, new DateTime(2013, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Revised", "", 33, "The Name of the Doctor " }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeType", "Notes", "Title" },
                values: new object[,]
                {
                    { 805, 73, 11, new DateTime(2013, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Special", "", "The Day of the Doctor" },
                    { 806, 73, 11, new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Special", "", "The Time of the Doctor" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 807, 73, 12, new DateTime(2014, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Revised", "", 34, "Deep Breath " },
                    { 808, 84, 12, new DateTime(2014, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Revised", "", 34, "Into the Dalek " },
                    { 809, 70, 12, new DateTime(2014, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Revised", "", 34, "Robot of Sherwood " },
                    { 810, 73, 12, new DateTime(2014, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Revised", "", 34, "Listen " },
                    { 811, 87, 12, new DateTime(2014, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Revised", "", 34, "Time Heist " },
                    { 812, 78, 12, new DateTime(2014, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Revised", "", 34, "The Caretaker " },
                    { 789, 73, 11, new DateTime(2011, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Revised", "", 32, "The Wedding of River Song " },
                    { 813, 90, 12, new DateTime(2014, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Revised", "", 34, "Kill the Moon " },
                    { 788, 73, 11, new DateTime(2011, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Revised", "", 32, "Closing Time " },
                    { 786, 77, 11, new DateTime(2011, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Revised", "", 32, "The Girl Who Waited " },
                    { 763, 69, 11, new DateTime(2010, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Revised", "", 31, "The Eleventh Hour " },
                    { 764, 69, 11, new DateTime(2010, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Revised", "", 31, "The Beast Below " },
                    { 765, 69, 11, new DateTime(2010, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Revised", "", 31, "Victory of the Daleks " },
                    { 766, 69, 11, new DateTime(2010, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Revised", "", 31, "The Time of Angels " },
                    { 767, 69, 11, new DateTime(2010, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Revised", "", 31, "Flesh and Stone " },
                    { 768, 73, 11, new DateTime(2010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Revised", "", 31, "The Vampires of Venice " },
                    { 769, 73, 11, new DateTime(2010, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Revised", "", 31, "Amy's Choice " }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 770, 70, 11, new DateTime(2010, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Revised", "", 31, "The Hungry Earth " },
                    { 771, 73, 11, new DateTime(2010, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Revised", "", 31, "Cold Blood " },
                    { 772, 73, 11, new DateTime(2010, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Revised", "", 31, "Vincent and the Doctor " },
                    { 773, 74, 11, new DateTime(2010, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Revised", "", 31, "The Lodger " },
                    { 774, 85, 11, new DateTime(2010, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Revised", "", 31, "The Pandorica Opens " },
                    { 775, 81, 11, new DateTime(2010, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Revised", "", 31, "The Big Bang " },
                    { 776, 73, 11, new DateTime(2010, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Special", "", 32, "A Christams Carol" },
                    { 777, 81, 11, new DateTime(2011, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Revised", "", 32, "The Impossible Astronaut " },
                    { 778, 86, 11, new DateTime(2011, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Revised", "", 32, "Day of the Moon " },
                    { 779, 78, 11, new DateTime(2011, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Revised", "", 32, "The Curse of the Black Spot " },
                    { 780, 73, 11, new DateTime(2011, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Revised", "", 32, "The Doctor's Wife " },
                    { 781, 73, 11, new DateTime(2011, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Revised", "", 32, "The Rebel Flesh " },
                    { 782, 73, 11, new DateTime(2011, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Revised", "", 32, "The Almost People " },
                    { 783, 73, 11, new DateTime(2011, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Revised", "", 32, "A Good Man Goes to War " },
                    { 784, 87, 11, new DateTime(2011, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Revised", "", 32, "Let's Kill Hitler " },
                    { 785, 88, 11, new DateTime(2011, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Revised", "", 32, "Night Terrors " },
                    { 787, 77, 11, new DateTime(2011, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Revised", "", 32, "The God Complex " }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeType", "Notes", "Title" },
                values: new object[] { 762, 69, 10, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Special", "", "The End of Time � Part Two" });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 814, 91, 12, new DateTime(2014, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Revised", "", 34, "Mummy on the Orient Express " },
                    { 816, 92, 12, new DateTime(2014, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Revised", "", 34, "In the Forest of the Night " },
                    { 844, 73, 12, new DateTime(2017, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Revised", "", 36, "World Enough and Time " },
                    { 845, 73, 12, new DateTime(2017, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Revised", "", 36, "The Doctor Falls " },
                    { 846, 73, 12, new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Special", "", 36, "Twice Upon a Time" },
                    { 847, 81, 13, new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Revised", "", 37, "The Woman Who Fell to Earth" },
                    { 848, 81, 13, new DateTime(2018, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Revised", "", 37, "The Ghost Monument " },
                    { 849, 81, 13, new DateTime(2018, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Revised", "", 37, "Rosa " },
                    { 850, 81, 13, new DateTime(2018, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Revised", "", 37, "Arachnids in the UK " },
                    { 851, 81, 13, new DateTime(2018, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Revised", "", 37, "The Tsuranga Conundrum " },
                    { 852, 97, 13, new DateTime(2018, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Revised", "", 37, "Demons of the Punjab " },
                    { 853, 98, 13, new DateTime(2018, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Revised", "", 37, "Kerblam! " },
                    { 854, 99, 13, new DateTime(2018, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Revised", "", 37, "The Witchfinders " },
                    { 855, 100, 13, new DateTime(2018, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Revised", "", 37, "It Takes You Away " },
                    { 856, 81, 13, new DateTime(2018, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Revised", "", 37, "The Battle of Ranskoor Av Kolos " },
                    { 857, 81, 13, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Special", "", 37, "Resolution" },
                    { 858, 81, 13, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Revised", "", 38, "Spyfall - Part 1 " },
                    { 859, 81, 13, new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Revised", "", 38, "Spyfall - Part 2 " },
                    { 860, 100, 13, new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Revised", "", 38, "Orphan 55 " },
                    { 861, 101, 13, new DateTime(2020, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Revised", "", 38, "Nikola Tesla's Night of Terror" },
                    { 862, 81, 13, new DateTime(2020, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Revised", "", 38, "Fugitive of the Judoon" },
                    { 863, 81, 13, new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Revised", "", 38, "Praxeus" },
                    { 864, 81, 13, new DateTime(2020, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Revised", "", 38, "Can You Hear Me?" },
                    { 865, 103, 13, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Revised", "", 38, "The Haunting of Villa Diodati" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 866, 81, 13, new DateTime(2020, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Revised", "", 38, "Ascension of the Cybermen" },
                    { 843, 67, 12, new DateTime(2017, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Revised", "", 36, "The Eaters of Light " },
                    { 815, 91, 12, new DateTime(2014, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Revised", "", 34, "Flatline " },
                    { 842, 70, 12, new DateTime(2017, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Revised", "", 36, "Empress of Mars " },
                    { 840, 73, 12, new DateTime(2017, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Revised", "", 36, "The Pyramid at the End of the World " },
                    { 817, 73, 12, new DateTime(2014, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Revised", "", 34, "Dark Water " },
                    { 818, 73, 12, new DateTime(2014, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Revised", "", 34, "Death in Heaven " },
                    { 819, 73, 12, new DateTime(2014, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Special", "", 35, "Last Christmas" },
                    { 820, 73, 12, new DateTime(2015, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Revised", "", 35, "The Magician's Apprentice " },
                    { 821, 73, 12, new DateTime(2015, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Revised", "", 35, "The Witch's Familiar " },
                    { 822, 74, 12, new DateTime(2015, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Revised", "", 35, "Under the Lake " },
                    { 823, 74, 12, new DateTime(2015, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Revised", "", 35, "Before the Flood " },
                    { 824, 91, 12, new DateTime(2015, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Revised", "", 35, "The Girl Who Died " },
                    { 825, 93, 12, new DateTime(2015, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Revised", "", 35, "The Woman Who Lived " },
                    { 826, 90, 12, new DateTime(2015, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Revised", "", 35, "The Zygon Invasion " },
                    { 827, 90, 12, new DateTime(2015, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Revised", "", 35, "The Zygon Inversion " },
                    { 828, 70, 12, new DateTime(2015, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Revised", "", 35, "Sleep No More " },
                    { 829, 94, 12, new DateTime(2015, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Revised", "", 35, "Face the Raven " },
                    { 830, 73, 12, new DateTime(2015, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Revised", "", 35, "Heaven Sent " },
                    { 831, 73, 12, new DateTime(2015, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Revised", "", 35, "Hell Bent " },
                    { 832, 73, 12, new DateTime(2015, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Special", "", 35, "The Husbands of River Song" },
                    { 833, 73, 12, new DateTime(2016, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Special", "", 36, "The Return of Doctor Mysterio" },
                    { 834, 73, 12, new DateTime(2017, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Revised", "", 36, "The Pilot" },
                    { 835, 92, 12, new DateTime(2017, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Revised", "", 36, "Smile" },
                    { 836, 94, 12, new DateTime(2017, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Revised", "", 36, "Thin Ice" },
                    { 837, 95, 12, new DateTime(2017, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Revised", "", 36, "Knock Knock " },
                    { 838, 91, 12, new DateTime(2017, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Revised", "", 36, "Oxygen " },
                    { 839, 73, 12, new DateTime(2017, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Revised", "", 36, "Extremis" },
                    { 841, 74, 12, new DateTime(2017, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Revised", "", 36, "The Lie of the Land" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeType", "Notes", "Title" },
                values: new object[,]
                {
                    { 761, 69, 10, new DateTime(2009, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Special", "", "The End of Time � Part One" },
                    { 760, 69, 10, new DateTime(2009, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Special", "", "The Waters of Mars" },
                    { 759, 69, 10, new DateTime(2009, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Special", "", "Planet of the Dead" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 681, 65, 7, new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 25, "Silver Nemesis - Part One" },
                    { 682, 65, 7, new DateTime(1988, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 25, "Silver Nemesis - Part Two" },
                    { 683, 65, 7, new DateTime(1988, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 25, "Silver Nemesis - Part Three" },
                    { 684, 60, 7, new DateTime(1988, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 25, "The Greatest Show in the Galaxy - Part One" },
                    { 685, 60, 7, new DateTime(1988, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 25, "The Greatest Show in the Galaxy - Part Two" },
                    { 686, 60, 7, new DateTime(1988, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 25, "The Greatest Show in the Galaxy - Part Three" },
                    { 687, 60, 7, new DateTime(1989, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 25, "The Greatest Show in the Galaxy - Part Four" },
                    { 688, 63, 7, new DateTime(1989, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 26, "Battlefield - Part One" },
                    { 689, 63, 7, new DateTime(1989, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 26, "Battlefield - Part Two" },
                    { 690, 63, 7, new DateTime(1989, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 26, "Battlefield - Part Three" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 691, 63, 7, new DateTime(1989, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 26, "Battlefield - Part Four" },
                    { 692, 66, 7, new DateTime(1989, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 26, "Ghost Light - Part One" },
                    { 693, 66, 7, new DateTime(1989, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 26, "Ghost Light - Part Two" },
                    { 694, 66, 7, new DateTime(1989, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 26, "Ghost Light - Part Three" },
                    { 695, 62, 7, new DateTime(1989, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 26, "The Curse of Fenric - Part One" },
                    { 696, 62, 7, new DateTime(1989, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 26, "The Curse of Fenric - Part Two" },
                    { 697, 62, 7, new DateTime(1989, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 26, "The Curse of Fenric - Part Three" },
                    { 698, 62, 7, new DateTime(1989, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 26, "The Curse of Fenric - Part Four" },
                    { 699, 67, 7, new DateTime(1989, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 26, "Survival - Part One" },
                    { 700, 67, 7, new DateTime(1989, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 26, "Survival - Part Two" },
                    { 701, 67, 7, new DateTime(1989, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 26, "Survival - Part Three" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeType", "Notes", "Title" },
                values: new object[] { 702, 68, 8, new DateTime(1996, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic", "", "Doctor Who (The Movie)" });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 703, 69, 9, new DateTime(2005, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Revised", "", 27, "Rose " },
                    { 680, 64, 7, new DateTime(1988, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 25, "The Happiness Patrol - Part Three" },
                    { 704, 69, 9, new DateTime(2005, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Revised", "", 27, "The End of the World " },
                    { 679, 64, 7, new DateTime(1988, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 25, "The Happiness Patrol - Part Two" },
                    { 677, 63, 7, new DateTime(1988, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 25, "Remembrance of the Daleks - Part Four" },
                    { 654, 57, 6, new DateTime(1986, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 23, "The Trial of a Time Lord - Part Nine (Terror of the Vervoids)" },
                    { 655, 57, 6, new DateTime(1986, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 23, "The Trial of a Time Lord - Part Ten (Terror of the Vervoids)" },
                    { 656, 57, 6, new DateTime(1986, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 23, "The Trial of a Time Lord - Part Eleven (Terror of the Vervoids)" },
                    { 657, 57, 6, new DateTime(1986, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 23, "The Trial of a Time Lord - Part Twelve (Terror of the Vervoids)" },
                    { 658, 28, 6, new DateTime(1986, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 23, "The Trial of a Time Lord - Part Thirteen (The Ultimate Foe)" },
                    { 659, 57, 6, new DateTime(1986, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Classic", "", 23, "The Trial of a Time Lord - Part Fourteen (The Ultimate Foe)" },
                    { 660, 57, 7, new DateTime(1987, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 24, "Time and the Rani - Part One" },
                    { 661, 57, 7, new DateTime(1987, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 24, "Time and the Rani - Part Two" },
                    { 662, 57, 7, new DateTime(1987, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 24, "Time and the Rani - Part Three" },
                    { 663, 57, 7, new DateTime(1987, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 24, "Time and the Rani - Part Four" },
                    { 664, 60, 7, new DateTime(1987, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 24, "Paradise Towers - Part One" },
                    { 665, 60, 7, new DateTime(1987, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 24, "Paradise Towers - Part Two" },
                    { 666, 60, 7, new DateTime(1987, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 24, "Paradise Towers - Part Three" },
                    { 667, 60, 7, new DateTime(1987, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 24, "Paradise Towers - Part Four" },
                    { 668, 61, 7, new DateTime(1987, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 24, "Delta and the Bannermen - Part One" },
                    { 669, 61, 7, new DateTime(1987, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 24, "Delta and the Bannermen - Part Two" },
                    { 670, 61, 7, new DateTime(1987, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 24, "Delta and the Bannermen - Part Three" },
                    { 671, 62, 7, new DateTime(1987, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 24, "Dragonfire - Part One" },
                    { 672, 62, 7, new DateTime(1987, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 24, "Dragonfire - Part Two" },
                    { 673, 62, 7, new DateTime(1987, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 24, "Dragonfire - Part Three" },
                    { 674, 63, 7, new DateTime(1988, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 25, "Remembrance of the Daleks - Part One" },
                    { 675, 63, 7, new DateTime(1988, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 25, "Remembrance of the Daleks - Part Two" },
                    { 676, 63, 7, new DateTime(1988, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 25, "Remembrance of the Daleks - Part Three" },
                    { 678, 64, 7, new DateTime(1988, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 25, "The Happiness Patrol - Part One" },
                    { 705, 70, 9, new DateTime(2005, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Revised", "", 27, "The Unquiet Dead " }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 706, 69, 9, new DateTime(2005, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Revised", "", 27, "Aliens of London " },
                    { 707, 69, 9, new DateTime(2005, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Revised", "", 27, "World War Three " },
                    { 736, 80, 10, new DateTime(2007, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Revised", "", 29, "The Lazarus Experiment " },
                    { 737, 81, 10, new DateTime(2007, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Revised", "", 29, "42" },
                    { 738, 72, 10, new DateTime(2007, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Revised", "", 29, "Human Nature " },
                    { 739, 72, 10, new DateTime(2007, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Revised", "", 29, "The Family of Blood " },
                    { 740, 73, 10, new DateTime(2007, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Revised", "", 29, "Blink " },
                    { 741, 69, 10, new DateTime(2007, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Revised", "", 29, "Utopia " },
                    { 742, 69, 10, new DateTime(2007, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Revised", "", 29, "The Sound of Drums " },
                    { 743, 69, 10, new DateTime(2007, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Revised", "", 29, "Last of the Time Lords " },
                    { 744, 69, 10, new DateTime(2007, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Special", "", 30, "Voyage of the Damned" },
                    { 745, 69, 10, new DateTime(2008, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Revised", "", 30, "Partners in Crime " },
                    { 746, 82, 10, new DateTime(2008, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Revised", "", 30, "The Fires of Pompeii " },
                    { 747, 83, 10, new DateTime(2008, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Revised", "", 30, "Planet of the Ood " },
                    { 748, 79, 10, new DateTime(2008, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Revised", "", 30, "The Sontaran Stratagem " },
                    { 749, 79, 10, new DateTime(2008, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Revised", "", 30, "The Poison Sky " },
                    { 750, 80, 10, new DateTime(2008, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Revised", "", 30, "The Doctor's Daughter " },
                    { 751, 78, 10, new DateTime(2008, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Revised", "", 30, "The Unicorn and the Wasp " },
                    { 752, 73, 10, new DateTime(2008, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Revised", "", 30, "Silence in the Library " },
                    { 753, 73, 10, new DateTime(2008, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Revised", "", 30, "Forest of the Dead " },
                    { 754, 69, 10, new DateTime(2008, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Revised", "", 30, "Midnight " },
                    { 755, 69, 10, new DateTime(2008, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Revised", "", 30, "Turn Left " },
                    { 756, 69, 10, new DateTime(2008, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Revised", "", 30, "The Stolen Earth " },
                    { 757, 69, 10, new DateTime(2008, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Revised", "", 30, "Journey's End " }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeType", "Notes", "Title" },
                values: new object[] { 758, 69, 10, new DateTime(2008, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Special", "", "The Next Doctor" });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 735, 79, 10, new DateTime(2007, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Revised", "", 29, "Evolution of the Daleks " },
                    { 734, 79, 10, new DateTime(2007, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Revised", "", 29, "Daleks in Manhattan " },
                    { 733, 69, 10, new DateTime(2007, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Revised", "", 29, "Gridlock " },
                    { 732, 78, 10, new DateTime(2007, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Revised", "", 29, "The Shakespeare Code " },
                    { 708, 71, 9, new DateTime(2005, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Revised", "", 27, "Dalek " },
                    { 709, 69, 9, new DateTime(2005, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Revised", "", 27, "The Long Game " },
                    { 710, 72, 9, new DateTime(2005, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Revised", "", 27, "Father's Day " },
                    { 711, 73, 9, new DateTime(2005, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Revised", "", 27, "The Empty Child " },
                    { 712, 73, 9, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Revised", "", 27, "The Doctor Dances " },
                    { 713, 69, 9, new DateTime(2005, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Revised", "", 27, "Boom Town " },
                    { 714, 69, 9, new DateTime(2005, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Revised", "", 27, "Bad Wolf " },
                    { 715, 69, 9, new DateTime(2005, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Revised", "", 27, "The Parting of the Ways " },
                    { 716, 69, 9, new DateTime(2005, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Special", "", 28, "The Christmas Invasion" },
                    { 717, 69, 10, new DateTime(2006, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Revised", "", 28, "New Earth " },
                    { 718, 69, 10, new DateTime(2006, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Revised", "", 28, "Tooth and Claw " },
                    { 652, 56, 6, new DateTime(1986, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 23, "The Trial of a Time Lord - Part Seven (Mindwarp)" },
                    { 719, 74, 10, new DateTime(2006, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Revised", "", 28, "School Reunion " }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 721, 75, 10, new DateTime(2006, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Revised", "", 28, "Rise of the Cybermen " },
                    { 722, 75, 10, new DateTime(2006, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Revised", "", 28, "The Age of Steel " },
                    { 723, 70, 10, new DateTime(2006, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Revised", "", 28, "The Idiot's Lantern " },
                    { 724, 76, 10, new DateTime(2006, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Revised", "", 28, "The Impossible Planet " },
                    { 725, 76, 10, new DateTime(2006, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Revised", "", 28, "The Satan Pit " },
                    { 726, 69, 10, new DateTime(2006, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Revised", "", 28, "Love & Monsters " },
                    { 727, 77, 10, new DateTime(2006, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Revised", "", 28, "Fear Her " },
                    { 728, 69, 10, new DateTime(2006, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Revised", "", 28, "Army of Ghosts " },
                    { 729, 69, 10, new DateTime(2006, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Revised", "", 28, "Doomsday " },
                    { 730, 69, 10, new DateTime(2006, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Special", "", 29, "The Runaway Bride" },
                    { 731, 69, 10, new DateTime(2007, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Revised", "", 29, "Smith and Jones " },
                    { 720, 73, 10, new DateTime(2006, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Revised", "", 28, "The Girl in the Fireplace " },
                    { 435, 31, 4, new DateTime(1976, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 14, "The Hand of Fear - Part Four" },
                    { 434, 31, 4, new DateTime(1976, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 14, "The Hand of Fear - Part Three" },
                    { 433, 31, 4, new DateTime(1976, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 14, "The Hand of Fear - Part Two" },
                    { 138, 3, 2, new DateTime(1966, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 4, "The Power of the Daleks - Part Four" },
                    { 139, 3, 2, new DateTime(1966, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 4, "The Power of the Daleks - Part Five" },
                    { 140, 3, 2, new DateTime(1966, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 4, "The Power of the Daleks - Part Six" },
                    { 141, 17, 2, new DateTime(1966, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 4, "The Highlanders - Part One" },
                    { 142, 17, 2, new DateTime(1966, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 4, "The Highlanders - Part Two" },
                    { 143, 17, 2, new DateTime(1966, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 4, "The Highlanders - Part Three" },
                    { 144, 17, 2, new DateTime(1967, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 4, "The Highlanders - Part Four" },
                    { 145, 19, 2, new DateTime(1967, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 4, "The Underwater Menace - Part One" },
                    { 146, 19, 2, new DateTime(1967, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 4, "The Underwater Menace - Part Two" },
                    { 147, 19, 2, new DateTime(1967, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 4, "The Underwater Menace - Part Three" },
                    { 148, 19, 2, new DateTime(1967, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 4, "The Underwater Menace - Part Four" },
                    { 149, 18, 2, new DateTime(1967, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 4, "The Moonbase - Part One" },
                    { 150, 18, 2, new DateTime(1967, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 4, "The Moonbase - Part Two" },
                    { 151, 18, 2, new DateTime(1967, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 4, "The Moonbase - Part Three" },
                    { 152, 18, 2, new DateTime(1967, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 4, "The Moonbase - Part Four" },
                    { 153, 16, 2, new DateTime(1967, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Classic", "", 4, "The Macra Terror - Part One" },
                    { 154, 16, 2, new DateTime(1967, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Classic", "", 4, "The Macra Terror - Part Two" },
                    { 155, 16, 2, new DateTime(1967, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "Classic", "", 4, "The Macra Terror - Part Three" },
                    { 156, 16, 2, new DateTime(1967, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Classic", "", 4, "The Macra Terror - Part Four" },
                    { 157, 20, 2, new DateTime(1967, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, "Classic", "", 4, "The Faceless Ones - Part One" },
                    { 158, 20, 2, new DateTime(1967, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, "Classic", "", 4, "The Faceless Ones - Part Two" },
                    { 159, 20, 2, new DateTime(1967, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, "Classic", "", 4, "The Faceless Ones - Part Three" },
                    { 160, 20, 2, new DateTime(1967, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, "Classic", "", 4, "The Faceless Ones - Part Four" },
                    { 137, 3, 2, new DateTime(1966, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 4, "The Power of the Daleks - Part Three" },
                    { 161, 20, 2, new DateTime(1967, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "Classic", "", 4, "The Faceless Ones - Part Five" },
                    { 136, 3, 2, new DateTime(1966, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 4, "The Power of the Daleks - Part Two" },
                    { 134, 18, 1, new DateTime(1966, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 4, "The Tenth Planet - Part Four" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 111, 14, 1, new DateTime(1966, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Classic", "", 3, "The Celestial Toyroom (The Celestial Toymaker - Part One)" },
                    { 112, 14, 1, new DateTime(1966, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, "Classic", "", 3, "The Hall of Dolls (The Celestial Toymaker - Part Two)" },
                    { 113, 14, 1, new DateTime(1966, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, "Classic", "", 3, "The Dancing Floor (The Celestial Toymaker - Part Three)" },
                    { 114, 14, 1, new DateTime(1966, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, "Classic", "", 3, "The Final Test (The Celestial Toymaker - Part Four)" },
                    { 115, 11, 1, new DateTime(1966, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, "Classic", "", 3, "A Holiday for the Doctor (The Gunfighters - Part One)" },
                    { 116, 11, 1, new DateTime(1966, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "Classic", "", 3, "Don't Shoot the Pianist (The Gunfighters - Part Two)" },
                    { 117, 11, 1, new DateTime(1966, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, "Classic", "", 3, "Johnny Ringo (The Gunfighters - Part Three)" },
                    { 118, 11, 1, new DateTime(1966, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, "Classic", "", 3, "The O.K. Corral (The Gunfighters - Part Four)" },
                    { 119, 16, 1, new DateTime(1966, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, "Classic", "", 3, "The Savages - Part One" },
                    { 120, 16, 1, new DateTime(1966, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, "Classic", "", 3, "The Savages - Part Two" },
                    { 121, 16, 1, new DateTime(1966, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "Classic", "", 3, "The Savages - Part Three" },
                    { 122, 16, 1, new DateTime(1966, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, "Classic", "", 3, "The Savages - Part Four" },
                    { 123, 16, 1, new DateTime(1966, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, "Classic", "", 3, "The War Machines - Part One" },
                    { 124, 16, 1, new DateTime(1966, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, "Classic", "", 3, "The War Machines - Part Two" },
                    { 125, 16, 1, new DateTime(1966, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, "Classic", "", 3, "The War Machines - Part Three" },
                    { 126, 16, 1, new DateTime(1966, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "Classic", "", 3, "The War Machines - Part Four" },
                    { 127, 14, 1, new DateTime(1966, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 4, "The Smugglers - Part One" },
                    { 128, 14, 1, new DateTime(1966, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 4, "The Smugglers - Part Two" },
                    { 129, 14, 1, new DateTime(1966, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 4, "The Smugglers - Part Three" },
                    { 130, 14, 1, new DateTime(1966, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 4, "The Smugglers - Part Four" },
                    { 131, 18, 1, new DateTime(1966, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 4, "The Tenth Planet - Part One" },
                    { 132, 18, 1, new DateTime(1966, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 4, "The Tenth Planet - Part Two" },
                    { 133, 18, 1, new DateTime(1966, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 4, "The Tenth Planet - Part Three" },
                    { 135, 3, 2, new DateTime(1966, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 4, "The Power of the Daleks - Part One" },
                    { 110, 13, 1, new DateTime(1966, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "Classic", "", 3, "The Bomb (The Ark - Part Four)" },
                    { 162, 20, 2, new DateTime(1967, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, "Classic", "", 4, "The Faceless Ones - Part Six" },
                    { 164, 3, 2, new DateTime(1967, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, "Classic", "", 4, "The Evil of the Daleks - Part Two" },
                    { 192, 22, 2, new DateTime(1968, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 5, "The Web of Fear - Part One" },
                    { 193, 22, 2, new DateTime(1968, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 5, "The Web of Fear - Part Two" },
                    { 194, 22, 2, new DateTime(1968, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 5, "The Web of Fear - Part Three" },
                    { 195, 22, 2, new DateTime(1968, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 5, "The Web of Fear - Part Four" },
                    { 196, 22, 2, new DateTime(1968, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Classic", "", 5, "The Web of Fear - Part Five" },
                    { 197, 22, 2, new DateTime(1968, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Classic", "", 5, "The Web of Fear - Part Six" },
                    { 198, 24, 2, new DateTime(1968, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "Classic", "", 5, "Fury from the Deep - Part One" },
                    { 199, 24, 2, new DateTime(1968, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Classic", "", 5, "Fury from the Deep - Part Two" },
                    { 200, 24, 2, new DateTime(1968, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, "Classic", "", 5, "Fury from the Deep - Part Three" },
                    { 201, 24, 2, new DateTime(1968, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, "Classic", "", 5, "Fury from the Deep - Part Four" },
                    { 202, 24, 2, new DateTime(1968, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, "Classic", "", 5, "Fury from the Deep - Part Five" },
                    { 203, 24, 2, new DateTime(1968, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, "Classic", "", 5, "Fury from the Deep - Part Six" },
                    { 204, 3, 2, new DateTime(1968, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "Classic", "", 5, "The Wheel in Space - Part One" },
                    { 205, 3, 2, new DateTime(1968, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, "Classic", "", 5, "The Wheel in Space - Part Two" },
                    { 206, 3, 2, new DateTime(1968, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, "Classic", "", 5, "The Wheel in Space - Part Three" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 207, 3, 2, new DateTime(1968, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, "Classic", "", 5, "The Wheel in Space - Part Four" },
                    { 208, 3, 2, new DateTime(1968, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, "Classic", "", 5, "The Wheel in Space - Part Five" },
                    { 209, 3, 2, new DateTime(1968, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "Classic", "", 5, "The Wheel in Space - Part Six" },
                    { 210, 25, 2, new DateTime(1968, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 6, "The Dominators - Part One" },
                    { 211, 25, 2, new DateTime(1968, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 6, "The Dominators - Part Two" },
                    { 212, 25, 2, new DateTime(1968, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 6, "The Dominators - Part Three" },
                    { 213, 25, 2, new DateTime(1968, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 6, "The Dominators - Part Four" },
                    { 214, 25, 2, new DateTime(1968, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 6, "The Dominators - Part Five" },
                    { 191, 3, 2, new DateTime(1968, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 5, "The Enemy of the World - Part Six" },
                    { 163, 3, 2, new DateTime(1967, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, "Classic", "", 4, "The Evil of the Daleks - Part One" },
                    { 190, 3, 2, new DateTime(1968, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 5, "The Enemy of the World - Part Five" },
                    { 188, 3, 2, new DateTime(1968, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 5, "The Enemy of the World - Part Three" },
                    { 165, 3, 2, new DateTime(1967, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, "Classic", "", 4, "The Evil of the Daleks - Part Three" },
                    { 166, 3, 2, new DateTime(1967, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "Classic", "", 4, "The Evil of the Daleks - Part Four" },
                    { 167, 3, 2, new DateTime(1967, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, "Classic", "", 4, "The Evil of the Daleks - Part Five" },
                    { 168, 3, 2, new DateTime(1967, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, "Classic", "", 4, "The Evil of the Daleks - Part Six" },
                    { 169, 3, 2, new DateTime(1967, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, "Classic", "", 4, "The Evil of the Daleks - Part Seven" },
                    { 170, 18, 2, new DateTime(1967, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 5, "The Tomb of the Cybermen - Part One" },
                    { 171, 18, 2, new DateTime(1967, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 5, "The Tomb of the Cybermen - Part Two" },
                    { 172, 18, 2, new DateTime(1967, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 5, "The Tomb of the Cybermen - Part Three" },
                    { 173, 18, 2, new DateTime(1967, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 5, "The Tomb of the Cybermen - Part Four" },
                    { 174, 22, 2, new DateTime(1967, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 5, "The Abominable Snowmen - Part One" },
                    { 175, 22, 2, new DateTime(1967, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 5, "The Abominable Snowmen - Part Two" },
                    { 176, 22, 2, new DateTime(1967, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 5, "The Abominable Snowmen - Part Three" },
                    { 177, 22, 2, new DateTime(1967, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 5, "The Abominable Snowmen - Part Four" },
                    { 178, 22, 2, new DateTime(1967, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 5, "The Abominable Snowmen - Part Five" },
                    { 179, 22, 2, new DateTime(1967, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 5, "The Abominable Snowmen - Part Six" },
                    { 180, 14, 2, new DateTime(1967, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 5, "The Ice Warriors - Part One" },
                    { 181, 14, 2, new DateTime(1967, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 5, "The Ice Warriors - Part Two" },
                    { 182, 14, 2, new DateTime(1967, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 5, "The Ice Warriors - Part Three" },
                    { 183, 14, 2, new DateTime(1967, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 5, "The Ice Warriors - Part Four" },
                    { 184, 14, 2, new DateTime(1967, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 5, "The Ice Warriors - Part Five" },
                    { 185, 14, 2, new DateTime(1967, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 5, "The Ice Warriors - Part Six" },
                    { 186, 3, 2, new DateTime(1967, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 5, "The Enemy of the World - Part One" },
                    { 187, 3, 2, new DateTime(1967, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 5, "The Enemy of the World - Part Two" },
                    { 189, 3, 2, new DateTime(1968, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 5, "The Enemy of the World - Part Four" },
                    { 109, 13, 1, new DateTime(1966, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Classic", "", 3, "The Return (The Ark - Part Three)" },
                    { 108, 12, 1, new DateTime(1966, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Classic", "", 3, "The Plague (The Ark - Part Two)" },
                    { 107, 12, 1, new DateTime(1966, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 3, "The Steel Sky (The Ark - Part One)" },
                    { 29, 4, 1, new DateTime(1964, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "Classic", "", 1, "The Bride of Sacrifice (The Aztecs - Part Three)" },
                    { 30, 4, 1, new DateTime(1964, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Classic", "", 1, "The Day of Darkness (The Aztecs - Part Four)" },
                    { 31, 5, 1, new DateTime(1964, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, "Classic", "", 1, "Strangers in Space (The Sensorites - Part One)" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 32, 5, 1, new DateTime(1964, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, "Classic", "", 1, "The Unwilling Warriors (The Sensorites - Part Two)" },
                    { 33, 5, 1, new DateTime(1964, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, "Classic", "", 1, "Hidden Danger (The Sensorites - Part Three)" },
                    { 34, 5, 1, new DateTime(1964, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, "Classic", "", 1, "A Race Against Death (The Sensorites - Part Four)" },
                    { 35, 5, 1, new DateTime(1964, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "Classic", "", 1, "Kidnap (The Sensorites - Part Five)" },
                    { 36, 5, 1, new DateTime(1964, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, "Classic", "", 1, "A Desperate Venture (The Sensorites - Part Six)" },
                    { 37, 6, 1, new DateTime(1964, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, "Classic", "", 1, "A Land of Fear (The Reign of Terror - Part One)" },
                    { 38, 6, 1, new DateTime(1964, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, "Classic", "", 1, "Guests of Madame Guillotine (The Reign of Terror - Part Two)" },
                    { 39, 6, 1, new DateTime(1964, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, "Classic", "", 1, "A Change of Identity (The Reign of Terror - Part Three)" },
                    { 40, 6, 1, new DateTime(1964, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "Classic", "", 1, "The Tyrant of France (The Reign of Terror - Part Four)" },
                    { 41, 6, 1, new DateTime(1964, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, "Classic", "", 1, "A Bargain of Necessity (The Reign of Terror - Part Five)" },
                    { 42, 6, 1, new DateTime(1964, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, "Classic", "", 1, "Prisoners of Conciergerie (The Reign of Terror - Part Six)" },
                    { 43, 7, 1, new DateTime(1964, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 2, "Planet of Giants (Planet of Giants - Part One)" },
                    { 44, 7, 1, new DateTime(1964, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 2, "Dangerous Journey (Planet of Giants - Part Two)" },
                    { 45, 7, 1, new DateTime(1964, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 2, "Crisis (Planet of Giants - Part Three)" },
                    { 46, 2, 1, new DateTime(1964, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 2, "World's End (The Dalek Invasion of Earth - Part One)" },
                    { 47, 2, 1, new DateTime(1964, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 2, "The Daleks (The Dalek Invasion of Earth - Part Two)" },
                    { 48, 2, 1, new DateTime(1964, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 2, "Day of Reckoning (The Dalek Invasion of Earth - Part Three)" },
                    { 49, 2, 1, new DateTime(1964, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 2, "The End of Tomorrow (The Dalek Invasion of Earth - Part Four)" },
                    { 50, 2, 1, new DateTime(1964, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 2, "The Waking Ally (The Dalek Invasion of Earth - Part Five)" },
                    { 51, 2, 1, new DateTime(1964, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 2, "Flashpoint (The Dalek Invasion of Earth - Part Six)" },
                    { 28, 4, 1, new DateTime(1964, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Classic", "", 1, "The Warriors of Death (The Aztecs - Part Two)" },
                    { 52, 3, 1, new DateTime(1965, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 2, "The Powerful Enemy (The Rescue - Part One)" },
                    { 27, 4, 1, new DateTime(1964, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Classic", "", 1, "The Temple of Evil (The Aztecs - Part One)" },
                    { 25, 2, 1, new DateTime(1964, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 1, "Sentence of Death (The Keys of Marinus - Part Five)" },
                    { 2, 1, 1, new DateTime(1963, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 1, "The Cave of Skulls (An Unearthly Child - Part Two)" },
                    { 3, 1, 1, new DateTime(1963, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 1, "The Forest of Fear (An Unearthly Child - Part Three)" },
                    { 4, 1, 1, new DateTime(1963, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 1, "The Firemaker (An Unearthly Child - Part Four)" },
                    { 5, 2, 1, new DateTime(1963, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 1, "The Dead Planet (The Daleks - Part One)" },
                    { 6, 2, 1, new DateTime(1963, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 1, "The Survivors (The Daleks - Part Two)" },
                    { 7, 2, 1, new DateTime(1964, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 1, "The Escape (The Daleks - Part Three)" },
                    { 8, 2, 1, new DateTime(1964, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 1, "The Ambush (The Daleks - Part Four)" },
                    { 9, 2, 1, new DateTime(1964, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 1, "The Expedition (The Daleks - Part Five)" },
                    { 10, 2, 1, new DateTime(1964, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 1, "The Ordeal (The Daleks - Part Six)" },
                    { 11, 2, 1, new DateTime(1964, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 1, "The Rescue (The Daleks - Part Seven)" },
                    { 12, 3, 1, new DateTime(1964, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 1, "The Edge of Destruction (The Edge of Destruction - Part One)" },
                    { 13, 3, 1, new DateTime(1964, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 1, "The Brink of Disaster (The Edge of Destruction - Part Two)" },
                    { 14, 4, 1, new DateTime(1964, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 1, "The Roof of the World (Marco Polo - Part One)" },
                    { 15, 4, 1, new DateTime(1964, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 1, "The Singing Sands (Marco Polo - Part Two)" },
                    { 16, 4, 1, new DateTime(1964, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 1, "Five Hundred Eyes (Marco Polo - Part Three)" },
                    { 17, 4, 1, new DateTime(1964, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 1, "The Wall of Lies (Marco Polo - Part Four)" },
                    { 18, 4, 1, new DateTime(1964, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 1, "Rider From Shang-Tu (Marco Polo - Part Five)" },
                    { 19, 4, 1, new DateTime(1964, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 1, "Mighty Kublai Khan (Marco Polo - Part Six)" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 20, 4, 1, new DateTime(1964, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 1, "Assassin at Peking (Marco Polo - Part Seven)" },
                    { 21, 2, 1, new DateTime(1964, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 1, "The Sea of Death (The Keys of Marinus - Part One)" },
                    { 22, 2, 1, new DateTime(1964, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 1, "The Velvet Web (The Keys of Marinus - Part Two)" },
                    { 23, 2, 1, new DateTime(1964, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 1, "The Screaming Jungle (The Keys of Marinus - Part Three)" },
                    { 24, 2, 1, new DateTime(1964, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 1, "The Snows of Terror (The Keys of Marinus - Part Four)" },
                    { 26, 2, 1, new DateTime(1964, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 1, "The Keys of Marinus (The Keys of Marinus - Part Six)" },
                    { 53, 3, 1, new DateTime(1965, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 2, "Desperate Measures (The Rescue - Part Two)" },
                    { 54, 6, 1, new DateTime(1965, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 2, "The Slave Traders (The Romans - Part One)" },
                    { 55, 6, 1, new DateTime(1965, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 2, "All Roads Lead to Rome (The Romans - Part Two)" },
                    { 84, 10, 1, new DateTime(1965, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 3, "Air Lock (Galaxy 4 - Part Three)" },
                    { 85, 10, 1, new DateTime(1965, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 3, "The Exploding Planet (Galaxy 4 - Part Four)" },
                    { 86, 2, 1, new DateTime(1965, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 3, "Mission to the Unknown" },
                    { 87, 11, 1, new DateTime(1965, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 3, "Temple of Secrets (The Myth Makers - Part One)" },
                    { 88, 11, 1, new DateTime(1965, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 3, "Small Prophet - Quick Return (The Myth Makers - Part Two)" },
                    { 89, 11, 1, new DateTime(1965, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 3, "Death of a Spy (The Myth Makers - Part Three)" },
                    { 90, 11, 1, new DateTime(1965, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 3, "Horse of Destruction (The Myth Makers - Part Four)" },
                    { 91, 2, 1, new DateTime(1965, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 3, "The Nightmare Begins (The Daleks' Master Plan - Part One)" },
                    { 92, 2, 1, new DateTime(1965, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 3, "Day of Armageddon (The Daleks' Master Plan - Part Two)" },
                    { 93, 2, 1, new DateTime(1965, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 3, "Devil's Planet (The Daleks' Master Plan - Part Three)" },
                    { 94, 2, 1, new DateTime(1965, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 3, "The Traitors (The Daleks' Master Plan - Part Four)" },
                    { 95, 2, 1, new DateTime(1965, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 3, "Counter Plot (The Daleks' Master Plan - Part Five)" },
                    { 96, 6, 1, new DateTime(1965, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 3, "Coronas of the Sun (The Daleks' Master Plan - Part Six)" },
                    { 97, 2, 1, new DateTime(1965, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 3, "The Feast of Steven (The Daleks' Master Plan - Part Seven)" },
                    { 98, 6, 1, new DateTime(1966, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 3, "Volcano (The Daleks' Master Plan - Part Eight)" },
                    { 99, 6, 1, new DateTime(1966, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 3, "Golden Death (The Daleks' Master Plan - Part Nine)" },
                    { 100, 6, 1, new DateTime(1966, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 3, "Escape Switch (The Daleks' Master Plan - Part Ten)" },
                    { 101, 6, 1, new DateTime(1966, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 3, "The Abandoned Planet (The Daleks' Master Plan - Part Eleven)" },
                    { 102, 6, 1, new DateTime(1966, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 3, "Destruction of Time (The Daleks' Master Plan - Part Twelve)" },
                    { 103, 4, 1, new DateTime(1966, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 3, "War of God (The Massacre of St Bartholomew's Eve - Part One)" },
                    { 104, 4, 1, new DateTime(1966, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 3, "The Sea Beggar (The Massacre of St Bartholomew's Eve - Part Two)" },
                    { 105, 4, 1, new DateTime(1966, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 3, "Priest of Death (The Massacre of St Bartholomew's Eve - Part Three)" },
                    { 106, 4, 1, new DateTime(1966, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 3, "Bell of Doom (The Massacre of St Bartholomew's Eve - Part Four)" },
                    { 83, 10, 1, new DateTime(1965, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 3, "Trap of Steel (Galaxy 4 - Part Two)" },
                    { 82, 10, 1, new DateTime(1965, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 3, "Four Hundred Dawns (Galaxy 4 - Part One)" },
                    { 81, 6, 1, new DateTime(1965, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, "Classic", "", 2, "Checkmate (The Time Meddler - Part Four)" },
                    { 80, 6, 1, new DateTime(1965, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, "Classic", "", 2, "A Battle of Wits (The Time Meddler - Part Three)" },
                    { 56, 6, 1, new DateTime(1965, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 2, "Conspiracy (The Romans - Part Three)" },
                    { 57, 6, 1, new DateTime(1965, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 2, "Inferno (The Romans - Part Four)" },
                    { 58, 8, 1, new DateTime(1965, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 2, "The Web Planet (The Web Planet - Part One)" },
                    { 59, 8, 1, new DateTime(1965, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 2, "The Zarbi (The Web Planet - Part Two)" },
                    { 60, 8, 1, new DateTime(1965, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 2, "Escape to Danger (The Web Planet - Part Three)" },
                    { 61, 8, 1, new DateTime(1965, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 2, "Crater of Needles (The Web Planet - Part Four)" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 62, 8, 1, new DateTime(1965, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 2, "Invasion (The Web Planet - Part Five)" },
                    { 63, 8, 1, new DateTime(1965, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 2, "The Centre (The Web Planet - Part Six)" },
                    { 64, 3, 1, new DateTime(1965, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 2, "The Lion (The Crusade - Part One)" },
                    { 65, 3, 1, new DateTime(1965, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 2, "The Knight of Jaffa (The Crusade - Part Two)" },
                    { 66, 3, 1, new DateTime(1965, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 2, "The Wheel of Fortune (The Crusade - Part Three)" },
                    { 215, 27, 2, new DateTime(1968, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 6, "The Mind Robber - Part One" },
                    { 67, 3, 1, new DateTime(1965, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 2, "The Warlords (The Crusade - Part Four)" },
                    { 69, 9, 1, new DateTime(1965, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Classic", "", 2, "The Dimensions of Time (The Space Museum - Part Two)" },
                    { 70, 9, 1, new DateTime(1965, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Classic", "", 2, "The Search (The Space Museum - Part Three)" },
                    { 71, 9, 1, new DateTime(1965, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "Classic", "", 2, "The Final Phase (The Space Museum - Part Four)" },
                    { 72, 2, 1, new DateTime(1965, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Classic", "", 2, "The Executioners (The Chase - Part One)" },
                    { 73, 2, 1, new DateTime(1965, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, "Classic", "", 2, "The Death of Time (The Chase - Part Two)" },
                    { 74, 2, 1, new DateTime(1965, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, "Classic", "", 2, "Flight through Eternity (The Chase - Part Three)" },
                    { 75, 2, 1, new DateTime(1965, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, "Classic", "", 2, "Journey into Terror (The Chase - Part Four)" },
                    { 76, 2, 1, new DateTime(1965, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, "Classic", "", 2, "The Death of Doctor Who (The Chase - Part Five)" },
                    { 77, 2, 1, new DateTime(1965, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "Classic", "", 2, "The Planet of Decision (The Chase - Part Six)" },
                    { 78, 6, 1, new DateTime(1965, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, "Classic", "", 2, "The Watcher (The Time Meddler - Part One)" },
                    { 79, 6, 1, new DateTime(1965, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, "Classic", "", 2, "The Meddling Monk (The Time Meddler - Part Two)" },
                    { 68, 9, 1, new DateTime(1965, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 2, "The Space Museum (The Space Museum - Part One)" },
                    { 216, 26, 2, new DateTime(1968, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 6, "The Mind Robber - Part Two" },
                    { 217, 26, 2, new DateTime(1968, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 6, "The Mind Robber - Part Three" },
                    { 218, 26, 2, new DateTime(1968, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 6, "The Mind Robber - Part Four" },
                    { 355, 34, 3, new DateTime(1973, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 10, "The Green Death - Part Six" },
                    { 356, 28, 3, new DateTime(1973, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 11, "The Time Warrior - Part One" },
                    { 357, 28, 3, new DateTime(1973, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 11, "The Time Warrior - Part Two" },
                    { 358, 28, 3, new DateTime(1973, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 11, "The Time Warrior - Part Three" },
                    { 359, 28, 3, new DateTime(1974, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 11, "The Time Warrior - Part Four" },
                    { 360, 21, 3, new DateTime(1974, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 11, "Invasion of the Dinosaurs - Part One" },
                    { 361, 21, 3, new DateTime(1974, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 11, "Invasion of the Dinosaurs - Part Two" },
                    { 362, 21, 3, new DateTime(1974, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 11, "Invasion of the Dinosaurs - Part Three" },
                    { 363, 21, 3, new DateTime(1974, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 11, "Invasion of the Dinosaurs - Part Four" },
                    { 364, 21, 3, new DateTime(1974, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 11, "Invasion of the Dinosaurs - Part Five" },
                    { 365, 21, 3, new DateTime(1974, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 11, "Invasion of the Dinosaurs - Part Six" },
                    { 366, 2, 3, new DateTime(1974, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 11, "Death to the Daleks - Part One" },
                    { 367, 2, 3, new DateTime(1974, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 11, "Death to the Daleks - Part Two" },
                    { 368, 2, 3, new DateTime(1974, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 11, "Death to the Daleks - Part Three" },
                    { 369, 2, 3, new DateTime(1974, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 11, "Death to the Daleks - Part Four" },
                    { 370, 14, 3, new DateTime(1974, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 11, "The Monster of Peladon - Part One" },
                    { 371, 14, 3, new DateTime(1974, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 11, "The Monster of Peladon - Part Two" },
                    { 372, 14, 3, new DateTime(1974, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 11, "The Monster of Peladon - Part Three" },
                    { 373, 14, 3, new DateTime(1974, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 11, "The Monster of Peladon - Part Four" },
                    { 374, 14, 3, new DateTime(1974, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 11, "The Monster of Peladon - Part Five" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 375, 14, 3, new DateTime(1974, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 11, "The Monster of Peladon - Part Six" },
                    { 376, 34, 3, new DateTime(1974, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 11, "Planet of the Spiders - Part One" },
                    { 377, 34, 3, new DateTime(1974, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 11, "Planet of the Spiders - Part Two" },
                    { 354, 34, 3, new DateTime(1973, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 10, "The Green Death - Part Five" },
                    { 378, 34, 3, new DateTime(1974, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 11, "Planet of the Spiders - Part Three" },
                    { 353, 34, 3, new DateTime(1973, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 10, "The Green Death - Part Four" },
                    { 351, 34, 3, new DateTime(1973, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 10, "The Green Death - Part Two" },
                    { 328, 34, 3, new DateTime(1972, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 9, "The Time Monster - Part Five" },
                    { 329, 34, 3, new DateTime(1972, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 9, "The Time Monster - Part Six" },
                    { 330, 31, 3, new DateTime(1972, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 10, "The Three Doctors - Part One" },
                    { 331, 31, 3, new DateTime(1973, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 10, "The Three Doctors - Part Two" },
                    { 332, 31, 3, new DateTime(1973, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 10, "The Three Doctors - Part Three" },
                    { 333, 31, 3, new DateTime(1973, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 10, "The Three Doctors - Part Four" },
                    { 334, 28, 3, new DateTime(1973, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 10, "Carnival of Monsters - Part One" },
                    { 335, 28, 3, new DateTime(1973, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 10, "Carnival of Monsters - Part Two" },
                    { 336, 28, 3, new DateTime(1973, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 10, "Carnival of Monsters - Part Three" },
                    { 337, 28, 3, new DateTime(1973, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 10, "Carnival of Monsters - Part Four" },
                    { 338, 21, 3, new DateTime(1973, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 10, "Frontier in Space - Part One" },
                    { 339, 21, 3, new DateTime(1973, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 10, "Frontier in Space - Part Two" },
                    { 340, 21, 3, new DateTime(1973, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 10, "Frontier in Space - Part Three" },
                    { 341, 21, 3, new DateTime(1973, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 10, "Frontier in Space - Part Four" },
                    { 342, 21, 3, new DateTime(1973, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 10, "Frontier in Space - Part Five" },
                    { 343, 21, 3, new DateTime(1973, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 10, "Frontier in Space - Part Six" },
                    { 344, 2, 3, new DateTime(1973, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 10, "Planet of the Daleks - Part One" },
                    { 345, 2, 3, new DateTime(1973, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 10, "Planet of the Daleks - Part Two" },
                    { 346, 2, 3, new DateTime(1973, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 10, "Planet of the Daleks - Part Three" },
                    { 347, 2, 3, new DateTime(1973, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 10, "Planet of the Daleks - Part Four" },
                    { 348, 2, 3, new DateTime(1973, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 10, "Planet of the Daleks - Part Five" },
                    { 349, 2, 3, new DateTime(1973, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 10, "Planet of the Daleks - Part Six" },
                    { 350, 34, 3, new DateTime(1973, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 10, "The Green Death - Part One" },
                    { 352, 34, 3, new DateTime(1973, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 10, "The Green Death - Part Three" },
                    { 379, 34, 3, new DateTime(1974, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 11, "Planet of the Spiders - Part Four" },
                    { 380, 34, 3, new DateTime(1974, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 11, "Planet of the Spiders - Part Five" },
                    { 381, 34, 3, new DateTime(1974, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 11, "Planet of the Spiders - Part Six" },
                    { 410, 36, 4, new DateTime(1975, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 13, "Pyramids of Mars - Part One" },
                    { 411, 36, 4, new DateTime(1975, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 13, "Pyramids of Mars - Part Two" },
                    { 412, 36, 4, new DateTime(1975, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 13, "Pyramids of Mars - Part Three" },
                    { 413, 36, 4, new DateTime(1975, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 13, "Pyramids of Mars - Part Four" },
                    { 414, 2, 4, new DateTime(1975, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 13, "The Android Invasion - Part One" },
                    { 415, 2, 4, new DateTime(1975, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 13, "The Android Invasion - Part Two" },
                    { 416, 2, 4, new DateTime(1975, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 13, "The Android Invasion - Part Three" },
                    { 417, 2, 4, new DateTime(1975, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 13, "The Android Invasion - Part Four" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 418, 37, 4, new DateTime(1976, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 13, "The Brain of Morbius - Part One" },
                    { 419, 37, 4, new DateTime(1976, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 13, "The Brain of Morbius - Part Two" },
                    { 420, 37, 4, new DateTime(1976, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 13, "The Brain of Morbius - Part Three" },
                    { 421, 37, 4, new DateTime(1976, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 13, "The Brain of Morbius - Part Four" },
                    { 422, 35, 4, new DateTime(1976, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 13, "The Seeds of Doom - Part One" },
                    { 423, 35, 4, new DateTime(1976, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 13, "The Seeds of Doom - Part Two" },
                    { 424, 35, 4, new DateTime(1976, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 13, "The Seeds of Doom - Part Three" },
                    { 425, 35, 4, new DateTime(1976, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 13, "The Seeds of Doom - Part Four" },
                    { 426, 35, 4, new DateTime(1976, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 13, "The Seeds of Doom - Part Five" },
                    { 427, 35, 4, new DateTime(1976, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 13, "The Seeds of Doom - Part Six" },
                    { 428, 7, 4, new DateTime(1976, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 14, "The Masque of Mandragora - Part One" },
                    { 429, 7, 4, new DateTime(1976, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 14, "The Masque of Mandragora - Part Two" },
                    { 430, 7, 4, new DateTime(1976, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 14, "The Masque of Mandragora - Part Three" },
                    { 431, 7, 4, new DateTime(1976, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 14, "The Masque of Mandragora - Part Four" },
                    { 432, 31, 4, new DateTime(1976, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 14, "The Hand of Fear - Part One" },
                    { 409, 7, 4, new DateTime(1975, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 13, "Planet of Evil - Part Four" },
                    { 408, 7, 4, new DateTime(1975, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 13, "Planet of Evil - Part Three" },
                    { 407, 7, 4, new DateTime(1975, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 13, "Planet of Evil - Part Two" },
                    { 406, 7, 4, new DateTime(1975, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 13, "Planet of Evil - Part One" },
                    { 382, 29, 4, new DateTime(1974, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 12, "Robot - Part One" },
                    { 383, 29, 4, new DateTime(1975, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 12, "Robot - Part Two" },
                    { 384, 29, 4, new DateTime(1975, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 12, "Robot - Part Three" },
                    { 385, 29, 4, new DateTime(1975, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 12, "Robot - Part Four" },
                    { 386, 28, 4, new DateTime(1975, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 12, "The Ark in Space - Part One" },
                    { 387, 28, 4, new DateTime(1975, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 12, "The Ark in Space - Part Two" },
                    { 388, 28, 4, new DateTime(1975, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 12, "The Ark in Space - Part Three" },
                    { 389, 28, 4, new DateTime(1975, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 12, "The Ark in Space - Part Four" },
                    { 390, 31, 4, new DateTime(1975, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 12, "The Sontaran Experiment - Part One" },
                    { 391, 31, 4, new DateTime(1975, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 12, "The Sontaran Experiment - Part Two" },
                    { 392, 2, 4, new DateTime(1975, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 12, "Genesis of the Daleks - Part One" },
                    { 327, 34, 3, new DateTime(1972, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 9, "The Time Monster - Part Four" },
                    { 393, 2, 4, new DateTime(1975, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 12, "Genesis of the Daleks - Part Two" },
                    { 395, 2, 4, new DateTime(1975, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 12, "Genesis of the Daleks - Part Four" },
                    { 396, 2, 4, new DateTime(1975, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 12, "Genesis of the Daleks - Part Five" },
                    { 397, 2, 4, new DateTime(1975, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 12, "Genesis of the Daleks - Part Six" },
                    { 398, 17, 4, new DateTime(1975, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 12, "Revenge of the Cybermen - Part One" },
                    { 399, 17, 4, new DateTime(1975, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 12, "Revenge of the Cybermen - Part Two" },
                    { 400, 17, 4, new DateTime(1975, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 12, "Revenge of the Cybermen - Part Three" },
                    { 401, 17, 4, new DateTime(1975, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 12, "Revenge of the Cybermen - Part Four" },
                    { 402, 35, 4, new DateTime(1975, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 13, "Terror of the Zygons - Part One" },
                    { 403, 35, 4, new DateTime(1975, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 13, "Terror of the Zygons - Part Two" },
                    { 404, 35, 4, new DateTime(1975, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 13, "Terror of the Zygons - Part Three" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 405, 35, 4, new DateTime(1975, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 13, "Terror of the Zygons - Part Four" },
                    { 394, 2, 4, new DateTime(1975, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 12, "Genesis of the Daleks - Part Three" },
                    { 867, 81, 13, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Revised", "", 38, "The Timeless Children " },
                    { 326, 34, 3, new DateTime(1972, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 9, "The Time Monster - Part Three" },
                    { 324, 34, 3, new DateTime(1972, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 9, "The Time Monster - Part One" },
                    { 246, 29, 2, new DateTime(1969, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, "Classic", "", 6, "The War Games - Part Three" },
                    { 247, 29, 2, new DateTime(1969, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, "Classic", "", 6, "The War Games - Part Four" },
                    { 248, 29, 2, new DateTime(1969, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, "Classic", "", 6, "The War Games - Part Five" },
                    { 249, 29, 2, new DateTime(1969, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "Classic", "", 6, "The War Games - Part Six" },
                    { 250, 29, 2, new DateTime(1969, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, "Classic", "", 6, "The War Games - Part Seven" },
                    { 251, 29, 2, new DateTime(1969, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, "Classic", "", 6, "The War Games - Part Eight" },
                    { 252, 29, 2, new DateTime(1969, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, "Classic", "", 6, "The War Games - Part Nine" },
                    { 253, 29, 2, new DateTime(1969, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, "Classic", "", 6, "The War Games - Part Ten" },
                    { 254, 28, 3, new DateTime(1970, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 7, "Spearhead from Space - Part One" },
                    { 255, 28, 3, new DateTime(1970, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 7, "Spearhead from Space - Part Two" },
                    { 256, 28, 3, new DateTime(1970, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 7, "Spearhead from Space - Part Three" },
                    { 257, 28, 3, new DateTime(1970, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 7, "Spearhead from Space - Part Four" },
                    { 258, 21, 3, new DateTime(1970, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 7, "The Silurians - Part One" },
                    { 259, 21, 3, new DateTime(1970, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 7, "The Silurians - Part Two" },
                    { 260, 21, 3, new DateTime(1970, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 7, "The Silurians - Part Three" },
                    { 261, 21, 3, new DateTime(1970, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 7, "The Silurians - Part Four" },
                    { 262, 21, 3, new DateTime(1970, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 7, "The Silurians - Part Five" },
                    { 263, 21, 3, new DateTime(1970, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 7, "The Silurians - Part Six" },
                    { 264, 21, 3, new DateTime(1970, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 7, "The Silurians - Part Seven" },
                    { 265, 3, 3, new DateTime(1970, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 7, "The Ambassadors of Death - Part One" },
                    { 266, 3, 3, new DateTime(1970, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 7, "The Ambassadors of Death - Part Two" },
                    { 267, 3, 3, new DateTime(1970, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 7, "The Ambassadors of Death - Part Three" },
                    { 268, 3, 3, new DateTime(1970, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 7, "The Ambassadors of Death - Part Four" },
                    { 245, 29, 2, new DateTime(1969, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, "Classic", "", 6, "The War Games - Part Two" },
                    { 269, 3, 3, new DateTime(1970, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 7, "The Ambassadors of Death - Part Five" },
                    { 244, 29, 2, new DateTime(1969, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "Classic", "", 6, "The War Games - Part One" },
                    { 242, 28, 2, new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, "Classic", "", 6, "The Space Pirates - Part Five" },
                    { 219, 26, 2, new DateTime(1968, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 6, "The Mind Robber - Part Five" },
                    { 220, 27, 2, new DateTime(1968, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 6, "The Invasion - Part One" },
                    { 221, 27, 2, new DateTime(1968, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 6, "The Invasion - Part Two" },
                    { 222, 27, 2, new DateTime(1968, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 6, "The Invasion - Part Three" },
                    { 223, 27, 2, new DateTime(1968, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 6, "The Invasion - Part Four" },
                    { 224, 27, 2, new DateTime(1968, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 6, "The Invasion - Part Five" },
                    { 225, 27, 2, new DateTime(1968, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 6, "The Invasion - Part Six" },
                    { 226, 27, 2, new DateTime(1968, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 6, "The Invasion - Part Seven" },
                    { 227, 27, 2, new DateTime(1968, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 6, "The Invasion - Part Eight" },
                    { 228, 28, 2, new DateTime(1968, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 6, "The Krotons - Part One" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 229, 28, 2, new DateTime(1969, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 6, "The Krotons - Part Two" },
                    { 230, 28, 2, new DateTime(1969, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 6, "The Krotons - Part Three" },
                    { 231, 28, 2, new DateTime(1969, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 6, "The Krotons - Part Four" },
                    { 232, 14, 2, new DateTime(1969, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 6, "The Seeds of Death - Part One" },
                    { 233, 14, 2, new DateTime(1969, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 6, "The Seeds of Death - Part Two" },
                    { 234, 14, 2, new DateTime(1969, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 6, "The Seeds of Death - Part Three" },
                    { 235, 14, 2, new DateTime(1969, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Classic", "", 6, "The Seeds of Death - Part Four" },
                    { 236, 14, 2, new DateTime(1969, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Classic", "", 6, "The Seeds of Death - Part Five" },
                    { 237, 14, 2, new DateTime(1969, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Classic", "", 6, "The Seeds of Death - Part Six" },
                    { 238, 28, 2, new DateTime(1969, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "Classic", "", 6, "The Space Pirates - Part One" },
                    { 239, 28, 2, new DateTime(1969, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Classic", "", 6, "The Space Pirates - Part Two" },
                    { 240, 28, 2, new DateTime(1969, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, "Classic", "", 6, "The Space Pirates - Part Three" },
                    { 241, 28, 2, new DateTime(1969, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, "Classic", "", 6, "The Space Pirates - Part Four" },
                    { 243, 28, 2, new DateTime(1969, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, "Classic", "", 6, "The Space Pirates - Part Six" },
                    { 270, 3, 3, new DateTime(1970, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 7, "The Ambassadors of Death - Part Six" },
                    { 271, 3, 3, new DateTime(1970, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 7, "The Ambassadors of Death - Part Seven" },
                    { 272, 30, 3, new DateTime(1970, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 7, "Inferno - Part One" },
                    { 301, 33, 3, new DateTime(1971, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 8, "The D�mons - Part Three" },
                    { 302, 33, 3, new DateTime(1971, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 8, "The D�mons - Part Four" },
                    { 303, 33, 3, new DateTime(1971, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 8, "The D�mons - Part Five" },
                    { 304, 7, 3, new DateTime(1972, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 9, "Day of the Daleks - Part One" },
                    { 305, 7, 3, new DateTime(1972, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 9, "Day of the Daleks - Part Two" },
                    { 306, 7, 3, new DateTime(1972, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 9, "Day of the Daleks - Part Three" },
                    { 307, 7, 3, new DateTime(1972, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 9, "Day of the Daleks - Part Four" },
                    { 308, 14, 3, new DateTime(1972, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 9, "The Curse of Peladon - Part One" },
                    { 309, 14, 3, new DateTime(1972, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 9, "The Curse of Peladon - Part Two" },
                    { 310, 14, 3, new DateTime(1972, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 9, "The Curse of Peladon - Part Three" },
                    { 311, 14, 3, new DateTime(1972, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 9, "The Curse of Peladon - Part Four" },
                    { 312, 21, 3, new DateTime(1972, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 9, "The Sea Devils - Part One" },
                    { 313, 21, 3, new DateTime(1972, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 9, "The Sea Devils - Part Two" },
                    { 314, 21, 3, new DateTime(1972, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 9, "The Sea Devils - Part Three" },
                    { 315, 21, 3, new DateTime(1972, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 9, "The Sea Devils - Part Four" },
                    { 316, 21, 3, new DateTime(1972, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 9, "The Sea Devils - Part Five" },
                    { 317, 21, 3, new DateTime(1972, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 9, "The Sea Devils - Part Six" },
                    { 318, 31, 3, new DateTime(1972, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 9, "The Mutants - Part One" },
                    { 319, 31, 3, new DateTime(1972, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 9, "The Mutants - Part Two" },
                    { 320, 31, 3, new DateTime(1972, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 9, "The Mutants - Part Three" },
                    { 321, 31, 3, new DateTime(1972, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 9, "The Mutants - Part Four" },
                    { 322, 31, 3, new DateTime(1972, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 9, "The Mutants - Part Five" },
                    { 323, 31, 3, new DateTime(1972, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 9, "The Mutants - Part Six" },
                    { 300, 33, 3, new DateTime(1971, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 8, "The D�mons - Part Two" },
                    { 299, 33, 3, new DateTime(1971, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 8, "The D�mons - Part One" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 298, 21, 3, new DateTime(1971, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 8, "Colony in Space - Part Six" },
                    { 297, 21, 3, new DateTime(1971, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Classic", "", 8, "Colony in Space - Part Five" },
                    { 273, 30, 3, new DateTime(1970, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Classic", "", 7, "Inferno - Part Two" },
                    { 274, 30, 3, new DateTime(1970, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Classic", "", 7, "Inferno - Part Three" },
                    { 275, 30, 3, new DateTime(1970, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 7, "Inferno - Part Four" },
                    { 276, 30, 3, new DateTime(1970, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Classic", "", 7, "Inferno - Part Five" },
                    { 277, 30, 3, new DateTime(1970, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Classic", "", 7, "Inferno - Part Six" },
                    { 278, 30, 3, new DateTime(1970, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Classic", "", 7, "Inferno - Part Seven" },
                    { 279, 28, 3, new DateTime(1971, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Classic", "", 8, "Terror of the Autons - Part One" },
                    { 280, 28, 3, new DateTime(1971, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Classic", "", 8, "Terror of the Autons - Part Two" },
                    { 281, 28, 3, new DateTime(1971, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Classic", "", 8, "Terror of the Autons - Part Three" },
                    { 282, 28, 3, new DateTime(1971, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Classic", "", 8, "Terror of the Autons - Part Four" },
                    { 283, 30, 3, new DateTime(1971, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Classic", "", 8, "The Mind of Evil - Part One" },
                    { 325, 34, 3, new DateTime(1972, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Classic", "", 9, "The Time Monster - Part Two" },
                    { 284, 30, 3, new DateTime(1971, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Classic", "", 8, "The Mind of Evil - Part Two" },
                    { 286, 30, 3, new DateTime(1971, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Classic", "", 8, "The Mind of Evil - Part Four" },
                    { 287, 30, 3, new DateTime(1971, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Classic", "", 8, "The Mind of Evil - Part Five" },
                    { 288, 30, 3, new DateTime(1971, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Classic", "", 8, "The Mind of Evil - Part Six" },
                    { 289, 31, 3, new DateTime(1971, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Classic", "", 8, "The Claws of Axos - Part One" },
                    { 290, 31, 3, new DateTime(1971, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Classic", "", 8, "The Claws of Axos - Part Two" },
                    { 291, 31, 3, new DateTime(1971, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Classic", "", 8, "The Claws of Axos - Part Three" },
                    { 292, 31, 3, new DateTime(1971, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Classic", "", 8, "The Claws of Axos - Part Four" },
                    { 293, 21, 3, new DateTime(1971, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Classic", "", 8, "Colony in Space - Part One" },
                    { 294, 21, 3, new DateTime(1971, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Classic", "", 8, "Colony in Space - Part Two" },
                    { 295, 21, 3, new DateTime(1971, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Classic", "", 8, "Colony in Space - Part Three" },
                    { 296, 21, 3, new DateTime(1971, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Classic", "", 8, "Colony in Space - Part Four" },
                    { 285, 30, 3, new DateTime(1971, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Classic", "", 8, "The Mind of Evil - Part Three" },
                    { 868, 81, 13, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Special", "", 38, "Revolution of the Daleks" }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1342, 23, 482 },
                    { 1270, 22, 482 },
                    { 1341, 23, 481 },
                    { 1269, 22, 481 },
                    { 1340, 23, 480 },
                    { 1268, 22, 480 },
                    { 1267, 22, 479 },
                    { 1245, 21, 479 },
                    { 1266, 22, 478 },
                    { 1244, 21, 478 },
                    { 1265, 22, 477 },
                    { 1243, 21, 477 },
                    { 1264, 22, 476 },
                    { 1242, 21, 476 },
                    { 1263, 22, 475 },
                    { 1241, 21, 475 },
                    { 1262, 22, 474 },
                    { 1255, 22, 467 },
                    { 1234, 21, 468 },
                    { 1256, 22, 468 },
                    { 1235, 21, 469 },
                    { 1257, 22, 469 },
                    { 1236, 21, 470 },
                    { 1271, 22, 483 },
                    { 1258, 22, 470 },
                    { 1259, 22, 471 },
                    { 1238, 21, 472 },
                    { 1260, 22, 472 },
                    { 1239, 21, 473 },
                    { 1261, 22, 473 },
                    { 1240, 21, 474 },
                    { 1237, 21, 471 },
                    { 1233, 21, 467 },
                    { 1343, 23, 483 },
                    { 1344, 23, 484 },
                    { 1288, 22, 500 },
                    { 1359, 23, 499 },
                    { 1287, 22, 499 },
                    { 1358, 23, 498 },
                    { 1286, 22, 498 },
                    { 1357, 23, 497 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1285, 22, 497 },
                    { 1356, 23, 496 },
                    { 1284, 22, 496 },
                    { 1355, 23, 495 },
                    { 1283, 22, 495 },
                    { 1354, 23, 494 },
                    { 1282, 22, 494 },
                    { 1353, 23, 493 },
                    { 1281, 22, 493 },
                    { 1352, 23, 492 },
                    { 1280, 22, 492 },
                    { 1273, 22, 485 },
                    { 1345, 23, 485 },
                    { 1274, 22, 486 },
                    { 1346, 23, 486 },
                    { 1275, 22, 487 },
                    { 1347, 23, 487 },
                    { 1272, 22, 484 },
                    { 1276, 22, 488 },
                    { 1277, 22, 489 },
                    { 1349, 23, 489 },
                    { 1278, 22, 490 },
                    { 1350, 23, 490 },
                    { 1279, 22, 491 },
                    { 1351, 23, 491 },
                    { 1348, 23, 488 },
                    { 1254, 22, 466 },
                    { 1232, 21, 466 },
                    { 1253, 22, 465 },
                    { 926, 17, 432 },
                    { 925, 17, 431 },
                    { 924, 17, 430 },
                    { 923, 17, 429 },
                    { 922, 17, 428 },
                    { 921, 17, 427 },
                    { 920, 17, 426 },
                    { 919, 17, 425 },
                    { 918, 17, 424 },
                    { 917, 17, 423 },
                    { 916, 17, 422 },
                    { 915, 17, 421 },
                    { 914, 17, 420 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 913, 17, 419 },
                    { 912, 17, 418 },
                    { 911, 17, 417 },
                    { 910, 17, 416 },
                    { 896, 17, 402 },
                    { 897, 17, 403 },
                    { 898, 17, 404 },
                    { 899, 17, 405 },
                    { 900, 17, 406 },
                    { 901, 17, 407 },
                    { 927, 17, 433 },
                    { 902, 17, 408 },
                    { 904, 17, 410 },
                    { 905, 17, 411 },
                    { 906, 17, 412 },
                    { 907, 17, 413 },
                    { 908, 17, 414 },
                    { 909, 17, 415 },
                    { 903, 17, 409 },
                    { 928, 17, 434 },
                    { 929, 17, 435 },
                    { 1206, 21, 440 },
                    { 1246, 22, 458 },
                    { 1225, 21, 459 },
                    { 1247, 22, 459 },
                    { 1226, 21, 460 },
                    { 1248, 22, 460 },
                    { 1227, 21, 461 },
                    { 1224, 21, 458 },
                    { 1249, 22, 461 },
                    { 1250, 22, 462 },
                    { 1229, 21, 463 },
                    { 1251, 22, 463 },
                    { 1230, 21, 464 },
                    { 1252, 22, 464 },
                    { 1231, 21, 465 },
                    { 1228, 21, 462 },
                    { 1360, 23, 500 },
                    { 1223, 21, 457 },
                    { 1221, 21, 455 },
                    { 1207, 21, 441 },
                    { 1208, 21, 442 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1209, 21, 443 },
                    { 1210, 21, 444 },
                    { 1211, 21, 445 },
                    { 1212, 21, 446 },
                    { 1222, 21, 456 },
                    { 1213, 21, 447 },
                    { 1215, 21, 449 },
                    { 1216, 21, 450 },
                    { 1217, 21, 451 },
                    { 1218, 21, 452 },
                    { 1219, 21, 453 },
                    { 1220, 21, 454 },
                    { 1214, 21, 448 },
                    { 1289, 22, 501 },
                    { 1361, 23, 501 },
                    { 1290, 22, 502 },
                    { 1420, 25, 548 },
                    { 1408, 24, 548 },
                    { 1336, 22, 548 },
                    { 1419, 25, 547 },
                    { 1407, 24, 547 },
                    { 1335, 22, 547 },
                    { 1418, 25, 546 },
                    { 1406, 24, 546 },
                    { 1334, 22, 546 },
                    { 1417, 25, 545 },
                    { 1405, 24, 545 },
                    { 1333, 22, 545 },
                    { 1416, 25, 544 },
                    { 1404, 24, 544 },
                    { 1332, 22, 544 },
                    { 1415, 25, 543 },
                    { 1403, 24, 543 },
                    { 1326, 22, 538 },
                    { 1398, 24, 538 },
                    { 1327, 22, 539 },
                    { 1399, 24, 539 },
                    { 1328, 22, 540 },
                    { 1400, 24, 540 },
                    { 1337, 22, 549 },
                    { 1412, 25, 540 },
                    { 1401, 24, 541 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1413, 25, 541 },
                    { 1330, 22, 542 },
                    { 1402, 24, 542 },
                    { 1414, 25, 542 },
                    { 1331, 22, 543 },
                    { 1329, 22, 541 },
                    { 1409, 24, 549 },
                    { 1421, 25, 549 },
                    { 1338, 22, 550 },
                    { 1505, 27, 556 },
                    { 1572, 28, 556 },
                    { 1429, 25, 557 },
                    { 1460, 26, 557 },
                    { 1506, 27, 557 },
                    { 1573, 28, 557 },
                    { 1459, 26, 556 },
                    { 1430, 25, 558 },
                    { 1507, 27, 558 },
                    { 1574, 28, 558 },
                    { 1431, 25, 559 },
                    { 1462, 26, 559 },
                    { 1508, 27, 559 },
                    { 1575, 28, 559 },
                    { 1461, 26, 558 },
                    { 1397, 24, 537 },
                    { 1428, 25, 556 },
                    { 1458, 26, 555 },
                    { 1410, 24, 550 },
                    { 1422, 25, 550 },
                    { 1339, 22, 551 },
                    { 1411, 24, 551 },
                    { 1423, 25, 551 },
                    { 1454, 26, 551 },
                    { 1571, 28, 555 },
                    { 1424, 25, 552 },
                    { 1425, 25, 553 },
                    { 1456, 26, 553 },
                    { 1426, 25, 554 },
                    { 1457, 26, 554 },
                    { 1570, 28, 554 },
                    { 1427, 25, 555 },
                    { 1455, 26, 552 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1205, 20, 401 },
                    { 1325, 22, 537 },
                    { 1324, 22, 536 },
                    { 1377, 24, 517 },
                    { 1305, 22, 517 },
                    { 1376, 24, 516 },
                    { 1304, 22, 516 },
                    { 1375, 24, 515 },
                    { 1303, 22, 515 },
                    { 1374, 24, 514 },
                    { 1302, 22, 514 },
                    { 1373, 24, 513 },
                    { 1301, 22, 513 },
                    { 1372, 24, 512 },
                    { 1300, 22, 512 },
                    { 1371, 24, 511 },
                    { 1299, 22, 511 },
                    { 1370, 24, 510 },
                    { 1298, 22, 510 },
                    { 1369, 24, 509 },
                    { 1362, 23, 502 },
                    { 1291, 22, 503 },
                    { 1363, 23, 503 },
                    { 1292, 22, 504 },
                    { 1364, 23, 504 },
                    { 1293, 22, 505 },
                    { 1306, 22, 518 },
                    { 1365, 23, 505 },
                    { 1366, 24, 506 },
                    { 1295, 22, 507 },
                    { 1367, 24, 507 },
                    { 1296, 22, 508 },
                    { 1368, 24, 508 },
                    { 1297, 22, 509 },
                    { 1294, 22, 506 },
                    { 1378, 24, 518 },
                    { 1307, 22, 519 },
                    { 1379, 24, 519 },
                    { 1317, 22, 529 },
                    { 1389, 24, 529 },
                    { 1318, 22, 530 },
                    { 1390, 24, 530 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1319, 22, 531 },
                    { 1391, 24, 531 },
                    { 1388, 24, 528 },
                    { 1320, 22, 532 },
                    { 1321, 22, 533 },
                    { 1393, 24, 533 },
                    { 1322, 22, 534 },
                    { 1394, 24, 534 },
                    { 1323, 22, 535 },
                    { 1395, 24, 535 },
                    { 1392, 24, 532 },
                    { 1396, 24, 536 },
                    { 1316, 22, 528 },
                    { 1315, 22, 527 },
                    { 1308, 22, 520 },
                    { 1380, 24, 520 },
                    { 1309, 22, 521 },
                    { 1381, 24, 521 },
                    { 1310, 22, 522 },
                    { 1382, 24, 522 },
                    { 1387, 24, 527 },
                    { 1311, 22, 523 },
                    { 1312, 22, 524 },
                    { 1384, 24, 524 },
                    { 1313, 22, 525 },
                    { 1385, 24, 525 },
                    { 1314, 22, 526 },
                    { 1386, 24, 526 },
                    { 1383, 24, 523 },
                    { 895, 17, 401 },
                    { 1204, 20, 400 },
                    { 894, 17, 400 },
                    { 840, 16, 346 },
                    { 711, 14, 346 },
                    { 1149, 19, 345 },
                    { 1021, 18, 345 },
                    { 839, 16, 345 },
                    { 710, 14, 345 },
                    { 1148, 19, 344 },
                    { 1020, 18, 344 },
                    { 838, 16, 344 },
                    { 709, 14, 344 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1147, 19, 343 },
                    { 1019, 18, 343 },
                    { 837, 16, 343 },
                    { 708, 14, 343 },
                    { 1146, 19, 342 },
                    { 1018, 18, 342 },
                    { 836, 16, 342 },
                    { 1142, 19, 338 },
                    { 704, 14, 339 },
                    { 833, 16, 339 },
                    { 1015, 18, 339 },
                    { 1143, 19, 339 },
                    { 705, 14, 340 },
                    { 1022, 18, 346 },
                    { 834, 16, 340 },
                    { 1144, 19, 340 },
                    { 706, 14, 341 },
                    { 835, 16, 341 },
                    { 1017, 18, 341 },
                    { 1145, 19, 341 },
                    { 707, 14, 342 },
                    { 1016, 18, 340 },
                    { 1150, 19, 346 },
                    { 712, 14, 347 },
                    { 841, 16, 347 },
                    { 717, 14, 352 },
                    { 846, 16, 352 },
                    { 1028, 18, 352 },
                    { 1156, 19, 352 },
                    { 718, 14, 353 },
                    { 847, 16, 353 },
                    { 1155, 19, 351 },
                    { 1029, 18, 353 },
                    { 719, 14, 354 },
                    { 848, 16, 354 },
                    { 1030, 18, 354 },
                    { 1158, 19, 354 },
                    { 720, 14, 355 },
                    { 849, 16, 355 },
                    { 1157, 19, 353 },
                    { 1014, 18, 338 },
                    { 1027, 18, 351 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 716, 14, 351 },
                    { 1023, 18, 347 },
                    { 1151, 19, 347 },
                    { 713, 14, 348 },
                    { 842, 16, 348 },
                    { 1024, 18, 348 },
                    { 1152, 19, 348 },
                    { 845, 16, 351 },
                    { 714, 14, 349 },
                    { 1025, 18, 349 },
                    { 1153, 19, 349 },
                    { 715, 14, 350 },
                    { 844, 16, 350 },
                    { 1026, 18, 350 },
                    { 1154, 19, 350 },
                    { 843, 16, 349 },
                    { 1031, 18, 355 },
                    { 832, 16, 338 },
                    { 1141, 19, 337 },
                    { 1004, 18, 328 },
                    { 822, 16, 328 },
                    { 693, 14, 328 },
                    { 1131, 19, 327 },
                    { 1003, 18, 327 },
                    { 821, 16, 327 },
                    { 692, 14, 327 },
                    { 1130, 19, 326 },
                    { 1002, 18, 326 },
                    { 820, 16, 326 },
                    { 691, 14, 326 },
                    { 1129, 19, 325 },
                    { 1001, 18, 325 },
                    { 819, 16, 325 },
                    { 690, 14, 325 },
                    { 1128, 19, 324 },
                    { 1000, 18, 324 },
                    { 686, 14, 321 },
                    { 815, 16, 321 },
                    { 997, 18, 321 },
                    { 1125, 19, 321 },
                    { 687, 14, 322 },
                    { 816, 16, 322 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1132, 19, 328 },
                    { 998, 18, 322 },
                    { 688, 14, 323 },
                    { 817, 16, 323 },
                    { 999, 18, 323 },
                    { 1127, 19, 323 },
                    { 689, 14, 324 },
                    { 818, 16, 324 },
                    { 1126, 19, 322 },
                    { 694, 14, 329 },
                    { 823, 16, 329 },
                    { 1005, 18, 329 },
                    { 828, 16, 334 },
                    { 1010, 18, 334 },
                    { 1138, 19, 334 },
                    { 700, 14, 335 },
                    { 829, 16, 335 },
                    { 1011, 18, 335 },
                    { 699, 14, 334 },
                    { 1139, 19, 335 },
                    { 830, 16, 336 },
                    { 1012, 18, 336 },
                    { 1140, 19, 336 },
                    { 702, 14, 337 },
                    { 831, 16, 337 },
                    { 1013, 18, 337 },
                    { 701, 14, 336 },
                    { 703, 14, 338 },
                    { 1137, 19, 333 },
                    { 827, 16, 333 },
                    { 1133, 19, 329 },
                    { 695, 14, 330 },
                    { 824, 16, 330 },
                    { 1006, 18, 330 },
                    { 1134, 19, 330 },
                    { 696, 14, 331 },
                    { 1009, 18, 333 },
                    { 825, 16, 331 },
                    { 1135, 19, 331 },
                    { 697, 14, 332 },
                    { 826, 16, 332 },
                    { 1008, 18, 332 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1136, 19, 332 },
                    { 698, 14, 333 },
                    { 1007, 18, 331 },
                    { 1432, 25, 560 },
                    { 1159, 19, 355 },
                    { 850, 17, 356 },
                    { 1185, 19, 381 },
                    { 1057, 18, 381 },
                    { 875, 17, 381 },
                    { 746, 14, 381 },
                    { 1184, 19, 380 },
                    { 1056, 18, 380 },
                    { 874, 17, 380 },
                    { 745, 14, 380 },
                    { 1183, 19, 379 },
                    { 1055, 18, 379 },
                    { 873, 17, 379 },
                    { 744, 14, 379 },
                    { 1182, 19, 378 },
                    { 1054, 18, 378 },
                    { 872, 17, 378 },
                    { 743, 14, 378 },
                    { 1181, 19, 377 },
                    { 868, 17, 374 },
                    { 1050, 18, 374 },
                    { 1178, 19, 374 },
                    { 740, 14, 375 },
                    { 869, 17, 375 },
                    { 1051, 18, 375 },
                    { 876, 17, 382 },
                    { 1179, 19, 375 },
                    { 870, 17, 376 },
                    { 1052, 18, 376 },
                    { 1180, 19, 376 },
                    { 742, 14, 377 },
                    { 871, 17, 377 },
                    { 1053, 18, 377 },
                    { 741, 14, 376 },
                    { 1186, 20, 382 },
                    { 877, 17, 383 },
                    { 1187, 20, 383 },
                    { 887, 17, 393 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1197, 20, 393 },
                    { 888, 17, 394 },
                    { 1198, 20, 394 },
                    { 889, 17, 395 },
                    { 1199, 20, 395 },
                    { 1196, 20, 392 },
                    { 890, 17, 396 },
                    { 891, 17, 397 },
                    { 1201, 20, 397 },
                    { 892, 17, 398 },
                    { 1202, 20, 398 },
                    { 893, 17, 399 },
                    { 1203, 20, 399 },
                    { 1200, 20, 396 },
                    { 739, 14, 374 },
                    { 886, 17, 392 },
                    { 885, 17, 391 },
                    { 878, 17, 384 },
                    { 1188, 20, 384 },
                    { 879, 17, 385 },
                    { 1189, 20, 385 },
                    { 880, 17, 386 },
                    { 1190, 20, 386 },
                    { 1195, 20, 391 },
                    { 881, 17, 387 },
                    { 882, 17, 388 },
                    { 1192, 20, 388 },
                    { 883, 17, 389 },
                    { 1193, 20, 389 },
                    { 884, 17, 390 },
                    { 1194, 20, 390 },
                    { 1191, 20, 387 },
                    { 721, 14, 356 },
                    { 1177, 19, 373 },
                    { 867, 17, 373 },
                    { 729, 14, 364 },
                    { 1167, 19, 363 },
                    { 1039, 18, 363 },
                    { 857, 17, 363 },
                    { 728, 14, 363 },
                    { 1166, 19, 362 },
                    { 1038, 18, 362 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 856, 17, 362 },
                    { 727, 14, 362 },
                    { 1165, 19, 361 },
                    { 1037, 18, 361 },
                    { 855, 17, 361 },
                    { 726, 14, 361 },
                    { 1164, 19, 360 },
                    { 1036, 18, 360 },
                    { 854, 17, 360 },
                    { 725, 14, 360 },
                    { 1032, 18, 356 },
                    { 1160, 19, 356 },
                    { 722, 14, 357 },
                    { 851, 17, 357 },
                    { 1033, 18, 357 },
                    { 1161, 19, 357 },
                    { 858, 17, 364 },
                    { 723, 14, 358 },
                    { 1034, 18, 358 },
                    { 1162, 19, 358 },
                    { 724, 14, 359 },
                    { 853, 17, 359 },
                    { 1035, 18, 359 },
                    { 1163, 19, 359 },
                    { 852, 17, 358 },
                    { 1040, 18, 364 },
                    { 1168, 19, 364 },
                    { 730, 14, 365 },
                    { 1173, 19, 369 },
                    { 2019, 52, 868 },
                    { 864, 17, 370 },
                    { 1046, 18, 370 },
                    { 1174, 19, 370 },
                    { 736, 14, 371 },
                    { 1045, 18, 369 },
                    { 865, 17, 371 },
                    { 1175, 19, 371 },
                    { 737, 14, 372 },
                    { 866, 17, 372 },
                    { 1048, 18, 372 },
                    { 1176, 19, 372 },
                    { 738, 14, 373 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1047, 18, 371 },
                    { 1049, 18, 373 },
                    { 863, 17, 369 },
                    { 1172, 19, 368 },
                    { 859, 17, 365 },
                    { 1041, 18, 365 },
                    { 1169, 19, 365 },
                    { 731, 14, 366 },
                    { 860, 17, 366 },
                    { 1042, 18, 366 },
                    { 734, 14, 369 },
                    { 1170, 19, 366 },
                    { 861, 17, 367 },
                    { 1043, 18, 367 },
                    { 1171, 19, 367 },
                    { 733, 14, 368 },
                    { 862, 17, 368 },
                    { 1044, 18, 368 },
                    { 732, 14, 367 },
                    { 1463, 26, 560 },
                    { 1509, 27, 560 },
                    { 1576, 28, 560 },
                    { 1833, 45, 774 },
                    { 1854, 48, 773 },
                    { 1832, 45, 773 },
                    { 1831, 45, 772 },
                    { 1860, 46, 771 },
                    { 1830, 45, 771 },
                    { 1859, 46, 770 },
                    { 1829, 45, 770 },
                    { 1858, 46, 769 },
                    { 1828, 45, 769 },
                    { 1857, 46, 768 },
                    { 1827, 45, 768 },
                    { 1856, 47, 767 },
                    { 1826, 45, 767 },
                    { 1855, 47, 766 },
                    { 1825, 45, 766 },
                    { 1824, 45, 765 },
                    { 1807, 38, 755 },
                    { 1808, 38, 756 },
                    { 1809, 38, 757 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1813, 34, 757 },
                    { 1814, 39, 757 },
                    { 1815, 36, 757 },
                    { 1861, 46, 774 },
                    { 1816, 37, 757 },
                    { 1818, 41, 758 },
                    { 1819, 42, 759 },
                    { 1820, 43, 760 },
                    { 1821, 44, 761 },
                    { 1822, 45, 763 },
                    { 1823, 45, 764 },
                    { 1817, 17, 757 },
                    { 1881, 47, 774 },
                    { 1834, 45, 775 },
                    { 1862, 46, 775 },
                    { 1884, 47, 783 },
                    { 1843, 45, 784 },
                    { 1871, 46, 784 },
                    { 1885, 47, 784 },
                    { 1844, 45, 785 },
                    { 1872, 46, 785 },
                    { 1870, 46, 783 },
                    { 1845, 45, 786 },
                    { 1846, 45, 787 },
                    { 1874, 46, 787 },
                    { 1853, 48, 788 },
                    { 1847, 45, 789 },
                    { 1875, 46, 789 },
                    { 1886, 47, 789 },
                    { 1873, 46, 786 },
                    { 1806, 38, 754 },
                    { 1842, 45, 783 },
                    { 1841, 45, 782 },
                    { 1882, 47, 775 },
                    { 1835, 45, 776 },
                    { 1863, 46, 776 },
                    { 1836, 45, 777 },
                    { 1864, 46, 777 },
                    { 1883, 47, 777 },
                    { 1869, 46, 782 },
                    { 1837, 45, 778 },
                    { 1838, 45, 779 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1866, 46, 779 },
                    { 1839, 45, 780 },
                    { 1867, 46, 780 },
                    { 1840, 45, 781 },
                    { 1868, 46, 781 },
                    { 1865, 46, 778 },
                    { 1848, 45, 791 },
                    { 1812, 47, 753 },
                    { 1804, 38, 752 },
                    { 1761, 34, 720 },
                    { 1780, 22, 719 },
                    { 1779, 17, 719 },
                    { 1776, 37, 719 },
                    { 1760, 34, 719 },
                    { 1759, 34, 718 },
                    { 1758, 34, 717 },
                    { 1757, 34, 716 },
                    { 1756, 34, 715 },
                    { 1755, 34, 714 },
                    { 1775, 36, 713 },
                    { 1754, 34, 713 },
                    { 1774, 36, 712 },
                    { 1753, 34, 712 },
                    { 1773, 36, 711 },
                    { 1752, 34, 711 },
                    { 1772, 35, 710 },
                    { 1739, 32, 698 },
                    { 1740, 32, 699 },
                    { 1741, 32, 700 },
                    { 1742, 32, 701 },
                    { 1743, 33, 702 },
                    { 1744, 34, 703 },
                    { 1777, 37, 720 },
                    { 1745, 34, 704 },
                    { 1747, 34, 706 },
                    { 1748, 34, 707 },
                    { 1749, 34, 708 },
                    { 1750, 34, 709 },
                    { 1771, 35, 709 },
                    { 1751, 34, 710 },
                    { 1746, 34, 705 },
                    { 1762, 34, 721 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1778, 37, 721 },
                    { 1763, 34, 722 },
                    { 1792, 39, 741 },
                    { 1793, 39, 742 },
                    { 1794, 39, 743 },
                    { 1796, 36, 743 },
                    { 1795, 40, 744 },
                    { 1797, 38, 745 },
                    { 1791, 39, 740 },
                    { 1798, 38, 746 },
                    { 1800, 38, 748 },
                    { 1801, 38, 749 },
                    { 1802, 38, 750 },
                    { 1810, 39, 750 },
                    { 1803, 38, 751 },
                    { 1811, 39, 751 },
                    { 1799, 38, 747 },
                    { 1805, 38, 753 },
                    { 1790, 39, 739 },
                    { 1788, 39, 737 },
                    { 1764, 34, 723 },
                    { 1765, 34, 724 },
                    { 1766, 34, 725 },
                    { 1767, 34, 726 },
                    { 1768, 34, 727 },
                    { 1769, 34, 728 },
                    { 1789, 39, 738 },
                    { 1770, 34, 729 },
                    { 1782, 39, 731 },
                    { 1783, 39, 732 },
                    { 1784, 39, 733 },
                    { 1785, 39, 734 },
                    { 1786, 39, 735 },
                    { 1787, 39, 736 },
                    { 1781, 38, 730 },
                    { 1738, 32, 697 },
                    { 1876, 46, 791 },
                    { 1877, 46, 792 },
                    { 1985, 54, 856 },
                    { 1963, 53, 856 },
                    { 2006, 52, 855 },
                    { 1984, 54, 855 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1962, 53, 855 },
                    { 2005, 52, 854 },
                    { 1983, 54, 854 },
                    { 1961, 53, 854 },
                    { 2004, 52, 853 },
                    { 1982, 54, 853 },
                    { 1960, 53, 853 },
                    { 2003, 52, 852 },
                    { 1981, 54, 852 },
                    { 1959, 53, 852 },
                    { 2002, 52, 851 },
                    { 1980, 54, 851 },
                    { 1958, 53, 851 },
                    { 1940, 50, 846 },
                    { 1953, 51, 846 },
                    { 1954, 53, 847 },
                    { 1976, 54, 847 },
                    { 1998, 52, 847 },
                    { 1955, 53, 848 },
                    { 2007, 52, 856 },
                    { 1977, 54, 848 },
                    { 1956, 53, 849 },
                    { 1978, 54, 849 },
                    { 2000, 52, 849 },
                    { 1957, 53, 850 },
                    { 1979, 54, 850 },
                    { 2001, 52, 850 },
                    { 1999, 52, 848 },
                    { 1964, 53, 857 },
                    { 1986, 54, 857 },
                    { 2008, 52, 857 },
                    { 1971, 53, 864 },
                    { 1993, 54, 864 },
                    { 2015, 52, 864 },
                    { 1972, 53, 865 },
                    { 1994, 54, 865 },
                    { 2016, 52, 865 },
                    { 2014, 52, 863 },
                    { 1973, 53, 866 },
                    { 2017, 52, 866 },
                    { 1974, 53, 867 },
                    { 1996, 54, 867 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 2018, 52, 867 },
                    { 1975, 53, 868 },
                    { 1997, 54, 868 },
                    { 1995, 54, 866 },
                    { 1952, 51, 845 },
                    { 1992, 54, 863 },
                    { 2013, 52, 862 },
                    { 1965, 53, 858 },
                    { 1987, 54, 858 },
                    { 2009, 52, 858 },
                    { 1966, 53, 859 },
                    { 1988, 54, 859 },
                    { 2010, 52, 859 },
                    { 1970, 53, 863 },
                    { 1967, 53, 860 },
                    { 2011, 52, 860 },
                    { 1968, 53, 861 },
                    { 1990, 54, 861 },
                    { 2012, 52, 861 },
                    { 1969, 53, 862 },
                    { 1991, 54, 862 },
                    { 1989, 54, 860 },
                    { 1849, 45, 792 },
                    { 1939, 50, 845 },
                    { 1938, 50, 844 },
                    { 1912, 49, 818 },
                    { 1911, 49, 817 },
                    { 1910, 49, 816 },
                    { 1909, 49, 815 },
                    { 1908, 49, 814 },
                    { 1907, 49, 813 },
                    { 1906, 49, 812 },
                    { 1905, 49, 811 },
                    { 1904, 49, 810 },
                    { 1903, 49, 809 },
                    { 1902, 49, 808 },
                    { 1901, 49, 807 },
                    { 1900, 49, 806 },
                    { 1899, 49, 805 },
                    { 1898, 49, 804 },
                    { 1888, 47, 804 },
                    { 1897, 49, 803 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1850, 45, 793 },
                    { 1878, 46, 793 },
                    { 1851, 45, 794 },
                    { 1879, 46, 794 },
                    { 1852, 45, 795 },
                    { 1880, 46, 795 },
                    { 1913, 49, 819 },
                    { 1887, 47, 795 },
                    { 1891, 49, 797 },
                    { 1892, 49, 798 },
                    { 1893, 49, 799 },
                    { 1894, 49, 800 },
                    { 1895, 49, 801 },
                    { 1896, 49, 802 },
                    { 1890, 49, 796 },
                    { 1914, 49, 820 },
                    { 1915, 49, 821 },
                    { 1916, 49, 822 },
                    { 1931, 50, 837 },
                    { 1944, 51, 837 },
                    { 1932, 50, 838 },
                    { 1945, 51, 838 },
                    { 1933, 50, 839 },
                    { 1946, 51, 839 },
                    { 1943, 51, 836 },
                    { 1934, 50, 840 },
                    { 1935, 50, 841 },
                    { 1948, 51, 841 },
                    { 1936, 50, 842 },
                    { 1949, 51, 842 },
                    { 1937, 50, 843 },
                    { 1950, 51, 843 },
                    { 1947, 51, 840 },
                    { 1951, 51, 844 },
                    { 1930, 50, 836 },
                    { 1929, 50, 835 },
                    { 1917, 49, 823 },
                    { 1918, 49, 824 },
                    { 1919, 49, 825 },
                    { 1920, 49, 826 },
                    { 1921, 49, 827 },
                    { 1922, 49, 828 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1942, 51, 835 },
                    { 1923, 49, 829 },
                    { 1925, 49, 831 },
                    { 1926, 50, 832 },
                    { 1889, 47, 833 },
                    { 1927, 50, 833 },
                    { 1928, 50, 834 },
                    { 1941, 51, 834 },
                    { 1924, 49, 830 },
                    { 1124, 19, 320 },
                    { 1737, 32, 696 },
                    { 1735, 32, 694 },
                    { 1603, 28, 587 },
                    { 1536, 27, 587 },
                    { 1490, 26, 587 },
                    { 1602, 28, 586 },
                    { 1535, 27, 586 },
                    { 1489, 26, 586 },
                    { 1601, 28, 585 },
                    { 1534, 27, 585 },
                    { 1488, 26, 585 },
                    { 1600, 28, 584 },
                    { 1533, 27, 584 },
                    { 1487, 26, 584 },
                    { 1599, 28, 583 },
                    { 1532, 27, 583 },
                    { 1486, 26, 583 },
                    { 1598, 28, 582 },
                    { 1531, 27, 582 },
                    { 1594, 28, 578 },
                    { 1451, 25, 579 },
                    { 1482, 26, 579 },
                    { 1528, 27, 579 },
                    { 1595, 28, 579 },
                    { 1452, 25, 580 },
                    { 1491, 26, 588 },
                    { 1483, 26, 580 },
                    { 1596, 28, 580 },
                    { 1453, 25, 581 },
                    { 1484, 26, 581 },
                    { 1530, 27, 581 },
                    { 1597, 28, 581 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1485, 26, 582 },
                    { 1529, 27, 580 },
                    { 1537, 27, 588 },
                    { 1604, 28, 588 },
                    { 1492, 26, 589 },
                    { 1544, 27, 595 },
                    { 1611, 28, 595 },
                    { 1499, 26, 596 },
                    { 1545, 27, 596 },
                    { 1612, 28, 596 },
                    { 1500, 26, 597 },
                    { 1498, 26, 595 },
                    { 1546, 27, 597 },
                    { 1501, 26, 598 },
                    { 1547, 27, 598 },
                    { 1614, 28, 598 },
                    { 1502, 26, 599 },
                    { 1548, 27, 599 },
                    { 1615, 28, 599 },
                    { 1613, 28, 597 },
                    { 1527, 27, 578 },
                    { 1610, 28, 594 },
                    { 1497, 26, 594 },
                    { 1538, 27, 589 },
                    { 1605, 28, 589 },
                    { 1493, 26, 590 },
                    { 1539, 27, 590 },
                    { 1606, 28, 590 },
                    { 1494, 26, 591 },
                    { 1543, 27, 594 },
                    { 1540, 27, 591 },
                    { 1495, 26, 592 },
                    { 1541, 27, 592 },
                    { 1608, 28, 592 },
                    { 1496, 26, 593 },
                    { 1542, 27, 593 },
                    { 1609, 28, 593 },
                    { 1607, 28, 591 },
                    { 1503, 26, 600 },
                    { 1481, 26, 578 },
                    { 1593, 28, 577 },
                    { 1517, 27, 568 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1471, 26, 568 },
                    { 1440, 25, 568 },
                    { 1583, 28, 567 },
                    { 1516, 27, 567 },
                    { 1470, 26, 567 },
                    { 1439, 25, 567 },
                    { 1582, 28, 566 },
                    { 1515, 27, 566 },
                    { 1469, 26, 566 },
                    { 1438, 25, 566 },
                    { 1581, 28, 565 },
                    { 1514, 27, 565 },
                    { 1468, 26, 565 },
                    { 1437, 25, 565 },
                    { 1580, 28, 564 },
                    { 1513, 27, 564 },
                    { 1433, 25, 561 },
                    { 1464, 26, 561 },
                    { 1510, 27, 561 },
                    { 1577, 28, 561 },
                    { 1434, 25, 562 },
                    { 1465, 26, 562 },
                    { 1584, 28, 568 },
                    { 1511, 27, 562 },
                    { 1435, 25, 563 },
                    { 1466, 26, 563 },
                    { 1512, 27, 563 },
                    { 1579, 28, 563 },
                    { 1436, 25, 564 },
                    { 1467, 26, 564 },
                    { 1578, 28, 562 },
                    { 1441, 25, 569 },
                    { 1472, 26, 569 },
                    { 1518, 27, 569 },
                    { 1477, 26, 574 },
                    { 1523, 27, 574 },
                    { 1590, 28, 574 },
                    { 1447, 25, 575 },
                    { 1478, 26, 575 },
                    { 1524, 27, 575 },
                    { 1446, 25, 574 },
                    { 1591, 28, 575 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1479, 26, 576 },
                    { 1525, 27, 576 },
                    { 1592, 28, 576 },
                    { 1449, 25, 577 },
                    { 1480, 26, 577 },
                    { 1526, 27, 577 },
                    { 1448, 25, 576 },
                    { 1450, 25, 578 },
                    { 1589, 28, 573 },
                    { 1476, 26, 573 },
                    { 1585, 28, 569 },
                    { 1442, 25, 570 },
                    { 1473, 26, 570 },
                    { 1519, 27, 570 },
                    { 1586, 28, 570 },
                    { 1443, 25, 571 },
                    { 1522, 27, 573 },
                    { 1474, 26, 571 },
                    { 1587, 28, 571 },
                    { 1444, 25, 572 },
                    { 1475, 26, 572 },
                    { 1521, 27, 572 },
                    { 1588, 28, 572 },
                    { 1445, 25, 573 },
                    { 1520, 27, 571 },
                    { 1736, 32, 695 },
                    { 1549, 27, 600 },
                    { 1504, 26, 601 },
                    { 1698, 31, 663 },
                    { 1697, 31, 662 },
                    { 1696, 31, 661 },
                    { 1695, 31, 660 },
                    { 1694, 31, 659 },
                    { 1693, 31, 658 },
                    { 1692, 31, 657 },
                    { 1691, 31, 656 },
                    { 1690, 31, 655 },
                    { 1689, 31, 654 },
                    { 1685, 30, 653 },
                    { 1684, 30, 652 },
                    { 1683, 30, 651 },
                    { 1682, 30, 650 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1681, 30, 649 },
                    { 1680, 30, 648 },
                    { 1679, 30, 647 },
                    { 1668, 30, 636 },
                    { 1669, 30, 637 },
                    { 1670, 30, 638 },
                    { 1671, 30, 639 },
                    { 1686, 11, 639 },
                    { 1672, 30, 640 },
                    { 1699, 31, 664 },
                    { 1687, 11, 640 },
                    { 1688, 11, 641 },
                    { 1674, 30, 642 },
                    { 1675, 30, 643 },
                    { 1676, 30, 644 },
                    { 1677, 30, 645 },
                    { 1678, 30, 646 },
                    { 1673, 30, 641 },
                    { 1700, 31, 665 },
                    { 1701, 31, 666 },
                    { 1702, 31, 667 },
                    { 1721, 32, 680 },
                    { 1722, 32, 681 },
                    { 1723, 32, 682 },
                    { 1724, 32, 683 },
                    { 1725, 32, 684 },
                    { 1726, 32, 685 },
                    { 1720, 32, 679 },
                    { 1727, 32, 686 },
                    { 1729, 32, 688 },
                    { 1730, 32, 689 },
                    { 1731, 32, 690 },
                    { 1732, 32, 691 },
                    { 1733, 32, 692 },
                    { 1734, 32, 693 },
                    { 1728, 32, 687 },
                    { 1667, 30, 635 },
                    { 1719, 32, 678 },
                    { 1717, 32, 676 },
                    { 1703, 31, 668 },
                    { 1709, 32, 668 },
                    { 1704, 31, 669 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1710, 32, 669 },
                    { 1705, 31, 670 },
                    { 1711, 32, 670 },
                    { 1718, 32, 677 },
                    { 1706, 31, 671 },
                    { 1707, 31, 672 },
                    { 1713, 32, 672 },
                    { 1708, 31, 673 },
                    { 1714, 32, 673 },
                    { 1715, 32, 674 },
                    { 1716, 32, 675 },
                    { 1712, 32, 671 },
                    { 1616, 28, 600 },
                    { 1666, 30, 634 },
                    { 1664, 30, 632 },
                    { 1562, 27, 613 },
                    { 1628, 28, 612 },
                    { 1561, 27, 612 },
                    { 1627, 28, 611 },
                    { 1560, 27, 611 },
                    { 1626, 28, 610 },
                    { 1559, 27, 610 },
                    { 1625, 28, 609 },
                    { 1558, 27, 609 },
                    { 1652, 23, 608 },
                    { 1651, 17, 608 },
                    { 1650, 14, 608 },
                    { 1649, 1, 608 },
                    { 1624, 28, 608 },
                    { 1557, 27, 608 },
                    { 1642, 29, 607 },
                    { 1623, 28, 607 },
                    { 1550, 27, 601 },
                    { 1617, 28, 601 },
                    { 1551, 27, 602 },
                    { 1618, 28, 602 },
                    { 1552, 27, 603 },
                    { 1619, 28, 603 },
                    { 1629, 28, 613 },
                    { 1553, 27, 604 },
                    { 1554, 27, 605 },
                    { 1621, 28, 605 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1555, 27, 606 },
                    { 1622, 28, 606 },
                    { 1641, 29, 606 },
                    { 1556, 27, 607 },
                    { 1620, 28, 604 },
                    { 1643, 29, 613 },
                    { 1563, 27, 614 },
                    { 1630, 28, 614 },
                    { 1654, 30, 622 },
                    { 1639, 28, 623 },
                    { 1647, 29, 623 },
                    { 1655, 30, 623 },
                    { 1640, 28, 624 },
                    { 1648, 29, 624 },
                    { 1646, 29, 622 },
                    { 1656, 30, 624 },
                    { 1658, 30, 626 },
                    { 1659, 30, 627 },
                    { 1660, 30, 628 },
                    { 1661, 30, 629 },
                    { 1662, 30, 630 },
                    { 1663, 30, 631 },
                    { 1657, 30, 625 },
                    { 1665, 30, 633 },
                    { 1638, 28, 622 },
                    { 1645, 29, 621 },
                    { 1644, 29, 614 },
                    { 1564, 27, 615 },
                    { 1631, 28, 615 },
                    { 1565, 27, 616 },
                    { 1632, 28, 616 },
                    { 1566, 27, 617 },
                    { 1653, 30, 621 },
                    { 1633, 28, 617 },
                    { 1634, 28, 618 },
                    { 1568, 27, 619 },
                    { 1635, 28, 619 },
                    { 1569, 27, 620 },
                    { 1636, 28, 620 },
                    { 1637, 28, 621 },
                    { 1567, 27, 618 },
                    { 996, 18, 320 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 735, 14, 370 },
                    { 685, 14, 320 },
                    { 361, 9, 143 },
                    { 410, 11, 142 },
                    { 394, 10, 142 },
                    { 360, 9, 142 },
                    { 409, 11, 141 },
                    { 393, 10, 141 },
                    { 359, 9, 141 },
                    { 392, 10, 140 },
                    { 358, 9, 140 },
                    { 391, 10, 139 },
                    { 357, 9, 139 },
                    { 390, 10, 138 },
                    { 356, 9, 138 },
                    { 389, 10, 137 },
                    { 355, 9, 137 },
                    { 388, 10, 136 },
                    { 354, 9, 136 },
                    { 347, 9, 129 },
                    { 381, 10, 129 },
                    { 348, 9, 130 },
                    { 382, 10, 130 },
                    { 349, 9, 131 },
                    { 383, 10, 131 },
                    { 395, 10, 143 },
                    { 350, 9, 132 },
                    { 351, 9, 133 },
                    { 385, 10, 133 },
                    { 352, 9, 134 },
                    { 386, 10, 134 },
                    { 353, 9, 135 },
                    { 387, 10, 135 },
                    { 384, 10, 132 },
                    { 380, 10, 128 },
                    { 411, 11, 143 },
                    { 396, 10, 144 },
                    { 422, 11, 154 },
                    { 814, 16, 320 },
                    { 372, 9, 154 },
                    { 421, 11, 153 },
                    { 405, 10, 153 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 371, 9, 153 },
                    { 420, 11, 152 },
                    { 404, 10, 152 },
                    { 370, 9, 152 },
                    { 419, 11, 151 },
                    { 403, 10, 151 },
                    { 369, 9, 151 },
                    { 418, 11, 150 },
                    { 402, 10, 150 },
                    { 368, 9, 150 },
                    { 417, 11, 149 },
                    { 401, 10, 149 },
                    { 412, 11, 144 },
                    { 363, 9, 145 },
                    { 397, 10, 145 },
                    { 413, 11, 145 },
                    { 364, 9, 146 },
                    { 398, 10, 146 },
                    { 362, 9, 144 },
                    { 414, 11, 146 },
                    { 399, 10, 147 },
                    { 415, 11, 147 },
                    { 366, 9, 148 },
                    { 400, 10, 148 },
                    { 416, 11, 148 },
                    { 367, 9, 149 },
                    { 365, 9, 147 },
                    { 373, 9, 155 },
                    { 346, 9, 128 },
                    { 345, 9, 127 },
                    { 278, 5, 111 },
                    { 324, 8, 110 },
                    { 277, 5, 110 },
                    { 323, 8, 109 },
                    { 276, 5, 109 },
                    { 322, 8, 108 },
                    { 275, 5, 108 },
                    { 321, 8, 107 },
                    { 274, 5, 107 },
                    { 320, 8, 106 },
                    { 273, 5, 106 },
                    { 319, 8, 105 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 272, 5, 105 },
                    { 318, 8, 104 },
                    { 271, 5, 104 },
                    { 317, 8, 103 },
                    { 270, 5, 103 },
                    { 300, 6, 98 },
                    { 312, 7, 98 },
                    { 266, 5, 99 },
                    { 301, 6, 99 },
                    { 313, 7, 99 },
                    { 267, 5, 100 },
                    { 325, 8, 111 },
                    { 302, 6, 100 },
                    { 268, 5, 101 },
                    { 303, 6, 101 },
                    { 315, 7, 101 },
                    { 269, 5, 102 },
                    { 304, 6, 102 },
                    { 316, 7, 102 },
                    { 314, 7, 100 },
                    { 379, 10, 127 },
                    { 279, 5, 112 },
                    { 280, 5, 113 },
                    { 378, 10, 126 },
                    { 344, 9, 126 },
                    { 340, 8, 126 },
                    { 377, 10, 125 },
                    { 343, 9, 125 },
                    { 339, 8, 125 },
                    { 376, 10, 124 },
                    { 342, 9, 124 },
                    { 338, 8, 124 },
                    { 375, 10, 123 },
                    { 341, 9, 123 },
                    { 337, 8, 123 },
                    { 336, 8, 122 },
                    { 289, 5, 122 },
                    { 335, 8, 121 },
                    { 288, 5, 121 },
                    { 334, 8, 120 },
                    { 327, 8, 113 },
                    { 281, 5, 114 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 328, 8, 114 },
                    { 282, 5, 115 },
                    { 329, 8, 115 },
                    { 283, 5, 116 },
                    { 326, 8, 112 },
                    { 330, 8, 116 },
                    { 331, 8, 117 },
                    { 285, 5, 118 },
                    { 332, 8, 118 },
                    { 286, 5, 119 },
                    { 333, 8, 119 },
                    { 287, 5, 120 },
                    { 284, 5, 117 },
                    { 265, 5, 98 },
                    { 407, 10, 155 },
                    { 374, 9, 156 },
                    { 474, 11, 206 },
                    { 570, 13, 205 },
                    { 473, 11, 205 },
                    { 569, 13, 204 },
                    { 472, 11, 204 },
                    { 568, 12, 203 },
                    { 471, 11, 203 },
                    { 567, 12, 202 },
                    { 470, 11, 202 },
                    { 566, 12, 201 },
                    { 469, 11, 201 },
                    { 565, 12, 200 },
                    { 468, 11, 200 },
                    { 564, 12, 199 },
                    { 467, 11, 199 },
                    { 563, 12, 198 },
                    { 466, 11, 198 },
                    { 459, 11, 191 },
                    { 556, 12, 191 },
                    { 460, 11, 192 },
                    { 557, 12, 192 },
                    { 461, 11, 193 },
                    { 558, 12, 193 },
                    { 571, 13, 206 },
                    { 462, 11, 194 },
                    { 463, 11, 195 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 560, 12, 195 },
                    { 464, 11, 196 },
                    { 561, 12, 196 },
                    { 465, 11, 197 },
                    { 562, 12, 197 },
                    { 559, 12, 194 },
                    { 555, 12, 190 },
                    { 475, 11, 207 },
                    { 476, 11, 208 },
                    { 588, 13, 223 },
                    { 491, 11, 223 },
                    { 587, 13, 222 },
                    { 490, 11, 222 },
                    { 586, 13, 221 },
                    { 489, 11, 221 },
                    { 585, 13, 220 },
                    { 488, 11, 220 },
                    { 584, 13, 219 },
                    { 487, 11, 219 },
                    { 583, 13, 218 },
                    { 486, 11, 218 },
                    { 582, 13, 217 },
                    { 485, 11, 217 },
                    { 581, 13, 216 },
                    { 484, 11, 216 },
                    { 580, 13, 215 },
                    { 573, 13, 208 },
                    { 477, 11, 209 },
                    { 574, 13, 209 },
                    { 478, 11, 210 },
                    { 575, 13, 210 },
                    { 479, 11, 211 },
                    { 572, 13, 207 },
                    { 576, 13, 211 },
                    { 577, 13, 212 },
                    { 481, 11, 213 },
                    { 578, 13, 213 },
                    { 482, 11, 214 },
                    { 579, 13, 214 },
                    { 483, 11, 215 },
                    { 480, 11, 212 },
                    { 423, 11, 155 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 458, 11, 190 },
                    { 457, 11, 189 },
                    { 439, 11, 171 },
                    { 535, 12, 170 },
                    { 438, 11, 170 },
                    { 534, 12, 169 },
                    { 437, 11, 169 },
                    { 533, 12, 168 },
                    { 436, 11, 168 },
                    { 532, 12, 167 },
                    { 435, 11, 167 },
                    { 531, 12, 166 },
                    { 434, 11, 166 },
                    { 530, 12, 165 },
                    { 433, 11, 165 },
                    { 529, 12, 164 },
                    { 432, 11, 164 },
                    { 528, 12, 163 },
                    { 431, 11, 163 },
                    { 408, 10, 156 },
                    { 424, 11, 156 },
                    { 425, 11, 157 },
                    { 522, 12, 157 },
                    { 426, 11, 158 },
                    { 523, 12, 158 },
                    { 536, 12, 171 },
                    { 427, 11, 159 },
                    { 428, 11, 160 },
                    { 525, 12, 160 },
                    { 429, 11, 161 },
                    { 526, 12, 161 },
                    { 430, 11, 162 },
                    { 527, 12, 162 },
                    { 524, 12, 159 },
                    { 554, 12, 189 },
                    { 440, 11, 172 },
                    { 441, 11, 173 },
                    { 553, 12, 188 },
                    { 456, 11, 188 },
                    { 552, 12, 187 },
                    { 455, 11, 187 },
                    { 551, 12, 186 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 454, 11, 186 },
                    { 550, 12, 185 },
                    { 453, 11, 185 },
                    { 549, 12, 184 },
                    { 452, 11, 184 },
                    { 548, 12, 183 },
                    { 451, 11, 183 },
                    { 547, 12, 182 },
                    { 450, 11, 182 },
                    { 546, 12, 181 },
                    { 449, 11, 181 },
                    { 545, 12, 180 },
                    { 538, 12, 173 },
                    { 442, 11, 174 },
                    { 539, 12, 174 },
                    { 443, 11, 175 },
                    { 540, 12, 175 },
                    { 444, 11, 176 },
                    { 537, 12, 172 },
                    { 541, 12, 176 },
                    { 542, 12, 177 },
                    { 446, 11, 178 },
                    { 543, 12, 178 },
                    { 447, 11, 179 },
                    { 544, 12, 179 },
                    { 448, 11, 180 },
                    { 445, 11, 177 },
                    { 311, 7, 97 },
                    { 299, 6, 97 },
                    { 264, 5, 97 },
                    { 162, 3, 34 },
                    { 85, 2, 34 },
                    { 34, 1, 34 },
                    { 161, 3, 33 },
                    { 84, 2, 33 },
                    { 33, 1, 33 },
                    { 160, 3, 32 },
                    { 83, 2, 32 },
                    { 32, 1, 32 },
                    { 159, 3, 31 },
                    { 82, 2, 31 },
                    { 31, 1, 31 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 158, 3, 30 },
                    { 81, 2, 30 },
                    { 30, 1, 30 },
                    { 157, 3, 29 },
                    { 80, 2, 29 },
                    { 152, 3, 24 },
                    { 25, 1, 25 },
                    { 76, 2, 25 },
                    { 153, 3, 25 },
                    { 26, 1, 26 },
                    { 77, 2, 26 },
                    { 35, 1, 35 },
                    { 154, 3, 26 },
                    { 78, 2, 27 },
                    { 155, 3, 27 },
                    { 28, 1, 28 },
                    { 79, 2, 28 },
                    { 156, 3, 28 },
                    { 29, 1, 29 },
                    { 27, 1, 27 },
                    { 75, 2, 24 },
                    { 86, 2, 35 },
                    { 36, 1, 36 },
                    { 97, 2, 46 },
                    { 46, 1, 46 },
                    { 173, 3, 45 },
                    { 96, 2, 45 },
                    { 45, 1, 45 },
                    { 172, 3, 44 },
                    { 95, 2, 44 },
                    { 44, 1, 44 },
                    { 171, 3, 43 },
                    { 94, 2, 43 },
                    { 43, 1, 43 },
                    { 170, 3, 42 },
                    { 93, 2, 42 },
                    { 42, 1, 42 },
                    { 169, 3, 41 },
                    { 92, 2, 41 },
                    { 41, 1, 41 },
                    { 87, 2, 36 },
                    { 164, 3, 36 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 37, 1, 37 },
                    { 88, 2, 37 },
                    { 165, 3, 37 },
                    { 38, 1, 38 },
                    { 163, 3, 35 },
                    { 89, 2, 38 },
                    { 39, 1, 39 },
                    { 90, 2, 39 },
                    { 167, 3, 39 },
                    { 40, 1, 40 },
                    { 91, 2, 40 },
                    { 168, 3, 40 },
                    { 166, 3, 38 },
                    { 174, 3, 46 },
                    { 24, 1, 24 },
                    { 74, 2, 23 },
                    { 62, 2, 11 },
                    { 11, 1, 11 },
                    { 138, 3, 10 },
                    { 61, 2, 10 },
                    { 10, 1, 10 },
                    { 137, 3, 9 },
                    { 60, 2, 9 },
                    { 9, 1, 9 },
                    { 136, 3, 8 },
                    { 59, 2, 8 },
                    { 8, 1, 8 },
                    { 135, 3, 7 },
                    { 58, 2, 7 },
                    { 7, 1, 7 },
                    { 134, 3, 6 },
                    { 57, 2, 6 },
                    { 6, 1, 6 },
                    { 52, 2, 1 },
                    { 129, 3, 1 },
                    { 2, 1, 2 },
                    { 53, 2, 2 },
                    { 130, 3, 2 },
                    { 3, 1, 3 },
                    { 139, 3, 11 },
                    { 54, 2, 3 },
                    { 4, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 55, 2, 4 },
                    { 132, 3, 4 },
                    { 5, 1, 5 },
                    { 56, 2, 5 },
                    { 133, 3, 5 },
                    { 131, 3, 3 },
                    { 151, 3, 23 },
                    { 12, 1, 12 },
                    { 140, 3, 12 },
                    { 23, 1, 23 },
                    { 150, 3, 22 },
                    { 73, 2, 22 },
                    { 22, 1, 22 },
                    { 149, 3, 21 },
                    { 72, 2, 21 },
                    { 21, 1, 21 },
                    { 148, 3, 20 },
                    { 71, 2, 20 },
                    { 20, 1, 20 },
                    { 147, 3, 19 },
                    { 70, 2, 19 },
                    { 19, 1, 19 },
                    { 146, 3, 18 },
                    { 69, 2, 18 },
                    { 18, 1, 18 },
                    { 145, 3, 17 },
                    { 13, 1, 13 },
                    { 64, 2, 13 },
                    { 141, 3, 13 },
                    { 14, 1, 14 },
                    { 65, 2, 14 },
                    { 142, 3, 14 },
                    { 63, 2, 12 },
                    { 15, 1, 15 },
                    { 143, 3, 15 },
                    { 16, 1, 16 },
                    { 67, 2, 16 },
                    { 144, 3, 16 },
                    { 17, 1, 17 },
                    { 68, 2, 17 },
                    { 66, 2, 15 },
                    { 47, 1, 47 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 98, 2, 47 },
                    { 175, 3, 47 },
                    { 250, 5, 83 },
                    { 237, 4, 83 },
                    { 249, 5, 82 },
                    { 236, 4, 82 },
                    { 248, 5, 81 },
                    { 235, 4, 81 },
                    { 247, 5, 80 },
                    { 234, 4, 80 },
                    { 246, 5, 79 },
                    { 233, 4, 79 },
                    { 245, 5, 78 },
                    { 232, 4, 78 },
                    { 231, 4, 77 },
                    { 205, 3, 77 },
                    { 128, 2, 77 },
                    { 230, 4, 76 },
                    { 204, 3, 76 },
                    { 225, 4, 71 },
                    { 123, 2, 72 },
                    { 200, 3, 72 },
                    { 226, 4, 72 },
                    { 124, 2, 73 },
                    { 201, 3, 73 },
                    { 238, 4, 84 },
                    { 227, 4, 73 },
                    { 202, 3, 74 },
                    { 228, 4, 74 },
                    { 126, 2, 75 },
                    { 203, 3, 75 },
                    { 229, 4, 75 },
                    { 127, 2, 76 },
                    { 125, 2, 74 },
                    { 199, 3, 71 },
                    { 251, 5, 84 },
                    { 252, 5, 85 },
                    { 310, 7, 96 },
                    { 298, 6, 96 },
                    { 263, 5, 96 },
                    { 309, 7, 95 },
                    { 297, 6, 95 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 262, 5, 95 },
                    { 308, 7, 94 },
                    { 296, 6, 94 },
                    { 261, 5, 94 },
                    { 307, 7, 93 },
                    { 295, 6, 93 },
                    { 260, 5, 93 },
                    { 306, 7, 92 },
                    { 294, 6, 92 },
                    { 259, 5, 92 },
                    { 305, 7, 91 },
                    { 293, 6, 91 },
                    { 240, 4, 86 },
                    { 253, 5, 86 },
                    { 241, 4, 87 },
                    { 254, 5, 87 },
                    { 242, 4, 88 },
                    { 255, 5, 88 },
                    { 239, 4, 85 },
                    { 290, 6, 88 },
                    { 256, 5, 89 },
                    { 291, 6, 89 },
                    { 244, 4, 90 },
                    { 257, 5, 90 },
                    { 292, 6, 90 },
                    { 258, 5, 91 },
                    { 243, 4, 89 },
                    { 122, 2, 71 },
                    { 224, 4, 70 },
                    { 198, 3, 70 },
                    { 109, 2, 58 },
                    { 211, 4, 57 },
                    { 185, 3, 57 },
                    { 108, 2, 57 },
                    { 210, 4, 56 },
                    { 184, 3, 56 },
                    { 107, 2, 56 },
                    { 209, 4, 55 },
                    { 183, 3, 55 },
                    { 106, 2, 55 },
                    { 208, 4, 54 },
                    { 182, 3, 54 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 105, 2, 54 },
                    { 207, 4, 53 },
                    { 181, 3, 53 },
                    { 104, 2, 53 },
                    { 206, 4, 52 },
                    { 48, 1, 48 },
                    { 99, 2, 48 },
                    { 176, 3, 48 },
                    { 49, 1, 49 },
                    { 100, 2, 49 },
                    { 177, 3, 49 },
                    { 186, 3, 58 },
                    { 50, 1, 50 },
                    { 178, 3, 50 },
                    { 51, 1, 51 },
                    { 102, 2, 51 },
                    { 179, 3, 51 },
                    { 103, 2, 52 },
                    { 180, 3, 52 },
                    { 101, 2, 50 },
                    { 212, 4, 58 },
                    { 110, 2, 59 },
                    { 187, 3, 59 },
                    { 219, 4, 65 },
                    { 117, 2, 66 },
                    { 194, 3, 66 },
                    { 220, 4, 66 },
                    { 118, 2, 67 },
                    { 195, 3, 67 },
                    { 193, 3, 65 },
                    { 221, 4, 67 },
                    { 196, 3, 68 },
                    { 222, 4, 68 },
                    { 120, 2, 69 },
                    { 197, 3, 69 },
                    { 223, 4, 69 },
                    { 121, 2, 70 },
                    { 119, 2, 68 },
                    { 492, 11, 224 },
                    { 116, 2, 65 },
                    { 192, 3, 64 },
                    { 213, 4, 59 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 111, 2, 60 },
                    { 188, 3, 60 },
                    { 214, 4, 60 },
                    { 112, 2, 61 },
                    { 189, 3, 61 },
                    { 218, 4, 64 },
                    { 215, 4, 61 },
                    { 190, 3, 62 },
                    { 216, 4, 62 },
                    { 114, 2, 63 },
                    { 191, 3, 63 },
                    { 217, 4, 63 },
                    { 115, 2, 64 },
                    { 113, 2, 62 },
                    { 589, 13, 224 },
                    { 406, 10, 154 },
                    { 493, 11, 225 },
                    { 797, 16, 303 },
                    { 966, 18, 290 },
                    { 753, 15, 259 },
                    { 624, 14, 259 },
                    { 979, 18, 303 },
                    { 1062, 19, 258 },
                    { 934, 18, 258 },
                    { 752, 15, 258 },
                    { 641, 14, 276 },
                    { 623, 14, 258 },
                    { 1107, 19, 303 },
                    { 1061, 19, 257 },
                    { 933, 18, 257 },
                    { 751, 15, 257 },
                    { 952, 18, 276 },
                    { 622, 14, 257 },
                    { 784, 16, 290 },
                    { 1080, 19, 276 },
                    { 770, 15, 276 },
                    { 1094, 19, 290 },
                    { 668, 14, 303 },
                    { 1079, 19, 275 },
                    { 937, 18, 261 },
                    { 640, 14, 275 },
                    { 755, 15, 261 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 626, 14, 261 },
                    { 796, 16, 302 },
                    { 1064, 19, 260 },
                    { 936, 18, 260 },
                    { 754, 15, 260 },
                    { 978, 18, 302 },
                    { 1095, 19, 291 },
                    { 625, 14, 260 },
                    { 967, 18, 291 },
                    { 1063, 19, 259 },
                    { 1106, 19, 302 },
                    { 785, 16, 291 },
                    { 935, 18, 259 },
                    { 769, 15, 275 },
                    { 656, 14, 291 },
                    { 951, 18, 275 },
                    { 1060, 19, 256 },
                    { 642, 14, 277 },
                    { 771, 15, 277 },
                    { 932, 18, 256 },
                    { 644, 14, 279 },
                    { 521, 11, 253 },
                    { 670, 14, 305 },
                    { 773, 16, 279 },
                    { 661, 14, 296 },
                    { 617, 13, 252 },
                    { 520, 11, 252 },
                    { 955, 18, 279 },
                    { 1093, 19, 289 },
                    { 965, 18, 289 },
                    { 616, 13, 251 },
                    { 981, 18, 305 },
                    { 519, 11, 251 },
                    { 1083, 19, 279 },
                    { 1109, 19, 305 },
                    { 783, 16, 289 },
                    { 615, 13, 250 },
                    { 518, 11, 250 },
                    { 654, 14, 289 },
                    { 618, 13, 253 },
                    { 1065, 19, 261 },
                    { 747, 15, 253 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 655, 14, 290 },
                    { 953, 18, 277 },
                    { 750, 15, 256 },
                    { 1081, 19, 277 },
                    { 621, 14, 256 },
                    { 643, 14, 278 },
                    { 669, 14, 304 },
                    { 798, 16, 304 },
                    { 1059, 19, 255 },
                    { 931, 18, 255 },
                    { 749, 15, 255 },
                    { 620, 14, 255 },
                    { 772, 15, 278 },
                    { 980, 18, 304 },
                    { 1058, 19, 254 },
                    { 954, 18, 278 },
                    { 930, 18, 254 },
                    { 748, 15, 254 },
                    { 619, 14, 254 },
                    { 1082, 19, 278 },
                    { 1108, 19, 304 },
                    { 667, 14, 302 },
                    { 657, 14, 292 },
                    { 627, 14, 262 },
                    { 944, 18, 268 },
                    { 789, 16, 295 },
                    { 1076, 19, 272 },
                    { 660, 14, 295 },
                    { 762, 15, 268 },
                    { 633, 14, 268 },
                    { 1101, 19, 297 },
                    { 1098, 19, 294 },
                    { 1071, 19, 267 },
                    { 943, 18, 267 },
                    { 663, 14, 298 },
                    { 970, 18, 294 },
                    { 792, 16, 298 },
                    { 788, 16, 294 },
                    { 974, 18, 298 },
                    { 761, 15, 267 },
                    { 632, 14, 267 },
                    { 638, 14, 273 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 659, 14, 294 },
                    { 973, 18, 297 },
                    { 1070, 19, 266 },
                    { 1072, 19, 268 },
                    { 634, 14, 269 },
                    { 790, 16, 296 },
                    { 765, 15, 271 },
                    { 1074, 19, 270 },
                    { 972, 18, 296 },
                    { 946, 18, 270 },
                    { 947, 18, 271 },
                    { 1100, 19, 296 },
                    { 764, 15, 270 },
                    { 1075, 19, 271 },
                    { 635, 14, 270 },
                    { 637, 14, 272 },
                    { 662, 14, 297 },
                    { 1073, 19, 269 },
                    { 945, 18, 269 },
                    { 791, 16, 297 },
                    { 766, 15, 272 },
                    { 1099, 19, 295 },
                    { 763, 15, 269 },
                    { 971, 18, 295 },
                    { 948, 18, 272 },
                    { 671, 14, 306 },
                    { 942, 18, 266 },
                    { 767, 15, 273 },
                    { 629, 14, 264 },
                    { 768, 15, 274 },
                    { 666, 14, 301 },
                    { 658, 14, 293 },
                    { 1067, 19, 263 },
                    { 939, 18, 263 },
                    { 795, 16, 301 },
                    { 757, 15, 263 },
                    { 1096, 19, 292 },
                    { 628, 14, 263 },
                    { 977, 18, 301 },
                    { 968, 18, 292 },
                    { 1066, 19, 262 },
                    { 950, 18, 274 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1105, 19, 301 },
                    { 938, 18, 262 },
                    { 786, 16, 292 },
                    { 756, 15, 262 },
                    { 1078, 19, 274 },
                    { 787, 16, 293 },
                    { 1102, 19, 298 },
                    { 758, 15, 264 },
                    { 969, 18, 293 },
                    { 760, 15, 266 },
                    { 631, 14, 266 },
                    { 664, 14, 299 },
                    { 949, 18, 273 },
                    { 793, 16, 299 },
                    { 1069, 19, 265 },
                    { 975, 18, 299 },
                    { 1103, 19, 299 },
                    { 941, 18, 265 },
                    { 759, 15, 265 },
                    { 630, 14, 265 },
                    { 665, 14, 300 },
                    { 1077, 19, 273 },
                    { 1068, 19, 264 },
                    { 794, 16, 300 },
                    { 976, 18, 300 },
                    { 1097, 19, 293 },
                    { 1104, 19, 300 },
                    { 639, 14, 274 },
                    { 940, 18, 264 },
                    { 800, 16, 306 },
                    { 799, 16, 305 },
                    { 636, 14, 271 },
                    { 959, 18, 283 },
                    { 1087, 19, 283 },
                    { 678, 14, 313 },
                    { 609, 13, 244 },
                    { 512, 11, 244 },
                    { 807, 16, 313 },
                    { 608, 13, 243 },
                    { 511, 11, 243 },
                    { 1120, 19, 316 },
                    { 989, 18, 313 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1117, 19, 313 },
                    { 607, 13, 242 },
                    { 510, 11, 242 },
                    { 645, 14, 280 },
                    { 500, 11, 232 },
                    { 1116, 19, 312 },
                    { 649, 14, 284 },
                    { 596, 13, 231 },
                    { 806, 16, 312 },
                    { 986, 18, 310 },
                    { 1114, 19, 310 },
                    { 498, 11, 230 },
                    { 595, 13, 230 },
                    { 676, 14, 311 },
                    { 598, 13, 233 },
                    { 987, 18, 311 },
                    { 610, 13, 245 },
                    { 648, 14, 283 },
                    { 513, 11, 245 },
                    { 1115, 19, 311 },
                    { 682, 14, 317 },
                    { 499, 11, 231 },
                    { 677, 14, 312 },
                    { 777, 16, 283 },
                    { 988, 18, 312 },
                    { 597, 13, 232 },
                    { 778, 16, 284 },
                    { 779, 16, 285 },
                    { 504, 11, 236 },
                    { 600, 13, 235 },
                    { 503, 11, 235 },
                    { 681, 14, 316 },
                    { 650, 14, 285 },
                    { 599, 13, 234 },
                    { 680, 14, 315 },
                    { 1088, 19, 284 },
                    { 809, 16, 315 },
                    { 502, 11, 234 },
                    { 501, 11, 233 },
                    { 991, 18, 315 },
                    { 780, 16, 286 },
                    { 651, 14, 286 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1119, 19, 315 },
                    { 601, 13, 236 },
                    { 960, 18, 284 },
                    { 505, 11, 237 },
                    { 602, 13, 237 },
                    { 606, 13, 241 },
                    { 509, 11, 241 },
                    { 679, 14, 314 },
                    { 808, 16, 314 },
                    { 605, 13, 240 },
                    { 508, 11, 240 },
                    { 990, 18, 314 },
                    { 804, 16, 310 },
                    { 992, 18, 316 },
                    { 507, 11, 239 },
                    { 810, 16, 316 },
                    { 1090, 19, 286 },
                    { 603, 13, 238 },
                    { 506, 11, 238 },
                    { 962, 18, 286 },
                    { 1118, 19, 314 },
                    { 604, 13, 239 },
                    { 675, 14, 310 },
                    { 805, 16, 311 },
                    { 652, 14, 287 },
                    { 813, 16, 319 },
                    { 1111, 19, 307 },
                    { 775, 16, 281 },
                    { 957, 18, 281 },
                    { 495, 11, 227 },
                    { 1085, 19, 281 },
                    { 684, 14, 319 },
                    { 592, 13, 227 },
                    { 782, 16, 288 },
                    { 673, 14, 308 },
                    { 811, 16, 317 },
                    { 1122, 19, 318 },
                    { 961, 18, 285 },
                    { 984, 18, 308 },
                    { 647, 14, 282 },
                    { 983, 18, 307 },
                    { 653, 14, 288 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 646, 14, 281 },
                    { 964, 18, 288 },
                    { 1123, 19, 319 },
                    { 590, 13, 225 },
                    { 982, 18, 306 },
                    { 995, 18, 319 },
                    { 1110, 19, 306 },
                    { 774, 16, 280 },
                    { 956, 18, 280 },
                    { 494, 11, 226 },
                    { 614, 13, 249 },
                    { 1084, 19, 280 },
                    { 591, 13, 226 },
                    { 672, 14, 307 },
                    { 801, 16, 307 },
                    { 1092, 19, 288 },
                    { 517, 11, 249 },
                    { 1089, 19, 285 },
                    { 613, 13, 248 },
                    { 802, 16, 308 },
                    { 1113, 19, 309 },
                    { 1086, 19, 282 },
                    { 497, 11, 229 },
                    { 803, 16, 309 },
                    { 1121, 19, 317 },
                    { 674, 14, 309 },
                    { 963, 18, 287 },
                    { 683, 14, 318 },
                    { 812, 16, 318 },
                    { 985, 18, 309 },
                    { 516, 11, 248 },
                    { 1091, 19, 287 },
                    { 958, 18, 282 },
                    { 515, 11, 247 },
                    { 781, 16, 287 },
                    { 593, 13, 228 },
                    { 993, 18, 317 },
                    { 496, 11, 228 },
                    { 1112, 19, 308 },
                    { 594, 13, 229 },
                    { 776, 16, 282 },
                    { 611, 13, 246 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 514, 11, 246 },
                    { 994, 18, 318 },
                    { 612, 13, 247 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 89, 1, 775 },
                    { 56, 1, 366 },
                    { 15, 1, 73 },
                    { 506, 30, 779 },
                    { 632, 50, 734 },
                    { 627, 46, 774 },
                    { 562, 37, 774 },
                    { 418, 24, 285 },
                    { 628, 47, 774 },
                    { 13, 1, 51 },
                    { 186, 21, 285 },
                    { 569, 39, 777 },
                    { 570, 39, 778 },
                    { 527, 33, 775 },
                    { 564, 37, 730 },
                    { 505, 30, 778 },
                    { 631, 49, 733 },
                    { 254, 22, 285 },
                    { 83, 1, 734 },
                    { 635, 51, 733 },
                    { 559, 36, 732 },
                    { 14, 1, 72 },
                    { 263, 22, 294 },
                    { 264, 22, 295 },
                    { 713, 97, 777 },
                    { 262, 22, 293 },
                    { 714, 97, 778 },
                    { 84, 1, 735 },
                    { 260, 22, 291 },
                    { 561, 36, 774 },
                    { 381, 23, 749 },
                    { 126, 1, 764 },
                    { 90, 1, 68 },
                    { 114, 1, 287 },
                    { 188, 21, 287 },
                    { 367, 23, 358 },
                    { 256, 22, 287 },
                    { 666, 67, 752 },
                    { 663, 64, 763 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 420, 24, 287 },
                    { 626, 46, 763 },
                    { 667, 67, 753 },
                    { 387, 23, 762 },
                    { 345, 22, 762 },
                    { 386, 23, 761 },
                    { 711, 96, 754 },
                    { 344, 22, 761 },
                    { 258, 22, 289 },
                    { 514, 31, 760 },
                    { 125, 1, 760 },
                    { 86, 1, 758 },
                    { 85, 1, 756 },
                    { 368, 23, 359 },
                    { 457, 26, 757 },
                    { 456, 26, 756 },
                    { 421, 24, 288 },
                    { 257, 22, 288 },
                    { 189, 21, 288 },
                    { 115, 1, 288 },
                    { 664, 65, 764 },
                    { 633, 50, 735 },
                    { 665, 66, 764 },
                    { 513, 31, 747 },
                    { 526, 33, 774 },
                    { 436, 25, 774 },
                    { 388, 23, 774 },
                    { 93, 1, 71 },
                    { 173, 21, 774 },
                    { 124, 1, 738 },
                    { 88, 1, 774 },
                    { 203, 21, 738 },
                    { 515, 31, 738 },
                    { 261, 22, 292 },
                    { 565, 38, 740 },
                    { 435, 25, 771 },
                    { 113, 1, 286 },
                    { 434, 25, 770 },
                    { 341, 22, 741 },
                    { 92, 1, 70 },
                    { 662, 63, 769 },
                    { 342, 22, 742 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 365, 23, 356 },
                    { 187, 21, 286 },
                    { 255, 22, 286 },
                    { 343, 22, 743 },
                    { 567, 38, 767 },
                    { 259, 22, 290 },
                    { 419, 24, 286 },
                    { 566, 38, 766 },
                    { 576, 41, 69 },
                    { 91, 1, 69 },
                    { 87, 1, 765 },
                    { 380, 23, 748 },
                    { 560, 36, 756 },
                    { 710, 95, 802 },
                    { 715, 97, 779 },
                    { 244, 17, 838 },
                    { 192, 21, 336 },
                    { 49, 1, 307 },
                    { 242, 15, 839 },
                    { 355, 22, 839 },
                    { 637, 52, 840 },
                    { 191, 21, 335 },
                    { 241, 15, 841 },
                    { 356, 22, 841 },
                    { 245, 18, 837 },
                    { 402, 24, 308 },
                    { 246, 19, 842 },
                    { 247, 20, 842 },
                    { 357, 22, 842 },
                    { 219, 10, 843 },
                    { 239, 15, 843 },
                    { 358, 22, 843 },
                    { 190, 21, 334 },
                    { 238, 15, 844 },
                    { 359, 22, 844 },
                    { 240, 15, 842 },
                    { 222, 13, 837 },
                    { 221, 12, 837 },
                    { 682, 75, 836 },
                    { 217, 8, 827 },
                    { 286, 22, 339 },
                    { 693, 83, 828 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 694, 84, 828 },
                    { 117, 1, 339 },
                    { 689, 79, 829 },
                    { 686, 78, 830 },
                    { 243, 16, 831 },
                    { 47, 1, 305 },
                    { 214, 7, 832 },
                    { 220, 11, 832 },
                    { 223, 14, 832 },
                    { 510, 30, 832 },
                    { 285, 22, 338 },
                    { 215, 7, 833 },
                    { 116, 1, 338 },
                    { 684, 77, 834 },
                    { 683, 76, 835 },
                    { 48, 1, 306 },
                    { 193, 21, 337 },
                    { 213, 6, 836 },
                    { 403, 24, 309 },
                    { 216, 8, 826 },
                    { 237, 15, 845 },
                    { 685, 77, 845 },
                    { 233, 15, 858 },
                    { 361, 22, 858 },
                    { 276, 22, 315 },
                    { 4, 1, 8 },
                    { 234, 15, 859 },
                    { 362, 22, 859 },
                    { 280, 22, 325 },
                    { 647, 54, 315 },
                    { 3, 1, 7 },
                    { 5, 1, 9 },
                    { 279, 22, 324 },
                    { 277, 22, 316 },
                    { 648, 54, 316 },
                    { 1, 1, 5 },
                    { 278, 22, 317 },
                    { 649, 54, 317 },
                    { 235, 15, 866 },
                    { 363, 22, 866 },
                    { 236, 15, 867 },
                    { 364, 22, 867 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 2, 1, 6 },
                    { 281, 22, 326 },
                    { 6, 1, 10 },
                    { 211, 5, 856 },
                    { 404, 24, 310 },
                    { 210, 5, 847 },
                    { 212, 5, 848 },
                    { 405, 24, 311 },
                    { 209, 4, 849 },
                    { 679, 72, 850 },
                    { 273, 22, 312 },
                    { 644, 54, 312 },
                    { 677, 71, 851 },
                    { 284, 22, 329 },
                    { 680, 73, 852 },
                    { 274, 22, 313 },
                    { 283, 22, 328 },
                    { 208, 3, 853 },
                    { 645, 54, 313 },
                    { 676, 70, 854 },
                    { 282, 22, 327 },
                    { 7, 1, 11 },
                    { 207, 2, 855 },
                    { 275, 22, 314 },
                    { 646, 54, 314 },
                    { 360, 22, 845 },
                    { 692, 82, 825 },
                    { 46, 1, 304 },
                    { 691, 81, 824 },
                    { 205, 21, 788 },
                    { 543, 34, 788 },
                    { 8, 1, 46 },
                    { 267, 22, 298 },
                    { 572, 39, 789 },
                    { 720, 97, 789 },
                    { 53, 1, 347 },
                    { 127, 1, 791 },
                    { 660, 61, 792 },
                    { 658, 59, 787 },
                    { 52, 1, 346 },
                    { 268, 22, 299 },
                    { 643, 53, 794 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 654, 55, 794 },
                    { 51, 1, 345 },
                    { 568, 38, 795 },
                    { 472, 28, 796 },
                    { 655, 56, 796 },
                    { 269, 22, 300 },
                    { 485, 28, 797 },
                    { 573, 40, 793 },
                    { 54, 1, 348 },
                    { 656, 57, 786 },
                    { 9, 1, 47 },
                    { 507, 30, 780 },
                    { 716, 97, 780 },
                    { 12, 1, 50 },
                    { 508, 30, 781 },
                    { 717, 97, 781 },
                    { 265, 22, 296 },
                    { 509, 30, 782 },
                    { 718, 97, 782 },
                    { 11, 1, 49 },
                    { 204, 21, 783 },
                    { 389, 23, 783 },
                    { 437, 25, 783 },
                    { 657, 58, 783 },
                    { 681, 74, 783 },
                    { 719, 97, 783 },
                    { 55, 1, 349 },
                    { 10, 1, 48 },
                    { 571, 39, 784 },
                    { 661, 62, 784 },
                    { 266, 22, 297 },
                    { 659, 60, 785 },
                    { 687, 79, 798 },
                    { 422, 24, 799 },
                    { 50, 1, 344 },
                    { 708, 93, 800 },
                    { 349, 22, 815 },
                    { 697, 86, 815 },
                    { 288, 22, 341 },
                    { 228, 15, 816 },
                    { 350, 22, 816 },
                    { 119, 1, 341 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 229, 15, 817 },
                    { 351, 22, 817 },
                    { 272, 22, 303 },
                    { 230, 15, 818 },
                    { 352, 22, 818 },
                    { 231, 15, 820 },
                    { 353, 22, 820 },
                    { 695, 85, 820 },
                    { 232, 15, 821 },
                    { 354, 22, 821 },
                    { 696, 85, 821 },
                    { 287, 22, 340 },
                    { 118, 1, 340 },
                    { 690, 80, 823 },
                    { 218, 9, 824 },
                    { 227, 15, 815 },
                    { 516, 32, 779 },
                    { 698, 87, 814 },
                    { 701, 90, 812 },
                    { 709, 94, 801 },
                    { 712, 96, 801 },
                    { 172, 21, 729 },
                    { 270, 22, 301 },
                    { 206, 21, 803 },
                    { 688, 79, 803 },
                    { 290, 22, 343 },
                    { 486, 28, 804 },
                    { 707, 92, 804 },
                    { 121, 1, 343 },
                    { 224, 15, 807 },
                    { 346, 22, 807 },
                    { 225, 15, 808 },
                    { 347, 22, 808 },
                    { 271, 22, 302 },
                    { 289, 22, 342 },
                    { 120, 1, 342 },
                    { 699, 88, 811 },
                    { 700, 89, 811 },
                    { 226, 15, 812 },
                    { 348, 22, 812 },
                    { 706, 91, 813 },
                    { 82, 1, 729 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 77, 1, 677 },
                    { 171, 21, 728 },
                    { 411, 24, 249 },
                    { 529, 34, 170 },
                    { 136, 21, 170 },
                    { 548, 35, 474 },
                    { 371, 23, 474 },
                    { 45, 1, 169 },
                    { 44, 1, 168 },
                    { 106, 1, 250 },
                    { 180, 21, 250 },
                    { 43, 1, 167 },
                    { 179, 21, 249 },
                    { 412, 24, 250 },
                    { 107, 1, 251 },
                    { 41, 1, 165 },
                    { 181, 21, 251 },
                    { 413, 24, 251 },
                    { 40, 1, 164 },
                    { 39, 1, 163 },
                    { 160, 21, 578 },
                    { 462, 27, 578 },
                    { 108, 1, 252 },
                    { 182, 21, 252 },
                    { 42, 1, 166 },
                    { 137, 21, 171 },
                    { 530, 34, 171 },
                    { 372, 23, 475 },
                    { 476, 28, 178 },
                    { 552, 35, 478 },
                    { 375, 23, 478 },
                    { 602, 44, 177 },
                    { 475, 28, 177 },
                    { 104, 1, 248 },
                    { 178, 21, 248 },
                    { 601, 44, 176 },
                    { 474, 28, 176 },
                    { 551, 35, 477 },
                    { 374, 23, 477 },
                    { 600, 44, 175 },
                    { 473, 28, 175 },
                    { 410, 24, 248 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 599, 44, 174 },
                    { 550, 35, 476 },
                    { 373, 23, 476 },
                    { 532, 34, 173 },
                    { 139, 21, 173 },
                    { 105, 1, 249 },
                    { 531, 34, 172 },
                    { 138, 21, 172 },
                    { 549, 35, 475 },
                    { 414, 24, 252 },
                    { 161, 21, 579 },
                    { 463, 27, 579 },
                    { 109, 1, 253 },
                    { 547, 35, 439 },
                    { 294, 22, 439 },
                    { 546, 35, 438 },
                    { 198, 21, 594 },
                    { 487, 29, 594 },
                    { 293, 22, 438 },
                    { 545, 35, 437 },
                    { 292, 22, 437 },
                    { 199, 21, 595 },
                    { 488, 29, 595 },
                    { 544, 35, 436 },
                    { 291, 22, 436 },
                    { 200, 21, 596 },
                    { 489, 29, 596 },
                    { 424, 25, 259 },
                    { 201, 21, 597 },
                    { 490, 29, 597 },
                    { 491, 29, 598 },
                    { 425, 25, 260 },
                    { 492, 29, 599 },
                    { 38, 1, 140 },
                    { 493, 29, 600 },
                    { 37, 1, 139 },
                    { 423, 25, 258 },
                    { 603, 44, 178 },
                    { 584, 42, 257 },
                    { 132, 21, 149 },
                    { 183, 21, 253 },
                    { 162, 21, 580 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 464, 27, 580 },
                    { 415, 24, 253 },
                    { 163, 21, 581 },
                    { 465, 27, 581 },
                    { 521, 33, 254 },
                    { 581, 42, 254 },
                    { 307, 22, 582 },
                    { 308, 22, 583 },
                    { 522, 33, 255 },
                    { 582, 42, 255 },
                    { 309, 22, 584 },
                    { 671, 68, 457 },
                    { 310, 22, 585 },
                    { 670, 68, 456 },
                    { 135, 21, 152 },
                    { 669, 68, 455 },
                    { 668, 68, 454 },
                    { 134, 21, 151 },
                    { 523, 33, 256 },
                    { 583, 42, 256 },
                    { 133, 21, 150 },
                    { 524, 33, 257 },
                    { 426, 25, 261 },
                    { 477, 28, 179 },
                    { 376, 23, 479 },
                    { 536, 34, 207 },
                    { 143, 21, 207 },
                    { 97, 1, 207 },
                    { 501, 29, 502 },
                    { 535, 34, 206 },
                    { 142, 21, 206 },
                    { 96, 1, 206 },
                    { 397, 24, 233 },
                    { 534, 34, 205 },
                    { 141, 21, 205 },
                    { 396, 24, 232 },
                    { 95, 1, 205 },
                    { 533, 34, 204 },
                    { 140, 21, 204 },
                    { 94, 1, 204 },
                    { 499, 29, 500 },
                    { 398, 24, 234 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 399, 24, 235 },
                    { 400, 24, 236 },
                    { 401, 24, 237 },
                    { 484, 28, 198 },
                    { 610, 44, 197 },
                    { 500, 29, 501 },
                    { 502, 29, 503 },
                    { 98, 1, 208 },
                    { 144, 21, 208 },
                    { 149, 21, 223 },
                    { 151, 21, 225 },
                    { 148, 21, 222 },
                    { 147, 21, 221 },
                    { 152, 21, 226 },
                    { 146, 21, 220 },
                    { 153, 21, 227 },
                    { 447, 26, 509 },
                    { 69, 1, 509 },
                    { 446, 26, 508 },
                    { 68, 1, 508 },
                    { 154, 21, 228 },
                    { 445, 26, 507 },
                    { 67, 1, 507 },
                    { 155, 21, 229 },
                    { 444, 26, 506 },
                    { 66, 1, 506 },
                    { 504, 29, 505 },
                    { 503, 29, 504 },
                    { 538, 34, 209 },
                    { 145, 21, 209 },
                    { 99, 1, 209 },
                    { 537, 34, 208 },
                    { 483, 28, 197 },
                    { 609, 44, 196 },
                    { 482, 28, 196 },
                    { 608, 44, 195 },
                    { 175, 21, 245 },
                    { 407, 24, 245 },
                    { 395, 24, 185 },
                    { 197, 21, 559 },
                    { 302, 22, 559 },
                    { 385, 23, 559 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 394, 24, 184 },
                    { 102, 1, 246 },
                    { 303, 22, 560 },
                    { 176, 21, 246 },
                    { 393, 24, 183 },
                    { 408, 24, 246 },
                    { 304, 22, 561 },
                    { 392, 24, 182 },
                    { 103, 1, 247 },
                    { 391, 24, 181 },
                    { 305, 22, 562 },
                    { 177, 21, 247 },
                    { 409, 24, 247 },
                    { 478, 28, 180 },
                    { 390, 24, 180 },
                    { 306, 22, 563 },
                    { 553, 35, 479 },
                    { 101, 1, 245 },
                    { 604, 44, 179 },
                    { 384, 23, 558 },
                    { 196, 21, 558 },
                    { 481, 28, 195 },
                    { 295, 22, 552 },
                    { 607, 44, 194 },
                    { 480, 28, 194 },
                    { 296, 22, 553 },
                    { 606, 44, 193 },
                    { 297, 22, 554 },
                    { 479, 28, 193 },
                    { 298, 22, 555 },
                    { 605, 44, 192 },
                    { 557, 35, 489 },
                    { 194, 21, 556 },
                    { 299, 22, 556 },
                    { 382, 23, 556 },
                    { 556, 35, 488 },
                    { 100, 1, 244 },
                    { 174, 21, 244 },
                    { 555, 35, 487 },
                    { 195, 21, 557 },
                    { 300, 22, 557 },
                    { 383, 23, 557 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 406, 24, 244 },
                    { 554, 35, 486 },
                    { 301, 22, 558 },
                    { 494, 29, 601 },
                    { 36, 1, 138 },
                    { 495, 29, 602 },
                    { 25, 1, 95 },
                    { 597, 43, 672 },
                    { 598, 43, 673 },
                    { 24, 1, 94 },
                    { 74, 1, 674 },
                    { 452, 26, 674 },
                    { 75, 1, 675 },
                    { 453, 26, 675 },
                    { 76, 1, 676 },
                    { 454, 26, 676 },
                    { 596, 43, 671 },
                    { 150, 21, 224 },
                    { 23, 1, 93 },
                    { 248, 22, 279 },
                    { 517, 33, 279 },
                    { 167, 21, 681 },
                    { 469, 27, 681 },
                    { 22, 1, 92 },
                    { 168, 21, 682 },
                    { 470, 27, 682 },
                    { 585, 42, 279 },
                    { 471, 27, 683 },
                    { 455, 26, 677 },
                    { 26, 1, 96 },
                    { 705, 90, 668 },
                    { 27, 1, 97 },
                    { 620, 45, 654 },
                    { 332, 22, 655 },
                    { 621, 45, 655 },
                    { 30, 1, 100 },
                    { 333, 22, 656 },
                    { 622, 45, 656 },
                    { 334, 22, 657 },
                    { 623, 45, 657 },
                    { 335, 22, 658 },
                    { 594, 43, 658 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 624, 45, 658 },
                    { 336, 22, 659 },
                    { 595, 43, 659 },
                    { 625, 45, 659 },
                    { 29, 1, 99 },
                    { 577, 41, 660 },
                    { 578, 41, 661 },
                    { 579, 41, 662 },
                    { 580, 41, 663 },
                    { 28, 1, 98 },
                    { 702, 90, 665 },
                    { 703, 90, 666 },
                    { 704, 90, 667 },
                    { 21, 1, 91 },
                    { 249, 22, 280 },
                    { 518, 33, 280 },
                    { 586, 42, 280 },
                    { 59, 1, 369 },
                    { 563, 37, 716 },
                    { 629, 48, 716 },
                    { 630, 49, 717 },
                    { 634, 51, 717 },
                    { 636, 52, 717 },
                    { 19, 1, 77 },
                    { 111, 1, 284 },
                    { 185, 21, 284 },
                    { 58, 1, 368 },
                    { 18, 1, 76 },
                    { 253, 22, 284 },
                    { 417, 24, 284 },
                    { 169, 21, 721 },
                    { 17, 1, 75 },
                    { 170, 21, 722 },
                    { 366, 23, 367 },
                    { 511, 31, 724 },
                    { 57, 1, 367 },
                    { 512, 31, 725 },
                    { 16, 1, 74 },
                    { 528, 33, 726 },
                    { 81, 1, 728 },
                    { 80, 1, 715 },
                    { 331, 22, 654 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 79, 1, 714 },
                    { 252, 22, 283 },
                    { 250, 22, 281 },
                    { 519, 33, 281 },
                    { 587, 42, 281 },
                    { 337, 22, 699 },
                    { 338, 22, 700 },
                    { 20, 1, 86 },
                    { 339, 22, 701 },
                    { 123, 1, 702 },
                    { 340, 22, 702 },
                    { 525, 33, 703 },
                    { 589, 42, 703 },
                    { 675, 69, 85 },
                    { 638, 52, 704 },
                    { 251, 22, 282 },
                    { 520, 33, 282 },
                    { 674, 69, 84 },
                    { 588, 42, 282 },
                    { 78, 1, 708 },
                    { 202, 21, 708 },
                    { 673, 69, 83 },
                    { 672, 69, 82 },
                    { 110, 1, 283 },
                    { 184, 21, 283 },
                    { 416, 24, 283 },
                    { 619, 45, 653 },
                    { 330, 22, 653 },
                    { 618, 45, 652 },
                    { 641, 53, 404 },
                    { 433, 25, 612 },
                    { 653, 54, 612 },
                    { 640, 53, 403 },
                    { 639, 53, 402 },
                    { 461, 27, 402 },
                    { 542, 34, 401 },
                    { 460, 27, 401 },
                    { 159, 21, 401 },
                    { 541, 34, 400 },
                    { 459, 27, 400 },
                    { 158, 21, 400 },
                    { 540, 34, 399 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 70, 1, 619 },
                    { 448, 26, 619 },
                    { 458, 27, 399 },
                    { 157, 21, 399 },
                    { 71, 1, 620 },
                    { 449, 26, 620 },
                    { 539, 34, 398 },
                    { 313, 22, 621 },
                    { 156, 21, 398 },
                    { 314, 22, 622 },
                    { 652, 54, 611 },
                    { 443, 26, 397 },
                    { 432, 25, 611 },
                    { 651, 54, 610 },
                    { 35, 1, 137 },
                    { 496, 29, 603 },
                    { 427, 25, 262 },
                    { 497, 29, 604 },
                    { 34, 1, 136 },
                    { 498, 29, 605 },
                    { 131, 21, 135 },
                    { 33, 1, 135 },
                    { 130, 21, 134 },
                    { 311, 22, 607 },
                    { 428, 25, 263 },
                    { 129, 21, 133 },
                    { 128, 21, 132 },
                    { 122, 1, 608 },
                    { 164, 21, 608 },
                    { 312, 22, 608 },
                    { 466, 27, 608 },
                    { 558, 35, 608 },
                    { 611, 44, 608 },
                    { 429, 25, 264 },
                    { 430, 25, 609 },
                    { 650, 54, 609 },
                    { 431, 25, 610 },
                    { 642, 53, 405 },
                    { 112, 1, 285 },
                    { 65, 1, 397 },
                    { 442, 26, 396 },
                    { 72, 1, 644 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 450, 26, 644 },
                    { 73, 1, 645 },
                    { 451, 26, 645 },
                    { 323, 22, 646 },
                    { 590, 43, 646 },
                    { 612, 45, 646 },
                    { 324, 22, 647 },
                    { 591, 43, 647 },
                    { 613, 45, 647 },
                    { 32, 1, 102 },
                    { 325, 22, 648 },
                    { 592, 43, 648 },
                    { 614, 45, 648 },
                    { 326, 22, 649 },
                    { 593, 43, 649 },
                    { 615, 45, 649 },
                    { 327, 22, 650 },
                    { 616, 45, 650 },
                    { 328, 22, 651 },
                    { 617, 45, 651 },
                    { 31, 1, 101 },
                    { 329, 22, 652 },
                    { 369, 23, 390 },
                    { 315, 22, 623 },
                    { 379, 23, 641 },
                    { 378, 23, 640 },
                    { 64, 1, 396 },
                    { 316, 22, 624 },
                    { 317, 22, 625 },
                    { 318, 22, 626 },
                    { 441, 26, 395 },
                    { 319, 22, 627 },
                    { 63, 1, 395 },
                    { 320, 22, 628 },
                    { 440, 26, 394 },
                    { 62, 1, 394 },
                    { 165, 21, 633 },
                    { 467, 27, 633 },
                    { 166, 21, 634 },
                    { 468, 27, 634 },
                    { 439, 26, 393 },
                    { 61, 1, 393 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 321, 22, 637 },
                    { 574, 41, 637 },
                    { 322, 22, 638 },
                    { 575, 41, 638 },
                    { 438, 26, 392 },
                    { 60, 1, 392 },
                    { 377, 23, 639 },
                    { 370, 23, 391 },
                    { 678, 71, 868 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1478);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1497);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1499);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1503);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1504);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1505);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1506);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1507);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1508);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1509);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1510);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1511);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1512);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1513);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1514);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1515);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1516);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1517);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1518);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1519);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1521);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1522);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1523);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1524);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1525);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1526);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1527);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1528);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1529);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1530);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1531);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1532);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1533);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1534);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1535);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1536);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1537);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1538);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1539);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1540);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1541);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1542);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1543);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1544);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1545);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1546);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1547);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1548);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1549);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1550);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1551);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1552);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1553);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1554);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1555);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1556);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1557);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1558);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1559);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1560);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1561);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1562);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1564);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1565);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1566);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1567);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1568);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1569);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1570);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1571);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1572);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1573);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1574);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1575);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1576);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1577);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1578);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1579);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1580);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1581);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1582);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1583);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1585);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1586);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1587);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1588);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1589);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1590);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1591);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1592);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1593);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1594);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1595);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1596);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1597);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1598);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1599);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1601);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1604);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1605);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1606);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1607);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1608);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1609);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1610);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1611);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1612);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1613);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1614);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1615);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1616);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1617);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1618);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1619);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1620);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1621);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1622);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1623);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1624);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1625);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1626);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1627);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1628);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1629);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1630);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1631);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1632);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1633);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1634);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1635);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1636);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1637);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1638);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1639);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1640);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1641);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1642);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1643);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1644);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1645);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1646);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1647);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1648);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1649);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1650);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1651);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1652);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1653);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1654);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1655);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1656);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1657);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1658);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1659);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1660);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1661);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1662);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1663);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1664);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1665);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1666);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1667);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1668);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1669);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1670);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1671);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1672);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1673);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1674);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1675);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1676);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1677);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1678);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1679);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1680);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1681);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1682);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1683);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1684);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1685);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1686);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1687);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1688);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1689);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1690);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1691);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1692);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1693);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1694);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1695);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1696);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1697);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1698);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1699);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1701);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1702);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1704);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1705);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1706);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1707);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1708);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1709);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1710);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1711);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1712);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1713);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1714);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1715);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1716);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1717);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1718);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1719);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1720);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1721);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1722);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1723);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1724);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1725);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1726);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1727);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1728);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1729);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1730);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1731);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1732);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1733);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1734);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1735);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1736);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1737);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1738);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1739);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1740);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1741);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1742);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1743);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1744);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1745);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1746);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1747);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1748);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1749);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1750);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1751);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1752);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1753);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1754);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1755);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1756);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1757);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1758);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1759);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1760);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1761);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1762);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1763);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1764);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1765);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1766);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1767);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1768);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1769);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1770);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1771);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1772);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1773);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1774);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1775);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1776);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1777);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1778);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1779);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1780);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1781);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1782);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1783);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1784);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1785);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1786);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1787);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1788);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1789);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1790);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1791);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1792);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1793);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1794);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1795);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1796);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1797);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1798);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1799);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1804);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1805);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1806);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1807);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1808);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1809);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1810);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1811);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1812);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1813);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1814);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1816);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1817);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1818);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1819);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1820);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1821);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1822);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1823);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1824);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1825);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1826);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1827);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1828);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1829);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1830);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1831);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1832);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1833);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1834);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1835);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1836);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1837);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1838);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1839);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1840);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1841);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1842);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1843);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1844);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1845);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1846);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1847);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1848);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1849);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1850);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1851);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1852);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1853);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1854);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1855);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1856);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1857);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1858);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1859);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1860);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1861);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1862);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1863);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1864);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1865);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1866);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1867);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1868);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1869);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1870);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1871);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1872);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1873);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1874);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1875);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1876);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1877);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1878);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1879);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1880);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1881);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1882);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1884);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1885);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1886);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1887);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1888);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1889);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1890);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1891);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1892);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1893);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1894);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1895);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1896);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1897);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1898);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1899);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1901);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1902);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1903);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1904);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1905);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1906);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1907);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1908);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1909);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1910);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1911);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1912);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1913);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1914);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1915);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1916);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1917);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1918);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1919);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1920);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1921);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1922);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1923);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1924);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1925);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1926);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1927);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1928);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1929);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1930);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1931);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1932);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1933);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1934);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1935);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1936);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1937);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1938);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1939);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1940);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1941);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1942);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1943);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1944);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1945);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1946);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1947);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1948);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1949);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1950);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1951);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1952);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1953);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1954);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1955);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1956);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1957);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1958);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1959);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1960);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1961);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1962);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1963);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1964);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1965);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1966);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1967);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1968);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1969);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1970);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1971);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1972);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1973);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1974);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1975);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1976);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1977);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1978);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1979);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1980);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1981);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1982);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1983);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1984);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1985);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1986);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1987);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1988);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1989);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1990);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1991);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1992);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1993);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1994);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1995);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1996);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1997);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1998);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1999);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 13);
        }
    }
}
