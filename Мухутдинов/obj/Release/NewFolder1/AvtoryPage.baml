   M S B A M L   `   `   `  ���� O  KМухутдинов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Мухутдинов.NewFolder1Мухутдинов.NewFolder1  0    *Мухутдинов.NewFolder1.AvtoryPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ?local-clr-namespace:Мухутдинов.NewFolder1     -     N� Title$  Авторы��.���  � RowDefinitions ��  � ColumnDefinitions �� $��2* ��� $��1* �.+��� .���� 
�������.+��� $	��134��$��17���� $%�Поиск по фамилии:���� -    ��Name$ AvtoryNameSearchField��$	��199��$��0,0,15,0q��� -    ��Name$ AvtorySearchButton��$��80��$��
Поиск��&   System.Windows.Controls.DataGrid  -     Name$ AvtoryDataGrid��   AutoGenerateColumns .     CanUserAddRows .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 	ID_avtory��-   AvtoryIDavtoryColumn��
   
Visibility$
 	Collapsed=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	ID_avtory+ �� Mode$ TwoWay=�  $,	 &Фамилия Имя Отчество��-   AvtoryFamiliaColumn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2*  �� *FIO+$ TwoWay=��� -   $��Экспорт в Excel��$
��Left=�$��
19,176,0,0q�$��15(�$	��Top=�$	��110��$��1��$��39���� $��Center=�$��Center=�$��1���� -   $ AvtoryTable��$��Обновить��$��1��$
��Left=�$��
19,129,0,0q�$��20(�$	��Top=�$	��110��$��36���� -	   $��Добавить��$��1��$
��Left=�$��134,129,0,0q�$��20(�$	��Top=�$	��102��$��36���� -
   $��Изменить��$
��Left=�$��134,176,0,0q�$��20(�$	��Top=�$	��102��$��1��$��39���� -   $��buttonDelete��$��Удалить��$
��Left=�$��134,225,0,0q�$	��Top=�$	��102��$��1��$��31��$��20(��� $��Номер автора:��$��1��$
��Left=�$��5,27,0,0q�$	��Top=�$��92��$��26���� -   $��IDavtoryyaField��$��1��$
��Left=�$��22��$��
102,31,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��150���� $��ФИО:��$��1��$
��Left=�$��5,58,0,0q�$	��Top=��� -   $��FamiliayaField��$��1��$
��Left=�$��51��$��
102,59,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��150��