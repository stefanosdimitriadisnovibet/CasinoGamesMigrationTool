using CasinoGamesMigrationTool.Console;
using CasinoGamesMigrationTool.Console.Models;
using CasinoGamesMigrationTool.Domain;
using CasinoGamesMigrationTool.XmlHandler.KingSolomons.Desktop.PlayTech;
using CasinoGamesMigrationTool.XmlHandler.KingSolomons.Mobile.PlayTech;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.Evolution;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.Iforium;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.Microgaming;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.NetEnt;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.NYX;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.ScientificGames;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.Evolution;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.Iforium;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.Microgaming;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.NetEnt;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.NYX;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.ScientificGames;
using CasinoGamesMigrationTool.XmlParser.KingSolomons.Desktop.PlayTech;
using CasinoGamesMigrationTool.XmlParser.KingSolomons.Mobile.PlayTech;
using CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.Evolution;
using CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.Iforium;
using CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.Microgaming;
using CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.NetEnt;
using CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.NYX;
using CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.ScientificGames;
using CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.Evolution;
using CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.Iforium;
using CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.Microgaming;
using CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.NetEnt;
using CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.NYX;
using CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.ScientificGames;
using CsvHelper;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Console;

namespace CasinoGamesMigrationTool
{
	public static class Program
	{
		public static string LogFilePath = $"./logs/{DateTime.UtcNow.Month}.{DateTime.UtcNow.Day} {Process.GetCurrentProcess().Id}.log";
		public static string DatabaseFilePath = @"C:\Users\sdimitriadis\Desktop\CasinoGamesMigrationTool\CasinoGamesMigrationTool.Console\CasinoGames.csv";

