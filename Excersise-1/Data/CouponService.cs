using System.Threading.Tasks;

namespace ebs2.Data
{
    public class CouponService
    {   
        public Task<int> CheckCoupon(string coupon)
        {
            try 
            {
                int discountVal = Program.couponDictionary[coupon];
                return Task.FromResult(discountVal);
            }
            catch
            {
                return Task.FromResult(0);
            }
        }
    }
}