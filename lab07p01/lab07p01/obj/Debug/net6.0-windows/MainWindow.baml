   M S B A M L   `   `   `  ????C  ?lab07p01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:lab07p01lab07p01  5   	       lab07p01.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:lab07p01     5   	     ? Title$  
MainWindow??5   	   $	??350??6   $	??600??6)   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $??4* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? -   5         ??Name$ oknoTekstowe??5      $??0??6*   $??0??6:   $??3??6G   $
??Wrap=?5      $??CharacterEllipsis=?6(    ?? Padding$
 10pxq?6I   ?? 5   
   -   5         ??Name$ bt_kolor_fomtu??5      $??Kolor fontu??6)   $??0??6?   $??1??6O   $??20px 10px 10px 10pxq?5      6.   ?? 5   
   -   5        $ bt_kolor_tla??5      $??
Kolor tła??6'   $??1??6;   $??1??6K   $??10px 10px 10px 10pxq?5      6.   ?? 5   
   -   5        $ bt_styl_fomtu??5      $??Wybór fontu??6(   $??2??6>   $??1??6N   $??10px 10px 20px 10pxq?5      6.   ?? 5   
   -   5         ??Name$ suwak??5      $??0??6    $??2??60   $??3??6=   $??	10px 10pxq?5       ? Value$ 10Q?5        ? Minimum$ 4Q?6   	 ? Maximum$	 60Q?6(   5"      5#      