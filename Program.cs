using DesafioPOO.Models;

Smartphone cellNokia = new Nokia("0000000000", "Windows 3", "15532F36", 128);
Smartphone cellIphone = new Iphone("0000000000", "X", "Q5R32F36", 64);

cellNokia.InformacoesdoSmartphone();
cellIphone.InformacoesdoSmartphone();

cellNokia.InstalarAplicativo("Twitter");
cellIphone.InstalarAplicativo("Steam");

cellNokia.Numero = "0123456789";
cellIphone.Numero = "9876543210";

cellNokia.Ligar();
cellIphone.Ligar();

cellNokia.ReceberLigacao();
cellIphone.ReceberLigacao();


cellNokia.InformacoesdoSmartphone();
cellIphone.InformacoesdoSmartphone();