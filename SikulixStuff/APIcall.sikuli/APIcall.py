from sikuli import *

# Capture text from the desktop app
data_hora = Region(100, 200, 300, 50).text()
codigo_peca = Region(400, 200, 200, 50).text()
tempo_producao = Region(600, 200, 100, 50).text()
resultado_teste = Region(800, 200, 50, 50).text()

# Run the external Python script
command = "python SendData.py \"%s\" \"%s\" \"%s\" \"%s\"" % (data_hora, codigo_peca, tempo_producao, resultado_teste)
run(command)
Region(585,281,205,52)