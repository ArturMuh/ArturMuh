   M S B A M L   `   `   `  ����O  KМухутдинов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Мухутдинов.NewFolder1Мухутдинов.NewFolder1  5      ;    5Мухутдинов.NewFolder1.Pasportnie_danniePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Мухутдинов.NewFolder1     5      -   5          N� Title$'  !Паспортные данные��5	      .��5
      �  � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $��1* �6   6,   .+�5   
   �� .��5      �� 
�������.+�5      &   System.Windows.Controls.DataGrid  -   5        $��PasportniedannieDataGrid��5         AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6*   -   5        PasportnieIDColumn��   
Visibility$ 	Collapsed=�5   R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6i   �� *id+	 �� Mode$	 TwoWay=�  5      $! Серия паспорта��6)   -   5        '#PasportniedannieSeriaPasportaColumn��
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 1* 5   n    6y   �� *Seria_pasporta+$	 TwoWay=�  5      $ Дата выдачи��6)   -   5        %!PasportniedannieDateVidachiColumn��$
 2* 5   i    6t   �� *Date_vidachi+$	 TwoWay=�  5      $ Кем выдан��6)   -   5        "PasportniedannieKemVidanColumn��$
 2* 5   d    6o   �� *	Kem_vidan+$	 TwoWay=�  5      $ Гражданство��6)   -   5        %!PasportniedannieGrawdanstvoColumn��$
 2* 5   i    6t   �� *Grawdanstvo+$	 TwoWay=�  5      $" Национальность��6)   -   5        %!PasportniedannieNationalityColumn��$
 2* 5   l    6w   �� *Nationality+$	 TwoWay=�  5      $# Код абитуриента��6)   -	   5        ($PasportniedannieKodAbiturientaColumn��$
 3* 5   p    6{   �� *kod_abiturienta+$	 TwoWay=�4  .System.Windows.Controls.DataGridTemplateColumn  5      -
   5         PasportniedannieDeleteColumn��$

 0.8* 5   S      CellTemplate 5      �� 5   "   .R�5    &   �� -   5        .��5    B   Удалить6K   5!   #   5#      5%      5&      5'      �� 5(   
   $��Center=�6   $��Center=�60   $��1��6M   .+�5)      �� -   5        $��PasportniedannieTable��5)   "   $	��0,5q�6   .��5*      �� $��5q�6   $��20(�6'   Обновить6?   5+      5,      5-      5.      