import requests
from bs4 import BeautifulSoup

def scrap(link):
    page = requests.get(link)
    soup = BeautifulSoup(page.content, 'html.parser')
    for ad in soup.find_all(class_ = 'adsbygoogle'):
        ad.decompose()

    for header in soup.find_all('header'):
        header.decompose()

    for footer in soup.find_all('footer'):
        footer.decompose()

    for img in soup.find_all('img'):
        img.decompose()

    soup.find(id='comments').decompose()

    return soup.find(id='main')

# Press the green button in the gutter to run the script.
if __name__ == '__main__':
# 2, 3, 12, 17, 25
    for ch in range(1,30):
    
        content = scrap(link='https://www.kseebsolutions.com/1st-puc-hindi-textbook-answers-sahitya-vaibhav-chapter-' + str(ch))

        with open("chapter"+str(ch)+".html", "w", encoding='utf-8') as file:
            file.write(str(content))


