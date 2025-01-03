### Векторный графический редактор  

Для представления каждого из примитивов были разработаны соответсвующее классы. Для линий – класс Lines, для кривых Эрмита – класс HermitSpline, для фигур (параллелограмм и стрелка) – класс Shape. Каждый класс содержит свои собственные конструкторы и методы.  

Алгоритм выделения, основанный на алгоритме закрашивания:  
1. Последовательно просматривая список вершин (P1, P2, . . , Pn), найти границы сканирования Ymin и Ymax.  
2. Для каждой строки Y из [Ymin . . Ymax] выполнить п.п. 2.1. – 2.4.  
2.1. Очистить список Xb.  
2.2. Для всех i из [1. . n] выполнить п. 2.2.1. – 2.2.2.  
2.2.1. Если i < n, то k = i + 1, иначе k = 0.  
2.2.2. Если ((yi < Y) и (yk >= Y)) или ((yi >= Y) и (yk < Y)), то  
вычислить координату x точки пересечения стороны Pi Pk  
со строкой Y и записать в Xb.  
2.3. Отсортировать список Xb по возрастанию.  
2.4.  Последовательно просматривая список Xb и сверяя координаты х фигуры с координатами мыши определяется, выделена фигура или нет.  

Класс Shape содержит в себе методы геометрических преобразований: moveShape – плоско-параллельное перемещение, reflectionShape1 - отражение относительно центра фигуры, reflectionShape2 - отражение относительно прямой общего положения, zoomShapeX - масштабирование по оси Х относительно заданного центра.  

Окно программы при запуске:  

<img src="https://github.com/user-attachments/assets/f1260b51-bef8-4eb4-b205-16bdc6548593" width="500" />  

Для выбора цвета рисования следует нажать на кнопку с изображением палитры цветов. Для выбора примитива в группе «Примитивы» следует нажать на кнопку с соответствующим изображением примитива.  
Чтобы нарисовать линию необходимо нажать на кнопку с ее изображением и поставить две точки на области вывода. 
Чтобы нарисовать кривую Эрмита необходимо нажать на кнопку с ее изображением и поставить 4 точки на области вывода: две первые задают начальную точку и касательный вектор из нее; две последние задают конечную точку и касательный вектор из нее.  
Чтобы нарисовать параллелограмм необходимо нажать на кнопку с его изображением и поставить точку на области вывода, где и появится фигура.  
Чтобы нарисовать стрелку необходимо нажать на кнопку с ее изображением и поставить точку на области вывода, где и появится фигура.  
Для установления высоты и ширины фигур (параллелограмм и стрелка) следует в соответствующие текстовые поля ввести значения.  

Результат размещения примитивов:  

<img src="https://github.com/user-attachments/assets/a57942cd-b052-426a-8946-a44a8a480b82" width="500" />  

Для выбора фигуры и ее перемещения следует нажать на кнопку выбора и затем на фигуру. 
Результат перемещения фигур, созданных ранее:  

<img src="https://github.com/user-attachments/assets/2d20167a-d10f-443f-bb16-44b308b942b3" width="500" />  

Для выполнения геометрических преобразований следует нажать на кнопку выбора, выбрать фигуру нажатием по ней, после чего нажать на соответствующую кнопку в группе «Геометрические преобразования». 
Для выполнения зеркального отражения относительно центра фигуры следует нажать кнопку и затем на выбранную фигуру.  
Для выполнения зеркального отражения относительно прямой общего положения следует нажать кнопку и затем расставить две точки на области вывода для задания прямой.  
Для выполнения масштабирования по оси Х относительно заданного центра следует нажать кнопку и затем на область для выбора цента, относительно которого будет происходить преобразование.  
Затем, не отпуская ЛКМ, двигать вправо для растяжения фигуры, и влево - для сжатия.  
Результат произведенных операций над фигурами:  

<img src="https://github.com/user-attachments/assets/cb766b00-a7e4-434a-bca0-6d2d670e6db5" width="500" />  

Для выполнения ТМО над двумя фигурами следует нажать на кнопку с изображением нужной ТМО и затем поочередно на две нужные фигуры. Результат разности стрелок:  

<img src="https://github.com/user-attachments/assets/12361f02-ac90-4036-8656-5a173879715a" width="500" />  

<img src="https://github.com/user-attachments/assets/8eb1f422-d865-4c35-9d12-3ea3ef14d58b" width="500" />  

Для удаления фигуры следует выбрать фигуру кнопкой выбора и нажать на кнопку «Удалить фигуру».  
Для очищения области вывода следует нажать на кнопку «Очистить все».  









