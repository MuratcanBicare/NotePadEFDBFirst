using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunlukEFDBFirst
{
    public partial class Form1 : Form
    {
        OdevNotlarDbEntities db = new OdevNotlarDbEntities();
        public Form1()
        {
            InitializeComponent();
            NotlariListele();
            
        }

       

        private void NotlariListele()
        {
            string search = txtAra.Text.Trim();
            if (search == "")
            {
            lstNotlar.DataSource = db.Notlar.ToList();
            }
            else
            {
                lstNotlar.DataSource = db.Notlar.Where(x => x.Baslik.Contains(search) || x.Icerik.Contains(search)).ToList();
            }
            txtBaslik.Clear();
            txtIcerik.Clear();
            
        }

        private void lstNotlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            IcerigiListele();
        }

        private void IcerigiListele()
        {
            if (lstNotlar.SelectedItems.Count == 0)
                return;

            Note note = (Note)lstNotlar.SelectedItem;
            txtBaslik.Text = note.Baslik;
            txtIcerik.Text = note.Icerik;
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            string baslik = txtBaslik.Text.Trim();
            string icerik = txtBaslik.Text.Trim();

            if(baslik == "" || icerik == "") 
            {
                note.Baslik = "Yeni yazı";
                note.Icerik = "Yeni not";
            }
            else
            {
                note.Baslik = baslik;
                note.Icerik = icerik;
            }
            db.Notlar.Add(note);
            db.SaveChanges();
            txtBaslik.Clear();
            txtIcerik.Clear();
            NotlariListele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {


            Note note = (Note)lstNotlar.SelectedItem;
            string baslik = txtBaslik.Text.Trim();
            string icerik = txtIcerik.Text.Trim();

            if (note == null)
                return;
            
            if (note.Baslik != baslik || note.Icerik != icerik)
            {

            note.Baslik = baslik;
            note.Icerik = icerik;
            }
            db.SaveChanges();
            NotlariListele();
            
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string search = txtAra.Text.Trim();

            if (search == "")
                return;

            lstNotlar.DataSource = db.Notlar.Where(x => x.Baslik.Contains(search) || x.Icerik.Contains(search)).ToList();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            NotlariListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliIndeks = lstNotlar.SelectedIndex;
            if (lstNotlar.SelectedItems.Count == 0)
                return;

            Note selectedNote = (Note)lstNotlar.SelectedItem;
            db.Notlar.Remove(selectedNote);
            db.SaveChanges();
            NotlariListele();

            if (lstNotlar.Items.Count > 0)
            {
                lstNotlar.ClearSelected();
                int secilecekIndeks = seciliIndeks >= lstNotlar.Items.Count ? lstNotlar.Items.Count - 1 : seciliIndeks;
                lstNotlar.SelectedIndex = secilecekIndeks;
            }
            txtBaslik.Clear();
            txtIcerik.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (lstNotlar.SelectedItems.Count == 0)
                return;

            Note n = (Note)lstNotlar.SelectedItem;
            if (txtIcerik.Text != n.Icerik || txtBaslik.Text != n.Baslik)
            {
                DialogResult dr = MessageBox.Show("İçerikte değişiklikler algılandı ve kaydedilmedi kaydedip çıkılsın mı ?", "Programdan Çıkılıyor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                switch (dr)
                {

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        NotlariKaydet();
                        break;
                    case DialogResult.No:
                        break;

                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Programdan çıkılsın mı ?", "Programdan Çıkılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                switch (dr)
                {

                    case DialogResult.Yes:
                        NotlariListele();
                        break;
                    case DialogResult.No:
                        e.Cancel = true;
                        break;

                }
            }
        }

        private void NotlariKaydet() 
        {
            Note note = (Note)lstNotlar.SelectedItem;
            string baslik = txtBaslik.Text.Trim();
            string icerik = txtIcerik.Text.Trim();

            note.Baslik = baslik;
            note.Icerik = icerik;

            db.SaveChanges();
        }

        private void txtBaslik_TextChanged(object sender, EventArgs e)
        {
            Note seciliNot = (Note)lstNotlar.SelectedItem;

            if (lstNotlar.SelectedItems.Count == 0)
                return;

            if (seciliNot.Baslik != txtBaslik.Text)
            {
                Text = "Günlük EF DbFirst(*)";
            }
            else
            {
                Text = "Günlük EF DbFirst";
            }
        }

        private void txtIcerik_TextChanged(object sender, EventArgs e)
        {
            Note seciliNot = (Note)lstNotlar.SelectedItem;

            if (lstNotlar.SelectedItems.Count == 0)
                return;

            if (seciliNot.Icerik != txtIcerik.Text)
            {
                Text = "Günlük EF DbFirst(*)";
            }
            else
            {
                Text = "Günlük EF DbFirst";
            }
        }
    }
}
