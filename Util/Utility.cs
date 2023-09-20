using PracticeMasGlobal.Enum;
using PracticeMasGlobal.Enums;
using System.Security.Cryptography;
using System.Text;


namespace PracticeMasGlobal.Util
{
    public class Utility
    {

        public static string RandomBrand(ERaceType type)
        {

            Random random = new Random();
            if (type.ToString() == "MotorBike")
            {
                EBrandBike bike = (EBrandBike)random.Next(System.Enum.GetValues(typeof(EBrandBike)).Length);
                return bike.ToString();
            }

            EBrandTruck truck = (EBrandTruck)random.Next(System.Enum.GetValues(typeof(EBrandTruck)).Length);
            return truck.ToString();

        }

        public static EColor RandomColor()
        {

            Random random = new Random();
            return (EColor)random.Next(System.Enum.GetValues(typeof(EColor)).Length);
        }


        public static string RandomModel(int length)
        {
            const string allowedCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder code = new StringBuilder();

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] byteArray = new byte[length];
                rng.GetBytes(byteArray);

                foreach (byte b in byteArray)
                {
                    code.Append(allowedCharacters[b % allowedCharacters.Length]);
                }
            }

            return code.ToString();
        }

        public static Epilots RandomPilots()
        {

            Random random = new Random();

            return (Epilots)random.Next(System.Enum.GetValues(typeof(Epilots)).Length);
        }


        

    }

}

