using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000151 RID: 337
	public static class UIElementsRuntimeUtilityNative : Object
	{
		// Token: 0x060018AE RID: 6318 RVA: 0x0007441C File Offset: 0x0007261C
		// Note: this type is marked as 'beforefieldinit'.
		static UIElementsRuntimeUtilityNative()
		{
			Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIElementsRuntimeUtilityNative");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr);
			UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_RepaintOverlayPanelsCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, "RepaintOverlayPanelsCallback");
			UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_UpdateRuntimePanelsCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, "UpdateRuntimePanelsCallback");
			UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_RepaintOffscreenPanelsCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, "RepaintOffscreenPanelsCallback");
			UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_RepaintOverlayPanels_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, 100666935);
			UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_UpdateRuntimePanels_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, 100666936);
			UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_RepaintOffscreenPanels_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, 100666937);
			UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_RegisterPlayerloopCallback_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, 100666938);
			UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_UnregisterPlayerloopCallback_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, 100666939);
			UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_VisualElementCreation_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, 100666940);
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00074500 File Offset: 0x00072700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320355, XrefRangeEnd = 320357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RepaintOverlayPanels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_RepaintOverlayPanels_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00074528 File Offset: 0x00072728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320357, XrefRangeEnd = 320359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateRuntimePanels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_UpdateRuntimePanels_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00074550 File Offset: 0x00072750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320359, XrefRangeEnd = 320361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RepaintOffscreenPanels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_RepaintOffscreenPanels_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00074578 File Offset: 0x00072778
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320363, RefRangeEnd = 320365, XrefRangeStart = 320361, XrefRangeEnd = 320363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterPlayerloopCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_RegisterPlayerloopCallback_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x000745A0 File Offset: 0x000727A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320367, RefRangeEnd = 320369, XrefRangeStart = 320365, XrefRangeEnd = 320367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterPlayerloopCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_UnregisterPlayerloopCallback_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x000745C8 File Offset: 0x000727C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320371, RefRangeEnd = 320372, XrefRangeStart = 320369, XrefRangeEnd = 320371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void VisualElementCreation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_VisualElementCreation_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0000B539 File Offset: 0x00009739
		public UIElementsRuntimeUtilityNative(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x000745F0 File Offset: 0x000727F0
		// (set) Token: 0x060018B7 RID: 6327 RVA: 0x0000B542 File Offset: 0x00009742
		public unsafe static Action RepaintOverlayPanelsCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_RepaintOverlayPanelsCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_RepaintOverlayPanelsCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x00074618 File Offset: 0x00072818
		// (set) Token: 0x060018B9 RID: 6329 RVA: 0x0000B554 File Offset: 0x00009754
		public unsafe static Action UpdateRuntimePanelsCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_UpdateRuntimePanelsCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_UpdateRuntimePanelsCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x00074640 File Offset: 0x00072840
		// (set) Token: 0x060018BB RID: 6331 RVA: 0x0000B566 File Offset: 0x00009766
		public unsafe static Action RepaintOffscreenPanelsCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_RepaintOffscreenPanelsCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_RepaintOffscreenPanelsCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeFieldInfoPtr_RepaintOverlayPanelsCallback;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeFieldInfoPtr_UpdateRuntimePanelsCallback;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeFieldInfoPtr_RepaintOffscreenPanelsCallback;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr_RepaintOverlayPanels_Public_Static_Void_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRuntimePanels_Public_Static_Void_0;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_RepaintOffscreenPanels_Public_Static_Void_0;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr_RegisterPlayerloopCallback_Public_Static_Void_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterPlayerloopCallback_Public_Static_Void_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_VisualElementCreation_Public_Static_Void_0;
	}
}
