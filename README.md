# SCP-217
Полная документация здесь: https://scpfoundation.net/scp-217
# Принцип работы
С шансом(установленным в конфиге) при использовании SCP-914 вы можете заразиться SCP-217  
После чего болезнь начнет развиваться, через (установленные в конфиге) минут вы начнете умирать
Вирус отнимает (установленный в конфиге) процент от максимального здоровья
В любой момент вы можете вылечиться от вируса выпив SCP-207
# SCP-217-6
Если вы все-таки погибли именно от вируса, вы моментально станете SCP-217-6 
SCP-217-6 имеет 1000 здоровья, сам по себе он как SCP-049-2
Если попытаться убить SCP-217-6 при помощи MICRO-HID, то во время получения урона он будет оглушен
# Структура конфига
| Имя  | Описание  | Тип | Стандартное значение 
|:-------------   |:---------------:|:-------------:| -------------:
| IsEnabled       |  Включение/Выключение плагина   | Boolean       | True
| Debug           |  Включение/Выключение дебага     | Boolean       | False
| InfectionChance |  Шанс заражения вирусом         | Double        | 40.50
| MinutesToDie    |  Время до начала действия SCP-273(в минутах) | Intenger | 1
| HealthP         |  Процент максимального здоровья которое отнимается раз в 3 секунды | Intenger | 15
# Зачем нужен этот плагин?
В целом это идеальный плагин для NonRP серверов, однако я бы не рекомендовал его ставить на сервера с элементами RP
