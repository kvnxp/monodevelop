
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Ide.Gui.OptionPanels
{
	internal partial class AddInsPanelWidget
	{
		private global::Gtk.VBox vbox72;
		private global::Gtk.CheckButton lookCheck;
		private global::Gtk.HBox hbox46;
		private global::Gtk.Label label104;
		private global::Gtk.Label label105;
		private global::Gtk.SpinButton valueSpin;
		private global::Gtk.ComboBox periodCombo;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.HBox hbox47;
		private global::Gtk.Button managerButton;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Ide.Gui.OptionPanels.AddInsPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Ide.Gui.OptionPanels.AddInsPanelWidget";
			// Container child MonoDevelop.Ide.Gui.OptionPanels.AddInsPanelWidget.Gtk.Container+ContainerChild
			this.vbox72 = new global::Gtk.VBox ();
			this.vbox72.Name = "vbox72";
			this.vbox72.Spacing = 6;
			// Container child vbox72.Gtk.Box+BoxChild
			this.lookCheck = new global::Gtk.CheckButton ();
			this.lookCheck.Name = "lookCheck";
			this.lookCheck.Label = global::MonoDevelop.Core.GettextCatalog.GetString ("Look for add-in updates at startup, with the following periodicity:");
			this.lookCheck.DrawIndicator = true;
			this.lookCheck.UseUnderline = true;
			this.vbox72.Add (this.lookCheck);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox72 [this.lookCheck]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox72.Gtk.Box+BoxChild
			this.hbox46 = new global::Gtk.HBox ();
			this.hbox46.Name = "hbox46";
			this.hbox46.Spacing = 6;
			// Container child hbox46.Gtk.Box+BoxChild
			this.label104 = new global::Gtk.Label ();
			this.label104.WidthRequest = 24;
			this.label104.Name = "label104";
			this.label104.Xalign = 0F;
			this.label104.Yalign = 0F;
			this.hbox46.Add (this.label104);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox46 [this.label104]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox46.Gtk.Box+BoxChild
			this.label105 = new global::Gtk.Label ();
			this.label105.Name = "label105";
			this.label105.Xalign = 0F;
			this.label105.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("Every");
			this.hbox46.Add (this.label105);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox46 [this.label105]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox46.Gtk.Box+BoxChild
			this.valueSpin = new global::Gtk.SpinButton (0, 100, 1);
			this.valueSpin.Name = "valueSpin";
			this.valueSpin.Adjustment.PageIncrement = 10;
			this.valueSpin.ClimbRate = 1;
			this.valueSpin.Numeric = true;
			this.valueSpin.Value = 1;
			this.hbox46.Add (this.valueSpin);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox46 [this.valueSpin]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox46.Gtk.Box+BoxChild
			this.periodCombo = global::Gtk.ComboBox.NewText ();
			this.periodCombo.AppendText (global::MonoDevelop.Core.GettextCatalog.GetString ("Days"));
			this.periodCombo.AppendText (global::MonoDevelop.Core.GettextCatalog.GetString ("Months"));
			this.periodCombo.Name = "periodCombo";
			this.periodCombo.Active = 0;
			this.hbox46.Add (this.periodCombo);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox46 [this.periodCombo]));
			w5.Position = 3;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox72.Add (this.hbox46);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox72 [this.hbox46]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox72.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox72.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox72 [this.hseparator1]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox72.Gtk.Box+BoxChild
			this.hbox47 = new global::Gtk.HBox ();
			this.hbox47.Name = "hbox47";
			// Container child hbox47.Gtk.Box+BoxChild
			this.managerButton = new global::Gtk.Button ();
			this.managerButton.Name = "managerButton";
			this.managerButton.UseUnderline = true;
			this.managerButton.Label = global::MonoDevelop.Core.GettextCatalog.GetString ("Add-in Manager...");
			this.hbox47.Add (this.managerButton);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox47 [this.managerButton]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox72.Add (this.hbox47);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox72 [this.hbox47]));
			w9.Position = 3;
			w9.Expand = false;
			w9.Fill = false;
			this.Add (this.vbox72);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.lookCheck.Clicked += new global::System.EventHandler (this.OnCheckToggled);
			this.managerButton.Clicked += new global::System.EventHandler (this.OnManageClicked);
		}
	}
}
