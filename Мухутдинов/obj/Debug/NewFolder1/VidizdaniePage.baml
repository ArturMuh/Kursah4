   M S B A M L   `   `   `  ����O  KМухутдинов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Мухутдинов.NewFolder1Мухутдинов.NewFolder1  5      4    .Мухутдинов.NewFolder1.VidizdaniePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Мухутдинов.NewFolder1     5      -   5          N� Title$  Вид издания��5	      .��5      �  � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $��1* �6   6,   .+�5   
   �� .��5      �� 
�������.+�5      �� $	��134��6   $��17��6(   �� 65   $,�&Поиск по вид изданию:��69   6Y   �� 5      -   5         ��Name$ VidizdanieNameSearchField��5      $	��199��6=   $��0,0,15,0q�6I   �� 5      -   5         ��Name$ VidizdanieSearchButton��5      $��80��6^   $��
Поиск��6i   &   System.Windows.Controls.DataGrid  5      -   5          Name$ VidizdanieDataGrid��5         AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 id��6-   -   5        VidizdanieidColumn��
   
Visibility$
 	Collapsed=�5   V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6m   �� *id+ �� Mode$ TwoWay=�  5      $	 Вид издания��6-   -   5        VidizdanieVidizdanieColumn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 5   f    6q   �� *
Vidizdanie+$ TwoWay=�5      5      5      �� 5    
   -   5        $��Экспорт в Excel��5       $
��Left=�6+   $��
19,140,0,0q�6F   $��15(�6Z   $	��Top=�6h   $	��110��6�   $��1��6�   $��39��6�   �� 5!   
   $��Center=�6   $��Center=�60   $��1��6M   5"      �� 5#   
   -   5        $ VidizdanieTable��5#      $��Обновить��6+   $��1��6>   $
��Left=�6N   $��	19,99,0,0q�6i   $��20(�6|   $	��Top=�6�   $	��110��6�   $��36��6�   �� 5$   
   -	   5        $��Добавить��5$      $��1��6$   $
��Left=�64   $��
134,99,0,0q�6O   $��20(�6c   $	��Top=�6r   $	��102��6�   $��36��6�   �� 5%   
   -
   5        $��Изменить��5%      $
��Left=�6%   $��134,140,0,0q�6@   $��20(�6U   $	��Top=�6c   $	��102��6{   $��1��6�   $��39��6�   �� 5&   
   -   5        $��buttonDelete��5&   ,   $��Удалить��6@   $
��Left=�6R   $��134,184,0,0q�6m   $	��Top=�6�   $	��102��6�   $��1��6�   $��30��6�   $��20(�6�   �� 5'   
   $ ��Номер издания:��6   $
��Left=�6)   $��5,30,0,0q�6D   $	��Top=�6V   $��97��6n   $��26��6y   $��1��6�   �� 5(   
   -   5        $��idizdanieyaField��5(      $��1��6*   $
��Left=�6:   $��22��6U   $��
102,32,0,0q�6a    �� TextWrapping$
 Wrap=�6u   $�� ��6�   $	��Top=�6�   $	��150��6�   �� 5)   
   $��Вид издания:��6   $��1��6'   $
��Left=�67   $��	10,62,0,0q�6R   $	��Top=�6e   �� 5*   
   -   5        $��VidizdanieyaField��5*      $��1��6+   $
��Left=�6;   $��23��6V   $��	97,65,0,0q�6b   $
 Wrap=�6u   $�� ��6�   $	��Top=�6�   $	��150��6�   5-      5.      