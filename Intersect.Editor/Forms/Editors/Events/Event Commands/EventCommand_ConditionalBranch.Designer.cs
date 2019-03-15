﻿using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommandConditionalBranch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventCommandConditionalBranch));
            this.grpConditional = new DarkUI.Controls.DarkGroupBox();
            this.grpEquippedItem = new DarkUI.Controls.DarkGroupBox();
            this.cmbEquippedItem = new DarkUI.Controls.DarkComboBox();
            this.lblEquippedItem = new System.Windows.Forms.Label();
            this.chkNegated = new DarkUI.Controls.DarkCheckBox();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.cmbConditionType = new DarkUI.Controls.DarkComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.grpHasItem = new DarkUI.Controls.DarkGroupBox();
            this.nudItemAmount = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbItem = new DarkUI.Controls.DarkComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblItemQuantity = new System.Windows.Forms.Label();
            this.grpSwitch = new DarkUI.Controls.DarkGroupBox();
            this.cmbSwitchVal = new DarkUI.Controls.DarkComboBox();
            this.lblSwitchIs = new System.Windows.Forms.Label();
            this.cmbSwitch = new DarkUI.Controls.DarkComboBox();
            this.lblSwitch = new System.Windows.Forms.Label();
            this.grpPlayerVariable = new DarkUI.Controls.DarkGroupBox();
            this.nudVariableValue = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbCompareGlobalVar = new DarkUI.Controls.DarkComboBox();
            this.cmbComparePlayerVar = new DarkUI.Controls.DarkComboBox();
            this.rdoVarCompareGlobalVar = new DarkUI.Controls.DarkRadioButton();
            this.rdoVarComparePlayerVar = new DarkUI.Controls.DarkRadioButton();
            this.rdoVarCompareStaticValue = new DarkUI.Controls.DarkRadioButton();
            this.cmbVariableMod = new DarkUI.Controls.DarkComboBox();
            this.lblComparator = new System.Windows.Forms.Label();
            this.cmbVariable = new DarkUI.Controls.DarkComboBox();
            this.lblVariable = new System.Windows.Forms.Label();
            this.grpQuestCompleted = new DarkUI.Controls.DarkGroupBox();
            this.lblQuestCompleted = new System.Windows.Forms.Label();
            this.cmbCompletedQuest = new DarkUI.Controls.DarkComboBox();
            this.grpQuestInProgress = new DarkUI.Controls.DarkGroupBox();
            this.lblQuestTask = new System.Windows.Forms.Label();
            this.cmbQuestTask = new DarkUI.Controls.DarkComboBox();
            this.cmbTaskModifier = new DarkUI.Controls.DarkComboBox();
            this.lblQuestIs = new System.Windows.Forms.Label();
            this.lblQuestProgress = new System.Windows.Forms.Label();
            this.cmbQuestInProgress = new DarkUI.Controls.DarkComboBox();
            this.grpStartQuest = new DarkUI.Controls.DarkGroupBox();
            this.lblStartQuest = new System.Windows.Forms.Label();
            this.cmbStartQuest = new DarkUI.Controls.DarkComboBox();
            this.grpTime = new DarkUI.Controls.DarkGroupBox();
            this.lblEndRange = new System.Windows.Forms.Label();
            this.lblStartRange = new System.Windows.Forms.Label();
            this.cmbTime2 = new DarkUI.Controls.DarkComboBox();
            this.cmbTime1 = new DarkUI.Controls.DarkComboBox();
            this.lblAnd = new System.Windows.Forms.Label();
            this.grpPowerIs = new DarkUI.Controls.DarkGroupBox();
            this.cmbPower = new DarkUI.Controls.DarkComboBox();
            this.lblPower = new System.Windows.Forms.Label();
            this.grpSelfSwitch = new DarkUI.Controls.DarkGroupBox();
            this.cmbSelfSwitchVal = new DarkUI.Controls.DarkComboBox();
            this.lblSelfSwitchIs = new System.Windows.Forms.Label();
            this.cmbSelfSwitch = new DarkUI.Controls.DarkComboBox();
            this.lblSelfSwitch = new System.Windows.Forms.Label();
            this.grpSpell = new DarkUI.Controls.DarkGroupBox();
            this.cmbSpell = new DarkUI.Controls.DarkComboBox();
            this.lblSpell = new System.Windows.Forms.Label();
            this.grpClass = new DarkUI.Controls.DarkGroupBox();
            this.cmbClass = new DarkUI.Controls.DarkComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.grpLevelStat = new DarkUI.Controls.DarkGroupBox();
            this.chkStatIgnoreBuffs = new DarkUI.Controls.DarkCheckBox();
            this.nudLevelStatValue = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbLevelStat = new DarkUI.Controls.DarkComboBox();
            this.lblLevelOrStat = new System.Windows.Forms.Label();
            this.lblLvlStatValue = new System.Windows.Forms.Label();
            this.cmbLevelComparator = new DarkUI.Controls.DarkComboBox();
            this.lblLevelComparator = new System.Windows.Forms.Label();
            this.grpMapIs = new DarkUI.Controls.DarkGroupBox();
            this.btnSelectMap = new DarkUI.Controls.DarkButton();
            this.grpGender = new DarkUI.Controls.DarkGroupBox();
            this.cmbGender = new DarkUI.Controls.DarkComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.grpConditional.SuspendLayout();
            this.grpEquippedItem.SuspendLayout();
            this.grpHasItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemAmount)).BeginInit();
            this.grpSwitch.SuspendLayout();
            this.grpPlayerVariable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVariableValue)).BeginInit();
            this.grpQuestCompleted.SuspendLayout();
            this.grpQuestInProgress.SuspendLayout();
            this.grpStartQuest.SuspendLayout();
            this.grpTime.SuspendLayout();
            this.grpPowerIs.SuspendLayout();
            this.grpSelfSwitch.SuspendLayout();
            this.grpSpell.SuspendLayout();
            this.grpClass.SuspendLayout();
            this.grpLevelStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelStatValue)).BeginInit();
            this.grpMapIs.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConditional
            // 
            this.grpConditional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpConditional.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpConditional.Controls.Add(this.chkNegated);
            this.grpConditional.Controls.Add(this.btnSave);
            this.grpConditional.Controls.Add(this.cmbConditionType);
            this.grpConditional.Controls.Add(this.lblType);
            this.grpConditional.Controls.Add(this.btnCancel);
            this.grpConditional.Controls.Add(this.grpPlayerVariable);
            this.grpConditional.Controls.Add(this.grpQuestCompleted);
            this.grpConditional.Controls.Add(this.grpQuestInProgress);
            this.grpConditional.Controls.Add(this.grpStartQuest);
            this.grpConditional.Controls.Add(this.grpTime);
            this.grpConditional.Controls.Add(this.grpPowerIs);
            this.grpConditional.Controls.Add(this.grpSelfSwitch);
            this.grpConditional.Controls.Add(this.grpSpell);
            this.grpConditional.Controls.Add(this.grpClass);
            this.grpConditional.Controls.Add(this.grpLevelStat);
            this.grpConditional.Controls.Add(this.grpMapIs);
            this.grpConditional.Controls.Add(this.grpGender);
            this.grpConditional.Controls.Add(this.grpEquippedItem);
            this.grpConditional.Controls.Add(this.grpHasItem);
            this.grpConditional.Controls.Add(this.grpSwitch);
            this.grpConditional.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpConditional.Location = new System.Drawing.Point(3, 3);
            this.grpConditional.Name = "grpConditional";
            this.grpConditional.Size = new System.Drawing.Size(281, 278);
            this.grpConditional.TabIndex = 17;
            this.grpConditional.TabStop = false;
            this.grpConditional.Text = "Conditional";
            // 
            // grpEquippedItem
            // 
            this.grpEquippedItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpEquippedItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEquippedItem.Controls.Add(this.cmbEquippedItem);
            this.grpEquippedItem.Controls.Add(this.lblEquippedItem);
            this.grpEquippedItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEquippedItem.Location = new System.Drawing.Point(8, 38);
            this.grpEquippedItem.Name = "grpEquippedItem";
            this.grpEquippedItem.Size = new System.Drawing.Size(262, 58);
            this.grpEquippedItem.TabIndex = 26;
            this.grpEquippedItem.TabStop = false;
            this.grpEquippedItem.Text = "Has Equipped Item";
            // 
            // cmbEquippedItem
            // 
            this.cmbEquippedItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbEquippedItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbEquippedItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbEquippedItem.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbEquippedItem.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbEquippedItem.ButtonIcon")));
            this.cmbEquippedItem.DrawDropdownHoverOutline = false;
            this.cmbEquippedItem.DrawFocusRectangle = false;
            this.cmbEquippedItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEquippedItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquippedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEquippedItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbEquippedItem.FormattingEnabled = true;
            this.cmbEquippedItem.Location = new System.Drawing.Point(105, 27);
            this.cmbEquippedItem.Name = "cmbEquippedItem";
            this.cmbEquippedItem.Size = new System.Drawing.Size(150, 21);
            this.cmbEquippedItem.TabIndex = 3;
            this.cmbEquippedItem.Text = null;
            this.cmbEquippedItem.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblEquippedItem
            // 
            this.lblEquippedItem.AutoSize = true;
            this.lblEquippedItem.Location = new System.Drawing.Point(6, 24);
            this.lblEquippedItem.Name = "lblEquippedItem";
            this.lblEquippedItem.Size = new System.Drawing.Size(30, 13);
            this.lblEquippedItem.TabIndex = 2;
            this.lblEquippedItem.Text = "Item:";
            // 
            // chkNegated
            // 
            this.chkNegated.Location = new System.Drawing.Point(199, 220);
            this.chkNegated.Name = "chkNegated";
            this.chkNegated.Size = new System.Drawing.Size(72, 17);
            this.chkNegated.TabIndex = 34;
            this.chkNegated.Text = "Negated";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbConditionType
            // 
            this.cmbConditionType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbConditionType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbConditionType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbConditionType.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbConditionType.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbConditionType.ButtonIcon")));
            this.cmbConditionType.DrawDropdownHoverOutline = false;
            this.cmbConditionType.DrawFocusRectangle = false;
            this.cmbConditionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbConditionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConditionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbConditionType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbConditionType.FormattingEnabled = true;
            this.cmbConditionType.Items.AddRange(new object[] {
            "Player Switch is...",
            "Player Variable is...",
            "Global Switch is...",
            "Global Variable is...",
            "Has item...",
            "Class is...",
            "Knows spell...",
            "Level is....",
            "Self Switch is....",
            "Power level is....",
            "Time is between....",
            "Can Start Quest....",
            "Quest In Progress....",
            "Quest Completed....",
            "Player death...",
            "No NPCs on the map...",
            "Gender is...",
            "Item Equipped Is..."});
            this.cmbConditionType.Location = new System.Drawing.Point(88, 13);
            this.cmbConditionType.Name = "cmbConditionType";
            this.cmbConditionType.Size = new System.Drawing.Size(183, 21);
            this.cmbConditionType.TabIndex = 22;
            this.cmbConditionType.Text = "Player Switch is...";
            this.cmbConditionType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbConditionType.SelectedIndexChanged += new System.EventHandler(this.cmbConditionType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 16);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(81, 13);
            this.lblType.TabIndex = 21;
            this.lblType.Text = "Condition Type:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(113, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpHasItem
            // 
            this.grpHasItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpHasItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpHasItem.Controls.Add(this.nudItemAmount);
            this.grpHasItem.Controls.Add(this.cmbItem);
            this.grpHasItem.Controls.Add(this.lblItem);
            this.grpHasItem.Controls.Add(this.lblItemQuantity);
            this.grpHasItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpHasItem.Location = new System.Drawing.Point(9, 40);
            this.grpHasItem.Name = "grpHasItem";
            this.grpHasItem.Size = new System.Drawing.Size(262, 83);
            this.grpHasItem.TabIndex = 25;
            this.grpHasItem.TabStop = false;
            this.grpHasItem.Text = "Has Item";
            // 
            // nudItemAmount
            // 
            this.nudItemAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudItemAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudItemAmount.Location = new System.Drawing.Point(104, 18);
            this.nudItemAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudItemAmount.Name = "nudItemAmount";
            this.nudItemAmount.Size = new System.Drawing.Size(150, 20);
            this.nudItemAmount.TabIndex = 4;
            this.nudItemAmount.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cmbItem
            // 
            this.cmbItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbItem.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbItem.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbItem.ButtonIcon")));
            this.cmbItem.DrawDropdownHoverOutline = false;
            this.cmbItem.DrawFocusRectangle = false;
            this.cmbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(104, 52);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(150, 21);
            this.cmbItem.TabIndex = 3;
            this.cmbItem.Text = null;
            this.cmbItem.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(7, 55);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(30, 13);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "Item:";
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.Location = new System.Drawing.Point(7, 20);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(66, 13);
            this.lblItemQuantity.TabIndex = 0;
            this.lblItemQuantity.Text = "Has at least:";
            // 
            // grpSwitch
            // 
            this.grpSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSwitch.Controls.Add(this.cmbSwitchVal);
            this.grpSwitch.Controls.Add(this.lblSwitchIs);
            this.grpSwitch.Controls.Add(this.cmbSwitch);
            this.grpSwitch.Controls.Add(this.lblSwitch);
            this.grpSwitch.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSwitch.Location = new System.Drawing.Point(9, 40);
            this.grpSwitch.Name = "grpSwitch";
            this.grpSwitch.Size = new System.Drawing.Size(262, 89);
            this.grpSwitch.TabIndex = 23;
            this.grpSwitch.TabStop = false;
            this.grpSwitch.Text = "Player Switch";
            // 
            // cmbSwitchVal
            // 
            this.cmbSwitchVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSwitchVal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSwitchVal.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSwitchVal.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbSwitchVal.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbSwitchVal.ButtonIcon")));
            this.cmbSwitchVal.DrawDropdownHoverOutline = false;
            this.cmbSwitchVal.DrawFocusRectangle = false;
            this.cmbSwitchVal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSwitchVal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSwitchVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSwitchVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSwitchVal.FormattingEnabled = true;
            this.cmbSwitchVal.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbSwitchVal.Location = new System.Drawing.Point(79, 52);
            this.cmbSwitchVal.Name = "cmbSwitchVal";
            this.cmbSwitchVal.Size = new System.Drawing.Size(175, 21);
            this.cmbSwitchVal.TabIndex = 3;
            this.cmbSwitchVal.Text = "False";
            this.cmbSwitchVal.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblSwitchIs
            // 
            this.lblSwitchIs.AutoSize = true;
            this.lblSwitchIs.Location = new System.Drawing.Point(10, 55);
            this.lblSwitchIs.Name = "lblSwitchIs";
            this.lblSwitchIs.Size = new System.Drawing.Size(21, 13);
            this.lblSwitchIs.TabIndex = 2;
            this.lblSwitchIs.Text = "Is: ";
            // 
            // cmbSwitch
            // 
            this.cmbSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSwitch.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSwitch.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbSwitch.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbSwitch.ButtonIcon")));
            this.cmbSwitch.DrawDropdownHoverOutline = false;
            this.cmbSwitch.DrawFocusRectangle = false;
            this.cmbSwitch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSwitch.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSwitch.FormattingEnabled = true;
            this.cmbSwitch.Location = new System.Drawing.Point(79, 17);
            this.cmbSwitch.Name = "cmbSwitch";
            this.cmbSwitch.Size = new System.Drawing.Size(175, 21);
            this.cmbSwitch.TabIndex = 1;
            this.cmbSwitch.Text = null;
            this.cmbSwitch.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblSwitch
            // 
            this.lblSwitch.AutoSize = true;
            this.lblSwitch.Location = new System.Drawing.Point(7, 20);
            this.lblSwitch.Name = "lblSwitch";
            this.lblSwitch.Size = new System.Drawing.Size(45, 13);
            this.lblSwitch.TabIndex = 0;
            this.lblSwitch.Text = "Switch: ";
            // 
            // grpPlayerVariable
            // 
            this.grpPlayerVariable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpPlayerVariable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpPlayerVariable.Controls.Add(this.nudVariableValue);
            this.grpPlayerVariable.Controls.Add(this.cmbCompareGlobalVar);
            this.grpPlayerVariable.Controls.Add(this.cmbComparePlayerVar);
            this.grpPlayerVariable.Controls.Add(this.rdoVarCompareGlobalVar);
            this.grpPlayerVariable.Controls.Add(this.rdoVarComparePlayerVar);
            this.grpPlayerVariable.Controls.Add(this.rdoVarCompareStaticValue);
            this.grpPlayerVariable.Controls.Add(this.cmbVariableMod);
            this.grpPlayerVariable.Controls.Add(this.lblComparator);
            this.grpPlayerVariable.Controls.Add(this.cmbVariable);
            this.grpPlayerVariable.Controls.Add(this.lblVariable);
            this.grpPlayerVariable.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpPlayerVariable.Location = new System.Drawing.Point(9, 40);
            this.grpPlayerVariable.Name = "grpPlayerVariable";
            this.grpPlayerVariable.Size = new System.Drawing.Size(262, 174);
            this.grpPlayerVariable.TabIndex = 24;
            this.grpPlayerVariable.TabStop = false;
            this.grpPlayerVariable.Text = "Player Variable";
            // 
            // nudVariableValue
            // 
            this.nudVariableValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudVariableValue.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudVariableValue.Location = new System.Drawing.Point(113, 92);
            this.nudVariableValue.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudVariableValue.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudVariableValue.Name = "nudVariableValue";
            this.nudVariableValue.Size = new System.Drawing.Size(141, 20);
            this.nudVariableValue.TabIndex = 49;
            this.nudVariableValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cmbCompareGlobalVar
            // 
            this.cmbCompareGlobalVar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbCompareGlobalVar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbCompareGlobalVar.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbCompareGlobalVar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbCompareGlobalVar.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbCompareGlobalVar.ButtonIcon")));
            this.cmbCompareGlobalVar.DrawDropdownHoverOutline = false;
            this.cmbCompareGlobalVar.DrawFocusRectangle = false;
            this.cmbCompareGlobalVar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCompareGlobalVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompareGlobalVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCompareGlobalVar.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbCompareGlobalVar.FormattingEnabled = true;
            this.cmbCompareGlobalVar.Location = new System.Drawing.Point(144, 146);
            this.cmbCompareGlobalVar.Name = "cmbCompareGlobalVar";
            this.cmbCompareGlobalVar.Size = new System.Drawing.Size(110, 21);
            this.cmbCompareGlobalVar.TabIndex = 48;
            this.cmbCompareGlobalVar.Text = null;
            this.cmbCompareGlobalVar.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // cmbComparePlayerVar
            // 
            this.cmbComparePlayerVar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbComparePlayerVar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbComparePlayerVar.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbComparePlayerVar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbComparePlayerVar.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbComparePlayerVar.ButtonIcon")));
            this.cmbComparePlayerVar.DrawDropdownHoverOutline = false;
            this.cmbComparePlayerVar.DrawFocusRectangle = false;
            this.cmbComparePlayerVar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbComparePlayerVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComparePlayerVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbComparePlayerVar.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbComparePlayerVar.FormattingEnabled = true;
            this.cmbComparePlayerVar.Location = new System.Drawing.Point(144, 119);
            this.cmbComparePlayerVar.Name = "cmbComparePlayerVar";
            this.cmbComparePlayerVar.Size = new System.Drawing.Size(110, 21);
            this.cmbComparePlayerVar.TabIndex = 47;
            this.cmbComparePlayerVar.Text = null;
            this.cmbComparePlayerVar.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // rdoVarCompareGlobalVar
            // 
            this.rdoVarCompareGlobalVar.AutoSize = true;
            this.rdoVarCompareGlobalVar.Location = new System.Drawing.Point(8, 147);
            this.rdoVarCompareGlobalVar.Name = "rdoVarCompareGlobalVar";
            this.rdoVarCompareGlobalVar.Size = new System.Drawing.Size(129, 17);
            this.rdoVarCompareGlobalVar.TabIndex = 46;
            this.rdoVarCompareGlobalVar.Text = "Global Variable Value:";
            this.rdoVarCompareGlobalVar.CheckedChanged += new System.EventHandler(this.rdoVarCompareGlobalVar_CheckedChanged);
            // 
            // rdoVarComparePlayerVar
            // 
            this.rdoVarComparePlayerVar.AutoSize = true;
            this.rdoVarComparePlayerVar.Location = new System.Drawing.Point(8, 120);
            this.rdoVarComparePlayerVar.Name = "rdoVarComparePlayerVar";
            this.rdoVarComparePlayerVar.Size = new System.Drawing.Size(128, 17);
            this.rdoVarComparePlayerVar.TabIndex = 45;
            this.rdoVarComparePlayerVar.Text = "Player Variable Value:";
            this.rdoVarComparePlayerVar.CheckedChanged += new System.EventHandler(this.rdoVarComparePlayerVar_CheckedChanged);
            // 
            // rdoVarCompareStaticValue
            // 
            this.rdoVarCompareStaticValue.Location = new System.Drawing.Point(8, 92);
            this.rdoVarCompareStaticValue.Name = "rdoVarCompareStaticValue";
            this.rdoVarCompareStaticValue.Size = new System.Drawing.Size(96, 17);
            this.rdoVarCompareStaticValue.TabIndex = 44;
            this.rdoVarCompareStaticValue.Text = "Static Value:";
            this.rdoVarCompareStaticValue.CheckedChanged += new System.EventHandler(this.rdoVarCompareStaticValue_CheckedChanged);
            // 
            // cmbVariableMod
            // 
            this.cmbVariableMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbVariableMod.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbVariableMod.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbVariableMod.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbVariableMod.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbVariableMod.ButtonIcon")));
            this.cmbVariableMod.DrawDropdownHoverOutline = false;
            this.cmbVariableMod.DrawFocusRectangle = false;
            this.cmbVariableMod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVariableMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariableMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVariableMod.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbVariableMod.FormattingEnabled = true;
            this.cmbVariableMod.Items.AddRange(new object[] {
            "Equal To",
            "Greater Than or Equal To",
            "Less Than or Equal To",
            "Greater Than",
            "Less Than",
            "Does Not Equal"});
            this.cmbVariableMod.Location = new System.Drawing.Point(113, 52);
            this.cmbVariableMod.Name = "cmbVariableMod";
            this.cmbVariableMod.Size = new System.Drawing.Size(141, 21);
            this.cmbVariableMod.TabIndex = 3;
            this.cmbVariableMod.Text = "Equal To";
            this.cmbVariableMod.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblComparator
            // 
            this.lblComparator.AutoSize = true;
            this.lblComparator.Location = new System.Drawing.Point(7, 55);
            this.lblComparator.Name = "lblComparator";
            this.lblComparator.Size = new System.Drawing.Size(61, 13);
            this.lblComparator.TabIndex = 2;
            this.lblComparator.Text = "Comparator";
            // 
            // cmbVariable
            // 
            this.cmbVariable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbVariable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbVariable.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbVariable.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbVariable.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbVariable.ButtonIcon")));
            this.cmbVariable.DrawDropdownHoverOutline = false;
            this.cmbVariable.DrawFocusRectangle = false;
            this.cmbVariable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVariable.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbVariable.FormattingEnabled = true;
            this.cmbVariable.Location = new System.Drawing.Point(113, 17);
            this.cmbVariable.Name = "cmbVariable";
            this.cmbVariable.Size = new System.Drawing.Size(141, 21);
            this.cmbVariable.TabIndex = 1;
            this.cmbVariable.Text = null;
            this.cmbVariable.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblVariable
            // 
            this.lblVariable.AutoSize = true;
            this.lblVariable.Location = new System.Drawing.Point(7, 20);
            this.lblVariable.Name = "lblVariable";
            this.lblVariable.Size = new System.Drawing.Size(45, 13);
            this.lblVariable.TabIndex = 0;
            this.lblVariable.Text = "Variable";
            // 
            // grpQuestCompleted
            // 
            this.grpQuestCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpQuestCompleted.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpQuestCompleted.Controls.Add(this.lblQuestCompleted);
            this.grpQuestCompleted.Controls.Add(this.cmbCompletedQuest);
            this.grpQuestCompleted.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpQuestCompleted.Location = new System.Drawing.Point(9, 40);
            this.grpQuestCompleted.Name = "grpQuestCompleted";
            this.grpQuestCompleted.Size = new System.Drawing.Size(262, 71);
            this.grpQuestCompleted.TabIndex = 32;
            this.grpQuestCompleted.TabStop = false;
            this.grpQuestCompleted.Text = "Quest Completed:";
            this.grpQuestCompleted.Visible = false;
            // 
            // lblQuestCompleted
            // 
            this.lblQuestCompleted.AutoSize = true;
            this.lblQuestCompleted.Location = new System.Drawing.Point(6, 21);
            this.lblQuestCompleted.Name = "lblQuestCompleted";
            this.lblQuestCompleted.Size = new System.Drawing.Size(38, 13);
            this.lblQuestCompleted.TabIndex = 5;
            this.lblQuestCompleted.Text = "Quest:";
            // 
            // cmbCompletedQuest
            // 
            this.cmbCompletedQuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbCompletedQuest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbCompletedQuest.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbCompletedQuest.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbCompletedQuest.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbCompletedQuest.ButtonIcon")));
            this.cmbCompletedQuest.DrawDropdownHoverOutline = false;
            this.cmbCompletedQuest.DrawFocusRectangle = false;
            this.cmbCompletedQuest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCompletedQuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompletedQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCompletedQuest.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbCompletedQuest.FormattingEnabled = true;
            this.cmbCompletedQuest.Location = new System.Drawing.Point(92, 18);
            this.cmbCompletedQuest.Name = "cmbCompletedQuest";
            this.cmbCompletedQuest.Size = new System.Drawing.Size(162, 21);
            this.cmbCompletedQuest.TabIndex = 3;
            this.cmbCompletedQuest.Text = null;
            this.cmbCompletedQuest.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // grpQuestInProgress
            // 
            this.grpQuestInProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpQuestInProgress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpQuestInProgress.Controls.Add(this.lblQuestTask);
            this.grpQuestInProgress.Controls.Add(this.cmbQuestTask);
            this.grpQuestInProgress.Controls.Add(this.cmbTaskModifier);
            this.grpQuestInProgress.Controls.Add(this.lblQuestIs);
            this.grpQuestInProgress.Controls.Add(this.lblQuestProgress);
            this.grpQuestInProgress.Controls.Add(this.cmbQuestInProgress);
            this.grpQuestInProgress.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpQuestInProgress.Location = new System.Drawing.Point(8, 40);
            this.grpQuestInProgress.Name = "grpQuestInProgress";
            this.grpQuestInProgress.Size = new System.Drawing.Size(263, 122);
            this.grpQuestInProgress.TabIndex = 32;
            this.grpQuestInProgress.TabStop = false;
            this.grpQuestInProgress.Text = "Quest In Progress:";
            this.grpQuestInProgress.Visible = false;
            // 
            // lblQuestTask
            // 
            this.lblQuestTask.AutoSize = true;
            this.lblQuestTask.Location = new System.Drawing.Point(6, 86);
            this.lblQuestTask.Name = "lblQuestTask";
            this.lblQuestTask.Size = new System.Drawing.Size(34, 13);
            this.lblQuestTask.TabIndex = 9;
            this.lblQuestTask.Text = "Task:";
            // 
            // cmbQuestTask
            // 
            this.cmbQuestTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbQuestTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbQuestTask.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbQuestTask.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbQuestTask.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbQuestTask.ButtonIcon")));
            this.cmbQuestTask.DrawDropdownHoverOutline = false;
            this.cmbQuestTask.DrawFocusRectangle = false;
            this.cmbQuestTask.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbQuestTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestTask.Enabled = false;
            this.cmbQuestTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbQuestTask.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbQuestTask.FormattingEnabled = true;
            this.cmbQuestTask.Location = new System.Drawing.Point(92, 83);
            this.cmbQuestTask.Name = "cmbQuestTask";
            this.cmbQuestTask.Size = new System.Drawing.Size(163, 21);
            this.cmbQuestTask.TabIndex = 8;
            this.cmbQuestTask.Text = null;
            this.cmbQuestTask.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // cmbTaskModifier
            // 
            this.cmbTaskModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbTaskModifier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbTaskModifier.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTaskModifier.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbTaskModifier.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbTaskModifier.ButtonIcon")));
            this.cmbTaskModifier.DrawDropdownHoverOutline = false;
            this.cmbTaskModifier.DrawFocusRectangle = false;
            this.cmbTaskModifier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskModifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTaskModifier.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbTaskModifier.FormattingEnabled = true;
            this.cmbTaskModifier.Location = new System.Drawing.Point(92, 50);
            this.cmbTaskModifier.Name = "cmbTaskModifier";
            this.cmbTaskModifier.Size = new System.Drawing.Size(163, 21);
            this.cmbTaskModifier.TabIndex = 7;
            this.cmbTaskModifier.Text = null;
            this.cmbTaskModifier.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbTaskModifier.SelectedIndexChanged += new System.EventHandler(this.cmbTaskModifier_SelectedIndexChanged);
            // 
            // lblQuestIs
            // 
            this.lblQuestIs.AutoSize = true;
            this.lblQuestIs.Location = new System.Drawing.Point(6, 52);
            this.lblQuestIs.Name = "lblQuestIs";
            this.lblQuestIs.Size = new System.Drawing.Size(18, 13);
            this.lblQuestIs.TabIndex = 6;
            this.lblQuestIs.Text = "Is:";
            // 
            // lblQuestProgress
            // 
            this.lblQuestProgress.AutoSize = true;
            this.lblQuestProgress.Location = new System.Drawing.Point(6, 21);
            this.lblQuestProgress.Name = "lblQuestProgress";
            this.lblQuestProgress.Size = new System.Drawing.Size(38, 13);
            this.lblQuestProgress.TabIndex = 5;
            this.lblQuestProgress.Text = "Quest:";
            // 
            // cmbQuestInProgress
            // 
            this.cmbQuestInProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbQuestInProgress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbQuestInProgress.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbQuestInProgress.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbQuestInProgress.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbQuestInProgress.ButtonIcon")));
            this.cmbQuestInProgress.DrawDropdownHoverOutline = false;
            this.cmbQuestInProgress.DrawFocusRectangle = false;
            this.cmbQuestInProgress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbQuestInProgress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestInProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbQuestInProgress.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbQuestInProgress.FormattingEnabled = true;
            this.cmbQuestInProgress.Location = new System.Drawing.Point(92, 18);
            this.cmbQuestInProgress.Name = "cmbQuestInProgress";
            this.cmbQuestInProgress.Size = new System.Drawing.Size(163, 21);
            this.cmbQuestInProgress.TabIndex = 3;
            this.cmbQuestInProgress.Text = null;
            this.cmbQuestInProgress.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbQuestInProgress.SelectedIndexChanged += new System.EventHandler(this.cmbQuestInProgress_SelectedIndexChanged);
            // 
            // grpStartQuest
            // 
            this.grpStartQuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpStartQuest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpStartQuest.Controls.Add(this.lblStartQuest);
            this.grpStartQuest.Controls.Add(this.cmbStartQuest);
            this.grpStartQuest.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpStartQuest.Location = new System.Drawing.Point(9, 40);
            this.grpStartQuest.Name = "grpStartQuest";
            this.grpStartQuest.Size = new System.Drawing.Size(262, 71);
            this.grpStartQuest.TabIndex = 31;
            this.grpStartQuest.TabStop = false;
            this.grpStartQuest.Text = "Can Start Quest:";
            this.grpStartQuest.Visible = false;
            // 
            // lblStartQuest
            // 
            this.lblStartQuest.AutoSize = true;
            this.lblStartQuest.Location = new System.Drawing.Point(6, 21);
            this.lblStartQuest.Name = "lblStartQuest";
            this.lblStartQuest.Size = new System.Drawing.Size(38, 13);
            this.lblStartQuest.TabIndex = 5;
            this.lblStartQuest.Text = "Quest:";
            // 
            // cmbStartQuest
            // 
            this.cmbStartQuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbStartQuest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbStartQuest.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbStartQuest.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbStartQuest.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbStartQuest.ButtonIcon")));
            this.cmbStartQuest.DrawDropdownHoverOutline = false;
            this.cmbStartQuest.DrawFocusRectangle = false;
            this.cmbStartQuest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStartQuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStartQuest.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbStartQuest.FormattingEnabled = true;
            this.cmbStartQuest.Location = new System.Drawing.Point(92, 18);
            this.cmbStartQuest.Name = "cmbStartQuest";
            this.cmbStartQuest.Size = new System.Drawing.Size(162, 21);
            this.cmbStartQuest.TabIndex = 3;
            this.cmbStartQuest.Text = null;
            this.cmbStartQuest.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // grpTime
            // 
            this.grpTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpTime.Controls.Add(this.lblEndRange);
            this.grpTime.Controls.Add(this.lblStartRange);
            this.grpTime.Controls.Add(this.cmbTime2);
            this.grpTime.Controls.Add(this.cmbTime1);
            this.grpTime.Controls.Add(this.lblAnd);
            this.grpTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpTime.Location = new System.Drawing.Point(10, 40);
            this.grpTime.Name = "grpTime";
            this.grpTime.Size = new System.Drawing.Size(261, 105);
            this.grpTime.TabIndex = 30;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Time is between:";
            this.grpTime.Visible = false;
            // 
            // lblEndRange
            // 
            this.lblEndRange.AutoSize = true;
            this.lblEndRange.Location = new System.Drawing.Point(9, 73);
            this.lblEndRange.Name = "lblEndRange";
            this.lblEndRange.Size = new System.Drawing.Size(64, 13);
            this.lblEndRange.TabIndex = 6;
            this.lblEndRange.Text = "End Range:";
            // 
            // lblStartRange
            // 
            this.lblStartRange.AutoSize = true;
            this.lblStartRange.Location = new System.Drawing.Point(6, 21);
            this.lblStartRange.Name = "lblStartRange";
            this.lblStartRange.Size = new System.Drawing.Size(67, 13);
            this.lblStartRange.TabIndex = 5;
            this.lblStartRange.Text = "Start Range:";
            // 
            // cmbTime2
            // 
            this.cmbTime2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbTime2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbTime2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTime2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbTime2.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbTime2.ButtonIcon")));
            this.cmbTime2.DrawDropdownHoverOutline = false;
            this.cmbTime2.DrawFocusRectangle = false;
            this.cmbTime2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTime2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTime2.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbTime2.FormattingEnabled = true;
            this.cmbTime2.Location = new System.Drawing.Point(92, 70);
            this.cmbTime2.Name = "cmbTime2";
            this.cmbTime2.Size = new System.Drawing.Size(161, 21);
            this.cmbTime2.TabIndex = 4;
            this.cmbTime2.Text = null;
            this.cmbTime2.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // cmbTime1
            // 
            this.cmbTime1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbTime1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbTime1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTime1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbTime1.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbTime1.ButtonIcon")));
            this.cmbTime1.DrawDropdownHoverOutline = false;
            this.cmbTime1.DrawFocusRectangle = false;
            this.cmbTime1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTime1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTime1.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbTime1.FormattingEnabled = true;
            this.cmbTime1.Location = new System.Drawing.Point(92, 18);
            this.cmbTime1.Name = "cmbTime1";
            this.cmbTime1.Size = new System.Drawing.Size(161, 21);
            this.cmbTime1.TabIndex = 3;
            this.cmbTime1.Text = null;
            this.cmbTime1.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblAnd
            // 
            this.lblAnd.AutoSize = true;
            this.lblAnd.Location = new System.Drawing.Point(100, 49);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(26, 13);
            this.lblAnd.TabIndex = 2;
            this.lblAnd.Text = "And";
            // 
            // grpPowerIs
            // 
            this.grpPowerIs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpPowerIs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpPowerIs.Controls.Add(this.cmbPower);
            this.grpPowerIs.Controls.Add(this.lblPower);
            this.grpPowerIs.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpPowerIs.Location = new System.Drawing.Point(9, 41);
            this.grpPowerIs.Name = "grpPowerIs";
            this.grpPowerIs.Size = new System.Drawing.Size(262, 51);
            this.grpPowerIs.TabIndex = 25;
            this.grpPowerIs.TabStop = false;
            this.grpPowerIs.Text = "Power Is...";
            // 
            // cmbPower
            // 
            this.cmbPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbPower.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbPower.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbPower.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbPower.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbPower.ButtonIcon")));
            this.cmbPower.DrawDropdownHoverOutline = false;
            this.cmbPower.DrawFocusRectangle = false;
            this.cmbPower.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPower.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbPower.FormattingEnabled = true;
            this.cmbPower.Location = new System.Drawing.Point(79, 17);
            this.cmbPower.Name = "cmbPower";
            this.cmbPower.Size = new System.Drawing.Size(175, 21);
            this.cmbPower.TabIndex = 1;
            this.cmbPower.Text = null;
            this.cmbPower.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(7, 20);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(40, 13);
            this.lblPower.TabIndex = 0;
            this.lblPower.Text = "Power:";
            // 
            // grpSelfSwitch
            // 
            this.grpSelfSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpSelfSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSelfSwitch.Controls.Add(this.cmbSelfSwitchVal);
            this.grpSelfSwitch.Controls.Add(this.lblSelfSwitchIs);
            this.grpSelfSwitch.Controls.Add(this.cmbSelfSwitch);
            this.grpSelfSwitch.Controls.Add(this.lblSelfSwitch);
            this.grpSelfSwitch.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSelfSwitch.Location = new System.Drawing.Point(9, 40);
            this.grpSelfSwitch.Name = "grpSelfSwitch";
            this.grpSelfSwitch.Size = new System.Drawing.Size(262, 89);
            this.grpSelfSwitch.TabIndex = 29;
            this.grpSelfSwitch.TabStop = false;
            this.grpSelfSwitch.Text = "Self Switch";
            // 
            // cmbSelfSwitchVal
            // 
            this.cmbSelfSwitchVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSelfSwitchVal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSelfSwitchVal.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSelfSwitchVal.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbSelfSwitchVal.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbSelfSwitchVal.ButtonIcon")));
            this.cmbSelfSwitchVal.DrawDropdownHoverOutline = false;
            this.cmbSelfSwitchVal.DrawFocusRectangle = false;
            this.cmbSelfSwitchVal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSelfSwitchVal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelfSwitchVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelfSwitchVal.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSelfSwitchVal.FormattingEnabled = true;
            this.cmbSelfSwitchVal.Location = new System.Drawing.Point(79, 52);
            this.cmbSelfSwitchVal.Name = "cmbSelfSwitchVal";
            this.cmbSelfSwitchVal.Size = new System.Drawing.Size(177, 21);
            this.cmbSelfSwitchVal.TabIndex = 3;
            this.cmbSelfSwitchVal.Text = null;
            this.cmbSelfSwitchVal.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblSelfSwitchIs
            // 
            this.lblSelfSwitchIs.AutoSize = true;
            this.lblSelfSwitchIs.Location = new System.Drawing.Point(10, 55);
            this.lblSelfSwitchIs.Name = "lblSelfSwitchIs";
            this.lblSelfSwitchIs.Size = new System.Drawing.Size(21, 13);
            this.lblSelfSwitchIs.TabIndex = 2;
            this.lblSelfSwitchIs.Text = "Is: ";
            // 
            // cmbSelfSwitch
            // 
            this.cmbSelfSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSelfSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSelfSwitch.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSelfSwitch.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbSelfSwitch.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbSelfSwitch.ButtonIcon")));
            this.cmbSelfSwitch.DrawDropdownHoverOutline = false;
            this.cmbSelfSwitch.DrawFocusRectangle = false;
            this.cmbSelfSwitch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSelfSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelfSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelfSwitch.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSelfSwitch.FormattingEnabled = true;
            this.cmbSelfSwitch.Location = new System.Drawing.Point(79, 17);
            this.cmbSelfSwitch.Name = "cmbSelfSwitch";
            this.cmbSelfSwitch.Size = new System.Drawing.Size(177, 21);
            this.cmbSelfSwitch.TabIndex = 1;
            this.cmbSelfSwitch.Text = null;
            this.cmbSelfSwitch.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblSelfSwitch
            // 
            this.lblSelfSwitch.AutoSize = true;
            this.lblSelfSwitch.Location = new System.Drawing.Point(7, 20);
            this.lblSelfSwitch.Name = "lblSelfSwitch";
            this.lblSelfSwitch.Size = new System.Drawing.Size(66, 13);
            this.lblSelfSwitch.TabIndex = 0;
            this.lblSelfSwitch.Text = "Self Switch: ";
            // 
            // grpSpell
            // 
            this.grpSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpSpell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSpell.Controls.Add(this.cmbSpell);
            this.grpSpell.Controls.Add(this.lblSpell);
            this.grpSpell.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSpell.Location = new System.Drawing.Point(9, 40);
            this.grpSpell.Name = "grpSpell";
            this.grpSpell.Size = new System.Drawing.Size(262, 52);
            this.grpSpell.TabIndex = 26;
            this.grpSpell.TabStop = false;
            this.grpSpell.Text = "Knows Spell";
            // 
            // cmbSpell
            // 
            this.cmbSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSpell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSpell.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSpell.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbSpell.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbSpell.ButtonIcon")));
            this.cmbSpell.DrawDropdownHoverOutline = false;
            this.cmbSpell.DrawFocusRectangle = false;
            this.cmbSpell.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSpell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSpell.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSpell.FormattingEnabled = true;
            this.cmbSpell.Location = new System.Drawing.Point(79, 18);
            this.cmbSpell.Name = "cmbSpell";
            this.cmbSpell.Size = new System.Drawing.Size(175, 21);
            this.cmbSpell.TabIndex = 3;
            this.cmbSpell.Text = null;
            this.cmbSpell.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.Location = new System.Drawing.Point(7, 20);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(33, 13);
            this.lblSpell.TabIndex = 2;
            this.lblSpell.Text = "Spell:";
            // 
            // grpClass
            // 
            this.grpClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpClass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpClass.Controls.Add(this.cmbClass);
            this.grpClass.Controls.Add(this.lblClass);
            this.grpClass.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpClass.Location = new System.Drawing.Point(9, 40);
            this.grpClass.Name = "grpClass";
            this.grpClass.Size = new System.Drawing.Size(262, 52);
            this.grpClass.TabIndex = 27;
            this.grpClass.TabStop = false;
            this.grpClass.Text = "Class is";
            // 
            // cmbClass
            // 
            this.cmbClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbClass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbClass.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbClass.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbClass.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbClass.ButtonIcon")));
            this.cmbClass.DrawDropdownHoverOutline = false;
            this.cmbClass.DrawFocusRectangle = false;
            this.cmbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClass.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(79, 18);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(175, 21);
            this.cmbClass.TabIndex = 3;
            this.cmbClass.Text = null;
            this.cmbClass.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(7, 20);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "Class:";
            // 
            // grpLevelStat
            // 
            this.grpLevelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpLevelStat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpLevelStat.Controls.Add(this.chkStatIgnoreBuffs);
            this.grpLevelStat.Controls.Add(this.nudLevelStatValue);
            this.grpLevelStat.Controls.Add(this.cmbLevelStat);
            this.grpLevelStat.Controls.Add(this.lblLevelOrStat);
            this.grpLevelStat.Controls.Add(this.lblLvlStatValue);
            this.grpLevelStat.Controls.Add(this.cmbLevelComparator);
            this.grpLevelStat.Controls.Add(this.lblLevelComparator);
            this.grpLevelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpLevelStat.Location = new System.Drawing.Point(9, 40);
            this.grpLevelStat.Name = "grpLevelStat";
            this.grpLevelStat.Size = new System.Drawing.Size(262, 140);
            this.grpLevelStat.TabIndex = 28;
            this.grpLevelStat.TabStop = false;
            this.grpLevelStat.Text = "Level or Stat is...";
            // 
            // chkStatIgnoreBuffs
            // 
            this.chkStatIgnoreBuffs.Location = new System.Drawing.Point(13, 115);
            this.chkStatIgnoreBuffs.Name = "chkStatIgnoreBuffs";
            this.chkStatIgnoreBuffs.Size = new System.Drawing.Size(211, 17);
            this.chkStatIgnoreBuffs.TabIndex = 32;
            this.chkStatIgnoreBuffs.Text = "Ignore equipment & spell buffs.";
            // 
            // nudLevelStatValue
            // 
            this.nudLevelStatValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudLevelStatValue.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudLevelStatValue.Location = new System.Drawing.Point(79, 87);
            this.nudLevelStatValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudLevelStatValue.Name = "nudLevelStatValue";
            this.nudLevelStatValue.Size = new System.Drawing.Size(178, 20);
            this.nudLevelStatValue.TabIndex = 8;
            this.nudLevelStatValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cmbLevelStat
            // 
            this.cmbLevelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbLevelStat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbLevelStat.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbLevelStat.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbLevelStat.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbLevelStat.ButtonIcon")));
            this.cmbLevelStat.DrawDropdownHoverOutline = false;
            this.cmbLevelStat.DrawFocusRectangle = false;
            this.cmbLevelStat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLevelStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevelStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLevelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbLevelStat.FormattingEnabled = true;
            this.cmbLevelStat.Items.AddRange(new object[] {
            "Level",
            "Attack",
            "Defense",
            "Speed",
            "Ability Power",
            "Magic Resist"});
            this.cmbLevelStat.Location = new System.Drawing.Point(79, 23);
            this.cmbLevelStat.Name = "cmbLevelStat";
            this.cmbLevelStat.Size = new System.Drawing.Size(177, 21);
            this.cmbLevelStat.TabIndex = 7;
            this.cmbLevelStat.Text = "Level";
            this.cmbLevelStat.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblLevelOrStat
            // 
            this.lblLevelOrStat.AutoSize = true;
            this.lblLevelOrStat.Location = new System.Drawing.Point(7, 25);
            this.lblLevelOrStat.Name = "lblLevelOrStat";
            this.lblLevelOrStat.Size = new System.Drawing.Size(70, 13);
            this.lblLevelOrStat.TabIndex = 6;
            this.lblLevelOrStat.Text = "Level or Stat:";
            // 
            // lblLvlStatValue
            // 
            this.lblLvlStatValue.AutoSize = true;
            this.lblLvlStatValue.Location = new System.Drawing.Point(10, 89);
            this.lblLvlStatValue.Name = "lblLvlStatValue";
            this.lblLvlStatValue.Size = new System.Drawing.Size(37, 13);
            this.lblLvlStatValue.TabIndex = 4;
            this.lblLvlStatValue.Text = "Value:";
            // 
            // cmbLevelComparator
            // 
            this.cmbLevelComparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbLevelComparator.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbLevelComparator.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbLevelComparator.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbLevelComparator.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbLevelComparator.ButtonIcon")));
            this.cmbLevelComparator.DrawDropdownHoverOutline = false;
            this.cmbLevelComparator.DrawFocusRectangle = false;
            this.cmbLevelComparator.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLevelComparator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevelComparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLevelComparator.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbLevelComparator.FormattingEnabled = true;
            this.cmbLevelComparator.Location = new System.Drawing.Point(79, 53);
            this.cmbLevelComparator.Name = "cmbLevelComparator";
            this.cmbLevelComparator.Size = new System.Drawing.Size(177, 21);
            this.cmbLevelComparator.TabIndex = 3;
            this.cmbLevelComparator.Text = null;
            this.cmbLevelComparator.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblLevelComparator
            // 
            this.lblLevelComparator.AutoSize = true;
            this.lblLevelComparator.Location = new System.Drawing.Point(7, 55);
            this.lblLevelComparator.Name = "lblLevelComparator";
            this.lblLevelComparator.Size = new System.Drawing.Size(64, 13);
            this.lblLevelComparator.TabIndex = 2;
            this.lblLevelComparator.Text = "Comparator:";
            // 
            // grpMapIs
            // 
            this.grpMapIs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpMapIs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpMapIs.Controls.Add(this.btnSelectMap);
            this.grpMapIs.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpMapIs.Location = new System.Drawing.Point(10, 41);
            this.grpMapIs.Name = "grpMapIs";
            this.grpMapIs.Size = new System.Drawing.Size(261, 61);
            this.grpMapIs.TabIndex = 35;
            this.grpMapIs.TabStop = false;
            this.grpMapIs.Text = "Map Is...";
            // 
            // btnSelectMap
            // 
            this.btnSelectMap.Location = new System.Drawing.Point(9, 21);
            this.btnSelectMap.Name = "btnSelectMap";
            this.btnSelectMap.Padding = new System.Windows.Forms.Padding(5);
            this.btnSelectMap.Size = new System.Drawing.Size(244, 23);
            this.btnSelectMap.TabIndex = 21;
            this.btnSelectMap.Text = "Select Map";
            this.btnSelectMap.Click += new System.EventHandler(this.btnSelectMap_Click);
            // 
            // grpGender
            // 
            this.grpGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpGender.Controls.Add(this.cmbGender);
            this.grpGender.Controls.Add(this.lblGender);
            this.grpGender.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpGender.Location = new System.Drawing.Point(10, 42);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(261, 51);
            this.grpGender.TabIndex = 33;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender Is...";
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbGender.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbGender.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbGender.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbGender.ButtonIcon")));
            this.cmbGender.DrawDropdownHoverOutline = false;
            this.cmbGender.DrawFocusRectangle = false;
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGender.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(79, 17);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(174, 21);
            this.cmbGender.TabIndex = 1;
            this.cmbGender.Text = null;
            this.cmbGender.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(7, 20);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender:";
            // 
            // EventCommandConditionalBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpConditional);
            this.Name = "EventCommandConditionalBranch";
            this.Size = new System.Drawing.Size(287, 284);
            this.grpConditional.ResumeLayout(false);
            this.grpConditional.PerformLayout();
            this.grpEquippedItem.ResumeLayout(false);
            this.grpEquippedItem.PerformLayout();
            this.grpHasItem.ResumeLayout(false);
            this.grpHasItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemAmount)).EndInit();
            this.grpSwitch.ResumeLayout(false);
            this.grpSwitch.PerformLayout();
            this.grpPlayerVariable.ResumeLayout(false);
            this.grpPlayerVariable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVariableValue)).EndInit();
            this.grpQuestCompleted.ResumeLayout(false);
            this.grpQuestCompleted.PerformLayout();
            this.grpQuestInProgress.ResumeLayout(false);
            this.grpQuestInProgress.PerformLayout();
            this.grpStartQuest.ResumeLayout(false);
            this.grpStartQuest.PerformLayout();
            this.grpTime.ResumeLayout(false);
            this.grpTime.PerformLayout();
            this.grpPowerIs.ResumeLayout(false);
            this.grpPowerIs.PerformLayout();
            this.grpSelfSwitch.ResumeLayout(false);
            this.grpSelfSwitch.PerformLayout();
            this.grpSpell.ResumeLayout(false);
            this.grpSpell.PerformLayout();
            this.grpClass.ResumeLayout(false);
            this.grpClass.PerformLayout();
            this.grpLevelStat.ResumeLayout(false);
            this.grpLevelStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelStatValue)).EndInit();
            this.grpMapIs.ResumeLayout(false);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpConditional;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkGroupBox grpSwitch;
        private DarkComboBox cmbSwitchVal;
        private System.Windows.Forms.Label lblSwitchIs;
        private DarkComboBox cmbSwitch;
        private System.Windows.Forms.Label lblSwitch;
        private DarkComboBox cmbConditionType;
        private System.Windows.Forms.Label lblType;
        private DarkGroupBox grpPlayerVariable;
        private DarkComboBox cmbVariableMod;
        private System.Windows.Forms.Label lblComparator;
        private DarkComboBox cmbVariable;
        private System.Windows.Forms.Label lblVariable;
        private DarkGroupBox grpHasItem;
        private DarkComboBox cmbItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblItemQuantity;
        private DarkGroupBox grpSpell;
        private DarkComboBox cmbSpell;
        private System.Windows.Forms.Label lblSpell;
        private DarkGroupBox grpClass;
        private DarkComboBox cmbClass;
        private System.Windows.Forms.Label lblClass;
        private DarkGroupBox grpLevelStat;
        private System.Windows.Forms.Label lblLvlStatValue;
        private DarkComboBox cmbLevelComparator;
        private System.Windows.Forms.Label lblLevelComparator;
        private DarkGroupBox grpSelfSwitch;
        private DarkComboBox cmbSelfSwitchVal;
        private System.Windows.Forms.Label lblSelfSwitchIs;
        private DarkComboBox cmbSelfSwitch;
        private System.Windows.Forms.Label lblSelfSwitch;
        private DarkGroupBox grpPowerIs;
        private DarkComboBox cmbPower;
        private System.Windows.Forms.Label lblPower;
        private DarkGroupBox grpTime;
        private DarkComboBox cmbTime2;
        private DarkComboBox cmbTime1;
        private System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.Label lblEndRange;
        private System.Windows.Forms.Label lblStartRange;
        private DarkGroupBox grpQuestInProgress;
        private System.Windows.Forms.Label lblQuestTask;
        private DarkComboBox cmbQuestTask;
        private DarkComboBox cmbTaskModifier;
        private System.Windows.Forms.Label lblQuestIs;
        private System.Windows.Forms.Label lblQuestProgress;
        private DarkComboBox cmbQuestInProgress;
        private DarkGroupBox grpStartQuest;
        private System.Windows.Forms.Label lblStartQuest;
        private DarkComboBox cmbStartQuest;
        private DarkGroupBox grpQuestCompleted;
        private System.Windows.Forms.Label lblQuestCompleted;
        private DarkComboBox cmbCompletedQuest;
        private DarkComboBox cmbLevelStat;
        private System.Windows.Forms.Label lblLevelOrStat;
        private DarkGroupBox grpGender;
        private DarkComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private DarkNumericUpDown nudItemAmount;
        private DarkNumericUpDown nudLevelStatValue;
        private DarkCheckBox chkStatIgnoreBuffs;
        private DarkCheckBox chkNegated;
        private DarkGroupBox grpMapIs;
        private DarkButton btnSelectMap;
        internal DarkComboBox cmbCompareGlobalVar;
        internal DarkComboBox cmbComparePlayerVar;
        internal DarkRadioButton rdoVarCompareGlobalVar;
        internal DarkRadioButton rdoVarComparePlayerVar;
        internal DarkRadioButton rdoVarCompareStaticValue;
        private DarkNumericUpDown nudVariableValue;
        private DarkGroupBox grpEquippedItem;
        private DarkComboBox cmbEquippedItem;
        private System.Windows.Forms.Label lblEquippedItem;
    }
}