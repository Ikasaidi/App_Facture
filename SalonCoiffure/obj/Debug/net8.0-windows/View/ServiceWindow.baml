   M S B A M L   `   `   `  ����H  DSalonCoiffure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SalonCoiffureSalonCoiffure  5      !    SalonCoiffure.ServiceWindow   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -localclr-namespace:SalonCoiffure     5        N� Title$  Service��5      .��5      �� $
��Auto=�6   .��5   
   � $��20q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�62   $��Center=�6D   .+�5      �� $	��Nom��6   $��Georgia)�6&   
�������$��Center=�6N   $��20(�6i   �� 5      $	��150��6   $��5q�6&   ���	#FF9692A5$��14(�6�   $��Georgia)�6�   
���������61   �� *SelectedService.Nom+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $
��Prix��6   $��Georgia)�6'   
�������$��Center=�6O   $��20(�6j   �� 5      $	��100��6   $��5q�6&   ���	#FF9692A5$��14(�6�   $��Georgia)�6�   
���������61   �� *SelectedService.Prix+$ PropertyChanged=�6�   5      &   System.Windows.Controls.DataGrid  5      $��1��6   $	��826��5      $	��400��5         AutoGenerateColumns$ False��5       ���	#FFCCC7E0$��Georgia)�5"      $��0q�5#      $��Stretch=�5$      $��Stretch=�5%      ���	#FF65A3BA$��14(�6J   ��5      �� *FilteredServices+ �� SelectedItem 5      �� *SelectedService+   Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$	 Nom��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N   	   
Foreground	 �	#FFB062621  +System.Windows.Controls.DataGridBoundColumn
   Binding
 66   �� *Nom+6X     5(      $
 Prix��6)   $ * 6P   	 �	#FFB06262
 67   �� *Prix+6Z   5*      �� 5-      $��2��6   $ 
Horizontal=�6&   $��Center=�6?   $��0,10,0,0q�6\   .+�5.      �� $��Ajouter��6   $��5q�6J   ���#287F8A
�������$��Georgia)�6}   $��20(�6�   ��6+   �� *
AddCommand+6�   �� 5/      $��Modifier��6   $��5q�6N   ���#287F8A
�������$��Georgia)�6�   $��20(�6�   ��6,   �� *UpdateCommand+6�   �� 50      $��	Supprimer��6   $��5q�6O   ���#287F8A
�������$��Georgia)�6�   $��20(�6�   ��6-   �� *DeleteCommand+6�   �� 51      $��Rechercher un service��6   
�������$��Georgia)�6K   $��10,0,0,0q�6`   $��Center=�6r   $��18(�6�   �� 52      $	��150��6   $��5q�6&   ���	#FF9692A5$��14(�6�   $��Georgia)�6�   
���������61   �� *
SearchText+$ PropertyChanged=�6�   53      55      56      57      