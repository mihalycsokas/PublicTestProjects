﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DynamicsOdataTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ChartOfAccountsConfigurationFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "ChartOfAccountsConfiguration.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ChartOfAccountsConfiguration", "\tIn order to verify each deployment is consistent\r\n\tAnd ensure that minimum requi" +
                    "red accounting elements are present\r\n\tto avoid testing new features before manua" +
                    "l configurations have been completed", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "ChartOfAccountsConfiguration")))
            {
                global::DynamicsOdataTests.ChartOfAccountsConfigurationFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void RequiredGLAccountsExist(string accountName, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Required GL Accounts exist", null, exampleTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given("the \'MainAccounts\' have been created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("we look at the \'Name\' key", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then(string.Format("{0} should match", accountName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Cash Advance Returns")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Cash Advance Returns")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Cash Advance Returns")]
        public virtual void RequiredGLAccountsExist_CashAdvanceReturns()
        {
#line 7
this.RequiredGLAccountsExist("Cash Advance Returns", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Bank Account - USD")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Bank Account - USD")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Bank Account - USD")]
        public virtual void RequiredGLAccountsExist_BankAccount_USD()
        {
#line 7
this.RequiredGLAccountsExist("Bank Account - USD", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Bank Account - CNY")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Bank Account - CNY")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Bank Account - CNY")]
        public virtual void RequiredGLAccountsExist_BankAccount_CNY()
        {
#line 7
this.RequiredGLAccountsExist("Bank Account - CNY", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Bank Account - EUR")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Bank Account - EUR")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Bank Account - EUR")]
        public virtual void RequiredGLAccountsExist_BankAccount_EUR()
        {
#line 7
this.RequiredGLAccountsExist("Bank Account - EUR", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Bank Account - RUB")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Bank Account - RUB")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Bank Account - RUB")]
        public virtual void RequiredGLAccountsExist_BankAccount_RUB()
        {
#line 7
this.RequiredGLAccountsExist("Bank Account - RUB", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Bank Account - GBP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Bank Account - GBP")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Bank Account - GBP")]
        public virtual void RequiredGLAccountsExist_BankAccount_GBP()
        {
#line 7
this.RequiredGLAccountsExist("Bank Account - GBP", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: USD Cash Advances Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "USD Cash Advances Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "USD Cash Advances Account")]
        public virtual void RequiredGLAccountsExist_USDCashAdvancesAccount()
        {
#line 7
this.RequiredGLAccountsExist("USD Cash Advances Account", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: EUR Cash Advances Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "EUR Cash Advances Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "EUR Cash Advances Account")]
        public virtual void RequiredGLAccountsExist_EURCashAdvancesAccount()
        {
#line 7
this.RequiredGLAccountsExist("EUR Cash Advances Account", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: CAD Cash Advances Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CAD Cash Advances Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "CAD Cash Advances Account")]
        public virtual void RequiredGLAccountsExist_CADCashAdvancesAccount()
        {
#line 7
this.RequiredGLAccountsExist("CAD Cash Advances Account", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Yuan Cash Advances Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Yuan Cash Advances Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Yuan Cash Advances Account")]
        public virtual void RequiredGLAccountsExist_YuanCashAdvancesAccount()
        {
#line 7
this.RequiredGLAccountsExist("Yuan Cash Advances Account", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: All Other Cash Advances Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "All Other Cash Advances Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "All Other Cash Advances Account")]
        public virtual void RequiredGLAccountsExist_AllOtherCashAdvancesAccount()
        {
#line 7
this.RequiredGLAccountsExist("All Other Cash Advances Account", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Bank Account - Payroll")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Bank Account - Payroll")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Bank Account - Payroll")]
        public virtual void RequiredGLAccountsExist_BankAccount_Payroll()
        {
#line 7
this.RequiredGLAccountsExist("Bank Account - Payroll", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Cash in bank - US (Fixed asset purch)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Cash in bank - US (Fixed asset purch)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Cash in bank - US (Fixed asset purch)")]
        public virtual void RequiredGLAccountsExist_CashInBank_USFixedAssetPurch()
        {
#line 7
this.RequiredGLAccountsExist("Cash in bank - US (Fixed asset purch)", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Petty Cash")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Petty Cash")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Petty Cash")]
        public virtual void RequiredGLAccountsExist_PettyCash()
        {
#line 7
this.RequiredGLAccountsExist("Petty Cash", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: TOTAL CASH & CASH EQUIVALENTS")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "TOTAL CASH & CASH EQUIVALENTS")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "TOTAL CASH & CASH EQUIVALENTS")]
        public virtual void RequiredGLAccountsExist_TOTALCASHCASHEQUIVALENTS()
        {
#line 7
this.RequiredGLAccountsExist("TOTAL CASH & CASH EQUIVALENTS", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Bonds")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Bonds")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Bonds")]
        public virtual void RequiredGLAccountsExist_Bonds()
        {
#line 7
this.RequiredGLAccountsExist("Bonds", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Other Marketable Securities")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Other Marketable Securities")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Other Marketable Securities")]
        public virtual void RequiredGLAccountsExist_OtherMarketableSecurities()
        {
#line 7
this.RequiredGLAccountsExist("Other Marketable Securities", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Bill of Exchange (BOE)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Bill of Exchange (BOE)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Bill of Exchange (BOE)")]
        public virtual void RequiredGLAccountsExist_BillOfExchangeBOE()
        {
#line 7
this.RequiredGLAccountsExist("Bill of Exchange (BOE)", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: BOE Remitted for Collection")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "BOE Remitted for Collection")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "BOE Remitted for Collection")]
        public virtual void RequiredGLAccountsExist_BOERemittedForCollection()
        {
#line 7
this.RequiredGLAccountsExist("BOE Remitted for Collection", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: BOE Remitted for Discount")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "BOE Remitted for Discount")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "BOE Remitted for Discount")]
        public virtual void RequiredGLAccountsExist_BOERemittedForDiscount()
        {
#line 7
this.RequiredGLAccountsExist("BOE Remitted for Discount", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Protested BOE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Protested BOE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Protested BOE")]
        public virtual void RequiredGLAccountsExist_ProtestedBOE()
        {
#line 7
this.RequiredGLAccountsExist("Protested BOE", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: TOTAL SECURITIES")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "TOTAL SECURITIES")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "TOTAL SECURITIES")]
        public virtual void RequiredGLAccountsExist_TOTALSECURITIES()
        {
#line 7
this.RequiredGLAccountsExist("TOTAL SECURITIES", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Accounts Receivable - Domestic")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Accounts Receivable - Domestic")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Accounts Receivable - Domestic")]
        public virtual void RequiredGLAccountsExist_AccountsReceivable_Domestic()
        {
#line 7
this.RequiredGLAccountsExist("Accounts Receivable - Domestic", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Accounts Receivable - Foreign")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Accounts Receivable - Foreign")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Accounts Receivable - Foreign")]
        public virtual void RequiredGLAccountsExist_AccountsReceivable_Foreign()
        {
#line 7
this.RequiredGLAccountsExist("Accounts Receivable - Foreign", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Accounts Receivable - Clearing")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Accounts Receivable - Clearing")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Accounts Receivable - Clearing")]
        public virtual void RequiredGLAccountsExist_AccountsReceivable_Clearing()
        {
#line 7
this.RequiredGLAccountsExist("Accounts Receivable - Clearing", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Inter-unit Receivable - Domestic")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Inter-unit Receivable - Domestic")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Inter-unit Receivable - Domestic")]
        public virtual void RequiredGLAccountsExist_Inter_UnitReceivable_Domestic()
        {
#line 7
this.RequiredGLAccountsExist("Inter-unit Receivable - Domestic", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Credit Card Receivable")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Credit Card Receivable")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Credit Card Receivable")]
        public virtual void RequiredGLAccountsExist_CreditCardReceivable()
        {
#line 7
this.RequiredGLAccountsExist("Credit Card Receivable", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Interest Receivable")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Interest Receivable")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Interest Receivable")]
        public virtual void RequiredGLAccountsExist_InterestReceivable()
        {
#line 7
this.RequiredGLAccountsExist("Interest Receivable", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Notes Receivable")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Notes Receivable")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Notes Receivable")]
        public virtual void RequiredGLAccountsExist_NotesReceivable()
        {
#line 7
this.RequiredGLAccountsExist("Notes Receivable", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Other Receivables")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Other Receivables")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Other Receivables")]
        public virtual void RequiredGLAccountsExist_OtherReceivables()
        {
#line 7
this.RequiredGLAccountsExist("Other Receivables", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: TOTAL ACCOUNTS RECEIVABLE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "TOTAL ACCOUNTS RECEIVABLE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "TOTAL ACCOUNTS RECEIVABLE")]
        public virtual void RequiredGLAccountsExist_TOTALACCOUNTSRECEIVABLE()
        {
#line 7
this.RequiredGLAccountsExist("TOTAL ACCOUNTS RECEIVABLE", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Prepaid Expenses")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Prepaid Expenses")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Prepaid Expenses")]
        public virtual void RequiredGLAccountsExist_PrepaidExpenses()
        {
#line 7
this.RequiredGLAccountsExist("Prepaid Expenses", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Prepaid Insurance")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Prepaid Insurance")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Prepaid Insurance")]
        public virtual void RequiredGLAccountsExist_PrepaidInsurance()
        {
#line 7
this.RequiredGLAccountsExist("Prepaid Insurance", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Advances")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Advances")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Advances")]
        public virtual void RequiredGLAccountsExist_Advances()
        {
#line 7
this.RequiredGLAccountsExist("Advances", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: Prepaid Commissions")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Prepaid Commissions")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "Prepaid Commissions")]
        public virtual void RequiredGLAccountsExist_PrepaidCommissions()
        {
#line 7
this.RequiredGLAccountsExist("Prepaid Commissions", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Required GL Accounts exist: TOTAL OTHER CURRENT ASSETS")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ChartOfAccountsConfiguration")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "TOTAL OTHER CURRENT ASSETS")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AccountName", "TOTAL OTHER CURRENT ASSETS")]
        public virtual void RequiredGLAccountsExist_TOTALOTHERCURRENTASSETS()
        {
#line 7
this.RequiredGLAccountsExist("TOTAL OTHER CURRENT ASSETS", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion