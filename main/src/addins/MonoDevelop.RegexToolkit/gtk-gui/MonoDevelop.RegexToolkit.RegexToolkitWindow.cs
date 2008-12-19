// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.RegexToolkit {
    
    
    public partial class RegexToolkitWindow {
        
        private Gtk.VBox vbox2;
        
        private Gtk.VPaned vpaned1;
        
        private Gtk.HPaned hpaned1;
        
        private Gtk.VBox vbox6;
        
        private Gtk.Label label8;
        
        private Gtk.Entry entryRegEx;
        
        private Gtk.VBox vbox3;
        
        private Gtk.CheckButton checkbuttonReplace;
        
        private Gtk.Entry entryReplace;
        
        private Gtk.HBox hbox7;
        
        private Gtk.Button buttonStart;
        
        private Gtk.VBox HelpWidget;
        
        private Gtk.Label label9;
        
        private Gtk.HBox hbox5;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.TextView inputTextview;
        
        private Gtk.Notebook notebook3;
        
        private Gtk.VBox vbox4;
        
        private Gtk.ScrolledWindow elementsscrolledwindow;
        
        private Gtk.TreeView elementsTreeview;
        
        private Gtk.Label label5;
        
        private Gtk.ScrolledWindow scrolledwindow5;
        
        private Gtk.TreeView optionsTreeview;
        
        private Gtk.Label label7;
        
        private Gtk.HBox hbox4;
        
        private Gtk.Notebook notebook2;
        
        private Gtk.ScrolledWindow scrolledwindow2;
        
        private Gtk.TreeView resultsTreeview;
        
        private Gtk.Label label3;
        
        private Gtk.ScrolledWindow scrolledwindow4;
        
        private Gtk.TextView replaceResultTextview;
        
        private Gtk.Label label4;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonLibrary;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.RegexToolkit.RegexToolkitWindow
            this.Name = "MonoDevelop.RegexToolkit.RegexToolkitWindow";
            this.Title = Mono.Unix.Catalog.GetString("Regular Expression Toolkit");
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(6));
            // Container child MonoDevelop.RegexToolkit.RegexToolkitWindow.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.vpaned1 = new Gtk.VPaned();
            this.vpaned1.CanFocus = true;
            this.vpaned1.Name = "vpaned1";
            this.vpaned1.Position = 255;
            this.vpaned1.BorderWidth = ((uint)(6));
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.hpaned1 = new Gtk.HPaned();
            this.hpaned1.CanFocus = true;
            this.hpaned1.Name = "hpaned1";
            this.hpaned1.Position = 297;
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.vbox6 = new Gtk.VBox();
            this.vbox6.Name = "vbox6";
            this.vbox6.Spacing = 6;
            this.vbox6.BorderWidth = ((uint)(6));
            // Container child vbox6.Gtk.Box+BoxChild
            this.label8 = new Gtk.Label();
            this.label8.Name = "label8";
            this.label8.Xalign = 0F;
            this.label8.LabelProp = Mono.Unix.Catalog.GetString("_Regular Expression");
            this.label8.UseUnderline = true;
            this.vbox6.Add(this.label8);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox6[this.label8]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox6.Gtk.Box+BoxChild
            this.entryRegEx = new Gtk.Entry();
            this.entryRegEx.CanFocus = true;
            this.entryRegEx.Name = "entryRegEx";
            this.entryRegEx.IsEditable = true;
            this.entryRegEx.InvisibleChar = '●';
            this.vbox6.Add(this.entryRegEx);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox6[this.entryRegEx]));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox6.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.checkbuttonReplace = new Gtk.CheckButton();
            this.checkbuttonReplace.CanFocus = true;
            this.checkbuttonReplace.Name = "checkbuttonReplace";
            this.checkbuttonReplace.Label = Mono.Unix.Catalog.GetString("_Replace");
            this.checkbuttonReplace.Active = true;
            this.checkbuttonReplace.DrawIndicator = true;
            this.checkbuttonReplace.UseUnderline = true;
            this.vbox3.Add(this.checkbuttonReplace);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox3[this.checkbuttonReplace]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.entryReplace = new Gtk.Entry();
            this.entryReplace.CanFocus = true;
            this.entryReplace.Name = "entryReplace";
            this.entryReplace.IsEditable = true;
            this.entryReplace.InvisibleChar = '●';
            this.vbox3.Add(this.entryReplace);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox3[this.entryReplace]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox7 = new Gtk.HBox();
            this.hbox7.Name = "hbox7";
            this.hbox7.Spacing = 6;
            // Container child hbox7.Gtk.Box+BoxChild
            this.buttonStart = new Gtk.Button();
            this.buttonStart.CanDefault = true;
            this.buttonStart.CanFocus = true;
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseUnderline = true;
            // Container child buttonStart.Gtk.Container+ContainerChild
            Gtk.Alignment w5 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w6 = new Gtk.HBox();
            w6.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w7 = new Gtk.Image();
            w7.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-media-play", Gtk.IconSize.Menu, 16);
            w6.Add(w7);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w9 = new Gtk.Label();
            w9.LabelProp = Mono.Unix.Catalog.GetString("_Start Regular Expression");
            w9.UseUnderline = true;
            w6.Add(w9);
            w5.Add(w6);
            this.buttonStart.Add(w5);
            this.hbox7.Add(this.buttonStart);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox7[this.buttonStart]));
            w13.PackType = ((Gtk.PackType)(1));
            w13.Position = 0;
            w13.Expand = false;
            w13.Fill = false;
            this.vbox3.Add(this.hbox7);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox7]));
            w14.PackType = ((Gtk.PackType)(1));
            w14.Position = 2;
            w14.Expand = false;
            w14.Fill = false;
            this.vbox6.Add(this.vbox3);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox6[this.vbox3]));
            w15.Position = 2;
            w15.Expand = false;
            w15.Fill = false;
            // Container child vbox6.Gtk.Box+BoxChild
            this.HelpWidget = new Gtk.VBox();
            this.HelpWidget.Name = "HelpWidget";
            this.HelpWidget.Spacing = 6;
            this.HelpWidget.BorderWidth = ((uint)(6));
            // Container child HelpWidget.Gtk.Box+BoxChild
            this.label9 = new Gtk.Label();
            this.label9.Name = "label9";
            this.label9.Xalign = 0F;
            this.label9.LabelProp = Mono.Unix.Catalog.GetString("_Input:");
            this.label9.UseMarkup = true;
            this.label9.UseUnderline = true;
            this.HelpWidget.Add(this.label9);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.HelpWidget[this.label9]));
            w16.Position = 0;
            w16.Expand = false;
            w16.Fill = false;
            // Container child HelpWidget.Gtk.Box+BoxChild
            this.hbox5 = new Gtk.HBox();
            this.hbox5.Name = "hbox5";
            this.hbox5.Spacing = 6;
            // Container child hbox5.Gtk.Box+BoxChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            this.inputTextview = new Gtk.TextView();
            this.inputTextview.CanFocus = true;
            this.inputTextview.Name = "inputTextview";
            this.scrolledwindow1.Add(this.inputTextview);
            this.hbox5.Add(this.scrolledwindow1);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.hbox5[this.scrolledwindow1]));
            w18.Position = 0;
            this.HelpWidget.Add(this.hbox5);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.HelpWidget[this.hbox5]));
            w19.Position = 1;
            this.vbox6.Add(this.HelpWidget);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.vbox6[this.HelpWidget]));
            w20.PackType = ((Gtk.PackType)(1));
            w20.Position = 3;
            this.hpaned1.Add(this.vbox6);
            Gtk.Paned.PanedChild w21 = ((Gtk.Paned.PanedChild)(this.hpaned1[this.vbox6]));
            w21.Resize = false;
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.notebook3 = new Gtk.Notebook();
            this.notebook3.CanFocus = true;
            this.notebook3.Name = "notebook3";
            this.notebook3.CurrentPage = 0;
            // Container child notebook3.Gtk.Notebook+NotebookChild
            this.vbox4 = new Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 6;
            // Container child vbox4.Gtk.Box+BoxChild
            this.elementsscrolledwindow = new Gtk.ScrolledWindow();
            this.elementsscrolledwindow.CanFocus = true;
            this.elementsscrolledwindow.Name = "elementsscrolledwindow";
            this.elementsscrolledwindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child elementsscrolledwindow.Gtk.Container+ContainerChild
            this.elementsTreeview = new Gtk.TreeView();
            this.elementsTreeview.CanFocus = true;
            this.elementsTreeview.Name = "elementsTreeview";
            this.elementsTreeview.HeadersClickable = true;
            this.elementsscrolledwindow.Add(this.elementsTreeview);
            this.vbox4.Add(this.elementsscrolledwindow);
            Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.vbox4[this.elementsscrolledwindow]));
            w23.Position = 0;
            this.notebook3.Add(this.vbox4);
            // Notebook tab
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("Elements");
            this.notebook3.SetTabLabel(this.vbox4, this.label5);
            this.label5.ShowAll();
            // Container child notebook3.Gtk.Notebook+NotebookChild
            this.scrolledwindow5 = new Gtk.ScrolledWindow();
            this.scrolledwindow5.CanFocus = true;
            this.scrolledwindow5.Name = "scrolledwindow5";
            this.scrolledwindow5.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow5.Gtk.Container+ContainerChild
            this.optionsTreeview = new Gtk.TreeView();
            this.optionsTreeview.CanFocus = true;
            this.optionsTreeview.Name = "optionsTreeview";
            this.optionsTreeview.HeadersClickable = true;
            this.scrolledwindow5.Add(this.optionsTreeview);
            this.notebook3.Add(this.scrolledwindow5);
            Gtk.Notebook.NotebookChild w26 = ((Gtk.Notebook.NotebookChild)(this.notebook3[this.scrolledwindow5]));
            w26.Position = 1;
            // Notebook tab
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("Options");
            this.notebook3.SetTabLabel(this.scrolledwindow5, this.label7);
            this.label7.ShowAll();
            this.hpaned1.Add(this.notebook3);
            this.vpaned1.Add(this.hpaned1);
            Gtk.Paned.PanedChild w28 = ((Gtk.Paned.PanedChild)(this.vpaned1[this.hpaned1]));
            w28.Resize = false;
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.notebook2 = new Gtk.Notebook();
            this.notebook2.CanFocus = true;
            this.notebook2.Name = "notebook2";
            this.notebook2.CurrentPage = 0;
            // Container child notebook2.Gtk.Notebook+NotebookChild
            this.scrolledwindow2 = new Gtk.ScrolledWindow();
            this.scrolledwindow2.CanFocus = true;
            this.scrolledwindow2.Name = "scrolledwindow2";
            this.scrolledwindow2.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow2.Gtk.Container+ContainerChild
            this.resultsTreeview = new Gtk.TreeView();
            this.resultsTreeview.CanFocus = true;
            this.resultsTreeview.Name = "resultsTreeview";
            this.resultsTreeview.HeadersClickable = true;
            this.scrolledwindow2.Add(this.resultsTreeview);
            this.notebook2.Add(this.scrolledwindow2);
            // Notebook tab
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Matches");
            this.notebook2.SetTabLabel(this.scrolledwindow2, this.label3);
            this.label3.ShowAll();
            // Container child notebook2.Gtk.Notebook+NotebookChild
            this.scrolledwindow4 = new Gtk.ScrolledWindow();
            this.scrolledwindow4.CanFocus = true;
            this.scrolledwindow4.Name = "scrolledwindow4";
            this.scrolledwindow4.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow4.Gtk.Container+ContainerChild
            this.replaceResultTextview = new Gtk.TextView();
            this.replaceResultTextview.CanFocus = true;
            this.replaceResultTextview.Name = "replaceResultTextview";
            this.replaceResultTextview.Editable = false;
            this.replaceResultTextview.CursorVisible = false;
            this.scrolledwindow4.Add(this.replaceResultTextview);
            this.notebook2.Add(this.scrolledwindow4);
            Gtk.Notebook.NotebookChild w32 = ((Gtk.Notebook.NotebookChild)(this.notebook2[this.scrolledwindow4]));
            w32.Position = 1;
            // Notebook tab
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("Replace");
            this.notebook2.SetTabLabel(this.scrolledwindow4, this.label4);
            this.label4.ShowAll();
            this.hbox4.Add(this.notebook2);
            Gtk.Box.BoxChild w33 = ((Gtk.Box.BoxChild)(this.hbox4[this.notebook2]));
            w33.Position = 0;
            this.vpaned1.Add(this.hbox4);
            this.vbox2.Add(this.vpaned1);
            Gtk.Box.BoxChild w35 = ((Gtk.Box.BoxChild)(this.vbox2[this.vpaned1]));
            w35.Position = 0;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-close";
            this.hbox1.Add(this.buttonCancel);
            Gtk.Box.BoxChild w36 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonCancel]));
            w36.PackType = ((Gtk.PackType)(1));
            w36.Position = 0;
            w36.Expand = false;
            w36.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonLibrary = new Gtk.Button();
            this.buttonLibrary.CanDefault = true;
            this.buttonLibrary.CanFocus = true;
            this.buttonLibrary.Name = "buttonLibrary";
            this.buttonLibrary.UseUnderline = true;
            this.buttonLibrary.Label = Mono.Unix.Catalog.GetString("Regex Library");
            this.hbox1.Add(this.buttonLibrary);
            Gtk.Box.BoxChild w37 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonLibrary]));
            w37.PackType = ((Gtk.PackType)(1));
            w37.Position = 1;
            w37.Expand = false;
            w37.Fill = false;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w38 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w38.Position = 1;
            w38.Expand = false;
            w38.Fill = false;
            this.Add(this.vbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 653;
            this.DefaultHeight = 481;
            this.label9.MnemonicWidget = this.inputTextview;
            this.Show();
        }
    }
}
