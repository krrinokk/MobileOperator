   M S B A M L   `   `   `  ????O  KWpfAppMaterialDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WpfAppMaterialDesignWpfAppMaterialDesign  5   	   '    !WpfAppMaterialDesign.View.Window8   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WpfAppMaterialDesign     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     ? Title$  
MainWindow??5	      $	??450??6   $	??800??6%    ? WindowStyle$
 None=?5
       ? 
ResizeMode$ NoResize=?5   	    ? WindowStartupLocation$ CenterScreen=?5   	   
??????  ? AllowsTransparency . .??5      ?? -   5        $??Dogovor??5       ?? CornerRadius$ 12??6   $??-10,0,0,94.6q?6.   ??5   
   ?? 5       ?? ImageSource$ /Images/back-image.jpg??6    j? Stretch$
 None=?5      ._?5   
   ?? $ 10??6   $??2q?5       J? Opacity$
 0.95Q?5      $??0,0,-20,0.2q?6   ??5      ?? 5      	 ?? 
StartPoint$		 0,0&?6&   
 ?? EndPoint$	
 1,1&?67   .??5      ?  ? Color$ #462AD8??6#    ? Offset$ 0Q?63   ? 5      $ #DA34AE??6#   $
 0.75Q?63   ? 5      $ #8A16C1??6#   $ 1Q?63   5      ??5!      ?? 5"      $		 0,1&?6&   $	
 1,0&?67   .??5#      ? $ #060531??6#   $ 0Q?63   ? 5$      $ #1B1448??6#   $ 1Q?63   5%      ._?5-      ?  J? RenderTransformOrigin$ 0.513,0.294&?6    ? RowDefinitions 5.      ?? 5/      $	??87* ?6$   ?? 50       ? ColumnDefinitions 52      ?? 53      $	??49* ?6'   ?? 54      $
??359* ?6'   .+?57      ?? $??/Images/Logo.png??6   $??-12,0,10.4,285.4q?62   ?? 58      $??MOBILE OPERATOR - MO??6   
???????$??10(?5:       $??
Montserrat)?5;       $??0??5<       $??Center=?5=       $??73,23,-0.2,255.4q?5>       $??70??6:   $??2??6F   ?? 5?      -   5         ??Name$ btnClose??5?      $??0q?5@      $??X??5A      
???????$??12(?5C      $??
Montserrat)?5D       ? Cursor$
 Hand??5E      $ 0.551,0.455&?5F   4   $??644.6,-3,-0.2,310.4q?6X   $??1??6u   ??5H      ?? 5I       ?? 
TargetType" ??6    .?5J      ??  ?? Property ? ?? ?? Value ?#DA34AE6;    ?? Triggers 5K      P? 5L   "    P? Property ?@J?IsMouseOver P? Value . . ?5M   &   ??  ? ?? ?#C62DAE6C   5N   #   5P      ??5S      ?? 5T       ?? 
TargetType" ??6*   .R?5U      ?? $??18??6%   $??18??60   $ 9??5V   )   #??z??5W   )   ._?5X   "   ?? $??Center=?63   $??Center=?5Y   7   5Z      5[      5]      ?? 5^      -   5        $ btnMinimize??5^      $??0q?5_      $??-??5`      
???????$??16(?5b      $??
Montserrat)?5c      $
 Hand??5d      $ 1.229,0.131&?5e   7   $??609.6,-3,53.8,310.4q?6[   $??1??6x   ??5g      ?? 5h      " ??6    .?5i      ??  ? ?? ?#28AEED6;    5j      P? 5k   "    ?@J?IsMouseOver . . ?5l   &   ??  ? ?? ?#278BEF6C   5m   #   5o      ??5r      ?? 5s      " ??6*   .R?5t      ?? $??18??6%   $??18??60   $ 9??5u   )   #??z??5v   )   ._?5w   "   ?? $??Center=?63   $??Center=?5x   7   5y      5z      5}      #  MaterialDesignThemes.Wpf.Card  5      $
??Auto??5?      $??19q?5?      $??44.8,43,118.4,25q?6   $??1??6*   5?      ?? 5?      -   5        $ 	btn4_Copy??5?   Z   $y?Visible=?6   $??
Найти??6I   ???#DA34AE
???   ?$??58.8,115,518.4,198q?6?   $
??Auto??6?   $??1??6?   ??6.   ?? *Report+6?   ?? 5?      -   5        $ print2Command1??5?   ?   $y?Visible=?6   
???   ? #  MaterialDesignRaisedLightButton#??[  6D   $??Печать??6?   $??438.8,115,138.4,198q?6?   $
??Auto??6?   $??1??6?   ??6}   ?? *Print+6?   ? 5?      -   5        $??	PrintGrid??5?      $??44.8,63,122.4,25q?6(   $??1??6B   .+?5?      &   System.Windows.Controls.DataGrid  -   5        $??	dataGrid7??5?   \   $
??Left=?6   $	??150??6m   $??
10,100,0,0q?6z   $	??Top=?6?   $	??540??6?   ??6:   ?? *
Dogovors+6?   ?? 5?      $????Выберите код тарифа, по которому хотите просмотреть заключенные договоры:??6    $??
44,0,0,240q?6q   $
??Left=?6?   $	??516??6?   ?? 5?      -   5        $??	comboBox1??5?   >   $??184,25,191,200q?6O   $??35??6g   ??6   ?? *Тарифs+6g   5?      5?      5?      5?      5?      