   M S B A M L   `   `   `  ����H  DSalonCoiffure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SalonCoiffureSalonCoiffure  5           SalonCoiffure.PaiementPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -localclr-namespace:SalonCoiffure     5        N� Title$  Paiement��5      .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $
��Auto=�6'   .��5      �� $��20q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,20q�66   .+�5      �� $��/Online Payment.png��6   $��80��69   $��80��6D   $��0,0,10,0q�6P   �� 5      $��Paiement��6    $��28(�60   $
��Bold"�6>   ���	#FF0D3F31$��Center=�6g   5      �� 5      $ ��Sélectionnez une facture:��6   $
��Bold"�6=   $��0,0,0,5q�6O   $��20(�6`   �� 5       �� DisplayMemberPath$ Id��5      $��0,0,0,20q�5      ��5      �� *
Factures+ �� SelectedItem 5      �� *SelectedFacture+5      �� 5      $��Destinataire:��6   $��20(�61   $
��Bold"�6?   
�������$	��0,5q�6d   �� 5       $��Company.com��6   $��20(�6/   
�������$
��Wrap=�6P   $��0,0,0,10q�6d   �� 5"      $��Référence:��6   $��20(�6.   $
��Bold"�6<   
�������$	��0,5q�6a   �� 5#      $��14(�6@   
�������$
��Wrap=�6a   $��0,0,0,10q�6u   ��6   �� *SelectedFacture.Id+6u   �� 5%      $��Date:��6   $��20(�6)   $
��Bold"�67   
�������$	��0,5q�6\   �� 5&      $��14(�6B   
�������$
��Wrap=�6c   $��0,0,0,10q�6w   ��6   �� *SelectedFacture.Date+6w   �� 5(      $��Montant à payer :��6   $��20(�65   $
��Bold"�6C   
�������$	��0,5q�6h   �� 5)      $��22(�66   $
��Bold"�6D   
���������6   �� *	Montant+6V   5*      5+      �� 5.   
   $��1��6   $
��Auto=�6'   ���	#AFD9D9D9$	��445��6a   $	��495��6m   .��5/      �� $��20q�6   $��Stretch=�6%   .+�50      �� $*��$Sélectionnez un moyen de paiement :��6   $��18(�6G   $
��Bold"�6U   
�������$��0,0,0,20q�6y   �� 53      $��Carte��6   $	��160��6)   $��45��65   $��5q�6A   $��Carte��55      ��54      �� *SelectModePaiementCommand+��56      �� *CarteButtonBackground+�� 57      $��Virement��6   $	��160��6,   $��45��68   $��5q�6D   $��Virement��59      ��58      �� *SelectModePaiementCommand+��5:      �� *VirementButtonBackground+�� 5;      $��Google/Apple Pay��6   $	��160��64   $��45��6@   $��5q�6L   $��Google/Apple Pay��5=      ��5<      �� *SelectModePaiementCommand+��5>      �� *GoogleAppleButtonBackground+�� 5?      $��Payer��6   $��50��6)   ���#3D42DF
�������$��16(�6]   $
��Bold"�6k   $	��239��6}   ��6�   �� *EnregistrerPaiementCommand+5@      5A      5B      5C      