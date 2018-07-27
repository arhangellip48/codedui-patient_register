namespace patient_register
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class UIMap
    {

        /// <summary>
        /// chosePacient
        /// </summary>
        public void chosePacient()
        {
            #region Variable Declarations
            WinRow uIBindingList1строка1Row = this.UIКвазарWindow.UIРеестрпациентовWindow.UIBindingList1строка1Row.UIBindingList1Table.UIBindingList1строка1Row;
            #endregion

            // Щелкните "BindingList`1 строка 1" строка
            System.Threading.Thread.Sleep(1500);
            Mouse.Click(new Point(360,900));
            Mouse.Click(new Point(360, 900));
        }

        /// <summary>
        /// clickAction
        /// </summary>
        public void clickAction()
        {
            #region Variable Declarations
            WinButton uIДействияButton1 = this.UIКвазарWindow.UIРеестрпациентовWindow.UIДействияButton.UIДействияButton1;
            WinMenu uIPopupControlMenu = this.UIActions0Window.UIPopupControlWindow.UIPopupControlMenu;
            #endregion

            // Щелкните "Действия" кнопка
            Mouse.Click(uIДействияButton1);

            // Щелкните "PopupControl" всплывающее меню
            Mouse.Click(new Point(360, 900));
        }

        /// <summary>
        /// choseAllFilter - Используйте "choseAllFilterParams" для передачи параметров в этот метод.
        /// </summary>
        public void choseAllFilter()
        {
            #region Variable Declarations
            WinComboBox uIItemComboBox = this.UIКвазарWindow.UIРеестрпациентовWindow.UICmbDiagnosisWindow.UIItemComboBox;
            WinListItem uIГипертонияListItem = this.UIValueListDropDownWindow.UIValueListDropDownList.UIГипертонияListItem;
            WinButton uIПолучитьданныеButton = this.UIКвазарWindow.UIРеестрпациентовWindow.UIПолучитьданныеWindow.UIПолучитьданныеButton;
            WinComboBox uICmbDiagnosisComboBox = this.UIКвазарWindow.UIРеестрпациентовWindow.UICmbDiagnosisWindow.UICmbDiagnosisComboBox;
            WinListItem uIСтенокардияListItem = this.UIValueListDropDownWindow.UIValueListDropDownList1.UIСтенокардияListItem;
            WinListItem uIИнфарктListItem = this.UIValueListDropDownWindow.UIValueListDropDownList2.UIИнфарктListItem;
            WinListItem uIХИБСListItem = this.UIValueListDropDownWindow.UIValueListDropDownList3.UIХИБСListItem;
            #endregion

            Mouse.Click(uIItemComboBox);
            Keyboard.SendKeys("{DOWN}");
                  // Щелкните "Получить данные" кнопка
            Mouse.Click(uIПолучитьданныеButton);
            Mouse.DoubleClick(uIПолучитьданныеButton);

            Mouse.Click(uIItemComboBox);
            Keyboard.SendKeys("{DOWN}");
            // Щелкните "Получить данные" кнопка
            Mouse.Click(uIПолучитьданныеButton);
            Mouse.DoubleClick(uIПолучитьданныеButton);

            Mouse.Click(uIItemComboBox);
            Keyboard.SendKeys("{DOWN}");

            // Щелкните "Получить данные" кнопка
            Mouse.Click(uIПолучитьданныеButton, new Point(79, 9));
            Mouse.DoubleClick(uIПолучитьданныеButton);
            Mouse.Click(uIItemComboBox);
            Keyboard.SendKeys("{DOWN}");
                        // Щелкните "Получить данные" кнопка
            Mouse.Click(uIПолучитьданныеButton, new Point(51, 11));
            Mouse.DoubleClick(uIПолучитьданныеButton);
        }

        public virtual choseAllFilterParams choseAllFilterParams
        {
            get
            {
                if ((this.mchoseAllFilterParams == null))
                {
                    this.mchoseAllFilterParams = new choseAllFilterParams();
                }
                return this.mchoseAllFilterParams;
            }
        }

        private choseAllFilterParams mchoseAllFilterParams;
    }
    /// <summary>
    /// Параметры для передачи в "choseAllFilter"
    /// </summary>
    [GeneratedCode("Построитель кодированных тестов ИП", "15.0.26208.0")]
    public class choseAllFilterParams
    {

        #region Fields
        /// <summary>
        /// Выбрать "Гипертония" в поле со списком
        /// </summary>
        public string UIItemComboBoxSelectedItem = "Гипертония";

        /// <summary>
        /// Тип "{Enter}" в "Гипертония" элемент списка
        /// </summary>
        public string UIГипертонияListItemSendKeys = "{Enter}";

        /// <summary>
        /// Выберите "Стенокардия" в "cmbDiagnosis" поле со списком
        /// </summary>
        public string UICmbDiagnosisComboBoxSelectedItem = "Стенокардия";

        /// <summary>
        /// Тип "{Enter}" в "Стенокардия" элемент списка
        /// </summary>
        public string UIСтенокардияListItemSendKeys = "{Enter}";

        /// <summary>
        /// Выберите "Инфаркт" в "cmbDiagnosis" поле со списком
        /// </summary>
        public string UICmbDiagnosisComboBoxSelectedItem1 = "Инфаркт";

        /// <summary>
        /// Тип "{Enter}" в "Инфаркт" элемент списка
        /// </summary>
        public string UIИнфарктListItemSendKeys = "{Enter}";

        /// <summary>
        /// Выберите "ХИБС" в "cmbDiagnosis" поле со списком
        /// </summary>
        public string UICmbDiagnosisComboBoxSelectedItem2 = "ХИБС";

        /// <summary>
        /// Тип "{Enter}" в "ХИБС" элемент списка
        /// </summary>
        public string UIХИБСListItemSendKeys = "{Enter}";
        #endregion
    }
}
