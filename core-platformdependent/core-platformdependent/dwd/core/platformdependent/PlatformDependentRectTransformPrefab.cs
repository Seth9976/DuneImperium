using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.platformdependent
{
	// Token: 0x0200001B RID: 27
	[Serializable]
	public class PlatformDependentRectTransformPrefab : PlatformDependentPrefab
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00005B40 File Offset: 0x00003D40
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentRectTransformPrefab()
		{
			Il2CppClassPointerStore<PlatformDependentRectTransformPrefab>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentRectTransformPrefab");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentRectTransformPrefab>.NativeClassPtr);
			PlatformDependentRectTransformPrefab.NativeFieldInfoPtr_anchorMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformPrefab>.NativeClassPtr, "anchorMax");
			PlatformDependentRectTransformPrefab.NativeFieldInfoPtr_anchorMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformPrefab>.NativeClassPtr, "anchorMin");
			PlatformDependentRectTransformPrefab.NativeFieldInfoPtr_offsetMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformPrefab>.NativeClassPtr, "offsetMax");
			PlatformDependentRectTransformPrefab.NativeFieldInfoPtr_offsetMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformPrefab>.NativeClassPtr, "offsetMin");
			PlatformDependentRectTransformPrefab.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Nullable_1_Boolean_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentRectTransformPrefab>.NativeClassPtr, 100663398);
			PlatformDependentRectTransformPrefab.NativeMethodInfoPtr_configure_Protected_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentRectTransformPrefab>.NativeClassPtr, 100663399);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239350, XrefRangeEnd = 1239359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentRectTransformPrefab(GameObject prefab, Nullable<bool> zeroOutTransform, Nullable<int> siblingIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentRectTransformPrefab>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentRectTransformPrefab.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Nullable_1_Boolean_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00005C64 File Offset: 0x00003E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239359, XrefRangeEnd = 1239368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void configure(GameObject instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentRectTransformPrefab.NativeMethodInfoPtr_configure_Protected_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000264D File Offset: 0x0000084D
		public PlatformDependentRectTransformPrefab(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00005CB4 File Offset: 0x00003EB4
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002656 File Offset: 0x00000856
		public unsafe Vector2 anchorMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformPrefab.NativeFieldInfoPtr_anchorMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformPrefab.NativeFieldInfoPtr_anchorMax)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00005CDC File Offset: 0x00003EDC
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002671 File Offset: 0x00000871
		public unsafe Vector2 anchorMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformPrefab.NativeFieldInfoPtr_anchorMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformPrefab.NativeFieldInfoPtr_anchorMin)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00005D04 File Offset: 0x00003F04
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000268C File Offset: 0x0000088C
		public unsafe Vector2 offsetMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformPrefab.NativeFieldInfoPtr_offsetMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformPrefab.NativeFieldInfoPtr_offsetMax)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00005D2C File Offset: 0x00003F2C
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000026A7 File Offset: 0x000008A7
		public unsafe Vector2 offsetMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformPrefab.NativeFieldInfoPtr_offsetMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformPrefab.NativeFieldInfoPtr_offsetMin)) = value;
			}
		}

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_anchorMax;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_anchorMin;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_offsetMax;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_offsetMin;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_Nullable_1_Boolean_Nullable_1_Int32_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_configure_Protected_Virtual_Void_GameObject_0;
	}
}
