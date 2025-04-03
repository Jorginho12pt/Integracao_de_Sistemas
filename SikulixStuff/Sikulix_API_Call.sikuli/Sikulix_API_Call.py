import ssl
import json
import urllib2  # Works in Jython (SikuliXs Python version)
from javax.swing import JOptionPane  # For message pop-ups

# Disable SSL verification (avoids certificate errors)
ssl_context = ssl._create_unverified_context()

def send_api_request():
    try:
        # Data to send (equivalent to C# DesktopTeste object)
        teste = {
            "DataHora": "2025-04-03T12:00:00Z",  # Replace with real input
            "CodigoPeca": "bb123457",  # Replace with real input
            "TempoProduco": 10,  # Replace with real input
            "ResultadoTeste": "1"  # Replace with real input
        }

        json_data = json.dumps(teste)  # Convert dictionary to JSON string
        url = "https://localhost:7252/Api/InsertTesteSP"

        # Create request
        request = urllib2.Request(url, data=json_data, headers={"Content-Type": "application/json"})

        # Send request with SSL disabled
        response = urllib2.urlopen(request, context=ssl_context)

        # Read response
        response_data = response.read()
        
        # Show response in a pop-up
        JOptionPane.showMessageDialog(None, "Response: " + response_data)

    except Exception as e:
        JOptionPane.showMessageDialog(None, "Error: " + str(e), "Erro", JOptionPane.ERROR_MESSAGE)

# Run the function
send_api_request()
