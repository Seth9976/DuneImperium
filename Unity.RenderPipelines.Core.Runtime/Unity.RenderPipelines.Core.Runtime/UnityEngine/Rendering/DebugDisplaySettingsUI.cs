using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x0200005E RID: 94
	public class DebugDisplaySettingsUI : Object
	{
		// Token: 0x06000663 RID: 1635 RVA: 0x00025DD4 File Offset: 0x00023FD4
		// Note: this type is marked as 'beforefieldinit'.
		static DebugDisplaySettingsUI()
		{
			Il2CppClassPointerStore<DebugDisplaySettingsUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DebugDisplaySettingsUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsUI>.NativeClassPtr);
			DebugDisplaySettingsUI.NativeFieldInfoPtr_m_DisposablePanels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsUI>.NativeClassPtr, "m_DisposablePanels");
			DebugDisplaySettingsUI.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsUI>.NativeClassPtr, "m_Settings");
			DebugDisplaySettingsUI.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsUI>.NativeClassPtr, 100664137);
			DebugDisplaySettingsUI.NativeMethodInfoPtr_RegisterDebug_Public_Void_IDebugDisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsUI>.NativeClassPtr, 100664138);
			DebugDisplaySettingsUI.NativeMethodInfoPtr_UnregisterDebug_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsUI>.NativeClassPtr, 100664139);
			DebugDisplaySettingsUI.NativeMethodInfoPtr_GetReset_Public_Virtual_Final_New_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsUI>.NativeClassPtr, 100664140);
			DebugDisplaySettingsUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsUI>.NativeClassPtr, 100664141);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00025E90 File Offset: 0x00024090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961065, XrefRangeEnd = 961074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsUI.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00025EC4 File Offset: 0x000240C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 961111, RefRangeEnd = 961113, XrefRangeStart = 961074, XrefRangeEnd = 961111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDebug(IDebugDisplaySettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsUI.NativeMethodInfoPtr_RegisterDebug_Public_Void_IDebugDisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00025F08 File Offset: 0x00024108
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 961156, RefRangeEnd = 961158, XrefRangeStart = 961113, XrefRangeEnd = 961156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterDebug()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsUI.NativeMethodInfoPtr_UnregisterDebug_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00025F3C File Offset: 0x0002413C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961158, XrefRangeEnd = 961164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Action GetReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsUI.NativeMethodInfoPtr_GetReset_Public_Virtual_Final_New_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00025F7C File Offset: 0x0002417C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugDisplaySettingsUI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0000487C File Offset: 0x00002A7C
		public DebugDisplaySettingsUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00025FB8 File Offset: 0x000241B8
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00004885 File Offset: 0x00002A85
		public unsafe IEnumerable<IDebugDisplaySettingsPanelDisposable> m_DisposablePanels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsUI.NativeFieldInfoPtr_m_DisposablePanels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<IDebugDisplaySettingsPanelDisposable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsUI.NativeFieldInfoPtr_m_DisposablePanels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00025FE8 File Offset: 0x000241E8
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x000048A4 File Offset: 0x00002AA4
		public unsafe IDebugDisplaySettings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsUI.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDebugDisplaySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsUI.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeFieldInfoPtr_m_DisposablePanels;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDebug_Public_Void_IDebugDisplaySettings_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDebug_Public_Void_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_GetReset_Public_Virtual_Final_New_Action_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000188 RID: 392
		[ObfuscatedName("UnityEngine.Rendering.DebugDisplaySettingsUI+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06001657 RID: 5719 RVA: 0x00060C24 File Offset: 0x0005EE24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsUI.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsUI>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsUI.__c__DisplayClass3_0>.NativeClassPtr);
				DebugDisplaySettingsUI.__c__DisplayClass3_0.NativeFieldInfoPtr_debugManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsUI.__c__DisplayClass3_0>.NativeClassPtr, "debugManager");
				DebugDisplaySettingsUI.__c__DisplayClass3_0.NativeFieldInfoPtr_panels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsUI.__c__DisplayClass3_0>.NativeClassPtr, "panels");
				DebugDisplaySettingsUI.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsUI.__c__DisplayClass3_0>.NativeClassPtr, 100664142);
				DebugDisplaySettingsUI.__c__DisplayClass3_0.NativeMethodInfoPtr__RegisterDebug_b__0_Internal_Void_IDebugDisplaySettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsUI.__c__DisplayClass3_0>.NativeClassPtr, 100664143);
			}

			// Token: 0x06001658 RID: 5720 RVA: 0x00060CA0 File Offset: 0x0005EEA0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsUI.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsUI.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001659 RID: 5721 RVA: 0x00060CDC File Offset: 0x0005EEDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961041, XrefRangeEnd = 961065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterDebug_b__0(IDebugDisplaySettingsData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsUI.__c__DisplayClass3_0.NativeMethodInfoPtr__RegisterDebug_b__0_Internal_Void_IDebugDisplaySettingsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600165A RID: 5722 RVA: 0x0000B3A1 File Offset: 0x000095A1
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000631 RID: 1585
			// (get) Token: 0x0600165B RID: 5723 RVA: 0x00060D20 File Offset: 0x0005EF20
			// (set) Token: 0x0600165C RID: 5724 RVA: 0x0000B3AA File Offset: 0x000095AA
			public unsafe DebugManager debugManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsUI.__c__DisplayClass3_0.NativeFieldInfoPtr_debugManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsUI.__c__DisplayClass3_0.NativeFieldInfoPtr_debugManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000632 RID: 1586
			// (get) Token: 0x0600165D RID: 5725 RVA: 0x00060D50 File Offset: 0x0005EF50
			// (set) Token: 0x0600165E RID: 5726 RVA: 0x0000B3C9 File Offset: 0x000095C9
			public unsafe List<IDebugDisplaySettingsPanelDisposable> panels
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsUI.__c__DisplayClass3_0.NativeFieldInfoPtr_panels);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IDebugDisplaySettingsPanelDisposable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsUI.__c__DisplayClass3_0.NativeFieldInfoPtr_panels), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400104A RID: 4170
			private static readonly IntPtr NativeFieldInfoPtr_debugManager;

			// Token: 0x0400104B RID: 4171
			private static readonly IntPtr NativeFieldInfoPtr_panels;

			// Token: 0x0400104C RID: 4172
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400104D RID: 4173
			private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__0_Internal_Void_IDebugDisplaySettingsData_0;
		}
	}
}
