
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Ide.Projects
{
	public partial class FeatureSelectorDialog
	{
		private global::Gtk.VBox vbox5;

		private global::Gtk.Label label3;

		private global::MonoDevelop.Ide.Projects.CombineEntryFeatureSelector featureList;

		private global::Gtk.Button button1547;

		private global::Gtk.Button button1548;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Ide.Projects.FeatureSelectorDialog
			this.Name = "MonoDevelop.Ide.Projects.FeatureSelectorDialog";
			this.Title = global::MonoDevelop.Core.GettextCatalog.GetString ("New Project Features");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(6));
			// Internal child MonoDevelop.Ide.Projects.FeatureSelectorDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.Spacing = 6;
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			this.vbox5.BorderWidth = ((uint)(6));
			// Container child vbox5.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0f;
			this.label3.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("<b>Project features</b>");
			this.label3.UseMarkup = true;
			this.vbox5.Add (this.label3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label3]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.featureList = new global::MonoDevelop.Ide.Projects.CombineEntryFeatureSelector ();
			this.featureList.Events = ((global::Gdk.EventMask)(256));
			this.featureList.Name = "featureList";
			this.vbox5.Add (this.featureList);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.featureList]));
			w3.Position = 1;
			w1.Add (this.vbox5);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(w1[this.vbox5]));
			w4.Position = 0;
			// Internal child MonoDevelop.Ide.Projects.FeatureSelectorDialog.ActionArea
			global::Gtk.HButtonBox w5 = this.ActionArea;
			w5.Name = "GtkDialog_ActionArea";
			w5.Spacing = 6;
			w5.BorderWidth = ((uint)(5));
			w5.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child GtkDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.button1547 = new global::Gtk.Button ();
			this.button1547.CanFocus = true;
			this.button1547.Name = "button1547";
			this.button1547.UseUnderline = true;
			this.button1547.Label = "button1547";
			this.AddActionWidget (this.button1547, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w6 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5[this.button1547]));
			w6.Expand = false;
			w6.Fill = false;
			// Container child GtkDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.button1548 = new global::Gtk.Button ();
			this.button1548.CanFocus = true;
			this.button1548.Name = "button1548";
			this.button1548.UseUnderline = true;
			this.button1548.Label = "button1548";
			this.AddActionWidget (this.button1548, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w7 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5[this.button1548]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 585;
			this.DefaultHeight = 435;
			this.Show ();
		}
	}
}
