   M S B A M L   `   `   `  ????G  Coefening_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:oefening_wpfoefening_wpf  5   	   !    oefening_wpf.DelegatesIntro   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:oefening_wpf     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     ? Title$  DelegatesIntro??5   	   $	??450??6    $	??800??6-      MaterialDesignBody#???   5
   	   $??Regular"?5   	   $??13(?5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5   	      TextRenderingMode$
 Auto=?5   	     MaterialDesignPaper#???  5   	     MaterialDesignFont#???  5   	   .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5       ? ColumnDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      .+?5   
   ?? -   5         ??Name$ 	txtAantal??5      $??0??6%   $??0??62   $??5,5,5,15q?6B   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Aantal??5       % !MaterialDesignFloatingHintTextBox#??[ 5      $??Center=?5       ?? 5!   
   -   5         ??Name$ cmbProducten??5!      $??0??6)   $??1??66   $??5q?6F   $ Search??5"       ?? 
IsEditable$
 True??5#      ?? 5$   
   -   5        	 ??Name$	 btnKopen??5$      $??Kopen??6#   $??0??63   $??2??6@   $??5q?6Q   ?? 5%   
   -   5        
 ??Name$
 lstWinkelkar??5%      $??1??6(   $??0??65   $??3??6E   $??5q?6Y   ?? 5&   
   -   5        $	 btnAfdrukken1??5&      $??Bon Afdrukken (1)??6(   $??0??6D   $??3??6Q   $??5q?6a   ?? 5'   
   -   5         ??Name$ txtBon1??5'      $??1??6%   $??3??62   $??5q?6B   ?? 5(   
   -   5        $	 btnAfdrukken2??5(      $??Bon Afdrukken (2)??6(   $??0??6D   $??4??6Q   $??5q?6a   ?? 5)   
   -   5        $ txtBon2??5)      $??1??6%   $??4??62   $??5q?6B   5*      5+      