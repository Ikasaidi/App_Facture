   M S B A M L   `   `   `  ����H  DSalonCoiffure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SalonCoiffureSalonCoiffure  5   	       SalonCoiffure.EmailForm   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:SalonCoiffure     5   	     � Title$  Email Sender��5   	   $	��450��6   $	��800��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $	��À:��6-   $��Center=�6:   $��5q�6U   �� 5   
   -   5         ��Name$ TxtTo��5   /   $��0��6   $��1��6   $��5q�6>   �� 5   
   $��1��6   $��0��6   $	��De:��6-   $��Center=�6;   $��5q�6V   �� 5   
   -   5        $ TxtFrom��5   /   $��1��6   $��1��6   $��5q�6@   �� 5!   
   $��2��6   $��0��6   $��Mot de passe:��6-   $��Center=�6E   $��5q�6`   �� 5"   
   -   5        $ TxtPw��5"   /   $��2��6   $��1��6   $��5q�6>   �� 5%   
   $��3��6   $��0��6   $��Sujet:��6-   $��Center=�6>   $��5q�6Y   �� 5&   
   -   5        $ 
TxtSubject��5&   /   $��3��6   $��1��6   $��5q�6C   �� 5)   
   $��4��6   $��0��6   $��Message:��6-   $	��Top=�6@   $��5q�6X   �� 5*   
   -   5        $ TxtBody��5*   /   $��4��6   $��1��6    �� TextWrapping$
 Wrap=�6@    �� AcceptsReturn$
 True��6T   " �� VerticalScrollBarVisibility$
 Auto=�6i   $��5q�6�   �� 5-   
   -   5         ��Name$ BtnSend��5-   .   $��5��6   $��1��6   $��Envoyer��6?   $��Right=�6Q   $��5q�6m   $	��100��6x   6�   5.      5/      