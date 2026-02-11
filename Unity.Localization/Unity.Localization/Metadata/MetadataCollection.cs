using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000D7 RID: 215
	[Serializable]
	public class MetadataCollection : Object
	{
		// Token: 0x06000AFB RID: 2811 RVA: 0x00032984 File Offset: 0x00030B84
		// Note: this type is marked as 'beforefieldinit'.
		static MetadataCollection()
		{
			Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Metadata", "MetadataCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr);
			MetadataCollection.NativeFieldInfoPtr_m_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr, "m_Items");
			MetadataCollection.NativeMethodInfoPtr_get_MetadataEntries_Public_Virtual_Final_New_get_IList_1_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr, 100665119);
			MetadataCollection.NativeMethodInfoPtr_get_HasData_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr, 100665120);
			MetadataCollection.NativeMethodInfoPtr_HasMetadata_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr, 100665121);
			MetadataCollection.NativeMethodInfoPtr_GetMetadata_Public_Virtual_Final_New_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr, 100665122);
			MetadataCollection.NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_Void_IList_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr, 100665123);
			MetadataCollection.NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_IList_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr, 100665124);
			MetadataCollection.NativeMethodInfoPtr_AddMetadata_Public_Virtual_Final_New_Void_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr, 100665125);
			MetadataCollection.NativeMethodInfoPtr_RemoveMetadata_Public_Virtual_Final_New_Boolean_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr, 100665126);
			MetadataCollection.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr, 100665127);
			MetadataCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr, 100665128);
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x00032A90 File Offset: 0x00030C90
		public unsafe virtual IList<IMetadata> MetadataEntries
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataCollection.NativeMethodInfoPtr_get_MetadataEntries_Public_Virtual_Final_New_get_IList_1_IMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IMetadata>>(intPtr3) : null;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00032AD0 File Offset: 0x00030CD0
		public unsafe bool HasData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078979, XrefRangeEnd = 1078980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataCollection.NativeMethodInfoPtr_get_HasData_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00032B0C File Offset: 0x00030D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078980, XrefRangeEnd = 1078983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasMetadata<TObject>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataCollection.MethodInfoStoreGeneric_HasMetadata_Public_Boolean_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00032B48 File Offset: 0x00030D48
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1078998, RefRangeEnd = 1079007, XrefRangeStart = 1078983, XrefRangeEnd = 1078998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TObject GetMetadata<TObject>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataCollection.MethodInfoStoreGeneric_GetMetadata_Public_Virtual_Final_New_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TObject>(intPtr, false, true);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00032B84 File Offset: 0x00030D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079007, XrefRangeEnd = 1079036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetMetadatas<TObject>(IList<TObject> foundItems)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(foundItems);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataCollection.MethodInfoStoreGeneric_GetMetadatas_Public_Virtual_Final_New_Void_IList_1_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00032BC8 File Offset: 0x00030DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079036, XrefRangeEnd = 1079039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList<TObject> GetMetadatas<TObject>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataCollection.MethodInfoStoreGeneric_GetMetadatas_Public_Virtual_Final_New_IList_1_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<TObject>>(intPtr3) : null;
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00032C08 File Offset: 0x00030E08
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1079043, RefRangeEnd = 1079048, XrefRangeStart = 1079039, XrefRangeEnd = 1079043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddMetadata(IMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataCollection.NativeMethodInfoPtr_AddMetadata_Public_Virtual_Final_New_Void_IMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00032C4C File Offset: 0x00030E4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1079052, RefRangeEnd = 1079057, XrefRangeStart = 1079048, XrefRangeEnd = 1079052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool RemoveMetadata(IMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataCollection.NativeMethodInfoPtr_RemoveMetadata_Public_Virtual_Final_New_Boolean_IMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00032C9C File Offset: 0x00030E9C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1079061, RefRangeEnd = 1079066, XrefRangeStart = 1079057, XrefRangeEnd = 1079061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(IMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataCollection.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_IMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00032CEC File Offset: 0x00030EEC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1079074, RefRangeEnd = 1079086, XrefRangeStart = 1079066, XrefRangeEnd = 1079074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetadataCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0000694B File Offset: 0x00004B4B
		public MetadataCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00032D28 File Offset: 0x00030F28
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x00006954 File Offset: 0x00004B54
		public unsafe List<IMetadata> m_Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataCollection.NativeFieldInfoPtr_m_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataCollection.NativeFieldInfoPtr_m_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeFieldInfoPtr_m_Items;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataEntries_Public_Virtual_Final_New_get_IList_1_IMetadata_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_get_HasData_Public_get_Boolean_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_HasMetadata_Public_Boolean_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadata_Public_Virtual_Final_New_TObject_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_Void_IList_1_TObject_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_IList_1_TObject_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_AddMetadata_Public_Virtual_Final_New_Void_IMetadata_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMetadata_Public_Virtual_Final_New_Boolean_IMetadata_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_IMetadata_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000177 RID: 375
		private sealed class MethodInfoStoreGeneric_HasMetadata_Public_Boolean_0<TObject>
		{
			// Token: 0x04000ABE RID: 2750
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MetadataCollection.NativeMethodInfoPtr_HasMetadata_Public_Boolean_0, Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000178 RID: 376
		private sealed class MethodInfoStoreGeneric_GetMetadata_Public_Virtual_Final_New_TObject_0<TObject>
		{
			// Token: 0x04000ABF RID: 2751
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MetadataCollection.NativeMethodInfoPtr_GetMetadata_Public_Virtual_Final_New_TObject_0, Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000179 RID: 377
		private sealed class MethodInfoStoreGeneric_GetMetadatas_Public_Virtual_Final_New_Void_IList_1_TObject_0<TObject>
		{
			// Token: 0x04000AC0 RID: 2752
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MetadataCollection.NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_Void_IList_1_TObject_0, Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200017A RID: 378
		private sealed class MethodInfoStoreGeneric_GetMetadatas_Public_Virtual_Final_New_IList_1_TObject_0<TObject>
		{
			// Token: 0x04000AC1 RID: 2753
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MetadataCollection.NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_IList_1_TObject_0, Il2CppClassPointerStore<MetadataCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}
	}
}
