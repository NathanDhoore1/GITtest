   M S B A M L   `   `   `  ????G  Coefening_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:oefening_wpfoefening_wpf  5   	       oefening_wpf.ReeksWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:oefening_wpf     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     ? Title$  ReeksWindow??5   	   $	??450??6   $	??800??6*      MaterialDesignBody#???   5
   	   $??Regular"?5   	   $??13(?5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5   	      TextRenderingMode$
 Auto=?5   	     MaterialDesignPaper#???  5   	     MaterialDesignFont#???  5   	   .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $??1* ?6   ?? 5      $
??auto ?6   ?? 5      $??5* ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6    ? ColumnDefinitions 5   
   ?? 5      ?? 5      ?? 5      $
??auto ?6   .+?5!   
   ?? )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Titel??6    % !MaterialDesignFloatingHintTextBox#??[ 6E   $??Center=?6?   $??0??5"      $??2??6   $??5q?63   ?? 5#   
   $??Albums??6   $??0??6"   $??2??6/   $??5q?6?   ?? 5$   
   $??1??6   $??2??6    $??7??60    ?? DisplayMemberPath$ Titel??6A   ?? 5&   
   $ Beschrijving??6   $ Status??5'      $??Bottom=?6;   $??1??6V   $??2??6c   $??5q?6w   ?? 5(   
   $ Website??6   #??[ 6<   $??Center=?6w   $??2??6?   $??2??6?   $??5q?6?   ?? 5)   
    ?? AcceptsReturn$
 True??6    ?? TextWrapping$
 Wrap=?6(   $ Beschrijving??6<   #??[ 5*      $??3??6M   $??2??6Z   $??2q?6n   ?? 5,   
   $ 
Genre.Naam??6   $??4??5-      $??0??6    $??2??60   $??15q?6A   5.      ?? 5/   
   $
 Naam??50      $ Genre??6-   $??Bottom=?6T   $??4??6o   $??1??6|   $??5q?6?   ?? 51   
   $??5??6   $??1??6"   .+?52      ?? $??Genre Toevoegen??6   $??5q?60    # MaterialDesignFlatLightBgButton#??[ 6<   53      ?? 54   
   $??Genre Verwijderen??6   $??7??6/   $??5q?6<   ?? 55   
   $??Bewaren??6   $??7??6%   $??1??62   $??5q?6B   56      57      