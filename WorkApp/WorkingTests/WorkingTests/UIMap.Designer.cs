﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      Этот код был создан построителем кодированных тестов ИП.
//      Версия: 14.0.0.0
//
//      Изменения, внесенные в этот файл, могут привести к неправильной работе кода и будут
//      утрачены при повторном формировании кода.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace WorkingTests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Loadint data from file and 4 cliks on button Next
        /// </summary>
        public void LoadDataAnd4ClickOnNext()
        {
            #region Variable Declarations
            WinButton uILoadfromfileButton = this.UIForm1Window.UILoadfromfileWindow.UILoadfromfileButton;
            WinEdit uITextBoxNameEdit = this.UIForm1Window.UITextBoxNameWindow.UITextBoxNameEdit;
            WinButton uISetButton = this.UIForm1Window.UISetWindow.UISetButton;
            WinButton uIWritetofileButton = this.UIForm1Window.UIWritetofileWindow.UIWritetofileButton;
            WinButton uINextButton = this.UIForm1Window.UINextWindow.UINextButton;
            #endregion

            // Щелкните "Load from file" кнопка
            Mouse.Click(uILoadfromfileButton, new Point(90, 10));

            // Тип "Yurs" в "textBoxName" надпись
            uITextBoxNameEdit.Text = this.LoadDataAnd4ClickOnNextParams.UITextBoxNameEditText;

            // Щелкните "Set" кнопка
            Mouse.Click(uISetButton, new Point(29, 10));

            // Щелкните "Write to file" кнопка
            Mouse.Click(uIWritetofileButton, new Point(70, 4));

            // Щелкните "Load from file" кнопка
            Mouse.Click(uILoadfromfileButton, new Point(62, 12));

            // Щелкните "Next >>" кнопка
            Mouse.Click(uINextButton, new Point(24, 16));

            // Двойной щелчок "Next >>" кнопка
            Mouse.DoubleClick(uINextButton, new Point(24, 16));

            // Щелкните "Next >>" кнопка
            Mouse.Click(uINextButton, new Point(24, 16));
        }
        
        /// <summary>
        /// ChangeYearMethod - Используйте "ChangeYearMethodParams" для передачи параметров в этот метод.
        /// </summary>
        public void ChangeYearMethod()
        {
            #region Variable Declarations
            WinEdit uITextBoxYearEdit = this.UIForm1Window.UITextBoxYearWindow.UITextBoxYearEdit;
            WinButton uISetButton = this.UIForm1Window.UISetWindow1.UISetButton;
            #endregion

            // Тип "1994" в "textBoxYear" надпись
            uITextBoxYearEdit.Text = this.ChangeYearMethodParams.UITextBoxYearEditText;

            // Щелкните "Set" кнопка
            Mouse.Click(uISetButton, new Point(43, 19));
        }
        
        /// <summary>
        /// ChangeNameMethod - Используйте "ChangeNameMethodParams" для передачи параметров в этот метод.
        /// </summary>
        public void ChangeNameMethod()
        {
            #region Variable Declarations
            WinEdit uITextBoxNameEdit = this.UIForm1Window.UITextBoxNameWindow.UITextBoxNameEdit;
            WinButton uISetButton = this.UIForm1Window.UISetWindow.UISetButton;
            #endregion

            // Тип "Yura" в "textBoxName" надпись
            uITextBoxNameEdit.Text = this.ChangeNameMethodParams.UITextBoxNameEditText;

            // Щелкните "Set" кнопка
            Mouse.Click(uISetButton, new Point(27, 13));
        }
        
        /// <summary>
        /// CalclulateTarrifFor4Users
        /// </summary>
        public void CalclulateTarrifFor4Users()
        {
            #region Variable Declarations
            WinButton uICalculateTarrifButton = this.UIForm1Window.UICalculateTarrifWindow.UICalculateTarrifButton;
            WinButton uINextButton = this.UIForm1Window.UINextWindow.UINextButton;
            #endregion

            // Щелкните "Calculate Tarrif" кнопка
            Mouse.Click(uICalculateTarrifButton, new Point(66, 17));

            // Щелкните "Next >>" кнопка
            Mouse.Click(uINextButton, new Point(37, 12));

            // Щелкните "Calculate Tarrif" кнопка
            Mouse.Click(uICalculateTarrifButton, new Point(41, 19));

            // Щелкните "Next >>" кнопка
            Mouse.Click(uINextButton, new Point(30, 11));

            // Щелкните "Calculate Tarrif" кнопка
            Mouse.Click(uICalculateTarrifButton, new Point(47, 20));

            // Щелкните "Next >>" кнопка
            Mouse.Click(uINextButton, new Point(29, 11));

            // Щелкните "Calculate Tarrif" кнопка
            Mouse.Click(uICalculateTarrifButton, new Point(56, 19));
        }
        
        /// <summary>
        /// CloseMethod
        /// </summary>
        public void CloseMethod()
        {
            #region Variable Declarations
            WinButton uIЗакрытьButton = this.UIForm1Window.UIForm1TitleBar.UIЗакрытьButton;
            #endregion

            // Щелкните "Закрыть" кнопка
            Mouse.Click(uIЗакрытьButton, new Point(15, 14));
        }
        
        #region Properties
        public virtual LoadDataAnd4ClickOnNextParams LoadDataAnd4ClickOnNextParams
        {
            get
            {
                if ((this.mLoadDataAnd4ClickOnNextParams == null))
                {
                    this.mLoadDataAnd4ClickOnNextParams = new LoadDataAnd4ClickOnNextParams();
                }
                return this.mLoadDataAnd4ClickOnNextParams;
            }
        }
        
        public virtual ChangeYearMethodParams ChangeYearMethodParams
        {
            get
            {
                if ((this.mChangeYearMethodParams == null))
                {
                    this.mChangeYearMethodParams = new ChangeYearMethodParams();
                }
                return this.mChangeYearMethodParams;
            }
        }
        
        public virtual ChangeNameMethodParams ChangeNameMethodParams
        {
            get
            {
                if ((this.mChangeNameMethodParams == null))
                {
                    this.mChangeNameMethodParams = new ChangeNameMethodParams();
                }
                return this.mChangeNameMethodParams;
            }
        }
        
        public UIForm1Window UIForm1Window
        {
            get
            {
                if ((this.mUIForm1Window == null))
                {
                    this.mUIForm1Window = new UIForm1Window();
                }
                return this.mUIForm1Window;
            }
        }
        #endregion
        
        #region Fields
        private LoadDataAnd4ClickOnNextParams mLoadDataAnd4ClickOnNextParams;
        
        private ChangeYearMethodParams mChangeYearMethodParams;
        
        private ChangeNameMethodParams mChangeNameMethodParams;
        
        private UIForm1Window mUIForm1Window;
        #endregion
    }
    
    /// <summary>
    /// Параметры для передачи в "LoadDataAnd4ClickOnNext"
    /// </summary>
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class LoadDataAnd4ClickOnNextParams
    {
        
        #region Fields
        /// <summary>
        /// Тип "Yurs" в "textBoxName" надпись
        /// </summary>
        public string UITextBoxNameEditText = "Yurs";
        #endregion
    }
    
    /// <summary>
    /// Параметры для передачи в "ChangeYearMethod"
    /// </summary>
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class ChangeYearMethodParams
    {
        
        #region Fields
        /// <summary>
        /// Тип "1994" в "textBoxYear" надпись
        /// </summary>
        public string UITextBoxYearEditText = "1994";
        #endregion
    }
    
    /// <summary>
    /// Параметры для передачи в "ChangeNameMethod"
    /// </summary>
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class ChangeNameMethodParams
    {
        
        #region Fields
        /// <summary>
        /// Тип "Yura" в "textBoxName" надпись
        /// </summary>
        public string UITextBoxNameEditText = "Yura";
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class UIForm1Window : WinWindow
    {
        
        public UIForm1Window()
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Form1";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public UILoadfromfileWindow UILoadfromfileWindow
        {
            get
            {
                if ((this.mUILoadfromfileWindow == null))
                {
                    this.mUILoadfromfileWindow = new UILoadfromfileWindow(this);
                }
                return this.mUILoadfromfileWindow;
            }
        }
        
        public UITextBoxNameWindow UITextBoxNameWindow
        {
            get
            {
                if ((this.mUITextBoxNameWindow == null))
                {
                    this.mUITextBoxNameWindow = new UITextBoxNameWindow(this);
                }
                return this.mUITextBoxNameWindow;
            }
        }
        
        public UISetWindow UISetWindow
        {
            get
            {
                if ((this.mUISetWindow == null))
                {
                    this.mUISetWindow = new UISetWindow(this);
                }
                return this.mUISetWindow;
            }
        }
        
        public UIWritetofileWindow UIWritetofileWindow
        {
            get
            {
                if ((this.mUIWritetofileWindow == null))
                {
                    this.mUIWritetofileWindow = new UIWritetofileWindow(this);
                }
                return this.mUIWritetofileWindow;
            }
        }
        
        public UINextWindow UINextWindow
        {
            get
            {
                if ((this.mUINextWindow == null))
                {
                    this.mUINextWindow = new UINextWindow(this);
                }
                return this.mUINextWindow;
            }
        }
        
        public UITextBoxYearWindow UITextBoxYearWindow
        {
            get
            {
                if ((this.mUITextBoxYearWindow == null))
                {
                    this.mUITextBoxYearWindow = new UITextBoxYearWindow(this);
                }
                return this.mUITextBoxYearWindow;
            }
        }
        
        public UISetWindow1 UISetWindow1
        {
            get
            {
                if ((this.mUISetWindow1 == null))
                {
                    this.mUISetWindow1 = new UISetWindow1(this);
                }
                return this.mUISetWindow1;
            }
        }
        
        public UICalculateTarrifWindow UICalculateTarrifWindow
        {
            get
            {
                if ((this.mUICalculateTarrifWindow == null))
                {
                    this.mUICalculateTarrifWindow = new UICalculateTarrifWindow(this);
                }
                return this.mUICalculateTarrifWindow;
            }
        }
        
        public UIForm1TitleBar UIForm1TitleBar
        {
            get
            {
                if ((this.mUIForm1TitleBar == null))
                {
                    this.mUIForm1TitleBar = new UIForm1TitleBar(this);
                }
                return this.mUIForm1TitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UILoadfromfileWindow mUILoadfromfileWindow;
        
        private UITextBoxNameWindow mUITextBoxNameWindow;
        
        private UISetWindow mUISetWindow;
        
        private UIWritetofileWindow mUIWritetofileWindow;
        
        private UINextWindow mUINextWindow;
        
        private UITextBoxYearWindow mUITextBoxYearWindow;
        
        private UISetWindow1 mUISetWindow1;
        
        private UICalculateTarrifWindow mUICalculateTarrifWindow;
        
        private UIForm1TitleBar mUIForm1TitleBar;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class UILoadfromfileWindow : WinWindow
    {
        
        public UILoadfromfileWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "buttonLoad";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinButton UILoadfromfileButton
        {
            get
            {
                if ((this.mUILoadfromfileButton == null))
                {
                    this.mUILoadfromfileButton = new WinButton(this);
                    #region Условия поиска
                    this.mUILoadfromfileButton.SearchProperties[WinButton.PropertyNames.Name] = "Load from file";
                    this.mUILoadfromfileButton.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUILoadfromfileButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUILoadfromfileButton;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class UITextBoxNameWindow : WinWindow
    {
        
        public UITextBoxNameWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "textBoxName";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinEdit UITextBoxNameEdit
        {
            get
            {
                if ((this.mUITextBoxNameEdit == null))
                {
                    this.mUITextBoxNameEdit = new WinEdit(this);
                    #region Условия поиска
                    this.mUITextBoxNameEdit.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUITextBoxNameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITextBoxNameEdit;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class UISetWindow : WinWindow
    {
        
        public UISetWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "buttonSetName";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinButton UISetButton
        {
            get
            {
                if ((this.mUISetButton == null))
                {
                    this.mUISetButton = new WinButton(this);
                    #region Условия поиска
                    this.mUISetButton.SearchProperties[WinButton.PropertyNames.Name] = "Set";
                    this.mUISetButton.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUISetButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISetButton;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class UIWritetofileWindow : WinWindow
    {
        
        public UIWritetofileWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "buttonWrite";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinButton UIWritetofileButton
        {
            get
            {
                if ((this.mUIWritetofileButton == null))
                {
                    this.mUIWritetofileButton = new WinButton(this);
                    #region Условия поиска
                    this.mUIWritetofileButton.SearchProperties[WinButton.PropertyNames.Name] = "Write to file";
                    this.mUIWritetofileButton.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUIWritetofileButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIWritetofileButton;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class UINextWindow : WinWindow
    {
        
        public UINextWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "buttonNext";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinButton UINextButton
        {
            get
            {
                if ((this.mUINextButton == null))
                {
                    this.mUINextButton = new WinButton(this);
                    #region Условия поиска
                    this.mUINextButton.SearchProperties[WinButton.PropertyNames.Name] = "Next >>";
                    this.mUINextButton.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUINextButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUINextButton;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class UITextBoxYearWindow : WinWindow
    {
        
        public UITextBoxYearWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "textBoxYear";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinEdit UITextBoxYearEdit
        {
            get
            {
                if ((this.mUITextBoxYearEdit == null))
                {
                    this.mUITextBoxYearEdit = new WinEdit(this);
                    #region Условия поиска
                    this.mUITextBoxYearEdit.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUITextBoxYearEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITextBoxYearEdit;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class UISetWindow1 : WinWindow
    {
        
        public UISetWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "buttonSetYear";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinButton UISetButton
        {
            get
            {
                if ((this.mUISetButton == null))
                {
                    this.mUISetButton = new WinButton(this);
                    #region Условия поиска
                    this.mUISetButton.SearchProperties[WinButton.PropertyNames.Name] = "Set";
                    this.mUISetButton.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUISetButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISetButton;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class UICalculateTarrifWindow : WinWindow
    {
        
        public UICalculateTarrifWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "button1";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinButton UICalculateTarrifButton
        {
            get
            {
                if ((this.mUICalculateTarrifButton == null))
                {
                    this.mUICalculateTarrifButton = new WinButton(this);
                    #region Условия поиска
                    this.mUICalculateTarrifButton.SearchProperties[WinButton.PropertyNames.Name] = "Calculate Tarrif";
                    this.mUICalculateTarrifButton.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUICalculateTarrifButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICalculateTarrifButton;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class UIForm1TitleBar : WinTitleBar
    {
        
        public UIForm1TitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinButton UIЗакрытьButton
        {
            get
            {
                if ((this.mUIЗакрытьButton == null))
                {
                    this.mUIЗакрытьButton = new WinButton(this);
                    #region Условия поиска
                    this.mUIЗакрытьButton.SearchProperties[WinButton.PropertyNames.Name] = "Закрыть";
                    this.mUIЗакрытьButton.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUIЗакрытьButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIЗакрытьButton;
        #endregion
    }
}