   M S B A M L   `   `   `  ????O  KWpfAppMaterialDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WpfAppMaterialDesignWpfAppMaterialDesign  5   	   '    !WpfAppMaterialDesign.View.Window7   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WpfAppMaterialDesign     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     ? Title$  
MainWindow??5	      $	??450??6   $	??800??6%    ? WindowStyle$
 None=?5
       ? 
ResizeMode$ NoResize=?5   	    ? WindowStartupLocation$ CenterScreen=?5   	   
??????  ? AllowsTransparency . .??5      ??  ?? CornerRadius$ 12??6   $??
0,0,0,94.6q?6   ??5   
   ?? 5       ?? ImageSource$ /Images/back-image.jpg??6    j? Stretch$
 None=?5      ._?5   
   ?? $ 10??6   $??2q?5       J? Opacity$
 0.95Q?5      $??0,0,-20,0.2q?6   ??5      ?? 5      	 ?? 
StartPoint$		 0,0&?6&   
 ?? EndPoint$	
 1,1&?67   .??5      ?  ? Color$ #462AD8??6#    ? Offset$ 0Q?63   ? 5      $ #DA34AE??6#   $
 0.75Q?63   ? 5      $ #8A16C1??6#   $ 1Q?63   5      ??5!      ?? 5"      $		 0,1&?6&   $	
 1,0&?67   .??5#      ? $ #060531??6#   $ 0Q?63   ? 5$      $ #1B1448??6#   $ 1Q?63   5%      ._?5-      ?  J? RenderTransformOrigin$ 0.513,0.294&?6   .+?5/      ?? $??/Images/Logo.png??6   $??-12,0,728.8,289q?62   ?? 50      $??MOBILE OPERATOR - MO??6   
???????$??10(?52       $??
Montserrat)?53       $??0??54       $??Center=?55       $??73,23,-0.2,259q?56       $??70??68   ?? 57      -   5         ??Name$ btnClose??57      $??0q?58      $??X??59      
???????$??12(?5;      $??
Montserrat)?5<       ? Cursor$
 Hand??5=      $ 0.551,0.455&?5>   4   $??743,-3,-0.2,314q?6X   ??5@      ?? 5A       ?? 
TargetType" ??6    .?5B      ??  ?? Property ? ?? ?? Value ?#DA34AE6;    ?? Triggers 5C      P? 5D   "    P? Property ?@J?IsMouseOver P? Value . . ?5E   &   ??  ? ?? ?#C62DAE6C   5F   #   5H      ??5K      ?? 5L       ?? 
TargetType" ??6*   .R?5M      ?? $??18??6%   $??18??60   $ 9??5N   )   #??z??5O   )   ._?5P   "   ?? $??Center=?63   $??Center=?5Q   7   5R      5S      5U      ?? 5V      -   5        $ btnMinimize??5V      $??0q?5W      $??-??5X      
???????$??16(?5Z      $??
Montserrat)?5[      $
 Hand??5\      $ 1.229,0.131&?5]   7   $??708,-3,53.8,314q?6[   ??5_      ?? 5`      " ??6    .?5a      ??  ? ?? ?#28AEED6;    5b      P? 5c   "    ?@J?IsMouseOver . . ?5d   &   ??  ? ?? ?#278BEF6C   5e   #   5g      ??5j      ?? 5k      " ??6*   .R?5l      ?? $??18??6%   $??18??60   $ 9??5m   )   #??z??5n   )   ._?5o   "   ?? $??Center=?63   $??Center=?5p   7   5q      5r      5u      #  MaterialDesignThemes.Wpf.Card  5v      $
??Auto??5w      $??19q?5x      $??143,73,118.8,129q?6   ?? 5y      $b??\Напишите букву, по которой будет произведен поиск:??6   $??273,93,0,218q?6V   $
??Left=?6l   $	??425??6?   ?? 5z      -   5        $??textBox1??5z      $??А..Я??6+   $??328,134,338.8,188q?67   $??30??6R   ?? 5{      -   5        $ 	btn4_Copy??5{   [   $y?Visible=?6   $??
Найти??6J   ???#DA34AE
???   ?$??328,178,338.8,142q?6?   ??6.   ?? *	Command+6?   5}      5~      5      5?      