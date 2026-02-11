using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000137 RID: 311
	public class RuntimePanel : BaseRuntimePanel
	{
		// Token: 0x0600174E RID: 5966 RVA: 0x0006F978 File Offset: 0x0006DB78
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimePanel()
		{
			Il2CppClassPointerStore<RuntimePanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "RuntimePanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimePanel>.NativeClassPtr);
			RuntimePanel.NativeFieldInfoPtr_s_EventDispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimePanel>.NativeClassPtr, "s_EventDispatcher");
			RuntimePanel.NativeFieldInfoPtr_m_PanelSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimePanel>.NativeClassPtr, "m_PanelSettings");
			RuntimePanel.NativeMethodInfoPtr_get_panelSettings_Public_Virtual_Final_New_get_PanelSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePanel>.NativeClassPtr, 100666776);
			RuntimePanel.NativeMethodInfoPtr_Create_Public_Static_RuntimePanel_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePanel>.NativeClassPtr, 100666777);
			RuntimePanel.NativeMethodInfoPtr__ctor_Private_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePanel>.NativeClassPtr, 100666778);
			RuntimePanel.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePanel>.NativeClassPtr, 100666779);
			RuntimePanel.NativeMethodInfoPtr_OnElementFocus_Private_Void_FocusEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePanel>.NativeClassPtr, 100666780);
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x0006FA34 File Offset: 0x0006DC34
		public unsafe virtual PanelSettings panelSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePanel.NativeMethodInfoPtr_get_panelSettings_Public_Virtual_Final_New_get_PanelSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PanelSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x0006FA74 File Offset: 0x0006DC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318729, XrefRangeEnd = 318733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimePanel Create(ScriptableObject ownerObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ownerObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePanel.NativeMethodInfoPtr_Create_Public_Static_RuntimePanel_ScriptableObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimePanel>(intPtr3) : null;
			}
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x0006FAB8 File Offset: 0x0006DCB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318790, RefRangeEnd = 318791, XrefRangeStart = 318733, XrefRangeEnd = 318790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimePanel(ScriptableObject ownerObject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimePanel>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ownerObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePanel.NativeMethodInfoPtr__ctor_Private_Void_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0006FB04 File Offset: 0x0006DD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318791, XrefRangeEnd = 318805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePanel.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0006FB40 File Offset: 0x0006DD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318805, XrefRangeEnd = 318811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementFocus(FocusEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePanel.NativeMethodInfoPtr_OnElementFocus_Private_Void_FocusEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0000AC3C File Offset: 0x00008E3C
		public RuntimePanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x0006FB84 File Offset: 0x0006DD84
		// (set) Token: 0x06001756 RID: 5974 RVA: 0x0000AC45 File Offset: 0x00008E45
		public unsafe static EventDispatcher s_EventDispatcher
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimePanel.NativeFieldInfoPtr_s_EventDispatcher, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimePanel.NativeFieldInfoPtr_s_EventDispatcher, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001757 RID: 5975 RVA: 0x0006FBAC File Offset: 0x0006DDAC
		// (set) Token: 0x06001758 RID: 5976 RVA: 0x0000AC57 File Offset: 0x00008E57
		public unsafe PanelSettings m_PanelSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePanel.NativeFieldInfoPtr_m_PanelSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PanelSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePanel.NativeFieldInfoPtr_m_PanelSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeFieldInfoPtr_s_EventDispatcher;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeFieldInfoPtr_m_PanelSettings;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_get_panelSettings_Public_Virtual_Final_New_get_PanelSettings_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_RuntimePanel_ScriptableObject_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_ScriptableObject_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_OnElementFocus_Private_Void_FocusEvent_0;

		// Token: 0x02000469 RID: 1129
		[ObfuscatedName("UnityEngine.UIElements.RuntimePanel+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003C10 RID: 15376 RVA: 0x000F1748 File Offset: 0x000EF948
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RuntimePanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimePanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimePanel.__c>.NativeClassPtr);
				RuntimePanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimePanel.__c>.NativeClassPtr, "<>9");
				RuntimePanel.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimePanel.__c>.NativeClassPtr, "<>9__5_0");
				RuntimePanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePanel.__c>.NativeClassPtr, 100666783);
				RuntimePanel.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_FocusEvent_RuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePanel.__c>.NativeClassPtr, 100666784);
			}

			// Token: 0x06003C11 RID: 15377 RVA: 0x000F17C4 File Offset: 0x000EF9C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimePanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C12 RID: 15378 RVA: 0x000F1800 File Offset: 0x000EFA00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318520, XrefRangeEnd = 318729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__5_0(FocusEvent e, RuntimePanel p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePanel.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_FocusEvent_RuntimePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C13 RID: 15379 RVA: 0x0001935D File Offset: 0x0001755D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700123A RID: 4666
			// (get) Token: 0x06003C14 RID: 15380 RVA: 0x000F1854 File Offset: 0x000EFA54
			// (set) Token: 0x06003C15 RID: 15381 RVA: 0x00019366 File Offset: 0x00017566
			public unsafe static RuntimePanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RuntimePanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimePanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RuntimePanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700123B RID: 4667
			// (get) Token: 0x06003C16 RID: 15382 RVA: 0x000F187C File Offset: 0x000EFA7C
			// (set) Token: 0x06003C17 RID: 15383 RVA: 0x00019378 File Offset: 0x00017578
			public unsafe static EventCallback<FocusEvent, RuntimePanel> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RuntimePanel.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback<FocusEvent, RuntimePanel>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RuntimePanel.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A55 RID: 10837
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002A56 RID: 10838
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04002A57 RID: 10839
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002A58 RID: 10840
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_FocusEvent_RuntimePanel_0;
		}

		// Token: 0x0200046A RID: 1130
		[Serializable]
		public new sealed class <>c
		{
		}
	}
}
