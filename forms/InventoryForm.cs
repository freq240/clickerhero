using System;

namespace ClickerGame
{
    public partial class InventoryForm : FormWithShadow
    {
        // Start values for damage and reduction 
        int DamageValue = Hero.STANDART_DAMAGE_VALUE;
        int ReductionValue = Hero.STANDART_REDUCTION_VALUE;

        


        public InventoryForm()
        {
            InitializeComponent();

            labelCM1.Hide();
            labelCM2.Hide();
            labelCM3.Hide();   
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ClosingForm();
        }

        private void toMenuButton_Click(object sender, EventArgs e)
        {
            SlowTransition(5);
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();           
        }


        // Update damage and reduction value
        private void UpdateDamage(Weapon weapon)
        {
            if (ItemStates.isSomeWeaponEquiped)
            {
                for (int i = 0; i < Hero.EquipedItems.Count; i++)
                {
                    if (Hero.EquipedItems[i] is Weapon)
                    {
                        Hero.EquipedItems[i] = weapon;
                    }
                }
            }
            else
            {
                Hero.EquipedItems.Add(weapon);
                ItemStates.isSomeWeaponEquiped = true;
            }
            
            // update to standart 
            DamageValue = Hero.STANDART_DAMAGE_VALUE;

            // update it on new one
            DamageValue += weapon.Damage;
            Hero.HeroDamage = DamageValue;
            labelDamageValue.Text = DamageValue.ToString() + " ֍";
        }

        private void UpdateReduction(IArmor armor)
        {
            // update to standart 
            ReductionValue = Hero.STANDART_REDUCTION_VALUE;
            
            // for chest 
            if (armor is Chest)
            {
                if (ItemStates.isSomeChestEquiped)
                {
                    for (int i = 0; i < Hero.EquipedItems.Count; i++)
                    {
                        if (Hero.EquipedItems[i] is Chest)
                        {
                            Hero.EquipedItems[i] = armor;
                        }
                    }
                }
                else
                {
                    Hero.EquipedItems.Add(armor);
                    ItemStates.isSomeChestEquiped = true;
                }
            }

            // for head 
            if (armor is Head)
            {
                if (ItemStates.isSomeHeadEquiped)
                {
                    for (int i = 0; i < Hero.EquipedItems.Count; i++)
                    {
                        if (Hero.EquipedItems[i] is Head)
                        {
                            Hero.EquipedItems[i] = armor;
                        }
                    }
                }
                else
                {
                    Hero.EquipedItems.Add(armor);
                    ItemStates.isSomeHeadEquiped = true;
                }
            }

            for (int i = 0; i < Hero.EquipedItems.Count; i++)
            {
                if (Hero.EquipedItems[i] is Chest)
                {
                    ReductionValue += ((Chest)Hero.EquipedItems[i]).Reduction;
                }
                if (Hero.EquipedItems[i] is Head)
                {
                    ReductionValue += ((Head)Hero.EquipedItems[i]).Reduction;
                }
            }

            Hero.HeroReduction = ReductionValue;
            labelReductionValue.Text = ReductionValue.ToString() + " %";
        }

  
        // Weapons check
        // AXE
        private void pictureBoxW1_Click(object sender, EventArgs e)
        {   
            labelCM1.Left = 90;
            labelCM1.Top = 310;
            labelCM1.Show();

            // call update-method
            UpdateDamage(new Axe());
            
        }

        // SWORD
        private void pictureBoxW2_Click(object sender, EventArgs e)
        {
            labelCM1.Left = 240;
            labelCM1.Top = 310;
            labelCM1.Show();

            UpdateDamage(new Sword());
        }


        // BOW
        private void pictureBoxW3_Click(object sender, EventArgs e)
        {
            labelCM1.Left = 405;
            labelCM1.Top = 310;
            labelCM1.Show();

            UpdateDamage(new Bow());
        }

        // Helmets check

        // MOTOHEAD
        private void pictureBoxH1_Click(object sender, EventArgs e)
        {
            labelCM2.Left = 615;
            labelCM2.Top = 310;
            labelCM2.Show();

            UpdateReduction(new MotoHead());
        }

