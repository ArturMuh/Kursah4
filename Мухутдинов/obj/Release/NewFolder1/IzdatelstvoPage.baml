   M S B A M L   `   `   `  ���� O  KМухутдинов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Мухутдинов.NewFolder1Мухутдинов.NewFolder1  5    /Мухутдинов.NewFolder1.IzdatelstvoPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ?local-clr-namespace:Мухутдинов.NewFolder1     -     N� Title$  Издательство��.���  � RowDefinitions ��  � ColumnDefinitions �� $��2* ��� $��1* �.+��� .���� 
�������.+��� $	��134��$��17���� $0�*Название издательства:���� -    ��Name$  IzdatelstvoNameSearchField��$	��199��$��0,0,15,0q��� -    ��Name$ IzdatelstvoSearchButton��$��80��$��
Поиск��&   System.Windows.Controls.DataGrid  -     Name$ IzdatelstvoDataGrid��   AutoGenerateColumns .     CanUserAddRows .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID_izdatelstva��-   "IzdatelstvoIDizdatelstvaColumn��
   
Visibility$
 	Collapsed=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ID_izdatelstva+ �� Mode$ TwoWay=�  $	 Название��-   IzdatelstvoNazvanieColumn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2*  �� *
Nazvanie+$ TwoWay=��� -   $��Экспорт в Excel��$
��Left=�$��
22,165,0,0q�$��15(�$	��Top=�$	��112��$��1��$��35���� $��Center=�$��Center=�$��1���� -   $ IzdatelstvoTable��$��Обновить��$��1��$
��Left=�$��
22,124,0,0q�$��20(�$	��Top=�$	��112��$��36���� -	   $��Добавить��$��1��$
��Left=�$��143,125,0,0q�$��20(�$	��Top=�$	��104��$��36���� -
   $��Изменить��$
��Left=�$��143,166,0,0q�$��20(�$	��Top=�$	��104��$��1��$��34���� -   $��buttonDelete��$��Удалить��$
��Left=�$��
22,205,0,0q�$	��Top=�$	��113��$��1��$��30��$��20(��� $&�� Код издательства:��$
��Left=�$��
533,29,0,0q�$	��Top=�$	��112��$��26��$��2���� -   $��IDizdatelstvayaField��$��1��$
��Left=�$��22��$��
107,31,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��150���� $��Название:��$
��Left=�$��
533,60,0,0q�$	��Top=�$��2���� -   $��NazvanieyaField��$��1��$
��Left=�$��23��$��
102,59,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��155��