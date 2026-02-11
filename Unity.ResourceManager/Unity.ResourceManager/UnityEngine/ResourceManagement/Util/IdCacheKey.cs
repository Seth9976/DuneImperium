using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x02000018 RID: 24
	public sealed class IdCacheKey : Object
	{
		// Token: 0x06000189 RID: 393 RVA: 0x0000B058 File Offset: 0x00009258
		// Note: this type is marked as 'beforefieldinit'.
		static IdCacheKey()
		{
			Il2CppClassPointerStore<IdCacheKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "IdCacheKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdCacheKey>.NativeClassPtr);
			IdCacheKey.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdCacheKey>.NativeClassPtr, "ID");
			IdCacheKey.NativeFieldInfoPtr_locationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdCacheKey>.NativeClassPtr, "locationType");
			IdCacheKey.NativeMethodInfoPtr__ctor_Public_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdCacheKey>.NativeClassPtr, 100663590);
			IdCacheKey.NativeMethodInfoPtr_Equals_Private_Boolean_IdCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdCacheKey>.NativeClassPtr, 100663591);
			IdCacheKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdCacheKey>.NativeClassPtr, 100663592);
			IdCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdCacheKey>.NativeClassPtr, 100663593);
			IdCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IOperationCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdCacheKey>.NativeClassPtr, 100663594);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000B114 File Offset: 0x00009314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1138610, RefRangeEnd = 1138611, XrefRangeStart = 1138599, XrefRangeEnd = 1138610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IdCacheKey(Type locType, string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdCacheKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdCacheKey.NativeMethodInfoPtr__ctor_Public_Void_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000B174 File Offset: 0x00009374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138611, XrefRangeEnd = 1138616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(IdCacheKey other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdCacheKey.NativeMethodInfoPtr_Equals_Private_Boolean_IdCacheKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000B1C4 File Offset: 0x000093C4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdCacheKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000B200 File Offset: 0x00009400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138616, XrefRangeEnd = 1138623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000B250 File Offset: 0x00009450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138623, XrefRangeEnd = 1138630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(IOperationCacheKey other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IOperationCacheKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002A26 File Offset: 0x00000C26
		public IdCacheKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000B2A0 File Offset: 0x000094A0
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00002A2F File Offset: 0x00000C2F
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdCacheKey.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdCacheKey.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000B2C8 File Offset: 0x000094C8
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00002A4E File Offset: 0x00000C4E
		public unsafe Type locationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdCacheKey.NativeFieldInfoPtr_locationType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdCacheKey.NativeFieldInfoPtr_locationType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_locationType;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Private_Boolean_IdCacheKey_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IOperationCacheKey_0;
	}
}
