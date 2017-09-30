using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Assignment2_Aditi
{
    public partial class Form1 : Form
    {
        List<Car> car = new List<Car>();
        public int count;
        public string filename;
        string[] loadText;
        String fileRead = "";
        int j = 1;
        public static string recentcar;

        public static double ip;
        public static object[,] array = new object[10000, 10000]; // array to store information for each car
        private StreamWriter filewrite;
        public Form1()
        {

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool saveDetails()
        {
            if(txtcityGallon.Text == "" || txtCityMiles.Text == ""|| txtHighwayGallon.Text == "" || 
                txtHighwayMiles.Text == "" || txtInitialPrice.Text == "" || txtModel.Text == "" || txtYear1.Text == ""
                || txtYear2.Text == "" || txtYear3.Text == "" || txtYear4.Text == "" || txtYear5.Text == ""
                || txtYear6.Text == "" || txtYear7.Text == "" || txtYear8.Text == "" || txtYear9.Text == ""
                || txtYear10.Text == "" )
            {
                MessageBox.Show("Please Enter the Empty fields!");
                return false;
            }
            else
            {
              try
                {
                    Car.AvgGas[0] = Double.Parse(txtYear1.Text);
                    Car.AvgGas[1] = Double.Parse(txtYear2.Text);
                    Car.AvgGas[2] = Double.Parse(txtYear3.Text);
                    Car.AvgGas[3] = Double.Parse(txtYear4.Text);
                    Car.AvgGas[4] = Double.Parse(txtYear5.Text);
                    Car.AvgGas[5] = Double.Parse(txtYear6.Text);
                    Car.AvgGas[6] = Double.Parse(txtYear7.Text);
                    Car.AvgGas[7] = Double.Parse(txtYear8.Text);
                    Car.AvgGas[8] = Double.Parse(txtYear9.Text);
                    Car.AvgGas[9] = Double.Parse(txtYear10.Text);
                    Car.CityMileDriven = Double.Parse(txtCityMiles.Text);
                    Car.HighwayMileDriven = Double.Parse(txtHighwayGallon.Text);
                    string makestring = cmbMake.SelectedItem.ToString();
                    //MessageBox.Show("the com" + makestring);
                   // int num = Int32.Parse(txtNumberOfCars.Text);
                   // for(int i = 0;i <num;i++)
                    {
                        car.Add(new Car(makestring, txtModel.Text, Double.Parse(txtInitialPrice.Text), Double.Parse(txtcityGallon.Text), Double.Parse(txtHighwayGallon.Text)));
                        recentcar = makestring +"\t"+ txtModel.Text;
                    }

                    return true;
                        }
                catch(ArgumentOutOfRangeException e)
                {
                    MessageBox.Show(e.Message);
                }
                txtModel.Text = "";
                txtInitialPrice.Text = "";
                txtHighwayGallon.Text = "";
                txtcityGallon.Text = "";
            }
            return false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveDetails() == true)
            {
                try
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Text File|*.txt";
                    saveFileDialog1.Title = "Save a Car Report";
                    saveFileDialog1.ShowDialog();
                    filename = saveFileDialog1.FileName; 


                    if (saveFileDialog1.FileName != "")
                        File.WriteAllText(saveFileDialog1.FileName, saveFileDetails());
                    else
                        MessageBox.Show("Kindly Enter File Name.");
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(string.Format(ex.Message + "\n Null Reference Exception"));
                    return;

                }

            

            }
        }
        public string saveFileDetails()
        {
           
                string fileContent;
                fileContent = car.Count + "#" + Car.CityMileDriven.ToString() + "#" + Car.HighwayMileDriven.ToString() + "#";

                foreach (double d in Car.AvgGas)
                    fileContent += d.ToString() + "#";

                foreach (Car c in car)
                {
                    fileContent += c.make + "#" + c.model + "#" + c.IntialPrice.ToString() + "#"
                                + c.CityGallon.ToString() + "#" + c.HighwayGallon.ToString() + "#";
             //   MessageBox.Show(c.make);
                }

                return (fileContent);
            
           
        }

        private void txtNumberOfCars_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                next(j++);
             //   string[] loadText = fileRead.Split('#');
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("There no entries."));
                return;
            }


        }
        private void Report()
        {
            
            double calOwnership = 0;
            //This method will print report in multiline textfield.
            txtReport.Text = "City Miles Driven:" + Car.CityMileDriven + "\t Highway Miles Driven: " + Car.HighwayMileDriven +
                                "\n Average price per gallon of gasoline for next 10 years \n";
            int count = 1;
            foreach (double avg1 in Car.AvgGas)
            {
                txtReport.Text += "Year " + count + ": " + avg1 + "\n";
                count++;
                 calOwnership = calOwnership + avg1;
            }


            txtReport.Text += "\n";
            foreach (Car c in car)
            {
                txtReport.Text += "\n" + c.ToString();
                calOwnership = calOwnership + c.IntialPrice;
                string costofownership;
                costofownership = "total cost of ownership is :" + calOwnership + "\n";
                txtReport.Text += costofownership;

            }
        }
        public void next(int i)
        {
            string makestring = car[i].make;
            //MessageBox.Show(makestring);
            //MessageBox.Show(String.Format("i:"+i+"No of Rows:" + gridCarDetails.RowCount.ToString()));
            cmbMake.SelectedItem = makestring;
            txtModel.Text = car[i].model;
            txtInitialPrice.Text = car[i].IntialPrice.ToString();
            txtcityGallon.Text = car[i].CityGallon.ToString();
            txtHighwayGallon.Text = car[i].HighwayGallon.ToString();
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // string[] values;
            //string fileContent;


            //FileStream output = new FileStream(filename,FileMode.OpenOrCreate,FileAccess.Write);
            //filewrite = new StreamWriter(output);
            if (txtcityGallon.Text == "" || txtHighwayGallon.Text == "" || txtModel.Text == "" || txtInitialPrice.Text == "")
            {
                MessageBox.Show("Error! Please enter the fields");
            }
            else
            {
                string makestring = cmbMake.SelectedItem.ToString();
                car.Add(new Car(makestring, txtModel.Text, Double.Parse(txtInitialPrice.Text), Double.Parse(txtcityGallon.Text), Double.Parse(txtHighwayGallon.Text)));
                recentcar = makestring + "\t" + txtModel.Text;
                MessageBox.Show("The fiels are added to current file");

            }
            //foreach (Car c in car)
            //{
            //   // string fileContent;

            //    filewrite.WriteLine(c.make + "#" + c.model + "#" + c.IntialPrice.ToString() + "#"
            //                 + c.CityGallon.ToString() + "#" + c.HighwayGallon.ToString() + "#");
            //}


        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String fileRead = "";
           
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
              

                string ext = Path.GetExtension(openFileDialog1.FileName);

                if (ext.Equals(".txt"))
                {
                    try
                    {
                        System.IO.StreamReader stringRead = new System.IO.StreamReader(openFileDialog1.FileName);
                        fileRead = stringRead.ReadToEnd();
                        stringRead.Close();
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(String.Format(ex.Message + "\n Error! Can't open the file"));
                        return;
                    }

                }
                else
                    MessageBox.Show("File format not valid");
            }
            try
            {
                loadText = fileRead.Split('#');
                car.Clear();
              

                int lcount = 1;
                try
                 {
                Car.CityMileDriven = Convert.ToDouble(loadText[lcount++]);
                Car.HighwayMileDriven = Convert.ToDouble(loadText[lcount++]);
                for (int i = 0; i < 10; i++)
                {
                    Car.AvgGas[i] = Convert.ToDouble(loadText[lcount++]);
                }
                 txtCityMiles.Text = Car.CityMileDriven.ToString();
                 txtHighwayMiles.Text = Car.HighwayMileDriven.ToString();
                    txtYear1.Text = Car.AvgGas[0].ToString();
                    txtYear2.Text = Car.AvgGas[1].ToString();
                    txtYear3.Text = Car.AvgGas[2].ToString();
                    txtYear4.Text = Car.AvgGas[3].ToString();
                    txtYear5.Text = Car.AvgGas[4].ToString();
                    txtYear6.Text = Car.AvgGas[5].ToString();
                    txtYear7.Text = Car.AvgGas[6].ToString();
                    txtYear8.Text = Car.AvgGas[7].ToString();
                    txtYear9.Text = Car.AvgGas[8].ToString();
                    txtYear10.Text = Car.AvgGas[9].ToString();



                }
                catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(string.Format(ex.Message + "\n Load Data Exception"));
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(ex.Message + "\n Load Exception"));
                return;
            }
            for (int i = 0; i < Convert.ToInt32(loadText[0]); i++)
            {
                car.Add(new Car(loadText[lcount++],
                                loadText[lcount++],
                                double.Parse(loadText[lcount++]),
                                double.Parse(loadText[lcount++]),
                                double.Parse(loadText[lcount++])));
                    string makestring = car[0].make;
                //MessageBox.Show(String.Format("i:"+i+"No of Rows:" + gridCarDetails.RowCount.ToString()));
               cmbMake.SelectedItem = makestring;
                 txtModel.Text = car[0].model;
                txtInitialPrice.Text = car[0].IntialPrice.ToString();
                txtcityGallon.Text = car[0].CityGallon.ToString();
                txtHighwayGallon.Text = car[0].HighwayGallon.ToString();
                    recentcar = makestring + "\t" + txtModel.Text;
                    

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(string.Format(ex.Message + "\n Error in Data present in File"));
                return;
            }



        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if (txtcityGallon.Text == "" || txtCityMiles.Text == "" || txtHighwayGallon.Text == "" ||
                   txtHighwayMiles.Text == "" || txtInitialPrice.Text == "" || txtModel.Text == "" || txtYear1.Text == ""
                   || txtYear2.Text == "" || txtYear3.Text == "" || txtYear4.Text == "" || txtYear5.Text == ""
                   || txtYear6.Text == "" || txtYear7.Text == "" || txtYear8.Text == "" || txtYear9.Text == ""
                   || txtYear10.Text == "")
            {
                MessageBox.Show("Please enter the fields!");
            }
            else
            {
                Report();

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcityGallon.Text == "" || txtHighwayGallon.Text == "" || txtModel.Text == "" || txtInitialPrice.Text == "" )
            {
                MessageBox.Show("Error! Not enough data for deletion");
            }
            else
            {
                try
                {
                    int k = 0;
                  
                        foreach (Car c in car)
                        {
                            if(Double.Parse(txtcityGallon.Text) == c.CityGallon && Double.Parse(txtInitialPrice.Text)
                            == c.IntialPrice && Double.Parse(txtHighwayGallon.Text) == c.HighwayGallon 
                            && txtModel.Text == c.model )
                            {
                          //  MessageBox.Show("Found the match"+k);
                            car.RemoveAt(k);
                            loadText[k] = "";
                            Report();


                        }


                        k++;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deleted");
                    return;
                }
            }
            }

        private void BtnLoan_Click(object sender, EventArgs e)
        {
            if(txtcityGallon.Text == "" || txtCityMiles.Text == "" || txtHighwayGallon.Text == "" ||
                txtHighwayMiles.Text == "" || txtInitialPrice.Text == "" || txtModel.Text == "" || txtYear1.Text == ""
                || txtYear2.Text == "" || txtYear3.Text == "" || txtYear4.Text == "" || txtYear5.Text == ""
                || txtYear6.Text == "" || txtYear7.Text == "" || txtYear8.Text == "" || txtYear9.Text == ""
                || txtYear10.Text == "" )
            {
                MessageBox.Show("Please enter the fields!");
            }
            else
            {
                ip = Double.Parse(txtInitialPrice.Text);
                Car.DownPayment = ip;
                Form2 f2 = new Form2();
                f2.Show();
            }
        }
    }

    }

