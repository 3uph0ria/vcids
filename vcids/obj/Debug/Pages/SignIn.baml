   M S B A M L   `   `   `  ����@  <vcids, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:vcids.Pagesvcids.Pages  5          vcids.Pages.SignIn   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:vcids.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ SignIn��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   �� 5"      $��* �6   �� 5#      $��* �6   .+�5&   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��5��5'         Mode$ Custom=�5(      ���	#FFD38800$��16q�5*      .��5+      ]� .+�5-      ��  �� Orientation$ 
Horizontal=�5.      .+�5/      �� 
�������$��Center=�51      $��16 0 0 0q�52      $��VCIBS��53      54      55      56      �� 58   
   $��2��6   $
��Fill=�6$   $��1��64   $��8��6A   $��../Resources/hero-bg.jpg��6R   �� 5:   
   $��2��6   $��3��6"   $��Center=�62   $��Авторизация��5;   	   $��Center=�5<   	    $  MaterialDesignHeadline5TextBlock#��[ 5=   	   G� 5A   
   -   5        $��Password��5B      $��4��5A      $��3��6#    # MaterialDesignFilledPasswordBox#��[ 5C      $��Center=�5D      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Пароль��5F      {�5E      �� 
 �� Path$
 	IsChecked� �� ElementName$A ;MaterialDesignFilledPasswordFieldPasswordBoxEnabledComboBox��5F      �� 5H   
   $��6��6   $��3��6"   $ 
Horizontal=�62   $��Center=�6K   .+�5I      �� -   5        $��BtnSignInAdmin��5I   @   
�������$ ��АДМИНИСТРАТОР��6(   6V   5K      �� 5L   
   -   5        $��Login��5M      $��3��5L      $��3��6     MaterialDesignFilledTextBox#��[ 5N      $��Center=�5O       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5Q      $	 
Логин��5R      {�5S      �� $
 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox��5V      5W      