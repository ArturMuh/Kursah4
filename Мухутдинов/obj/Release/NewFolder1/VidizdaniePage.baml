   M S B A M L   `   `   `  ���� O  KМухутдинов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Мухутдинов.NewFolder1Мухутдинов.NewFolder1  4    .Мухутдинов.NewFolder1.VidizdaniePage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ?local-clr-namespace:Мухутдинов.NewFolder1     -     N� Title$  Вид издания��.���  � RowDefinitions ��  � ColumnDefinitions �� $��2* ��� $��1* �.+��� .���� 
�������.+��� $	��134��$��17���� $,�&Поиск по вид изданию:���� -    ��Name$ VidizdanieNameSearchField��$	��199��$��0,0,15,0q��� -    ��Name$ VidizdanieSearchButton��$��80��$��
Поиск��&   System.Windows.Controls.DataGrid  -     Name$ VidizdanieDataGrid��   AutoGenerateColumns .     CanUserAddRows .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 id��-   VidizdanieidColumn��
   
Visibility$
 	Collapsed=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *id+ �� Mode$ TwoWay=�  $	 Вид издания��-   VidizdanieVidizdanieColumn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2*  �� *
Vidizdanie+$ TwoWay=��� -   $��Экспорт в Excel��$
��Left=�$��
19,140,0,0q�$��15(�$	��Top=�$	��110��$��1��$��39���� $��Center=�$��Center=�$��1���� -   $ VidizdanieTable��$��Обновить��$��1��$
��Left=�$��	19,99,0,0q�$��20(�$	��Top=�$	��110��$��36���� -	   $��Добавить��$��1��$
��Left=�$��
134,99,0,0q�$��20(�$	��Top=�$	��102��$��36���� -
   $��Изменить��$
��Left=�$��134,140,0,0q�$��20(�$	��Top=�$	��102��$��1��$��39���� -   $��buttonDelete��$��Удалить��$
��Left=�$��134,184,0,0q�$	��Top=�$	��102��$��1��$��30��$��20(��� $ ��Номер издания:��$
��Left=�$��5,30,0,0q�$	��Top=�$��97��$��26��$��1���� -   $��idizdanieyaField��$��1��$
��Left=�$��22��$��
102,32,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��150���� $��Вид издания:��$��1��$
��Left=�$��	10,62,0,0q�$	��Top=��� -   $��VidizdanieyaField��$��1��$
��Left=�$��23��$��	97,65,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��150��