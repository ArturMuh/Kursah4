   M S B A M L   `   `   `  ���� O  KМухутдинов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Мухутдинов.NewFolder1Мухутдинов.NewFolder1  /    )Мухутдинов.NewFolder1.KnigiPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     X TXceed.Wpf.Toolkit, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  9local-clr-namespace:Мухутдинов.NewFolder1  -     N� Title$  
Книги��.��� -   $��grid1�� � RowDefinitions ��  � ColumnDefinitions �� $��2* ��� $��1* �.+��� .���� 
�������.+��� $	��149��$��17���� $/�)Поиск по наименованию:���� -    ��Name$ KnigiNameSearchField��$	��199��$��0,0,15,0q��� -    ��Name$ KnigiSearchButton��$��80��$��
Поиск��&   System.Windows.Controls.DataGrid  -     Name$ KnigiDataGrid��   AutoGenerateColumns .     CanUserAddRows .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID_knigi��-   KnigiIDknigiColumn��
   
Visibility$
 	Collapsed=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
ID_knigi+ �� Mode$ TwoWay=�  $!	 Название книги��-   KnigiNazvanieknigiColumn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2*  �� *Nazvanie_knigi+$ TwoWay=�  $	 
Автор��-   KnigiNameavtoryColumn��$ 2*  �� *
Nameavtory+$ TwoWay=�  $	 Вид издания��-	   KnigiVidizdanieColumn��$ 2*  �� *
Vidizdanie+$ TwoWay=�  $
	 ISBN��-
   KnigiISBNColumn��$ 2*  �� *ISBN+$ TwoWay=�  $	 Количество��-   KnigiKolichestvoColumn��$ 2*  �� *Kolichestvo+$ TwoWay=�  $	 Цена��-   KnigiPriceColumn1��$ 2*  �� *Price+$ TwoWay=�  $	 Дата поставки��-   KnigiDatepostavkiColumn��$ 2*  �� *Date_postavki+ �� StringFormat$ dd.MM.yy��$ TwoWay=�  $	 Издательство��-   KnigiIzdatelstvoColumn��$ 2*  �� *Izdatelstvo+$ TwoWay=�  $	 Раздел��-   KnigiRazdeliColumn��$ 2*  �� *Razdel+$ TwoWay=��� -   $��Экспорт в Excel��$
��Left=�$��
10,308,0,0q�$��14(�$	��Top=�$	��107��$��1��$��28�� J� RenderTransformOrigin$ 0.489,1.057&��� $��Center=�$��Center=�$��1���� -   $ 
KnigiTable��$��Обновить��$��1��$
��Left=�$��122,308,0,0q�$��20(�$	��Top=�$��99��$��29���� -   $��Добавить��$��1��$
��Left=�$��122,341,0,0q�$��20(�$	��Top=�$��98��$��31���� -   $��buttonDelete��$��Удалить��$
��Left=�$��
10,376,0,0q�$	��Top=�$	��103��$��1��$��31��$��20(��� -   $��print��$��Печать��$��1��$
��Left=�$��122,377,0,0q�$��20(�$	��Top=�$��98��$��31���� -   $��Изменить��$
��Left=�$��
10,341,0,0q�$��20(�$	��Top=�$	��106��$��1��$��30���� $��Код книги:��$��1��$
��Left=�$��6,10,0,0q�$	��Top=�$��92��$��26���� -   $ IDknigiyaField��$��1��$
��Left=�$��22��$��
102,14,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��150���� $"��Название книги:��$��1��$
��Left=�$��4,36,0,0q�$	��Top=��� -   $ NazvanieknigiyaField��$��1��$
��Left=�$��23��$��
102,41,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��150���� $��Раздел:��$��1��$
��Left=�$��
10,100,0,0q�$	��Top=�$ 0.457,0.578&��� -    ��Name$ comboboxLocality1��$
��Left=�$	��Top=�$��1��$��0��$	��150�� �� 
IsEditable .  �� DisplayMemberPath$ Razdel��$��102,100,0,0q��� $��Количество:��$
��Left=�$��
10,126,0,0q�$	��Top=�$ 0.474,0.578&�$��1���� -   $ KolichestvoField��$��1��$
��Left=�$��102,130,0,0q�$
 Wrap=�$	��Top=�$	��150��$��22���� $��	Цена:��$
��Left=�$��
13,233,0,0q�$	��Top=�$ 0.506,1.425&�$��1���� -   $ 
PriceField��$��1��$
��Left=�$��102,130,0,0q�$
 Wrap=�$	��Top=�$	��150��$��22���� $ ��Дата поставки:��$
��Left=�$��	7,264,0,0q�$	��Top=�$ 0.474,0.578&�$��1��(  "System.Windows.Controls.DatePicker  -     Name$ Date_postavkiyaField��$��1��$
��Left=�$��23��$��102,267,0,0q�   Text$  ��$	��Top=�$	��150���� $��Вид издания:��$
��Left=�$��
10,152,0,0q�$	��Top=�$ 0.474,0.578&�$��1���� $��ISBN:��$
��Left=�$��
10,178,0,0q�$	��Top=�$ 0.175,0.462&�$��1���� -   $ 	ISBNField��$��1��$
��Left=�$��102,184,0,0q�$
 Wrap=�$	��Top=�$	��150��$��22���� $��Автор:��$��1��$
��Left=�$��8,69,0,0q�$	��Top=��� -   $ comboboxLocality22��$
��Left=�$	��Top=�$��1��$��0��$	��150�� . $	 FIO��$��
102,69,0,0q��� $��Издательство:��$
��Left=�$��
10,207,0,0q�$	��Top=�$ 0.596,0.462&�$��1���� -   $ comboboxLocality��$
��Left=�$	��Top=�$��1��$��0��$	��150�� . $ Nazvanie��$��102,211,0,0q��� -   $ comboboxLocality23��$
��Left=�$	��Top=�$��1��$��0��$	��150�� . $ 
Vidizdanie��$��102,157,0,0q��� -    $ 
ChinaField��$��1��$
��Left=�$��102,240,0,0q�$
 Wrap=�$	��Top=�$	��150��$��22��