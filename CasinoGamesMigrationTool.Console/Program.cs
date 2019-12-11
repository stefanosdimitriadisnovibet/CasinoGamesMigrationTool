using CasinoGamesMigrationTool.XmlHandler.KingSolomons.Desktop.PlayTech;
using CasinoGamesMigrationTool.XmlHandler.KingSolomons.Mobile.PlayTech;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.Edict;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.Evolution;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.Iforium;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.Microgaming;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.NetEnt;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.NYX;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.PlayNGo;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.RedTiger;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Desktop.ScientificGames;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.Edict;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.Evolution;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.Iforium;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.Microgaming;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.NetEnt;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.NYX;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.PlayNGo;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.RedTiger;
using CasinoGamesMigrationTool.XmlHandler.Novibet.Mobile.ScientificGames;
using CasinoGamesMigrationTool.XmlHandler.NoviCasino.Desktop.Evolution;
using CasinoGamesMigrationTool.XmlHandler.NoviCasino.Desktop.Iforium;
using CasinoGamesMigrationTool.XmlHandler.NoviCasino.Desktop.Microgaming;
using CasinoGamesMigrationTool.XmlHandler.NoviCasino.Desktop.NetEnt;
using CasinoGamesMigrationTool.XmlHandler.NoviCasino.Desktop.ScientificGames;
using CasinoGamesMigrationTool.XmlHandler.NoviCasino.Mobile.Evolution;
using CasinoGamesMigrationTool.XmlHandler.NoviCasino.Mobile.Iforium;
using CasinoGamesMigrationTool.XmlHandler.NoviCasino.Mobile.Microgaming;
using CasinoGamesMigrationTool.XmlHandler.NoviCasino.Mobile.NetEnt;
using CasinoGamesMigrationTool.XmlHandler.NoviCasino.Mobile.ScientificGames;
using CasinoGamesMigrationTool.XmlParser.KingSolomons.Desktop.PlayTech;
using CasinoGamesMigrationTool.XmlParser.KingSolomons.Mobile.PlayTech;
using CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.Edict;
using CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.Evolution;
using CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.Iforium;
using CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.Microgaming;
using CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.NetEnt;
using CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.NYX;
using CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.PlayNGo;
using CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.RedTiger;
using CasinoGamesMigrationTool.XmlParser.Novibet.Desktop.ScientificGames;
using CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.Edict;
using CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.Evolution;
using CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.Iforium;
using CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.Microgaming;
using CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.NetEnt;
using CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.NYX;
using CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.PlayNGo;
using CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.RedTiger;
using CasinoGamesMigrationTool.XmlParser.Novibet.Mobile.ScientificGames;
using CasinoGamesMigrationTool.XmlParser.NoviCasino.Desktop.Evolution;
using CasinoGamesMigrationTool.XmlParser.NoviCasino.Desktop.Iforium;
using CasinoGamesMigrationTool.XmlParser.NoviCasino.Desktop.Microgaming;
using CasinoGamesMigrationTool.XmlParser.NoviCasino.Desktop.NetEnt;
using CasinoGamesMigrationTool.XmlParser.NoviCasino.Desktop.ScientificGames;
using CasinoGamesMigrationTool.XmlParser.NoviCasino.Mobile.Evolution;
using CasinoGamesMigrationTool.XmlParser.NoviCasino.Mobile.Iforium;
using CasinoGamesMigrationTool.XmlParser.NoviCasino.Mobile.Microgaming;
using CasinoGamesMigrationTool.XmlParser.NoviCasino.Mobile.NetEnt;
using CasinoGamesMigrationTool.XmlParser.NoviCasino.Mobile.ScientificGames;
using System;
using System.Threading.Tasks;

