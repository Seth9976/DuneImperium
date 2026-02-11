using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.iap.store
{
	// Token: 0x02000022 RID: 34
	public class OfflineProductStorage : Object
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x0000AF58 File Offset: 0x00009158
		// Note: this type is marked as 'beforefieldinit'.
		static OfflineProductStorage()
		{
			Il2CppClassPointerStore<OfflineProductStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "OfflineProductStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineProductStorage>.NativeClassPtr);
			OfflineProductStorage.NativeFieldInfoPtr_LastVerified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineProductStorage>.NativeClassPtr, "LastVerified");
			OfflineProductStorage.NativeFieldInfoPtr_OwnedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineProductStorage>.NativeClassPtr, "OwnedProducts");
			OfflineProductStorage.NativeMethodInfoPtr__ctor_Public_Void_Int64_HashSet_1_IAPProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineProductStorage>.NativeClassPtr, 100663724);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000AFC4 File Offset: 0x000091C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202356, XrefRangeEnd = 1202358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OfflineProductStorage(long lastVerified, HashSet<IAPProduct> ownedProducts)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineProductStorage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lastVerified;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ownedProducts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineProductStorage.NativeMethodInfoPtr__ctor_Public_Void_Int64_HashSet_1_IAPProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002C92 File Offset: 0x00000E92
		public OfflineProductStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000B020 File Offset: 0x00009220
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002C9B File Offset: 0x00000E9B
		public unsafe long LastVerified
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineProductStorage.NativeFieldInfoPtr_LastVerified);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineProductStorage.NativeFieldInfoPtr_LastVerified)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000B048 File Offset: 0x00009248
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00002CB6 File Offset: 0x00000EB6
		public unsafe HashSet<IAPProduct> OwnedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineProductStorage.NativeFieldInfoPtr_OwnedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IAPProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineProductStorage.NativeFieldInfoPtr_OwnedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_LastVerified;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_OwnedProducts;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_HashSet_1_IAPProduct_0;
	}
}