		public static async Task Main(string[] args)
		{
			#region Xml

			//#region KingSolomons

			//#region Desktop
			//XmlKingSolomonsDesktopPlayTechResponse xmlKingSolomonsDesktopPlayTechResponse = XmlKingSolomonsDesktopPlayTechParser.ParseXml();

			//XmlHandler.KingSolomons.Desktop.PlayTech.XmlKingSolomonsDesktopPlayTechGame[] xmlKingSolomonsDesktopPlayTechGames = xmlKingSolomonsDesktopPlayTechResponse.HandleGames();
			////XmlHandler.KingSolomons.Desktop.PlayTech.XmlKingSolomonsDesktopPlayTechGameLanguages[] xmlKingSolomonsDesktopPlayTechGameLanguages = xmlKingSolomonsDesktopPlayTechResponse.HandleGameLanguages();
			//////XmlHandler.KingSolomons.Desktop.PlayTech.XmlKingSolomonsDesktopPlayTechJackpotGame[] xmlKingSolomonsDesktopPlayTechJackpotGames = xmlKingSolomonsDesktopPlayTechResponse.HandleJacktopGames();
			//#endregion Desktop

			//#region Mobile
			//XmlKingSolomonsMobilePlayTechResponse xmlKingSolomonsMobilePlayTechResponse = XmlKingSolomonsMobilePlayTechParser.ParseXml();

			//XmlHandler.KingSolomons.Mobile.PlayTech.XmlKingSolomonsMobilePlayTechGame[] xmlKingSolomonsMobilePlayTechGames = xmlKingSolomonsMobilePlayTechResponse.HandleGames();
			////XmlHandler.KingSolomons.Mobile.PlayTech.XmlKingSolomonsMobilePlayTechGameLanguage[] xmlKingSolomonsMobilePlayTechGameLanguages = xmlKingSolomonsMobilePlayTechResponse.HandleGameLanguages();
			//////XmlHandler.KingSolomons.Mobile.PlayTech.XmlKingSolomonsMobilePlayTechJackpotGame[] xmlKingSolomonsMobilePlayTechJackpotGames = xmlKingSolomonsMobilePlayTechResponse.HandleJackpotGames();
			//#endregion Mobile

			//#endregion KingSolomons

			//#region NoviCasino

			////#region Desktop
			////XmlNoviCasinoDesktopEvolutionResponse xmlNoviCasinoDesktopEvolutionResponse = XmlNoviCasinoDesktopEvolutionParser.ParseXml();

			////XmlHandler.NoviCasino.Desktop.Evolution.XmlNoviCasinoDesktopEvolutionGame[] xmlNoviCasinoDesktopEvolutionGames = xmlNoviCasinoDesktopEvolutionResponse.HandleGames();
			////XmlHandler.NoviCasino.Desktop.Evolution.XmlNoviCasinoDesktopEvolutionGameLanguages[] xmlNoviCasinoDesktopEvolutionGameLanguages = xmlNoviCasinoDesktopEvolutionResponse.HandleGameLanguages();

			////XmlNoviCasinoDesktopIforiumResponse xmlNoviCasinoDesktopIforiumResponse = XmlNoviCasinoDesktopIforiumParser.ParseXml();

			////XmlHandler.NoviCasino.Desktop.Iforium.XmlNoviCasinoDesktopIforiumGame[] xmlNoviCasinoDesktopIforiumGames = xmlNoviCasinoDesktopIforiumResponse.HandleGames();
			////XmlHandler.NoviCasino.Desktop.Iforium.XmlNoviCasinoDesktopIforiumGameLanguages[] xmlNoviCasinoDesktopIforiumGameLanguages = xmlNoviCasinoDesktopIforiumResponse.HandleGameLanguages();

			////XmlNoviCasinoDesktopMicrogamingResponse xmlNoviCasinoDesktopMicrogamingResponse = XmlNoviCasinoDesktopMicrogamingParser.ParseXml();

			////XmlHandler.NoviCasino.Desktop.Microgaming.XmlNoviCasinoDesktopMicrogamingGame[] xmlNoviCasinoDesktopMicrogamingGames = xmlNoviCasinoDesktopMicrogamingResponse.HandleGames();
			////XmlHandler.NoviCasino.Desktop.Microgaming.XmlNoviCasinoDesktopMicrogamingGameLanguages[] xmlNoviCasinoDesktopMicrogamingGameLanguages = xmlNoviCasinoDesktopMicrogamingResponse.HandleGameLanguages();
			//////XmlHandler.NoviCasino.Desktop.Microgaming.XmlNoviCasinoDesktopMicrogamingJackpotGame[] xmlNoviCasinoDesktopMicrogamingJackpotGames = xmlNoviCasinoDesktopMicrogamingResponse.HandleJacktopGames();

			////XmlNoviCasinoDesktopNetEntResponse xmlNoviCasinoDesktopNetEntResponse = XmlNoviCasinoDesktopNetEntParser.ParseXml();

			////XmlHandler.NoviCasino.Desktop.NetEnt.XmlNoviCasinoDesktopNetEntGame[] xmlNoviCasinoDesktopNetEntGames = xmlNoviCasinoDesktopNetEntResponse.HandleGames();
			////XmlHandler.NoviCasino.Desktop.NetEnt.XmlNoviCasinoDesktopNetEntGameLanguages[] xmlNoviCasinoDesktopNetEntGameLanguages = xmlNoviCasinoDesktopNetEntResponse.HandleGameLanguages();
			//////XmlHandler.NoviCasino.Desktop.NetEnt.XmlNoviCasinoDesktopNetEntJackpotGame[] xmlNoviCasinoDesktopNetEntJackpotGames = xmlNoviCasinoDesktopNetEntResponse.HandleJacktopGames();

			////XmlNoviCasinoDesktopScientificGamesResponse xmlNoviCasinoDesktopScientificGamesResponse = XmlNoviCasinoDesktopScientificGamesParser.ParseXml();

			////XmlHandler.NoviCasino.Desktop.ScientificGames.XmlNoviCasinoDesktopScientificGamesGame[] xmlNoviCasinoDesktopScientificGames = xmlNoviCasinoDesktopScientificGamesResponse.HandleGames();
			////XmlHandler.NoviCasino.Desktop.ScientificGames.XmlNoviCasinoDesktopScientificGamesGameLanguages[] xmlNoviCasinoDesktopScientificGamesGameLanguages = xmlNoviCasinoDesktopScientificGamesResponse.HandleGameLanguages();
			////#endregion Desktop

			////#region Mobile
			////XmlNoviCasinoMobileEvolutionResponse xmlNoviCasinoMobileEvolutionResponse = XmlNoviCasinoMobileEvolutionParser.ParseXml();

			////XmlHandler.NoviCasino.Mobile.Evolution.XmlNoviCasinoMobileEvolutionGame[] xmlNoviCasinoMobileEvolutionGames = xmlNoviCasinoMobileEvolutionResponse.HandleGames();
			////XmlHandler.NoviCasino.Mobile.Evolution.XmlNoviCasinoMobileEvolutionGameLanguages[] xmlNoviCasinoMobileEvolutionGameLanguages = xmlNoviCasinoMobileEvolutionResponse.HandleGameLanguages();

			////XmlNoviCasinoMobileIforiumResponse xmlNoviCasinoMobileIforiumResponse = XmlNoviCasinoMobileIforiumParser.ParseXml();

			////XmlHandler.NoviCasino.Mobile.Iforium.XmlNoviCasinoMobileIforiumGame[] xmlNoviCasinoMobileIforiumGames = xmlNoviCasinoMobileIforiumResponse.HandleGames();
			////XmlHandler.NoviCasino.Mobile.Iforium.XmlNoviCasinoMobileIforiumGameLanguages[] xmlNoviCasinoMobileIforiumGameLanguages = xmlNoviCasinoMobileIforiumResponse.HandleGameLanguages();

			////XmlNoviCasinoMobileMicrogamingResponse xmlNoviCasinoMobileMicrogamingResponse = XmlNoviCasinoMobileMicrogamingParser.ParseXml();

			////XmlHandler.NoviCasino.Mobile.Microgaming.XmlNoviCasinoMobileMicrogamingGame[] xmlNoviCasinoMobileMicrogamingGames = xmlNoviCasinoMobileMicrogamingResponse.HandleGames();
			////XmlHandler.NoviCasino.Mobile.Microgaming.XmlNoviCasinoMobileMicrogamingGameLanguages[] xmlNoviCasinoMobileMicrogamingGameLanguages = xmlNoviCasinoMobileMicrogamingResponse.HandleGameLanguages();
			//////XmlHandler.NoviCasino.Mobile.Microgaming.XmlNoviCasinoMobileMicrogamingJackpotGame[] xmlNoviCasinoMobileMicrogamingJackpotGames = xmlNoviCasinoMobileMicrogamingResponse.HandleJacktopGames();

			////XmlNoviCasinoMobileNetEntResponse xmlNoviCasinoMobileNetEntResponse = XmlNoviCasinoMobileNetEntParser.ParseXml();

			////XmlHandler.NoviCasino.Mobile.NetEnt.XmlNoviCasinoMobileNetEntGame[] xmlNoviCasinoMobileNetEntGames = xmlNoviCasinoMobileNetEntResponse.HandleGames();
			////XmlHandler.NoviCasino.Mobile.NetEnt.XmlNoviCasinoMobileNetEntGameLanguages[] xmlNoviCasinoMobileNetEntGameLanguages = xmlNoviCasinoMobileNetEntResponse.HandleGameLanguages();

			////XmlNoviCasinoMobileScientificGamesResponse xmlNoviCasinoMobileScientificGamesResponse = XmlNoviCasinoMobileScientificGamesParser.ParseXml();

			////XmlHandler.NoviCasino.Mobile.ScientificGames.XmlNoviCasinoMobileScientificGamesGame[] xmlNoviCasinoMobileScientificGames = xmlNoviCasinoMobileScientificGamesResponse.HandleGames();
			////XmlHandler.NoviCasino.Mobile.ScientificGames.XmlNoviCasinoMobileScientificGamesGameLanguages[] xmlNoviCasinoMobileScientificGamesGameLanguages = xmlNoviCasinoMobileScientificGamesResponse.HandleGameLanguages();
			////#endregion Mobile

			//#endregion NoviCasino

			#region Novibet

			#region Desktop
			//XmlNovibetDesktopEdictResponse xmlNovibetDesktopEdictResponse = XmlNovibetDesktopEdictParser.ParseXml();

			//XmlHandler.Novibet.Desktop.Edict.XmlNovibetDesktopEdictGame[] xmlNovibetDesktopEdictGames = xmlNovibetDesktopEdictResponse.HandleGames();
			//XmlHandler.Novibet.Desktop.Edict.XmlNovibetDesktopEdictGameLanguages[] xmlNovibetDesktopEdictGameLanguages = xmlNovibetDesktopEdictResponse.HandleGameLanguages();

			XmlNovibetDesktopEvolutionResponse xmlNovibetDesktopEvolutionResponse = XmlNovibetDesktopEvolutionParser.ParseXml();

			XmlHandler.Novibet.Desktop.Evolution.XmlNovibetDesktopEvolutionGame[] xmlNovibetDesktopEvolutionGames = xmlNovibetDesktopEvolutionResponse.HandleGames();
			//XmlHandler.Novibet.Desktop.Evolution.XmlNovibetDesktopEvolutionGameLanguages[] xmlNovibetDesktopEvolutionGameLanguages = xmlNovibetDesktopEvolutionResponse.HandleGameLanguages();

			XmlNovibetDesktopIforiumResponse xmlNovibetDesktopIforiumResponse = XmlNovibetDesktopIforiumParser.ParseXml();

			XmlHandler.Novibet.Desktop.Iforium.XmlNovibetDesktopIforiumGame[] xmlNovibetDesktopIforiumGames = xmlNovibetDesktopIforiumResponse.HandleGames();
			//XmlHandler.Novibet.Desktop.Iforium.XmlNovibetDesktopIforiumGameLanguages[] xmlNovibetDesktopIforiumGameLanguages = xmlNovibetDesktopIforiumResponse.HandleGameLanguages();

			XmlNovibetDesktopMicrogamingResponse xmlNovibetDesktopMicrogamingResponse = XmlNovibetDesktopMicrogamingParser.ParseXml();

			XmlHandler.Novibet.Desktop.Microgaming.XmlNovibetDesktopMicrogamingGame[] xmlNovibetDesktopMicrogamingGames = xmlNovibetDesktopMicrogamingResponse.HandleGames();
			//XmlHandler.Novibet.Desktop.Microgaming.XmlNovibetDesktopMicrogamingGameLanguages[] xmlNovibetDesktopMicrogamingGameLanguages = xmlNovibetDesktopMicrogamingResponse.HandleGameLanguages();
			////XmlHandler.Novibet.Desktop.Microgaming.XmlNovibetDesktopMicrogamingJackpotGame[] xmlNovibetDesktopMicrogamingJackpotGames = xmlNovibetDesktopMicrogamingResponse.HandleJacktopGames();

			XmlNovibetDesktopNetEntResponse xmlNovibetDesktopNetEntResponse = XmlNovibetDesktopNetEntParser.ParseXml();

			XmlHandler.Novibet.Desktop.NetEnt.XmlNovibetDesktopNetEntGame[] xmlNovibetDesktopNetEntGames = xmlNovibetDesktopNetEntResponse.HandleGames();
			//XmlHandler.Novibet.Desktop.NetEnt.XmlNovibetDesktopNetEntGameLanguages[] xmlNovibetDesktopNetEntGameLanguages = xmlNovibetDesktopNetEntResponse.HandleGameLanguages();
			////XmlHandler.Novibet.Desktop.NetEnt.XmlNovibetDesktopNetEntJackpotGame[] xmlNovibetDesktopNetEntJackpotGames = xmlNovibetDesktopNetEntResponse.HandleJacktopGames();

			XmlNovibetDesktopNYXResponse xmlNovibetDesktopNYXResponse = XmlNovibetDesktopNYXParser.ParseXml();

			XmlHandler.Novibet.Desktop.NYX.XmlNovibetDesktopNYXGame[] xmlNovibetDesktopNYXGames = xmlNovibetDesktopNYXResponse.HandleGames();
			//XmlHandler.Novibet.Desktop.NYX.XmlNovibetDesktopNYXGameLanguages[] xmlNovibetDesktopNYXGameLanguages = xmlNovibetDesktopNYXResponse.HandleGameLanguages();

			//XmlNovibetDesktopPlayNGoResponse xmlNovibetDesktopPlayNGoResponse = XmlNovibetDesktopPlayNGoParser.ParseXml();

			//XmlHandler.Novibet.Desktop.PlayNGo.XmlNovibetDesktopPlayNGoGame[] xmlNovibetDesktopPlayNGoGames = xmlNovibetDesktopPlayNGoResponse.HandleGames();
			//XmlHandler.Novibet.Desktop.PlayNGo.XmlNovibetDesktopPlayNGoGameLanguages[] xmlNovibetDesktopPlayNGoGameLanguages = xmlNovibetDesktopPlayNGoResponse.HandleGameLanguages();

			//XmlNovibetDesktopRedTigerResponse xmlNovibetDesktopRedTigerResponse = XmlNovibetDesktopRedTigerParser.ParseXml();

			//XmlHandler.Novibet.Desktop.RedTiger.XmlNovibetDesktopRedTigerGame[] xmlNovibetDesktopRedTigerGames = xmlNovibetDesktopRedTigerResponse.HandleGames();
			//XmlHandler.Novibet.Desktop.RedTiger.XmlNovibetDesktopRedTigerGameLanguages[] xmlNovibetDesktopRedTigerGameLanguages = xmlNovibetDesktopRedTigerResponse.HandleGameLanguages();

			XmlNovibetDesktopScientificGamesResponse xmlNovibetDesktopScientificGamesResponse = XmlNovibetDesktopScientificGamesParser.ParseXml();

			XmlHandler.Novibet.Desktop.ScientificGames.XmlNovibetDesktopScientificGamesGame[] xmlNovibetDesktopScientificGamesGames = xmlNovibetDesktopScientificGamesResponse.HandleGames();
			//XmlHandler.Novibet.Desktop.ScientificGames.XmlNovibetDesktopScientificGamesGameLanguages[] xmlNovibetDesktopScientificGamesGameLanguages = xmlNovibetDesktopScientificGamesResponse.HandleGameLanguages();

			#endregion Desktop

			#region Mobile
			//XmlNovibetMobileEdictResponse xmlNovibetMobileEdictResponse = XmlNovibetMobileEdictParser.ParseXml();

			//XmlHandler.Novibet.Mobile.Edict.XmlNovibetMobileEdictGame[] xmlNovibetMobileEdictGames = xmlNovibetMobileEdictResponse.HandleGames();
			//XmlHandler.Novibet.Mobile.Edict.XmlNovibetMobileEdictGameLanguages[] xmlNovibetMobileEdictGameLanguages = xmlNovibetMobileEdictResponse.HandleGameLanguages();

			XmlNovibetMobileEvolutionResponse xmlNovibetMobileEvolutionResponse = XmlNovibetMobileEvolutionParser.ParseXml();

			XmlHandler.Novibet.Mobile.Evolution.XmlNovibetMobileEvolutionGame[] xmlNovibetMobileEvolutionGames = xmlNovibetMobileEvolutionResponse.HandleGames();
			//XmlHandler.Novibet.Mobile.Evolution.XmlNovibetMobileEvolutionGameLanguages[] xmlNovibetMobileEvolutionGameLanguages = xmlNovibetMobileEvolutionResponse.HandleGameLanguages();

			XmlNovibetMobileIforiumResponse xmlNovibetMobileIforiumResponse = XmlNovibetMobileIforiumParser.ParseXml();

			XmlHandler.Novibet.Mobile.Iforium.XmlNovibetMobileIforiumGame[] xmlNovibetMobileIforiumGames = xmlNovibetMobileIforiumResponse.HandleGames();
			//XmlHandler.Novibet.Mobile.Iforium.XmlNovibetMobileIforiumGameLanguages[] xmlNovibetMobileIforiumGameLanguages = xmlNovibetMobileIforiumResponse.HandleGameLanguages();

			XmlNovibetMobileMicrogamingResponse xmlNovibetMobileMicrogamingResponse = XmlNovibetMobileMicrogamingParser.ParseXml();

			XmlHandler.Novibet.Mobile.Microgaming.XmlNovibetMobileMicrogamingGame[] xmlNovibetMobileMicrogamingGames = xmlNovibetMobileMicrogamingResponse.HandleGames();
			//XmlHandler.Novibet.Mobile.Microgaming.XmlNovibetMobileMicrogamingGameLanguages[] xmlNovibetMobileMicrogamingGameLanguages = xmlNovibetMobileMicrogamingResponse.HandleGameLanguages();
			//XmlHandler.Novibet.Mobile.Microgaming.XmlNovibetMobileMicrogamingJackpotGame[] xmlNovibetMobileMicrogamingJackpotGames = xmlNovibetMobileMicrogamingResponse.HandleJacktopGames();

			XmlNovibetMobileNetEntResponse xmlNovibetMobileNetEntResponse = XmlNovibetMobileNetEntParser.ParseXml();

			XmlHandler.Novibet.Mobile.NetEnt.XmlNovibetMobileNetEntGame[] xmlNovibetMobileNetEntGames = xmlNovibetMobileNetEntResponse.HandleGames();
			//XmlHandler.Novibet.Mobile.NetEnt.XmlNovibetMobileNetEntGameLanguages[] xmlNovibetMobileNetEntGameLanguages = xmlNovibetMobileNetEntResponse.HandleGameLanguages();

			XmlNovibetMobileNYXResponse xmlNovibetMobileNYXResponse = XmlNovibetMobileNYXParser.ParseXml();

			XmlHandler.Novibet.Mobile.NYX.XmlNovibetMobileNYXGame[] xmlNovibetMobileNYXGames = xmlNovibetMobileNYXResponse.HandleGames();
			//XmlHandler.Novibet.Mobile.NYX.XmlNovibetMobileNYXGameLanguages[] xmlNovibetMobileNYXGameLanguages = xmlNovibetMobileNYXResponse.HandleGameLanguages();

			//XmlNovibetMobilePlayNGoResponse xmlNovibetMobilePlayNGoResponse = XmlNovibetMobilePlayNGoParser.ParseXml();

			//XmlHandler.Novibet.Mobile.PlayNGo.XmlNovibetMobilePlayNGoGame[] xmlNovibetMobilePlayNGoGames = xmlNovibetMobilePlayNGoResponse.HandleGames();
			//XmlHandler.Novibet.Mobile.PlayNGo.XmlNovibetMobilePlayNGoGameLanguages[] xmlNovibetMobilePlayNGoGameLanguages = xmlNovibetMobilePlayNGoResponse.HandleGameLanguages();

			//XmlNovibetMobileRedTigerResponse xmlNovibetMobileRedTigerResponse = XmlNovibetMobileRedTigerParser.ParseXml();

			//XmlHandler.Novibet.Mobile.RedTiger.XmlNovibetMobileRedTigerGame[] xmlNovibetMobileRedTigerGames = xmlNovibetMobileRedTigerResponse.HandleGames();
			//XmlHandler.Novibet.Mobile.RedTiger.XmlNovibetMobileRedTigerGameLanguages[] xmlNovibetMobileRedTigerGameLanguages = xmlNovibetMobileRedTigerResponse.HandleGameLanguages();

			XmlNovibetMobileScientificGamesResponse xmlNovibetMobileScientificGamesResponse = XmlNovibetMobileScientificGamesParser.ParseXml();

			XmlHandler.Novibet.Mobile.ScientificGames.XmlNovibetMobileScientificGamesGame[] xmlNovibetMobileScientificGamesGames = xmlNovibetMobileScientificGamesResponse.HandleGames();
			//XmlHandler.Novibet.Mobile.ScientificGames.XmlNovibetMobileScientificGamesGameLanguages[] xmlNovibetMobileScientificGamesGameLanguages = xmlNovibetMobileScientificGamesResponse.HandleGameLanguages();
			#endregion Mobile

			#endregion Novibet

			#endregion Xml

			#region CMS

			//#region Desktop

			//XmlCMSDesktopResponse xmlCMSDesktopResponse = XmlCMSDesktopParser.ParseXml();

			//XmlCMSDesktopGame[] xmlCMSDesktopGames = xmlCMSDesktopResponse.HandleGames();

			//#endregion Desktop

			//#region Mobile

			//XmlCMSMobileResponse xmlCMSMobileResponse = XmlCMSMobileParser.ParseXml();

			//XmlCMSMobileGame[] xmlCMSMobileGames = xmlCMSMobileResponse.HandleGames();

			//#endregion Mobile

			#endregion CMS

			#region Database

			//UserCasinoGames[] games = DatabaseHandler.DatabaseHandler.HandleGames();

			#endregion Database

			var games = default(CsvUserCasinoGames[]);

			#region CSV
			using (var reader = new StreamReader(DatabaseFilePath))
			using (var csv = new CsvReader(reader))
			{
				games = csv.GetRecords<CsvUserCasinoGames>().ToArray();

				WriteLine($"Total games in csv: [{games.Count()}]");
			}
			#endregion CSV

			if (games != null && games.Length > 0)
			{
				await Login();

				await CreateGames(
				games,
				xmlNovibetDesktopEvolutionGames.Select(x => x.Sysname).ToArray(),
				xmlNovibetMobileEvolutionGames.Select(x => x.Sysname).ToArray(),
				xmlNovibetDesktopScientificGamesGames.Select(x => x.Sysname).ToArray(),
				xmlNovibetMobileScientificGamesGames.Select(x => x.Sysname).ToArray(),
				xmlNovibetDesktopNetEntGames.Select(x => x.Sysname).ToArray(),
				xmlNovibetMobileNetEntGames.Select(x => x.Sysname).ToArray(),
				xmlKingSolomonsDesktopPlayTechGames.Select(x => x.Sysname).ToArray(),
				xmlKingSolomonsMobilePlayTechGames.Select(x => x.Sysname).ToArray(),
				xmlNovibetDesktopNYXGames.Select(x => x.Sysname).ToArray(),
				xmlNovibetMobileNYXGames.Select(x => x.Sysname).ToArray(),
				xmlNovibetDesktopMicrogamingGames.ToArray(),
				xmlNovibetMobileMicrogamingGames.ToArray());
			}

			var cmsDesktop = XmlParser.CMS.New.CMSDesktopParser.ParseXml();
			var cmsMobile = XmlParser.CMS.New.CMSMobileParser.ParseXml();

			//using var context = new BBCasinoGamesContext();

			//var games = context.Games.ToArray();

			foreach (var game in games)
			{
				//var sysname = game.Name;

				//var jsonGame = cmsDesktop.Property1.SelectMany(x => x.Games).FirstOrDefault(x => x.Sysname == sysname);

				//if (jsonGame == null)
				//{
				//	jsonGame = cmsMobile.Property1.SelectMany(x => x.Games).FirstOrDefault(x => x.Sysname == sysname);
				//}

				//if (jsonGame == null)
				//{
				//	File.AppendAllText(LogFilePath, $"{JsonSerializer.Serialize(new { Db = game, Json = jsonGame })}\n");
				//}

				//var heroImage = jsonGame.HeroImage;
				//var defaultImage = jsonGame.DefaultImage;
				//var liveImage = jsonGame.LiveImage;



				//var contentType = "multipart/form-data";

				//Stream stream = new MemoryStream();

				//stream.Write()
			}

			WriteLine("Application ended...");
			WriteLine("Close the application");
			ReadLine();
		}

