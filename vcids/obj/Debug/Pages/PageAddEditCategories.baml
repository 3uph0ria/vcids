   M S B A M L   `   `   `  ����@  <vcids, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:vcids.Pagesvcids.Pages  5      '    !vcids.Pages.PageAddEditCategories   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:vcids.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ PageAddEditCategories��5      .��5      � $��15q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   $��0��60   $J��DДобавление/редактирование категории��5   	    $  MaterialDesignHeadline5TextBlock#��[ 5      �� 5   
   -   5        $
��Name��5      $��1��5      $	��600��5         MaterialDesignFilledTextBox#��[ 5!      $��Center=�5"       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5$      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Наименование��5%      $��0 0 20 0q�5&      ��5      �� *Name+{�5'      �� 	 �� Path$	 	IsChecked�
 �� ElementName$0
 *MaterialDesignFilledTextBoxEnabledComboBox���� 5,   
   $��Center=�6   $��8��60   $��Center=�6>    �� Orientation$ 
Horizontal=�6[   .+�5-      �� -   5        $��BtnAddservice��5-      $��Добавить��6F   6\   5.      5/      50      