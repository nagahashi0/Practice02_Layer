using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice02_Layer.Controllers
{
    public class CustomerController : Controller
    {

        private readonly Services.CustomerService _service;
 

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CustomerController()
        {
            this._service = new Services.CustomerService();
        }

        /// <summary>
        /// 一覧画面の表示
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            //ビューモデルの初期化
            Models.Customer.ListViewModel resMdl = this._service.ListInitialize();
            //ビューの表示
            return View(resMdl);
        }

        /// <summary>
        /// 検索を実行し一覧画面を表示します
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SearchList(Models.Customer.ListViewModel mdl)
        {
            //タスクを実行し、レスポンス用のビューに表示するデータを受けSearchListData取得
            Models.Customer.ListViewModel resMdl = this._service.SearchListData(mdl.FilterItems);
            //ビューの表示
            return View("List", resMdl);
        }
    }
}