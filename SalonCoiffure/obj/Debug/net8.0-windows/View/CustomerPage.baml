   M S B A M L   `   `   `  ����H  DSalonCoiffure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SalonCoiffureSalonCoiffure  5           SalonCoiffure.CustomerPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -localclr-namespace:SalonCoiffure     5        N� Title$  CustomerPage��5      .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �  � Orientation$ 
Horizontal=�6   $��0,0,0,10q�6-   $��Center=�6?   .+�5      �� $	��Nom��6   
�������$��Georgia)�65   $��Center=�6J   $��20(�6e   �� 5      $	��120��6   $��5q�6"   ���	#FFA2D0B9$��14(�6�   $��Georgia)�6�   
���������6-   �� *SelectedCustomer.Nom+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��Téléphone��6   
�������$��Georgia)�6;   $��Center=�6P   $��20(�6k   �� 5      $	��120��6   $��5q�6"   ���	#FFA2D0B9$��14(�6�   $��Georgia)�6�   
���������6-   �� *SelectedCustomer.Telephone+$ PropertyChanged=�6�   �� 5      $��Email��6   
�������$��Georgia)�67   $��Center=�6L   $��20(�6g   �� 5      $	��160��6   $��5q�6"   ���	#FFA2D0B9$��14(�6�   $��Georgia)�6�   
���������6-   �� *SelectedCustomer.Email+$ PropertyChanged=�6�   �� 5      $��Adresse��6   
�������$��Georgia)�69   $��Center=�6N   $��20(�6i   �� 5      $	��160��6   $��5q�6"   ���	#FFA2D0B9$��14(�6�   $��Georgia)�6�   
���������6-   �� *SelectedCustomer.Adresse+$ PropertyChanged=�6�   5      &   System.Windows.Controls.DataGrid  5    
   -   5        $��1��5       $	��826��5!      $	��476��5"         AutoGenerateColumns$ False��5%      ���	#FFCCC7E0$��Georgia)�5'      $��0,0,0,10q�5(      $��Stretch=�5*      $��Stretch=�5+      ���	#FF65A3BA��5#      �� *FilteredCustomers+ �� SelectedItem 5$      �� *SelectedCustomer+   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$	 Nom��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6J   	   
Foreground	 �	#FFB062621  +System.Windows.Controls.DataGridBoundColumn
   Binding
 62   �� *Nom+6T     5.      $ Téléphone��6%   $ * 6V   	 �	#FFB06262
 68   �� *	Telephone+6`     5/      $ Email��6%   $ * 6N   	 �	#FFB06262
 64   �� *Email+6X     50      $ Adresse��6%   $ * 6R   	 �	#FFB06262
 66   �� *	Adresse+6\   52      � 55   
   $��2��6   $ 
Horizontal=�6!   $��Center=�6:   $��0,10,0,0q�6W   .+�56      �� $��Ajouter��6   $��5q�6F   ���	#FF286B8A
�������$��Georgia)�6{   $��14(�6�   ��6'   �� *
AddCommand+6�   �� 57      $��Modifier��6   $��5q�6J   ���	#FF286B8A
�������$��Georgia)�6   $��14(�6�   ��6(   �� *UpdateCommand+6�   �� 58      -   5        $��	Supprimer��58      $��5q�6K   ���	#FF286B8A
�������$��Georgia)�6�   $��14(�6�   ��6)   �� *DeleteCommand+6�   �� 59      $��Rechercher par nom��6   
�������$��Georgia)�6D   $��Center=�6Y   $��10,0,5,0q�6t   $��20(�6�   �� 5:      $	��120��6   $��5q�6"   ���	#FFA2D0B9$��14(�6�   $��Georgia)�6�   
���������6-   �� *
SearchText+$ PropertyChanged=�6�   5;      5<      5=      