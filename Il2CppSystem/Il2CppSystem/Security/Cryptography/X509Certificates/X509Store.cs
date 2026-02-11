using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.X509;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000DF RID: 223
	public sealed class X509Store : Object
	{
		// Token: 0x06000EDB RID: 3803 RVA: 0x000542C0 File Offset: 0x000524C0
		// Note: this type is marked as 'beforefieldinit'.
		static X509Store()
		{
			Il2CppClassPointerStore<X509Store>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Store");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Store>.NativeClassPtr);
			X509Store.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Store>.NativeClassPtr, "_name");
			X509Store.NativeFieldInfoPtr__location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Store>.NativeClassPtr, "_location");
			X509Store.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Store>.NativeClassPtr, "list");
			X509Store.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Store>.NativeClassPtr, "_flags");
			X509Store.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Store>.NativeClassPtr, "store");
			X509Store.NativeMethodInfoPtr__ctor_Public_Void_StoreName_StoreLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100665456);
			X509Store.NativeMethodInfoPtr_get_Certificates_Public_get_X509Certificate2Collection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100665457);
			X509Store.NativeMethodInfoPtr_get_Factory_Private_get_X509Stores_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100665458);
			X509Store.NativeMethodInfoPtr_get_Store_Internal_get_X509Store_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100665459);
			X509Store.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100665460);
			X509Store.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100665461);
			X509Store.NativeMethodInfoPtr_Open_Public_Void_OpenFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100665462);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x000543E0 File Offset: 0x000525E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 455834, RefRangeEnd = 455839, XrefRangeStart = 455825, XrefRangeEnd = 455834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Store(StoreName storeName, StoreLocation storeLocation)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Store>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref storeName;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeLocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr__ctor_Public_Void_StoreName_StoreLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00054438 File Offset: 0x00052638
		public unsafe X509Certificate2Collection Certificates
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 455841, RefRangeEnd = 455847, XrefRangeStart = 455839, XrefRangeEnd = 455841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr_get_Certificates_Public_get_X509Certificate2Collection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr3) : null;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x00054478 File Offset: 0x00052678
		public unsafe X509Stores Factory
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455847, XrefRangeEnd = 455849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr_get_Factory_Private_get_X509Stores_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Stores>(intPtr3) : null;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x000544B8 File Offset: 0x000526B8
		public unsafe X509Store Store
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr_get_Store_Internal_get_X509Store_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr3) : null;
			}
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x000544F8 File Offset: 0x000526F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455849, XrefRangeEnd = 455851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0005452C File Offset: 0x0005272C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00054560 File Offset: 0x00052760
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 455881, RefRangeEnd = 455886, XrefRangeStart = 455851, XrefRangeEnd = 455881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(OpenFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr_Open_Public_Void_OpenFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x000075D3 File Offset: 0x000057D3
		public X509Store(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x000545A0 File Offset: 0x000527A0
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x000075DC File Offset: 0x000057DC
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x000545C8 File Offset: 0x000527C8
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x000075FB File Offset: 0x000057FB
		public unsafe StoreLocation _location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__location);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__location)) = value;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x000545F0 File Offset: 0x000527F0
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x00007616 File Offset: 0x00005816
		public unsafe X509Certificate2Collection list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x00054620 File Offset: 0x00052820
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x00007635 File Offset: 0x00005835
		public unsafe OpenFlags _flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__flags)) = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x00054648 File Offset: 0x00052848
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x00007650 File Offset: 0x00005850
		public unsafe X509Store store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeFieldInfoPtr__location;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeFieldInfoPtr_list;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StoreName_StoreLocation_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_get_Certificates_Public_get_X509Certificate2Collection_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_get_Factory_Private_get_X509Stores_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_get_Store_Internal_get_X509Store_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_OpenFlags_0;
	}
}
