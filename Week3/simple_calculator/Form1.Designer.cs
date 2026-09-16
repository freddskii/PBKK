namespace CalculatorApp;

partial class Form1
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblTitle = new Label();
        txtDisplay = new TextBox();
        lblOperation = new Label();
        pnlDisplay = new Panel();
        btn7 = new Button();
        btn8 = new Button();
        btn9 = new Button();
        btnDivide = new Button();
        btn4 = new Button();
        btn5 = new Button();
        btn6 = new Button();
        btnMultiply = new Button();
        btn1 = new Button();
        btn2 = new Button();
        btn3 = new Button();
        btnMinus = new Button();
        btn0 = new Button();
        btnDecimal = new Button();
        btnClear = new Button();
        btnPlus = new Button();
        btnEquals = new Button();
        tableLayoutPanel = new TableLayoutPanel();
        tableLayoutPanel.SuspendLayout();
        pnlDisplay.SuspendLayout();
        SuspendLayout();

        // ============================================================
        // COLOR PALETTE - Modern Dark Theme (Slate + Indigo accents)
        // ============================================================
        Color bgDark        = Color.FromArgb(15, 23, 42);       // Slate 900
        Color bgCard         = Color.FromArgb(30, 41, 59);       // Slate 800
        Color bgCardLight    = Color.FromArgb(51, 65, 85);       // Slate 700
        Color displayBg      = Color.FromArgb(24, 33, 50);       // Custom dark
        Color textPrimary    = Color.FromArgb(248, 250, 252);    // Slate 50
        Color textSecondary  = Color.FromArgb(148, 163, 184);    // Slate 400
        Color numBtnBg       = Color.FromArgb(51, 65, 85);       // Slate 700
        Color numBtnHover    = Color.FromArgb(71, 85, 105);      // Slate 600
        Color numBtnFg       = Color.FromArgb(241, 245, 249);    // Slate 100
        Color opBtnBg        = Color.FromArgb(49, 46, 129);      // Indigo 900
        Color opBtnFg        = Color.FromArgb(165, 180, 252);    // Indigo 300
        Color equalsBg       = Color.FromArgb(79, 70, 229);      // Indigo 600
        Color equalsFg       = Color.White;
        Color clearBg        = Color.FromArgb(127, 29, 29);      // Red 900
        Color clearFg        = Color.FromArgb(252, 165, 165);    // Red 300
        Color accentLine     = Color.FromArgb(99, 102, 241);     // Indigo 500

        // ============================================================
        // FONTS
        // ============================================================
        Font titleFont   = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        Font displayFont = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
        Font opLblFont   = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        Font numFont     = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
        Font opFont      = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        Font equalsFont  = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);

        // ============================================================
        // pnlDisplay - Display card panel with rounded feel
        // ============================================================
        pnlDisplay.BackColor = displayBg;
        pnlDisplay.Location = new Point(16, 12);
        pnlDisplay.Name = "pnlDisplay";
        pnlDisplay.Padding = new Padding(16, 8, 16, 12);
        pnlDisplay.Size = new Size(338, 130);
        pnlDisplay.TabIndex = 10;
        pnlDisplay.Controls.Add(txtDisplay);
        pnlDisplay.Controls.Add(lblOperation);
        pnlDisplay.Controls.Add(lblTitle);

        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = titleFont;
        lblTitle.ForeColor = accentLine;
        lblTitle.Location = new Point(16, 10);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(100, 25);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Calculator";

        //
        // lblOperation - shows current operation context
        //
        lblOperation.AutoSize = true;
        lblOperation.Font = opLblFont;
        lblOperation.ForeColor = textSecondary;
        lblOperation.Location = new Point(16, 42);
        lblOperation.Name = "lblOperation";
        lblOperation.Size = new Size(10, 20);
        lblOperation.TabIndex = 3;
        lblOperation.Text = "";
        lblOperation.TextAlign = ContentAlignment.MiddleLeft;

        // 
        // txtDisplay
        // 
        txtDisplay.BackColor = displayBg;
        txtDisplay.BorderStyle = BorderStyle.None;
        txtDisplay.Font = displayFont;
        txtDisplay.ForeColor = textPrimary;
        txtDisplay.Location = new Point(10, 65);
        txtDisplay.Margin = new Padding(0);
        txtDisplay.Name = "txtDisplay";
        txtDisplay.ReadOnly = true;
        txtDisplay.Size = new Size(316, 57);
        txtDisplay.TabIndex = 1;
        txtDisplay.Text = "0";
        txtDisplay.TextAlign = HorizontalAlignment.Right;

        // ============================================================
        // tableLayoutPanel - Button grid
        // ============================================================
        tableLayoutPanel.ColumnCount = 4;
        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel.RowCount = 5;
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel.Controls.Add(btn7, 0, 0);
        tableLayoutPanel.Controls.Add(btn8, 1, 0);
        tableLayoutPanel.Controls.Add(btn9, 2, 0);
        tableLayoutPanel.Controls.Add(btnDivide, 3, 0);
        tableLayoutPanel.Controls.Add(btn4, 0, 1);
        tableLayoutPanel.Controls.Add(btn5, 1, 1);
        tableLayoutPanel.Controls.Add(btn6, 2, 1);
        tableLayoutPanel.Controls.Add(btnMultiply, 3, 1);
        tableLayoutPanel.Controls.Add(btn1, 0, 2);
        tableLayoutPanel.Controls.Add(btn2, 1, 2);
        tableLayoutPanel.Controls.Add(btn3, 2, 2);
        tableLayoutPanel.Controls.Add(btnMinus, 3, 2);
        tableLayoutPanel.Controls.Add(btnClear, 0, 3);
        tableLayoutPanel.Controls.Add(btn0, 1, 3);
        tableLayoutPanel.Controls.Add(btnDecimal, 2, 3);
        tableLayoutPanel.Controls.Add(btnPlus, 3, 3);
        tableLayoutPanel.Controls.Add(btnEquals, 0, 4);
        tableLayoutPanel.SetColumnSpan(btnEquals, 4);
        tableLayoutPanel.Location = new Point(16, 152);
        tableLayoutPanel.Name = "tableLayoutPanel";
        tableLayoutPanel.Size = new Size(338, 380);
        tableLayoutPanel.TabIndex = 2;
        tableLayoutPanel.BackColor = bgDark;
        tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

        // ============================================================
        // NUMBER BUTTONS (0-9)
        // ============================================================

        // btn7
        btn7.Dock = DockStyle.Fill;
        btn7.FlatStyle = FlatStyle.Flat;
        btn7.FlatAppearance.BorderSize = 0;
        btn7.FlatAppearance.MouseOverBackColor = numBtnHover;
        btn7.BackColor = numBtnBg;
        btn7.ForeColor = numBtnFg;
        btn7.Font = numFont;
        btn7.Margin = new Padding(3);
        btn7.Name = "btn7";
        btn7.Text = "7";
        btn7.Cursor = Cursors.Hand;
        btn7.UseVisualStyleBackColor = false;
        btn7.Click += NumberButton_Click;

        // btn8
        btn8.Dock = DockStyle.Fill;
        btn8.FlatStyle = FlatStyle.Flat;
        btn8.FlatAppearance.BorderSize = 0;
        btn8.FlatAppearance.MouseOverBackColor = numBtnHover;
        btn8.BackColor = numBtnBg;
        btn8.ForeColor = numBtnFg;
        btn8.Font = numFont;
        btn8.Margin = new Padding(3);
        btn8.Name = "btn8";
        btn8.Text = "8";
        btn8.Cursor = Cursors.Hand;
        btn8.UseVisualStyleBackColor = false;
        btn8.Click += NumberButton_Click;

        // btn9
        btn9.Dock = DockStyle.Fill;
        btn9.FlatStyle = FlatStyle.Flat;
        btn9.FlatAppearance.BorderSize = 0;
        btn9.FlatAppearance.MouseOverBackColor = numBtnHover;
        btn9.BackColor = numBtnBg;
        btn9.ForeColor = numBtnFg;
        btn9.Font = numFont;
        btn9.Margin = new Padding(3);
        btn9.Name = "btn9";
        btn9.Text = "9";
        btn9.Cursor = Cursors.Hand;
        btn9.UseVisualStyleBackColor = false;
        btn9.Click += NumberButton_Click;

        // btn4
        btn4.Dock = DockStyle.Fill;
        btn4.FlatStyle = FlatStyle.Flat;
        btn4.FlatAppearance.BorderSize = 0;
        btn4.FlatAppearance.MouseOverBackColor = numBtnHover;
        btn4.BackColor = numBtnBg;
        btn4.ForeColor = numBtnFg;
        btn4.Font = numFont;
        btn4.Margin = new Padding(3);
        btn4.Name = "btn4";
        btn4.Text = "4";
        btn4.Cursor = Cursors.Hand;
        btn4.UseVisualStyleBackColor = false;
        btn4.Click += NumberButton_Click;

        // btn5
        btn5.Dock = DockStyle.Fill;
        btn5.FlatStyle = FlatStyle.Flat;
        btn5.FlatAppearance.BorderSize = 0;
        btn5.FlatAppearance.MouseOverBackColor = numBtnHover;
        btn5.BackColor = numBtnBg;
        btn5.ForeColor = numBtnFg;
        btn5.Font = numFont;
        btn5.Margin = new Padding(3);
        btn5.Name = "btn5";
        btn5.Text = "5";
        btn5.Cursor = Cursors.Hand;
        btn5.UseVisualStyleBackColor = false;
        btn5.Click += NumberButton_Click;

        // btn6
        btn6.Dock = DockStyle.Fill;
        btn6.FlatStyle = FlatStyle.Flat;
        btn6.FlatAppearance.BorderSize = 0;
        btn6.FlatAppearance.MouseOverBackColor = numBtnHover;
        btn6.BackColor = numBtnBg;
        btn6.ForeColor = numBtnFg;
        btn6.Font = numFont;
        btn6.Margin = new Padding(3);
        btn6.Name = "btn6";
        btn6.Text = "6";
        btn6.Cursor = Cursors.Hand;
        btn6.UseVisualStyleBackColor = false;
        btn6.Click += NumberButton_Click;

        // btn1
        btn1.Dock = DockStyle.Fill;
        btn1.FlatStyle = FlatStyle.Flat;
        btn1.FlatAppearance.BorderSize = 0;
        btn1.FlatAppearance.MouseOverBackColor = numBtnHover;
        btn1.BackColor = numBtnBg;
        btn1.ForeColor = numBtnFg;
        btn1.Font = numFont;
        btn1.Margin = new Padding(3);
        btn1.Name = "btn1";
        btn1.Text = "1";
        btn1.Cursor = Cursors.Hand;
        btn1.UseVisualStyleBackColor = false;
        btn1.Click += NumberButton_Click;

        // btn2
        btn2.Dock = DockStyle.Fill;
        btn2.FlatStyle = FlatStyle.Flat;
        btn2.FlatAppearance.BorderSize = 0;
        btn2.FlatAppearance.MouseOverBackColor = numBtnHover;
        btn2.BackColor = numBtnBg;
        btn2.ForeColor = numBtnFg;
        btn2.Font = numFont;
        btn2.Margin = new Padding(3);
        btn2.Name = "btn2";
        btn2.Text = "2";
        btn2.Cursor = Cursors.Hand;
        btn2.UseVisualStyleBackColor = false;
        btn2.Click += NumberButton_Click;

        // btn3
        btn3.Dock = DockStyle.Fill;
        btn3.FlatStyle = FlatStyle.Flat;
        btn3.FlatAppearance.BorderSize = 0;
        btn3.FlatAppearance.MouseOverBackColor = numBtnHover;
        btn3.BackColor = numBtnBg;
        btn3.ForeColor = numBtnFg;
        btn3.Font = numFont;
        btn3.Margin = new Padding(3);
        btn3.Name = "btn3";
        btn3.Text = "3";
        btn3.Cursor = Cursors.Hand;
        btn3.UseVisualStyleBackColor = false;
        btn3.Click += NumberButton_Click;

        // btn0
        btn0.Dock = DockStyle.Fill;
        btn0.FlatStyle = FlatStyle.Flat;
        btn0.FlatAppearance.BorderSize = 0;
        btn0.FlatAppearance.MouseOverBackColor = numBtnHover;
        btn0.BackColor = numBtnBg;
        btn0.ForeColor = numBtnFg;
        btn0.Font = numFont;
        btn0.Margin = new Padding(3);
        btn0.Name = "btn0";
        btn0.Text = "0";
        btn0.Cursor = Cursors.Hand;
        btn0.UseVisualStyleBackColor = false;
        btn0.Click += NumberButton_Click;

        // btnDecimal
        btnDecimal.Dock = DockStyle.Fill;
        btnDecimal.FlatStyle = FlatStyle.Flat;
        btnDecimal.FlatAppearance.BorderSize = 0;
        btnDecimal.FlatAppearance.MouseOverBackColor = numBtnHover;
        btnDecimal.BackColor = numBtnBg;
        btnDecimal.ForeColor = numBtnFg;
        btnDecimal.Font = numFont;
        btnDecimal.Margin = new Padding(3);
        btnDecimal.Name = "btnDecimal";
        btnDecimal.Text = ".";
        btnDecimal.Cursor = Cursors.Hand;
        btnDecimal.UseVisualStyleBackColor = false;
        btnDecimal.Click += btnDecimal_Click;

        // ============================================================
        // OPERATOR BUTTONS
        // ============================================================
        // btnDivide
        btnDivide.Dock = DockStyle.Fill;
        btnDivide.FlatStyle = FlatStyle.Flat;
        btnDivide.FlatAppearance.BorderSize = 0;
        btnDivide.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 56, 202);
        btnDivide.BackColor = opBtnBg;
        btnDivide.ForeColor = opBtnFg;
        btnDivide.Font = opFont;
        btnDivide.Margin = new Padding(3);
        btnDivide.Name = "btnDivide";
        btnDivide.Text = "÷";
        btnDivide.Cursor = Cursors.Hand;
        btnDivide.UseVisualStyleBackColor = false;
        btnDivide.Click += OperatorButton_Click;

        // btnMultiply
        btnMultiply.Dock = DockStyle.Fill;
        btnMultiply.FlatStyle = FlatStyle.Flat;
        btnMultiply.FlatAppearance.BorderSize = 0;
        btnMultiply.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 56, 202);
        btnMultiply.BackColor = opBtnBg;
        btnMultiply.ForeColor = opBtnFg;
        btnMultiply.Font = opFont;
        btnMultiply.Margin = new Padding(3);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Text = "×";
        btnMultiply.Cursor = Cursors.Hand;
        btnMultiply.UseVisualStyleBackColor = false;
        btnMultiply.Click += OperatorButton_Click;

        // btnMinus
        btnMinus.Dock = DockStyle.Fill;
        btnMinus.FlatStyle = FlatStyle.Flat;
        btnMinus.FlatAppearance.BorderSize = 0;
        btnMinus.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 56, 202);
        btnMinus.BackColor = opBtnBg;
        btnMinus.ForeColor = opBtnFg;
        btnMinus.Font = opFont;
        btnMinus.Margin = new Padding(3);
        btnMinus.Name = "btnMinus";
        btnMinus.Text = "−";
        btnMinus.Cursor = Cursors.Hand;
        btnMinus.UseVisualStyleBackColor = false;
        btnMinus.Click += OperatorButton_Click;

        // btnPlus
        btnPlus.Dock = DockStyle.Fill;
        btnPlus.FlatStyle = FlatStyle.Flat;
        btnPlus.FlatAppearance.BorderSize = 0;
        btnPlus.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 56, 202);
        btnPlus.BackColor = opBtnBg;
        btnPlus.ForeColor = opBtnFg;
        btnPlus.Font = opFont;
        btnPlus.Margin = new Padding(3);
        btnPlus.Name = "btnPlus";
        btnPlus.Text = "+";
        btnPlus.Cursor = Cursors.Hand;
        btnPlus.UseVisualStyleBackColor = false;
        btnPlus.Click += OperatorButton_Click;

        // ============================================================
        // SPECIAL BUTTONS
        // ============================================================

        // btnClear
        btnClear.Dock = DockStyle.Fill;
        btnClear.FlatStyle = FlatStyle.Flat;
        btnClear.FlatAppearance.BorderSize = 0;
        btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 27, 27);
        btnClear.BackColor = clearBg;
        btnClear.ForeColor = clearFg;
        btnClear.Font = numFont;
        btnClear.Margin = new Padding(3);
        btnClear.Name = "btnClear";
        btnClear.Text = "C";
        btnClear.Cursor = Cursors.Hand;
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;

        // btnEquals
        btnEquals.Dock = DockStyle.Fill;
        btnEquals.FlatStyle = FlatStyle.Flat;
        btnEquals.FlatAppearance.BorderSize = 0;
        btnEquals.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 102, 241);
        btnEquals.BackColor = equalsBg;
        btnEquals.ForeColor = equalsFg;
        btnEquals.Font = equalsFont;
        btnEquals.Margin = new Padding(3);
        btnEquals.Name = "btnEquals";
        btnEquals.Text = "=";
        btnEquals.Cursor = Cursors.Hand;
        btnEquals.UseVisualStyleBackColor = false;
        btnEquals.Click += btnEquals_Click;

        // ============================================================
        // Form1 - Main window
        // ============================================================
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = bgDark;
        ClientSize = new Size(370, 550);
        Controls.Add(tableLayoutPanel);
        Controls.Add(pnlDisplay);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Calculator";
        Padding = new Padding(0);
        pnlDisplay.ResumeLayout(false);
        pnlDisplay.PerformLayout();
        tableLayoutPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlDisplay;
    private Label lblTitle;
    private Label lblOperation;
    private TextBox txtDisplay;
    private TableLayoutPanel tableLayoutPanel;
    private Button btn7;
    private Button btn8;
    private Button btn9;
    private Button btnDivide;
    private Button btn4;
    private Button btn5;
    private Button btn6;
    private Button btnMultiply;
    private Button btn1;
    private Button btn2;
    private Button btn3;
    private Button btnMinus;
    private Button btn0;
    private Button btnDecimal;
    private Button btnClear;
    private Button btnPlus;
    private Button btnEquals;
}