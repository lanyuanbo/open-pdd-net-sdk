using System.Net.Http;
using System.Threading.Tasks;
using PddOpenSdk.Models.Request.Refund;
using PddOpenSdk.Models.Response.Refund;
namespace PddOpenSdk.Services.PddApi
{
    public class RefundApi : PddCommonApi {

        public RefundApi() : base()
        {
        }

        public RefundApi(HttpClient httpClient) : base(httpClient)
        {

        }

        /// <summary>
        /// 取消发货
        /// </summary>
        public async Task<CancelRdcPddgeniusSendgoodsResponseModel> CancelRdcPddgeniusSendgoodsAsync (CancelRdcPddgeniusSendgoodsRequestModel cancelRdcPddgeniusSendgoods) {
            var result = await PostAsync<CancelRdcPddgeniusSendgoodsRequestModel, CancelRdcPddgeniusSendgoodsResponseModel> ("pdd.rdc.pddgenius.sendgoods.cancel", cancelRdcPddgeniusSendgoods);
            return result;
        }
        /// <summary>
        /// 获取商家退货地址库
        /// </summary>
        public async Task<GetRefundAddressListResponseModel> GetRefundAddressListAsync (GetRefundAddressListRequestModel getRefundAddressList) {
            var result = await PostAsync<GetRefundAddressListRequestModel, GetRefundAddressListResponseModel> ("pdd.refund.address.list.get", getRefundAddressList);
            return result;
        }
        /// <summary>
        /// 售后列表接口
        /// </summary>
        public async Task<GetRefundListIncrementResponseModel> GetRefundListIncrementAsync (GetRefundListIncrementRequestModel getRefundListIncrement) {
            var result = await PostAsync<GetRefundListIncrementRequestModel, GetRefundListIncrementResponseModel> ("pdd.refund.list.increment.get", getRefundListIncrement);
            return result;
        }
        /// <summary>
        /// 售后校验接口
        /// </summary>
        public async Task<CheckRefundStatusResponseModel> CheckRefundStatusAsync (CheckRefundStatusRequestModel checkRefundStatus) {
            var result = await PostAsync<CheckRefundStatusRequestModel, CheckRefundStatusResponseModel> ("pdd.refund.status.check", checkRefundStatus);
            return result;
        }

    }
}