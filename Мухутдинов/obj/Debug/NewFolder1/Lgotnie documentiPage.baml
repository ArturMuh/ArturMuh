   M S B A M L   `   `   `  ����O  KМухутдинов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Мухутдинов.NewFolder1Мухутдинов.NewFolder1  5      ;    5Мухутдинов.NewFolder1.Lgotnie_documentiPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Мухутдинов.NewFolder1     5        N� Title$  Lgotnie_documentiPage��5	      .��5      �  � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $��1* �6   6,   .+�5   
   �� .��5      �� 
�������.+�5      &   System.Windows.Controls.DataGrid  -   5        $��LgotniedocumentiDataGrid��5         AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6-   -   5        LgotniedocumentiIDColumn��   
Visibility$ 	Collapsed=�5   \   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6s   �� *id+	 �� Mode$	 TwoWay=�  5      $ 
Серия��6-   -   5        LgotniedocumentiSeriaColumn��
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 2* 5   a    6l   �� *Seria+$	 TwoWay=�  5      $ 
Номер��6-   -   5        LgotniedocumentiNomerColumn��$
 1* 5   a    6l   �� *Nomer+$	 TwoWay=�  5      $ Дата выдачи��6-   -   5        %!LgotniedocumentiDatevidachiColumn��$
 1* 5   m    6x   �� *Date_vidachi+$	 TwoWay=�  5      $ Кем выдан��6-   -   5        "LgotniedocumentiKemvidanColumn��$
 1* 5   h    6s   �� *	Kem_vidan+$	 TwoWay=�  5      $# Код абитуриента��6-   -   5        '#LgotniedocumentiKodAbiturintaColumn��$
 1* 5   s    6~   �� *Kod_abiturinta+$	 TwoWay=�4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        ObrazovanieDeleteColumn��$

 0.8* 5   R      CellTemplate 5      �� 5   "   .R�5    &   �� -	   5        .��5    C   Удалить6L   5!   #   5#      5%      5&      5'      �� 5(   
   $��Center=�6   $��Center=�60   $��1��6M   .+�5)      �� -
   5        $��LgotniedocumentiTable��5)   "   $	��0,5q�6   .��5*      �� $��5q�6   $��20(�6'   Обновить6?   5+      5-      50      51      