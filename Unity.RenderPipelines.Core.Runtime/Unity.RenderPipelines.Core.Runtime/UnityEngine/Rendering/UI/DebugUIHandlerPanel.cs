using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x02000131 RID: 305
	public class DebugUIHandlerPanel : MonoBehaviour
	{
		// Token: 0x060013BF RID: 5055 RVA: 0x00058328 File Offset: 0x00056528
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerPanel()
		{
			Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr);
			DebugUIHandlerPanel.NativeFieldInfoPtr_nameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, "nameLabel");
			DebugUIHandlerPanel.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, "scrollRect");
			DebugUIHandlerPanel.NativeFieldInfoPtr_viewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, "viewport");
			DebugUIHandlerPanel.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, "Canvas");
			DebugUIHandlerPanel.NativeFieldInfoPtr_m_ScrollTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, "m_ScrollTransform");
			DebugUIHandlerPanel.NativeFieldInfoPtr_m_ContentTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, "m_ContentTransform");
			DebugUIHandlerPanel.NativeFieldInfoPtr_m_MaskTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, "m_MaskTransform");
			DebugUIHandlerPanel.NativeFieldInfoPtr_m_ScrollTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, "m_ScrollTarget");
			DebugUIHandlerPanel.NativeFieldInfoPtr_m_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, "m_Panel");
			DebugUIHandlerPanel.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, 100666153);
			DebugUIHandlerPanel.NativeMethodInfoPtr_SetPanel_Internal_Void_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, 100666154);
			DebugUIHandlerPanel.NativeMethodInfoPtr_GetPanel_Internal_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, 100666155);
			DebugUIHandlerPanel.NativeMethodInfoPtr_SelectNextItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, 100666156);
			DebugUIHandlerPanel.NativeMethodInfoPtr_SelectPreviousItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, 100666157);
			DebugUIHandlerPanel.NativeMethodInfoPtr_OnScrollbarClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, 100666158);
			DebugUIHandlerPanel.NativeMethodInfoPtr_SetScrollTarget_Internal_Void_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, 100666159);
			DebugUIHandlerPanel.NativeMethodInfoPtr_UpdateScroll_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, 100666160);
			DebugUIHandlerPanel.NativeMethodInfoPtr_GetYPosInScroll_Private_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, 100666161);
			DebugUIHandlerPanel.NativeMethodInfoPtr_GetFirstItem_Internal_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, 100666162);
			DebugUIHandlerPanel.NativeMethodInfoPtr_ResetDebugManager_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, 100666163);
			DebugUIHandlerPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr, 100666164);
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x000584FC File Offset: 0x000566FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980950, XrefRangeEnd = 980964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPanel.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00058530 File Offset: 0x00056730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980964, XrefRangeEnd = 980966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPanel(DebugUI.Panel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPanel.NativeMethodInfoPtr_SetPanel_Internal_Void_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00058574 File Offset: 0x00056774
		[CallerCount(0)]
		public unsafe DebugUI.Panel GetPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPanel.NativeMethodInfoPtr_GetPanel_Internal_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Panel>(intPtr3) : null;
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x000585B4 File Offset: 0x000567B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980966, XrefRangeEnd = 980970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectNextItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPanel.NativeMethodInfoPtr_SelectNextItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x000585E8 File Offset: 0x000567E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980970, XrefRangeEnd = 980975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectPreviousItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPanel.NativeMethodInfoPtr_SelectPreviousItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0005861C File Offset: 0x0005681C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980975, XrefRangeEnd = 980981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnScrollbarClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPanel.NativeMethodInfoPtr_OnScrollbarClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x00058650 File Offset: 0x00056850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScrollTarget(DebugUIHandlerWidget target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPanel.NativeMethodInfoPtr_SetScrollTarget_Internal_Void_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00058694 File Offset: 0x00056894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 980998, RefRangeEnd = 980999, XrefRangeStart = 980981, XrefRangeEnd = 980998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScroll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPanel.NativeMethodInfoPtr_UpdateScroll_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x000586C8 File Offset: 0x000568C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 981007, RefRangeEnd = 981009, XrefRangeStart = 980999, XrefRangeEnd = 981007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetYPosInScroll(RectTransform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPanel.NativeMethodInfoPtr_GetYPosInScroll_Private_Single_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00058718 File Offset: 0x00056918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981009, XrefRangeEnd = 981014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerWidget GetFirstItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPanel.NativeMethodInfoPtr_GetFirstItem_Internal_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr3) : null;
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00058758 File Offset: 0x00056958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981014, XrefRangeEnd = 981020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetDebugManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPanel.NativeMethodInfoPtr_ResetDebugManager_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0005878C File Offset: 0x0005698C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerPanel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0000A036 File Offset: 0x00008236
		public DebugUIHandlerPanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x000587C8 File Offset: 0x000569C8
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x0000A03F File Offset: 0x0000823F
		public unsafe Text nameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_nameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_nameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x000587F8 File Offset: 0x000569F8
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x0000A05E File Offset: 0x0000825E
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x00058828 File Offset: 0x00056A28
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x0000A07D File Offset: 0x0000827D
		public unsafe RectTransform viewport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_viewport);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_viewport), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00058858 File Offset: 0x00056A58
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x0000A09C File Offset: 0x0000829C
		public unsafe DebugUIHandlerCanvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerCanvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x00058888 File Offset: 0x00056A88
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x0000A0BB File Offset: 0x000082BB
		public unsafe RectTransform m_ScrollTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_m_ScrollTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_m_ScrollTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x000588B8 File Offset: 0x00056AB8
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x0000A0DA File Offset: 0x000082DA
		public unsafe RectTransform m_ContentTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_m_ContentTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_m_ContentTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x000588E8 File Offset: 0x00056AE8
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x0000A0F9 File Offset: 0x000082F9
		public unsafe RectTransform m_MaskTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_m_MaskTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_m_MaskTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x00058918 File Offset: 0x00056B18
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x0000A118 File Offset: 0x00008318
		public unsafe DebugUIHandlerWidget m_ScrollTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_m_ScrollTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_m_ScrollTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x00058948 File Offset: 0x00056B48
		// (set) Token: 0x060013DE RID: 5086 RVA: 0x0000A137 File Offset: 0x00008337
		public unsafe DebugUI.Panel m_Panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_m_Panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.Panel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPanel.NativeFieldInfoPtr_m_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeFieldInfoPtr_nameLabel;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeFieldInfoPtr_viewport;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollTransform;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentTransform;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeFieldInfoPtr_m_MaskTransform;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollTarget;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeFieldInfoPtr_m_Panel;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr_SetPanel_Internal_Void_Panel_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr_GetPanel_Internal_Panel_0;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeMethodInfoPtr_SelectNextItem_Public_Void_0;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeMethodInfoPtr_SelectPreviousItem_Public_Void_0;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeMethodInfoPtr_OnScrollbarClicked_Public_Void_0;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeMethodInfoPtr_SetScrollTarget_Internal_Void_DebugUIHandlerWidget_0;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScroll_Internal_Void_0;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeMethodInfoPtr_GetYPosInScroll_Private_Single_RectTransform_0;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstItem_Internal_DebugUIHandlerWidget_0;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeMethodInfoPtr_ResetDebugManager_Public_Void_0;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
