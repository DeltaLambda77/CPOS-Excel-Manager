   M S B A M L   `   `   `  ����M  ICPOS Excel Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:CPOS_Excel_Manager.ViewsCPOS_Excel_Manager.Views  5      *    $CPOS_Excel_Manager.Views.AccountView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:CPOS_Excel_Manager.Views     5      
�������.��5
      �   � RowDefinitions  5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5        $��	TitleText��5   ^   $��1��6      TextBlockStyle#��[  6"   $��Medium"�6J   &$Enter the Date of the CenPOS Report:5      (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ Account_DatePicker��5      $��2��61   $	��200��6>   $��Center=�6J   $��45��6e   
�������$��12(�5      $��Segoe UI)�6   $��Center=�61    � 	Resources 5      :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value��%|   '        �� 5      "  6   .�5      ��  � ��$ Center=�6:   �� 5       � ��
 �����63   5      5       5"      �� 5$   
   -   5        $��3��5$        
ExpandGrid#��[ 6   $��10q�6B   $	��200��6N   $��Segoe UI)�5%      $��16(�6'   $
��Bold"�65   
�������$��Process CenPOS Emails��5&      $��Print��6Z   ��61   �� *NavigatePrintCommand+5'      5(      5)      