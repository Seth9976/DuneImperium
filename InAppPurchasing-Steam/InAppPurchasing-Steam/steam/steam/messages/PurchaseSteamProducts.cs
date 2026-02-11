using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.iap.steam.steam.messages
{
	// Token: 0x0200000A RID: 10
	public class PurchaseSteamProducts : Object
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00003910 File Offset: 0x00001B10
		// Note: this type is marked as 'beforefieldinit'.
		static PurchaseSteamProducts()
		{
			Il2CppClassPointerStore<PurchaseSteamProducts>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Steam.dll", "dwd.iap.steam.steam.messages", "PurchaseSteamProducts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchaseSteamProducts>.NativeClassPtr);
			PurchaseSteamProducts.NativeFieldInfoPtr_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProducts>.NativeClassPtr, "SteamID");
			PurchaseSteamProducts.NativeFieldInfoPtr_CountryCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProducts>.NativeClassPtr, "CountryCode");
			PurchaseSteamProducts.NativeFieldInfoPtr_CurrencyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProducts>.NativeClassPtr, "CurrencyCode");
			PurchaseSteamProducts.NativeFieldInfoPtr_Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProducts>.NativeClassPtr, "Language");
			PurchaseSteamProducts.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProducts>.NativeClassPtr, "ProductID");
			PurchaseSteamProducts.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseSteamProducts>.NativeClassPtr, 100663385);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000039B8 File Offset: 0x00001BB8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PurchaseSteamProducts()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchaseSteamProducts>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseSteamProducts.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000227E File Offset: 0x0000047E
		public PurchaseSteamProducts(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000039F4 File Offset: 0x00001BF4
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002287 File Offset: 0x00000487
		public unsafe ulong SteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProducts.NativeFieldInfoPtr_SteamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProducts.NativeFieldInfoPtr_SteamID)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00003A1C File Offset: 0x00001C1C
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000022A2 File Offset: 0x000004A2
		public unsafe string CountryCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProducts.NativeFieldInfoPtr_CountryCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProducts.NativeFieldInfoPtr_CountryCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00003A44 File Offset: 0x00001C44
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000022C1 File Offset: 0x000004C1
		public unsafe string CurrencyCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProducts.NativeFieldInfoPtr_CurrencyCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProducts.NativeFieldInfoPtr_CurrencyCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00003A6C File Offset: 0x00001C6C
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000022E0 File Offset: 0x000004E0
		public unsafe string Language
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProducts.NativeFieldInfoPtr_Language);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProducts.NativeFieldInfoPtr_Language), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00003A94 File Offset: 0x00001C94
		// (set) Token: 0x0600005C RID: 92 RVA: 0x000022FF File Offset: 0x000004FF
		public unsafe string ProductID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProducts.NativeFieldInfoPtr_ProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProducts.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_SteamID;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_CountryCode;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_CurrencyCode;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_Language;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_ProductID;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
