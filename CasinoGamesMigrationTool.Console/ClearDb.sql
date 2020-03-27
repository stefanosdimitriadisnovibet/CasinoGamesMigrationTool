BEGIN TRAN

USE BBCasinoGames

EXEC sys.sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT all'
EXEC sys.sp_msforeachtable 'delete from ?'

ROLLBACK TRAN

BEGIN TRAN	

USE BBCasinoGames

Insert Into [BonusProfiles] ([Sysname],[Name],[Description],[Created],[Updated]) VALUES 
(N'CASINOBONUS',N'CASINOBONUS',N'Casino bonus','2020-01-13 12:34:51.557',NULL)

Insert Into [BonusAttributes] ([BonusProfileId],[Sysname],[Name],[Type],[Created],[Updated]) Values 
(19,N'CREDITS',N'Credits',2,'2020-01-13 12:35:05.700',NULL)

Insert Into [GameAttributes] ([Sysname],[Name],[Type],[Created],[Updated]) Values 
(N'IS_LIVE',N'is_live',3,'2020-01-13 12:32:15.317',NULL),
(N'IS_JACKPOT',N'is_jackpot',3,'2020-01-13 12:32:56.847',NULL),
(N'CATEGORY',N'category',1,'2020-01-13 12:33:05.293',NULL),
(N'MANUFACTURER',N'manufacturer',1,'2020-01-13 12:33:14.107',NULL),
(N'IS_MOBILE_COMPATIBLE',N'is_mobile_compatible',3,'2020-01-13 12:33:27.110',NULL),
(N'IS_DESKTOP_COMPATIBLE',N'is_desktop_compatible',3,'2020-01-13 12:33:35.233',NULL),
(N'PROVIDER_FEE',N'provider_fee',2,'2020-01-13 12:33:54.113','2020-01-13 12:34:03.693'),
(N'JACKPOT_CONTRIBUTION',N'jackpot_contribution',2,'2020-01-13 12:34:19.237',NULL)

Insert Into [Providers] ([Sysname],[Name],[Created],[Updated]) Values 
(N'MGS',N'MGS','2020-01-14 10:41:07.100',NULL),
(N'EGAMINGS',N'Egamings','2020-01-14 10:41:07.100',NULL),
(N'EVOLUTION',N'Evolution','2020-01-14 10:41:07.100',NULL),
(N'SCIENTIFICGAMES',N'Scientific Games','2020-01-14 10:41:07.100',NULL),
(N'NETENT',N'NetEnt','2020-01-14 10:41:07.100',NULL),
(N'EDICT',N'Edict','2020-01-14 10:41:07.100',NULL),
(N'IFORIUM',N'Iforium','2020-01-14 10:41:07.100',NULL),
(N'NYX',N'NYX','2020-01-14 10:41:07.100',NULL),
(N'PLAYNGO',N'PlayNGo','2020-01-14 10:41:07.100',NULL),
(N'REDTIGER',N'Red_Tiger','2020-01-14 10:41:07.100',NULL),
(N'SKYWIND',N'Skywind','2020-01-14 10:41:07.100',NULL),
(N'VIADEN',N'Viaden','2020-01-14 10:41:07.100',NULL)

Insert Into [DisplayProfiles] ([Sysname],[Name],[Description],[Created],[Updated]) Values 
(N'NOVIBET',N'Novibet',N'Novibet','2020-01-22 14:25:45.223',NULL),
(N'NOVI_CASINO',N'NoviCasino',N'NoviCasino','2020-01-22 14:34:04.797',NULL),
(N'KING_SOLOMONS',N'KingSolomons',N'KingSolomons','2020-01-22 14:34:11.747',NULL)

Insert Into [DisplayAttributes] ([DisplayProfileId],[Sysname],[Name],[Type],[Created],[Updated],[Metadata])
Values (79,N'DEFAULT_IMAGE',N'Default Image',7,'2020-01-22 15:36:35.663',NULL,NULL)
,(79,N'NAME',N'Name',6,'2020-01-22 15:45:45.727',NULL,NULL)
,(79,N'LIVE_IMAGE',N'Live Image',7,'2020-01-22 15:46:02.217',NULL,NULL)
,(79,N'HERO_IMAGE',N'Hero Image',7,'2020-01-22 15:46:22.203',NULL,NULL)
,(78,N'NAME',N'Name',6,'2020-01-22 15:46:45.617',NULL,NULL)
,(78,N'HERO_IMAGE',N'Hero Image',7,'2020-01-22 15:46:53.950',NULL,NULL)
,(78,N'DEFAULT_IMAGE',N'Default Image',7,'2020-01-22 15:47:01.117',NULL,NULL)
,(78,N'LIVE_IMAGE',N'Live Image',7,'2020-01-22 15:47:09.307',NULL,NULL)
,(77,N'NAME',N'Name',6,'2020-01-22 15:47:19.733',NULL,NULL)
,(77,N'DEFAULT_IMAGE',N'Default Image',7,'2020-01-22 15:47:30.587',NULL,NULL)
,(77,N'LIVE_IMAGE',N'Live Image',7,'2020-01-22 15:47:38.280',NULL,NULL)
,(77,N'HERO_IMAGE',N'Hero Image',7,'2020-01-22 15:47:43.770',NULL,NULL)

Insert Into [Languages] ([Sysname],[Name]) Values 
(N'en-US',N'English')


Insert Into [LaunchProfiles] ([ProviderId],[Sysname],[Name],[Description],[Created]) Values 
(1224,N'RED_TIGER',N'RedTiger',N'RedTiger','2020-01-27 10:56:25.127')
,(1223,N'PLAY_NGO',N'PlayNGo',N'PlayNGo','2020-02-04 11:16:41.773')
,(1213,N'MICRO_GAMING',N'MicroGaming',N'MicroGaming','2020-02-04 12:37:26.253')
,(1214,N'EVOLUTION',N'Evolution',N'Evolution','2020-02-04 12:37:35.390')
,(1215,N'SCIENTIFIC_GAMES',N'ScientificGames',N'ScientificGames','2020-02-04 12:37:58.987')
,(1217,N'NET_ENT',N'NetEnt',N'NetEnt','2020-02-04 12:38:06.570')
,(1218,N'EDICT',N'Edict',N'Edict','2020-02-04 12:38:19.037')
,(1219,N'IFORIUM',N'Iforium',N'Iforium','2020-02-04 12:38:32.207')
,(1220,N'PLAY_TECH',N'PlayTech',N'PlayTech','2020-02-04 12:38:43.797')
,(1222,N'NYX',N'Nyx',N'Nyx','2020-02-04 12:39:05.230')

ROLLBACK TRAN

BEGIN TRAN 

USE BBCasinoGames

DELETE FROM dbo.BonusAttributeValues
DELETE FROM dbo.GameAttributeValues
DELETE FROM dbo.Games

DELETE FROM dbo.MediaImages
DELETE FROM dbo.MultilingualTexts
DELETE FROM dbo.DisplayAttributeValues
DELETE FROM dbo.LanguageTranslations

ROLLBACK TRAN