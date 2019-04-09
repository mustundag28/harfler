# HARFLER
Girilen metin tek harf, iki harf ve üç harf üzerinden olasılıkları hesaplanarak uygulanır. 
Program Windows Masaüstü (Desktop) uygulamasıdır. 
C# dilinde yazılmıştır. 
MS Office Access veritabanını kullanır. 
Microsoft Visual Studio uygulama geliştirme ortamı (IDE) kullanılmıştır.

#Önemli Uyarı:

projenin üstüne sağ tuşla Properties -> Build sekmesine ->geçin.
Platform Target -> x86’yı seçin ve Apply diyerek sorunsuz çalışmasını sağlayın.

#
Metin üzerinde gerekmeyen ifadeler ayıklanır.
Boşluk karakterleri ayıklama işlemidir.
	                   text = text.Trim();

Türkçe karakter için yer değiştirme(replace) fonksiyonu kullanarak büyük harf(upper) yapıyoruz.
                text = text.Replace("ı", "I");
                text = text.Replace("i", "İ");
                text = text.Replace("ğ", "Ğ");
                text = text.Replace("ü", "Ü");
                text = text.Replace("ö", "Ö");
                text = text.Replace("ş", "Ş");

Büyük harflere çeviriyoruz.
                text = text.ToUpper();

Tekli Harfler
	Girilen metin sonuna kadar döngüde kalır. Sıradaki her harf için Microsoft Access veritabanında TEKLI tablosunda olasılık kolonu bir arttırılarak kaydedilir. Fonksiyon:
private void tekliHarf(string girdi)
        {
            Fonksiyon Girdiğimiz metin “ab” olsun. “a”yı ve “b”yi işleyeceğiz. Döngü sayısı uzunluk (Lenght) oldu. 
            …
Veritabanı kodları…            

Veritabanı komutu için “cmdText” değişkenini kullanıyoruz.
            string cmdText = "";

Olasılık için “ihtimal” değişkenini kullanıyoruz.
            int ihtimal = 0;
,
Döngü buradan başlıyor.
            for (int i = 0; i < girdi.Length; i++)
            {
…
Tekli tablosundan döngü sırasındaki harfin olasılığını sorgulayıp çalıştırıyoruz.
cmdText = "select OLASILIK from TEKLI WHERE HARF = '" + girdi[i] + "'";
…
Sorgu sonucu dönen değeri tamsayıya çevirip ihtimal değişkenine atıyoruz. Değişkeni bir arttırıyoruz.
ihtimal = Int32.Parse(dt.Rows[0][0].ToString());
                    ihtimal++;
…

