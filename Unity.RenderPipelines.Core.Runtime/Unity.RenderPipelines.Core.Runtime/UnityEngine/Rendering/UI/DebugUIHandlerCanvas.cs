using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x02000120 RID: 288
	public class DebugUIHandlerCanvas : MonoBehaviour
	{
		// Token: 0x0600129D RID: 4765 RVA: 0x00054270 File Offset: 0x00052470
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerCanvas()
		{
			Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr);
			DebugUIHandlerCanvas.NativeFieldInfoPtr_m_DebugTreeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, "m_DebugTreeState");
			DebugUIHandlerCanvas.NativeFieldInfoPtr_m_PrefabsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, "m_PrefabsMap");
			DebugUIHandlerCanvas.NativeFieldInfoPtr_panelPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, "panelPrefab");
			DebugUIHandlerCanvas.NativeFieldInfoPtr_prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, "prefabs");
			DebugUIHandlerCanvas.NativeFieldInfoPtr_m_UIPanels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, "m_UIPanels");
			DebugUIHandlerCanvas.NativeFieldInfoPtr_m_SelectedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, "m_SelectedPanel");
			DebugUIHandlerCanvas.NativeFieldInfoPtr_m_SelectedWidget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, "m_SelectedWidget");
			DebugUIHandlerCanvas.NativeFieldInfoPtr_m_CurrentQueryPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, "m_CurrentQueryPath");
			DebugUIHandlerCanvas.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666012);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666013);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_RequestHierarchyReset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666014);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_ResetAllHierarchy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666015);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_Rebuild_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666016);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_Traverse_Private_Void_IContainer_Transform_DebugUIHandlerWidget_byref_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666017);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_GetWidgetFromPath_Private_DebugUIHandlerWidget_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666018);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_ActivatePanel_Private_Void_Int32_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666019);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_ChangeSelection_Internal_Void_DebugUIHandlerWidget_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666020);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_SelectPreviousItem_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666021);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_SelectNextPanel_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666022);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_SelectPreviousPanel_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666023);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_SelectNextItem_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666024);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_ChangeSelectionValue_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666025);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_ActivateSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666026);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_HandleInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666027);
			DebugUIHandlerCanvas.NativeMethodInfoPtr_SetScrollTarget_Internal_Void_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666028);
			DebugUIHandlerCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, 100666029);
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x000544A8 File Offset: 0x000526A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979826, XrefRangeEnd = 979853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x000544DC File Offset: 0x000526DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979853, XrefRangeEnd = 979871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00054510 File Offset: 0x00052710
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 979871, RefRangeEnd = 979876, XrefRangeStart = 979871, XrefRangeEnd = 979871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestHierarchyReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_RequestHierarchyReset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00054544 File Offset: 0x00052744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 979901, RefRangeEnd = 979902, XrefRangeStart = 979876, XrefRangeEnd = 979901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAllHierarchy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_ResetAllHierarchy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00054578 File Offset: 0x00052778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 980005, RefRangeEnd = 980006, XrefRangeStart = 979902, XrefRangeEnd = 980005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rebuild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_Rebuild_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x000545AC File Offset: 0x000527AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 980075, RefRangeEnd = 980077, XrefRangeStart = 980006, XrefRangeEnd = 980075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Traverse(DebugUI.IContainer container, Transform parentTransform, DebugUIHandlerWidget parentUIHandler, ref DebugUIHandlerWidget selectedHandler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentUIHandler);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(selectedHandler);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_Traverse_Private_Void_IContainer_Transform_DebugUIHandlerWidget_byref_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			selectedHandler = ((intPtr4 == 0) ? null : new DebugUIHandlerWidget(intPtr4));
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x0005463C File Offset: 0x0005283C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980077, XrefRangeEnd = 980098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerWidget GetWidgetFromPath(string queryPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(queryPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_GetWidgetFromPath_Private_DebugUIHandlerWidget_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr3) : null;
			}
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0005468C File Offset: 0x0005288C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 980133, RefRangeEnd = 980139, XrefRangeStart = 980098, XrefRangeEnd = 980133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivatePanel(int index, DebugUIHandlerWidget selectedWidget = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectedWidget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_ActivatePanel_Private_Void_Int32_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x000546DC File Offset: 0x000528DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 980163, RefRangeEnd = 980167, XrefRangeStart = 980139, XrefRangeEnd = 980163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromNext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_ChangeSelection_Internal_Void_DebugUIHandlerWidget_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x0005472C File Offset: 0x0005292C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 980175, RefRangeEnd = 980176, XrefRangeStart = 980167, XrefRangeEnd = 980175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectPreviousItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_SelectPreviousItem_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00054760 File Offset: 0x00052960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980176, XrefRangeEnd = 980180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectNextPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_SelectNextPanel_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00054794 File Offset: 0x00052994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 980185, RefRangeEnd = 980186, XrefRangeStart = 980180, XrefRangeEnd = 980185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectPreviousPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_SelectPreviousPanel_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x000547C8 File Offset: 0x000529C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980186, XrefRangeEnd = 980194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectNextItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_SelectNextItem_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x000547FC File Offset: 0x000529FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980194, XrefRangeEnd = 980204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeSelectionValue(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiplier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_ChangeSelectionValue_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0005483C File Offset: 0x00052A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980204, XrefRangeEnd = 980208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_ActivateSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00054870 File Offset: 0x00052A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 980261, RefRangeEnd = 980262, XrefRangeStart = 980208, XrefRangeEnd = 980261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_HandleInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x000548A4 File Offset: 0x00052AA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 980273, RefRangeEnd = 980275, XrefRangeStart = 980262, XrefRangeEnd = 980273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScrollTarget(DebugUIHandlerWidget widget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr_SetScrollTarget_Internal_Void_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x000548E8 File Offset: 0x00052AE8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerCanvas()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00009868 File Offset: 0x00007A68
		public DebugUIHandlerCanvas(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x00054924 File Offset: 0x00052B24
		// (set) Token: 0x060012B2 RID: 4786 RVA: 0x00009871 File Offset: 0x00007A71
		public unsafe int m_DebugTreeState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_m_DebugTreeState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_m_DebugTreeState)) = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x0005494C File Offset: 0x00052B4C
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x0000988C File Offset: 0x00007A8C
		public unsafe Dictionary<Type, Transform> m_PrefabsMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_m_PrefabsMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_m_PrefabsMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x0005497C File Offset: 0x00052B7C
		// (set) Token: 0x060012B6 RID: 4790 RVA: 0x000098AB File Offset: 0x00007AAB
		public unsafe Transform panelPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_panelPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_panelPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x000549AC File Offset: 0x00052BAC
		// (set) Token: 0x060012B8 RID: 4792 RVA: 0x000098CA File Offset: 0x00007ACA
		public unsafe List<DebugUIPrefabBundle> prefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_prefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DebugUIPrefabBundle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_prefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x000549DC File Offset: 0x00052BDC
		// (set) Token: 0x060012BA RID: 4794 RVA: 0x000098E9 File Offset: 0x00007AE9
		public unsafe List<DebugUIHandlerPanel> m_UIPanels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_m_UIPanels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DebugUIHandlerPanel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_m_UIPanels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x00054A0C File Offset: 0x00052C0C
		// (set) Token: 0x060012BC RID: 4796 RVA: 0x00009908 File Offset: 0x00007B08
		public unsafe int m_SelectedPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_m_SelectedPanel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_m_SelectedPanel)) = value;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x00054A34 File Offset: 0x00052C34
		// (set) Token: 0x060012BE RID: 4798 RVA: 0x00009923 File Offset: 0x00007B23
		public unsafe DebugUIHandlerWidget m_SelectedWidget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_m_SelectedWidget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_m_SelectedWidget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x00054A64 File Offset: 0x00052C64
		// (set) Token: 0x060012C0 RID: 4800 RVA: 0x00009942 File Offset: 0x00007B42
		public unsafe string m_CurrentQueryPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_m_CurrentQueryPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.NativeFieldInfoPtr_m_CurrentQueryPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugTreeState;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeFieldInfoPtr_m_PrefabsMap;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeFieldInfoPtr_panelPrefab;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeFieldInfoPtr_prefabs;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeFieldInfoPtr_m_UIPanels;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedPanel;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedWidget;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentQueryPath;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_RequestHierarchyReset_Internal_Void_0;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr_ResetAllHierarchy_Private_Void_0;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Private_Void_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_Traverse_Private_Void_IContainer_Transform_DebugUIHandlerWidget_byref_DebugUIHandlerWidget_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_GetWidgetFromPath_Private_DebugUIHandlerWidget_String_0;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_ActivatePanel_Private_Void_Int32_DebugUIHandlerWidget_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSelection_Internal_Void_DebugUIHandlerWidget_Boolean_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_SelectPreviousItem_Internal_Void_0;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeMethodInfoPtr_SelectNextPanel_Internal_Void_0;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeMethodInfoPtr_SelectPreviousPanel_Internal_Void_0;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeMethodInfoPtr_SelectNextItem_Internal_Void_0;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSelectionValue_Private_Void_Single_0;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_ActivateSelection_Private_Void_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_HandleInput_Private_Void_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_SetScrollTarget_Internal_Void_DebugUIHandlerWidget_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000216 RID: 534
		[ObfuscatedName("UnityEngine.Rendering.UI.DebugUIHandlerCanvas+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001B31 RID: 6961 RVA: 0x0006F370 File Offset: 0x0006D570
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DebugUIHandlerCanvas.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerCanvas.__c>.NativeClassPtr);
				DebugUIHandlerCanvas.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerCanvas.__c>.NativeClassPtr, "<>9");
				DebugUIHandlerCanvas.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerCanvas.__c>.NativeClassPtr, "<>9__12_0");
				DebugUIHandlerCanvas.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerCanvas.__c>.NativeClassPtr, "<>9__15_0");
				DebugUIHandlerCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas.__c>.NativeClassPtr, 100666031);
				DebugUIHandlerCanvas.__c.NativeMethodInfoPtr__Rebuild_b__12_0_Internal_Boolean_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas.__c>.NativeClassPtr, 100666032);
				DebugUIHandlerCanvas.__c.NativeMethodInfoPtr__ActivatePanel_b__15_0_Internal_Void_DebugUIHandlerPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas.__c>.NativeClassPtr, 100666033);
			}

			// Token: 0x06001B32 RID: 6962 RVA: 0x0006F414 File Offset: 0x0006D614
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerCanvas.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B33 RID: 6963 RVA: 0x0006F450 File Offset: 0x0006D650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979820, XrefRangeEnd = 979821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Rebuild_b__12_0(DebugUI.Widget x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.__c.NativeMethodInfoPtr__Rebuild_b__12_0_Internal_Boolean_Widget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B34 RID: 6964 RVA: 0x0006F4A0 File Offset: 0x0006D6A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979821, XrefRangeEnd = 979824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ActivatePanel_b__15_0(DebugUIHandlerPanel p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.__c.NativeMethodInfoPtr__ActivatePanel_b__15_0_Internal_Void_DebugUIHandlerPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B35 RID: 6965 RVA: 0x0000D953 File Offset: 0x0000BB53
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007AC RID: 1964
			// (get) Token: 0x06001B36 RID: 6966 RVA: 0x0006F4E4 File Offset: 0x0006D6E4
			// (set) Token: 0x06001B37 RID: 6967 RVA: 0x0000D95C File Offset: 0x0000BB5C
			public unsafe static DebugUIHandlerCanvas.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugUIHandlerCanvas.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerCanvas.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugUIHandlerCanvas.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007AD RID: 1965
			// (get) Token: 0x06001B38 RID: 6968 RVA: 0x0006F50C File Offset: 0x0006D70C
			// (set) Token: 0x06001B39 RID: 6969 RVA: 0x0000D96E File Offset: 0x0000BB6E
			public unsafe static Func<DebugUI.Widget, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugUIHandlerCanvas.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DebugUI.Widget, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugUIHandlerCanvas.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007AE RID: 1966
			// (get) Token: 0x06001B3A RID: 6970 RVA: 0x0006F534 File Offset: 0x0006D734
			// (set) Token: 0x06001B3B RID: 6971 RVA: 0x0000D980 File Offset: 0x0000BB80
			public unsafe static Action<DebugUIHandlerPanel> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugUIHandlerCanvas.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DebugUIHandlerPanel>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugUIHandlerCanvas.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013D3 RID: 5075
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040013D4 RID: 5076
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x040013D5 RID: 5077
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x040013D6 RID: 5078
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013D7 RID: 5079
			private static readonly IntPtr NativeMethodInfoPtr__Rebuild_b__12_0_Internal_Boolean_Widget_0;

			// Token: 0x040013D8 RID: 5080
			private static readonly IntPtr NativeMethodInfoPtr__ActivatePanel_b__15_0_Internal_Void_DebugUIHandlerPanel_0;
		}

		// Token: 0x02000217 RID: 535
		[ObfuscatedName("UnityEngine.Rendering.UI.DebugUIHandlerCanvas+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x06001B3C RID: 6972 RVA: 0x0006F55C File Offset: 0x0006D75C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<DebugUIHandlerCanvas.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUIHandlerCanvas>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerCanvas.__c__DisplayClass14_0>.NativeClassPtr);
				DebugUIHandlerCanvas.__c__DisplayClass14_0.NativeFieldInfoPtr_queryPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerCanvas.__c__DisplayClass14_0>.NativeClassPtr, "queryPath");
				DebugUIHandlerCanvas.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas.__c__DisplayClass14_0>.NativeClassPtr, 100666034);
				DebugUIHandlerCanvas.__c__DisplayClass14_0.NativeMethodInfoPtr__GetWidgetFromPath_b__0_Internal_Boolean_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerCanvas.__c__DisplayClass14_0>.NativeClassPtr, 100666035);
			}

			// Token: 0x06001B3D RID: 6973 RVA: 0x0006F5C4 File Offset: 0x0006D7C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerCanvas.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B3E RID: 6974 RVA: 0x0006F600 File Offset: 0x0006D800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979824, XrefRangeEnd = 979826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetWidgetFromPath_b__0(DebugUIHandlerWidget w)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(w);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerCanvas.__c__DisplayClass14_0.NativeMethodInfoPtr__GetWidgetFromPath_b__0_Internal_Boolean_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B3F RID: 6975 RVA: 0x0000D992 File Offset: 0x0000BB92
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007AF RID: 1967
			// (get) Token: 0x06001B40 RID: 6976 RVA: 0x0006F650 File Offset: 0x0006D850
			// (set) Token: 0x06001B41 RID: 6977 RVA: 0x0000D99B File Offset: 0x0000BB9B
			public unsafe string queryPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.__c__DisplayClass14_0.NativeFieldInfoPtr_queryPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerCanvas.__c__DisplayClass14_0.NativeFieldInfoPtr_queryPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040013D9 RID: 5081
			private static readonly IntPtr NativeFieldInfoPtr_queryPath;

			// Token: 0x040013DA RID: 5082
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013DB RID: 5083
			private static readonly IntPtr NativeMethodInfoPtr__GetWidgetFromPath_b__0_Internal_Boolean_DebugUIHandlerWidget_0;
		}
	}
}
