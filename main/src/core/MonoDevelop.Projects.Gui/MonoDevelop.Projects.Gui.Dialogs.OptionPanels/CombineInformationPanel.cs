/*
Copyright (c) 2006 Scott Ellington

Permission is hereby granted, free of charge, to any person 
obtaining a copy of this software and associated documentation 
files (the "Software"), to deal in the Software without 
restriction, including without limitation the rights to use, 
copy, modify, merge, publish, distribute, sublicense, and/or sell 
copies of the Software, and to permit persons to whom the 
Software is furnished to do so, subject to the following 
conditions:

The above copyright notice and this permission notice shall be 
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
OTHER DEALINGS IN THE SOFTWARE. 
*/

using System;
using System.IO;
using System.Collections;
using System.ComponentModel;

using MonoDevelop.Projects;
using MonoDevelop.Core;

using MonoDevelop.Core.Gui.Components;
using MonoDevelop.Core.Gui.Dialogs;
using Gtk;
using MonoDevelop.Components;

namespace MonoDevelop.Projects.Gui.Dialogs.OptionPanels
{
	internal class CombineInformationPanel : AbstractOptionPanel 
	{
		CombineInformationWidget widget;

		public override void LoadPanelContents()
		{
			Add ( widget = new  CombineInformationWidget ((Properties) CustomizationObject));
		}
		
		public override bool StorePanelContents()
		{
			widget.Store ((Properties) CustomizationObject);
 			return true;
		}
	}
		
	partial class CombineInformationWidget : Gtk.Bin 
	{
		Combine combine;

		public CombineInformationWidget (Properties CustomizationObject) 
		{
			Build ();
			this.combine =  ((Properties)CustomizationObject).Get<Combine> ("Combine");

			versLabel.UseUnderline = true;
			descLabel.UseUnderline = true;

			versEntry.Text = combine.Version;
			descView.Buffer.Text = combine.Description;
		}			
		
		public void Store (Properties CustomizationObject)
		{
			combine.Version = versEntry.Text;
			combine.Description = descView.Buffer.Text;
		}
	}
}

