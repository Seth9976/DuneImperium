using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x0200001B RID: 27
	public sealed class AsyncOpHandlesCacheKey : Object
	{
		// Token: 0x060001AA RID: 426 RVA: 0x0000B83C File Offset: 0x00009A3C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncOpHandlesCacheKey()
		{
			Il2CppClassPointerStore<AsyncOpHandlesCacheKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "AsyncOpHandlesCacheKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOpHandlesCacheKey>.NativeClassPtr);
			AsyncOpHandlesCacheKey.NativeFieldInfoPtr_m_Handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOpHandlesCacheKey>.NativeClassPtr, "m_Handles");
			AsyncOpHandlesCacheKey.NativeMethodInfoPtr__ctor_Public_Void_IList_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOpHandlesCacheKey>.NativeClassPtr, 100663605);
			AsyncOpHandlesCacheKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOpHandlesCacheKey>.NativeClassPtr, 100663606);
			AsyncOpHandlesCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOpHandlesCacheKey>.NativeClassPtr, 100663607);
			AsyncOpHandlesCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IOperationCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOpHandlesCacheKey>.NativeClassPtr, 100663608);
			AsyncOpHandlesCacheKey.NativeMethodInfoPtr_Equals_Private_Boolean_AsyncOpHandlesCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOpHandlesCacheKey>.NativeClassPtr, 100663609);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000B8E4 File Offset: 0x00009AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138686, XrefRangeEnd = 1138694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOpHandlesCacheKey(IList<AsyncOperationHandle> handles)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOpHandlesCacheKey>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handles);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOpHandlesCacheKey.NativeMethodInfoPtr__ctor_Public_Void_IList_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000B930 File Offset: 0x00009B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOpHandlesCacheKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000B96C File Offset: 0x00009B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138694, XrefRangeEnd = 1138699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOpHandlesCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000B9BC File Offset: 0x00009BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138699, XrefRangeEnd = 1138704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(IOperationCacheKey other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOpHandlesCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IOperationCacheKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000BA0C File Offset: 0x00009C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138704, XrefRangeEnd = 1138707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AsyncOpHandlesCacheKey other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOpHandlesCacheKey.NativeMethodInfoPtr_Equals_Private_Boolean_AsyncOpHandlesCacheKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002AF7 File Offset: 0x00000CF7
		public AsyncOpHandlesCacheKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000BA5C File Offset: 0x00009C5C
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002B00 File Offset: 0x00000D00
		public unsafe HashSet<AsyncOperationHandle> m_Handles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOpHandlesCacheKey.NativeFieldInfoPtr_m_Handles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOpHandlesCacheKey.NativeFieldInfoPtr_m_Handles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_m_Handles;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_AsyncOperationHandle_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IOperationCacheKey_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Private_Boolean_AsyncOpHandlesCacheKey_0;
	}
}
