USE [ArticleDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 21.01.2021 00:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Articles]    Script Date: 21.01.2021 00:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[ShortDescription] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Writer] [nvarchar](max) NULL,
	[Date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Articles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210119213434_InitialCreate', N'5.0.2')
GO
SET IDENTITY_INSERT [dbo].[Articles] ON 
GO
INSERT [dbo].[Articles] ([Id], [Title], [ShortDescription], [Description], [Writer], [Date]) VALUES (1, N'Bilgi yüklemesinden korkmak gerekir mi?', N'1971’de yayımlanan makalede.', N'1971’de yayımlanan The Futurist adlı dergideki bir makalede, ortalama bir kentte artık altı televizyon kanalının olduğu belirtiliyor, fakat gelecekte bu sayının 100’e, hatta 200’e tırmanabileceği uyarısı yapılıyordu. “Bunun sonu nereye varacak?” diye soruluyordu yazının sonunda.

Bilgiye her an bağlantılı olduğumuz bugün bu sayılar komik geliyor. Fakat aşırı bilgi yüklemesi her kuşağın sorunu gibi görünüyor. Tarihe dönüp bakarsak kitap basımına da internetin ortaya çıkışına da din adamları da politikacılar da aynı tepkiyi göstermişti: Artık daha fazlasını kaldıramayız; insanlık kapasitesinin sonuna ulaştı.', N'Jason G Goldman', CAST(N'2021-01-20T00:39:20.1321362' AS DateTime2))
GO
INSERT [dbo].[Articles] ([Id], [Title], [ShortDescription], [Description], [Writer], [Date]) VALUES (2, N'Yeteneksizler neden kendilerini yetenekli sanır?', N'Psikologlar insanların kendi yeteneklerini.', N'Psikologlar insanların kendi yeteneklerini yargılama konusunda iyi olmadığını, en yeteneksiz insanların en kötü değerlendirmeleri yaptığını belirtiyor.

Psikologlar kendi başarısızlıklarımızı sandığımızdan daha fazla görmezden geldiğimizi söylüyor. Yeteneksiz bazı insanların kendilerini överek bu kadar sinir bozucu görülmelerinin nedeni de budur belki.

1999’da New York’taki Cornell Üniversitesi’nden Justin Kruger ve David Dunning herhangi bir konuda yeteneği olmayan insanların bu yetenek yoksunluğunun farkında olup olmadıklarını araştırdı.

Bu konuda yazdıkları makalelerine Pittsburgh bölgesinden bir banka soyguncusu örneğini vererek başladılar. McArthur Wheeler adlı kişi iki banka soygununun ardından 1995’te tutuklanmıştı. Gündüz vakti maskesiz soygun yapan Wheeler, polisin gösterdiği güvenlik kameralarını görünce şaşırmış, “Ama yüzüme limon suyu sürmüştüm” diye protesto etmişti. Çünkü limon suyunun kendisini kameralarda görünmez kılacağına inanıyordu.

Yetenek değerlendirmesi

İki araştırmacı, komedyenlerden 30 espriye komiklik derecelerine göre not vermelerini istemişti. Daha sonra 65 üniversite öğrencisinden aynı şakaları değerlendirmeleri istendi. Bu kişilerden ayrıca kendi değerlendirmelerini ortalamaya kıyasla nasıl bulduklarını söylemeleri bekleniyordu. İki sonuç karşılaştırıldı.


Katılımcıların çoğu kendi değerlendirmelerini ortalamanın üzerinde görüyordu. Fakat performansları kıyaslandığında ilginç sonuçlar ortaya çıktı. Esprileri değerlendirme konusunda ortalamanın üzerinde not alanlar, kendi değerlendirmelerinde de gerçekçi davranmış, oysa neyin daha komik olduğu konusunda kötü tahminde bulunanlar, kendi yeteneklerini doğru değerlendirmede de kötü performans göstermişti.

Araştırmacılar espirinin öznelliği sorununu gidermek için aynı grupla ikinci bir test yapıp bu kez mantık ve dilbilgisi konularında soru sordular. Bu testten de benzer sonuç alındı. En kötü performansı sergileyenler kendi yeteneklerini değerlendirme konusunda da en kötü çıkanlardı. Bunlar yeteneklerini ortalamanın üzerinde görüyorlardı.

Çifte eksiklik
Kruger ve Dunning bu deneyden hareketle şu sonuca vardılar: En az yetenekli olanlarda çifte eksiklik söz konusuydu. Sadece yetenek sorunları yoktu; kendi yeteneklerinin sınırlılığını görmelerini sağlayacak zihinsel kapasiteden de yoksundu bu insanlar.

Bir sonraki aşamada ise araştırmacılar kötü performans sergileyenleri mantık sorularını yanıtlama konusunda eğitime tabi tuttular. Bunun sonucunda katılımcıların kendi kendilerini değerlendirmede de gelişme kaydettikleri görüldü. Yani yetenek seviyesi arttıkça kendi durumunun farkında olma halinde de gelişme kaydediliyordu.

Bu “beceriksiz ve farkında bile değil” durumunun sadece soyut laboratuvar deneylerinde değil, gerçek hayatta da var olduğunu gösteren farklı araştırmalar da yapıldı.

Dunning-Kruger etkisi olarak adlandırılan bu durumu psikologlar üstbiliş (düşünme hakkında düşünme) örneği olarak kullanıyor.

Kısacası, cehaletimizin farkında olmadan gururla dolaşıyor olma durumuna düşmemek için, etrafımızdaki insanlarda bu özellik var mı diye incelemeye başlamadan önce, dönüp kendimizi yoklamakta yarar var.', N'Tom Stafford', CAST(N'2021-01-20T00:45:02.2840230' AS DateTime2))
GO
INSERT [dbo].[Articles] ([Id], [Title], [ShortDescription], [Description], [Writer], [Date]) VALUES (6, N'update', N'update', N'update', N'update', CAST(N'2021-01-20T22:02:55.4228345' AS DateTime2))
GO
INSERT [dbo].[Articles] ([Id], [Title], [ShortDescription], [Description], [Writer], [Date]) VALUES (8, N'deneme', N'deneme', N'deneme', N'deneme', CAST(N'2021-01-21T00:13:40.9626568' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Articles] OFF
GO
