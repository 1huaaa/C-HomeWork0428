using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FarmerGame   
{
    public partial class Form1 : Form
    {
        List<string> leftBank = new List<string>();
        List<string> rightBank = new List<string>();
        Stack<(List<string> left, List<string> right)> history
            = new Stack<(List<string>, List<string>)>();

        public Form1()
        {
            InitializeComponent();
            InitGame();

        }


        private void InitGame()
        {
            leftBank = new List<string> { "農夫", "狼", "羊", "菜" };
            rightBank = new List<string>();
            history = new Stack<(List<string>, List<string>)>();
            RefreshListBoxes();
        }

        private void RefreshListBoxes()
        {
            listBoxLeft.Items.Clear();
            listBoxRight.Items.Clear();

            foreach (var item in leftBank) listBoxLeft.Items.Add(item);
            foreach (var item in rightBank) listBoxRight.Items.Add(item);
        }

        private void Moveitem(ListBox fromBox, List<string> fromBank, List<string> toBank)
        {

            List<string> selected = fromBox.SelectedItems
                                           .Cast<string>()
                                           .ToList();

            if (!selected.Contains("農夫"))
            {
                MessageBox.Show("農夫必須在船上才能過河！");
                return;
            }

            if (selected.Count > 2)
            {
                MessageBox.Show("船太小了！最多只能帶一樣東西。");
                return;
            }

            history.Push((new List<string>(fromBank),
                          new List<string>(toBank)));

            foreach (string item in selected)
            {
                fromBank.Remove(item);
                toBank.Add(item);
            }

            RefreshListBoxes();
            CheckGameState();
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            Moveitem(listBoxLeft, leftBank, rightBank);
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            Moveitem(listBoxRight, rightBank, leftBank);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (history.Count == 0)
            {
                MessageBox.Show("沒有可以返回的步驟！");
                return;
            }

            var snapshot = history.Pop();
            leftBank = snapshot.left;
            rightBank = snapshot.right;
            RefreshListBoxes();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitGame();
        }

        private bool IsDangerous(List<string> bank)
        {
            if (bank.Contains("農夫")) return false;

            return (bank.Contains("狼") && bank.Contains("羊"))
                || (bank.Contains("羊") && bank.Contains("菜"));
        }

        private bool IsGameOver()
        {
            return IsDangerous(leftBank) || IsDangerous(rightBank);
        }

        private void CheckGameState()
        {
            if (IsGameOver())
            {
                MessageBox.Show("遊戲結束！有人被吃掉了！按確定重新開始。");
                InitGame();
                return;
            }

            if (leftBank.Count == 0)
            {
                MessageBox.Show("恭喜過關！");
                InitGame();
            }
        }

        private void listBoxRight_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}