		private static async Task CreateGames(
			CsvUserCasinoGames[] games,
			string[] xmlNovibetDesktopEvolutionGames,
			string[] xmlNovibetMobileEvolutionGames,
			string[] xmlNovibetDesktopScientificGamesGames,
			string[] xmlNovibetMobileScientificGamesGames,
			string[] xmlNovibetDesktopNetEntGames,
			string[] xmlNovibetMobileNetEntGames,
			string[] xmlKingSolomonsDesktopPlayTechGames,
			string[] xmlKingSolomonsMobilePlayTechGames,
			string[] xmlNovibetDesktopNYXGames,
			string[] xmlNovibetMobileNYXGames,
			XmlHandler.Novibet.Desktop.Microgaming.XmlNovibetDesktopMicrogamingGame[] xmlNovibetDesktopMicrogamingGames,
			XmlHandler.Novibet.Mobile.Microgaming.XmlNovibetMobileMicrogamingGame[] xmlNovibetMobileMicrogamingGames)
		{
			var getProvidersHttpResponse = await MyHttpClient._HttpClient.GetAsync($"{MyHttpClient.BaseUrl}/providers");

			var getProvidersContent = await getProvidersHttpResponse.Content.ReadAsStringAsync();

			var providers = JsonSerializer.Deserialize<Provider[]>(getProvidersContent);

#warning We are handling only not live games
			games = games
				.Where(game => (game.ProviderId != (int)CasinoProvidersEnum.Evolution || game.ProviderId != (int)CasinoProvidersEnum.NetEnt)
					&& !game.IsLive)
				.ToArray();

			WriteLine($"Total not evolution or netent live games in csv: [{games.Length}]");

			var requests = games
				.Select(game =>
				{
					switch ((CasinoProvidersEnum)game.ProviderId)
					{
						case CasinoProvidersEnum.Microgaming:
							return CreateMicrogamingGame(game, providers, xmlNovibetDesktopMicrogamingGames, xmlNovibetMobileMicrogamingGames);
						case CasinoProvidersEnum.Evolution:
							return CreateEvolutionGame(game, providers, xmlNovibetDesktopEvolutionGames, xmlNovibetMobileEvolutionGames);
						case CasinoProvidersEnum.ScientificGames:
							return CreateScientificGamesGame(game, providers, xmlNovibetDesktopScientificGamesGames, xmlNovibetMobileScientificGamesGames);
						case CasinoProvidersEnum.NetEnt:
							return CreateNetEntGame(game, providers, xmlNovibetDesktopNetEntGames, xmlNovibetMobileNetEntGames);
						case CasinoProvidersEnum.Edict:
							return CreateEdictGame(game, providers);
						case CasinoProvidersEnum.Iforium:
							return CreateIforiumGame(game, providers);
						case CasinoProvidersEnum.Playtech:
							return CreatePlaytechGame(game, providers, xmlKingSolomonsDesktopPlayTechGames, xmlKingSolomonsMobilePlayTechGames);
						case CasinoProvidersEnum.Nyx:
							return CreateNyxGame(game, providers, xmlNovibetDesktopNYXGames, xmlNovibetMobileNYXGames);
						case CasinoProvidersEnum.PlayNGo:
							return CreatePlayNGoGame(game, providers);
						case CasinoProvidersEnum.RedTiger:
							return CreateRedTigerGame(game, providers);
						default:
							//var message = JsonSerializer.Serialize(game);

							//File.AppendAllText(LogFilePath, $"{message}\n");

							//WriteLine(message);

							return default;
					}
				})
				.Where(request => request != null)
				.ToArray();

			WriteLine($"Total requests: [{requests.Count()}]");

			foreach (var request in requests)
			{
				var content = JsonSerializer.Serialize(request);

				var httpResponse = await MyHttpClient._HttpClient.PostAsync($"{MyHttpClient.BaseUrl}/games/legacy_migration", new StringContent(content, Encoding.Unicode, MediaTypeNames.Application.Json));

				if (!httpResponse.IsSuccessStatusCode)
				{
					var responseContent = await httpResponse.Content.ReadAsStringAsync();

					var message = JsonSerializer.Serialize(new { request = request, responseContent = responseContent, responseStatusCode = httpResponse.StatusCode });

					await File.AppendAllTextAsync(LogFilePath, $"{DateTime.UtcNow.TimeOfDay}\t{message}\n");

					//WriteLine(message);
				}
			}
		}

