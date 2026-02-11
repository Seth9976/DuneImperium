using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000056 RID: 86
	public class DebugDisplaySettingsCommon : Object
	{
		// Token: 0x0600070C RID: 1804 RVA: 0x0002DDC8 File Offset: 0x0002BFC8
		// Note: this type is marked as 'beforefieldinit'.
		static DebugDisplaySettingsCommon()
		{
			Il2CppClassPointerStore<DebugDisplaySettingsCommon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DebugDisplaySettingsCommon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsCommon>.NativeClassPtr);
			DebugDisplaySettingsCommon.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsCommon>.NativeClassPtr, 100664117);
			DebugDisplaySettingsCommon.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsCommon>.NativeClassPtr, 100664118);
			DebugDisplaySettingsCommon.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsCommon>.NativeClassPtr, 100664119);
			DebugDisplaySettingsCommon.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsCommon>.NativeClassPtr, 100664120);
			DebugDisplaySettingsCommon.NativeMethodInfoPtr_CreatePanel_Public_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsCommon>.NativeClassPtr, 100664121);
			DebugDisplaySettingsCommon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsCommon>.NativeClassPtr, 100664122);
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x0002DE70 File Offset: 0x0002C070
		public unsafe virtual bool AreAnySettingsActive
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsCommon.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x0002DEAC File Offset: 0x0002C0AC
		public unsafe virtual bool IsPostProcessingAllowed
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsCommon.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x0002DEE8 File Offset: 0x0002C0E8
		public unsafe virtual bool IsLightingActive
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsCommon.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0002DF24 File Offset: 0x0002C124
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsCommon.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0002DF70 File Offset: 0x0002C170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603738, XrefRangeEnd = 603742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDebugDisplaySettingsPanelDisposable CreatePanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsCommon.NativeMethodInfoPtr_CreatePanel_Public_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDebugDisplaySettingsPanelDisposable>(intPtr3) : null;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0002DFB0 File Offset: 0x0002C1B0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugDisplaySettingsCommon()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsCommon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsCommon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000051B6 File Offset: 0x000033B6
		public DebugDisplaySettingsCommon(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_CreatePanel_Public_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200016C RID: 364
		public static class WidgetFactory : Object
		{
			// Token: 0x06001C02 RID: 7170 RVA: 0x0000FEBF File Offset: 0x0000E0BF
			// Note: this type is marked as 'beforefieldinit'.
			static WidgetFactory()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsCommon.WidgetFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsCommon>.NativeClassPtr, "WidgetFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsCommon.WidgetFactory>.NativeClassPtr);
				DebugDisplaySettingsCommon.WidgetFactory.NativeMethodInfoPtr_CreateMissingDebugShadersWarning_Internal_Static_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsCommon.WidgetFactory>.NativeClassPtr, 100664123);
			}

			// Token: 0x06001C03 RID: 7171 RVA: 0x00073ADC File Offset: 0x00071CDC
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 603682, RefRangeEnd = 603687, XrefRangeStart = 603659, XrefRangeEnd = 603682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateMissingDebugShadersWarning()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsCommon.WidgetFactory.NativeMethodInfoPtr_CreateMissingDebugShadersWarning_Internal_Static_Widget_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
			}

			// Token: 0x06001C04 RID: 7172 RVA: 0x0000FEF3 File Offset: 0x0000E0F3
			public WidgetFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001464 RID: 5220
			private static readonly IntPtr NativeMethodInfoPtr_CreateMissingDebugShadersWarning_Internal_Static_Widget_0;

			// Token: 0x0200021B RID: 539
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon+WidgetFactory+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060023C6 RID: 9158 RVA: 0x000864D0 File Offset: 0x000846D0
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsCommon.WidgetFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsCommon.WidgetFactory>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsCommon.WidgetFactory.__c>.NativeClassPtr);
					DebugDisplaySettingsCommon.WidgetFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsCommon.WidgetFactory.__c>.NativeClassPtr, "<>9");
					DebugDisplaySettingsCommon.WidgetFactory.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsCommon.WidgetFactory.__c>.NativeClassPtr, "<>9__0_0");
					DebugDisplaySettingsCommon.WidgetFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsCommon.WidgetFactory.__c>.NativeClassPtr, 100664125);
					DebugDisplaySettingsCommon.WidgetFactory.__c.NativeMethodInfoPtr__CreateMissingDebugShadersWarning_b__0_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsCommon.WidgetFactory.__c>.NativeClassPtr, 100664126);
				}

				// Token: 0x060023C7 RID: 9159 RVA: 0x0008654C File Offset: 0x0008474C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsCommon.WidgetFactory.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsCommon.WidgetFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023C8 RID: 9160 RVA: 0x00086588 File Offset: 0x00084788
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603651, XrefRangeEnd = 603659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _CreateMissingDebugShadersWarning_b__0_0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsCommon.WidgetFactory.__c.NativeMethodInfoPtr__CreateMissingDebugShadersWarning_b__0_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060023C9 RID: 9161 RVA: 0x000149B5 File Offset: 0x00012BB5
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CE0 RID: 3296
				// (get) Token: 0x060023CA RID: 9162 RVA: 0x000865C4 File Offset: 0x000847C4
				// (set) Token: 0x060023CB RID: 9163 RVA: 0x000149BE File Offset: 0x00012BBE
				public unsafe static DebugDisplaySettingsCommon.WidgetFactory.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsCommon.WidgetFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsCommon.WidgetFactory.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsCommon.WidgetFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000CE1 RID: 3297
				// (get) Token: 0x060023CC RID: 9164 RVA: 0x000865EC File Offset: 0x000847EC
				// (set) Token: 0x060023CD RID: 9165 RVA: 0x000149D0 File Offset: 0x00012BD0
				public unsafe static Func<bool> __9__0_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsCommon.WidgetFactory.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsCommon.WidgetFactory.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040018EB RID: 6379
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x040018EC RID: 6380
				private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

				// Token: 0x040018ED RID: 6381
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040018EE RID: 6382
				private static readonly IntPtr NativeMethodInfoPtr__CreateMissingDebugShadersWarning_b__0_0_Internal_Boolean_0;
			}
		}

		// Token: 0x0200016D RID: 365
		public class SettingsPanel : DebugDisplaySettingsPanel
		{
			// Token: 0x06001C05 RID: 7173 RVA: 0x00073B10 File Offset: 0x00071D10
			// Note: this type is marked as 'beforefieldinit'.
			static SettingsPanel()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsCommon.SettingsPanel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsCommon>.NativeClassPtr, "SettingsPanel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsCommon.SettingsPanel>.NativeClassPtr);
				DebugDisplaySettingsCommon.SettingsPanel.NativeFieldInfoPtr_k_GoToSectionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsCommon.SettingsPanel>.NativeClassPtr, "k_GoToSectionString");
				DebugDisplaySettingsCommon.SettingsPanel.NativeMethodInfoPtr_get_Flags_Public_Virtual_get_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsCommon.SettingsPanel>.NativeClassPtr, 100664127);
				DebugDisplaySettingsCommon.SettingsPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsCommon.SettingsPanel>.NativeClassPtr, 100664128);
			}

			// Token: 0x17000A0E RID: 2574
			// (get) Token: 0x06001C06 RID: 7174 RVA: 0x00073B78 File Offset: 0x00071D78
			public unsafe override DebugUI.Flags Flags
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugDisplaySettingsCommon.SettingsPanel.NativeMethodInfoPtr_get_Flags_Public_Virtual_get_Flags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C07 RID: 7175 RVA: 0x00073BC0 File Offset: 0x00071DC0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 603737, RefRangeEnd = 603738, XrefRangeStart = 603696, XrefRangeEnd = 603737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SettingsPanel()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsCommon.SettingsPanel>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsCommon.SettingsPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C08 RID: 7176 RVA: 0x0000FEFC File Offset: 0x0000E0FC
			public SettingsPanel(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A0D RID: 2573
			// (get) Token: 0x06001C09 RID: 7177 RVA: 0x00073BFC File Offset: 0x00071DFC
			// (set) Token: 0x06001C0A RID: 7178 RVA: 0x0000FF05 File Offset: 0x0000E105
			public unsafe static string k_GoToSectionString
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsCommon.SettingsPanel.NativeFieldInfoPtr_k_GoToSectionString, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsCommon.SettingsPanel.NativeFieldInfoPtr_k_GoToSectionString, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001465 RID: 5221
			private static readonly IntPtr NativeFieldInfoPtr_k_GoToSectionString;

			// Token: 0x04001466 RID: 5222
			private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_Virtual_get_Flags_0;

			// Token: 0x04001467 RID: 5223
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200021C RID: 540
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon+SettingsPanel+<>c__DisplayClass3_0")]
			public sealed class __c__DisplayClass3_0 : Object
			{
				// Token: 0x060023CE RID: 9166 RVA: 0x00086614 File Offset: 0x00084814
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass3_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsCommon.SettingsPanel.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsCommon.SettingsPanel>.NativeClassPtr, "<>c__DisplayClass3_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsCommon.SettingsPanel.__c__DisplayClass3_0>.NativeClassPtr);
					DebugDisplaySettingsCommon.SettingsPanel.__c__DisplayClass3_0.NativeFieldInfoPtr_foldout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsCommon.SettingsPanel.__c__DisplayClass3_0>.NativeClassPtr, "foldout");
					DebugDisplaySettingsCommon.SettingsPanel.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsCommon.SettingsPanel.__c__DisplayClass3_0>.NativeClassPtr, 100664129);
					DebugDisplaySettingsCommon.SettingsPanel.__c__DisplayClass3_0.NativeMethodInfoPtr___ctor_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsCommon.SettingsPanel.__c__DisplayClass3_0>.NativeClassPtr, 100664130);
				}

				// Token: 0x060023CF RID: 9167 RVA: 0x0008667C File Offset: 0x0008487C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass3_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsCommon.SettingsPanel.__c__DisplayClass3_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsCommon.SettingsPanel.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023D0 RID: 9168 RVA: 0x000866B8 File Offset: 0x000848B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603687, XrefRangeEnd = 603696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __ctor_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsCommon.SettingsPanel.__c__DisplayClass3_0.NativeMethodInfoPtr___ctor_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023D1 RID: 9169 RVA: 0x000149E2 File Offset: 0x00012BE2
				public __c__DisplayClass3_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CE2 RID: 3298
				// (get) Token: 0x060023D2 RID: 9170 RVA: 0x000866EC File Offset: 0x000848EC
				// (set) Token: 0x060023D3 RID: 9171 RVA: 0x000149EB File Offset: 0x00012BEB
				public unsafe DebugUI.Foldout foldout
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsCommon.SettingsPanel.__c__DisplayClass3_0.NativeFieldInfoPtr_foldout);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.Foldout>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsCommon.SettingsPanel.__c__DisplayClass3_0.NativeFieldInfoPtr_foldout), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040018EF RID: 6383
				private static readonly IntPtr NativeFieldInfoPtr_foldout;

				// Token: 0x040018F0 RID: 6384
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040018F1 RID: 6385
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_Void_0;
			}
		}
	}
}
