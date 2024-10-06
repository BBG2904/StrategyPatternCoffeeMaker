// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using StrategyPatternCoffeeMaker;
using StrategyPatternCoffeeMaker.Strategy_Implementation;
using StrategyPatternCoffeeMaker.Strategy_Interface;

//Without DI
var Context = new CoffeeMakerContext();
var milk = new Milk();
Context.ChooseOption(milk);
Context.DoOperation();

var tea = new Tea();
Context.ChooseOption(tea);
Context.DoOperation();

var coffee = new Coffee();
Context.ChooseOption(coffee);
Context.DoOperation();

//With DI
var serviceProvider = new ServiceCollection()
    .AddScoped<ICoffeeMaker, Coffee>()
    .AddScoped<ICoffeeMaker, Tea>()
    .AddScoped<ICoffeeMaker, Milk>()
    .AddScoped<CoffeeMakerContext>()
    .BuildServiceProvider();

var diContext = serviceProvider.GetService<CoffeeMakerContext>();
var milkDI = serviceProvider.GetServices<ICoffeeMaker>();
var milkOption =milkDI.First(x => x.GetType() == typeof(Milk));
diContext.ChooseOption(milkOption);
diContext.DoOperation();

var TeaDI = serviceProvider.GetServices<ICoffeeMaker>();
var teaOption = milkDI.First(x => x.GetType() == typeof(Tea));
diContext.ChooseOption(teaOption);
diContext.DoOperation();

var coffeeDI = serviceProvider.GetServices<ICoffeeMaker>();
var coffeeOption = coffeeDI.First(x => x.GetType() == typeof(Coffee));
diContext.ChooseOption(coffeeOption);
diContext.DoOperation();
