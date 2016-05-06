using System;
using Gtk;
using ShisenShoCore;

namespace ShisenShoGUI
{
	public class Window: Gtk.Window
	{
		Core c;
		public Window (Core core) : base (Gtk.WindowType.Toplevel)
		{
			Build ();
			this.c = core;
			this.Show ();
		}

		// Usefull to Stop the application when the close button is pressed on the Window
		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Chess.MainWindow
			this.Name = "ShisenSho.MainWindow";
			this.Title = "ShisenSho";
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);	// Necessary to throw the close button press on the window
		}
	}
}

