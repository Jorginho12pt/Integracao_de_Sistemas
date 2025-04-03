from sikuli import *

# Step 1: Locate the application window
if exists("DesktopApp-1.png"):  # Ensure the app is open
    print("App found!")

    # Step 2: Extract text from the textboxes
    data_horaImage = (Region(176,119,110,17))  
    codigo_pecaImage = (Region(191,146,204,19))  
    tempo_producaoImage = (Region(267,171,127,20))  
    resultado_testeImage = (Region(203,195,177,22))  

    data_hora = data_horaImage.text()
    codigo_peca =  codigo_pecaImage.text()
    tempo_producao = tempo_producaoImage.text()
    resultado_teste = resultado_testeImage.text()

    # Step 3: Print extracted values
    print("DataHora:", data_hora)
    print("CodigoPeca:", codigo_peca)
    print("TempoProduco:", tempo_producao)
    print("ResultadoTeste:", resultado_teste)

else:
    print("Application not found!")