		private static GameLegacyCreateRequest CreateRedTigerGame(CsvUserCasinoGames game, Provider[] providers)
		{
			return new GameLegacyCreateRequest
			{
				Category = game.Category,
				Credits = game.Credits,
				DesktopCompatible = true,
				ExternalSysname = game.GameSysname.Substring(game.GameSysname.IndexOf("_") + 1),
				IsJackpot = game.IsJackpot,
				IsLive = game.IsLive,
				JackpotContribution = game.JackpotContr,
				Manufacturer = game.Manuf,
				MobileCompatible = true,
				Name = game.Caption,
				ProviderFee = game.ProviderFee,
				ProviderId = providers.Single(provider => string.Equals(provider.name, game.Provider, StringComparison.InvariantCultureIgnoreCase)).id,
				SystemId = game.GameId
			};
		}

		private static GameLegacyCreateRequest CreatePlayNGoGame(CsvUserCasinoGames game, Provider[] providers)
		{
			return new GameLegacyCreateRequest
			{
				Category = game.Category,
				Credits = game.Credits,
				DesktopCompatible = !game.Caption.EndsWith("mobile", StringComparison.InvariantCultureIgnoreCase),
				ExternalSysname = game.GameSysname.Substring(game.GameSysname.IndexOf("_") + 1),
				IsJackpot = game.IsJackpot,
				IsLive = game.IsLive,
				JackpotContribution = game.JackpotContr,
				Manufacturer = game.Manuf,
				MobileCompatible = game.Caption.EndsWith("mobile", StringComparison.InvariantCultureIgnoreCase),
				Name = game.Caption,
				ProviderFee = game.ProviderFee,
				ProviderId = providers.Single(provider => string.Equals(provider.name, game.Provider, StringComparison.InvariantCultureIgnoreCase)).id,
				SystemId = game.GameId
			};
		}

