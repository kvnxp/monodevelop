
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Ide.Updater
{
	internal partial class UpdateDialog
	{
		private global::Gtk.Alignment alignment1;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Notebook notebook1;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.Label messageLabel;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Label infoLabel;
		private global::Gtk.ScrolledWindow scrolledwindow1;
		private global::Gtk.VBox productBox;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label1;
		private global::Gtk.ComboBox updateLevelCombo;
		private global::Gtk.CheckButton checkAutomaticallyCheck;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Ide.Updater.UpdateDialog
			this.Name = "MonoDevelop.Ide.Updater.UpdateDialog";
			this.Title = global::MonoDevelop.Core.GettextCatalog.GetString ("MonoDevelop Updater");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child MonoDevelop.Ide.Updater.UpdateDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			// Container child alignment2.Gtk.Container+ContainerChild
			this.messageLabel = new global::Gtk.Label ();
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Wrap = true;
			this.alignment2.Add (this.messageLabel);
			this.notebook1.Add (this.alignment2);
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.infoLabel = new global::Gtk.Label ();
			this.infoLabel.Name = "infoLabel";
			this.infoLabel.Xpad = 6;
			this.infoLabel.Ypad = 6;
			this.infoLabel.Xalign = 0F;
			this.infoLabel.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("The following updates are available. After downloading,\nplease quit MonoDevelop before installing them.");
			this.infoLabel.Wrap = true;
			this.vbox3.Add (this.infoLabel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.infoLabel]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w5 = new global::Gtk.Viewport ();
			w5.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.productBox = new global::Gtk.VBox ();
			this.productBox.Name = "productBox";
			this.productBox.Spacing = 12;
			w5.Add (this.productBox);
			this.scrolledwindow1.Add (w5);
			this.vbox3.Add (this.scrolledwindow1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.scrolledwindow1]));
			w8.Position = 1;
			this.notebook1.Add (this.vbox3);
			global::Gtk.Notebook.NotebookChild w9 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox3]));
			w9.Position = 1;
			this.vbox2.Add (this.notebook1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.notebook1]));
			w10.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("Update _level:");
			this.label1.UseUnderline = true;
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.updateLevelCombo = global::Gtk.ComboBox.NewText ();
			this.updateLevelCombo.Name = "updateLevelCombo";
			this.hbox1.Add (this.updateLevelCombo);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.updateLevelCombo]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.checkAutomaticallyCheck = new global::Gtk.CheckButton ();
			this.checkAutomaticallyCheck.CanFocus = true;
			this.checkAutomaticallyCheck.Name = "checkAutomaticallyCheck";
			this.checkAutomaticallyCheck.Label = global::MonoDevelop.Core.GettextCatalog.GetString ("Check for updates automatically");
			this.checkAutomaticallyCheck.DrawIndicator = true;
			this.checkAutomaticallyCheck.UseUnderline = true;
			this.vbox2.Add (this.checkAutomaticallyCheck);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.checkAutomaticallyCheck]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			this.alignment1.Add (this.vbox2);
			w1.Add (this.alignment1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(w1 [this.alignment1]));
			w16.Position = 0;
			// Internal child MonoDevelop.Ide.Updater.UpdateDialog.ActionArea
			global::Gtk.HButtonBox w17 = this.ActionArea;
			w17.Name = "dialog1_ActionArea";
			w17.Spacing = 10;
			w17.BorderWidth = ((uint)(5));
			w17.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-close";
			this.AddActionWidget (this.buttonOk, -7);
			global::Gtk.ButtonBox.ButtonBoxChild w18 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w17 [this.buttonOk]));
			w18.Expand = false;
			w18.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 508;
			this.DefaultHeight = 373;
			this.label1.MnemonicWidget = this.updateLevelCombo;
			this.Hide ();
		}
	}
}
