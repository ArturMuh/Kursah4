   M S B A M L   `   `   `  ����O  KМухутдинов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Мухутдинов.NewFolder1Мухутдинов.NewFolder1  5      1    +Мухутдинов.NewFolder1.RazdeliPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Мухутдинов.NewFolder1     5      -   5          N� Title$  Раздел��5	      .��5      �  � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $��1* �6   6,   .+�5   
   �� .��5      �� 
�������.+�5      �� $	��134��6   $��17��6(   �� 65   $&� Название раздела:��69   6U   �� 5      -   5         ��Name$ RazdeliNameSearchField��5      $	��199��6:   $��0,0,15,0q�6F   �� 5      -   5         ��Name$ RazdeliSearchButton��5      $��80��6X   $��
Поиск��6c   &   System.Windows.Controls.DataGrid  5      -   5          Name$ RazdeliDataGrid��5         AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
ID_razdela��6-   -   5        RazdeliIDrazdelaColumn��
   
Visibility$
 	Collapsed=�5   b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6y   �� *
ID_razdela+ �� Mode$ TwoWay=�  5      $	 Раздел��6-   -   5        RazdeliRazdelColumn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 5   Z    6e   �� *Razdel+$ TwoWay=�5      5      5      �� 5    
   -   5        $��Экспорт в Excel��5       $
��Left=�6+   $��
24,169,0,0q�6F   $��15(�6Z   $	��Top=�6h   $	��123��6�   $��1��6�   $��35��6�   �� 5!   
   $��Center=�6   $��Center=�60   $��1��6M   5"      �� 5#   
   -   5        $ RazdeliTable��5#      $��Обновить��6(   $��1��6;   $
��Left=�6K   $��
24,128,0,0q�6f   $��20(�6z   $	��Top=�6�   $	��123��6�   $��36��6�   �� 5$   
   -	   5        $��Добавить��5$      $��1��6$   $
��Left=�64   $��152,128,0,0q�6O   $��20(�6d   $	��Top=�6s   $	��100��6�   $��36��6�   �� 5%   
   -
   5        $��Изменить��5%      $
��Left=�6%   $��152,169,0,0q�6@   $��20(�6U   $	��Top=�6c   $	��100��6{   $��1��6�   $��34��6�   �� 5&   
   -   5        $��buttonDelete��5&   ,   $��Удалить��6@   $
��Left=�6R   $��
24,209,0,0q�6m   $	��Top=�6�   $	��123��6�   $��1��6�   $��36��6�   $��20(�6�   �� 5'   
   $ ��Номер раздела:��6   $��1��6)   $
��Left=�69   $��5,27,0,0q�6T   $	��Top=�6f   $	��103��6~   $��26��6�   �� 5(   
   -   5        $��ID_razdelayaField��5(      $��1��6+   $
��Left=�6;   $��22��6V   $��
102,32,0,0q�6b    �� TextWrapping$
 Wrap=�6v   $�� ��6�   $	��Top=�6�   $	��150��6�   �� 5)   
   $��Раздел:��6   $��1��6"   $
��Left=�62   $��5,58,0,0q�6M   $	��Top=�6_   �� 5*   
   -   5        $��RazdelyaField��5*      $��1��6'   $
��Left=�67   $��46��6R   $��
102,59,0,0q�6^   $
 Wrap=�6r   $�� ��6�   $	��Top=�6�   $	��150��6�   5-      5.      