		private static GameLegacyCreateRequest CreateNyxGame(CsvUserCasinoGames game, Provider[] providers, string[] xmlNovibetDesktopNYXGames, string[] xmlNovibetMobileNYXGames)
		{
			return new GameLegacyCreateRequest
			{
				Category = game.Category,
				Credits = game.Credits,
				DesktopCompatible = xmlNovibetDesktopNYXGames.Contains(game.Caption),
				ExternalSysname = game.GameSysname.Substring(game.GameSysname.IndexOf("_") + 1),
				IsJackpot = game.IsJackpot,
				IsLive = game.IsLive,
				JackpotContribution = game.JackpotContr,
				Manufacturer = game.Manuf,
				MobileCompatible = xmlNovibetMobileNYXGames.Contains(game.Caption),
				Name = game.Caption,
				ProviderFee = game.ProviderFee,
				ProviderId = providers.Single(provider => string.Equals(provider.name, game.Provider, StringComparison.InvariantCultureIgnoreCase)).id,
				SystemId = game.GameId
			};
		}

		private static GameLegacyCreateRequest CreatePlaytechGame(CsvUserCasinoGames game, Provider[] providers, string[] xmlKingSolomonsDesktopPlayTechGames, string[] xmlKingSolomonsMobilePlayTechGames)
		{
			return new GameLegacyCreateRequest
			{
				Category = game.Category,
				Credits = game.Credits,
				DesktopCompatible = xmlKingSolomonsDesktopPlayTechGames.Contains(game.Caption),
				ExternalSysname = game.GameSysname.Substring(game.GameSysname.IndexOf("_") + 1),
				IsJackpot = game.IsJackpot,
				IsLive = game.IsLive,
				JackpotContribution = game.JackpotContr,
				Manufacturer = game.Manuf,
				MobileCompatible = xmlKingSolomonsMobilePlayTechGames.Contains(game.Caption),
				Name = game.Caption,
				ProviderFee = game.ProviderFee,
				ProviderId = providers.Single(provider => string.Equals(provider.name, game.Provider, StringComparison.InvariantCultureIgnoreCase)).id,
				SystemId = game.GameId
			};
		}

