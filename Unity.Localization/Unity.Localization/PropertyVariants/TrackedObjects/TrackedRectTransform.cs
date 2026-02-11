using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	// Token: 0x020000FC RID: 252
	[Serializable]
	public class TrackedRectTransform : TrackedTransform
	{
		// Token: 0x06000C2A RID: 3114 RVA: 0x0003720C File Offset: 0x0003540C
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedRectTransform()
		{
			Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedObjects", "TrackedRectTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr);
			TrackedRectTransform.NativeFieldInfoPtr_m_AnchorPosToApply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, "m_AnchorPosToApply");
			TrackedRectTransform.NativeFieldInfoPtr_m_AnchorMinToApply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, "m_AnchorMinToApply");
			TrackedRectTransform.NativeFieldInfoPtr_m_AnchorMaxToApply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, "m_AnchorMaxToApply");
			TrackedRectTransform.NativeFieldInfoPtr_m_PivotToApply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, "m_PivotToApply");
			TrackedRectTransform.NativeFieldInfoPtr_m_SizeDeltaToApply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, "m_SizeDeltaToApply");
			TrackedRectTransform.NativeMethodInfoPtr_AddPropertyHandlers_Protected_Virtual_Void_Dictionary_2_String_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, 100665314);
			TrackedRectTransform.NativeMethodInfoPtr_ApplyLocale_Public_Virtual_AsyncOperationHandle_Locale_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, 100665315);
			TrackedRectTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, 100665316);
			TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, 100665317);
			TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, 100665318);
			TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_2_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, 100665319);
			TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_3_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, 100665320);
			TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_4_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, 100665321);
			TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_5_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, 100665322);
			TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_6_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, 100665323);
			TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_7_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, 100665324);
			TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_8_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, 100665325);
			TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_9_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, 100665326);
			TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_10_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr, 100665327);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x000373B8 File Offset: 0x000355B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080692, XrefRangeEnd = 1080795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddPropertyHandlers(Dictionary<string, Action<float>> handlers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handlers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedRectTransform.NativeMethodInfoPtr_AddPropertyHandlers_Protected_Virtual_Void_Dictionary_2_String_Action_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00037408 File Offset: 0x00035608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080795, XrefRangeEnd = 1080808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variantLocale);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultLocale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedRectTransform.NativeMethodInfoPtr_ApplyLocale_Public_Virtual_AsyncOperationHandle_Locale_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00037470 File Offset: 0x00035670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedRectTransform()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedRectTransform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedRectTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x000374AC File Offset: 0x000356AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357469, RefRangeEnd = 357470, XrefRangeStart = 357469, XrefRangeEnd = 357470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddPropertyHandlers_b__5_0(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x000374EC File Offset: 0x000356EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1080808, RefRangeEnd = 1080809, XrefRangeStart = 1080808, XrefRangeEnd = 1080808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddPropertyHandlers_b__5_1(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0003752C File Offset: 0x0003572C
		[CallerCount(0)]
		public unsafe void _AddPropertyHandlers_b__5_2(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_2_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0003756C File Offset: 0x0003576C
		[CallerCount(0)]
		public unsafe void _AddPropertyHandlers_b__5_3(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_3_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x000375AC File Offset: 0x000357AC
		[CallerCount(0)]
		public unsafe void _AddPropertyHandlers_b__5_4(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_4_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x000375EC File Offset: 0x000357EC
		[CallerCount(0)]
		public unsafe void _AddPropertyHandlers_b__5_5(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_5_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0003762C File Offset: 0x0003582C
		[CallerCount(0)]
		public unsafe void _AddPropertyHandlers_b__5_6(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_6_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0003766C File Offset: 0x0003586C
		[CallerCount(0)]
		public unsafe void _AddPropertyHandlers_b__5_7(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_7_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x000376AC File Offset: 0x000358AC
		[CallerCount(0)]
		public unsafe void _AddPropertyHandlers_b__5_8(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_8_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x000376EC File Offset: 0x000358EC
		[CallerCount(0)]
		public unsafe void _AddPropertyHandlers_b__5_9(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_9_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0003772C File Offset: 0x0003592C
		[CallerCount(0)]
		public unsafe void _AddPropertyHandlers_b__5_10(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedRectTransform.NativeMethodInfoPtr__AddPropertyHandlers_b__5_10_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00007249 File Offset: 0x00005449
		public TrackedRectTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x0003776C File Offset: 0x0003596C
		// (set) Token: 0x06000C3B RID: 3131 RVA: 0x00007252 File Offset: 0x00005452
		public unsafe Vector3 m_AnchorPosToApply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedRectTransform.NativeFieldInfoPtr_m_AnchorPosToApply);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedRectTransform.NativeFieldInfoPtr_m_AnchorPosToApply)) = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x00037794 File Offset: 0x00035994
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x0000726D File Offset: 0x0000546D
		public unsafe Vector2 m_AnchorMinToApply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedRectTransform.NativeFieldInfoPtr_m_AnchorMinToApply);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedRectTransform.NativeFieldInfoPtr_m_AnchorMinToApply)) = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x000377BC File Offset: 0x000359BC
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x00007288 File Offset: 0x00005488
		public unsafe Vector2 m_AnchorMaxToApply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedRectTransform.NativeFieldInfoPtr_m_AnchorMaxToApply);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedRectTransform.NativeFieldInfoPtr_m_AnchorMaxToApply)) = value;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x000377E4 File Offset: 0x000359E4
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x000072A3 File Offset: 0x000054A3
		public unsafe Vector2 m_PivotToApply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedRectTransform.NativeFieldInfoPtr_m_PivotToApply);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedRectTransform.NativeFieldInfoPtr_m_PivotToApply)) = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x0003780C File Offset: 0x00035A0C
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x000072BE File Offset: 0x000054BE
		public unsafe Vector2 m_SizeDeltaToApply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedRectTransform.NativeFieldInfoPtr_m_SizeDeltaToApply);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedRectTransform.NativeFieldInfoPtr_m_SizeDeltaToApply)) = value;
			}
		}

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeFieldInfoPtr_m_AnchorPosToApply;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeFieldInfoPtr_m_AnchorMinToApply;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeFieldInfoPtr_m_AnchorMaxToApply;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeFieldInfoPtr_m_PivotToApply;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeFieldInfoPtr_m_SizeDeltaToApply;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_AddPropertyHandlers_Protected_Virtual_Void_Dictionary_2_String_Action_1_Single_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLocale_Public_Virtual_AsyncOperationHandle_Locale_Locale_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__5_0_Private_Void_Single_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__5_1_Private_Void_Single_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__5_2_Private_Void_Single_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__5_3_Private_Void_Single_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__5_4_Private_Void_Single_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__5_5_Private_Void_Single_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__5_6_Private_Void_Single_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__5_7_Private_Void_Single_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__5_8_Private_Void_Single_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__5_9_Private_Void_Single_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr__AddPropertyHandlers_b__5_10_Private_Void_Single_0;
	}
}
