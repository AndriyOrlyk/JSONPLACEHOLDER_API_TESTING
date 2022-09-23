using System.Collections.Generic;
using System.Linq;

namespace JsonPlaceHolderTests
{
    static public class Data 
    {
        static public PlaceHolder[] AllResources = new PlaceHolder[]
        {
            new PlaceHolder {
                UserId = 1,
                Id = 1,
                Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                Body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
            },
            new PlaceHolder {
                UserId = 1,
                Id = 2,
                Title = "qui est esse",
                Body = "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla"
            },
            new PlaceHolder {
                UserId = 1,
                Id = 3,
                Title = "ea molestias quasi exercitationem repellat qui ipsa sit aut",
                Body = "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut"
            },
            new PlaceHolder {
                UserId = 1,
                Id = 4,
                Title = "eum et est occaecati",
                Body = "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit"
            },
            new PlaceHolder {
                UserId = 1,
                Id = 5,
                Title = "nesciunt quas odio",
                Body = "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque"
            },
            new PlaceHolder {
                UserId = 1,
                Id = 6,
                Title = "dolorem eum magni eos aperiam quia",
                Body = "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae"
            },
            new PlaceHolder {
                UserId = 1,
                Id = 7,
                Title = "magnam facilis autem",
                Body = "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas"
            },
            new PlaceHolder {
                UserId = 1,
                Id = 8,
                Title = "dolorem dolore est ipsam",
                Body = "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae"
            },
            new PlaceHolder {
                UserId = 1,
                Id = 9,
                Title = "nesciunt iure omnis dolorem tempora et accusantium",
                Body = "consectetur animi nesciunt iure dolore\nenim quia ad\nveniam autem ut quam aut nobis\net est aut quod aut provident voluptas autem voluptas"
            },
            new PlaceHolder {
                UserId = 1,
                Id = 10,
                Title = "optio molestias id quia eum",
                Body = "quo et expedita modi cum officia vel magni\ndoloribus qui repudiandae\nvero nisi sit\nquos veniam quod sed accusamus veritatis error"
            },
            new PlaceHolder {
                UserId = 2,
                Id = 11,
                Title = "et ea vero quia laudantium autem",
                Body = "delectus reiciendis molestiae occaecati non minima eveniet qui voluptatibus\naccusamus in eum beatae sit\nvel qui neque voluptates ut commodi qui incidunt\nut animi commodi"
            },
            new PlaceHolder {
                UserId = 2,
                Id = 12,
                Title = "in quibusdam tempore odit est dolorem",
                Body = "itaque id aut magnam\npraesentium quia et ea odit et ea voluptas et\nsapiente quia nihil amet occaecati quia id voluptatem\nincidunt ea est distinctio odio"
            },
            new PlaceHolder {
                UserId = 2,
                Id = 13,
                Title = "dolorum ut in voluptas mollitia et saepe quo animi",
                Body = "aut dicta possimus sint mollitia voluptas commodi quo doloremque\niste corrupti reiciendis voluptatem eius rerum\nsit cumque quod eligendi laborum minima\nperferendis recusandae assumenda consectetur porro architecto ipsum ipsam"
            },
            new PlaceHolder {
                UserId = 2,
                Id = 14,
                Title = "voluptatem eligendi optio",
                Body = "fuga et accusamus dolorum perferendis illo voluptas\nnon doloremque neque facere\nad qui dolorum molestiae beatae\nsed aut voluptas totam sit illum"
            },
            new PlaceHolder {
                UserId = 2,
                Id = 15,
                Title = "eveniet quod temporibus",
                Body = "reprehenderit quos placeat\nvelit minima officia dolores impedit repudiandae molestiae nam\nvoluptas recusandae quis delectus\nofficiis harum fugiat vitae"
            },
            new PlaceHolder {
                UserId = 2,
                Id = 16,
                Title = "sint suscipit perspiciatis velit dolorum rerum ipsa laboriosam odio",
                Body = "suscipit nam nisi quo aperiam aut\nasperiores eos fugit maiores voluptatibus quia\nvoluptatem quis ullam qui in alias quia est\nconsequatur magni mollitia accusamus ea nisi voluptate dicta"
            },
            new PlaceHolder {
                UserId = 2,
                Id = 17,
                Title = "fugit voluptas sed molestias voluptatem provident",
                Body = "eos voluptas et aut odit natus earum\naspernatur fuga molestiae ullam\ndeserunt ratione qui eos\nqui nihil ratione nemo velit ut aut id quo"
            },
            new PlaceHolder {
                UserId = 2,
                Id = 18,
                Title = "voluptate et itaque vero tempora molestiae",
                Body = "eveniet quo quis\nlaborum totam consequatur non dolor\nut et est repudiandae\nest voluptatem vel debitis et magnam"
            },
            new PlaceHolder {
                UserId = 2,
                Id = 19,
                Title = "adipisci placeat illum aut reiciendis qui",
                Body = "illum quis cupiditate provident sit magnam\nea sed aut omnis\nveniam maiores ullam consequatur atque\nadipisci quo iste expedita sit quos voluptas"
            },
            new PlaceHolder {
                UserId = 2,
                Id = 20,
                Title = "doloribus ad provident suscipit at",
                Body = "qui consequuntur ducimus possimus quisquam amet similique\nsuscipit porro ipsam amet\neos veritatis officiis exercitationem vel fugit aut necessitatibus totam\nomnis rerum consequatur expedita quidem cumque explicabo"
            },
            new PlaceHolder {
                UserId = 3,
                Id = 21,
                Title = "asperiores ea ipsam voluptatibus modi minima quia sint",
                Body = "repellat aliquid praesentium dolorem quo\nsed totam minus non itaque\nnihil labore molestiae sunt dolor eveniet hic recusandae veniam\ntempora et tenetur expedita sunt"
            },
            new PlaceHolder {
                UserId = 3,
                Id = 22,
                Title = "dolor sint quo a velit explicabo quia nam",
                Body = "eos qui et ipsum ipsam suscipit aut\nsed omnis non odio\nexpedita earum mollitia molestiae aut atque rem suscipit\nnam impedit esse"
            },
            new PlaceHolder {
                UserId = 3,
                Id = 23,
                Title = "maxime id vitae nihil numquam",
                Body = "veritatis unde neque eligendi\nquae quod architecto quo neque vitae\nest illo sit tempora doloremque fugit quod\net et vel beatae sequi ullam sed tenetur perspiciatis"
            },
            new PlaceHolder {
                UserId = 3,
                Id = 24,
                Title = "autem hic labore sunt dolores incidunt",
                Body = "enim et ex nulla\nomnis voluptas quia qui\nvoluptatem consequatur numquam aliquam sunt\ntotam recusandae id dignissimos aut sed asperiores deserunt"
            },
            new PlaceHolder {
                UserId = 3,
                Id = 25,
                Title = "rem alias distinctio quo quis",
                Body = "ullam consequatur ut\nomnis quis sit vel consequuntur\nipsa eligendi ipsum molestiae et omnis error nostrum\nmolestiae illo tempore quia et distinctio"
            },
            new PlaceHolder {
                UserId = 3,
                Id = 26,
                Title = "est et quae odit qui non",
                Body = "similique esse doloribus nihil accusamus\nomnis dolorem fuga consequuntur reprehenderit fugit recusandae temporibus\nperspiciatis cum ut laudantium\nomnis aut molestiae vel vero"
            },
            new PlaceHolder {
                UserId = 3,
                Id = 27,
                Title = "quasi id et eos tenetur aut quo autem",
                Body = "eum sed dolores ipsam sint possimus debitis occaecati\ndebitis qui qui et\nut placeat enim earum aut odit facilis\nconsequatur suscipit necessitatibus rerum sed inventore temporibus consequatur"
            },
            new PlaceHolder {
                UserId = 3,
                Id = 28,
                Title = "delectus ullam et corporis nulla voluptas sequi",
                Body = "non et quaerat ex quae ad maiores\nmaiores recusandae totam aut blanditiis mollitia quas illo\nut voluptatibus voluptatem\nsimilique nostrum eum"
            },
            new PlaceHolder {
                UserId = 3,
                Id = 29,
                Title = "iusto eius quod necessitatibus culpa ea",
                Body = "odit magnam ut saepe sed non qui\ntempora atque nihil\naccusamus illum doloribus illo dolor\neligendi repudiandae odit magni similique sed cum maiores"
            },
            new PlaceHolder {
                UserId = 3,
                Id = 30,
                Title = "a quo magni similique perferendis",
                Body = "alias dolor cumque\nimpedit blanditiis non eveniet odio maxime\nblanditiis amet eius quis tempora quia autem rem\na provident perspiciatis quia"
            },
            new PlaceHolder {
                UserId = 4,
                Id = 31,
                Title = "ullam ut quidem id aut vel consequuntur",
                Body = "debitis eius sed quibusdam non quis consectetur vitae\nimpedit ut qui consequatur sed aut in\nquidem sit nostrum et maiores adipisci atque\nquaerat voluptatem adipisci repudiandae"
            },
            new PlaceHolder {
                UserId = 4,
                Id = 32,
                Title = "doloremque illum aliquid sunt",
                Body = "deserunt eos nobis asperiores et hic\nest debitis repellat molestiae optio\nnihil ratione ut eos beatae quibusdam distinctio maiores\nearum voluptates et aut adipisci ea maiores voluptas maxime"
            },
            new PlaceHolder {
                UserId = 4,
                Id = 33,
                Title = "qui explicabo molestiae dolorem",
                Body = "rerum ut et numquam laborum odit est sit\nid qui sint in\nquasi tenetur tempore aperiam et quaerat qui in\nrerum officiis sequi cumque quod"
            },
            new PlaceHolder {
                UserId = 4,
                Id = 34,
                Title = "magnam ut rerum iure",
                Body = "ea velit perferendis earum ut voluptatem voluptate itaque iusto\ntotam pariatur in\nnemo voluptatem voluptatem autem magni tempora minima in\nest distinctio qui assumenda accusamus dignissimos officia nesciunt nobis"
            },
            new PlaceHolder {
                UserId = 4,
                Id = 35,
                Title = "id nihil consequatur molestias animi provident",
                Body = "nisi error delectus possimus ut eligendi vitae\nplaceat eos harum cupiditate facilis reprehenderit voluptatem beatae\nmodi ducimus quo illum voluptas eligendi\net nobis quia fugit"
            },
            new PlaceHolder {
                UserId = 4,
                Id = 36,
                Title = "fuga nam accusamus voluptas reiciendis itaque",
                Body = "ad mollitia et omnis minus architecto odit\nvoluptas doloremque maxime aut non ipsa qui alias veniam\nblanditiis culpa aut quia nihil cumque facere et occaecati\nqui aspernatur quia eaque ut aperiam inventore"
            },
            new PlaceHolder {
                UserId = 4,
                Id = 37,
                Title = "provident vel ut sit ratione est",
                Body = "debitis et eaque non officia sed nesciunt pariatur vel\nvoluptatem iste vero et ea\nnumquam aut expedita ipsum nulla in\nvoluptates omnis consequatur aut enim officiis in quam qui"
            },
            new PlaceHolder {
                UserId = 4,
                Id = 38,
                Title = "explicabo et eos deleniti nostrum ab id repellendus",
                Body = "animi esse sit aut sit nesciunt assumenda eum voluptas\nquia voluptatibus provident quia necessitatibus ea\nrerum repudiandae quia voluptatem delectus fugit aut id quia\nratione optio eos iusto veniam iure"
            },
            new PlaceHolder {
                UserId = 4,
                Id = 39,
                Title = "eos dolorem iste accusantium est eaque quam",
                Body = "corporis rerum ducimus vel eum accusantium\nmaxime aspernatur a porro possimus iste omnis\nest in deleniti asperiores fuga aut\nvoluptas sapiente vel dolore minus voluptatem incidunt ex"
            },
            new PlaceHolder {
                UserId = 4,
                Id = 40,
                Title = "enim quo cumque",
                Body = "ut voluptatum aliquid illo tenetur nemo sequi quo facilis\nipsum rem optio mollitia quas\nvoluptatem eum voluptas qui\nunde omnis voluptatem iure quasi maxime voluptas nam"
            },
            new PlaceHolder {
                UserId = 5,
                Id = 41,
                Title = "non est facere",
                Body = "molestias id nostrum\nexcepturi molestiae dolore omnis repellendus quaerat saepe\nconsectetur iste quaerat tenetur asperiores accusamus ex ut\nnam quidem est ducimus sunt debitis saepe"
            },
            new PlaceHolder {
                UserId = 5,
                Id = 42,
                Title = "commodi ullam sint et excepturi error explicabo praesentium voluptas",
                Body = "odio fugit voluptatum ducimus earum autem est incidunt voluptatem\nodit reiciendis aliquam sunt sequi nulla dolorem\nnon facere repellendus voluptates quia\nratione harum vitae ut"
            },
            new PlaceHolder {
                UserId = 5,
                Id = 43,
                Title = "eligendi iste nostrum consequuntur adipisci praesentium sit beatae perferendis",
                Body = "similique fugit est\nillum et dolorum harum et voluptate eaque quidem\nexercitationem quos nam commodi possimus cum odio nihil nulla\ndolorum exercitationem magnam ex et a et distinctio debitis"
            },
            new PlaceHolder {
                UserId = 5,
                Id = 44,
                Title = "optio dolor molestias sit",
                Body = "temporibus est consectetur dolore\net libero debitis vel velit laboriosam quia\nipsum quibusdam qui itaque fuga rem aut\nea et iure quam sed maxime ut distinctio quae"
            },
            new PlaceHolder {
                UserId = 5,
                Id = 45,
                Title = "ut numquam possimus omnis eius suscipit laudantium iure",
                Body = "est natus reiciendis nihil possimus aut provident\nex et dolor\nrepellat pariatur est\nnobis rerum repellendus dolorem autem"
            },
            new PlaceHolder {
                UserId = 5,
                Id = 46,
                Title = "aut quo modi neque nostrum ducimus",
                Body = "voluptatem quisquam iste\nvoluptatibus natus officiis facilis dolorem\nquis quas ipsam\nvel et voluptatum in aliquid"
            },
            new PlaceHolder {
                UserId = 5,
                Id = 47,
                Title = "quibusdam cumque rem aut deserunt",
                Body = "voluptatem assumenda ut qui ut cupiditate aut impedit veniam\noccaecati nemo illum voluptatem laudantium\nmolestiae beatae rerum ea iure soluta nostrum\neligendi et voluptate"
            },
            new PlaceHolder {
                UserId = 5,
                Id = 48,
                Title = "ut voluptatem illum ea doloribus itaque eos",
                Body = "voluptates quo voluptatem facilis iure occaecati\nvel assumenda rerum officia et\nillum perspiciatis ab deleniti\nlaudantium repellat ad ut et autem reprehenderit"
            },
            new PlaceHolder {
                UserId = 5,
                Id = 49,
                Title = "laborum non sunt aut ut assumenda perspiciatis voluptas",
                Body = "inventore ab sint\nnatus fugit id nulla sequi architecto nihil quaerat\neos tenetur in in eum veritatis non\nquibusdam officiis aspernatur cumque aut commodi aut"
            },
            new PlaceHolder {
                UserId = 5,
                Id = 50,
                Title = "repellendus qui recusandae incidunt voluptates tenetur qui omnis exercitationem",
                Body = "error suscipit maxime adipisci consequuntur recusandae\nvoluptas eligendi et est et voluptates\nquia distinctio ab amet quaerat molestiae et vitae\nadipisci impedit sequi nesciunt quis consectetur"
            },
            new PlaceHolder {
                UserId = 6,
                Id = 51,
                Title = "soluta aliquam aperiam consequatur illo quis voluptas",
                Body = "sunt dolores aut doloribus\ndolore doloribus voluptates tempora et\ndoloremque et quo\ncum asperiores sit consectetur dolorem"
            },
            new PlaceHolder {
                UserId = 6,
                Id = 52,
                Title = "qui enim et consequuntur quia animi quis voluptate quibusdam",
                Body = "iusto est quibusdam fuga quas quaerat molestias\na enim ut sit accusamus enim\ntemporibus iusto accusantium provident architecto\nsoluta esse reprehenderit qui laborum"
            },
            new PlaceHolder {
                UserId = 6,
                Id = 53,
                Title = "ut quo aut ducimus alias",
                Body = "minima harum praesentium eum rerum illo dolore\nquasi exercitationem rerum nam\nporro quis neque quo\nconsequatur minus dolor quidem veritatis sunt non explicabo similique"
            },
            new PlaceHolder {
                UserId = 6,
                Id = 54,
                Title = "sit asperiores ipsam eveniet odio non quia",
                Body = "totam corporis dignissimos\nvitae dolorem ut occaecati accusamus\nex velit deserunt\net exercitationem vero incidunt corrupti mollitia"
            },
            new PlaceHolder {
                UserId = 6,
                Id = 55,
                Title = "sit vel voluptatem et non libero",
                Body = "debitis excepturi ea perferendis harum libero optio\neos accusamus cum fuga ut sapiente repudiandae\net ut incidunt omnis molestiae\nnihil ut eum odit"
            },
            new PlaceHolder {
                UserId = 6,
                Id = 56,
                Title = "qui et at rerum necessitatibus",
                Body = "aut est omnis dolores\nneque rerum quod ea rerum velit pariatur beatae excepturi\net provident voluptas corrupti\ncorporis harum reprehenderit dolores eligendi"
            },
            new PlaceHolder {
                UserId = 6,
                Id = 57,
                Title = "sed ab est est",
                Body = "at pariatur consequuntur earum quidem\nquo est laudantium soluta voluptatem\nqui ullam et est\net cum voluptas voluptatum repellat est"
            },
            new PlaceHolder {
                UserId = 6,
                Id = 58,
                Title = "voluptatum itaque dolores nisi et quasi",
                Body = "veniam voluptatum quae adipisci id\net id quia eos ad et dolorem\naliquam quo nisi sunt eos impedit error\nad similique veniam"
            },
            new PlaceHolder {
                UserId = 6,
                Id = 59,
                Title = "qui commodi dolor at maiores et quis id accusantium",
                Body = "perspiciatis et quam ea autem temporibus non voluptatibus qui\nbeatae a earum officia nesciunt dolores suscipit voluptas et\nanimi doloribus cum rerum quas et magni\net hic ut ut commodi expedita sunt"
            },
            new PlaceHolder {
                UserId = 6,
                Id = 60,
                Title = "consequatur placeat omnis quisquam quia reprehenderit fugit veritatis facere",
                Body = "asperiores sunt ab assumenda cumque modi velit\nqui esse omnis\nvoluptate et fuga perferendis voluptas\nillo ratione amet aut et omnis"
            },
            new PlaceHolder {
                UserId = 7,
                Id = 61,
                Title = "voluptatem doloribus consectetur est ut ducimus",
                Body = "ab nemo optio odio\ndelectus tenetur corporis similique nobis repellendus rerum omnis facilis\nvero blanditiis debitis in nesciunt doloribus dicta dolores\nmagnam minus velit"
            },
            new PlaceHolder {
                UserId = 7,
                Id = 62,
                Title = "beatae enim quia vel",
                Body = "enim aspernatur illo distinctio quae praesentium\nbeatae alias amet delectus qui voluptate distinctio\nodit sint accusantium autem omnis\nquo molestiae omnis ea eveniet optio"
            },
            new PlaceHolder {
                UserId = 7,
                Id = 63,
                Title = "voluptas blanditiis repellendus animi ducimus error sapiente et suscipit",
                Body = "enim adipisci aspernatur nemo\nnumquam omnis facere dolorem dolor ex quis temporibus incidunt\nab delectus culpa quo reprehenderit blanditiis asperiores\naccusantium ut quam in voluptatibus voluptas ipsam dicta"
            },
            new PlaceHolder {
                UserId = 7,
                Id = 64,
                Title = "et fugit quas eum in in aperiam quod",
                Body = "id velit blanditiis\neum ea voluptatem\nmolestiae sint occaecati est eos perspiciatis\nincidunt a error provident eaque aut aut qui"
            },
            new PlaceHolder {
                UserId = 7,
                Id = 65,
                Title = "consequatur id enim sunt et et",
                Body = "voluptatibus ex esse\nsint explicabo est aliquid cumque adipisci fuga repellat labore\nmolestiae corrupti ex saepe at asperiores et perferendis\nnatus id esse incidunt pariatur"
            },
            new PlaceHolder {
                UserId = 7,
                Id = 66,
                Title = "repudiandae ea animi iusto",
                Body = "officia veritatis tenetur vero qui itaque\nsint non ratione\nsed et ut asperiores iusto eos molestiae nostrum\nveritatis quibusdam et nemo iusto saepe"
            },
            new PlaceHolder {
                UserId = 7,
                Id = 67,
                Title = "aliquid eos sed fuga est maxime repellendus",
                Body = "reprehenderit id nostrum\nvoluptas doloremque pariatur sint et accusantium quia quod aspernatur\net fugiat amet\nnon sapiente et consequatur necessitatibus molestiae"
            },
            new PlaceHolder {
                UserId = 7,
                Id = 68,
                Title = "odio quis facere architecto reiciendis optio",
                Body = "magnam molestiae perferendis quisquam\nqui cum reiciendis\nquaerat animi amet hic inventore\nea quia deleniti quidem saepe porro velit"
            },
            new PlaceHolder {
                UserId = 7,
                Id = 69,
                Title = "fugiat quod pariatur odit minima",
                Body = "officiis error culpa consequatur modi asperiores et\ndolorum assumenda voluptas et vel qui aut vel rerum\nvoluptatum quisquam perspiciatis quia rerum consequatur totam quas\nsequi commodi repudiandae asperiores et saepe a"
            },
            new PlaceHolder {
                UserId = 7,
                Id = 70,
                Title = "voluptatem laborum magni",
                Body = "sunt repellendus quae\nest asperiores aut deleniti esse accusamus repellendus quia aut\nquia dolorem unde\neum tempora esse dolore"
            },
            new PlaceHolder {
                UserId = 8,
                Id = 71,
                Title = "et iusto veniam et illum aut fuga",
                Body = "occaecati a doloribus\niste saepe consectetur placeat eum voluptate dolorem et\nqui quo quia voluptas\nrerum ut id enim velit est perferendis"
            },
            new PlaceHolder {
                UserId = 8,
                Id = 72,
                Title = "sint hic doloribus consequatur eos non id",
                Body = "quam occaecati qui deleniti consectetur\nconsequatur aut facere quas exercitationem aliquam hic voluptas\nneque id sunt ut aut accusamus\nsunt consectetur expedita inventore velit"
            },
            new PlaceHolder {
                UserId = 8,
                Id = 73,
                Title = "consequuntur deleniti eos quia temporibus ab aliquid at",
                Body = "voluptatem cumque tenetur consequatur expedita ipsum nemo quia explicabo\naut eum minima consequatur\ntempore cumque quae est et\net in consequuntur voluptatem voluptates aut"
            },
            new PlaceHolder {
                UserId = 8,
                Id = 74,
                Title = "enim unde ratione doloribus quas enim ut sit sapiente",
                Body = "odit qui et et necessitatibus sint veniam\nmollitia amet doloremque molestiae commodi similique magnam et quam\nblanditiis est itaque\nquo et tenetur ratione occaecati molestiae tempora"
            },
            new PlaceHolder {
                UserId = 8,
                Id = 75,
                Title = "dignissimos eum dolor ut enim et delectus in",
                Body = "commodi non non omnis et voluptas sit\nautem aut nobis magnam et sapiente voluptatem\net laborum repellat qui delectus facilis temporibus\nrerum amet et nemo voluptate expedita adipisci error dolorem"
            },
            new PlaceHolder {
                UserId = 8,
                Id = 76,
                Title = "doloremque officiis ad et non perferendis",
                Body = "ut animi facere\ntotam iusto tempore\nmolestiae eum aut et dolorem aperiam\nquaerat recusandae totam odio"
            },
            new PlaceHolder {
                UserId = 8,
                Id = 77,
                Title = "necessitatibus quasi exercitationem odio",
                Body = "modi ut in nulla repudiandae dolorum nostrum eos\naut consequatur omnis\nut incidunt est omnis iste et quam\nvoluptates sapiente aliquam asperiores nobis amet corrupti repudiandae provident"
            },
            new PlaceHolder {
                UserId = 8,
                Id = 78,
                Title = "quam voluptatibus rerum veritatis",
                Body = "nobis facilis odit tempore cupiditate quia\nassumenda doloribus rerum qui ea\nillum et qui totam\naut veniam repellendus"
            },
            new PlaceHolder {
                UserId = 8,
                Id = 79,
                Title = "pariatur consequatur quia magnam autem omnis non amet",
                Body = "libero accusantium et et facere incidunt sit dolorem\nnon excepturi qui quia sed laudantium\nquisquam molestiae ducimus est\nofficiis esse molestiae iste et quos"
            },
            new PlaceHolder {
                UserId = 8,
                Id = 80,
                Title = "labore in ex et explicabo corporis aut quas",
                Body = "ex quod dolorem ea eum iure qui provident amet\nquia qui facere excepturi et repudiandae\nasperiores molestias provident\nminus incidunt vero fugit rerum sint sunt excepturi provident"
            },
            new PlaceHolder {
                UserId = 9,
                Id = 81,
                Title = "tempora rem veritatis voluptas quo dolores vero",
                Body = "facere qui nesciunt est voluptatum voluptatem nisi\nsequi eligendi necessitatibus ea at rerum itaque\nharum non ratione velit laboriosam quis consequuntur\nex officiis minima doloremque voluptas ut aut"
            },
            new PlaceHolder {
                UserId = 9,
                Id = 82,
                Title = "laudantium voluptate suscipit sunt enim enim",
                Body = "ut libero sit aut totam inventore sunt\nporro sint qui sunt molestiae\nconsequatur cupiditate qui iste ducimus adipisci\ndolor enim assumenda soluta laboriosam amet iste delectus hic"
            },
            new PlaceHolder {
                UserId = 9,
                Id = 83,
                Title = "odit et voluptates doloribus alias odio et",
                Body = "est molestiae facilis quis tempora numquam nihil qui\nvoluptate sapiente consequatur est qui\nnecessitatibus autem aut ipsa aperiam modi dolore numquam\nreprehenderit eius rem quibusdam"
            },
            new PlaceHolder {
                UserId = 9,
                Id = 84,
                Title = "optio ipsam molestias necessitatibus occaecati facilis veritatis dolores aut",
                Body = "sint molestiae magni a et quos\neaque et quasi\nut rerum debitis similique veniam\nrecusandae dignissimos dolor incidunt consequatur odio"
            },
            new PlaceHolder {
                UserId = 9,
                Id = 85,
                Title = "dolore veritatis porro provident adipisci blanditiis et sunt",
                Body = "similique sed nisi voluptas iusto omnis\nmollitia et quo\nassumenda suscipit officia magnam sint sed tempora\nenim provident pariatur praesentium atque animi amet ratione"
            },
            new PlaceHolder {
                UserId = 9,
                Id = 86,
                Title = "placeat quia et porro iste",
                Body = "quasi excepturi consequatur iste autem temporibus sed molestiae beatae\net quaerat et esse ut\nvoluptatem occaecati et vel explicabo autem\nasperiores pariatur deserunt optio"
            },
            new PlaceHolder {
                UserId = 9,
                Id = 87,
                Title = "nostrum quis quasi placeat",
                Body = "eos et molestiae\nnesciunt ut a\ndolores perspiciatis repellendus repellat aliquid\nmagnam sint rem ipsum est"
            },
            new PlaceHolder {
                UserId = 9,
                Id = 88,
                Title = "sapiente omnis fugit eos",
                Body = "consequatur omnis est praesentium\nducimus non iste\nneque hic deserunt\nvoluptatibus veniam cum et rerum sed"
            },
            new PlaceHolder {
                UserId = 9,
                Id = 89,
                Title = "sint soluta et vel magnam aut ut sed qui",
                Body = "repellat aut aperiam totam temporibus autem et\narchitecto magnam ut\nconsequatur qui cupiditate rerum quia soluta dignissimos nihil iure\ntempore quas est"
            },
            new PlaceHolder {
                UserId = 9,
                Id = 90,
                Title = "ad iusto omnis odit dolor voluptatibus",
                Body = "minus omnis soluta quia\nqui sed adipisci voluptates illum ipsam voluptatem\neligendi officia ut in\neos soluta similique molestias praesentium blanditiis"
            },
            new PlaceHolder {
                UserId = 10,
                Id = 91,
                Title = "aut amet sed",
                Body = "libero voluptate eveniet aperiam sed\nsunt placeat suscipit molestias\nsimilique fugit nam natus\nexpedita consequatur consequatur dolores quia eos et placeat"
            },
            new PlaceHolder {
                UserId = 10,
                Id = 92,
                Title = "ratione ex tenetur perferendis",
                Body = "aut et excepturi dicta laudantium sint rerum nihil\nlaudantium et at\na neque minima officia et similique libero et\ncommodi voluptate qui"
            },
            new PlaceHolder {
                UserId = 10,
                Id = 93,
                Title = "beatae soluta recusandae",
                Body = "dolorem quibusdam ducimus consequuntur dicta aut quo laboriosam\nvoluptatem quis enim recusandae ut sed sunt\nnostrum est odit totam\nsit error sed sunt eveniet provident qui nulla"
            },
            new PlaceHolder {
                UserId = 10,
                Id = 94,
                Title = "qui qui voluptates illo iste minima",
                Body = "aspernatur expedita soluta quo ab ut similique\nexpedita dolores amet\nsed temporibus distinctio magnam saepe deleniti\nomnis facilis nam ipsum natus sint similique omnis"
            },
            new PlaceHolder {
                UserId = 10,
                Id = 95,
                Title = "id minus libero illum nam ad officiis",
                Body = "earum voluptatem facere provident blanditiis velit laboriosam\npariatur accusamus odio saepe\ncumque dolor qui a dicta ab doloribus consequatur omnis\ncorporis cupiditate eaque assumenda ad nesciunt"
            },
            new PlaceHolder {
                UserId = 10,
                Id = 96,
                Title = "quaerat velit veniam amet cupiditate aut numquam ut sequi",
                Body = "in non odio excepturi sint eum\nlabore voluptates vitae quia qui et\ninventore itaque rerum\nveniam non exercitationem delectus aut"
            },
            new PlaceHolder {
                UserId = 10,
                Id = 97,
                Title = "quas fugiat ut perspiciatis vero provident",
                Body = "eum non blanditiis soluta porro quibusdam voluptas\nvel voluptatem qui placeat dolores qui velit aut\nvel inventore aut cumque culpa explicabo aliquid at\nperspiciatis est et voluptatem dignissimos dolor itaque sit nam"
            },
            new PlaceHolder {
                UserId = 10,
                Id = 98,
                Title = "laboriosam dolor voluptates",
                Body = "doloremque ex facilis sit sint culpa\nsoluta assumenda eligendi non ut eius\nsequi ducimus vel quasi\nveritatis est dolores"
            },
            new PlaceHolder {
                UserId = 10,
                Id = 99,
                Title = "temporibus sit alias delectus eligendi possimus magni",
                Body = "quo deleniti praesentium dicta non quod\naut est molestias\nmolestias et officia quis nihil\nitaque dolorem quia"
            },
            new PlaceHolder {
                UserId = 10,
                Id = 100,
                Title = "at nam consequatur ea labore ea harum",
                Body = "cupiditate quo est a modi nesciunt soluta\nipsa voluptas error itaque dicta in\nautem qui minus magnam et distinctio eum\naccusamus ratione error aut"
            }
        };

        
        static public List<PlaceHolder> GetByUserId(int userId)
        {
            System.Console.WriteLine(AllResources);
            return AllResources.Where(placeHolder => placeHolder.UserId == userId).ToList();
        }

        static public List<PlaceHolder> GetById(int id)
        {
            // Given the static immuteable nature of our list that contains all ids from 1 to 100, it would be more 
            // efficient to just return the array value at index id + 1, but in a more real life scenario where this 
            // data isn't so neat and tidy, where ids might be missing, out of order, and possibly even duplicated,
            // this will guarantee that we get them all.
            return AllResources.Where(placeHolder => placeHolder.Id == id).ToList();
        }
    }
}
