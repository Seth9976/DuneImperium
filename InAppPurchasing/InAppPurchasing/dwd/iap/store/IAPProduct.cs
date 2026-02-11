using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;

namespace dwd.iap.store
{
	// Token: 0x02000012 RID: 18
	public class IAPProduct : Object
	{
		// Token: 0x0600007C RID: 124 RVA: 0x000058CC File Offset: 0x00003ACC
		// Note: this type is marked as 'beforefieldinit'.
		static IAPProduct()
		{
			Il2CppClassPointerStore<IAPProduct>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "IAPProduct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr);
			IAPProduct.NativeFieldInfoPtr_cultureInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "cultureInfo");
			IAPProduct.NativeFieldInfoPtr_cultureCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "cultureCode");
			IAPProduct.NativeFieldInfoPtr_countryCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "countryCode");
			IAPProduct.NativeFieldInfoPtr_currencyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "currencyCode");
			IAPProduct.NativeFieldInfoPtr_PriceFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "PriceFormatter");
			IAPProduct.NativeFieldInfoPtr__CurrencySymbol_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "<CurrencySymbol>k__BackingField");
			IAPProduct.NativeFieldInfoPtr__ProductID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "<ProductID>k__BackingField");
			IAPProduct.NativeFieldInfoPtr_archetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "archetypeID");
			IAPProduct.NativeFieldInfoPtr__Label_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "<Label>k__BackingField");
			IAPProduct.NativeFieldInfoPtr__Description_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "<Description>k__BackingField");
			IAPProduct.NativeFieldInfoPtr__Price_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "<Price>k__BackingField");
			IAPProduct.NativeFieldInfoPtr__FormattedPrice_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "<FormattedPrice>k__BackingField");
			IAPProduct.NativeFieldInfoPtr__ProductType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "<ProductType>k__BackingField");
			IAPProduct.NativeFieldInfoPtr__Purchaseable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "<Purchaseable>k__BackingField");
			IAPProduct.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "<Status>k__BackingField");
			IAPProduct.NativeFieldInfoPtr__FailReason_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "<FailReason>k__BackingField");
			IAPProduct.NativeFieldInfoPtr__Receipt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "<Receipt>k__BackingField");
			IAPProduct.NativeFieldInfoPtr__PriceDisclaimer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "<PriceDisclaimer>k__BackingField");
			IAPProduct.NativeFieldInfoPtr__Tags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "<Tags>k__BackingField");
			IAPProduct.NativeFieldInfoPtr__Image_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "<Image>k__BackingField");
			IAPProduct.NativeFieldInfoPtr__Claimable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, "<Claimable>k__BackingField");
			IAPProduct.NativeMethodInfoPtr_get_CultureInformation_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663426);
			IAPProduct.NativeMethodInfoPtr_set_CultureInformation_Public_Static_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663427);
			IAPProduct.NativeMethodInfoPtr_get_CultureCode_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663428);
			IAPProduct.NativeMethodInfoPtr_set_CultureCode_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663429);
			IAPProduct.NativeMethodInfoPtr_get_CountryCode_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663430);
			IAPProduct.NativeMethodInfoPtr_set_CountryCode_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663431);
			IAPProduct.NativeMethodInfoPtr_get_CurrencyCode_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663432);
			IAPProduct.NativeMethodInfoPtr_set_CurrencyCode_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663433);
			IAPProduct.NativeMethodInfoPtr_get_CurrencySymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663434);
			IAPProduct.NativeMethodInfoPtr_set_CurrencySymbol_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663435);
			IAPProduct.NativeMethodInfoPtr_get_ProductID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663436);
			IAPProduct.NativeMethodInfoPtr_set_ProductID_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663437);
			IAPProduct.NativeMethodInfoPtr_get_ArchetypeID_Public_get_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663438);
			IAPProduct.NativeMethodInfoPtr_set_ArchetypeID_Public_set_Void_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663439);
			IAPProduct.NativeMethodInfoPtr_get_Label_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663440);
			IAPProduct.NativeMethodInfoPtr_set_Label_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663441);
			IAPProduct.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663442);
			IAPProduct.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663443);
			IAPProduct.NativeMethodInfoPtr_get_Price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663444);
			IAPProduct.NativeMethodInfoPtr_set_Price_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663445);
			IAPProduct.NativeMethodInfoPtr_get_FormattedPrice_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663446);
			IAPProduct.NativeMethodInfoPtr_set_FormattedPrice_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663447);
			IAPProduct.NativeMethodInfoPtr_get_ProductType_Public_get_IAPProductTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663448);
			IAPProduct.NativeMethodInfoPtr_set_ProductType_Public_set_Void_IAPProductTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663449);
			IAPProduct.NativeMethodInfoPtr_get_Purchaseable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663450);
			IAPProduct.NativeMethodInfoPtr_set_Purchaseable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663451);
			IAPProduct.NativeMethodInfoPtr_get_Status_Public_get_IAPProductStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663452);
			IAPProduct.NativeMethodInfoPtr_set_Status_Public_set_Void_IAPProductStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663453);
			IAPProduct.NativeMethodInfoPtr_get_FailReason_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663454);
			IAPProduct.NativeMethodInfoPtr_set_FailReason_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663455);
			IAPProduct.NativeMethodInfoPtr_get_Receipt_Public_get_IAPReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663456);
			IAPProduct.NativeMethodInfoPtr_set_Receipt_Public_set_Void_IAPReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663457);
			IAPProduct.NativeMethodInfoPtr_get_PriceString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663458);
			IAPProduct.NativeMethodInfoPtr_get_PriceDisclaimer_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663459);
			IAPProduct.NativeMethodInfoPtr_set_PriceDisclaimer_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663460);
			IAPProduct.NativeMethodInfoPtr_get_Tags_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663461);
			IAPProduct.NativeMethodInfoPtr_set_Tags_Public_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663462);
			IAPProduct.NativeMethodInfoPtr_get_Image_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663463);
			IAPProduct.NativeMethodInfoPtr_set_Image_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663464);
			IAPProduct.NativeMethodInfoPtr_get_Claimable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663465);
			IAPProduct.NativeMethodInfoPtr_set_Claimable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663466);
			IAPProduct.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663467);
			IAPProduct.NativeMethodInfoPtr__ctor_Public_Void_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663468);
			IAPProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663469);
			IAPProduct.NativeMethodInfoPtr_DebugString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663470);
			IAPProduct.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663471);
			IAPProduct.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663472);
			IAPProduct.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663473);
			IAPProduct.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663474);
			IAPProduct.NativeMethodInfoPtr_IDsString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr, 100663475);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00005E88 File Offset: 0x00004088
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00005EBC File Offset: 0x000040BC
		public unsafe static CultureInfo CultureInformation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200465, XrefRangeEnd = 1200469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_CultureInformation_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200469, XrefRangeEnd = 1200482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_CultureInformation_Public_Static_set_Void_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00005EF4 File Offset: 0x000040F4
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00005F20 File Offset: 0x00004120
		public unsafe static string CultureCode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200482, XrefRangeEnd = 1200486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_CultureCode_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200486, XrefRangeEnd = 1200507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_CultureCode_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00005F58 File Offset: 0x00004158
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00005F84 File Offset: 0x00004184
		public unsafe static string CountryCode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200507, XrefRangeEnd = 1200511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_CountryCode_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1200521, RefRangeEnd = 1200523, XrefRangeStart = 1200511, XrefRangeEnd = 1200521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_CountryCode_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00005FBC File Offset: 0x000041BC
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00005FE8 File Offset: 0x000041E8
		public unsafe static string CurrencyCode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200523, XrefRangeEnd = 1200527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_CurrencyCode_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1200537, RefRangeEnd = 1200539, XrefRangeStart = 1200527, XrefRangeEnd = 1200537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_CurrencyCode_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00006020 File Offset: 0x00004220
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00006058 File Offset: 0x00004258
		public unsafe string CurrencySymbol
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_CurrencySymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_CurrencySymbol_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000609C File Offset: 0x0000429C
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000060D4 File Offset: 0x000042D4
		public unsafe string ProductID
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_ProductID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_ProductID_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00006118 File Offset: 0x00004318
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00006158 File Offset: 0x00004358
		public unsafe ArchetypeID ArchetypeID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_ArchetypeID_Public_get_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200539, XrefRangeEnd = 1200550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_ArchetypeID_Public_set_Void_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000619C File Offset: 0x0000439C
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000061D4 File Offset: 0x000043D4
		public unsafe string Label
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_Label_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_Label_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00006218 File Offset: 0x00004418
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00006250 File Offset: 0x00004450
		public unsafe string Description
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00006294 File Offset: 0x00004494
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000062D0 File Offset: 0x000044D0
		public unsafe float Price
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_Price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 850305, RefRangeEnd = 850310, XrefRangeStart = 850305, XrefRangeEnd = 850310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_Price_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00006310 File Offset: 0x00004510
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00006348 File Offset: 0x00004548
		public unsafe string FormattedPrice
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_FormattedPrice_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_FormattedPrice_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000638C File Offset: 0x0000458C
		// (set) Token: 0x06000094 RID: 148 RVA: 0x000063C8 File Offset: 0x000045C8
		public unsafe IAPProductTypes ProductType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_ProductType_Public_get_IAPProductTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_ProductType_Public_set_Void_IAPProductTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00006408 File Offset: 0x00004608
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00006444 File Offset: 0x00004644
		public unsafe bool Purchaseable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_Purchaseable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_Purchaseable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00006484 File Offset: 0x00004684
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000064C0 File Offset: 0x000046C0
		public unsafe IAPProductStatus Status
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_Status_Public_get_IAPProductStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_Status_Public_set_Void_IAPProductStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00006500 File Offset: 0x00004700
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00006538 File Offset: 0x00004738
		public unsafe string FailReason
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_FailReason_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_FailReason_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000657C File Offset: 0x0000477C
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000065BC File Offset: 0x000047BC
		public unsafe IAPReceipt Receipt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_Receipt_Public_get_IAPReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAPReceipt>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_Receipt_Public_set_Void_IAPReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00006600 File Offset: 0x00004800
		public unsafe string PriceString
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1200571, RefRangeEnd = 1200574, XrefRangeStart = 1200550, XrefRangeEnd = 1200571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_PriceString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00006638 File Offset: 0x00004838
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00006670 File Offset: 0x00004870
		public unsafe string PriceDisclaimer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_PriceDisclaimer_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_PriceDisclaimer_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000066B4 File Offset: 0x000048B4
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x000066F4 File Offset: 0x000048F4
		public unsafe List<string> Tags
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_Tags_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_Tags_Public_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00006738 File Offset: 0x00004938
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00006770 File Offset: 0x00004970
		public unsafe string Image
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_Image_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_Image_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000067B4 File Offset: 0x000049B4
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x000067F0 File Offset: 0x000049F0
		public unsafe bool Claimable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_get_Claimable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_set_Claimable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00006830 File Offset: 0x00004A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200574, XrefRangeEnd = 1200579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPProduct(string productID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000687C File Offset: 0x00004A7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1200591, RefRangeEnd = 1200592, XrefRangeStart = 1200579, XrefRangeEnd = 1200591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPProduct(IAPProduct other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr__ctor_Public_Void_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000068C8 File Offset: 0x00004AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200592, XrefRangeEnd = 1200596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPProduct()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPProduct>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00006904 File Offset: 0x00004B04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1200676, RefRangeEnd = 1200677, XrefRangeStart = 1200596, XrefRangeEnd = 1200676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DebugString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_DebugString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000693C File Offset: 0x00004B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200677, XrefRangeEnd = 1200681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(IAPProduct other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000698C File Offset: 0x00004B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200681, XrefRangeEnd = 1200682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPProduct.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000069D4 File Offset: 0x00004BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200682, XrefRangeEnd = 1200690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPProduct.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00006A2C File Offset: 0x00004C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200690, XrefRangeEnd = 1200710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPProduct.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00006A70 File Offset: 0x00004C70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1200713, RefRangeEnd = 1200717, XrefRangeStart = 1200710, XrefRangeEnd = 1200713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string IDsString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProduct.NativeMethodInfoPtr_IDsString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000023A6 File Offset: 0x000005A6
		public IAPProduct(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00006AA8 File Offset: 0x00004CA8
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000023AF File Offset: 0x000005AF
		public unsafe static CultureInfo cultureInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPProduct.NativeFieldInfoPtr_cultureInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPProduct.NativeFieldInfoPtr_cultureInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00006AD0 File Offset: 0x00004CD0
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000023C1 File Offset: 0x000005C1
		public unsafe static string cultureCode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPProduct.NativeFieldInfoPtr_cultureCode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPProduct.NativeFieldInfoPtr_cultureCode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00006AF0 File Offset: 0x00004CF0
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000023D3 File Offset: 0x000005D3
		public unsafe static string countryCode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPProduct.NativeFieldInfoPtr_countryCode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPProduct.NativeFieldInfoPtr_countryCode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00006B10 File Offset: 0x00004D10
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x000023E5 File Offset: 0x000005E5
		public unsafe static string currencyCode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPProduct.NativeFieldInfoPtr_currencyCode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPProduct.NativeFieldInfoPtr_currencyCode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00006B30 File Offset: 0x00004D30
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000023F7 File Offset: 0x000005F7
		public unsafe static NumberFormatInfo PriceFormatter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IAPProduct.NativeFieldInfoPtr_PriceFormatter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IAPProduct.NativeFieldInfoPtr_PriceFormatter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00006B58 File Offset: 0x00004D58
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002409 File Offset: 0x00000609
		public unsafe string _CurrencySymbol_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__CurrencySymbol_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__CurrencySymbol_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00006B80 File Offset: 0x00004D80
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002428 File Offset: 0x00000628
		public unsafe string _ProductID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__ProductID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__ProductID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00006BA8 File Offset: 0x00004DA8
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002447 File Offset: 0x00000647
		public unsafe ArchetypeID archetypeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr_archetypeID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr_archetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00006BD8 File Offset: 0x00004DD8
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002466 File Offset: 0x00000666
		public unsafe string _Label_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Label_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Label_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00006C00 File Offset: 0x00004E00
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002485 File Offset: 0x00000685
		public unsafe string _Description_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Description_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Description_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00006C28 File Offset: 0x00004E28
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000024A4 File Offset: 0x000006A4
		public unsafe float _Price_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Price_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Price_k__BackingField)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00006C50 File Offset: 0x00004E50
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x000024BF File Offset: 0x000006BF
		public unsafe string _FormattedPrice_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__FormattedPrice_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__FormattedPrice_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00006C78 File Offset: 0x00004E78
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000024DE File Offset: 0x000006DE
		public unsafe IAPProductTypes _ProductType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__ProductType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__ProductType_k__BackingField)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00006CA0 File Offset: 0x00004EA0
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000024F9 File Offset: 0x000006F9
		public unsafe bool _Purchaseable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Purchaseable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Purchaseable_k__BackingField)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00006CC8 File Offset: 0x00004EC8
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002514 File Offset: 0x00000714
		public unsafe IAPProductStatus _Status_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Status_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Status_k__BackingField)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00006CF0 File Offset: 0x00004EF0
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000252F File Offset: 0x0000072F
		public unsafe string _FailReason_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__FailReason_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__FailReason_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00006D18 File Offset: 0x00004F18
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000254E File Offset: 0x0000074E
		public unsafe IAPReceipt _Receipt_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Receipt_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPReceipt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Receipt_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00006D48 File Offset: 0x00004F48
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000256D File Offset: 0x0000076D
		public unsafe string _PriceDisclaimer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__PriceDisclaimer_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__PriceDisclaimer_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00006D70 File Offset: 0x00004F70
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000258C File Offset: 0x0000078C
		public unsafe List<string> _Tags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Tags_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Tags_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00006DA0 File Offset: 0x00004FA0
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x000025AB File Offset: 0x000007AB
		public unsafe string _Image_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Image_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Image_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00006DC8 File Offset: 0x00004FC8
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x000025CA File Offset: 0x000007CA
		public unsafe bool _Claimable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Claimable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProduct.NativeFieldInfoPtr__Claimable_k__BackingField)) = value;
			}
		}

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_cultureInfo;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_cultureCode;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_countryCode;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_currencyCode;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_PriceFormatter;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr__CurrencySymbol_k__BackingField;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr__ProductID_k__BackingField;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_archetypeID;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr__Label_k__BackingField;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr__Description_k__BackingField;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr__Price_k__BackingField;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr__FormattedPrice_k__BackingField;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr__ProductType_k__BackingField;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr__Purchaseable_k__BackingField;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr__FailReason_k__BackingField;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr__Receipt_k__BackingField;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr__PriceDisclaimer_k__BackingField;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr__Tags_k__BackingField;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr__Image_k__BackingField;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr__Claimable_k__BackingField;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureInformation_Public_Static_get_CultureInfo_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_set_CultureInformation_Public_Static_set_Void_CultureInfo_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureCode_Public_Static_get_String_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_set_CultureCode_Public_Static_set_Void_String_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_get_CountryCode_Public_Static_get_String_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_set_CountryCode_Public_Static_set_Void_String_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyCode_Public_Static_get_String_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrencyCode_Public_Static_set_Void_String_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencySymbol_Public_get_String_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrencySymbol_Public_set_Void_String_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_get_ProductID_Public_get_String_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_set_ProductID_Public_set_Void_String_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_get_ArchetypeID_Public_get_ArchetypeID_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_set_ArchetypeID_Public_set_Void_ArchetypeID_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_get_Label_Public_get_String_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_set_Label_Public_set_Void_String_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_set_Description_Public_set_Void_String_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Single_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_set_Price_Public_set_Void_Single_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_get_FormattedPrice_Public_get_String_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_set_FormattedPrice_Public_set_Void_String_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_get_ProductType_Public_get_IAPProductTypes_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_set_ProductType_Public_set_Void_IAPProductTypes_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_get_Purchaseable_Public_get_Boolean_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_set_Purchaseable_Public_set_Void_Boolean_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_IAPProductStatus_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_set_Status_Public_set_Void_IAPProductStatus_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_get_FailReason_Public_get_String_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_set_FailReason_Public_set_Void_String_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_get_Receipt_Public_get_IAPReceipt_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_set_Receipt_Public_set_Void_IAPReceipt_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_get_PriceString_Public_get_String_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_get_PriceDisclaimer_Public_get_String_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_set_PriceDisclaimer_Public_set_Void_String_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Public_get_List_1_String_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_set_Tags_Public_set_Void_List_1_String_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_get_Image_Public_get_String_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_set_Image_Public_set_Void_String_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_get_Claimable_Public_get_Boolean_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_set_Claimable_Public_set_Void_Boolean_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAPProduct_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_DebugString_Public_String_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IAPProduct_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_IDsString_Public_String_0;
	}
}
