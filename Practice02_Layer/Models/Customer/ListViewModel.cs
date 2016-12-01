using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice02_Layer.Models.Customer
{
    /// <summary>
    /// 一覧画面ビューモデルの
    /// </summary>
    public class ListViewModel
    {
        /// <summary>
        /// ページタイトル
        /// </summary>
        public string PageTitle { get; set; }
        /// <summary>
        /// 検索条件
        /// </summary>
        public FilterViewModel FilterItems { get; set; }
        /// <summary>
        /// リストデータ
        /// </summary>
        public IEnumerable<ListItemViewModel> List { get; set; }
    }

    /// <summary>
    /// 一覧画面の検索条件のビューモデル
    /// </summary>
    public class FilterViewModel
    {
        /// <summary>
        /// 顧客名
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// 担当者名
        /// </summary>
        public string EmployeeName { get; set; }
    }

    /// <summary>
    /// 一覧画面のリスト1行分のビューモデル
    /// </summary>
    public class ListItemViewModel
    {
        /// <summary>
        /// 顧客コード
        /// </summary>
        public string CustomerCode { get; set; }
        /// <summary>
        /// 顧客名
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// 担当者コード
        /// </summary>
        public string EmployeeCode { get; set; }
        /// <summary>
        /// 担当者名
        /// </summary>
        public string EmployeeName { get; set; }
    }
}
