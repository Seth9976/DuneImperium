using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200001C RID: 28
	public class ContentSizeFitter : UIBehaviour
	{
		// Token: 0x060003E6 RID: 998 RVA: 0x0001621C File Offset: 0x0001441C
		// Note: this type is marked as 'beforefieldinit'.
		static ContentSizeFitter()
		{
			Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ContentSizeFitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr);
			ContentSizeFitter.NativeFieldInfoPtr_m_HorizontalFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, "m_HorizontalFit");
			ContentSizeFitter.NativeFieldInfoPtr_m_VerticalFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, "m_VerticalFit");
			ContentSizeFitter.NativeFieldInfoPtr_m_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, "m_Rect");
			ContentSizeFitter.NativeFieldInfoPtr_m_Tracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, "m_Tracker");
			ContentSizeFitter.NativeMethodInfoPtr_get_horizontalFit_Public_get_FitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663927);
			ContentSizeFitter.NativeMethodInfoPtr_set_horizontalFit_Public_set_Void_FitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663928);
			ContentSizeFitter.NativeMethodInfoPtr_get_verticalFit_Public_get_FitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663929);
			ContentSizeFitter.NativeMethodInfoPtr_set_verticalFit_Public_set_Void_FitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663930);
			ContentSizeFitter.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663931);
			ContentSizeFitter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663932);
			ContentSizeFitter.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663933);
			ContentSizeFitter.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663934);
			ContentSizeFitter.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663935);
			ContentSizeFitter.NativeMethodInfoPtr_HandleSelfFittingAlongAxis_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663936);
			ContentSizeFitter.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663937);
			ContentSizeFitter.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663938);
			ContentSizeFitter.NativeMethodInfoPtr_SetDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663939);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x000163A0 File Offset: 0x000145A0
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x000163DC File Offset: 0x000145DC
		public unsafe ContentSizeFitter.FitMode horizontalFit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_get_horizontalFit_Public_get_FitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088065, XrefRangeEnd = 1088069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_set_horizontalFit_Public_set_Void_FitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0001641C File Offset: 0x0001461C
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x00016458 File Offset: 0x00014658
		public unsafe ContentSizeFitter.FitMode verticalFit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_get_verticalFit_Public_get_FitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088069, XrefRangeEnd = 1088073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_set_verticalFit_Public_set_Void_FitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00016498 File Offset: 0x00014698
		public unsafe RectTransform rectTransform
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1088081, RefRangeEnd = 1088089, XrefRangeStart = 1088073, XrefRangeEnd = 1088081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000164D8 File Offset: 0x000146D8
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentSizeFitter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00016514 File Offset: 0x00014714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088089, XrefRangeEnd = 1088091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentSizeFitter.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00016550 File Offset: 0x00014750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088091, XrefRangeEnd = 1088098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentSizeFitter.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0001658C File Offset: 0x0001478C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088098, XrefRangeEnd = 1088099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentSizeFitter.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000165C8 File Offset: 0x000147C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088099, XrefRangeEnd = 1088110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSelfFittingAlongAxis(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_HandleSelfFittingAlongAxis_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00016608 File Offset: 0x00014808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088110, XrefRangeEnd = 1088119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentSizeFitter.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00016644 File Offset: 0x00014844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088119, XrefRangeEnd = 1088127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentSizeFitter.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00016680 File Offset: 0x00014880
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1088132, RefRangeEnd = 1088136, XrefRangeStart = 1088127, XrefRangeEnd = 1088132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_SetDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000035AC File Offset: 0x000017AC
		public ContentSizeFitter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x000166B4 File Offset: 0x000148B4
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x000035B5 File Offset: 0x000017B5
		public unsafe ContentSizeFitter.FitMode m_HorizontalFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_HorizontalFit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_HorizontalFit)) = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x000166DC File Offset: 0x000148DC
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x000035D0 File Offset: 0x000017D0
		public unsafe ContentSizeFitter.FitMode m_VerticalFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_VerticalFit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_VerticalFit)) = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00016704 File Offset: 0x00014904
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x000035EB File Offset: 0x000017EB
		public unsafe RectTransform m_Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00016734 File Offset: 0x00014934
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x0000360A File Offset: 0x0000180A
		public unsafe DrivenRectTransformTracker m_Tracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_Tracker);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_Tracker)) = value;
			}
		}

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalFit;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalFit;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr_m_Rect;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracker;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalFit_Public_get_FitMode_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalFit_Public_set_Void_FitMode_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalFit_Public_get_FitMode_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalFit_Public_set_Void_FitMode_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_HandleSelfFittingAlongAxis_Private_Void_Int32_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Protected_Void_0;

		// Token: 0x0200009F RID: 159
		public enum FitMode
		{
			// Token: 0x04000999 RID: 2457
			Unconstrained,
			// Token: 0x0400099A RID: 2458
			MinSize,
			// Token: 0x0400099B RID: 2459
			PreferredSize
		}
	}
}
