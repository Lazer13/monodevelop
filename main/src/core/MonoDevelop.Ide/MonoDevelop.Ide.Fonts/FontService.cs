// 
// FontService.cs
//  
// Author:
//       Mike Krüger <mkrueger@novell.com>
// 
// Copyright (c) 2010 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Linq;
using Mono.Addins;
using MonoDevelop.Core;
using Pango;

namespace MonoDevelop.Ide.Fonts
{
	public static class FontService
	{
		static List<FontDescriptionCodon> fontDescriptions = new List<FontDescriptionCodon> ();
		static Dictionary<string, FontDescription> loadedFonts = new Dictionary<string, FontDescription> ();
		static Properties fontProperties;
		
		public static IEnumerable<FontDescriptionCodon> FontDescriptions {
			get {
				return fontDescriptions;
			}
		}
		
		static FontService ()
		{
			fontProperties = PropertyService.Get ("FontProperties", new Properties ());
			
			AddinManager.AddExtensionNodeHandler ("/MonoDevelop/Ide/Fonts", delegate(object sender, ExtensionNodeEventArgs args) {
				var codon = (FontDescriptionCodon)args.ExtensionNode;
				switch (args.Change) {
				case ExtensionChange.Add:
					fontDescriptions.Add (codon);
					break;
				case ExtensionChange.Remove:
					fontDescriptions.Remove (codon);
					if (loadedFonts.ContainsKey (codon.Name))
						loadedFonts.Remove (codon.Name);
					break;
				}
			}); 
		}
		
		static FontDescription LoadFont (string name)
		{
			return Pango.FontDescription.FromString (FilterFontName (name));
		}
		
		public static string FilterFontName (string name)
		{
			if (name == "_DEFAULT_MONOSPACE")
				return DesktopService.DefaultMonospaceFont;
			return name;
		}
		
		public static string GetUnderlyingFontName (string name)
		{
			var result = fontProperties.Get<string> (name);
			
			if (result == null) {
				var font = GetFont (name);
				if (font == null)
					throw new InvalidOperationException ("Font " + name + " not found.");
				return font.FontDescription;
			}
			return result;
		}
		
		public static FontDescription GetFontDescription (string name)
		{
			if (loadedFonts.ContainsKey (name))
				return loadedFonts [name];
			return loadedFonts [name] = LoadFont (GetUnderlyingFontName (name));
		}
		
		public static FontDescriptionCodon GetFont (string name)
		{
			foreach (var d in fontDescriptions) {
				if (d.Name == name)
					return d;
			}
			LoggingService.LogError ("Font " + name + " not found.");
			return null;
		}
		
		public static void SetFont (string name, string value)
		{
			if (loadedFonts.ContainsKey (name)) 
				loadedFonts.Remove (name);
			fontProperties.Set (name, value);
			
			Console.WriteLine (fontChangeCallbacks.ContainsKey (name));
			if (fontChangeCallbacks.ContainsKey (name)) 
				fontChangeCallbacks [name].ForEach (c => c ());
		}
		
		static Dictionary<string, List<Action>> fontChangeCallbacks = new Dictionary<string, List<Action>> ();
		public static void RegisterFontChangedCallback (string fontName, Action callback)
		{
			if (!fontChangeCallbacks.ContainsKey (fontName))
				fontChangeCallbacks [fontName] = new List<Action> ();
			fontChangeCallbacks [fontName].Add (callback);
		}
		
		public static void RemoveCallback (Action callback)
		{
			foreach (var list in fontChangeCallbacks.Values)
				list.Remove (callback);
		}
	}
}