using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraBars.Docking;

namespace NavBarExample {
    public partial class MyNavBarControl : DevExpress.XtraEditors.XtraUserControl {
        const int _margin = 3;
        ImageList images;
        int imageIndexer = 0;
        public MyNavBarControl() {
            InitializeComponent();
            this.ControlAdded += new ControlEventHandler(MyNavBarControl_ControlAdded);
            this.ControlRemoved += new ControlEventHandler(MyNavBarControl_ControlRemoved);
            this.Resize += new EventHandler(MyNavBarControl_Resize);
            images = new ImageList();
            images.Images.Add(Properties.Resources._1);
            images.Images.Add(Properties.Resources._2);
            images.Images.Add(Properties.Resources._3);
            images.Images.Add(Properties.Resources._4);
            images.Images.Add(Properties.Resources._5);
            images.Images.Add(Properties.Resources._6);
            images.Images.Add(Properties.Resources._7);
            images.Images.Add(Properties.Resources._8);
            images.Images.Add(Properties.Resources._9);
            images.Images.Add(Properties.Resources._10);
        }

        void MyNavBarControl_Resize(object sender, EventArgs e) {
            foreach(NavBarControl item in Controls) {
                item.Height = this.Height - (_margin * 2);
            }
        }

        void MyNavBarControl_ControlRemoved(object sender, ControlEventArgs e) {
            if(Controls.Count == 0) return;
            CalculateBestFit();
        }

        void MyNavBarControl_ControlAdded(object sender, ControlEventArgs e) {
            CalculateBestFit();
        }

        public void CalculateBestFit() {
            List<Point> locations = new List<Point>();
            int shift = _margin;
            for(int i = 0; i < Controls.Count; i++) {
                Point newLocation = new Point();
                newLocation.X = (i * _margin) + shift;
                shift += Controls[i].Width;
                newLocation.Y = _margin;
                locations.Add(newLocation);
            }
            for(int i = 0; i < Controls.Count; i++) {
                Controls[i].Location = locations[i];
            }
            this.Size = new Size((Controls.Count * _margin) + shift, Controls[0].Height + _margin * 2);
            OnResize(new EventArgs());
        }

        public void AddBar(NavBarControl navBar) {
            navBar.SmallImages = images;
            this.Controls.Add(navBar);
        }

        public void DeleteBar(int index) {
            if(Controls.Count < index) return;
            Controls.RemoveAt(index);
        }

        public void AddGroup(int barIndex, string groupName) {
            if(!IsCorrectIndex(barIndex)) return;
            NavBarGroup group = new NavBarGroup(groupName);
            group.Name = groupName;
            (Controls[barIndex] as NavBarControl).Groups.Add(group);
        }

        public void DeleteGroup(int barIndex, string groupName) {
            if(!IsCorrectIndex(barIndex)) return;
            NavBarControl bar = GetNavBarByIndex(barIndex);
            NavBarGroup group = GetNavBarGroupByName(bar, groupName);
            if(group != null) (Controls[barIndex] as NavBarControl).Groups.Remove(group);
        }

        public void ArrGroupItem(int barIndex, string groupName, string itemName) {
            if(!IsCorrectIndex(barIndex)) return;
            NavBarControl bar = GetNavBarByIndex(barIndex);
            NavBarGroup group = GetNavBarGroupByName(bar, groupName);
            if(group == null) return;
            if(!group.Expanded) group.Expanded = true;
            NavBarItem item = new NavBarItem(itemName);
            item.SmallImageIndex = (imageIndexer++) % (images.Images.Count - 1);
            group.ItemLinks.Add(item);
        }

        public void DeleteGroupItem(int barIndex, string groupName, string itemName) {
            if(!IsCorrectIndex(barIndex)) return;
            NavBarControl bar = GetNavBarByIndex(barIndex);
            NavBarGroup group = GetNavBarGroupByName(bar, groupName);
            if(group == null) return;
            NavBarItemLink item = GetItemLinkByName(group, itemName);
            if(item == null) return;
            group.ItemLinks.Remove(item);
        }

        NavBarItemLink GetItemLinkByName(NavBarGroup group, string itemName) {
            foreach(NavBarItemLink item in group.ItemLinks) {
                if(item.Caption == itemName) {
                    return item;
                }
            }
            return null;
        }

        bool IsCorrectIndex(int index) {
            return index > -1 && index < Controls.Count;
        }

        NavBarGroup GetNavBarGroupByName(NavBarControl bar, string groupName) {
            return bar.Groups[groupName];
        }

        NavBarControl GetNavBarByIndex(int index) {
            return Controls[index] as NavBarControl;
        }
    }
}
