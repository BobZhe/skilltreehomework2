using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCar
{
    //interface IPurchaseGoods
    //{
    //    void SetTheGoodsNumber(
    //        int book1Count,
    //        int book2Count,
    //        int book3Count,
    //        int book4Count,
    //        int book5Count);

    //    double PayTheBill();
    //}

    internal class CHarryPotter
    {
        private int _price        = 100;
        private int[] _bookCounts = new int[5];
        private int _totalBookCounts;
        private int[] _BooksGroupedAmount = new int[5] { 0, 0, 0, 0, 0 };

        public void SetTheGoodsNumber(
            int book1Count,
            int book2Count,
            int book3Count,
            int book4Count,
            int book5Count)
        {
            _bookCounts[0] = book1Count;
            _bookCounts[1] = book2Count;
            _bookCounts[2] = book3Count;
            _bookCounts[3] = book4Count;
            _bookCounts[4] = book5Count;
            
            _totalBookCounts = 
                book1Count + book2Count + book3Count + book4Count + book5Count;
        }

        public double PayTheBill()
        {
            double bill = new double();
            bill = GetTheNoDiscountsBill() - GetTheDiscounts();
            return bill;
        }

        internal double GetTheNoDiscountsBill()
        {
            double noDiscountsBill = new double();

            noDiscountsBill = _price * _totalBookCounts;
            
            return noDiscountsBill;
        }

        internal double GetTheDiscounts()
        {
            double discounts = new double();
            
            DecideBooksGroupedAmount();

            discounts = CalculateTheDiscounts();
            
            return discounts;
        }

        private int DecideBooksGroupedAmount()
        {
            int zeroAmount       = 0;
            int minvalue         = 0;
            int BookGroupedInx     = 0;
            int[] booksCountDealArray = new int[5];

            for(int i = 0; i < _bookCounts.Length; i++) 
            {
                booksCountDealArray[i] = _bookCounts[i];
            }

            zeroAmount = FindZeroAmountInDealArray(booksCountDealArray);
            
            if(zeroAmount == 5) 
            {
                for(int i = 0; i < 5; i++) {
                    _BooksGroupedAmount[i] = 0;
                }
                return 0;
            }

            while(zeroAmount != 5)
            {
                zeroAmount = FindZeroAmountInDealArray(booksCountDealArray);

                BookGroupedInx = DecideBelongToWhichBookGrouped(zeroAmount);

                minvalue = GetMinButNotZeroInDealArray(booksCountDealArray);

                _BooksGroupedAmount[BookGroupedInx] = minvalue;

                DealArraySubMinNumber(
                    ref booksCountDealArray,
                    minvalue);

                zeroAmount = FindZeroAmountInDealArray(booksCountDealArray);
            }

            return 1;  
        }

        private int DecideBelongToWhichBookGrouped(int zeroAmount)
        {
            int BookGroupedInx = 4 - zeroAmount;
            return BookGroupedInx;
        }

        private void RecodeDealArrayLocationIsZero(
            int[] DealArray, 
            ref int[,] dealArrayLocationIsZero)
        {
            for(int i = 0; i < 5; i++)
            {
                if(DealArray[i] == 0)
                {
                    dealArrayLocationIsZero[1,i] = 1;
                }
            }
        }

        private int FindZeroAmountInDealArray(int[] DealArray)
        {
            int zeroAmount = 0;
            int[,] dealArrayLocationIsZero = 
                new int[2, 5] { { 0, 1, 2, 3, 4 }, { 0, 0, 0, 0, 0 } };
            
            RecodeDealArrayLocationIsZero(DealArray, ref dealArrayLocationIsZero);
            
            for(int i = 0; i < 5; i++) {
                zeroAmount += dealArrayLocationIsZero[1, i];
            }
            
            return zeroAmount;
        }

        private int GetMinButNotZeroInDealArray(int[] DealArray)
        {
            int minNumber = DealArray.Max();
            if(minNumber != 0){
                for(int i = 0; i < DealArray.Length; i++)
                {
                    if((DealArray[i] < minNumber) && (DealArray[i] > 0))
                    {
                        minNumber = DealArray[i];
                    }
                
                }
            }
            return minNumber;
        }

        private void DealArraySubMinNumber(
            ref int[] DealArray,
            int minNumber)
        {
            for(int i = 0; i < DealArray.Length; i++) {
                if(DealArray[i] != 0) {
                    DealArray[i] = DealArray[i] - minNumber;
                }
            }
        }
        
        private double CalculateTheDiscounts()
        {
            double discounts = new double();
            discounts = (_BooksGroupedAmount[0] * 0    * 1 +
                         _BooksGroupedAmount[1] * 0.05 * 2 +
                         _BooksGroupedAmount[2] * 0.1  * 3 +
                         _BooksGroupedAmount[3] * 0.2  * 4 +
                         _BooksGroupedAmount[4] * 0.25 * 5 ) * _price;

            return discounts;
        }
    }   

    public class CShoppingCar
    {
        CHarryPotter PurchaseGoods = null;

        public CShoppingCar(string MerchandiseName)
        {
            switch(MerchandiseName)
            {
                case("HarryPotter"):
                    PurchaseGoods = new CHarryPotter();
                    break;
                default:
                    break;
            }
        }

        public double PayTheBill()
        {
            return PurchaseGoods.PayTheBill();
        }

        public void SetTheGoodsNumber(
            int book1Count,
            int book2Count,
            int book3Count,
            int book4Count,
            int book5Count)
        {
            PurchaseGoods.SetTheGoodsNumber(
                book1Count,
                book2Count,
                book3Count,
                book4Count,
                book5Count);
        }
    }
 
}

