   M S B A M L   `   `   `  ����H  DSalonCoiffure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SalonCoiffureSalonCoiffure  5          SalonCoiffure.FacturePage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -localclr-namespace:SalonCoiffure     5        N� Title$  FacturePage��5      .��5
      � $��20q�6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   �� ���	#AFD9D9D9 �� CornerRadius$ 10��6)    �� Padding$ 20q�6;   $��0��6H   $��0,0,10,0q�6X   $	��361��6j   $	��686��6v   ._�5      �� .+�5      �� $��Créer une facture��6   $��24(�65   $
��Bold"�6C   ���#7142D7$��0,0,0,20q�6j   �� 5      $��Client :��6   $��SemiBold"�6,   ���#ABA5E0
�������$��16(�6j   �� 5       �� DisplayMemberPath$	 Nom��5      $��0,5,0,15q�5      $��30��6-   
���   ���5      �� *	Customers+ �� SelectedItem 5      �� *SelectedCustomer+5      �� 5      $��Services disponibles :��6   $��SemiBold"�6:   
�������$��18(�6c   �� 5      -   5         ��Name$ ServicesListBox��5      $	 Nom��5       �� SelectionMode$ Multiple=�5       $	��120��5"      $��0,5,0,15q�5#      
���   ���5      �� *AvailableServices+5#   ,   �� 5$      $��Liste des factures :��6   $��SemiBold"�68   
�������$��18(�6a   �� 5%      $ Id��5'      $	��100��5(      $	��200��5)      $��	0,10,0,10q�5*      ��5%      �� *
Factures+ 5&      �� *SelectedFacture+5*      5.      5/      �� 52   
   ���	#AFD9D9D9$ 10��6)   $ 20q�6;   $��1��6H   $	��686��6X   ._�53      �� .+�54      �� $��Créer la facture��6   ���#7142D7
���   �$
��Bold"�58   	   $��40��59   	   $��0,10,0,0q�5:   	   $��0q�5;   	   $	��186��6   $��16(�6)   ��55   	   �� *CreateFactureCommand+5;   )   �� 5=      $��Mettre à jour la facture��6   ���	#FF8A4194
���   �$
��Bold"�5A   	   $��40��5B   	   $��0,10,0,0q�5C   	   $��0q�5D   	   $	��186��6   $��16(�6)   ��5>   	   �� *UpdateFactureCommand+5D   )   �� 5F      $��Supprimer la facture��6   ���#287F8A
���   �$
��Bold"�5J      $��40��5K      $��0,10,0,0q�5L      $��0q�5M      $	��188��6)   $��16(�65   ��5G      �� *DeleteFactureCommand+5M   5   �� 5O      -   5        $��Enregistrer en PDF��5O      ���	#FF8A4194
���   �$
��Bold"�5S      $��40��5T      $��0,10,0,0q�5U      $��0q�5V      $	��188��6)   $��16(�65   �� 5X      -   5        $��Envoyer un email��5X      ���#7142D7
���   �$
��Bold"�5\      $��40��5]      $��0,10,0,0q�5^      $��0q�5_      $	��188��6)   $��16(�65   �� 5`      $��Détails de la facture��6   $��24(�69   $
��Bold"�6G   ���#7142D7$��0,0,0,20q�6n   �� 5b      $��Client :��6   $��SemiBold"�6,   
�������$��18(�6U   �� 5c      -   5         ��Name$ 
ClientName��5c      $��0,0,0,10q�6W   ��61   �� *SelectedCustomer.Nom+6W   �� 5e      $��Services sélectionnés :��6   $��SemiBold"�6;   
�������$��18(�6d   �� 5f      $��0,0,0,10q�6H   ��6   �� *SelectedServices+��5g      �� 5h      .R�5i      �� ��6(   �� *Nom+5j      5l      �� 5n      $��Prix total :��6   $��SemiBold"�60   
�������$��18(�6Y   �� 5o      -   5        $ 
TotalPrice��5o      $��18(�6b   
�������$
��Bold"�6�   ��61   �� *	TotalPrix+	 �� StringFormat$	 {0:C}��6�   5p      5q      5r      5s      