#  C#軟件開發
## 串口助手製作
  - 設計: 主要分為三個部分，可以先在google或百度上參考一些人家的設計。
       1. 畫面設計
       2. 功能設計
       3. 擴充功能設計
  - 畫面: 對畫面設計沒什麼美感，主要先參考網路上廣大網友的設計,ex: <span style="color:red;">XCOM</span>。
  - 功能: 主要以使用過別人的串口助手，依樣畫葫蘆，並優化自己覺得不方便的設計。
       1. 串口號有下拉選單可以從電腦端獲取目前連接上的串口號
          使用者可以自行選擇需要開啟哪一個串口(ex. COM1...)。
       2. 波特率、封包長度、奇偶校驗、停止位個數，預設採用
          9600、8、N、1，也是做成有下拉選單，可以給使用者
          做細部微調。
       3. 有發送的欄位和接收顯示的欄位，並可以調整為16進制或是
          文字方式。
       4. 預計多支持幾個語系，如繁體中文，簡體中文，英文。

   ### Version 1.0
   - 主要在畫面設計部分尚未添加功能。

   ### Version 1.02  2016/11/8
   - 添加SerialPort類,完成接收部分的功能。<span style="color:red;">(<b>目前支援BIG5編碼~<b>)</span>
   - 添加主介面接收執行緒，當有資料接收會進入事件。 =>serialPort1_DataReceived
   - 添加委派，資料接收會透過委派給主ui執行緒更新事件。
   - 接收文本框，卷軸自動下拉功能添加，可勾選自動下拉開啟功能。(參考arduino 串口)
   - 添加menu，有一個語言設置，可以更換語系目前添加部分簡體，尚待完成。

   ### Version 1.03 2016/11/10
   - 添加串口發送功能，並支持發送中文文本，接收中文偶爾產生亂碼(問題不明)

   ### Version 1.04 2016/11/11
   - 修改打包為.exe檔時讀取不到照片,果斷將照片加入resx,在讀出來
   - 新增選單欄可以查看目前版本號
   - 可以從bin->release->serialHelper.exe執行程式,可以不用放在資料夾內也可以使用

   ### Version 1.05 2016/11/13
   - 修改原本介面使用的checkListBox控件為checkBox控件,因為前者太坑啦。
   - 更改編碼為UTF-8
   - 接收格式16進制顯示功能可以使用囉
   - 發送格式支援定時發送和發送+發送新行和回車(\r\n)。
   - 新增串口定時偵測,每300ms偵測一次是否有新的com號加入。
   - 太累了發現timer,錯誤會自動關,居然關不掉阿,明天再改阿。

  ### Version 1.06 2016/11/14
   - 更改接收區域從textbox更換為richtextbox控鍵可以容納更多資料。
   - 又發現bug勾選16進制顯示,某些狀況下會把0x0d =>0x00帶換掉(初步分析 Encoding.UTF8.GetBytes()出錯)

   # 測試版介面 Version 1.05

   ![第一版介面Ver1.05](https://i.imgur.com/mPSX16x.png)

   #### 目前還是學生,利用每晚回家時間更新
   #### 更新時間: PM 23:00~ AM 1:00
