import requests
import json
import sys

api_url = "https://localhost:7252/Api/InsertTesteSP"

data_hora, codigo_peca, tempo_producao, resultado_teste = sys.argv[1], sys.argv[2], sys.argv[3], sys.argv[4]

payload = {
    "dataHora": data_hora,
    "codigoPeca": codigo_peca,
    "tempoProducao": int(tempo_producao),
    "resultadoTeste": resultado_teste
}

response = requests.post(api_url, json=payload)
print("Payload success:", response.status_code, response.text)