from sikuli import *

if exists(Pattern("DescktopApp.png").similar(0.40)):
    print("App found, starting data fetch")

    data_horaImage = (Region(122,68,117,17))  
    codigo_pecaImage = (Region(137,92,63,20))  
    tempo_producaoImage = (Region(216,121,22,15))  
    resultado_testeImage = (Region(151,139,172,30))  

    data_hora = data_horaImage.text();
    codigo_peca =  codigo_pecaImage.text();
    tempo_producao = tempo_producaoImage.text();
    resultado_teste = resultado_testeImage.text();

    print("DataHora:", data_hora)
    print("CodigoPeca:", codigo_peca)
    print("TempoProduco:", tempo_producao)
    print("ResultadoTeste:", resultado_teste)

    command = "python SendData.py \"%s\" \"%s\" \"%s\" \"%s\"" % (data_hora, codigo_peca, tempo_producao, resultado_teste)
    run(command)

else:
    print("Error finding aplication. Make sure window is visible and restart")

