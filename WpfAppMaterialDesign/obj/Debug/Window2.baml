   M S B A M L   `   `   `  ????O  KWpfAppMaterialDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WpfAppMaterialDesignWpfAppMaterialDesign  5   	   "    WpfAppMaterialDesign.Window2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WpfAppMaterialDesign     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     ? Title$  
MainWindow??5	      $	??450??6   $	??800??6%    ? WindowStyle$
 None=?5
       ? 
ResizeMode$ NoResize=?5   	    ? WindowStartupLocation$ CenterScreen=?5   	   
??????  ? AllowsTransparency . .??5      ??  ?? CornerRadius$ 12??6   ??5   
   ?? 5       ?? ImageSource$ /Images/back-image.jpg??6    j? Stretch$
 None=?5      ._?5   
   ?? $ 10??6   $??2q?5       J? Opacity$
 0.95Q?5      $??
0,0,0,-0.4q?6   ??5      ?? 5      	 ?? 
StartPoint$		 0,0&?6&   
 ?? EndPoint$	
 1,1&?67   .??5      ?  ? Color$ #462AD8??6#    ? Offset$ 0Q?63   ? 5      $ #DA34AE??6#   $
 0.75Q?63   ? 5      $ #8A16C1??6#   $ 1Q?63   5      ??5!      ?? 5"      $		 0,1&?6&   $	
 1,0&?67   .??5#      ? $ #060531??6#   $ 0Q?63   ? 5$      $ #1B1448??6#   $ 1Q?63   5%      ._?5-      ? .+?5.      ?? -   5         ??Name$ btnClose??5.      $??0q?5/      $??X??50      
???????$??12(?52      $??
Montserrat)?53       ? Cursor$
 Hand??54       J? RenderTransformOrigin$ 0.551,0.455&?55   4   $??743,-3,-0.2,393.4q?6X   ??57      ?? 58       ?? 
TargetType" ??6    .?59      ??  ?? Property ? ?? ?? Value ?#DA34AE6;    ?? Triggers 5:      P? 5;   "    P? Property ?@J?IsMouseOver P? Value . . ?5<   &   ??  ? ?? ?#C62DAE6C   5=   #   5?      ??5B      ?? 5C       ?? 
TargetType" ??6*   .R?5D      ?? $??18??6%   $??18??60   $ 9??5E   )   #??z??5F   )   ._?5G   "   ?? $??Center=?63   $??Center=?5H   7   5I      5J      5L      ?? 5M      -   5        $ btnMinimize??5M      $??0q?5N      $??-??5O      
???????$??16(?5Q      $??
Montserrat)?5R      $
 Hand??5S      $ 1.229,0.131&?5T   7   $??703,-3,26.8,393.4q?6[   ??5V      ?? 5W      " ??6    .?5X      ??  ? ?? ?#28AEED6;    5Y      P? 5Z   "    ?@J?IsMouseOver . . ?5[   &   ??  ? ?? ?#278BEF6C   5\   #   5^      ??5a      ?? 5b      " ??6*   .R?5c      ?? $??18??6%   $??18??60   $ 9??5d   )   #??z??5e   )   ._?5f   "   ?? $??Center=?63   $??Center=?5g   7   5h      5i      5l      #  MaterialDesignThemes.Wpf.Card  5m      $
??Auto??5n      $??19q?5o      $??208,68,303.8,93.4q?6   5r      ?? 5s      -   5        $??textBox1??5s      $
??Left=?6+   $??23??6F   $??288,133,0,0q?6R    ?? TextWrapping$
 Wrap=?6g   $??ФИО??6{   $	??Top=?6?   $	??120??6?   ?? 5t      -   5        $??textBox2??5t      $
??Left=?6+   $??23??6F   $??288,193,0,0q?6R   $
 Wrap=?6g   $??Код клиента??6{   $	??Top=?6?   $	??120??6?   ?? 5u      -   5        $??textBox3??5u      $
??Left=?6+   $??23??6F   $??288,255,0,0q?6R   $
 Wrap=?6g   $??Баланс??6{   $	??Top=?6?   $	??120??6?   5x      5y      5z      5{      