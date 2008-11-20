// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.Dialogs {
    
    
    internal partial class TipOfTheDayWindow {
        
        private Gtk.VBox vbox2;
        
        private Gtk.VBox vbox3;
        
        private Gtk.HBox hbox7;
        
        private Gtk.Image image5;
        
        private Gtk.Label categoryLabel;
        
        private Gtk.ScrolledWindow scrolledwindow2;
        
        private Gtk.TextView tipTextview;
        
        private Gtk.HBox hbox5;
        
        private Gtk.CheckButton noshowCheckbutton;
        
        private Gtk.HButtonBox hbuttonbox1;
        
        private Gtk.Button nextButton;
        
        private Gtk.Button closeButton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.Gui.Dialogs.TipOfTheDayWindow
            this.Name = "MonoDevelop.Ide.Gui.Dialogs.TipOfTheDayWindow";
            this.Title = "Tip of the Day";
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(6));
            // Container child MonoDevelop.Ide.Gui.Dialogs.TipOfTheDayWindow.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 12;
            this.vbox3.BorderWidth = ((uint)(6));
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox7 = new Gtk.HBox();
            this.hbox7.Name = "hbox7";
            this.hbox7.Spacing = 5;
            // Container child hbox7.Gtk.Box+BoxChild
            this.image5 = new Gtk.Image();
            this.image5.Name = "image5";
            this.image5.Xalign = 0F;
            this.image5.Yalign = 0F;
            this.image5.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-info", Gtk.IconSize.Dialog, 48);
            this.hbox7.Add(this.image5);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.hbox7[this.image5]));
            w1.Position = 0;
            w1.Expand = false;
            // Container child hbox7.Gtk.Box+BoxChild
            this.categoryLabel = new Gtk.Label();
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Xalign = 0F;
            this.categoryLabel.LabelProp = Mono.Unix.Catalog.GetString("Did you know...?");
            this.categoryLabel.UseMarkup = true;
            this.categoryLabel.Wrap = true;
            this.hbox7.Add(this.categoryLabel);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox7[this.categoryLabel]));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            this.vbox3.Add(this.hbox7);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox7]));
            w3.Position = 0;
            w3.Expand = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.scrolledwindow2 = new Gtk.ScrolledWindow();
            this.scrolledwindow2.Name = "scrolledwindow2";
            this.scrolledwindow2.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow2.Gtk.Container+ContainerChild
            this.tipTextview = new Gtk.TextView();
            this.tipTextview.Buffer.Text = "Did you know that you can design lots of cool things with glade?";
            this.tipTextview.Name = "tipTextview";
            this.tipTextview.Editable = false;
            this.tipTextview.CursorVisible = false;
            this.tipTextview.WrapMode = ((Gtk.WrapMode)(2));
            this.scrolledwindow2.Add(this.tipTextview);
            this.vbox3.Add(this.scrolledwindow2);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox3[this.scrolledwindow2]));
            w5.Position = 1;
            this.vbox2.Add(this.vbox3);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox2[this.vbox3]));
            w6.Position = 0;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox5 = new Gtk.HBox();
            this.hbox5.Name = "hbox5";
            this.hbox5.Spacing = 12;
            this.hbox5.BorderWidth = ((uint)(6));
            // Container child hbox5.Gtk.Box+BoxChild
            this.noshowCheckbutton = new Gtk.CheckButton();
            this.noshowCheckbutton.Name = "noshowCheckbutton";
            this.noshowCheckbutton.Label = Mono.Unix.Catalog.GetString("_Show at startup");
            this.noshowCheckbutton.DrawIndicator = true;
            this.noshowCheckbutton.UseUnderline = true;
            this.hbox5.Add(this.noshowCheckbutton);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox5[this.noshowCheckbutton]));
            w7.Position = 0;
            w7.Expand = false;
            w7.Fill = false;
            // Container child hbox5.Gtk.Box+BoxChild
            this.hbuttonbox1 = new Gtk.HButtonBox();
            this.hbuttonbox1.Name = "hbuttonbox1";
            this.hbuttonbox1.Spacing = 10;
            this.hbuttonbox1.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
            this.nextButton = new Gtk.Button();
            this.nextButton.Name = "nextButton";
            this.nextButton.UseUnderline = true;
            // Container child nextButton.Gtk.Container+ContainerChild
            Gtk.Alignment w8 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w9 = new Gtk.HBox();
            w9.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w10 = new Gtk.Image();
            w10.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-go-forward", Gtk.IconSize.Button, 20);
            w9.Add(w10);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w12 = new Gtk.Label();
            w12.LabelProp = Mono.Unix.Catalog.GetString("_Next Tip");
            w12.UseUnderline = true;
            w9.Add(w12);
            w8.Add(w9);
            this.nextButton.Add(w8);
            this.hbuttonbox1.Add(this.nextButton);
            // Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
            this.closeButton = new Gtk.Button();
            this.closeButton.CanDefault = true;
            this.closeButton.Name = "closeButton";
            this.closeButton.UseStock = true;
            this.closeButton.UseUnderline = true;
            this.closeButton.Label = "gtk-close";
            this.hbuttonbox1.Add(this.closeButton);
            Gtk.ButtonBox.ButtonBoxChild w17 = ((Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.closeButton]));
            w17.Position = 1;
            this.hbox5.Add(this.hbuttonbox1);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.hbox5[this.hbuttonbox1]));
            w18.Position = 1;
            this.vbox2.Add(this.hbox5);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox5]));
            w19.Position = 1;
            w19.Expand = false;
            this.Add(this.vbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 500;
            this.DefaultHeight = 285;
            this.closeButton.HasDefault = true;
            this.Show();
        }
    }
}
