archeagebot
===========

Основа примитивного pixel-finding бота для русской версии игры Archeage на C#

===========

Проект в стадии "Поматросил и бросил", заниматься им я больше не буду. Некоторый функционал на момент релиза не работает (интерфейс поменялся с ЗБТ, хоть на глаз возможно и не заметно). Рефакторинг не производил, выложил бота в состоянии на момент окончания ЗБТ.

Ядро программы - функция FindForm, которая получает структуру, описывающую какой-либо элемент интерфейса, и осуществляет поиск по "скриншоту" окна ArcheAge (которое на момент релиза должно иметь только расширение только 1024х768, иначе фиг че найдет, так как формы привязаны к пикселям очень жестко).

На примере покажу принцип работы:
Структура содержит 2 основных параметра: OffsetX и OffsetY, которая задает координаты поиска.

Из кода:
===========

<pre>
...
int YellowTextMaxR = 245;
int YellowTextMinR = 135;
int YellowTextMaxG = 160;
int YellowTextMinG = 80;
int YellowTextMaxB = 55;
int YellowTextMinB = 20;

/* Форма буквы F */
new VisionForm(){
    OffsetX = 0, 
    OffsetY = 0, 
    MaxR = YellowTextMaxR,
    MinR = YellowTextMinR,
    MaxG = YellowTextMaxG,
    MinG = YellowTextMinG,
    MaxB = YellowTextMaxB,
    MinB = YellowTextMinB,
    Object = true
},
new VisionForm(){
    OffsetX = 0, 
    OffsetY = 1, 
    MaxR = YellowTextMaxR,
    MinR = YellowTextMinR,
    MaxG = YellowTextMaxG,
    MinG = YellowTextMinG,
    MaxB = YellowTextMaxB,
    MinB = YellowTextMinB,
    Object = true
},
new VisionForm(){
    OffsetX = 0, 
    OffsetY = 2, 
    MaxR = YellowTextMaxR,
    MinR = YellowTextMinR,
    MaxG = YellowTextMaxG,
    MinG = YellowTextMinG,
    MaxB = YellowTextMaxB,
    MinB = YellowTextMinB,
    Object = true
},
new VisionForm(){
    OffsetX = 0, 
    OffsetY = 3, 
    MaxR = YellowTextMaxR,
    MinR = YellowTextMinR,
    MaxG = YellowTextMaxG,
    MinG = YellowTextMinG,
    MaxB = YellowTextMaxB,
    MinB = YellowTextMinB,
    Object = true
},
new VisionForm(){
    OffsetX = 0, 
    OffsetY = 4, 
    MaxR = YellowTextMaxR,
    MinR = YellowTextMinR,
    MaxG = YellowTextMaxG,
    MinG = YellowTextMinG,
    MaxB = YellowTextMaxB,
    MinB = YellowTextMinB,
    Object = true
},
new VisionForm(){
    OffsetX = 0, 
    OffsetY = 5, 
    MaxR = YellowTextMaxR,
    MinR = YellowTextMinR,
    MaxG = YellowTextMaxG,
    MinG = YellowTextMinG,
    MaxB = YellowTextMaxB,
    MinB = YellowTextMinB,
    Object = true
},
new VisionForm(){
    OffsetX = 0, 
    OffsetY = 6, 
    MaxR = YellowTextMaxR,
    MinR = YellowTextMinR,
    MaxG = YellowTextMaxG,
    MinG = YellowTextMinG,
    MaxB = YellowTextMaxB,
    MinB = YellowTextMinB,
    Object = true
},
new VisionForm(){
    OffsetX = 0, 
    OffsetY = 7, 
    MaxR = YellowTextMaxR,
    MinR = YellowTextMinR,
    MaxG = YellowTextMaxG,
    MinG = YellowTextMinG,
    MaxB = YellowTextMaxB,
    MinB = YellowTextMinB,
    Object = true
},
...
</pre>

===========

В данном примере мы задаем структуру где будем искать желтую палку высотой 8 пикселей. Ища эту форму чуть ниже центра экрана мы можем получить true когда появится взаимодействие на букву F. Так как фон окружения, день, ночь влияют на цвет палки мы задаем цветовую погрешность. В данном примере красный цвет должен быть в диапазоне между 135 и 245. Если какой-то цвет не попал в этот диапазон - это не наша желтая палка.

Для получения этих данных я использовал фотошоп на максимальном увеличении холста для получения больших квадратных пикселей для задания оффсетов, а дальше по нескольким скринам на белом-черном фоне определял цветовую погрешность.

Комбинируя оффсеты и нужные диапазоны цветов можно запилить даже определить куда смотрит персонаж (по "фонарику" на миникарте справа сверху) и его координаты. Кстати это и сейчас работает :)

ПС: На вопросы по коду не отвечаю ибо забил на проект так как скучно (дикий спам, дикий донат, игнорирования возможностей хакщилда... дикикй похуизм майлру), критику при объяснения лучшего варианта исполнения принимаю и благодарю ^_^
