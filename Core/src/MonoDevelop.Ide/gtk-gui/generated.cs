// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Stetic {
    
    
    internal class Gui {
        
        public static void Build(object obj, System.Type type) {
            Stetic.Gui.Build(obj, type.FullName);
        }
        
        public static void Build(object obj, string id) {
            System.Collections.Hashtable bindings = new System.Collections.Hashtable();
            if ((id == "MonoDevelop.Ide.Gui.Dialogs.GotoTypeDialog")) {
                Gtk.Dialog cobj = ((Gtk.Dialog)(obj));
                // Widget MonoDevelop.Ide.Gui.Dialogs.GotoTypeDialog
                cobj.Title = Mono.Unix.Catalog.GetString("Go to Type");
                cobj.WindowPosition = ((Gtk.WindowPosition)(4));
                cobj.HasSeparator = false;
                cobj.Events = ((Gdk.EventMask)(256));
                cobj.Name = "MonoDevelop.Ide.Gui.Dialogs.GotoTypeDialog";
                // Internal child MonoDevelop.Ide.Gui.Dialogs.GotoTypeDialog.VBox
                Gtk.VBox w1 = cobj.VBox;
                w1.BorderWidth = ((uint)(2));
                w1.Events = ((Gdk.EventMask)(256));
                w1.Name = "dialog_VBox";
                // Container child dialog_VBox.Gtk.Box+BoxChild
                Gtk.ScrolledWindow w2 = new Gtk.ScrolledWindow();
                w2.VscrollbarPolicy = ((Gtk.PolicyType)(1));
                w2.HscrollbarPolicy = ((Gtk.PolicyType)(1));
                w2.ShadowType = ((Gtk.ShadowType)(1));
                w2.BorderWidth = ((uint)(12));
                w2.CanFocus = true;
                w2.Events = ((Gdk.EventMask)(0));
                w2.Name = "scrolledwindow1";
                // Container child scrolledwindow1.Gtk.Container+ContainerChild
                Gtk.TreeView w3 = new Gtk.TreeView();
                w3.CanFocus = true;
                w3.Events = ((Gdk.EventMask)(0));
                w3.Name = "treeview1";
                bindings["treeview1"] = w3;
                w2.Add(w3);
                bindings["scrolledwindow1"] = w2;
                w1.Add(w2);
                Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(w1[w2]));
                w5.Position = 0;
                bindings["dialog_VBox"] = w1;
                // Internal child MonoDevelop.Ide.Gui.Dialogs.GotoTypeDialog.ActionArea
                Gtk.HButtonBox w6 = cobj.ActionArea;
                w6.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
                w6.Spacing = 10;
                w6.BorderWidth = ((uint)(5));
                w6.Events = ((Gdk.EventMask)(256));
                w6.Name = "MonoDevelop.Ide.GotoTypeDialog_ActionArea";
                // Container child MonoDevelop.Ide.GotoTypeDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
                Gtk.Button w7 = new Gtk.Button();
                w7.UseStock = true;
                w7.UseUnderline = true;
                w7.CanFocus = true;
                w7.Events = ((Gdk.EventMask)(0));
                w7.Name = "button1";
                w7.CanDefault = true;
                w7.Label = Mono.Unix.Catalog.GetString("gtk-cancel");
                bindings["button1"] = w7;
                cobj.AddActionWidget(w7, -6);
                Gtk.ButtonBox.ButtonBoxChild w8 = ((Gtk.ButtonBox.ButtonBoxChild)(w6[w7]));
                w8.Expand = false;
                w8.Fill = false;
                // Container child MonoDevelop.Ide.GotoTypeDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
                Gtk.Button w9 = new Gtk.Button();
                w9.UseStock = true;
                w9.UseUnderline = true;
                w9.CanFocus = true;
                w9.Events = ((Gdk.EventMask)(0));
                w9.Name = "button4";
                w9.CanDefault = true;
                w9.Label = Mono.Unix.Catalog.GetString("gtk-ok");
                bindings["button4"] = w9;
                cobj.AddActionWidget(w9, -5);
                Gtk.ButtonBox.ButtonBoxChild w10 = ((Gtk.ButtonBox.ButtonBoxChild)(w6[w9]));
                w10.Position = 1;
                w10.Expand = false;
                w10.Fill = false;
                bindings["MonoDevelop.Ide.GotoTypeDialog_ActionArea"] = w6;
                cobj.DefaultWidth = 400;
                cobj.DefaultHeight = 300;
                bindings["MonoDevelop.Ide.Gui.Dialogs.GotoTypeDialog"] = cobj;
                w3.Show();
                w2.Show();
                w1.Show();
                w7.Show();
                w9.Show();
                w6.Show();
                cobj.Show();
                w3.RowActivated += ((Gtk.RowActivatedHandler)(System.Delegate.CreateDelegate(typeof(Gtk.RowActivatedHandler), cobj, "RowActivated")));
                w7.Clicked += ((System.EventHandler)(System.Delegate.CreateDelegate(typeof(System.EventHandler), cobj, "CancelClicked")));
                w9.Clicked += ((System.EventHandler)(System.Delegate.CreateDelegate(typeof(System.EventHandler), cobj, "OkClicked")));
            }
            System.Reflection.FieldInfo[] fields = obj.GetType().GetFields(((System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic) | System.Reflection.BindingFlags.Instance));
            for (int n = 0; (n < fields.Length); n = (n + 1)) {
                System.Reflection.FieldInfo field = fields[n];
                object widget = bindings[field.Name];
                if (((widget != null) && field.FieldType.IsInstanceOfType(widget))) {
                    field.SetValue(obj, widget);
                }
            }
        }
    }
    
    internal class ActionGroups {
        
        public static Gtk.ActionGroup GetActionGroup(System.Type type) {
            return Stetic.ActionGroups.GetActionGroup(type.FullName);
        }
        
        public static Gtk.ActionGroup GetActionGroup(string name) {
            return null;
        }
    }
}
