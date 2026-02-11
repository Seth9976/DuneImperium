using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace lotus.util
{
	// Token: 0x020000D9 RID: 217
	public class HierarchyItemRenderer : MonoBehaviour
	{
		// Token: 0x06000AE6 RID: 2790 RVA: 0x00033CA0 File Offset: 0x00031EA0
		// Note: this type is marked as 'beforefieldinit'.
		static HierarchyItemRenderer()
		{
			Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.util", "HierarchyItemRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr);
			HierarchyItemRenderer.NativeFieldInfoPtr_ACTIVE_ALPHA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr, "ACTIVE_ALPHA");
			HierarchyItemRenderer.NativeFieldInfoPtr_INACTIVE_ALPHA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr, "INACTIVE_ALPHA");
			HierarchyItemRenderer.NativeFieldInfoPtr_nameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr, "nameLabel");
			HierarchyItemRenderer.NativeFieldInfoPtr_activeToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr, "activeToggle");
			HierarchyItemRenderer.NativeFieldInfoPtr_layoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr, "layoutGroup");
			HierarchyItemRenderer.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr, "canvasGroup");
			HierarchyItemRenderer.NativeFieldInfoPtr_linkedGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr, "linkedGameObject");
			HierarchyItemRenderer.NativeMethodInfoPtr_get_ActiveToggle_Public_get_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr, 100665048);
			HierarchyItemRenderer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr, 100665049);
			HierarchyItemRenderer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr, 100665050);
			HierarchyItemRenderer.NativeMethodInfoPtr_set_LinkedGameObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr, 100665051);
			HierarchyItemRenderer.NativeMethodInfoPtr_SetIndent_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr, 100665052);
			HierarchyItemRenderer.NativeMethodInfoPtr_ToggleChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr, 100665053);
			HierarchyItemRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr, 100665054);
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00033DE8 File Offset: 0x00031FE8
		public unsafe Toggle ActiveToggle
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyItemRenderer.NativeMethodInfoPtr_get_ActiveToggle_Public_get_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr3) : null;
			}
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00033E28 File Offset: 0x00032028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994384, XrefRangeEnd = 994394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyItemRenderer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00033E5C File Offset: 0x0003205C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994394, XrefRangeEnd = 994405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyItemRenderer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002F3 RID: 755
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x00033E90 File Offset: 0x00032090
		public unsafe GameObject LinkedGameObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994405, XrefRangeEnd = 994410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyItemRenderer.NativeMethodInfoPtr_set_LinkedGameObject_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00033ED4 File Offset: 0x000320D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994410, XrefRangeEnd = 994412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndent(int indentValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref indentValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyItemRenderer.NativeMethodInfoPtr_SetIndent_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00033F14 File Offset: 0x00032114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994412, XrefRangeEnd = 994414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleChanged(bool toggleState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref toggleState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyItemRenderer.NativeMethodInfoPtr_ToggleChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00033F54 File Offset: 0x00032154
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HierarchyItemRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchyItemRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyItemRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00007010 File Offset: 0x00005210
		public HierarchyItemRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00033F90 File Offset: 0x00032190
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x00007019 File Offset: 0x00005219
		public unsafe static float ACTIVE_ALPHA
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(HierarchyItemRenderer.NativeFieldInfoPtr_ACTIVE_ALPHA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HierarchyItemRenderer.NativeFieldInfoPtr_ACTIVE_ALPHA, (void*)(&value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00033FAC File Offset: 0x000321AC
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00007027 File Offset: 0x00005227
		public unsafe static float INACTIVE_ALPHA
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(HierarchyItemRenderer.NativeFieldInfoPtr_INACTIVE_ALPHA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HierarchyItemRenderer.NativeFieldInfoPtr_INACTIVE_ALPHA, (void*)(&value));
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00033FC8 File Offset: 0x000321C8
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00007035 File Offset: 0x00005235
		public unsafe Text nameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyItemRenderer.NativeFieldInfoPtr_nameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyItemRenderer.NativeFieldInfoPtr_nameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00033FF8 File Offset: 0x000321F8
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00007054 File Offset: 0x00005254
		public unsafe Toggle activeToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyItemRenderer.NativeFieldInfoPtr_activeToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyItemRenderer.NativeFieldInfoPtr_activeToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00034028 File Offset: 0x00032228
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00007073 File Offset: 0x00005273
		public unsafe HorizontalLayoutGroup layoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyItemRenderer.NativeFieldInfoPtr_layoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HorizontalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyItemRenderer.NativeFieldInfoPtr_layoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00034058 File Offset: 0x00032258
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00007092 File Offset: 0x00005292
		public unsafe CanvasGroup canvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyItemRenderer.NativeFieldInfoPtr_canvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyItemRenderer.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00034088 File Offset: 0x00032288
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x000070B1 File Offset: 0x000052B1
		public unsafe GameObject linkedGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyItemRenderer.NativeFieldInfoPtr_linkedGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyItemRenderer.NativeFieldInfoPtr_linkedGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeFieldInfoPtr_ACTIVE_ALPHA;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeFieldInfoPtr_INACTIVE_ALPHA;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeFieldInfoPtr_nameLabel;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeFieldInfoPtr_activeToggle;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeFieldInfoPtr_layoutGroup;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeFieldInfoPtr_linkedGameObject;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveToggle_Public_get_Toggle_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_set_LinkedGameObject_Public_set_Void_GameObject_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_SetIndent_Public_Void_Int32_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_ToggleChanged_Private_Void_Boolean_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
