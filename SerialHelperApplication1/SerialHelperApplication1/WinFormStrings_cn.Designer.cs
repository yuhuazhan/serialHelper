﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SerialHelperApplication1 {
    using System;
    
    
    /// <summary>
    ///   用於查詢當地語系化字串等的強類型資源類別。
    /// </summary>
    // 這個類別是自動產生的，是利用 StronglyTypedResourceBuilder
    // 類別透過 ResGen 或 Visual Studio 這類工具。
    // 若要加入或移除成員，請編輯您的 .ResX 檔，然後重新執行 ResGen
    // (利用 /str 選項)，或重建您的 VS 專案。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class WinFormStrings_cn {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WinFormStrings_cn() {
        }
        
        /// <summary>
        ///   傳回這個類別使用的快取的 ResourceManager 執行個體。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SerialHelperApplication1.WinFormStrings_cn", typeof(WinFormStrings_cn).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   覆寫目前執行緒的 CurrentUICulture 屬性，對象是所有
        ///   使用這個強類型資源類別的資源查閱。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查詢類似 波特率 的當地語系化字串。
        /// </summary>
        internal static string baudRate_lbl_txt {
            get {
                return ResourceManager.GetString("baudRate_lbl_txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 校验位 的當地語系化字串。
        /// </summary>
        internal static string checkBit_lbl_txt {
            get {
                return ResourceManager.GetString("checkBit_lbl_txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        /// </summary>
        internal static System.Drawing.Bitmap close {
            get {
                object obj = ResourceManager.GetObject("close", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查詢類似 数据位 的當地語系化字串。
        /// </summary>
        internal static string dataLen_lbl_txt {
            get {
                return ResourceManager.GetString("dataLen_lbl_txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 串口配置 的當地語系化字串。
        /// </summary>
        internal static string groupBox1_txt {
            get {
                return ResourceManager.GetString("groupBox1_txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 发送和接收显示区域 的當地語系化字串。
        /// </summary>
        internal static string groupBox2_txt {
            get {
                return ResourceManager.GetString("groupBox2_txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 接收格式 的當地語系化字串。
        /// </summary>
        internal static string groupBox3_txt {
            get {
                return ResourceManager.GetString("groupBox3_txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 发送格式 的當地語系化字串。
        /// </summary>
        internal static string groupBox4_txt {
            get {
                return ResourceManager.GetString("groupBox4_txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 开启串口 的當地語系化字串。
        /// </summary>
        internal static string mangeCom_btn_txt {
            get {
                return ResourceManager.GetString("mangeCom_btn_txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 串口尚未开启 的當地語系化字串。
        /// </summary>
        internal static string msg_serialNotOpen_err {
            get {
                return ResourceManager.GetString("msg_serialNotOpen_err", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類型 System.Drawing.Bitmap 的當地語系化資源。
        /// </summary>
        internal static System.Drawing.Bitmap open {
            get {
                object obj = ResourceManager.GetObject("open", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查詢類似 串口号 的當地語系化字串。
        /// </summary>
        internal static string serialNumber_lbl_txt {
            get {
                return ResourceManager.GetString("serialNumber_lbl_txt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 停止位 的當地語系化字串。
        /// </summary>
        internal static string stopBits_lbl_txt {
            get {
                return ResourceManager.GetString("stopBits_lbl_txt", resourceCulture);
            }
        }
    }
}
