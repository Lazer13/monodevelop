// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.OptionPanels {
    
    
    public partial class TasksPanelWidget {
        
        private Gtk.VBox vbox6;
        
        private Gtk.HBox hbox2;
        
        private Gtk.VBox vbox7;
        
        private Gtk.Label labelTokens;
        
        private Gtk.ScrolledWindow scrolledwindow3;
        
        private Gtk.TreeView tokensTreeView;
        
        private Gtk.VBox vbox14;
        
        private Gtk.VBox vboxPriority;
        
        private Gtk.Label label112;
        
        private Gtk.Entry entryToken;
        
        private Gtk.Label label113;
        
        private Gtk.HButtonBox hbuttonbox2;
        
        private Gtk.Button buttonChange;
        
        private Gtk.Button buttonRemove;
        
        private Gtk.Button buttonAdd;
        
        private Gtk.Label label;
        
        private Gtk.HSeparator hseparator2;
        
        private Gtk.Frame frame1;
        
        private Gtk.Alignment alignment1;
        
        private Gtk.Table table6;
        
        private Gtk.ColorButton colorbuttonHighPrio;
        
        private Gtk.ColorButton colorbuttonLowPrio;
        
        private Gtk.ColorButton colorbuttonNormalPrio;
        
        private Gtk.Label label10;
        
        private Gtk.Label label11;
        
        private Gtk.Label label12;
        
        private Gtk.Label label9;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.Gui.OptionPanels.TasksPanelWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Ide.Gui.OptionPanels.TasksPanelWidget";
            // Container child MonoDevelop.Ide.Gui.OptionPanels.TasksPanelWidget.Gtk.Container+ContainerChild
            this.vbox6 = new Gtk.VBox();
            this.vbox6.Name = "vbox6";
            this.vbox6.Spacing = 12;
            // Container child vbox6.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 8;
            // Container child hbox2.Gtk.Box+BoxChild
            this.vbox7 = new Gtk.VBox();
            this.vbox7.Name = "vbox7";
            // Container child vbox7.Gtk.Box+BoxChild
            this.labelTokens = new Gtk.Label();
            this.labelTokens.Name = "labelTokens";
            this.labelTokens.Xalign = 0F;
            this.labelTokens.Yalign = 0F;
            this.labelTokens.LabelProp = Mono.Unix.Catalog.GetString("_Token List:");
            this.labelTokens.UseUnderline = true;
            this.vbox7.Add(this.labelTokens);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox7[this.labelTokens]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox7.Gtk.Box+BoxChild
            this.scrolledwindow3 = new Gtk.ScrolledWindow();
            this.scrolledwindow3.WidthRequest = 200;
            this.scrolledwindow3.Name = "scrolledwindow3";
            this.scrolledwindow3.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow3.Gtk.Container+ContainerChild
            this.tokensTreeView = new Gtk.TreeView();
            this.tokensTreeView.Name = "tokensTreeView";
            this.tokensTreeView.HeadersVisible = false;
            this.tokensTreeView.HeadersClickable = true;
            this.scrolledwindow3.Add(this.tokensTreeView);
            this.vbox7.Add(this.scrolledwindow3);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox7[this.scrolledwindow3]));
            w3.Position = 1;
            this.hbox2.Add(this.vbox7);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox2[this.vbox7]));
            w4.Position = 0;
            // Container child hbox2.Gtk.Box+BoxChild
            this.vbox14 = new Gtk.VBox();
            this.vbox14.Name = "vbox14";
            this.vbox14.Spacing = 4;
            // Container child vbox14.Gtk.Box+BoxChild
            this.vboxPriority = new Gtk.VBox();
            this.vboxPriority.Name = "vboxPriority";
            this.vboxPriority.Spacing = 4;
            // Container child vboxPriority.Gtk.Box+BoxChild
            this.label112 = new Gtk.Label();
            this.label112.Name = "label112";
            this.label112.Xalign = 0F;
            this.label112.LabelProp = Mono.Unix.Catalog.GetString("_Name:");
            this.label112.UseUnderline = true;
            this.vboxPriority.Add(this.label112);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vboxPriority[this.label112]));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vboxPriority.Gtk.Box+BoxChild
            this.entryToken = new Gtk.Entry();
            this.entryToken.Name = "entryToken";
            this.entryToken.IsEditable = true;
            this.entryToken.MaxLength = 50;
            this.entryToken.InvisibleChar = '●';
            this.vboxPriority.Add(this.entryToken);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vboxPriority[this.entryToken]));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vboxPriority.Gtk.Box+BoxChild
            this.label113 = new Gtk.Label();
            this.label113.Name = "label113";
            this.label113.Xalign = 0F;
            this.label113.LabelProp = Mono.Unix.Catalog.GetString("Priority:");
            this.vboxPriority.Add(this.label113);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vboxPriority[this.label113]));
            w7.Position = 2;
            w7.Expand = false;
            w7.Fill = false;
            this.vbox14.Add(this.vboxPriority);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox14[this.vboxPriority]));
            w8.Position = 0;
            w8.Expand = false;
            w8.Fill = false;
            // Container child vbox14.Gtk.Box+BoxChild
            this.hbuttonbox2 = new Gtk.HButtonBox();
            this.hbuttonbox2.Name = "hbuttonbox2";
            this.hbuttonbox2.Spacing = 6;
            this.hbuttonbox2.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
            this.buttonChange = new Gtk.Button();
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.UseStock = true;
            this.buttonChange.UseUnderline = true;
            this.buttonChange.Label = "gtk-edit";
            this.hbuttonbox2.Add(this.buttonChange);
            // Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
            this.buttonRemove = new Gtk.Button();
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.UseStock = true;
            this.buttonRemove.UseUnderline = true;
            this.buttonRemove.Label = "gtk-remove";
            this.hbuttonbox2.Add(this.buttonRemove);
            Gtk.ButtonBox.ButtonBoxChild w10 = ((Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2[this.buttonRemove]));
            w10.Position = 1;
            // Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
            this.buttonAdd = new Gtk.Button();
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseStock = true;
            this.buttonAdd.UseUnderline = true;
            this.buttonAdd.Label = "gtk-add";
            this.hbuttonbox2.Add(this.buttonAdd);
            Gtk.ButtonBox.ButtonBoxChild w11 = ((Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2[this.buttonAdd]));
            w11.Position = 2;
            this.vbox14.Add(this.hbuttonbox2);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox14[this.hbuttonbox2]));
            w12.Position = 1;
            w12.Expand = false;
            // Container child vbox14.Gtk.Box+BoxChild
            this.label = new Gtk.Label();
            this.label.Name = "label";
            this.label.Ypad = 12;
            this.label.Yalign = 0F;
            this.label.LabelProp = Mono.Unix.Catalog.GetString("<i><b>Note:</b> Only Letters, Digits and Underscore are allowed.</i>");
            this.label.UseMarkup = true;
            this.label.Wrap = true;
            this.label.Justify = ((Gtk.Justification)(2));
            this.vbox14.Add(this.label);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.vbox14[this.label]));
            w13.Position = 2;
            w13.Expand = false;
            w13.Fill = false;
            this.hbox2.Add(this.vbox14);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.hbox2[this.vbox14]));
            w14.Position = 1;
            this.vbox6.Add(this.hbox2);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox6[this.hbox2]));
            w15.Position = 0;
            // Container child vbox6.Gtk.Box+BoxChild
            this.hseparator2 = new Gtk.HSeparator();
            this.hseparator2.Name = "hseparator2";
            this.vbox6.Add(this.hseparator2);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox6[this.hseparator2]));
            w16.Position = 1;
            w16.Expand = false;
            // Container child vbox6.Gtk.Box+BoxChild
            this.frame1 = new Gtk.Frame();
            this.frame1.Name = "frame1";
            this.frame1.ShadowType = ((Gtk.ShadowType)(0));
            // Container child frame1.Gtk.Container+ContainerChild
            this.alignment1 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment1.Name = "alignment1";
            this.alignment1.LeftPadding = ((uint)(12));
            this.alignment1.TopPadding = ((uint)(4));
            // Container child alignment1.Gtk.Container+ContainerChild
            this.table6 = new Gtk.Table(((uint)(3)), ((uint)(2)), false);
            this.table6.Name = "table6";
            this.table6.RowSpacing = ((uint)(4));
            this.table6.ColumnSpacing = ((uint)(6));
            // Container child table6.Gtk.Table+TableChild
            this.colorbuttonHighPrio = new Gtk.ColorButton();
            this.colorbuttonHighPrio.Name = "colorbuttonHighPrio";
            this.table6.Add(this.colorbuttonHighPrio);
            Gtk.Table.TableChild w17 = ((Gtk.Table.TableChild)(this.table6[this.colorbuttonHighPrio]));
            w17.LeftAttach = ((uint)(1));
            w17.RightAttach = ((uint)(2));
            w17.XOptions = ((Gtk.AttachOptions)(0));
            w17.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table6.Gtk.Table+TableChild
            this.colorbuttonLowPrio = new Gtk.ColorButton();
            this.colorbuttonLowPrio.Name = "colorbuttonLowPrio";
            this.table6.Add(this.colorbuttonLowPrio);
            Gtk.Table.TableChild w18 = ((Gtk.Table.TableChild)(this.table6[this.colorbuttonLowPrio]));
            w18.TopAttach = ((uint)(2));
            w18.BottomAttach = ((uint)(3));
            w18.LeftAttach = ((uint)(1));
            w18.RightAttach = ((uint)(2));
            w18.XOptions = ((Gtk.AttachOptions)(0));
            w18.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table6.Gtk.Table+TableChild
            this.colorbuttonNormalPrio = new Gtk.ColorButton();
            this.colorbuttonNormalPrio.Name = "colorbuttonNormalPrio";
            this.table6.Add(this.colorbuttonNormalPrio);
            Gtk.Table.TableChild w19 = ((Gtk.Table.TableChild)(this.table6[this.colorbuttonNormalPrio]));
            w19.TopAttach = ((uint)(1));
            w19.BottomAttach = ((uint)(2));
            w19.LeftAttach = ((uint)(1));
            w19.RightAttach = ((uint)(2));
            w19.XOptions = ((Gtk.AttachOptions)(0));
            w19.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table6.Gtk.Table+TableChild
            this.label10 = new Gtk.Label();
            this.label10.Name = "label10";
            this.label10.Xalign = 1F;
            this.label10.LabelProp = Mono.Unix.Catalog.GetString("High");
            this.table6.Add(this.label10);
            Gtk.Table.TableChild w20 = ((Gtk.Table.TableChild)(this.table6[this.label10]));
            w20.XOptions = ((Gtk.AttachOptions)(0));
            w20.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table6.Gtk.Table+TableChild
            this.label11 = new Gtk.Label();
            this.label11.Name = "label11";
            this.label11.Xalign = 1F;
            this.label11.LabelProp = Mono.Unix.Catalog.GetString("Normal");
            this.table6.Add(this.label11);
            Gtk.Table.TableChild w21 = ((Gtk.Table.TableChild)(this.table6[this.label11]));
            w21.TopAttach = ((uint)(1));
            w21.BottomAttach = ((uint)(2));
            w21.XOptions = ((Gtk.AttachOptions)(0));
            w21.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table6.Gtk.Table+TableChild
            this.label12 = new Gtk.Label();
            this.label12.Name = "label12";
            this.label12.Xalign = 1F;
            this.label12.LabelProp = Mono.Unix.Catalog.GetString("Low");
            this.label12.Justify = ((Gtk.Justification)(2));
            this.table6.Add(this.label12);
            Gtk.Table.TableChild w22 = ((Gtk.Table.TableChild)(this.table6[this.label12]));
            w22.TopAttach = ((uint)(2));
            w22.BottomAttach = ((uint)(3));
            w22.XOptions = ((Gtk.AttachOptions)(0));
            w22.YOptions = ((Gtk.AttachOptions)(0));
            this.alignment1.Add(this.table6);
            this.frame1.Add(this.alignment1);
            this.label9 = new Gtk.Label();
            this.label9.Name = "label9";
            this.label9.LabelProp = Mono.Unix.Catalog.GetString("<b>Task Priorities Foreground Colors</b>");
            this.label9.UseMarkup = true;
            this.frame1.LabelWidget = this.label9;
            this.vbox6.Add(this.frame1);
            Gtk.Box.BoxChild w25 = ((Gtk.Box.BoxChild)(this.vbox6[this.frame1]));
            w25.PackType = ((Gtk.PackType)(1));
            w25.Position = 2;
            w25.Expand = false;
            w25.Fill = false;
            this.Add(this.vbox6);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.label112.MnemonicWidget = this.entryToken;
            this.Show();
        }
    }
}
