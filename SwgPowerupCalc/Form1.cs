using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SwgPowerupCalc
{
	public class Form1 : Form
	{
        public int index;

        public int baseRE = 100;

        public float EnhMod;

		public PowerupSimulator psim;

		private IContainer components;

		private TextBox txtTool;

		private ListBox lstRatioPresets;

        private CheckBox cappedSuit;

        private CheckBox cappedPups;

        private CheckBox REArm;

        private CheckBox ExpertiseBonus;

        private CheckBox SpiceBonus;

        private CheckBox Custom;

        private CheckBox REEnhMod;

        private Label label1;

        private Label label2;

		private TextBox txtPowerBit;

		private Label label3;

		private TextBox txtRE;

		private Button btnCalculate;

        private Button howToUseBtn;

        private Button helpBtn;

        private Label label4;

		private TextBox txtRatio;

		private Label label6;

		private TextBox txtSimCount;

		private Label label5;

        private Label label7;

        private TextBox txtEnhMod;

        private Label label8;

        public Form1()
        { 
		    InitializeComponent();
            BackColor = System.Drawing.Color.DarkGray;
            lstRatioPresets.DataSource = PowerupSimulator.modBits;
			lstRatioPresets.DisplayMember = "Name";
			lstRatioPresets.ValueMember = "Ratio";
			lstRatioPresets.SelectedIndex = 1;
			lstRatioPresets.SelectedIndex = 0;
			psim = new PowerupSimulator();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
            //If user selects "Advanced Component Experimentation"
            if (index == 3)
            {
                MessageBox.Show("Cannot make Advanced Component Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Armor Experimentation"
            else if (index == 6)
            {
                MessageBox.Show("Cannot make Armor Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Artisan Experimentation"
            else if (index == 8)
            {
                MessageBox.Show("Cannot make Artisan Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Beast Expertise Bonus"
            else if (index == 17)
            {
                MessageBox.Show("Cannot make Beast Expertise Bonus into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Booster Experimentation"
            else if (index == 23)
            {
                MessageBox.Show("Cannot make Booster Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Chassis Experimentation"
            else if (index == 29)
            {
                MessageBox.Show("Cannot make Chassis Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Clothing Experimentation"
            else if (index == 31)
            {
                MessageBox.Show("Cannot make Clothing Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Cybernetic Experimentation"
            else if (index == 38)
            {
                MessageBox.Show("Cannot make Cybernetic Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Detect Camoflage"
            else if (index == 42)
            {
                MessageBox.Show("Cannot make Detect Camoflage into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Devastation"
            else if (index == 43)
            {
                MessageBox.Show("Cannot make Devastation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Dodge Reduction"
            else if (index == 47)
            {
                MessageBox.Show("Cannot make Dodge Reduction into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Droid Experimentation"
            else if (index == 50)
            {
                MessageBox.Show("Cannot make Droid Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Elemental Penetration: Acid"
            else if (index == 52)
            {
                MessageBox.Show("Cannot make Elemental Penetration: Acid into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Elemental Penetration: Cold"
            else if (index == 53)
            {
                MessageBox.Show("Cannot make Elemental Penetration: Cold into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "	Elemental Penetration: Electricity"
            else if (index == 54)
            {
                MessageBox.Show("Cannot make Elemental Penetration: Electricity into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Elemental Penetration: Heat"
            else if (index == 55)
            {
                MessageBox.Show("Cannot make Elemental Penetration: Heat into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Engine Experimentation"
            else if (index == 57)
            {
                MessageBox.Show("Cannot make Engine Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Fervent Mutation"
            else if (index == 64)
            {
                MessageBox.Show("Cannot make Fervent Mutation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Focused Enzyme Manipulation"
            else if (index == 67)
            {
                MessageBox.Show("Cannot make Focused Enzyme Manipulation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Food Experimentation"
            else if (index == 73)
            {
                MessageBox.Show("Cannot make Focused Food Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Heal Action Cost Reduction"
            else if (index == 77)
            {
                MessageBox.Show("Cannot make Heal Action Cost Reduction into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Incubation Time Reduction"
            else if (index == 83)
            {
                MessageBox.Show("Cannot make Incubation Time Reduction into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Lightsaber Experimentation"
            else if (index == 89)
            {
                MessageBox.Show("Cannot make Lightsaber Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Parry Reduction"
            else if (index == 97)
            {
                MessageBox.Show("Cannot make Parry Reduction into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Power Systems Experimentation"
            else if (index == 109)
            {
                MessageBox.Show("Cannot make Power Systems Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Shield Experimentation"
            else if (index == 116)
            {
                MessageBox.Show("Cannot make Shield Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Structure Experimentation"
            else if (index == 123)
            {
                MessageBox.Show("Cannot make Structure Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Weapon Experimentation"
            else if (index == 142)
            {
                MessageBox.Show("Cannot make Weapon Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            //If user selects "Weapon Systems Experimentation"
            else if (index == 144)
            {
                MessageBox.Show("Cannot make Weapon Systems Experimentation into a power up!\n\n Resetting selection.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstRatioPresets.SelectedIndex = 1;
                lstRatioPresets.SelectedIndex = 0;
            }
            else
            {
                try
                {
                    int ratio = int.Parse(txtRatio.Text);
                    float tool = float.Parse(txtTool.Text);
                    int powerbit = int.Parse(txtPowerBit.Text);
                    float rechance = float.Parse(txtRE.Text);
                    float quality = float.Parse(txtEnhMod.Text);
                    long simcount = long.Parse(txtSimCount.Text);
                    PowerupSimulator.SimulationResult simulationResult = psim.Simulate(ratio, tool, powerbit, rechance, quality, simcount);
                    MessageBox.Show($"Power Min: {simulationResult.power_min}\nPower Max: {simulationResult.power_max}\nPower Average: {simulationResult.power_avg}\n\n" + $"Amount Min: {simulationResult.amount_min}\nAmount Max: {simulationResult.amount_max}\nAmount Average: {simulationResult.amount_avg}", Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input values.\nPlease make sure you enter valid numbers.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Invalid input values.\nSome numbers were too large.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (ArgumentException ex3)
                {
                    MessageBox.Show(ex3.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
		}
        private void howToUseBtn_Click(object sender, EventArgs e)
        {
                MessageBox.Show("How To Use \n\n Select a mod-bit from the list that you would like to simulate.\n Enter the value of your Reverse Engineering tool effectiveness." +
                    "\n Enter the power bit value that you would like to use.\n Check off the boxes or enter a custom Reverse Engineering Chance.\n " +
                    "Check off the box if you wish to use an enhancement module.\n Select the number of simulations you would like to do.\n Click simulate.\n\n"
                    , Text, MessageBoxButtons.OK);
        }
        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Value Breakdowns \n\n Modifier Bit Ratio - This automically updates as you choose the modifier bit. No need to change this.\n\n " +
                "Power Bit Value - This caps at 35. When making power ups, use a 35 to maximize power of the power up. \n\n Tool Effectiveness - This is your " +
                "Reverse Engineering Tool, this caps at 10. \n\n RE-Chance Skillmod - This is your character's Reverse Engineer Chance. Use the check boxes to determine your " +
                "character's Reverse Engineer chance, or enter it by yourself. \n\n Enhancement Module - This is the Reverse Engineer Enhancement Module. It boosts the lowest power" +
                " of the power up you can get. This is by default off, since it DOES NOT effect MAX power up value. \n\n Number of simulations - Pretty straight forward. \n\n " +
                "Capped Suit - 3 RE Chance Shirt, 4 RE Chance Weapon, 4 RE Chance Chest. Full suit provides 11 RE Chance. \n\n Capped Power ups - Soft cap on RE Chance power ups " +
                "are 11's, 12's are possible, but rare. 33 total with 11's. \n\n Deconstruction Arm - Collection from hand sampling. Adds 5 RE Chance to character. \n\n Expertise Bonus - " +
                "Free 10 RE chance on 2nd page of Trader expertise. Don't miss this! \n\n Yarrok Bonus - Beyond implemented new Yarrock Spice with 1 RE chance. " +
                "Schematic can be looted from Legendary Avatar Platform. \n\n  Please report any bugs, errors, or changes to Dom#2403 on Discord\n\n"
                , Text, MessageBoxButtons.OK);
        }

        private void lstRatioPresets_SelectedIndexChanged(object sender, EventArgs e)
		{
                txtRatio.Text = lstRatioPresets.SelectedValue.ToString();
                index = lstRatioPresets.SelectedIndex;
        }

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtTool = new System.Windows.Forms.TextBox();
            this.lstRatioPresets = new System.Windows.Forms.ListBox();
            this.cappedSuit = new System.Windows.Forms.CheckBox();
            this.cappedPups = new System.Windows.Forms.CheckBox();
            this.REArm = new System.Windows.Forms.CheckBox();
            this.ExpertiseBonus = new System.Windows.Forms.CheckBox();
            this.SpiceBonus = new System.Windows.Forms.CheckBox();
            this.Custom = new System.Windows.Forms.CheckBox();
            this.REEnhMod = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPowerBit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRE = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.howToUseBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRatio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSimCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEnhMod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTool
            // 
            this.txtTool.BackColor = System.Drawing.Color.White;
            this.txtTool.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTool.Location = new System.Drawing.Point(461, 113);
            this.txtTool.Name = "txtTool";
            this.txtTool.Size = new System.Drawing.Size(145, 22);
            this.txtTool.TabIndex = 2;
            this.txtTool.Text = "10.0";
            // 
            // lstRatioPresets
            // 
            this.lstRatioPresets.BackColor = System.Drawing.Color.White;
            this.lstRatioPresets.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRatioPresets.FormattingEnabled = true;
            this.lstRatioPresets.HorizontalScrollbar = true;
            this.lstRatioPresets.ItemHeight = 14;
            this.lstRatioPresets.Items.AddRange(new object[] {
            "NULL"});
            this.lstRatioPresets.Location = new System.Drawing.Point(12, 12);
            this.lstRatioPresets.Name = "lstRatioPresets";
            this.lstRatioPresets.Size = new System.Drawing.Size(440, 535);
            this.lstRatioPresets.Sorted = true;
            this.lstRatioPresets.TabIndex = 0;
            this.lstRatioPresets.SelectedIndexChanged += new System.EventHandler(this.lstRatioPresets_SelectedIndexChanged);
            // 
            // cappedSuit
            // 
            this.cappedSuit.AutoSize = true;
            this.cappedSuit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cappedSuit.Location = new System.Drawing.Point(458, 265);
            this.cappedSuit.Name = "cappedSuit";
            this.cappedSuit.Size = new System.Drawing.Size(103, 18);
            this.cappedSuit.TabIndex = 8;
            this.cappedSuit.Text = "Capped Suit";
            this.cappedSuit.CheckedChanged += new System.EventHandler(this.cappedSuit_CheckedChanged);
            // 
            // cappedPups
            // 
            this.cappedPups.AutoSize = true;
            this.cappedPups.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cappedPups.Location = new System.Drawing.Point(458, 285);
            this.cappedPups.Name = "cappedPups";
            this.cappedPups.Size = new System.Drawing.Size(103, 18);
            this.cappedPups.TabIndex = 8;
            this.cappedPups.Text = "Capped Power ups";
            this.cappedPups.CheckedChanged += new System.EventHandler(this.cappedPups_CheckedChanged);
            // 
            // REArm
            // 
            this.REArm.AutoSize = true;
            this.REArm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REArm.Location = new System.Drawing.Point(458, 305);
            this.REArm.Name = "REArm";
            this.REArm.Size = new System.Drawing.Size(103, 18);
            this.REArm.TabIndex = 8;
            this.REArm.Text = "Deconstruction Arm";
            this.REArm.CheckedChanged += new System.EventHandler(this.REArm_CheckedChanged);
            // 
            // ExpertiseBonus
            // 
            this.ExpertiseBonus.AutoSize = true;
            this.ExpertiseBonus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpertiseBonus.Location = new System.Drawing.Point(458, 325);
            this.ExpertiseBonus.Name = "ExpertiseBonus";
            this.ExpertiseBonus.Size = new System.Drawing.Size(103, 18);
            this.ExpertiseBonus.TabIndex = 8;
            this.ExpertiseBonus.Text = "Expertise Bonus";
            this.ExpertiseBonus.CheckedChanged += new System.EventHandler(this.ExpertiseBonus_CheckedChanged);
            // 
            // SpiceBonus
            // 
            this.SpiceBonus.AutoSize = true;
            this.SpiceBonus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpiceBonus.Location = new System.Drawing.Point(458, 345);
            this.SpiceBonus.Name = "SpiceBonus";
            this.SpiceBonus.Size = new System.Drawing.Size(103, 18);
            this.SpiceBonus.TabIndex = 8;
            this.SpiceBonus.Text = "Yarrock Bonus";
            this.SpiceBonus.CheckedChanged += new System.EventHandler(this.SpiceBonus_CheckedChanged);
            // 
            // Custom
            // 
            this.Custom.AutoSize = true;
            this.Custom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Custom.Location = new System.Drawing.Point(458, 365);
            this.Custom.Name = "Custom";
            this.Custom.Size = new System.Drawing.Size(103, 18);
            this.Custom.TabIndex = 8;
            this.Custom.Text = "Custom RE Chance";
            this.Custom.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // REEnhMod
            // 
            this.REEnhMod.AutoSize = true;
            this.REEnhMod.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REEnhMod.Location = new System.Drawing.Point(458, 385);
            this.REEnhMod.Name = "REEnhMod";
            this.REEnhMod.Size = new System.Drawing.Size(103, 18);
            this.REEnhMod.TabIndex = 8;
            this.REEnhMod.Text = "Enhancement Module";
            this.REEnhMod.CheckedChanged += new System.EventHandler(this.REEnhMod_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 14);
            this.label1.Text = "Tool Effectiveness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 14);
            this.label2.Text = "Power Bit Value";
            // 
            // txtPowerBit
            // 
            this.txtPowerBit.BackColor = System.Drawing.Color.White;
            this.txtPowerBit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPowerBit.Location = new System.Drawing.Point(461, 71);
            this.txtPowerBit.Name = "txtPowerBit";
            this.txtPowerBit.Size = new System.Drawing.Size(145, 22);
            this.txtPowerBit.TabIndex = 2;
            this.txtPowerBit.Text = "35";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 14);
            this.label3.Text = "RE-Chance Skillmod";
            // 
            // txtRE
            // 
            this.txtRE.BackColor = System.Drawing.Color.White;
            this.txtRE.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRE.Location = new System.Drawing.Point(461, 155);
            this.txtRE.Name = "txtRE";
            this.txtRE.Size = new System.Drawing.Size(145, 22);
            this.txtRE.TabIndex = 3;
            this.txtRE.Text = "100";
            this.txtRE.Enabled = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(461, 405);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(145, 31);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Simulate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // howToUseBtn
            // 
            this.howToUseBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToUseBtn.Location = new System.Drawing.Point(461, 445);
            this.howToUseBtn.Name = "howToUseBtn";
            this.howToUseBtn.Size = new System.Drawing.Size(145, 31);
            this.howToUseBtn.TabIndex = 11;
            this.howToUseBtn.Text = "How To Use";
            this.howToUseBtn.UseVisualStyleBackColor = true;
            this.howToUseBtn.Click += new System.EventHandler(this.howToUseBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.Location = new System.Drawing.Point(461, 485);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(145, 31);
            this.helpBtn.TabIndex = 12;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Modifier Bit Ratio";
            // 
            // txtRatio
            // 
            this.txtRatio.BackColor = System.Drawing.Color.White;
            this.txtRatio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRatio.Location = new System.Drawing.Point(461, 30);
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.Size = new System.Drawing.Size(145, 22);
            this.txtRatio.TabIndex = 1;
            this.txtRatio.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(458, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 14);
            this.label6.Text = "Number of Simulations";
            // 
            // txtSimCount
            // 
            this.txtSimCount.BackColor = System.Drawing.Color.White;
            this.txtSimCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSimCount.Location = new System.Drawing.Point(461, 237);
            this.txtSimCount.Name = "txtSimCount";
            this.txtSimCount.Size = new System.Drawing.Size(145, 22);
            this.txtSimCount.TabIndex = 5;
            this.txtSimCount.Text = "10000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(504, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "developed by Dom";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(458, 180);
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.Text = "Enhancement Module";
            // 
            // txtEnhMod
            // 
            this.txtEnhMod.BackColor = System.Drawing.Color.White;
            this.txtEnhMod.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnhMod.Location = new System.Drawing.Point(461, 196);
            this.txtEnhMod.Name = "txtEnhMod";
            this.txtEnhMod.Size = new System.Drawing.Size(145, 22);
            this.txtEnhMod.TabIndex = 4;
            this.txtEnhMod.Text = "0";
            this.txtEnhMod.Enabled = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(200, 535);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(309, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Updated as of 2/26/2020";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(618, 550);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSimCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRatio);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.howToUseBtn);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPowerBit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRatioPresets);
            this.Controls.Add(this.txtTool);
            this.Controls.Add(this.cappedSuit);
            this.Controls.Add(this.cappedPups);
            this.Controls.Add(this.REArm);
            this.Controls.Add(this.ExpertiseBonus);
            this.Controls.Add(this.SpiceBonus);
            this.Controls.Add(this.Custom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEnhMod);
            this.Controls.Add(this.REEnhMod);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SWG Beyond Power Up Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        // Checkboxes
        private void cappedSuit_CheckedChanged(object sender, EventArgs e)
        {
            if(cappedSuit.Checked == true)
            {
                baseRE += 11;
                txtRE.Text = baseRE.ToString();
            }
            if (cappedSuit.Checked == false)
            {
                baseRE -= 11;
                txtRE.Text = baseRE.ToString();
            }
        }
        private void cappedPups_CheckedChanged(object sender, EventArgs e)
        {
            if (cappedPups.Checked == true)
            {
                baseRE += 33;
                txtRE.Text = baseRE.ToString();
            }
            if (cappedPups.Checked == false)
            {
                baseRE -= 33;
                txtRE.Text = baseRE.ToString();
            }
        }
        private void REArm_CheckedChanged(object sender, EventArgs e)
        {
            if (REArm.Checked == true)
            {
                baseRE += 5;
                txtRE.Text = baseRE.ToString();
            }
            if (REArm.Checked == false)
            {
                baseRE -= 5;
                txtRE.Text = baseRE.ToString();
            }
        }
        private void ExpertiseBonus_CheckedChanged(object sender, EventArgs e)
        {
            if (ExpertiseBonus.Checked == true)
            {
                baseRE += 10;
                txtRE.Text = baseRE.ToString();
            }
            if (ExpertiseBonus.Checked == false)
            {
                baseRE -= 10;
                txtRE.Text = baseRE.ToString();
            }
        }
        private void SpiceBonus_CheckedChanged(object sender, EventArgs e)
        {
            if (SpiceBonus.Checked == true)
            {
                baseRE += 1;
                txtRE.Text = baseRE.ToString();
            }
            if (SpiceBonus.Checked == false)
            {
                baseRE -= 1;
                txtRE.Text = baseRE.ToString();
            }
        }
        private void Custom_CheckedChanged(object sender, EventArgs e)
        {
            if (Custom.Checked == true)
            {
                txtRE.Text = "0";

                cappedSuit.Enabled = false;
                cappedPups.Enabled = false;
                REArm.Enabled = false;
                ExpertiseBonus.Enabled = false;
                SpiceBonus.Enabled = false;

                txtRE.Enabled = true;
            }
            if (Custom.Checked == false)
            {
                txtRE.Text = "100";

                cappedSuit.Enabled = true;
                cappedSuit.Checked = false;

                cappedPups.Enabled = true;
                cappedPups.Checked = false;

                REArm.Enabled = true;
                REArm.Checked = false;

                ExpertiseBonus.Enabled = true;
                ExpertiseBonus.Checked = false;

                SpiceBonus.Enabled = true;
                SpiceBonus.Checked = false;

                txtRE.Enabled = false;
            }
        }
        private void REEnhMod_CheckedChanged(object sender, EventArgs e)
        {
            if (REEnhMod.Checked == true)
            {
                txtEnhMod.Enabled = true;
                EnhMod = 10.0f;
                txtEnhMod.Text = EnhMod.ToString();
            }
            if (REEnhMod.Checked == false)
            {
                txtEnhMod.Enabled = false;
                EnhMod = 0.0f;
                txtEnhMod.Text = EnhMod.ToString();
            }
        }
    }
}