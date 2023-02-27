import requests
from lxml import html
from prettytable import PrettyTable

# links.txt dosyasındaki linkleri yükle
with open("links.txt", "r") as f:
    links = f.read().splitlines()

xpath = "/html/body/div[1]/div[3]/div/div[1]/div/div[2]/div[4]/div/div[1]/a"

table = PrettyTable()
table.field_names = ["Sonraki Bölüm Var mı?", "Link"]

for link in links:
    response = requests.get(link)
    tree = html.fromstring(response.content)
    next_button = tree.xpath(xpath)
    if next_button:
        next_link = next_button[0].get('href')
        table.add_row(["Sonraki Bölüm Mevcut :", next_link])
print(table)

# Önce izlediğim bölümlerin linklerini giriyorum
while True:
    link = input("İzlediğiniz bölümün linkini girin (çıkmak için q): ")
    if link == 'q':
        break
    
    if link in links:
        new_b_link = input("Yeni bölüm linkini girin : ")
        index = links.index(link)
        links[index] = new_b_link
        print(f"{link} linki, {new_b_link} ile değiştirildi.")
        
        # links.txt dosyasını güncelle
        with open("links.txt", "w") as f:
            for link in links:
                f.write(link + "\n")
    else:
        print(f"{link} linki, listede bulunamadı.")
