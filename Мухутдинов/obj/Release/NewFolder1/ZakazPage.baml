   M S B A M L   `   `   `  ���� O  KМухутдинов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Мухутдинов.NewFolder1Мухутдинов.NewFolder1  /    )Мухутдинов.NewFolder1.ZakazPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ?local-clr-namespace:Мухутдинов.NewFolder1     -     N� Title$  
Заказ��.���  � RowDefinitions ��  � ColumnDefinitions �� $��2* ��� $��1* �.+��� .���� 
�������.+��� $	��134��$��17���� $8�2Поиск по наименованию книг:���� -    ��Name$ ZakazNameSearchField��$	��199��$��0,0,15,0q��� -    ��Name$ ZakazSearchButton��$��80��$��
Поиск��&   System.Windows.Controls.DataGrid  -     Name$ ZakazDataGrid��   AutoGenerateColumns .     CanUserAddRows .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 	ID_zakaza��-   ZakazIDzakazaColumn��
   
Visibility$
 	Collapsed=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	ID_zakaza+ �� Mode$ TwoWay=�  $	 Дата заказа��-   ZakazDatezakazaColumn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2*  �� *Date_zakaza+ �� StringFormat$ dd.MM.yy��$ TwoWay=�  $!	 Название книги��-   ZakazNazvanieknigiColumn��$ 2*  �� *Nazvanie_knigi+$ TwoWay=�  $	 Цена��-   ZakazPriceColumn��$ 2*  �� *Price+$ TwoWay=�  $	 Количество��-	   ZakazKolichestvoColumn��$ 2*  �� *Kolichestvo+$ TwoWay=��� -
   $��Экспорт в Excel��$
��Left=�$��
10,243,0,0q�$��15(�$	��Top=�$	��114��$��1��$��34���� $��Center=�$��Center=�$��1���� -   $ 
ZakazTable��$��Обновить��$��1��$
��Left=�$��
10,199,0,0q�$��20(�$	��Top=�$	��114��$��36���� -   $��Добавить��$��1��$
��Left=�$��136,197,0,0q�$��20(�$	��Top=�$	��114��$��36�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$
 0.09Q�T� �� -   $��Изменить��$
��Left=�$��133,241,0,0q�$��20(�$	��Top=�$	��114��$��1��$��34���� -   $��buttonDelete��$��Удалить��$
��Left=�$��
10,282,0,0q�$	��Top=�$	��114��$��1��$��36��$��20(��� $��ID заказа:��$��1��$
��Left=�$��5,27,0,0q�$	��Top=�$��92��$��26���� -   $��IDzakazayaField��$��1��$
��Left=�$��22��$��
102,31,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��150���� $��Дата заказа:��$��1��$
��Left=�$��5,89,0,0q�$	��Top=�$ 
0.48,0.578&�(  "System.Windows.Controls.DatePicker  -   $��DatezakazayaField��$��1��$
��Left=�$��23��$��
102,92,0,0q�   Text$  ��$	��Top=�$	��150���� $"��Название книги:��$��Right=�$��
0,61,167,0q�$	��Top=�$��2���� -    ��Name$ comboboxLocality24��$
��Left=�$	��Top=�$��1��$��0��$	��150�� �� 
IsEditable .  �� DisplayMemberPath$ Nazvanie_knigi��$��
102,63,0,0q��� $��	Цена:��$��Right=�$��0,120,216,0q�$	��Top=�$��1��$ -0.268,0.538&��� -   $��
PriceField��$��1��$
��Left=�$��102,124,0,0q�$
 Wrap=�$	��Top=�$	��150��$��22���� $��Количество:��$��Right=�$��0,151,176,0q�$	��Top=�$��1��$ -0.268,0.538&�$��81���� -   $��KolichestvoField��$��1��$
��Left=�$��102,155,0,0q�$
 Wrap=�$	��Top=�$	��150��$��22��