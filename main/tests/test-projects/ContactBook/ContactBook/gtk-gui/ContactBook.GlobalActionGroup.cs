
// This file has been generated by the GUI designer. Do not modify.
namespace ContactBook
{
	public partial class GlobalActionGroup
	{
		private global::Gtk.Action Run;

		public virtual void Build ()
		{
			// Action group ContactBook.GlobalActionGroup
			this.Run = new global::Gtk.Action ("Run", global::Mono.Unix.Catalog.GetString ("Run"), null, null);
			this.Run.ShortLabel = "Run";
			this.Add (this.Run, null);
			this.Run.Activated += new global::System.EventHandler (this.OnRunActivated);
		}
	}
}
