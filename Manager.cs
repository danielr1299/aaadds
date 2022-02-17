using DataStuctures;
using Logic.InnerDataTypes;

namespace Logic
{
    public class Manager
    {
        BST<DataX> mainTree;
        //DoubleList<???> TimeQueue

        //readonly DataX<int> mainBST;
        readonly int maxPerBoxType = 50;
        IUIComunicator comunicator;        

        public Manager(IUIComunicator comunicator, int maxPerBoxType = 50)
        {
            this.comunicator = comunicator;

            if (maxPerBoxType > 50)
            this.maxPerBoxType = maxPerBoxType;
           // comunicator.OnMessage($"Box {mainBST.X} on {mainBST.Y} quantity exceeded the maximum ({maxPerBoxType})");
            // איך אני מתייחס לכמות שאני צריך להחזיר
        }

        public void Supply(double bottomSize, double height, int amount)
        {

            //search for the box and update total amout if exists, add new otherwise
           // if(!mainBST.X.Equals(bottomSize) && !mainBST)

         //   if (!mainBST.X.Equals(bottomSize) && !mainTree)
             //   mainTree.Add(bottomSize, height);
           // else
              //  mainBST.Count += amount;

          //  if (mainBST.X > 5 || mainBST.Y > 10)
                comunicator.OnMessage("Inappropriate box");
        }

        public void BoxData(double bottomSize, double height)
        {
            //DataX x = new DataX(bottomSize);
            //get count (and lastPurchaseDate) for this box if exists
          //  if (mainBST.X.Equals(bottomSize) && mainBST.Y.Equals(height))
           //     comunicator.OnMessage($"{mainBST.X} , {mainBST.Y}");
          //  else
                comunicator.OnMessage("not found");


        }

        public void Purchase(double x, double y, int count = 1)
        {
            // find boxes
            // to pr.  -> true/false
            // if false -> done
            // if true - update data
           // if(mainTree.Search())

        }

    }
}
