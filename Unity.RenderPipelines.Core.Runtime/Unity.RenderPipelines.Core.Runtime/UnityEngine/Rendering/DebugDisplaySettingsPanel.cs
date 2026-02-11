using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x0200005C RID: 92
	public class DebugDisplaySettingsPanel : Object
	{
		// Token: 0x0600064E RID: 1614 RVA: 0x000257BC File Offset: 0x000239BC
		// Note: this type is marked as 'beforefieldinit'.
		static DebugDisplaySettingsPanel()
		{
			Il2CppClassPointerStore<DebugDisplaySettingsPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DebugDisplaySettingsPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsPanel>.NativeClassPtr);
			DebugDisplaySettingsPanel.NativeFieldInfoPtr_m_Widgets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsPanel>.NativeClassPtr, "m_Widgets");
			DebugDisplaySettingsPanel.NativeFieldInfoPtr_m_DisplayInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsPanel>.NativeClassPtr, "m_DisplayInfo");
			DebugDisplaySettingsPanel.NativeMethodInfoPtr_get_PanelName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsPanel>.NativeClassPtr, 100664126);
			DebugDisplaySettingsPanel.NativeMethodInfoPtr_get_Order_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsPanel>.NativeClassPtr, 100664127);
			DebugDisplaySettingsPanel.NativeMethodInfoPtr_get_Widgets_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsPanel>.NativeClassPtr, 100664128);
			DebugDisplaySettingsPanel.NativeMethodInfoPtr_get_Flags_Public_Virtual_New_get_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsPanel>.NativeClassPtr, 100664129);
			DebugDisplaySettingsPanel.NativeMethodInfoPtr_AddWidget_Protected_Void_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsPanel>.NativeClassPtr, 100664130);
			DebugDisplaySettingsPanel.NativeMethodInfoPtr_Clear_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsPanel>.NativeClassPtr, 100664131);
			DebugDisplaySettingsPanel.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsPanel>.NativeClassPtr, 100664132);
			DebugDisplaySettingsPanel.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsPanel>.NativeClassPtr, 100664133);
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x000258B4 File Offset: 0x00023AB4
		public unsafe virtual string PanelName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960972, XrefRangeEnd = 960974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugDisplaySettingsPanel.NativeMethodInfoPtr_get_PanelName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x000258F8 File Offset: 0x00023AF8
		public unsafe virtual int Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugDisplaySettingsPanel.NativeMethodInfoPtr_get_Order_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00025940 File Offset: 0x00023B40
		public unsafe virtual Il2CppReferenceArray<DebugUI.Widget> Widgets
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960974, XrefRangeEnd = 960978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsPanel.NativeMethodInfoPtr_get_Widgets_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Widget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DebugUI.Widget>>(intPtr3) : null;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00025980 File Offset: 0x00023B80
		public unsafe virtual DebugUI.Flags Flags
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugDisplaySettingsPanel.NativeMethodInfoPtr_get_Flags_Public_Virtual_New_get_Flags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000259C8 File Offset: 0x00023BC8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 960988, RefRangeEnd = 961001, XrefRangeStart = 960978, XrefRangeEnd = 960988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddWidget(DebugUI.Widget widget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsPanel.NativeMethodInfoPtr_AddWidget_Protected_Void_Widget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00025A0C File Offset: 0x00023C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961001, XrefRangeEnd = 961003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsPanel.NativeMethodInfoPtr_Clear_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00025A40 File Offset: 0x00023C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsPanel.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00025A74 File Offset: 0x00023C74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 961026, RefRangeEnd = 961030, XrefRangeStart = 961003, XrefRangeEnd = 961026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugDisplaySettingsPanel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsPanel.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0000482C File Offset: 0x00002A2C
		public DebugDisplaySettingsPanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00025AB0 File Offset: 0x00023CB0
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00004835 File Offset: 0x00002A35
		public unsafe List<DebugUI.Widget> m_Widgets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsPanel.NativeFieldInfoPtr_m_Widgets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DebugUI.Widget>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsPanel.NativeFieldInfoPtr_m_Widgets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00025AE0 File Offset: 0x00023CE0
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x00004854 File Offset: 0x00002A54
		public unsafe DisplayInfoAttribute m_DisplayInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsPanel.NativeFieldInfoPtr_m_DisplayInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayInfoAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsPanel.NativeFieldInfoPtr_m_DisplayInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeFieldInfoPtr_m_Widgets;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeFieldInfoPtr_m_DisplayInfo;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_get_PanelName_Public_Virtual_New_get_String_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_Virtual_New_get_Int32_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_get_Widgets_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Widget_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_Virtual_New_get_Flags_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_AddWidget_Protected_Void_Widget_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Protected_Void_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