		private static GameLegacyCreateRequest CreateEdictGame(CsvUserCasinoGames game, Provider[] providers)
		{
			return new GameLegacyCreateRequest
			{
				Category = game.Category,
				Credits = game.Credits,
				DesktopCompatible = true,
				ExternalSysname = game.GameSysname.Substring(game.GameSysname.IndexOf("_") + 1),
				IsJackpot = game.IsJackpot,
				IsLive = game.IsLive,
				JackpotContribution = game.JackpotContr,
				Manufacturer = game.Manuf,
				MobileCompatible = true,
				Name = game.Caption,
				ProviderFee = game.ProviderFee,
				ProviderId = providers.Single(provider => string.Equals(provider.name, game.Provider, StringComparison.InvariantCultureIgnoreCase)).id,
				SystemId = game.GameId
			};
		}

		private static GameLegacyCreateRequest CreateNetEntGame(CsvUserCasinoGames game, Provider[] providers, string[] xmlNovibetDesktopNetEntGames, string[] xmlNovibetMobileNetEntGames)
		{
			return new GameLegacyCreateRequest
			{
				Category = game.Category,
				Credits = game.Credits,
				DesktopCompatible = xmlNovibetDesktopNetEntGames.Contains(game.Caption),
				ExternalSysname = game.GameSysname.Substring(game.GameSysname.IndexOf("_") + 1),
				IsJackpot = game.IsJackpot,
				IsLive = game.IsLive,
				JackpotContribution = game.JackpotContr,
				Manufacturer = game.Manuf,
				MobileCompatible = xmlNovibetMobileNetEntGames.Contains(game.Caption),
				Name = game.Caption,
				ProviderFee = game.ProviderFee,
				ProviderId = providers.Single(provider => string.Equals(provider.name, game.Provider, StringComparison.InvariantCultureIgnoreCase)).id,
				SystemId = game.GameId
			};
		}

