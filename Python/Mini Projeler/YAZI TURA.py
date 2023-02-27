import random, time
while True:
    print("Yazı Tura için = 1")
    try:
        b=int(input(" :"))
    except ValueError:
            print("Lütfen doğru sayıyı giriniz ")
            b=int(input("Yazı Tura için = 1 :"))
    if b==1:
        a=random.randint(1,2)
        time.sleep(0.5)
        print("Yazı, Tura atılıyor ve...")
        time.sleep(1)
        if a==1:
            print("Yazı çıkdı")
            time.sleep(0.5)
            c=input(" Bizi tercih etiğiniz için teşekkürler ")
        elif a==2:
            print("Tura çıkdı")
            time.sleep(0.5)
            c=input(" Bizi tercih etiğiniz için teşekkürler ")
    elif b!=1:
        print("Malesefki yanlış komut girdiniz Lütfen tekrar deneyin")
        time.sleep(1)