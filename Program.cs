
// Ceci est le fichier de test des différents patterns.
// Leur code se trouve dans les dossiers respectifs.


// Creational Patterns


// // Le Singleton, ex: connexion à une DB

// using ConsoleApp1.src.CreationalPatterns.Singleton;

// var settings = AppSettings.getInstance();
// settings.Set("app_name", "design patterns");
// settings.Set("app_creator", "Toto Santos");

// Test.Run();




// // Abstract Factory
// using ConsoleApp1.src.CreationalPatterns.AbstractFactory.good;

// var os = OperatingSystemType.Mac;
// IUIComponentFactory uiComponentFactory;


// if (os == OperatingSystemType.Windows)
//     uiComponentFactory = new WindowsUIComponentFactory();

// else
//     uiComponentFactory = new MacUIComponentFactory();

// var userSettingsForm = new UserSettingsForm();
// userSettingsForm.Render(uiComponentFactory);





// // Builder, créer des objets de plus en plus complexe par étape

// using ConsoleApp1.src.CreationalPatterns.Builder;

// // Sans director
// var carBuilder = new CarBuilder();
// carBuilder.SetCarType(CarType.Sports).SetIsConvertible(false); // etc pour ajouter de la complexité

// // Avec director
// using ConsoleApp1.src.CreationalPatterns.Builder;

// var carBuilder = new CarBuilder();
// var director = new Director();
// director.ConstructSportsCar(carBuilder);
// var sportsCar = carBuilder.GetCar();



// Structural patterns

// // Decorator

// using ConsoleApp1.src.StructuralPatterns.Decorator.good;

// var url = "https://google.cloud.com";
// var data = "SomeRandomData";
// var compress = true;
// var encrypt = true;

// Data cloudData = new CloudData(url);

// // Ca enveloppe, et ça sera exécuté dans l'ordre INVERSE où on l'a enveloppé
// if (encrypt)
//     cloudData = new EncryptionDecorator(cloudData);
// if (compress)
//     cloudData = new CompressionDecorator(cloudData);

// cloudData.Save(data);



// // Facade
// using ConsoleApp1.src.StructuralPatterns.Facade;

// var orderReq = new OrderRequest();
// var orderService = new OrderService();
// orderService.Order(orderReq);



// // Flyweight
// using ConsoleApp1.src.StructuralPatterns.Flyweight;

// var cropService = new CropService(new CropIconFactory());

// foreach (var crop in cropService.GetCrops())
//     crop.Render();



// // Proxy
// using ConsoleApp1.src.StructuralPatterns.Proxy.good;

// var videoList = new VideoList();
// String[] videoIds = {"slfjh","zeruiy","5668","sdfsdf4675"};

// foreach (var videoId in videoIds)
//     videoList.Add(new YoutubeVideoProxy(videoId));

// videoList.Watch("5668");



// // Bridge
// using ConsoleApp1.src.StructuralPatterns.Bridge.Good;

// var lgRemoteControl = new RemoteControl(new LGRadio());
// lgRemoteControl.TurnOn();
// lgRemoteControl.TurnOff();

// var sonyAdvancedRemoteControl = new AdvancedRemote(new SonyRadio());
// sonyAdvancedRemoteControl.TurnOn();
// sonyAdvancedRemoteControl.SetChannel(3);



// // Adapter
// using ConsoleApp1.src.StructuralPatterns.Adapter;
// using ConsoleApp1.src.StructuralPatterns.Adapter.Package;

// var videoEditor = new VideoEditor(new Video());
// videoEditor.ApplyColor(new RainbowColorComposition(new Rainbow()));



// // Composite

// using ConsoleApp1.src.StructuralPatterns.Composite;

// var package = new Box();
// var box1 = new Box();
// box1.Add(new Microphone());

// // contains box3 and box4
// var box2 = new Box();

// var box3 = new Box();
// box3.Add(new Mouse());

// var box4 = new Box();
// box4.Add(new Keyboard());

// box2.Add(box3);
// box2.Add(box4);

// package.Add(box1);
// package.Add(box2);