		private static GameLegacyCreateRequest CreateScientificGamesGame(CsvUserCasinoGames game, Provider[] providers, string[] xmlNovibetDesktopScientificGamesGames, string[] xmlNovibetMobileScientificGamesGames)
		{
			return new GameLegacyCreateRequest
			{
				Category = game.Category,
				Credits = game.Credits,
				DesktopCompatible = xmlNovibetDesktopScientificGamesGames.Contains(game.Caption),
				ExternalSysname = game.GameSysname.Substring(game.GameSysname.IndexOf("_") + 1),
				IsJackpot = game.IsJackpot,
				IsLive = game.IsLive,
				JackpotContribution = game.JackpotContr,
				Manufacturer = game.Manuf,
				MobileCompatible = xmlNovibetMobileScientificGamesGames.Contains(game.Caption),
				Name = game.Caption,
				ProviderFee = game.ProviderFee,
				ProviderId = providers.Single(provider => string.Equals(provider.name, game.Provider, StringComparison.InvariantCultureIgnoreCase)).id,
				SystemId = game.GameId
			};
		}

		private static GameLegacyCreateRequest CreateEvolutionGame(CsvUserCasinoGames game, Provider[] providers, string[] xmlNovibetDesktopEvolutionGames, string[] xmlNovibetMobileEvolutionGames)
		{
			return new GameLegacyCreateRequest
			{
				Category = game.Category,
				Credits = game.Credits,
				DesktopCompatible = xmlNovibetDesktopEvolutionGames.Contains(game.Caption),
				ExternalSysname = game.GameSysname,
				IsJackpot = game.IsJackpot,
				IsLive = game.IsLive,
				JackpotContribution = game.JackpotContr,
				Manufacturer = game.Manuf,
				MobileCompatible = xmlNovibetMobileEvolutionGames.Contains(game.Caption),
				Name = game.Caption,
				ProviderFee = game.ProviderFee,
				ProviderId = providers.Single(provider => string.Equals(provider.name, game.Provider, StringComparison.InvariantCultureIgnoreCase)).id,
				SystemId = game.GameId
			};
		}

