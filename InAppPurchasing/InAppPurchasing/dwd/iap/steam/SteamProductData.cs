using System;
using Canis.attributes;
using dwd.core.archetypes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.iap.steam
{
	// Token: 0x0200000A RID: 10
	public class SteamProductData : Object
	{
		// Token: 0x06000028 RID: 40 RVA: 0x000045D0 File Offset: 0x000027D0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamProductData()
		{
			Il2CppClassPointerStore<SteamProductData>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.steam", "SteamProductData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamProductData>.NativeClassPtr);
			SteamProductData.NativeFieldInfoPtr_ToFloatMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamProductData>.NativeClassPtr, "ToFloatMultiplier");
			SteamProductData.NativeFieldInfoPtr_FALLBACK_CURRENCY_CODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamProductData>.NativeClassPtr, "FALLBACK_CURRENCY_CODE");
			SteamProductData.NativeFieldInfoPtr_prices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamProductData>.NativeClassPtr, "prices");
			SteamProductData.NativeMethodInfoPtr_get_Price_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamProductData>.NativeClassPtr, 100663334);
			SteamProductData.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamProductData>.NativeClassPtr, 100663335);
			SteamProductData.NativeMethodInfoPtr_PriceAsFloatFromProduct_Public_Static_Single_ArchetypeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamProductData>.NativeClassPtr, 100663336);
			SteamProductData.NativeMethodInfoPtr_PriceAsFloat_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamProductData>.NativeClassPtr, 100663337);
			SteamProductData.NativeMethodInfoPtr_PriceAsInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamProductData>.NativeClassPtr, 100663338);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000046A0 File Offset: 0x000028A0
		public unsafe int Price
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1199726, RefRangeEnd = 1199727, XrefRangeStart = 1199688, XrefRangeEnd = 1199726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamProductData.NativeMethodInfoPtr_get_Price_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000046DC File Offset: 0x000028DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1199765, RefRangeEnd = 1199766, XrefRangeStart = 1199727, XrefRangeEnd = 1199765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamProductData(ReadOnlyAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamProductData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamProductData.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004728 File Offset: 0x00002928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199766, XrefRangeEnd = 1199805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float PriceAsFloatFromProduct(ArchetypeComponent product)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamProductData.NativeMethodInfoPtr_PriceAsFloatFromProduct_Public_Static_Single_ArchetypeComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000476C File Offset: 0x0000296C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199805, XrefRangeEnd = 1199836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float PriceAsFloat(int price)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref price;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamProductData.NativeMethodInfoPtr_PriceAsFloat_Public_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000047AC File Offset: 0x000029AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199836, XrefRangeEnd = 1199867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PriceAsInt(float price)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref price;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamProductData.NativeMethodInfoPtr_PriceAsInt_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000219D File Offset: 0x0000039D
		public SteamProductData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000047EC File Offset: 0x000029EC
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000021A6 File Offset: 0x000003A6
		public unsafe static Dictionary<string, float> ToFloatMultiplier
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamProductData.NativeFieldInfoPtr_ToFloatMultiplier, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamProductData.NativeFieldInfoPtr_ToFloatMultiplier, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00004814 File Offset: 0x00002A14
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000021B8 File Offset: 0x000003B8
		public unsafe static string FALLBACK_CURRENCY_CODE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamProductData.NativeFieldInfoPtr_FALLBACK_CURRENCY_CODE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamProductData.NativeFieldInfoPtr_FALLBACK_CURRENCY_CODE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00004834 File Offset: 0x00002A34
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000021CA File Offset: 0x000003CA
		public unsafe Dictionary<string, int> prices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamProductData.NativeFieldInfoPtr_prices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamProductData.NativeFieldInfoPtr_prices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_ToFloatMultiplier;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_FALLBACK_CURRENCY_CODE;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_prices;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Int32_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyAttributes_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_PriceAsFloatFromProduct_Public_Static_Single_ArchetypeComponent_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_PriceAsFloat_Public_Static_Single_Int32_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_PriceAsInt_Public_Static_Int32_Single_0;
	}
}