namespace CasinoGamesMigrationTool
{
	public class Program
	{
		public static Task Main(string[] args)
		{
			#region Xml

			#region KingSolomons

			#region Desktop
			XmlKingSolomonsDesktopPlayTechResponse xmlKingSolomonsDesktopPlayTechResponse = XmlKingSolomonsDesktopPlayTechParser.ParseXml();

			XmlHandler.KingSolomons.Desktop.PlayTech.XmlKingSolomonsDesktopPlayTechGame[] xmlKingSolomonsDesktopPlayTechGames = xmlKingSolomonsDesktopPlayTechResponse.HandleGames();
			XmlHandler.KingSolomons.Desktop.PlayTech.XmlKingSolomonsDesktopPlayTechGameLanguages[] xmlKingSolomonsDesktopPlayTechGameLanguages = xmlKingSolomonsDesktopPlayTechResponse.HandleGameLanguages();
			XmlHandler.KingSolomons.Desktop.PlayTech.XmlKingSolomonsDesktopPlayTechJackpotGame[] xmlKingSolomonsDesktopPlayTechJackpotGames = xmlKingSolomonsDesktopPlayTechResponse.HandleJacktopGames();
			#endregion Desktop

			#region Mobile
			XmlKingSolomonsMobilePlayTechResponse xmlKingSolomonsMobilePlayTechResponse = XmlKingSolomonsMobilePlayTechParser.ParseXml();

			XmlHandler.KingSolomons.Mobile.PlayTech.XmlKingSolomonsMobilePlayTechGame[] xmlKingSolomonsMobilePlayTechGames = xmlKingSolomonsMobilePlayTechResponse.HandleGames();
			XmlHandler.KingSolomons.Mobile.PlayTech.XmlKingSolomonsMobilePlayTechGameLanguage[] xmlKingSolomonsMobilePlayTechGameLanguages = xmlKingSolomonsMobilePlayTechResponse.HandleGameLanguages();
			XmlHandler.KingSolomons.Mobile.PlayTech.XmlKingSolomonsMobilePlayTechJackpotGame[] xmlKingSolomonsMobilePlayTechJackpotGames = xmlKingSolomonsMobilePlayTechResponse.HandleJackpotGames();
			#endregion Mobile

			#endregion KingSolomons

			#region NoviCasino

			#region Desktop
			XmlNoviCasinoDesktopEvolutionResponse xmlNoviCasinoDesktopEvolutionResponse = XmlNoviCasinoDesktopEvolutionParser.ParseXml();

			XmlHandler.NoviCasino.Desktop.Evolution.XmlNoviCasinoDesktopEvolutionGame[] xmlNoviCasinoDesktopEvolutionGames = xmlNoviCasinoDesktopEvolutionResponse.HandleGames();
			XmlHandler.NoviCasino.Desktop.Evolution.XmlNoviCasinoDesktopEvolutionGameLanguages[] xmlNoviCasinoDesktopEvolutionGameLanguages = xmlNoviCasinoDesktopEvolutionResponse.HandleGameLanguages();

			XmlNoviCasinoDesktopIforiumResponse xmlNoviCasinoDesktopIforiumResponse = XmlNoviCasinoDesktopIforiumParser.ParseXml();

			XmlHandler.NoviCasino.Desktop.Iforium.XmlNoviCasinoDesktopIforiumGame[] xmlNoviCasinoDesktopIforiumGames = xmlNoviCasinoDesktopIforiumResponse.HandleGames();
			XmlHandler.NoviCasino.Desktop.Iforium.XmlNoviCasinoDesktopIforiumGameLanguages[] xmlNoviCasinoDesktopIforiumGameLanguages = xmlNoviCasinoDesktopIforiumResponse.HandleGameLanguages();

			XmlNoviCasinoDesktopMicrogamingResponse xmlNoviCasinoDesktopMicrogamingResponse = XmlNoviCasinoDesktopMicrogamingParser.ParseXml();

			XmlHandler.NoviCasino.Desktop.Microgaming.XmlNoviCasinoDesktopMicrogamingGame[] xmlNoviCasinoDesktopMicrogamingGames = xmlNoviCasinoDesktopMicrogamingResponse.HandleGames();
			XmlHandler.NoviCasino.Desktop.Microgaming.XmlNoviCasinoDesktopMicrogamingGameLanguages[] xmlNoviCasinoDesktopMicrogamingGameLanguages = xmlNoviCasinoDesktopMicrogamingResponse.HandleGameLanguages();
			XmlHandler.NoviCasino.Desktop.Microgaming.XmlNoviCasinoDesktopMicrogamingJackpotGame[] xmlNoviCasinoDesktopMicrogamingJackpotGamesx = xmlNoviCasinoDesktopMicrogamingResponse.HandleJacktopGames();

			XmlNoviCasinoDesktopNetEntResponse xmlNoviCasinoDesktopNetEntResponse = XmlNoviCasinoDesktopNetEntParser.ParseXml();

			XmlHandler.NoviCasino.Desktop.NetEnt.XmlNoviCasinoDesktopNetEntGame[] xmlNoviCasinoDesktopNetEntGames = xmlNoviCasinoDesktopNetEntResponse.HandleGames();
			XmlHandler.NoviCasino.Desktop.NetEnt.XmlNoviCasinoDesktopNetEntGameLanguages[] xmlNoviCasinoDesktopNetEntGameLanguages = xmlNoviCasinoDesktopNetEntResponse.HandleGameLanguages();
			XmlHandler.NoviCasino.Desktop.NetEnt.XmlNoviCasinoDesktopNetEntJackpotGame[] xmlNoviCasinoDesktopNetEntJackpotGames = xmlNoviCasinoDesktopNetEntResponse.HandleJacktopGames();

			XmlNoviCasinoDesktopScientificGamesResponse xmlNoviCasinoDesktopScientificGamesResponse = XmlNoviCasinoDesktopScientificGamesParser.ParseXml();

			XmlHandler.NoviCasino.Desktop.ScientificGames.XmlNoviCasinoDesktopScientificGamesGame[] xmlNoviCasinoDesktopScientificGames = xmlNoviCasinoDesktopScientificGamesResponse.HandleGames();
			XmlHandler.NoviCasino.Desktop.ScientificGames.XmlNoviCasinoDesktopScientificGamesGameLanguages[] xmlNoviCasinoDesktopScientificGamesGameLanguages = xmlNoviCasinoDesktopScientificGamesResponse.HandleGameLanguages();
			#endregion Desktop

			#region Mobile
			XmlNoviCasinoMobileEvolutionResponse xmlNoviCasinoMobileEvolutionResponse = XmlNoviCasinoMobileEvolutionParser.ParseXml();

			XmlHandler.NoviCasino.Mobile.Evolution.XmlNoviCasinoMobileEvolutionGame[] xmlNoviCasinoMobileEvolutionGames = xmlNoviCasinoMobileEvolutionResponse.HandleGames();
			XmlHandler.NoviCasino.Mobile.Evolution.XmlNoviCasinoMobileEvolutionGameLanguages[] xmlNoviCasinoMobileEvolutionGameLanguages = xmlNoviCasinoMobileEvolutionResponse.HandleGameLanguages();

			XmlNoviCasinoMobileIforiumResponse xmlNoviCasinoMobileIforiumResponse = XmlNoviCasinoMobileIforiumParser.ParseXml();

			XmlHandler.NoviCasino.Mobile.Iforium.XmlNoviCasinoMobileIforiumGame[] xmlNoviCasinoMobileIforiumGames = xmlNoviCasinoMobileIforiumResponse.HandleGames();
			XmlHandler.NoviCasino.Mobile.Iforium.XmlNoviCasinoMobileIforiumGameLanguages[] xmlNoviCasinoMobileIforiumGameLanguages = xmlNoviCasinoMobileIforiumResponse.HandleGameLanguages();

			XmlNoviCasinoMobileMicrogamingResponse xmlNoviCasinoMobileMicrogamingResponse = XmlNoviCasinoMobileMicrogamingParser.ParseXml();

			XmlHandler.NoviCasino.Mobile.Microgaming.XmlNoviCasinoMobileMicrogamingGame[] xmlNoviCasinoMobileMicrogamingGames = xmlNoviCasinoMobileMicrogamingResponse.HandleGames();
			XmlHandler.NoviCasino.Mobile.Microgaming.XmlNoviCasinoMobileMicrogamingGameLanguages[] xmlNoviCasinoMobileMicrogamingGameLanguages = xmlNoviCasinoMobileMicrogamingResponse.HandleGameLanguages();
			XmlHandler.NoviCasino.Mobile.Microgaming.XmlNoviCasinoMobileMicrogamingJackpotGame[] xmlNoviCasinoMobileMicrogamingJackpotGamesx = xmlNoviCasinoMobileMicrogamingResponse.HandleJacktopGames();

			XmlNoviCasinoMobileNetEntResponse xmlNoviCasinoMobileNetEntResponse = XmlNoviCasinoMobileNetEntParser.ParseXml();

			XmlHandler.NoviCasino.Mobile.NetEnt.XmlNoviCasinoMobileNetEntGame[] xmlNoviCasinoMobileNetEntGames = xmlNoviCasinoMobileNetEntResponse.HandleGames();
			XmlHandler.NoviCasino.Mobile.NetEnt.XmlNoviCasinoMobileNetEntGameLanguages[] xmlNoviCasinoMobileNetEntGameLanguages = xmlNoviCasinoMobileNetEntResponse.HandleGameLanguages();

			XmlNoviCasinoMobileScientificGamesResponse xmlNoviCasinoMobileScientificGamesResponse = XmlNoviCasinoMobileScientificGamesParser.ParseXml();

			XmlHandler.NoviCasino.Mobile.ScientificGames.XmlNoviCasinoMobileScientificGamesGame[] xmlNoviCasinoMobileScientificGames = xmlNoviCasinoMobileScientificGamesResponse.HandleGames();
			XmlHandler.NoviCasino.Mobile.ScientificGames.XmlNoviCasinoMobileScientificGamesGameLanguages[] xmlNoviCasinoMobileScientificGamesGameLanguages = xmlNoviCasinoMobileScientificGamesResponse.HandleGameLanguages();
			#endregion Mobile

			#endregion NoviCasino

			#region Novibet

			#region Desktop
			XmlNovibetDesktopEdictResponse xmlNovibetDesktopEdictResponse = XmlNovibetDesktopEdictParser.ParseXml();

			XmlHandler.Novibet.Desktop.Edict.XmlNovibetDesktopEdictGame[] xmlNovibetDesktopEdictGames = xmlNovibetDesktopEdictResponse.HandleGames();
			XmlHandler.Novibet.Desktop.Edict.XmlNovibetDesktopEdictGameLanguages[] xmlNovibetDesktopEdictGameLanguages = xmlNovibetDesktopEdictResponse.HandleGameLanguages();

			XmlNovibetDesktopEvolutionResponse xmlNovibetDesktopEvolutionResponse = XmlNovibetDesktopEvolutionParser.ParseXml();

			XmlHandler.Novibet.Desktop.Evolution.XmlNovibetDesktopEvolutionGame[] xmlNovibetDesktopEvolutionGames = xmlNovibetDesktopEvolutionResponse.HandleGames();
			XmlHandler.Novibet.Desktop.Evolution.XmlNovibetDesktopEvolutionGameLanguages[] xmlNovibetDesktopEvolutionGameLanguages = xmlNovibetDesktopEvolutionResponse.HandleGameLanguages();

			XmlNovibetDesktopIforiumResponse xmlNovibetDesktopIforiumResponse = XmlNovibetDesktopIforiumParser.ParseXml();

			XmlHandler.Novibet.Desktop.Iforium.XmlNovibetDesktopIforiumGame[] xmlNovibetDesktopIforiumGames = xmlNovibetDesktopIforiumResponse.HandleGames();
			XmlHandler.Novibet.Desktop.Iforium.XmlNovibetDesktopIforiumGameLanguages[] xmlNovibetDesktopIforiumGameLanguages = xmlNovibetDesktopIforiumResponse.HandleGameLanguages();

			XmlNovibetDesktopMicrogamingResponse xmlNovibetDesktopMicrogamingResponse = XmlNovibetDesktopMicrogamingParser.ParseXml();

			XmlHandler.Novibet.Desktop.Microgaming.XmlNovibetDesktopMicrogamingGame[] xmlNovibetDesktopMicrogamingGames = xmlNovibetDesktopMicrogamingResponse.HandleGames();
			XmlHandler.Novibet.Desktop.Microgaming.XmlNovibetDesktopMicrogamingGameLanguages[] xmlNovibetDesktopMicrogamingGameLanguages = xmlNovibetDesktopMicrogamingResponse.HandleGameLanguages();
			XmlHandler.Novibet.Desktop.Microgaming.XmlNovibetDesktopMicrogamingJackpotGame[] xmlNovibetDesktopMicrogamingJackpotGames = xmlNovibetDesktopMicrogamingResponse.HandleJacktopGames();

			XmlNovibetDesktopNetEntResponse xmlNovibetDesktopNetEntResponse = XmlNovibetDesktopNetEntParser.ParseXml();

			XmlHandler.Novibet.Desktop.NetEnt.XmlNovibetDesktopNetEntGame[] xmlNovibetDesktopNetEntGames = xmlNovibetDesktopNetEntResponse.HandleGames();
			XmlHandler.Novibet.Desktop.NetEnt.XmlNovibetDesktopNetEntGameLanguages[] xmlNovibetDesktopNetEntGameLanguages = xmlNovibetDesktopNetEntResponse.HandleGameLanguages();
			XmlHandler.Novibet.Desktop.NetEnt.XmlNovibetDesktopNetEntJackpotGame[] xmlNovibetDesktopNetEntJackpotGames = xmlNovibetDesktopNetEntResponse.HandleJacktopGames();

			XmlNovibetDesktopNYXResponse xmlNovibetDesktopNYXResponse = XmlNovibetDesktopNYXParser.ParseXml();

			XmlHandler.Novibet.Desktop.NYX.XmlNovibetDesktopNYXGame[] xmlNovibetDesktopNYXGames = xmlNovibetDesktopNYXResponse.HandleGames();
			XmlHandler.Novibet.Desktop.NYX.XmlNovibetDesktopNYXGameLanguages[] xmlNovibetDesktopNYXGameLanguages = xmlNovibetDesktopNYXResponse.HandleGameLanguages();

			XmlNovibetDesktopPlayNGoResponse xmlNovibetDesktopPlayNGoResponse = XmlNovibetDesktopPlayNGoParser.ParseXml();

			XmlHandler.Novibet.Desktop.PlayNGo.XmlNovibetDesktopPlayNGoGame[] xmlNovibetDesktopPlayNGoGames = xmlNovibetDesktopPlayNGoResponse.HandleGames();
			XmlHandler.Novibet.Desktop.PlayNGo.XmlNovibetDesktopPlayNGoGameLanguages[] xmlNovibetDesktopPlayNGoGameLanguages = xmlNovibetDesktopPlayNGoResponse.HandleGameLanguages();

			XmlNovibetDesktopRedTigerResponse xmlNovibetDesktopRedTigerResponse = XmlNovibetDesktopRedTigerParser.ParseXml();

			XmlHandler.Novibet.Desktop.RedTiger.XmlNovibetDesktopRedTigerGame[] xmlNovibetDesktopRedTigerGames = xmlNovibetDesktopRedTigerResponse.HandleGames();
			XmlHandler.Novibet.Desktop.RedTiger.XmlNovibetDesktopRedTigerGameLanguages[] xmlNovibetDesktopRedTigerGameLanguages = xmlNovibetDesktopRedTigerResponse.HandleGameLanguages();

			XmlNovibetDesktopScientificGamesResponse xmlNovibetDesktopScientificGamesResponse = XmlNovibetDesktopScientificGamesParser.ParseXml();

			XmlHandler.Novibet.Desktop.ScientificGames.XmlNovibetDesktopScientificGamesGame[] xmlNovibetDesktopScientificGamesGames = xmlNovibetDesktopScientificGamesResponse.HandleGames();
			XmlHandler.Novibet.Desktop.ScientificGames.XmlNovibetDesktopScientificGamesGameLanguages[] xmlNovibetDesktopScientificGamesGameLanguages = xmlNovibetDesktopScientificGamesResponse.HandleGameLanguages();

			#endregion Desktop

			#region Mobile
			XmlNovibetMobileEdictResponse xmlNovibetMobileEdictResponse = XmlNovibetMobileEdictParser.ParseXml();

			XmlHandler.Novibet.Mobile.Edict.XmlNovibetMobileEdictGame[] xmlNovibetMobileEdictGames = xmlNovibetMobileEdictResponse.HandleGames();
			XmlHandler.Novibet.Mobile.Edict.XmlNovibetMobileEdictGameLanguages[] xmlNovibetMobileEdictGameLanguages = xmlNovibetMobileEdictResponse.HandleGameLanguages();

			XmlNovibetMobileEvolutionResponse xmlNovibetMobileEvolutionResponse = XmlNovibetMobileEvolutionParser.ParseXml();

			XmlHandler.Novibet.Mobile.Evolution.XmlNovibetMobileEvolutionGame[] xmlNovibetMobileEvolutionGames = xmlNovibetMobileEvolutionResponse.HandleGames();
			XmlHandler.Novibet.Mobile.Evolution.XmlNovibetMobileEvolutionGameLanguages[] xmlNovibetMobileEvolutionGameLanguages = xmlNovibetMobileEvolutionResponse.HandleGameLanguages();

			XmlNovibetMobileIforiumResponse xmlNovibetMobileIforiumResponse = XmlNovibetMobileIforiumParser.ParseXml();

			XmlHandler.Novibet.Mobile.Iforium.XmlNovibetMobileIforiumGame[] xmlNovibetMobileIforiumGames = xmlNovibetMobileIforiumResponse.HandleGames();
			XmlHandler.Novibet.Mobile.Iforium.XmlNovibetMobileIforiumGameLanguages[] xmlNovibetMobileIforiumGameLanguages = xmlNovibetMobileIforiumResponse.HandleGameLanguages();

			XmlNovibetMobileMicrogamingResponse xmlNovibetMobileMicrogamingResponse = XmlNovibetMobileMicrogamingParser.ParseXml();

			XmlHandler.Novibet.Mobile.Microgaming.XmlNovibetMobileMicrogamingGame[] xmlNovibetMobileMicrogamingGames = xmlNovibetMobileMicrogamingResponse.HandleGames();
			XmlHandler.Novibet.Mobile.Microgaming.XmlNovibetMobileMicrogamingGameLanguages[] xmlNovibetMobileMicrogamingGameLanguages = xmlNovibetMobileMicrogamingResponse.HandleGameLanguages();
			XmlHandler.Novibet.Mobile.Microgaming.XmlNovibetMobileMicrogamingJackpotGame[] xmlNovibetMobileMicrogamingJackpotGames = xmlNovibetMobileMicrogamingResponse.HandleJacktopGames();

			XmlNovibetMobileNetEntResponse xmlNovibetMobileNetEntResponse = XmlNovibetMobileNetEntParser.ParseXml();

			XmlHandler.Novibet.Mobile.NetEnt.XmlNovibetMobileNetEntGame[] xmlNovibetMobileNetEntGames = xmlNovibetMobileNetEntResponse.HandleGames();
			XmlHandler.Novibet.Mobile.NetEnt.XmlNovibetMobileNetEntGameLanguages[] xmlNovibetMobileNetEntGameLanguages = xmlNovibetMobileNetEntResponse.HandleGameLanguages();

			XmlNovibetMobileNYXResponse xmlNovibetMobileNYXResponse = XmlNovibetMobileNYXParser.ParseXml();

			XmlHandler.Novibet.Mobile.NYX.XmlNovibetMobileNYXGame[] xmlNovibetMobileNYXGames = xmlNovibetMobileNYXResponse.HandleGames();
			XmlHandler.Novibet.Mobile.NYX.XmlNovibetMobileNYXGameLanguages[] xmlNovibetMobileNYXGameLanguages = xmlNovibetMobileNYXResponse.HandleGameLanguages();

			XmlNovibetMobilePlayNGoResponse xmlNovibetMobilePlayNGoResponse = XmlNovibetMobilePlayNGoParser.ParseXml();

			XmlHandler.Novibet.Mobile.PlayNGo.XmlNovibetMobilePlayNGoGame[] xmlNovibetMobilePlayNGoGames = xmlNovibetMobilePlayNGoResponse.HandleGames();
			XmlHandler.Novibet.Mobile.PlayNGo.XmlNovibetMobilePlayNGoGameLanguages[] xmlNovibetMobilePlayNGoGameLanguages = xmlNovibetMobilePlayNGoResponse.HandleGameLanguages();

			XmlNovibetMobileRedTigerResponse xmlNovibetMobileRedTigerResponse = XmlNovibetMobileRedTigerParser.ParseXml();

			XmlHandler.Novibet.Mobile.RedTiger.XmlNovibetMobileRedTigerGame[] xmlNovibetMobileRedTigerGames = xmlNovibetMobileRedTigerResponse.HandleGames();
			XmlHandler.Novibet.Mobile.RedTiger.XmlNovibetMobileRedTigerGameLanguages[] xmlNovibetMobileRedTigerGameLanguages = xmlNovibetMobileRedTigerResponse.HandleGameLanguages();

			XmlNovibetMobileScientificGamesResponse xmlNovibetMobileScientificGamesResponse = XmlNovibetMobileScientificGamesParser.ParseXml();

			XmlHandler.Novibet.Mobile.ScientificGames.XmlNovibetMobileScientificGamesGame[] xmlNovibetMobileScientificGamesGames = xmlNovibetMobileScientificGamesResponse.HandleGames();
			XmlHandler.Novibet.Mobile.ScientificGames.XmlNovibetMobileScientificGamesGameLanguages[] xmlNovibetMobileScientificGamesGameLanguages = xmlNovibetMobileScientificGamesResponse.HandleGameLanguages();
			#endregion Mobile

			#endregion Novibet

			#endregion Xml

			#region CMS

			#endregion CMS

			Console.WriteLine("Application ended...");
			Console.WriteLine("Close the application");
			Console.ReadLine();

			return Task.CompletedTask;
		}
	}
}
