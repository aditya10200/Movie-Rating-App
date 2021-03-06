﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 16.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace MovieRatingCodedUi
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
    
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Testing Home
        /// </summary>
        public void AssertMethod1()
        {
            #region Variable Declarations
            WinText uIHomePageMovieRatingWText = this.UIHomePageMovieRatingWWindow.UIHomeHyperlink.UIHomePageMovieRatingWText;
            #endregion

            // Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' label equals 'Home'
            Assert.AreEqual(this.AssertMethod1ExpectedValues.UIHomePageMovieRatingWTextName, uIHomePageMovieRatingWText.Name, "Solution should be Home, otherwise error");
        }
        
        /// <summary>
        /// Testing Movies
        /// </summary>
        public void AssertMethod2()
        {
            #region Variable Declarations
            WinControl uIHomePageMovieRatingWMenuButton = this.UIHomePageMovieRatingWWindow.UIItemListItem.UIHomePageMovieRatingWMenuButton;
            #endregion

            // Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' MenuButton equals 'Movies'
            Assert.AreEqual(this.AssertMethod2ExpectedValues.UIHomePageMovieRatingWMenuButtonName, uIHomePageMovieRatingWMenuButton.Name, "Solution should be Movies, otherwise error");
        }
        
        /// <summary>
        /// Testing Genres
        /// </summary>
        public void AssertMethod3()
        {
            #region Variable Declarations
            WinControl uIHomePageMovieRatingWMenuButton1 = this.UIHomePageMovieRatingWWindow.UIItemListItem.UIHomePageMovieRatingWMenuButton1;
            #endregion

            // Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' MenuButton equals 'Genres'
            Assert.AreEqual(this.AssertMethod3ExpectedValues.UIHomePageMovieRatingWMenuButton1Name, uIHomePageMovieRatingWMenuButton1.Name, "Solution should be Genres, otherwise error");
        }
        
        /// <summary>
        /// Testing Actors
        /// </summary>
        public void AssertMethod4()
        {
            #region Variable Declarations
            WinControl uIHomePageMovieRatingWMenuButton2 = this.UIHomePageMovieRatingWWindow.UIItemListItem.UIHomePageMovieRatingWMenuButton2;
            #endregion

            // Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' MenuButton equals 'Actors'
            Assert.AreEqual(this.AssertMethod4ExpectedValues.UIHomePageMovieRatingWMenuButton2Name, uIHomePageMovieRatingWMenuButton2.Name, "Solution should be Actors, otherwise error");
        }
        
        /// <summary>
        /// Testing Director
        /// </summary>
        public void AssertMethod5()
        {
            #region Variable Declarations
            WinControl uIHomePageMovieRatingWMenuButton3 = this.UIHomePageMovieRatingWWindow.UIItemListItem.UIHomePageMovieRatingWMenuButton3;
            #endregion

            // Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' MenuButton equals 'Director'
            Assert.AreEqual(this.AssertMethod5ExpectedValues.UIHomePageMovieRatingWMenuButton3Name, uIHomePageMovieRatingWMenuButton3.Name, "Solution should be Director, otherwise error");
        }
        
        /// <summary>
        /// Testing Help
        /// </summary>
        public void AssertMethod6()
        {
            #region Variable Declarations
            WinText uIHomePageMovieRatingWText = this.UIHomePageMovieRatingWWindow.UIHelpHyperlink.UIHomePageMovieRatingWText;
            #endregion

            // Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' label equals 'Help'
            Assert.AreEqual(this.AssertMethod6ExpectedValues.UIHomePageMovieRatingWTextName, uIHomePageMovieRatingWText.Name, "Solution should be Help, otherwise error");
        }
        
        /// <summary>
        /// Testing Home
        /// </summary>
        public void AssertMethod7()
        {
            #region Variable Declarations
            WinText uIHomePageMovieRatingWText = this.UIHomePageMovieRatingWWindow.UIMovieRatingWebAppHyperlink.UIHomePageMovieRatingWText;
            #endregion

            // Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' label equals 'MovieRatingWebApp'
            Assert.AreEqual(this.AssertMethod7ExpectedValues.UIHomePageMovieRatingWTextName, uIHomePageMovieRatingWText.Name, "Solution should be Home, otherwise error");
        }
        
        /// <summary>
        /// Testing Register
        /// </summary>
        public void AssertMethod8()
        {
            #region Variable Declarations
            WinText uIHomePageMovieRatingWText = this.UIHomePageMovieRatingWWindow.UIRegisterHyperlink.UIHomePageMovieRatingWText;
            #endregion

            // Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' label equals 'Register'
            Assert.AreEqual(this.AssertMethod8ExpectedValues.UIHomePageMovieRatingWTextName, uIHomePageMovieRatingWText.Name, "Solution should be Register, otherwise error");
        }
        
        /// <summary>
        /// Tetsing Login
        /// </summary>
        public void AssertMethod9()
        {
            #region Variable Declarations
            WinText uIHomePageMovieRatingWText = this.UIHomePageMovieRatingWWindow.UILoginHyperlink.UIHomePageMovieRatingWText;
            #endregion

            // Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' label equals 'Log in'
            Assert.AreEqual(this.AssertMethod9ExpectedValues.UIHomePageMovieRatingWTextName, uIHomePageMovieRatingWText.Name, "Solution should be Login, otherwisee error");
        }
        
        #region Properties
        public virtual AssertMethod1ExpectedValues AssertMethod1ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod1ExpectedValues == null))
                {
                    this.mAssertMethod1ExpectedValues = new AssertMethod1ExpectedValues();
                }
                return this.mAssertMethod1ExpectedValues;
            }
        }
        
        public virtual AssertMethod2ExpectedValues AssertMethod2ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod2ExpectedValues == null))
                {
                    this.mAssertMethod2ExpectedValues = new AssertMethod2ExpectedValues();
                }
                return this.mAssertMethod2ExpectedValues;
            }
        }
        
        public virtual AssertMethod3ExpectedValues AssertMethod3ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod3ExpectedValues == null))
                {
                    this.mAssertMethod3ExpectedValues = new AssertMethod3ExpectedValues();
                }
                return this.mAssertMethod3ExpectedValues;
            }
        }
        
        public virtual AssertMethod4ExpectedValues AssertMethod4ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod4ExpectedValues == null))
                {
                    this.mAssertMethod4ExpectedValues = new AssertMethod4ExpectedValues();
                }
                return this.mAssertMethod4ExpectedValues;
            }
        }
        
        public virtual AssertMethod5ExpectedValues AssertMethod5ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod5ExpectedValues == null))
                {
                    this.mAssertMethod5ExpectedValues = new AssertMethod5ExpectedValues();
                }
                return this.mAssertMethod5ExpectedValues;
            }
        }
        
        public virtual AssertMethod6ExpectedValues AssertMethod6ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod6ExpectedValues == null))
                {
                    this.mAssertMethod6ExpectedValues = new AssertMethod6ExpectedValues();
                }
                return this.mAssertMethod6ExpectedValues;
            }
        }
        
        public virtual AssertMethod7ExpectedValues AssertMethod7ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod7ExpectedValues == null))
                {
                    this.mAssertMethod7ExpectedValues = new AssertMethod7ExpectedValues();
                }
                return this.mAssertMethod7ExpectedValues;
            }
        }
        
        public virtual AssertMethod8ExpectedValues AssertMethod8ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod8ExpectedValues == null))
                {
                    this.mAssertMethod8ExpectedValues = new AssertMethod8ExpectedValues();
                }
                return this.mAssertMethod8ExpectedValues;
            }
        }
        
        public virtual AssertMethod9ExpectedValues AssertMethod9ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod9ExpectedValues == null))
                {
                    this.mAssertMethod9ExpectedValues = new AssertMethod9ExpectedValues();
                }
                return this.mAssertMethod9ExpectedValues;
            }
        }
        
        public UIHomePageMovieRatingWWindow UIHomePageMovieRatingWWindow
        {
            get
            {
                if ((this.mUIHomePageMovieRatingWWindow == null))
                {
                    this.mUIHomePageMovieRatingWWindow = new UIHomePageMovieRatingWWindow();
                }
                return this.mUIHomePageMovieRatingWWindow;
            }
        }
        #endregion
        
        #region Fields
        private AssertMethod1ExpectedValues mAssertMethod1ExpectedValues;
        
        private AssertMethod2ExpectedValues mAssertMethod2ExpectedValues;
        
        private AssertMethod3ExpectedValues mAssertMethod3ExpectedValues;
        
        private AssertMethod4ExpectedValues mAssertMethod4ExpectedValues;
        
        private AssertMethod5ExpectedValues mAssertMethod5ExpectedValues;
        
        private AssertMethod6ExpectedValues mAssertMethod6ExpectedValues;
        
        private AssertMethod7ExpectedValues mAssertMethod7ExpectedValues;
        
        private AssertMethod8ExpectedValues mAssertMethod8ExpectedValues;
        
        private AssertMethod9ExpectedValues mAssertMethod9ExpectedValues;
        
        private UIHomePageMovieRatingWWindow mUIHomePageMovieRatingWWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class AssertMethod1ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' label equals 'Home'
        /// </summary>
        public string UIHomePageMovieRatingWTextName = "Home";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod2'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class AssertMethod2ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' MenuButton equals 'Movies'
        /// </summary>
        public string UIHomePageMovieRatingWMenuButtonName = "Movies";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod3'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class AssertMethod3ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' MenuButton equals 'Genres'
        /// </summary>
        public string UIHomePageMovieRatingWMenuButton1Name = "Genres";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod4'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class AssertMethod4ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' MenuButton equals 'Actors'
        /// </summary>
        public string UIHomePageMovieRatingWMenuButton2Name = "Actors";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod5'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class AssertMethod5ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' MenuButton equals 'Director'
        /// </summary>
        public string UIHomePageMovieRatingWMenuButton3Name = "Director";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod6'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class AssertMethod6ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' label equals 'Help'
        /// </summary>
        public string UIHomePageMovieRatingWTextName = "Help";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod7'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class AssertMethod7ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' label equals 'MovieRatingWebApp'
        /// </summary>
        public string UIHomePageMovieRatingWTextName = "MovieRatingWebApp";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod8'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class AssertMethod8ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' label equals 'Register'
        /// </summary>
        public string UIHomePageMovieRatingWTextName = "Register";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod9'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class AssertMethod9ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Home Page - Movie Rating Web App - Google Chrome' label equals 'Log in'
        /// </summary>
        public string UIHomePageMovieRatingWTextName = "Log in";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UIHomePageMovieRatingWWindow : WinWindow
    {
        
        public UIHomePageMovieRatingWWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Home Page - Movie Rating Web App - Google Chrome";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Chrome_WidgetWin_1";
            this.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
            #endregion
        }
        
        #region Properties
        public UIHomeHyperlink UIHomeHyperlink
        {
            get
            {
                if ((this.mUIHomeHyperlink == null))
                {
                    this.mUIHomeHyperlink = new UIHomeHyperlink(this);
                }
                return this.mUIHomeHyperlink;
            }
        }
        
        public UIItemListItem UIItemListItem
        {
            get
            {
                if ((this.mUIItemListItem == null))
                {
                    this.mUIItemListItem = new UIItemListItem(this);
                }
                return this.mUIItemListItem;
            }
        }
        
        public UIHelpHyperlink UIHelpHyperlink
        {
            get
            {
                if ((this.mUIHelpHyperlink == null))
                {
                    this.mUIHelpHyperlink = new UIHelpHyperlink(this);
                }
                return this.mUIHelpHyperlink;
            }
        }
        
        public UIMovieRatingWebAppHyperlink UIMovieRatingWebAppHyperlink
        {
            get
            {
                if ((this.mUIMovieRatingWebAppHyperlink == null))
                {
                    this.mUIMovieRatingWebAppHyperlink = new UIMovieRatingWebAppHyperlink(this);
                }
                return this.mUIMovieRatingWebAppHyperlink;
            }
        }
        
        public UIRegisterHyperlink UIRegisterHyperlink
        {
            get
            {
                if ((this.mUIRegisterHyperlink == null))
                {
                    this.mUIRegisterHyperlink = new UIRegisterHyperlink(this);
                }
                return this.mUIRegisterHyperlink;
            }
        }
        
        public UILoginHyperlink UILoginHyperlink
        {
            get
            {
                if ((this.mUILoginHyperlink == null))
                {
                    this.mUILoginHyperlink = new UILoginHyperlink(this);
                }
                return this.mUILoginHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private UIHomeHyperlink mUIHomeHyperlink;
        
        private UIItemListItem mUIItemListItem;
        
        private UIHelpHyperlink mUIHelpHyperlink;
        
        private UIMovieRatingWebAppHyperlink mUIMovieRatingWebAppHyperlink;
        
        private UIRegisterHyperlink mUIRegisterHyperlink;
        
        private UILoginHyperlink mUILoginHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UIHomeHyperlink : WinHyperlink
    {
        
        public UIHomeHyperlink(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinHyperlink.PropertyNames.Name] = "Home";
            this.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
            #endregion
        }
        
        #region Properties
        public WinText UIHomePageMovieRatingWText
        {
            get
            {
                if ((this.mUIHomePageMovieRatingWText == null))
                {
                    this.mUIHomePageMovieRatingWText = new WinText(this);
                    #region Search Criteria
                    this.mUIHomePageMovieRatingWText.SearchProperties[WinText.PropertyNames.Name] = "Home";
                    this.mUIHomePageMovieRatingWText.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
                    #endregion
                }
                return this.mUIHomePageMovieRatingWText;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIHomePageMovieRatingWText;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UIItemListItem : WinListItem
    {
        
        public UIItemListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
            #endregion
        }
        
        #region Properties
        public WinControl UIHomePageMovieRatingWMenuButton
        {
            get
            {
                if ((this.mUIHomePageMovieRatingWMenuButton == null))
                {
                    this.mUIHomePageMovieRatingWMenuButton = new WinControl(this);
                    #region Search Criteria
                    this.mUIHomePageMovieRatingWMenuButton.SearchProperties[UITestControl.PropertyNames.Name] = "Movies";
                    this.mUIHomePageMovieRatingWMenuButton.SearchProperties[UITestControl.PropertyNames.ControlType] = "MenuButton";
                    this.mUIHomePageMovieRatingWMenuButton.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
                    #endregion
                }
                return this.mUIHomePageMovieRatingWMenuButton;
            }
        }
        
        public WinControl UIHomePageMovieRatingWMenuButton1
        {
            get
            {
                if ((this.mUIHomePageMovieRatingWMenuButton1 == null))
                {
                    this.mUIHomePageMovieRatingWMenuButton1 = new WinControl(this);
                    #region Search Criteria
                    this.mUIHomePageMovieRatingWMenuButton1.SearchProperties[UITestControl.PropertyNames.Name] = "Genres";
                    this.mUIHomePageMovieRatingWMenuButton1.SearchProperties[UITestControl.PropertyNames.ControlType] = "MenuButton";
                    this.mUIHomePageMovieRatingWMenuButton1.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
                    #endregion
                }
                return this.mUIHomePageMovieRatingWMenuButton1;
            }
        }
        
        public WinControl UIHomePageMovieRatingWMenuButton2
        {
            get
            {
                if ((this.mUIHomePageMovieRatingWMenuButton2 == null))
                {
                    this.mUIHomePageMovieRatingWMenuButton2 = new WinControl(this);
                    #region Search Criteria
                    this.mUIHomePageMovieRatingWMenuButton2.SearchProperties[UITestControl.PropertyNames.Name] = "Actors";
                    this.mUIHomePageMovieRatingWMenuButton2.SearchProperties[UITestControl.PropertyNames.ControlType] = "MenuButton";
                    this.mUIHomePageMovieRatingWMenuButton2.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
                    #endregion
                }
                return this.mUIHomePageMovieRatingWMenuButton2;
            }
        }
        
        public WinControl UIHomePageMovieRatingWMenuButton3
        {
            get
            {
                if ((this.mUIHomePageMovieRatingWMenuButton3 == null))
                {
                    this.mUIHomePageMovieRatingWMenuButton3 = new WinControl(this);
                    #region Search Criteria
                    this.mUIHomePageMovieRatingWMenuButton3.SearchProperties[UITestControl.PropertyNames.Name] = "Director";
                    this.mUIHomePageMovieRatingWMenuButton3.SearchProperties[UITestControl.PropertyNames.ControlType] = "MenuButton";
                    this.mUIHomePageMovieRatingWMenuButton3.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
                    #endregion
                }
                return this.mUIHomePageMovieRatingWMenuButton3;
            }
        }
        #endregion
        
        #region Fields
        private WinControl mUIHomePageMovieRatingWMenuButton;
        
        private WinControl mUIHomePageMovieRatingWMenuButton1;
        
        private WinControl mUIHomePageMovieRatingWMenuButton2;
        
        private WinControl mUIHomePageMovieRatingWMenuButton3;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UIHelpHyperlink : WinHyperlink
    {
        
        public UIHelpHyperlink(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinHyperlink.PropertyNames.Name] = "Help";
            this.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
            #endregion
        }
        
        #region Properties
        public WinText UIHomePageMovieRatingWText
        {
            get
            {
                if ((this.mUIHomePageMovieRatingWText == null))
                {
                    this.mUIHomePageMovieRatingWText = new WinText(this);
                    #region Search Criteria
                    this.mUIHomePageMovieRatingWText.SearchProperties[WinText.PropertyNames.Name] = "Help";
                    this.mUIHomePageMovieRatingWText.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
                    #endregion
                }
                return this.mUIHomePageMovieRatingWText;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIHomePageMovieRatingWText;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UIMovieRatingWebAppHyperlink : WinHyperlink
    {
        
        public UIMovieRatingWebAppHyperlink(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinHyperlink.PropertyNames.Name] = "MovieRatingWebApp";
            this.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
            #endregion
        }
        
        #region Properties
        public WinText UIHomePageMovieRatingWText
        {
            get
            {
                if ((this.mUIHomePageMovieRatingWText == null))
                {
                    this.mUIHomePageMovieRatingWText = new WinText(this);
                    #region Search Criteria
                    this.mUIHomePageMovieRatingWText.SearchProperties[WinText.PropertyNames.Name] = "MovieRatingWebApp";
                    this.mUIHomePageMovieRatingWText.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
                    #endregion
                }
                return this.mUIHomePageMovieRatingWText;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIHomePageMovieRatingWText;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UIRegisterHyperlink : WinHyperlink
    {
        
        public UIRegisterHyperlink(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinHyperlink.PropertyNames.Name] = "Register";
            this.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
            #endregion
        }
        
        #region Properties
        public WinText UIHomePageMovieRatingWText
        {
            get
            {
                if ((this.mUIHomePageMovieRatingWText == null))
                {
                    this.mUIHomePageMovieRatingWText = new WinText(this);
                    #region Search Criteria
                    this.mUIHomePageMovieRatingWText.SearchProperties[WinText.PropertyNames.Name] = "Register";
                    this.mUIHomePageMovieRatingWText.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
                    #endregion
                }
                return this.mUIHomePageMovieRatingWText;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIHomePageMovieRatingWText;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class UILoginHyperlink : WinHyperlink
    {
        
        public UILoginHyperlink(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinHyperlink.PropertyNames.Name] = "Log in";
            this.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
            #endregion
        }
        
        #region Properties
        public WinText UIHomePageMovieRatingWText
        {
            get
            {
                if ((this.mUIHomePageMovieRatingWText == null))
                {
                    this.mUIHomePageMovieRatingWText = new WinText(this);
                    #region Search Criteria
                    this.mUIHomePageMovieRatingWText.SearchProperties[WinText.PropertyNames.Name] = "Log in";
                    this.mUIHomePageMovieRatingWText.WindowTitles.Add("Home Page - Movie Rating Web App - Google Chrome");
                    #endregion
                }
                return this.mUIHomePageMovieRatingWText;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIHomePageMovieRatingWText;
        #endregion
    }
}
