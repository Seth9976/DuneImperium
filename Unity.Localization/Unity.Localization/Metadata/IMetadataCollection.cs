using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000D6 RID: 214
	public class IMetadataCollection : Il2CppObjectBase
	{
		// Token: 0x06000AF2 RID: 2802 RVA: 0x000326A4 File Offset: 0x000308A4
		// Note: this type is marked as 'beforefieldinit'.
		static IMetadataCollection()
		{
			Il2CppClassPointerStore<IMetadataCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Metadata", "IMetadataCollection");
			IMetadataCollection.NativeMethodInfoPtr_get_MetadataEntries_Public_Abstract_Virtual_New_get_IList_1_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMetadataCollection>.NativeClassPtr, 100665112);
			IMetadataCollection.NativeMethodInfoPtr_GetMetadata_Public_Abstract_Virtual_New_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMetadataCollection>.NativeClassPtr, 100665113);
			IMetadataCollection.NativeMethodInfoPtr_GetMetadatas_Public_Abstract_Virtual_New_Void_IList_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMetadataCollection>.NativeClassPtr, 100665114);
			IMetadataCollection.NativeMethodInfoPtr_GetMetadatas_Public_Abstract_Virtual_New_IList_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMetadataCollection>.NativeClassPtr, 100665115);
			IMetadataCollection.NativeMethodInfoPtr_AddMetadata_Public_Abstract_Virtual_New_Void_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMetadataCollection>.NativeClassPtr, 100665116);
			IMetadataCollection.NativeMethodInfoPtr_RemoveMetadata_Public_Abstract_Virtual_New_Boolean_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMetadataCollection>.NativeClassPtr, 100665117);
			IMetadataCollection.NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMetadataCollection>.NativeClassPtr, 100665118);
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00032758 File Offset: 0x00030958
		public unsafe virtual IList<IMetadata> MetadataEntries
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMetadataCollection.NativeMethodInfoPtr_get_MetadataEntries_Public_Abstract_Virtual_New_get_IList_1_IMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IMetadata>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x000327A4 File Offset: 0x000309A4
		[CallerCount(0)]
		public unsafe virtual TObject GetMetadata<TObject>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMetadataCollection.MethodInfoStoreGeneric_GetMetadata_Public_Abstract_Virtual_New_TObject_0<TObject>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TObject>(intPtr, false, true);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x000327E8 File Offset: 0x000309E8
		[CallerCount(0)]
		public unsafe virtual void GetMetadatas<TObject>(IList<TObject> foundItems)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(foundItems);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMetadataCollection.MethodInfoStoreGeneric_GetMetadatas_Public_Abstract_Virtual_New_Void_IList_1_TObject_0<TObject>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00032838 File Offset: 0x00030A38
		[CallerCount(0)]
		public unsafe virtual IList<TObject> GetMetadatas<TObject>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMetadataCollection.MethodInfoStoreGeneric_GetMetadatas_Public_Abstract_Virtual_New_IList_1_TObject_0<TObject>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<TObject>>(intPtr3) : null;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00032884 File Offset: 0x00030A84
		[CallerCount(0)]
		public unsafe virtual void AddMetadata(IMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMetadataCollection.NativeMethodInfoPtr_AddMetadata_Public_Abstract_Virtual_New_Void_IMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x000328D4 File Offset: 0x00030AD4
		[CallerCount(0)]
		public unsafe virtual bool RemoveMetadata(IMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMetadataCollection.NativeMethodInfoPtr_RemoveMetadata_Public_Abstract_Virtual_New_Boolean_IMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0003292C File Offset: 0x00030B2C
		[CallerCount(0)]
		public unsafe virtual bool Contains(IMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMetadataCollection.NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_IMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00006942 File Offset: 0x00004B42
		public IMetadataCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataEntries_Public_Abstract_Virtual_New_get_IList_1_IMetadata_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadata_Public_Abstract_Virtual_New_TObject_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadatas_Public_Abstract_Virtual_New_Void_IList_1_TObject_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadatas_Public_Abstract_Virtual_New_IList_1_TObject_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_AddMetadata_Public_Abstract_Virtual_New_Void_IMetadata_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMetadata_Public_Abstract_Virtual_New_Boolean_IMetadata_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_IMetadata_0;

		// Token: 0x02000174 RID: 372
		private sealed class MethodInfoStoreGeneric_GetMetadata_Public_Abstract_Virtual_New_TObject_0<TObject>
		{
			// Token: 0x04000ABB RID: 2747
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IMetadataCollection.NativeMethodInfoPtr_GetMetadata_Public_Abstract_Virtual_New_TObject_0, Il2CppClassPointerStore<IMetadataCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000175 RID: 373
		private sealed class MethodInfoStoreGeneric_GetMetadatas_Public_Abstract_Virtual_New_Void_IList_1_TObject_0<TObject>
		{
			// Token: 0x04000ABC RID: 2748
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IMetadataCollection.NativeMethodInfoPtr_GetMetadatas_Public_Abstract_Virtual_New_Void_IList_1_TObject_0, Il2CppClassPointerStore<IMetadataCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000176 RID: 374
		private sealed class MethodInfoStoreGeneric_GetMetadatas_Public_Abstract_Virtual_New_IList_1_TObject_0<TObject>
		{
			// Token: 0x04000ABD RID: 2749
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IMetadataCollection.NativeMethodInfoPtr_GetMetadatas_Public_Abstract_Virtual_New_IList_1_TObject_0, Il2CppClassPointerStore<IMetadataCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}
	}
}