		private static GameLegacyCreateRequest CreateMicrogamingGame(CsvUserCasinoGames game, Provider[] providers, XmlHandler.Novibet.Desktop.Microgaming.XmlNovibetDesktopMicrogamingGame[] xmlNovibetDesktopMicrogamingGames, XmlHandler.Novibet.Mobile.Microgaming.XmlNovibetMobileMicrogamingGame[] xmlNovibetMobileMicrogamingGames)
		{
			var fileLogger = new FileLogger();

			var source = default(string);

			if (game.IsMobile)
			{
				var potentialGame = xmlNovibetMobileMicrogamingGames.SingleOrDefault(x => x.Sysname == game.Caption);

				if (potentialGame == null)
					fileLogger.Log($"Mobile {game.Caption}");
				else
					source = potentialGame.Source;
			}
			else
			{
				var potentialGame = xmlNovibetDesktopMicrogamingGames.SingleOrDefault(x => x.Sysname == game.Caption);

				if (potentialGame == null)
					fileLogger.Log($"Desktop {game.Caption}");
				else
					source = potentialGame.Source;
			}

			if (string.IsNullOrWhiteSpace(source))
				return default;

			var externalSysname = default(string);

			if (source.StartsWith("https://mobile3.risemi.net"))
			{
				source = source.Replace("https://mobile3.risemi.net/MobileWebServices_40/casino/game/launch/NoviBet/", "");
				source = source.Substring(0, source.IndexOf("/"));

				externalSysname = source;
			}
			else if (source.StartsWith("https://redirector3.valueactive.eu"))
			{
				if (source.Contains("&amp"))
				{
					source = source.Replace("https://redirector3.valueactive.eu/Casino/default.aspx?{TOKEN}sext1={AUTH}&amp;sext2={AUTH}&amp;gameid=", "");

					source = source.Substring(0, source.IndexOf("&amp"));
				}
				else
				{
					source = source.Replace("https://redirector3.valueactive.eu/Casino/default.aspx?{TOKEN}sext1={AUTH}&sext2={AUTH}&gameid=", "");

					source = source.Substring(0, source.IndexOf("&"));
				}

				externalSysname = source;
			}
			else if (source.StartsWith("https://webservice.basestatic.net"))
#warning What to do
				return default;

			return new GameLegacyCreateRequest
			{
				Category = game.Category,
				Credits = game.Credits,
				DesktopCompatible = !game.IsMobile,
				ExternalSysname = externalSysname,
				IsJackpot = game.IsJackpot,
				IsLive = game.IsLive,
				JackpotContribution = game.JackpotContr,
				Manufacturer = game.Manuf,
				MobileCompatible = game.IsMobile,
				Name = game.Caption,
				ProviderFee = game.ProviderFee,
				ProviderId = providers.Single(provider => string.Equals(provider.name, game.Provider, StringComparison.InvariantCultureIgnoreCase)).id,
				SystemId = game.GameId
			};
		}

		private static GameLegacyCreateRequest CreateIforiumGame(CsvUserCasinoGames game, Provider[] providers)
		{
			return new GameLegacyCreateRequest
			{
				Category = game.Category,
				Credits = game.Credits,
				DesktopCompatible = !game.Caption.EndsWith("mobile", StringComparison.InvariantCultureIgnoreCase),
				ExternalSysname = game.GameSysname.Substring(game.GameSysname.IndexOf("_") + 1),
				IsJackpot = game.IsJackpot,
				IsLive = game.IsLive,
				JackpotContribution = game.JackpotContr,
				Manufacturer = game.Manuf,
				MobileCompatible = game.Caption.EndsWith("mobile", StringComparison.InvariantCultureIgnoreCase),
				Name = game.Caption,
				ProviderFee = game.ProviderFee,
				ProviderId = providers.Single(provider => string.Equals(provider.name, game.Provider, StringComparison.InvariantCultureIgnoreCase)).id,
				SystemId = game.GameId
			};
		}

		private static async Task Login()
		{
			var request = new LoginRequest
			{
				Username = "sdim",
				Password = "test123"
			};

			var requestContent = JsonSerializer.Serialize(request);

			var httpResponse = await MyHttpClient._HttpClient.PostAsync($"{MyHttpClient.BaseUrl}/account/login", new StringContent(requestContent, Encoding.Unicode, MediaTypeNames.Application.Json));

			var httpResponseContent = await httpResponse.Content.ReadAsStringAsync();

			var response = JsonSerializer.Deserialize<LoginResponse>(httpResponseContent);

			MyHttpClient._HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", response.accessToken);
		}
	}
}