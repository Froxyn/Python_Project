from prettytable import PrettyTable
import datetime
import os
import time

# Gider ve gelirlerin kaydedileceği dosya adı
giderler_dosya = "giderler.txt"
gelirler_dosya = "gelirler.txt"

# Dosyaların var olup olmadığını kontrol et ve yoksa dosyaları oluştur
if not os.path.exists(giderler_dosya):
    open(giderler_dosya, 'w').close()
if not os.path.exists(gelirler_dosya):
    open(gelirler_dosya, 'w').close()

# Giderleri ve gelirleri dosyadan yükle
with open(giderler_dosya, "r") as f:
    giderler = [tuple(line.strip().split("|")) for line in f.readlines()]
    giderler = [(datetime.datetime.strptime(tarih, "%Y-%m-%d %X"), float(miktar), açıklama) for tarih, miktar, açıklama in giderler]

with open(gelirler_dosya, "r") as f:
    gelirler = [tuple(line.strip().split("|")) for line in f.readlines()]
    gelirler = [(datetime.datetime.strptime(tarih, "%Y-%m-%d %X"), float(miktar), açıklama) for tarih, miktar, açıklama in gelirler]

# Kasa bakiyesi
kasa_bakiyesi = 0

# Giderleri ve gelirleri topla
gider_toplam = 0
gelir_toplam = 0
gider_toplam = sum(miktar for _, miktar, _ in giderler)
gelir_toplam = sum(miktar for _, miktar, _ in gelirler)

# Kasa bakiyesi hesapla
kasa_bakiyesi += gelir_toplam - gider_toplam

# Ana döngü
while True:
    time.sleep(0.2)
    # Menüyü göster
    print("=" * 30)
    print("*-" * 3+"*" , "KASA PROGRAMI","*-" * 3+"*" )
    print("=" * 30)
    print("1. Gelir ekle")
    print("2. Gider ekle")
    print("3. Günlük kasa raporu")
    print("4. Tüm Verileri Sil")
    print("5. Çıkış Yap")

    # Kullanıcının seçimini al
    seçim = input("Seçiminiz: ")
    if seçim == "1":
        # Gelir ekle
        miktar = float(input("Gelir miktarı: "))
        açıklama = input("Açıklama: ")
        tarih = datetime.datetime.now()
        gelirler.append((tarih, miktar, açıklama))
        kasa_bakiyesi += miktar
        print("Gelir başarıyla eklendi!")
        # Gelir defterine kaydet
        with open(gelirler_dosya, "a") as f:
            f.write(f"{tarih.strftime('%Y-%m-%d %X')}|{miktar}|{açıklama}\n")
        miktar = 0
            
    elif seçim == "2":
        # Gider ekle
        miktar = float(input("Gider miktarı: "))
        açıklama = input("Açıklama: ")
        tarih = datetime.datetime.now()
        giderler.append((tarih, miktar, açıklama))
        kasa_bakiyesi -= miktar
        print("Gider başarıyla eklendi!")
        # Gider defterine kaydet
        with open(giderler_dosya, "a") as f:
            f.write(f"{tarih.strftime('%Y-%m-%d %X')}|{-miktar}|{açıklama}\n")
        miktar = 0
            
    elif seçim == "3":
        kasa_bakiyesi = 0
        # Günlük kasa raporu
        kasa_bakiyesi -= gider_toplam
        kasa_bakiyesi += gelir_toplam
        rapor = PrettyTable()
        rapor.field_names = ["Tarih", "Gelir/Gider", "Açıklama"]
        print("Gün Sonu Raporu Alınıyor...")
        time.sleep(1.4)
        for tarih, miktar, açıklama in gelirler:
            kasa_bakiyesi += miktar
            rapor.add_row([tarih.strftime("%Y-%m-%d %X"), f"+{miktar:.2f}", açıklama])
        
        for tarih, miktar, açıklama in giderler:
            kasa_bakiyesi -= miktar
            rapor.add_row([tarih.strftime("%Y-%m-%d %X"), f"{miktar:.2f}", açıklama])
            
        rapor.add_row(["", "", ""])
        print(rapor)
        time.sleep(0.5)
            

    elif seçim == "4":
        if os.path.exists("giderler.txt") and os.path.isfile("giderler.txt"):
            os.remove("giderler.txt")
            os.remove("gelirler.txt")
            
            # Dosyaların var olup olmadığını kontrol et ve yoksa dosyaları oluştur
            if not os.path.exists(giderler_dosya):
                open(giderler_dosya, 'w').close()
            if not os.path.exists(gelirler_dosya):
                open(gelirler_dosya, 'w').close()

            # Giderleri ve gelirleri dosyadan yükle
            with open(giderler_dosya, "r") as f:
                giderler = [tuple(line.strip().split("|")) for line in f.readlines()]
                giderler = [(datetime.datetime.strptime(tarih, "%Y-%m-%d %X"), float(miktar), açıklama) for tarih, miktar, açıklama in giderler]

            with open(gelirler_dosya, "r") as f:
                gelirler = [tuple(line.strip().split("|")) for line in f.readlines()]
                gelirler = [(datetime.datetime.strptime(tarih, "%Y-%m-%d %X"), float(miktar), açıklama) for tarih, miktar, açıklama in gelirler]
            print(" Veriler Başarıyla Silindi!")
            time.sleep(0.5)
            
        else:
            #Veri Bulunamazsa Bildir
            time.sleep(0.2)
            print("Lütfen Uygulamayı Yeniden Başlatmayı Deneyiniz.")
            print("Veriler Bulunamadı!")
            time.sleep(0.2)
            
    elif seçim == "5":
        # Çıkış yap
        break
        
    else:
        print("Geçersiz seçim!")
