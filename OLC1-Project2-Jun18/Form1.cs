using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OLC1_Project2_Jun18
{
    public partial class Form1 : Form
    {
        private static string PAGE_NAME = "page";
        private int COUNTER = 0;
        private static string FILENAME_DEFAULT = "Nuevo";

        public Form1()
        {
            InitializeComponent();
        }

        /*******************************************************
         * ****************************************************
         * CONTROL DE AREA DE CÓDIGO
         * ****************************************************
         ******************************************************/
        private void createSourceArea(TabPage page, string text)
        {
            RichTextBox rowCount = new RichTextBox()
            {
                Name = "row" + COUNTER,
                Dock = DockStyle.Left,
                Width = (page.Width * 10) / 100,
                Parent = page,
                ForeColor = Color.MediumPurple,
                Font = new Font("Consolas", 12, FontStyle.Regular),
                WordWrap = false,
            };

            RichTextBox box = new RichTextBox()
            {
                Name = "box" + COUNTER,
                Text = text,
                Dock = DockStyle.Right,
                Width = (page.Width * 90) / 100,
                Parent = page,
                AcceptsTab = true,
                ForeColor = Color.MidnightBlue,
                Font = new Font("Consolas", 12, FontStyle.Regular),
                WordWrap = true
            };

            box.TextChanged += Box_TextChanged;
            box.KeyUp += Box_KeyUp;
            box.Click += Box_Click;
            box.VScroll += Box_VScroll;

            page.Controls.Add(rowCount);
            page.Controls.Add(box);
        }

        private void createTabPage(string path, string filename, string text)
        {
            TabPage page = new TabPage()
            {
                Name = PAGE_NAME + COUNTER,
                Text = filename,
                Tag = path
            };

            tabControl.TabPages.Add(page);
            createSourceArea(page, text);
            tabControl.SelectedTab = page;
            COUNTER++;
        }

        private void Box_VScroll(object sender, EventArgs e)
        {
            RichTextBox box = (RichTextBox)sender;
            Control parent = box.Parent;
            RichTextBox row = (RichTextBox)parent.Controls[0];
        }

        private void Box_Click(object sender, EventArgs e) 
            => getPositionCursor((RichTextBox)sender);

        private void Box_KeyUp(object sender, KeyEventArgs e) 
            => getPositionCursor((RichTextBox)sender);

        private void Box_TextChanged(object sender, EventArgs e)
        {
            getPositionCursor((RichTextBox)sender);
        }

        private void getPositionCursor(RichTextBox box)
        {
            int selection_start, first_index, current_line;
            selection_start = box.SelectionStart;
            current_line = box.GetLineFromCharIndex(selection_start);
            first_index = box.GetFirstCharIndexOfCurrentLine();
            int x = selection_start - first_index;

            Console.WriteLine($"x: {x}, y: {current_line}");
        }

        /*******************************************************
         * ****************************************************
         * ABRIR Y CREAR ARCHIVO
         * ****************************************************
         ******************************************************/
        private void abrirMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Seleccionar archivo",
                Filter = "Source CRL | *.crl",
                CheckFileExists = true,
                CheckPathExists = true
            };
            ofd.ShowDialog();

            try
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                createTabPage(ofd.FileName, ofd.SafeFileName, sr.ReadToEnd());
                sr.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void nuevoMenuItem_Click(object sender, EventArgs e) 
            => createTabPage("", FILENAME_DEFAULT, "");

        /*******************************************************
         * ****************************************************
         * GUARDAR ARCHIVO
         * ****************************************************
         ******************************************************/
        private void guardarMenuItem_Click(object sender, EventArgs e)
        {
            TabPage currentPage = tabControl.SelectedTab;
            RichTextBox box = (RichTextBox)currentPage.Controls[0];
            string path = currentPage.Tag.ToString();

            if (path.Length < 1)
            {
                // GUARDAR COMO
                saveAs(box, currentPage);
            }
            else
            {
                // GUARDAR
                try
                {
                    StreamWriter write = new StreamWriter(path);
                    write.Write(box.Text);
                    write.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void guardarTodoMenuItem_Click(object sender, EventArgs e)
        {
            TabPage currentPage = tabControl.SelectedTab;
            RichTextBox box = (RichTextBox)currentPage.Controls[0];
            // GUARDAR COMO
            saveAs(box, currentPage);
        }

        private void saveAs(RichTextBox box, TabPage currentPage)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Title = "Seleccionar destino",
                Filter = "Source CRL | *.crl"
            };
            sfd.ShowDialog();

            try
            {
                StreamWriter writer = new StreamWriter(sfd.FileName);
                writer.Write(box.Text);

                currentPage.Tag = sfd.FileName;
                currentPage.Text = sfd.FileName;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        /*******************************************************
        * ****************************************************
        * CERRAR UNA O VARIOS ARCHIVOS
        * ****************************************************
        ******************************************************/
        private void cerrarMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl.TabPages.Remove(tabControl.SelectedTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cerrarTodoMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl.TabPages.Clear();
                COUNTER = 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*******************************************************
         * ****************************************************
         * COMPILAR
         * GENERAR ARBOLES AST Y SINTACTICO ABSTRACTO
         * REFACTORIZAR CODIGO
         * EJECUTAR CODIGO
         * ****************************************************
         ******************************************************/
        private void compilarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void astMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sintacticoAbstractoMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reformatearMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ejecutarMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
