   M S B A M L   `   `   `  ����M  ICPOS Excel Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:CPOS_Excel_Manager.ViewsCPOS_Excel_Manager.Views  5      (    "CPOS_Excel_Manager.Views.PrintView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:CPOS_Excel_Manager.Views     5      
�������.��5
      �   � RowDefinitions  5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5        $��	TitleText��5   ^   $��1��6      TextBlockStyle#��[  6"   $��Medium"�6J   CenPOS Processor5      �� 5   
   -   5         ��Name$ Status_TextBox��5      $��2��6+   $	��400��68    �� 
IsReadOnly$
 True��6D   $��Status Box:��6V    �� TextWrapping$
 Wrap=�5      $��Segoe UI)�6&   $��12(�6<   .��6J   5      �� 5   
   -   5         ��Name$ PrintCPOSButton��5      $��3��6*     
ExpandGrid#��[ 67   $��10q�6[   $	��200��6g   $��Segoe UI)�6s   $��16(�6�   $
��Bold"�6�   
�������$��Print CenPOS Summary��5      $��Account��6[   ��60   �� *NavigateAccountCommand+5      5      5       