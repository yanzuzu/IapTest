using UnityEngine;
using System.Collections;
using Soomla.Store;

public class GameStoreIAP:IStoreAssets {
	//Update the 0 if you add more avaialbe items later, or else you will get errors.
	
	public int GetVersion() {
		return 0;
	}
	
	public VirtualCurrency[] GetCurrencies ()
	{
		return new VirtualCurrency[]{};
	}
	public VirtualGood[] GetGoods ()
	{
		return new VirtualGood[] {TEST_ITEM_VG};
	}
	public VirtualCurrencyPack[] GetCurrencyPacks ()
	{
		return new VirtualCurrencyPack[] {};
	}
	public VirtualCategory[] GetCategories ()
	{
		return new VirtualCategory[] {};
	}
	public VirtualGood[] GetNonConsumableItems ()
	{
		return new VirtualGood[]{TEST_ITEM_VG};
	}
	
	
	#if UNITY_ANDROID
	public const string TEST_ITEM = "samlo.iaptest.item1";
	#elif UNITY_IPHONE
	public const string TEST_ITEM = "samlo.iaptest.item1";
	#endif
	
	public static VirtualGood TEST_ITEM_VG = new LifetimeVG(
		"TestItem",
		"This is for test",
		TEST_ITEM,
		new PurchaseWithMarket (TEST_ITEM, 0 )
		);
	

}