using AnimeApi.Entities;
using AnimeApi.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace AnimeApi.Infrastructure.Seed
{
    public static class Seeder
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            await context.Database.MigrateAsync();

            if (!context.Plataformas.Any())
            {
                context.Plataformas.AddRange(
                    new Plataforma { Id = 1, Nome = "Crunchyroll", Url = "https://www.crunchyroll.com" },
                    new Plataforma { Id = 2, Nome = "Netflix", Url = "https://www.netflix.com" },
                    new Plataforma { Id = 3, Nome = "Amazon Prime", Url = "https://www.primevideo.com" },
                    new Plataforma { Id = 4, Nome = "HBO Max", Url = "https://www.hbomax.com/" },
                    new Plataforma { Id = 5, Nome = "Disney Plus", Url = "https://www.disneyplus.com" }
                );
            }

            if (!context.Animes.Any())
            {
                context.Animes.AddRange(
                    new Anime
                    {
                        Id = 1,
                        Titulo = "Attack on Titan",
                        Descricao =
                            "Em um mundo assolado por criaturas gigantes conhecidas como Titãs, a humanidade vive confinada dentro de muralhas colossais que a protegem da aniquilação. A história acompanha Eren Yeager, Mikasa Ackerman e Armin Arlert, três jovens que veem suas vidas mudarem para sempre após a queda da Muralha Maria. Movido por um desejo ardente de vingança e liberdade, Eren jura exterminar todos os Titãs. Ao longo da jornada, segredos obscuros sobre a origem dessas criaturas e a verdadeira história da humanidade vêm à tona, revelando conspirações políticas, traições inesperadas e dilemas morais profundos. A narrativa mistura ação intensa, drama psicológico e reflexões filosóficas sobre liberdade, destino e sacrifício. Cada temporada amplia a complexidade do enredo, mostrando que os verdadeiros inimigos podem estar tanto dentro quanto fora das muralhas. Com batalhas épicas, personagens complexos e reviravoltas impactantes, Attack on Titan se tornou um marco na cultura pop, conquistando fãs no mundo inteiro. Mais do que uma simples luta pela sobrevivência, é uma história sobre esperança, resistência e a busca por um futuro melhor.",
                        ImagemNome = "wallpapersden.com_attack-on-titan-poster-4k-digital-2022_1360x768.jpg",
                        PlataformaId = 1
                    },

                    new Anime
                    {
                        Id = 2,
                        Titulo = "Demon Slayer",
                        Descricao =
                            "Demon Slayer acompanha Tanjiro Kamado, um jovem bondoso que vive em uma montanha com sua família. Sua vida muda drasticamente quando sua família é massacrada por demônios e sua irmã mais nova, Nezuko, é transformada em uma dessas criaturas. Determinado a encontrar uma cura para Nezuko e vingar sua família, Tanjiro se junta ao Esquadrão de Caçadores de Demônios. A jornada é marcada por batalhas intensas contra inimigos poderosos, cada um com habilidades únicas e histórias trágicas. A série se destaca pela animação impecável, trilha sonora emocionante e pela forma como equilibra ação, drama e momentos de ternura. Tanjiro, com sua determinação inabalável e compaixão, inspira todos ao seu redor, enquanto Nezuko prova que mesmo um demônio pode manter sua humanidade. Ao lado de aliados como Zenitsu e Inosuke, o grupo enfrenta desafios cada vez maiores, revelando segredos sobre a origem dos demônios e o passado sombrio de Muzan Kibutsuji, o grande antagonista. Demon Slayer é uma obra que fala sobre família, sacrifício e a força da esperança diante da escuridão.",
                        ImagemNome = "wp8720119.jpg",
                        PlataformaId = 2
                    },

                    new Anime
                    {
                        Id = 3,
                        Titulo = "One Piece",
                        Descricao =
                            "One Piece narra a incrível jornada de Monkey D. Luffy, um jovem pirata que sonha em encontrar o lendário tesouro conhecido como One Piece e se tornar o Rei dos Piratas. Com seu chapéu de palha e o poder da fruta Gomu Gomu no Mi, que lhe concede um corpo elástico, Luffy parte em uma aventura pelos mares em busca de liberdade e companheiros leais. Ao longo da jornada, ele reúne uma tripulação única: Zoro, o espadachim que sonha ser o melhor do mundo; Nami, a navegadora que deseja mapear todos os mares; Usopp, o atirador cheio de imaginação; Sanji, o cozinheiro que busca o All Blue; Chopper, o médico rena; Robin, a arqueóloga que busca a verdade da história; Franky, o carpinteiro ciborgue; Brook, o músico esqueleto; e Jinbe, o timoneiro homem-peixe. Juntos, eles enfrentam inimigos poderosos, governos corruptos e mistérios ancestrais. One Piece é uma história sobre amizade, sonhos e a busca pela liberdade, com um mundo vasto, cheio de ilhas exóticas, culturas diversas e segredos que mudam a cada arco. Mais do que uma aventura pirata, é uma celebração da coragem e da determinação de nunca desistir dos próprios ideais.",
                        ImagemNome = "wp8994577.jpg",
                        PlataformaId = 2
                    },

                    new Anime
                    {
                        Id = 4,
                        Titulo = "My Hero Academia",
                        Descricao =
                            "Em um mundo onde cerca de 80% da população possui superpoderes chamados “Quirks”, a sociedade se organiza em torno de heróis e vilões. Izuku Midoriya, um jovem sem poderes, sonha em se tornar um herói como seu ídolo All Might. Sua vida muda quando All Might reconhece sua coragem e lhe concede o poder do One For All, um legado que carrega a força de gerações. A jornada de Midoriya é marcada por treinos intensos, batalhas contra vilões poderosos e dilemas sobre o que significa ser um verdadeiro herói. Ao lado de colegas da U.A. High School, como Bakugo, Todoroki e Uraraka, ele enfrenta desafios que vão muito além da sala de aula. A série explora temas de amizade, rivalidade, sacrifício e responsabilidade, mostrando que ser herói não é apenas ter poder, mas também ter coração e determinação. Cada arco revela segredos sobre o passado dos heróis e vilões, ampliando a complexidade da narrativa. Com ação eletrizante, personagens carismáticos e mensagens inspiradoras, My Hero Academia conquistou fãs no mundo inteiro e se tornou um dos pilares da nova geração de animes.",
                        ImagemNome = "wp1874068.jpg",
                        PlataformaId = 1
                    },

                    new Anime
                    {
                        Id = 5,
                        Titulo = "Bleach",
                        Descricao =
                            "Bleach acompanha Ichigo Kurosaki, um adolescente que acidentalmente recebe poderes de Shinigami (Ceifeiro de Almas) após conhecer Rukia Kuchiki. Com essa responsabilidade, Ichigo passa a proteger os vivos contra espíritos malignos chamados Hollows e a guiar almas para o além. A série se destaca por suas batalhas intensas, personagens memoráveis e um universo rico que mistura ação sobrenatural com reflexões sobre vida e morte. Ao longo da história, Ichigo descobre segredos sobre sua própria origem e enfrenta inimigos cada vez mais poderosos, como os Arrancar e os membros da organização Espada. Bleach também apresenta mundos paralelos, como a Soul Society e Hueco Mundo, cada um com suas regras e hierarquias. A narrativa combina humor, drama e ação, criando momentos épicos que marcaram gerações de fãs. Com arcos longos e repletos de reviravoltas, Bleach é uma obra que fala sobre coragem, amizade e a luta constante contra forças que ameaçam o equilíbrio entre os mundos. É um clássico do gênero shonen, lembrado por suas batalhas icônicas e pela trilha sonora marcante.",
                        ImagemNome = "bleach-thousand-year-blood-war-anime_2560x1440_11093.jpg",
                        PlataformaId = 5
                    },

                    new Anime
                    {
                        Id = 6,
                        Titulo = "Invincible",
                        Descricao =
                            "Invincible é uma série animada baseada nos quadrinhos de Robert Kirkman. A história acompanha Mark Grayson, um adolescente aparentemente comum, filho de Nolan Grayson, também conhecido como Omni-Man, o maior super-herói da Terra. Quando Mark finalmente desenvolve seus poderes, ele assume o codinome Invincible e começa sua jornada para se tornar um herói. No entanto, sua vida muda drasticamente ao descobrir segredos sombrios sobre seu pai e a verdadeira missão dos Viltrumitas, uma raça alienígena poderosa e implacável. A série se destaca por sua violência gráfica, narrativa madura e personagens complexos, explorando os dilemas morais de ser um herói em um mundo cheio de corrupção, traições e ameaças cósmicas. Invincible mistura ação brutal com drama familiar, mostrando que nem sempre os heróis são tão nobres quanto parecem. Cada episódio revela novas camadas da trama, com batalhas épicas e consequências devastadoras. É uma obra que redefine o gênero de super-heróis, trazendo realismo e intensidade emocional para um universo que vai muito além do bem contra o mal.",
                        ImagemNome = "invincible-season-1-2560x1440-13454.jpg",
                        PlataformaId = 3
                    },

                    new Anime
                    {
                        Id = 7,
                        Titulo = "Black Clover",
                        Descricao =
                            "Black Clover acompanha Asta e Yuno, dois órfãos criados em uma igreja, que sonham em se tornar o Rei Mago, o maior mago do Reino Clover. Enquanto Yuno demonstra talento natural e recebe um grimório raro de quatro folhas, Asta nasce sem qualquer poder mágico, algo impensável em um mundo onde a magia é tudo. Determinado a superar suas limitações, Asta treina seu corpo ao extremo e acaba recebendo um grimório misterioso de cinco folhas, que lhe concede poderes anti-magia. A série segue a jornada dos dois em busca de seus sonhos, enfrentando inimigos poderosos, demônios e organizações sombrias que ameaçam o reino. Black Clover é marcado por batalhas intensas, rivalidades inspiradoras e momentos de superação. Asta, com sua determinação inabalável, prova que força de vontade pode superar qualquer obstáculo, enquanto Yuno mostra que talento e disciplina também são essenciais. A obra mistura ação frenética, humor leve e mensagens sobre amizade e perseverança, conquistando fãs que se identificam com a luta dos protagonistas contra o destino.",
                        ImagemNome = "wp5060560.png",
                        PlataformaId = 4
                    },

                    new Anime
                    {
                        Id = 8,
                        Titulo = "Dragon Ball Super",
                        Descricao =
                            "Dragon Ball Super continua a saga de Goku e seus amigos após os eventos de Dragon Ball Z. A série expande o universo ao introduzir novos deuses, universos paralelos e torneios épicos que colocam os guerreiros em batalhas nunca antes vistas. Goku alcança novas transformações, como o Super Saiyajin Blue e o Ultra Instinct, enfrentando inimigos poderosos como Beerus, Zamasu e Jiren. A narrativa mistura humor clássico da franquia com momentos de pura ação, trazendo de volta a essência que conquistou gerações. Dragon Ball Super também explora temas de amizade, rivalidade e superação, mostrando que Goku e Vegeta continuam evoluindo mesmo após tantas batalhas. O Torneio do Poder é um dos arcos mais marcantes, reunindo lutadores de diversos universos em uma competição que decide o destino da existência. Com animação moderna, trilha sonora empolgante e personagens carismáticos, Dragon Ball Super mantém viva a chama da franquia, conquistando novos fãs e emocionando os antigos. É uma celebração da força, da coragem e da busca infinita por se tornar mais forte.",
                        ImagemNome = "dragonBall.jpg",
                        PlataformaId = 3
                    }
                );
            }

            await context.SaveChangesAsync();
        }
    }
}
