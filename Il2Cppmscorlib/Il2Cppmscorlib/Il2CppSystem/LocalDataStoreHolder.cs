using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000126 RID: 294
	public sealed class LocalDataStoreHolder : Object
	{
		// Token: 0x06001396 RID: 5014 RVA: 0x00084AD0 File Offset: 0x00082CD0
		// Note: this type is marked as 'beforefieldinit'.
		static LocalDataStoreHolder()
		{
			Il2CppClassPointerStore<LocalDataStoreHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LocalDataStoreHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalDataStoreHolder>.NativeClassPtr);
			LocalDataStoreHolder.NativeFieldInfoPtr_m_Store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreHolder>.NativeClassPtr, "m_Store");
			LocalDataStoreHolder.NativeMethodInfoPtr__ctor_Public_Void_LocalDataStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreHolder>.NativeClassPtr, 100666777);
			LocalDataStoreHolder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreHolder>.NativeClassPtr, 100666778);
			LocalDataStoreHolder.NativeMethodInfoPtr_get_Store_Public_get_LocalDataStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreHolder>.NativeClassPtr, 100666779);
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00084B50 File Offset: 0x00082D50
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreHolder(LocalDataStore store)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDataStoreHolder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreHolder.NativeMethodInfoPtr__ctor_Public_Void_LocalDataStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00084B9C File Offset: 0x00082D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338063, XrefRangeEnd = 1338069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreHolder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x00084BD0 File Offset: 0x00082DD0
		public unsafe LocalDataStore Store
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreHolder.NativeMethodInfoPtr_get_Store_Public_get_LocalDataStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStore>(intPtr3) : null;
			}
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x000063FF File Offset: 0x000045FF
		public LocalDataStoreHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x00084C10 File Offset: 0x00082E10
		// (set) Token: 0x0600139C RID: 5020 RVA: 0x00006408 File Offset: 0x00004608
		public unsafe LocalDataStore m_Store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreHolder.NativeFieldInfoPtr_m_Store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreHolder.NativeFieldInfoPtr_m_Store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeFieldInfoPtr_m_Store;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalDataStore_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_get_Store_Public_get_LocalDataStore_0;
	}
}
