import time
while True:
    print("""
          ____________________
          
          1=TOPLAMA
          --------------------
          2=ÇIKARMA
          --------------------
          3=ÇARPMA
          --------------------
          4=BÖLME
          --------------------
          Çıkmak için "X"
          ____________________
          Lütfen yapmak istediğiniz işlemi seçiniz...
          """)
    islem=input("___: ")
    if islem == "x" or islem == "X":
            print("ÇIKILIYOR...")
            quit()
    elif islem=="1" or "TOPLAMA" or "toplama":
        time.sleep(0.5)
        print("TOPLAMAK İSTEDİĞİNİZ İKİ SAYIYI GİRİNİZ")
        sayı1=int(input("1.SAYI :"))
        sayı2=int(input("2.SAYI :"))
        print("HESAPLANILIYOR...")
        time.sleep(1)
        print("İŞLEMİNİZİN SONUCU", sayı1+sayı2)
        time.sleep(3)
    elif islem=="2" or islem=="ÇIKARMA" or islem=="çıkarma":
        time.sleep(0.5)
        print("ÇIKARMAK İSTEDİĞİNİZ İKİ SAYIYI GİRİNİZ")
        sayı1=int(input("1.SAYI :"))
        sayı2=int(input("2.SAYI :"))
        print("HESAPLANILIYOR...")
        time.sleep(1)
        print("İŞLEMİNİZİN SONUCU", sayı1-sayı2)
        time.sleep(3)
    elif islem=="3" or islem=="ÇARPMA" or islem=="ÇARPMA":
        time.sleep(0.5)
        print("ÇARPMAK İSTEDİĞİNİZ İKİ SAYIYI GİRİNİZ")
        sayı1=int(input("1.SAYI :"))
        sayı2=int(input("2.SAYI :"))
        print("HESAPLANILIYOR...")
        time.sleep(1)
        print("İŞLEMİNİZİN SONUCU", sayı1*sayı2)
        time.sleep(3)
    elif islem=="4" or islem=="BÖLME" or islem=="bölme":
        time.sleep(0.5)
        print("BÖLMEK İSTEDİĞİNİZ İKİ SAYIYI GİRİNİZ")
        sayı1=int(input("1.SAYI :"))
        sayı2=int(input("2.SAYI :"))
        print("HESAPLANILIYOR...")
        time.sleep(1)
        print("İŞLEMİNİZİN SONUCU", sayı1/sayı2)
        time.sleep(3)
    else :
        print("LÜTFEN GEÇERLİ BİR İŞLEM GİRİNİZ")
        time.sleep(2)
        print(" ")