// System.Console.WriteLine("Total price of package: " + package.getPrice());






// Behavioral



// // Interpreter
// using ConsoleApp1.src.Patterns.Interpreter;

// string input = "1 + 2 * 3";

// Context context = new Context();
// Interpreter interpreter = new Interpreter(context);
// int result = interpreter.Interpret(input);
// System.Console.WriteLine("Result: " + result);

// // Visitor
// using ConsoleApp1.src.Patterns.Visitor.good;

// var clients = new List<Client> {
//     new RetailClient("Debinhams", "team@debinhams.com"),
//     new RestaurantClient("Johnny's wicked pizza", "johnnypizza@gmail.com"),
//     new LawClient("Harris&Harris", "contact@harrisandharris.com")
// };

// foreach (var client in clients) {
//     client.Accept(new EmailVisitor());
//     client.Accept(new PDFExportVisitor());
// }

// // Chain of Responsibility
// using ConsoleApp1.src.Patterns.ChainOfResponsibility.good;

// var validator = new Validator();
// var authenticator = new Authenticator();
// var logger = new Logger();

// validator.SetNext(authenticator).SetNext(logger);

// var server = new WebServer(validator);
// var req = new HttpRequest("danny", "123");
// server.Handle(req);

// // Mediator
// using ConsoleApp1.src.Patterns.Mediator.Regular;

// var postsDialogBox = new PostDialogBox();
// postsDialogBox.SimulateUserInteraction();

// // Observer
// using ConsoleApp1.src.Patterns.Observer;

// DataSource datasource = new DataSource();
// Sheet2 sheet2 = new Sheet2(datasource);
// BarChart barChart = new BarChart(datasource);

// datasource.AddObserver(sheet2);
// datasource.AddObserver(barChart);

// datasource.SetValues(new List<int>());

// // Template

// using ConsoleApp1.src.Patterns.Template.good;
// var teaBeverage = new Tea();
// teaBeverage.Prepare();

// using ConsoleApp1.src.Patterns.Template.ThruStrategy;
// var beverageMaker = new BeverageMaker(new Coffee());
// beverageMaker.MakeBeverage();

// // Undoable Command
// using ConsoleApp1.src.Patterns.Command.undoable;
// using ConsoleApp1.src.SOLID.D;

// var htmldoc = new HtmlDocument();
// var history = new History();
// htmldoc.Content = "Hello there";
// System.Console.WriteLine(htmldoc.Content);

// var italicCommand = new ItalicCommand(htmldoc, history);
// italicCommand.Execute();
// System.Console.WriteLine(htmldoc.Content);

// var undoCommand = new UndoCommand(history);
// undoCommand.Execute();
// System.Console.WriteLine(htmldoc.Content);

// Command
// using ConsoleApp1.src.Patterns.Command.good;

// var light = new Light();
// var remote = new RemoteControl(new TurnOnCommand(light));
// remote.PressButton(); // Light is now on

// remote.SetCommand(new DimCommand(light)); // remote will now control dimming light
// remote.PressButton(); // Light is dimmed !

// Memento
// using ConsoleApp1.src.Patterns.Memento;

// var editor = new Editor();
// var history = new Caretaker(editor);
// history.Backup();
// editor.title = "Test";
// history.Backup();
// editor.content = "Blableblibloblu";
// history.Backup();
// editor.title = "A life in a fish";

// System.Console.WriteLine("Title : " + editor.title);
// System.Console.WriteLine("Content : " + editor.content);

// history.ShowHistory();

//Encapsulation
// using ConsoleApp1.src.OopPrinciples.Encapsulation;

// BadBankAccount badBankAccount = new BadBankAccount();
// badBankAccount.balance = 100;

// System.Console.WriteLine(badBankAccount.balance);

// BankAccount bankAccount = new BankAccount(100);
// System.Console.WriteLine(bankAccount.GetBalance());

// bankAccount.Deposit(50);
// System.Console.WriteLine(bankAccount.GetBalance());

// bankAccount.Withdraw(130);
// System.Console.WriteLine(bankAccount.GetBalance());