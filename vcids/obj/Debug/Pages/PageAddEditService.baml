   M S B A M L   `   `   `  ����@  <vcids, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:vcids.Pagesvcids.Pages  5      $    vcids.Pages.PageAddEditService   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:vcids.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ PageAddEditService��5      .��5      � $��15q�6    � RowDefinitions 5      �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   .+�5      �� $��Center=�6   $��0��6,   $D��>Добавление/редактирование товара��5   	    $  MaterialDesignHeadline5TextBlock#��[ 5       �� 5!   
   -   5        $
��Name��5#      $��1��5"      $	��600��5%        MaterialDesignFilledTextBox#��[ 5&      $��Center=�5'       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5)      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Наименование��5*      $��0 0 20 0q�5+      ��5$      �� *Name+{�5,      �� 	 �� Path$	 	IsChecked�
 �� ElementName$0
 *MaterialDesignFilledTextBoxEnabledComboBox���� 5/   
   -   5         ��Name$ CBoxServices��56      $ Категория��50      $	��600��51      $��0 0 20 0q�52      $��Center=�53      $��2��54       �� DisplayMemberPath$
 Name��57       �� SelectedItem 55      �� *Categoris.Id+57      �� 5:   
   -   5        $	��Img��5<      $��3��5;      $	��600��5>      #��[ 5?      $��Center=�5@       . $
 Wrap=�5B      $ Картинка��5C      $��0 0 20 0q�5D      ��5=      �� *Img+{�5E      �� $	 	IsChecked�$0
 *MaterialDesignFilledTextBoxEnabledComboBox���� 5I   
   $��5��5J      $	��600��5K       ! MaterialDesignOutlinedTextBox#��[ 5L      $	��Top=�5M      $��3��5N      $	��150��5O       . $
 Wrap=�5R      $��0 0 20 0q�5S      " �� VerticalScrollBarVisibility$
 Auto=�5T      $ Описание��5U      ��5P      �� *Description+{�5V      �� $	 	IsChecked�$2
 ,MaterialDesignOutlinedTextBoxEnabledComboBox���� 5Z   
   $��Center=�6   $��8��60   $��Center=�6>    �� Orientation$ 
Horizontal=�6[   .+�5[   
   �� -   5        $��BtnAddservice��5[      $��Добавить��6B   6X   5\      5]      5^      