        // VIKINGHEAD
        private void pictureBoxH2_Click(object sender, EventArgs e)
        {
            labelCM2.Left = 770;
            labelCM2.Top = 310;
            labelCM2.Show();

            UpdateReduction(new VikingHead());
        }

        // SPARTAHEAD
        private void pictureBoxH3_Click(object sender, EventArgs e)
        {
            labelCM2.Left = 935;
            labelCM2.Top = 310;
            labelCM2.Show();

            UpdateReduction(new SpartaHead());

        }

        // Armor check
        
        // SOLDIER CHEST
        private void pictureBoxA1_Click(object sender, EventArgs e)
        {
            labelCM3.Left = 100;
            labelCM3.Top = 510;
            labelCM3.Show();

            UpdateReduction(new SoldierChest());
        }

        // KNIGHT CHEST
        private void pictureBoxA2_Click(object sender, EventArgs e)
        {
            labelCM3.Left = 250;
            labelCM3.Top = 510;
            labelCM3.Show();

            UpdateReduction(new KnightChest());
        }

        // EMPEROR CHEST
        private void pictureBoxA3_Click(object sender, EventArgs e)
        {
            labelCM3.Left = 405;
            labelCM3.Top = 510;
            labelCM3.Show();

            UpdateReduction(new EmperorChest());
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            labelDamageValue.Text = Hero.STANDART_DAMAGE_VALUE.ToString();
            labelReductionValue.Text = Hero.STANDART_REDUCTION_VALUE.ToString() + " %";

            if (ItemStates.isSomeWeaponEquiped)
            {
                for (int i = 0; i < Hero.EquipedItems.Count; i++)
                {

                    // FOR WEAPON STARTER MARK
                    if (Hero.EquipedItems[i] is Weapon)
                    {
                        string weaponName = ((Weapon)Hero.EquipedItems[i]).Name;
                        switch (weaponName)
                        {
                            case "Axe":
                                
                                labelCM1.Left = 90;
                                labelCM1.Top = 310;
                                labelCM1.Show();
                                UpdateDamage(new Axe());
                                break;

                            case "Sword":

                                labelCM1.Left = 240;
                                labelCM1.Top = 310;
                                labelCM1.Show();
                                UpdateDamage(new Sword());
                                break;
                        
                            case "Bow":
                        
                                labelCM1.Left = 405;
                                labelCM1.Top = 310;
                                labelCM1.Show();
                                UpdateDamage(new Bow());
                                break;

                            default:
                                break;
                        }
                    }

                    // FOR CHEST STARTER MARK
                    if (Hero.EquipedItems[i] is Chest)
                    {
                        string chestName = ((Chest)Hero.EquipedItems[i]).Name;
                        switch (chestName)
                        {
                            case "SoldierChest":

                                labelCM3.Left = 100;
                                labelCM3.Top = 510;
                                labelCM3.Show();
                                UpdateReduction(new SoldierChest());
                                break;

                            case "KnightChest":

                                labelCM3.Left = 250;
                                labelCM3.Top = 510;
                                labelCM3.Show();
                                UpdateReduction(new KnightChest());
                                break;

                            case "EmperorChest":

                                labelCM3.Left = 405;
                                labelCM3.Top = 510;
                                labelCM3.Show();
                                UpdateReduction(new EmperorChest());
                                break;

                            default:
                                break;
                        }
                    }
                    // FOR HEAD STARTER MARK
                    if (Hero.EquipedItems[i] is Head)
                    {
                        string headName = ((Head)Hero.EquipedItems[i]).Name;
                        switch (headName)
                        {
                            case "MotoHead":

                                labelCM2.Left = 615;
                                labelCM2.Top = 310;
                                labelCM2.Show();
                                UpdateReduction(new MotoHead());
                                break;

                            case "VikingHead":

                                labelCM2.Left = 770;
                                labelCM2.Top = 310;
                                labelCM2.Show();
                                UpdateReduction(new VikingHead());
                                break;

                            case "SpartaHead":

                                labelCM2.Left = 935;
                                labelCM2.Top = 310;
                                labelCM2.Show();
                                UpdateReduction(new SpartaHead());
                                break;

                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}
