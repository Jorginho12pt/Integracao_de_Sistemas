https://www.rabbitmq.com/docs/management
https://www.rabbitmq.com/tutorials/tutorial-one-dotnet

------------CMD do RabbitMQ------------
C:\Program Files\RabbitMQ Server\rabbitmq_server-4.1.0\sbin>

------------enable RabbitMQ UI------------
rabbitmq-plugins enable rabbitmq_management  

------------new user admin------------
rabbitmqctl.bat add_user  1 2  
rabbitmqctl set_user_tags 1 administrator 
rabbitmqctl set_permissions -p / 1 ".*" ".*" ".*"

------------RabbitMQ UI------------
http://localhost:15672/


------------Perceber RabbitMQ-------------
basico: https://www.youtube.com/watch?v=sN5YpfOpCHA
Crirar loop para Consumidor as mensaguens: https://www.youtube.com/watch?v=XA_3CZmD9y0

----------RabbitMQ Stream-------------
https://www.rabbitmq.com/tutorials/tutorial-one-dotnet-stream

------------enable RabbitMQ Stream------------
rabbitmq-plugins enable rabbitmq_stream

------------DataGridView--------------------
https://www.youtube.com/watch?v=GyLlpBZGsrE

Notas:
	não usar Console.WriteLine mas sim -> Debug.WriteLine
	RAFA se te tiver a dar erros da update ao teu .net : https://dotnet.microsoft.com/en-us/download/dotnet
	tool que usei para atualizar os projetos: https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.upgradeassistant




















