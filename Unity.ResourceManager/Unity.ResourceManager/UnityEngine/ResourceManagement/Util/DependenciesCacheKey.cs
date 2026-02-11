using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x0200001A RID: 26
	public sealed class DependenciesCacheKey : Object
	{
		// Token: 0x0600019F RID: 415 RVA: 0x0000B5A0 File Offset: 0x000097A0
		// Note: this type is marked as 'beforefieldinit'.
		static DependenciesCacheKey()
		{
			Il2CppClassPointerStore<DependenciesCacheKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "DependenciesCacheKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DependenciesCacheKey>.NativeClassPtr);
			DependenciesCacheKey.NativeFieldInfoPtr_m_Dependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DependenciesCacheKey>.NativeClassPtr, "m_Dependencies");
			DependenciesCacheKey.NativeFieldInfoPtr_m_DependenciesHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DependenciesCacheKey>.NativeClassPtr, "m_DependenciesHash");
			DependenciesCacheKey.NativeMethodInfoPtr__ctor_Public_Void_IList_1_IResourceLocation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependenciesCacheKey>.NativeClassPtr, 100663600);
			DependenciesCacheKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependenciesCacheKey>.NativeClassPtr, 100663601);
			DependenciesCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependenciesCacheKey>.NativeClassPtr, 100663602);
			DependenciesCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IOperationCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependenciesCacheKey>.NativeClassPtr, 100663603);
			DependenciesCacheKey.NativeMethodInfoPtr_Equals_Private_Boolean_DependenciesCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependenciesCacheKey>.NativeClassPtr, 100663604);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000B65C File Offset: 0x0000985C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 412652, RefRangeEnd = 412658, XrefRangeStart = 412652, XrefRangeEnd = 412658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DependenciesCacheKey(IList<IResourceLocation> dependencies, int dependenciesHash)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DependenciesCacheKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dependencies);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependenciesHash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependenciesCacheKey.NativeMethodInfoPtr__ctor_Public_Void_IList_1_IResourceLocation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependenciesCacheKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000B6F4 File Offset: 0x000098F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138663, XrefRangeEnd = 1138666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependenciesCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000B744 File Offset: 0x00009944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138666, XrefRangeEnd = 1138669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(IOperationCacheKey other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependenciesCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IOperationCacheKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000B794 File Offset: 0x00009994
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1138684, RefRangeEnd = 1138686, XrefRangeStart = 1138669, XrefRangeEnd = 1138684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(DependenciesCacheKey other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependenciesCacheKey.NativeMethodInfoPtr_Equals_Private_Boolean_DependenciesCacheKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002AB4 File Offset: 0x00000CB4
		public DependenciesCacheKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000B7E4 File Offset: 0x000099E4
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00002ABD File Offset: 0x00000CBD
		public unsafe IList<IResourceLocation> m_Dependencies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DependenciesCacheKey.NativeFieldInfoPtr_m_Dependencies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<IResourceLocation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DependenciesCacheKey.NativeFieldInfoPtr_m_Dependencies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000B814 File Offset: 0x00009A14
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002ADC File Offset: 0x00000CDC
		public unsafe int m_DependenciesHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DependenciesCacheKey.NativeFieldInfoPtr_m_DependenciesHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DependenciesCacheKey.NativeFieldInfoPtr_m_DependenciesHash)) = value;
			}
		}

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeFieldInfoPtr_m_Dependencies;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr_m_DependenciesHash;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_IResourceLocation_Int32_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IOperationCacheKey_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Private_Boolean_DependenciesCacheKey_0;
	}
}
