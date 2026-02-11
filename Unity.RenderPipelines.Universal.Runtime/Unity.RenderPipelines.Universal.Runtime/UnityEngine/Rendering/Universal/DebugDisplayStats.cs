using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200005B RID: 91
	public class DebugDisplayStats : Object
	{
		// Token: 0x060007A7 RID: 1959 RVA: 0x00030124 File Offset: 0x0002E324
		// Note: this type is marked as 'beforefieldinit'.
		static DebugDisplayStats()
		{
			Il2CppClassPointerStore<DebugDisplayStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DebugDisplayStats");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplayStats>.NativeClassPtr);
			DebugDisplayStats.NativeFieldInfoPtr_m_DebugFrameTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplayStats>.NativeClassPtr, "m_DebugFrameTiming");
			DebugDisplayStats.NativeMethodInfoPtr_UpdateFrameTiming_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplayStats>.NativeClassPtr, 100664375);
			DebugDisplayStats.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplayStats>.NativeClassPtr, 100664376);
			DebugDisplayStats.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplayStats>.NativeClassPtr, 100664377);
			DebugDisplayStats.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplayStats>.NativeClassPtr, 100664378);
			DebugDisplayStats.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplayStats>.NativeClassPtr, 100664379);
			DebugDisplayStats.NativeMethodInfoPtr_CreatePanel_Public_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplayStats>.NativeClassPtr, 100664380);
			DebugDisplayStats.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplayStats>.NativeClassPtr, 100664381);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x000301F4 File Offset: 0x0002E3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605783, XrefRangeEnd = 605785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFrameTiming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplayStats.NativeMethodInfoPtr_UpdateFrameTiming_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00030228 File Offset: 0x0002E428
		public unsafe virtual bool AreAnySettingsActive
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplayStats.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x00030264 File Offset: 0x0002E464
		public unsafe virtual bool IsPostProcessingAllowed
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplayStats.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x000302A0 File Offset: 0x0002E4A0
		public unsafe virtual bool IsLightingActive
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplayStats.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x000302DC File Offset: 0x0002E4DC
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetScreenClearColor(ref Color _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplayStats.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00030328 File Offset: 0x0002E528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605785, XrefRangeEnd = 605789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDebugDisplaySettingsPanelDisposable CreatePanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplayStats.NativeMethodInfoPtr_CreatePanel_Public_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDebugDisplaySettingsPanelDisposable>(intPtr3) : null;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00030368 File Offset: 0x0002E568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605789, XrefRangeEnd = 605795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugDisplayStats()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplayStats>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplayStats.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00005523 File Offset: 0x00003723
		public DebugDisplayStats(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x000303A4 File Offset: 0x0002E5A4
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x0000552C File Offset: 0x0000372C
		public unsafe DebugFrameTiming m_DebugFrameTiming
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplayStats.NativeFieldInfoPtr_m_DebugFrameTiming);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugFrameTiming>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplayStats.NativeFieldInfoPtr_m_DebugFrameTiming), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugFrameTiming;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFrameTiming_Public_Void_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_CreatePanel_Public_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200017A RID: 378
		public class StatsPanel : DebugDisplaySettingsPanel
		{
			// Token: 0x06001C85 RID: 7301 RVA: 0x00075220 File Offset: 0x00073420
			// Note: this type is marked as 'beforefieldinit'.
			static StatsPanel()
			{
				Il2CppClassPointerStore<DebugDisplayStats.StatsPanel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplayStats>.NativeClassPtr, "StatsPanel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplayStats.StatsPanel>.NativeClassPtr);
				DebugDisplayStats.StatsPanel.NativeMethodInfoPtr_get_Flags_Public_Virtual_get_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplayStats.StatsPanel>.NativeClassPtr, 100664382);
				DebugDisplayStats.StatsPanel.NativeMethodInfoPtr__ctor_Public_Void_DebugFrameTiming_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplayStats.StatsPanel>.NativeClassPtr, 100664383);
			}

			// Token: 0x17000A32 RID: 2610
			// (get) Token: 0x06001C86 RID: 7302 RVA: 0x00075274 File Offset: 0x00073474
			public unsafe override DebugUI.Flags Flags
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugDisplayStats.StatsPanel.NativeMethodInfoPtr_get_Flags_Public_Virtual_get_Flags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C87 RID: 7303 RVA: 0x000752BC File Offset: 0x000734BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 605782, RefRangeEnd = 605783, XrefRangeStart = 605759, XrefRangeEnd = 605782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StatsPanel(DebugFrameTiming frameTiming)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplayStats.StatsPanel>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frameTiming);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplayStats.StatsPanel.NativeMethodInfoPtr__ctor_Public_Void_DebugFrameTiming_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C88 RID: 7304 RVA: 0x00010349 File Offset: 0x0000E549
			public StatsPanel(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040014BF RID: 5311
			private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_Virtual_get_Flags_0;

			// Token: 0x040014C0 RID: 5312
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebugFrameTiming_0;
		}
	}
}
