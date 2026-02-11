using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.platformdependent
{
	// Token: 0x02000017 RID: 23
	[Serializable]
	public class PlatformDependentPrefab : global::Il2CppSystem.Object
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x00005384 File Offset: 0x00003584
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentPrefab()
		{
			Il2CppClassPointerStore<PlatformDependentPrefab>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentPrefab");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentPrefab>.NativeClassPtr);
			PlatformDependentPrefab.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentPrefab>.NativeClassPtr, "Prefab");
			PlatformDependentPrefab.NativeFieldInfoPtr_ZeroOutTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentPrefab>.NativeClassPtr, "ZeroOutTransform");
			PlatformDependentPrefab.NativeFieldInfoPtr_SiblingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentPrefab>.NativeClassPtr, "SiblingIndex");
			PlatformDependentPrefab.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Nullable_1_Boolean_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentPrefab>.NativeClassPtr, 100663383);
			PlatformDependentPrefab.NativeMethodInfoPtr_Instantiate_Public_GameObject_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentPrefab>.NativeClassPtr, 100663384);
			PlatformDependentPrefab.NativeMethodInfoPtr_configure_Protected_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentPrefab>.NativeClassPtr, 100663385);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000542C File Offset: 0x0000362C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1239198, RefRangeEnd = 1239201, XrefRangeStart = 1239193, XrefRangeEnd = 1239198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentPrefab(GameObject prefab, Nullable<bool> zeroOutTransform, Nullable<int> siblingIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentPrefab>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(zeroOutTransform));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(siblingIndex));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentPrefab.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Nullable_1_Boolean_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000054A8 File Offset: 0x000036A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239201, XrefRangeEnd = 1239208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject Instantiate(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentPrefab.NativeMethodInfoPtr_Instantiate_Public_GameObject_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000054F8 File Offset: 0x000036F8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void configure(GameObject instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentPrefab.NativeMethodInfoPtr_configure_Protected_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000024F4 File Offset: 0x000006F4
		public PlatformDependentPrefab(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00005548 File Offset: 0x00003748
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000024FD File Offset: 0x000006FD
		public unsafe GameObject Prefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentPrefab.NativeFieldInfoPtr_Prefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentPrefab.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00005578 File Offset: 0x00003778
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000251C File Offset: 0x0000071C
		public unsafe bool ZeroOutTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentPrefab.NativeFieldInfoPtr_ZeroOutTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentPrefab.NativeFieldInfoPtr_ZeroOutTransform)) = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000055A0 File Offset: 0x000037A0
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002537 File Offset: 0x00000737
		public unsafe int SiblingIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentPrefab.NativeFieldInfoPtr_SiblingIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentPrefab.NativeFieldInfoPtr_SiblingIndex)) = value;
			}
		}

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_Prefab;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_ZeroOutTransform;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_SiblingIndex;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_Nullable_1_Boolean_Nullable_1_Int32_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_GameObject_Transform_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_configure_Protected_Virtual_New_Void_GameObject_0;
	}
}
