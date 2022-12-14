using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace OpenSeaBot
{
    
    internal static class MainPageElements 
    {
        public static string myAccountUrl = "https://opensea.io/account";
        public static string floorPrice;
        public static string bestOffer;
        public static string pattern;
        public static string floorNumberValue;
        public static double floorNumber;
        public static double mySellNumber;
        public static string mySellNumberWhenAlreadyNftForSaleValue;
        public static double mySellNumberWhenAlreadyNftForSaleNumber;
        public static double myPreviousOfferNumber = 0;
        public static string ethlizardCollection = "https://opensea.io/collection/ethlizards";
        public static string spellfireCollection = "https://opensea.io/collection/spellfire";
        public static bool isVisible;
        public static bool isSellButtonVisible;
        public static string extensionPath = "C:/Users/aspar/AppData/Local/Google/Chrome/User Data/Default/Extensions/nkbihfbeogaeaoehlefnkodbefgpgknn/10.17.0_0.crx";
        public static double bestOfferNumber;
        public static string myOfferNumberString;
        public static bool isNotEnoughWeth;
        public static By makeCollectionOfferButton = By.XPath("//span[text()='Make collection offer']");
        public static By getStarted = By.XPath("//button[text()='Get Started']");
        public static By importWallet = By.XPath("//button[text()='Import wallet']");
        public static By noThanks = By.XPath("//button[text()='No Thanks']");
        public static By word1 = By.XPath("//input[@id='import-srp__srp-word-0']");
        public static By word2 = By.XPath("//input[@id='import-srp__srp-word-1']");
        public static By word3 = By.XPath("//input[@id='import-srp__srp-word-2']");
        public static By word4 = By.XPath("//input[@id='import-srp__srp-word-3']");
        public static By word5 = By.XPath("//input[@id='import-srp__srp-word-4']");
        public static By word6 = By.XPath("//input[@id='import-srp__srp-word-5']");
        public static By word7 = By.XPath("//input[@id='import-srp__srp-word-6']");
        public static By word8 = By.XPath("//input[@id='import-srp__srp-word-7']");
        public static By word9 = By.XPath("//input[@id='import-srp__srp-word-8']");
        public static By word10 = By.XPath("//input[@id='import-srp__srp-word-9']");
        public static By word11 = By.XPath("//input[@id='import-srp__srp-word-10']");
        public static By word12 = By.XPath("//input[@id='import-srp__srp-word-11']");
        public static By password = By.XPath("//input[@id='password']");
        public static By passwordConfirm = By.XPath("//input[@id='confirm-password']");
        public static By termsOfUse = By.XPath("//input[@id='create-new-vault__terms-checkbox']");
        public static By import = By.XPath("//button[text()='Import']");
        public static By allDone = By.XPath("//button[text()='All Done']");
        public static By metamaskButton = By.XPath("//span[text()='MetaMask']");
        public static By nextMetamask = By.XPath("//button[text()='Next']");
        public static By connectMetamask = By.XPath("//button[text()='Connect']");
        public static By amountField = By.XPath("//input[@name='pricePerUnit']");
        public static By makeOfferButton = By.XPath("//button[text()='Make offer']");
        public static By confirmMetamaskButton = By.XPath("//button[text()='Confirm']");
        public static By signMetamaskButton = By.XPath("//button[text()='Sign']");
        public static By downArrowMetamask = By.XPath("//i[@title='Scroll down']");
        public static By ethlizardNFT = By.XPath("//div[text()='Ethlizards']");
        public static By spellfireNFT = By.XPath("//div[text()='SPELLFIRE']");
        public static By spellfireNFTWhole = By.XPath("//div[@class='sc-1xf18x6-0 sc-dw611d-0 hocRfR bhhJtZ']");
        public static By sellButton = By.XPath("//a[text()='Sell']");
        public static By collectionLink = By.XPath("//a[@class='sc-1pie21o-0 elyzfO CollectionLink--link']");
        public static By sellPriceField = By.XPath("//input[@id='price']");
        public static By completeListingButton = By.XPath("//button[text()='Complete listing']");
        public static By ethlizardNftToBeClicked = By.XPath("//div[contains(normalize-space(text()), 'Ethlizards #')]");
        public static By notEnoughWethMessage = By.XPath("//span[@class='sc-1xf18x6-0 sc-1aqfqq9-0 sc-13us3ky-0 jUxJqB ehcRoB fwzwmC']");
        public static By addWethButton = By.XPath("//button[@class='sc-1xf18x6-0 sc-glfma3-0 jPlHEK ldKPky']");
        public static By wrapEthButton = By.XPath("//div[@class='type__TextWrapper-sc-16386l-0 type__TransitionTextWrapper-sc-16386l-1 iLOGtN krBtbX button button-large css-oldlf1']");
        public static By confirmButtonMetamask = By.XPath("//button[@class='button btn--rounded btn-primary page-container__footer-button']");
        public static By lowerPriceButton = By.XPath("//button[text()='Lower price']");
        public static By inputFieldLowerPrice = By.XPath("//input[@id='newAmount']");
        public static By setNewPriceButton = By.XPath("//button[text()='Set new price']");
        public static By spellfireNftToBeClicked = By.XPath("//div[@class='sc-1xf18x6-0 sc-dw611d-0 hocRfR bhhJtZ']");
        public static By isCollectionReviewed = By.XPath("//div[@class='sc-1xf18x6-0 sc-1aqfqq9-0 haVRLx dqAHVz CollectionDetailsModal--details-header']");
        public static By checkBoxReviewedCollection = By.XPath("//input[@id='review-confirmation']");
        public static string bestOfferNumberValue;
        public static double myOfferNumber;
        public static bool isUnreviewedCollection;
        public static By offerPeriodDownArrow = By.XPath("//div[@class='sc-1xf18x6-0 ttmcH']//i[@class='sc-1gugx8q-0 dKJrxr material-icons']");
        public static By offerPeriodTwelveHours = By.XPath("//div[@class='tippy-content']//span[text()='12 hours']");
        public static double maxOfferNumber;

    }
}
