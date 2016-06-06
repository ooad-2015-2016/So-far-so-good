# So-far-so-good
 Članovi tima:
 1. Ervin Beus
 2. Lejla Džanko
 3. Jasmina Bajramović
 4. Ena Hajdarević

#**JobRadar** 

##Opis teme

Da li ste vec duže vremena nezaposleni i osjecate da prave prilike za Vas nema “ni na mapi”? Da li ste poslodavac i osjecate da Vaši oglasi za posao nikada ne nadu pravi ljudi?
Vrijeme je da se pojavite na radaru!
JobRadar je jedinstveni servis koji kroz svoje funkcionalnosti omogucava poslodavcima da pronadu pravi profil ljudi a nezaposlenima jednostavan nacin da budu u toku sa potražnjom i aktuelnim konkursima.
Na Vama je samo da kreirate profil, date nam potrebne informacije a zatim sacekate da Vas uz pomoc svoje “networking” magije spojimo s pravim ljudima!

## Procesi

**-Registracija korisnika (Sign up)**
	Postoje dvije vrste korisnika: poslodavci i osobe koje traže posao.
	U odnosnu na odabir prikazat će se određena forma za registraciju, te će korisnici unijeti svoje podatke.

**-Prijava korisnika (Log in)**
	Korisnik se prijavljuje na sistem i biva preusmjeren na početnu stranicu. Kompanije i korisnici će moći 
	vidjeti obavijesti vezane za posao (konkurse, prijave na konkurse i sl.)

**-Menadžment konkursa**
	Poslodavci će moći objaviti konkurs za posao sa detaljnim specifikacijama (lokacija, opis posla, stručna sprema,
	isustvo, datum isteka konkursa). Moguće je postaviti privatnost, da je konkurs vidljiv gostima i 
	registrovanim korisnicima.
	Prije isteka roka poslodavac može obrisati konkurs.
	Korisnici (osobe koje traže posao) mogu pretraživati konkurse na osnovu određenih kriterija.

**-Obavještenja i prikaz prijava**
	Korisnici koji su zainteresovani za posao mogu se prijaviti na konkurs.
	Prilikom prijave korisnika na konkurs poslodavac će dobiti obavještenje. Poslodavac će također biti u mogućnosti
	pregledati sve prijave sa kratkim detaljima o prijavljenim korisnicima.
	Poslodavac može pozvati korisnika na interviju, prilikom poziva korisnik će dobiti obavijest.
	Korisnik može postaviti nivo obavještenja, npr. ako neki konkurs bude objavljen u blizini korisnik će biti 
	obaviješten putem notifikacija.

**-Pregled profila**
	Korisnici mogu pregledati profile poslodavaca. Poslodavci mogu pregledati profile korisnika koji u postavkama
	ne odaberu opciju da im je profil sakriven. Poslodavci mogu pregledati profile svih prijavljenih na konkurs bez
	obzira na postavke.

**-Komunikacija**
	Komunikacija između poslodavaca i korisnika putem poruka, maila, kamere i notifikacija.
	Poslodavac može obaviti razgovor sa korisnikom preko našeg servisa putem poruka ili kamere.

**-Oglašavanje**
	Poslodavci mogu zakupiti oglasni prostor koji se odnosi na prikaz konkursa ili oglasni prostor za kompaniju.
	Koristit će neki od servisa za plaćanje. (npr. Paypal)
	Na stranici će se prikazivati i Google AdSense oglasi.
	
**-Statistika**
	Prikaz statistike vezane za broj objavljenih oglasa, broj prijavljenih, broj dodijeljenih poslova itd.

**-Kontrola sistema**
	Administrator sistema može pregledati korisničke podatke i brisati poslodavce i korisnike koji pokušaju
	zloupotrijebiti sistem.

**-Brisanje profila**
	Mogućnost brisanja profila poslodavaca i korisnika na zahtjev.


##Funkcionalnosti:
* Sign Up - Registrovanje nezaposlenih i poslodavaca (na formi za registrovanje bira se tip clana)
* Login - Zajednicki za sve clanove (na osnovu korisnièkog imena odreðuje se tip korisnika)
* Mogucnost objavljivanja konkursa (poslodavci)
* Mogucnost pregleda prijavljenih na konkurs (poslodavci)
* Mogucnost izmjene konkursa i statusa konkursa (poslodavci)
* Mogucnost brisanja konkursa (poslodavci)
* Mogucnost pregleda svih objavljenih konkursa i konkursa unutar struke nezaposlenog (nezaposleni)
* Mogucnost prijave na konkurs (nezaposleni)
* Mogucnost oznacavanja konkursa kao favorit i pregleda favorita (nezaposleni)
* Mogucnost izmjene podataka na profilu (nezaposleni i poslodavci)
* Mogucnost pretrage (Search) konkursa (nezaposleni i poslodavci)
* Mogucnost pregleda profila poslodavaca i nezaposlenih
* Mogucnost brisanja profila (nezaposleni i poslodavci)
* Obavjestavanje poslodavaca ako postoje zainteresovani za konkurs
* Obavjestavanje nezaposlenih kada izadju konkursi u njihovoj struci

 
##Akteri

1. **Gost** - gost je osoba koja ima mogućnost da pregleda javne raspisane konkurse 
2. **Registrovana osoba koja traži posao** - registrovana osoba koja traži posao je osoba koja ima mogućnost da pregleda svaki raspisani konkurs, bio on javni ili privatni, te da se i prijavi na željene konkurse
3. **Registrovani poslodavac** - registrovani poslodavac je osoba koja stoji ispred svoje firme i raspisuje konkurs za slobodno radno mjesto; ona ima privilegije gledanja osobnih podataka i dokumenata, koje su poslali registrovani korisnici koji traže posao zainteresovani za njihov raspisani konkurs, te na osnovu istih poslodavac može pozvati na intervju korisnike za koje smatra da posjeduju adekvatne vještine i znanje
4. **Administrator sistema** - administrator sistema je osoba koja ima odobrene privilegije za pristup podacima registovanih korisnika; njegova glavna uloga je nadgledanje sistema i ažuriranje u slučaju prijava na lažne konkurse, lažne profile itd.
5. **Sistem JobRadar** - sistem JobRadar je zadužen za validaciju i procesiranje zahtijeva koje ostali akteri šalju (npr. zahtjev za komunikaciju, validacija korisničkog imena i šifre prilikom prijave, obrada zahtjeva za plaćanje oglasnog prostora, itd.)

##Help

Koristi se baza MSQL, local.
Eksterni uredjaj je kamera. 
 - realizirana je u klasi CameraHelper (https://github.com/ooad-2015-2016/So-far-so-good/blob/master/ProjekatJobRadar/JobRadar/JobRadarBaza/Models/CameraHelper.cs)  - poziva se u klasi KorisnikViewModel (https://github.com/ooad-2015-2016/So-far-so-good/blob/master/ProjekatJobRadar/JobRadar/JobRadarBaza/ViewModels/KorisnikViewModel.cs)
Validacija je ispostovana u formama:
 - LogInForma (https://github.com/ooad-2015-2016/So-far-so-good/blob/master/ProjekatJobRadar/JobRadar/JobRadarBaza/Views/LogInForma.xaml)
 - RegistracijaPoslodavca (https://github.com/ooad-2015-2016/So-far-so-good/blob/master/ProjekatJobRadar/JobRadar/JobRadarBaza/Views/RegistracijaPoslodavca.xaml)
-  RegistracijaForma (https://github.com/ooad-2015-2016/So-far-so-good/blob/master/ProjekatJobRadar/JobRadar/JobRadarBaza/Views/RegistracijaForma.xaml)
Prilagodjavanje Windows Phone:
 - provjera za prednju i zadnju kameru unutar CameraHelper (https://github.com/ooad-2015-2016/So-far-so-good/blob/master/ProjekatJobRadar/JobRadar/JobRadarBaza/Models/CameraHelper.cs)
Web servis:
Projekat : https://github.com/ooad-2015-2016/So-far-so/good/tree/master/ProjekatJobRadar/JobRadarWeb
