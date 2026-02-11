using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.platformdependent
{
	// Token: 0x02000019 RID: 25
	[Serializable]
	public class PlatformDependentRectTransformAdjustment : PlatformDependentAdjustment
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x0000572C File Offset: 0x0000392C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentRectTransformAdjustment()
		{
			Il2CppClassPointerStore<PlatformDependentRectTransformAdjustment>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentRectTransformAdjustment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentRectTransformAdjustment>.NativeClassPtr);
			PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformAdjustment>.NativeClassPtr, "position");
			PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_sizeDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformAdjustment>.NativeClassPtr, "sizeDelta");
			PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_anchorMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformAdjustment>.NativeClassPtr, "anchorMin");
			PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_anchorMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformAdjustment>.NativeClassPtr, "anchorMax");
			PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformAdjustment>.NativeClassPtr, "pivot");
			PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_localScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformAdjustment>.NativeClassPtr, "localScale");
			PlatformDependentRectTransformAdjustment.NativeMethodInfoPtr_Approximately_Public_Boolean_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentRectTransformAdjustment>.NativeClassPtr, 100663390);
			PlatformDependentRectTransformAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentRectTransformAdjustment>.NativeClassPtr, 100663391);
			PlatformDependentRectTransformAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentRectTransformAdjustment>.NativeClassPtr, 100663392);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005810 File Offset: 0x00003A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239240, XrefRangeEnd = 1239252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Approximately(RectTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentRectTransformAdjustment.NativeMethodInfoPtr_Approximately_Public_Boolean_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005860 File Offset: 0x00003A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239252, XrefRangeEnd = 1239261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyAdjustment(GameObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentRectTransformAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000058B0 File Offset: 0x00003AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239261, XrefRangeEnd = 1239274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentRectTransformAdjustment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentRectTransformAdjustment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentRectTransformAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000257A File Offset: 0x0000077A
		public PlatformDependentRectTransformAdjustment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000058EC File Offset: 0x00003AEC
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002583 File Offset: 0x00000783
		public unsafe Vector2 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00005914 File Offset: 0x00003B14
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000259E File Offset: 0x0000079E
		public unsafe Vector2 sizeDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_sizeDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_sizeDelta)) = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000593C File Offset: 0x00003B3C
		// (set) Token: 0x060000CE RID: 206 RVA: 0x000025B9 File Offset: 0x000007B9
		public unsafe Vector2 anchorMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_anchorMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_anchorMin)) = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00005964 File Offset: 0x00003B64
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x000025D4 File Offset: 0x000007D4
		public unsafe Vector2 anchorMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_anchorMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_anchorMax)) = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000598C File Offset: 0x00003B8C
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000025EF File Offset: 0x000007EF
		public unsafe Vector2 pivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_pivot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_pivot)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000059B4 File Offset: 0x00003BB4
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000260A File Offset: 0x0000080A
		public unsafe Vector3 localScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_localScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformAdjustment.NativeFieldInfoPtr_localScale)) = value;
			}
		}

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_sizeDelta;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_anchorMin;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_anchorMax;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_pivot;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_localScale;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Boolean_RectTransform_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
