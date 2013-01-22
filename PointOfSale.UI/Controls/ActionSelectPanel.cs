using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PointOfSale.UI.Models;

namespace PointOfSale.UI.Controls
{
    public partial class ActionSelectPanel : UserControl
    {
        public ActionSelectPanel()
        {
            InitializeComponent();

            Actions = new ObservableCollection<InputAction>();
            Actions.CollectionChanged += ActionsCollectionChanged;

            ButtonColour = SystemColors.Control;
        }

        #region Actions

        public ObservableCollection<InputAction> Actions { get; private set; }

        void ActionsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            ResetPage();

            ReflowActions();
        }

        #endregion

        #region Layout

        private int columns = 1;
        private int rows = 4;

        [Category("Layout"), Description("Number of columns")]
        public int Columns { get { return columns; } set { SetColumns(value); } }
        [Category("Layout"), Description("Number of rows")]
        public int Rows { get { return rows; } set { SetRows(value); } }

        private void SetColumns(int value)
        {
            if (value < 1) throw new ArgumentException("Number of columns must be >= 1", "value");

            columns = value;

            ReflowLayout();
        }
        private void SetRows(int value)
        {
            if (value < 1) throw new ArgumentException("Number of rows must be >= 1", "value");

            rows = value;

            ReflowLayout();
        }

        #endregion

        #region Paging

        private int page;

        private Button nextButton;
        private Button prevButton;

        private void ResetPage()
        {
            page = 0;
        }
        private void ResetPageControls()
        {
            if (prevButton != null)
            {
                Layout.Controls.Remove(prevButton);

                prevButton.Dispose();
                prevButton = null;
            }
            if (nextButton != null)
            {
                Layout.Controls.Remove(nextButton);

                nextButton.Dispose();
                nextButton = null;
            }
        }
        private bool IsPagingNeeded()
        {
            return rows * columns < Actions.Count;
        }
        private int GetMaxPages()
        {
            if (!IsPagingNeeded()) return 1;

            var itemsPerPage = GetItemsPerPage();

            return (int)Math.Ceiling(Actions.Count / (double)itemsPerPage);
        }
        private int GetItemsPerPage()
        {
            var itemsPerPage = rows * columns;

            if (rows == 1 || columns == 1)
            {
                itemsPerPage -= 1;
            }
            else
            {
                itemsPerPage -= 2;
            }

            return itemsPerPage;
        }

        private void AddNextButton(int col, int row)
        {
            nextButton = GetStandardButton();

            if (rows == 1 || columns == 1)
            {
                nextButton.Text = "More";
            }
            else
            {
                nextButton.Text = "Next";
            }

            nextButton.Click += (sender, args) => NextPage();

            Layout.Controls.Add(nextButton, col, row);
        }
        private void AddPrevButton(int col, int row)
        {
            prevButton = GetStandardButton();
            prevButton.Text = "Previous";

            prevButton.Click += (sender, args) => PrevPage();

            Layout.Controls.Add(prevButton, col, row);
        }

        private void NextPage()
        {
            page++;

            if (page == GetMaxPages())
            {
                page = 0;
            }

            ReflowActions();
        }
        private void PrevPage()
        {
            page--;

            if (page < 0)
            {
                page = 0;
            }

            ReflowActions();
        }

        private InputAction GetAction(int col, int row)
        {
            var itemsPerPage = GetItemsPerPage();
            var index = itemsPerPage * page;

            index += (row * columns) + col;

            return index < Actions.Count ? Actions[index] : null;
        }

        #endregion

        #region Rendering

        [Category("Appearance"), Description("Colour of the buttons")]
        public Color ButtonColour { get; set; }

        private List<Button> actionInputs;

        private void AddActionButton(int col, int row)
        {
            var action = GetAction(col, row);
            if (action == null) return;

            var input = GetStandardButton();
            input.Text = action.Name;

            input.Click += (sender, args) => action.Invoke();

            Layout.Controls.Add(input, col, row);
            actionInputs.Add(input);
        }

        private void ResetLayout()
        {
            // remove controls
            ResetControls();

            // reset layout
            Layout.ColumnStyles.Clear();
            Layout.RowStyles.Clear();

            Layout.ColumnCount = 1;
            Layout.RowCount = 1;
        }
        private void ReflowLayout()
        {
            ResetLayout();

            // setup layout
            Layout.ColumnCount = columns;
            Layout.RowCount = rows;

            var colPercent = 100f / columns;
            var rowPercent = 100f / rows;

            for (var col = 0; col < columns; col++)
            {
                for (var row = 0; row < rows; row++)
                {
                    Layout.RowStyles.Add(new RowStyle(SizeType.Percent, rowPercent));
                }

                Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, colPercent));
            }

            // setup controls
            ReflowActions();
        }

        private void ResetControls()
        {
            if (actionInputs != null)
            {
                foreach (var input in actionInputs)
                {
                    Layout.Controls.Remove(input);

                    input.Dispose();
                }

                actionInputs.Clear();
            }
            else
            {
                actionInputs = new List<Button>();
            }

            ResetPageControls();
        }
        private void ReflowActions()
        {
            ResetControls();

            var needsPaging = IsPagingNeeded();

            var isOnlyRow = rows == 1;
            for (var col = 0; col < columns; col++)
            {
                var isLastColumn = columns == (col + 1);
                var isSecondLastColumn = columns == (col + 2);

                for (var row = 0; row < rows; row++)
                {
                    var isLastRow = rows == (row + 1);

                    if ((needsPaging && isLastColumn && isLastRow))
                    {
                        AddNextButton(col, row);
                    }
                    else if (needsPaging && isSecondLastColumn && isLastRow && !isOnlyRow)
                    {
                        AddPrevButton(col, row);
                    }
                    else
                    {
                        AddActionButton(col, row);
                    }
                }
            }
        }

        private Button GetStandardButton()
        {
            return new Button
            {
                BackColor = ButtonColour,
                Dock = DockStyle.Fill
            };
        }

        #endregion
    }
}
