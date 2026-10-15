using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        ApplyTraditionalChineseAndFont();
    }

    private void ApplyTraditionalChineseAndFont()
    {
        // 全域字型（18pt）
        var targetFont = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular);

        // 在此填入需要翻譯的字串對映（原文 -> 繁體中文）
        var translations = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            // 範例：補齊您介面上的字串
            { "Name", "姓名" },
            { "Birth Date", "出生日期" },
            { "Enter your name:", "請輸入姓名：" },
            { "Submit", "送出" },
            { "Cancel", "取消" },
            { "Calculate", "計算" },
            { "Result:", "結果：" }
            // 若需要更多，請在此加入對應
        };

        // 處理表單及其所有子控制項
        foreach (Control c in this.Controls)
        {
            ApplyToControlRecursive(c, targetFont, translations);
        }

        // 若需更好的自動排列，建議使用 FlowLayoutPanel 或 TableLayoutPanel
    }

    private void ApplyToControlRecursive(Control ctrl, Font font, Dictionary<string, string> translations)
    {
        if (ctrl == null) return;

        // 設定字型
        ctrl.Font = font;

        // 翻譯 Text（如果字典中有對應）
        if (!string.IsNullOrEmpty(ctrl.Text) && translations.TryGetValue(ctrl.Text.Trim(), out string zh))
        {
            ctrl.Text = zh;
        }

        // 視控制項類型做大小與排列調整
        if (ctrl is Label lbl)
        {
            lbl.AutoSize = true;
            lbl.Margin = new Padding(8);
        }
        else if (ctrl is Button btn)
        {
            // 根據文字量測所需大小並加上內外距
            var textSize = TextRenderer.MeasureText(btn.Text, font);
            btn.Size = new Size(Math.Max(btn.Size.Width, textSize.Width + 28), Math.Max(btn.Size.Height, textSize.Height + 12));
            btn.Margin = new Padding(8);
        }
        else if (ctrl is TextBox tb)
        {
            tb.Margin = new Padding(8);
            tb.Width = Math.Max(tb.Width, 240); // 保證有足夠寬度以顯示 18pt 文字
        }
        else if (ctrl is DateTimePicker dp)
        {
            dp.Margin = new Padding(8);
            dp.Width = Math.Max(dp.Width, 240);
        }
        else if (ctrl is ComboBox cb)
        {
            cb.Margin = new Padding(8);
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Width = Math.Max(cb.Width, 240);
        }
        else
        {
            // 一般控制項也加上間隔
            ctrl.Margin = new Padding(6);
        }

        // 遞迴處理子控制項（例如 Panel、GroupBox）
        foreach (Control child in ctrl.Controls)
        {
            ApplyToControlRecursive(child, font, translations);
        }
    }
}