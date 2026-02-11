using System;
using boardgames.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;
using UnityEngine.UI;

namespace worm.match.components
{
	// Token: 0x020001D0 RID: 464
	public class WormAdvanceSelectionButton : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x0600148C RID: 5260 RVA: 0x00056758 File Offset: 0x00054958
		// Note: this type is marked as 'beforefieldinit'.
		static WormAdvanceSelectionButton()
		{
			Il2CppClassPointerStore<WormAdvanceSelectionButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormAdvanceSelectionButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAdvanceSelectionButton>.NativeClassPtr);
			WormAdvanceSelectionButton.NativeFieldInfoPtr_selectionKindButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAdvanceSelectionButton>.NativeClassPtr, "selectionKindButtons");
			WormAdvanceSelectionButton.NativeFieldInfoPtr_onButtonChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAdvanceSelectionButton>.NativeClassPtr, "onButtonChanged");
			WormAdvanceSelectionButton.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAdvanceSelectionButton>.NativeClassPtr, 100666104);
			WormAdvanceSelectionButton.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAdvanceSelectionButton>.NativeClassPtr, 100666105);
			WormAdvanceSelectionButton.NativeMethodInfoPtr_Event_Advance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAdvanceSelectionButton>.NativeClassPtr, 100666106);
			WormAdvanceSelectionButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAdvanceSelectionButton>.NativeClassPtr, 100666107);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00056800 File Offset: 0x00054A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714301, XrefRangeEnd = 714307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAdvanceSelectionButton.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0005683C File Offset: 0x00054A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714307, XrefRangeEnd = 714330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAdvanceSelectionButton.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00056878 File Offset: 0x00054A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714330, XrefRangeEnd = 714340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Advance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAdvanceSelectionButton.NativeMethodInfoPtr_Event_Advance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x000568AC File Offset: 0x00054AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714340, XrefRangeEnd = 714352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAdvanceSelectionButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAdvanceSelectionButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAdvanceSelectionButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x0000C996 File Offset: 0x0000AB96
		public WormAdvanceSelectionButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x000568E8 File Offset: 0x00054AE8
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x0000C99F File Offset: 0x0000AB9F
		public unsafe Il2CppReferenceArray<WormAdvanceSelectionButton.SelectionKindButton> selectionKindButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAdvanceSelectionButton.NativeFieldInfoPtr_selectionKindButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormAdvanceSelectionButton.SelectionKindButton>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAdvanceSelectionButton.NativeFieldInfoPtr_selectionKindButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x00056918 File Offset: 0x00054B18
		// (set) Token: 0x06001495 RID: 5269 RVA: 0x0000C9BE File Offset: 0x0000ABBE
		public unsafe UnityEvent onButtonChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAdvanceSelectionButton.NativeFieldInfoPtr_onButtonChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAdvanceSelectionButton.NativeFieldInfoPtr_onButtonChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeFieldInfoPtr_selectionKindButtons;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeFieldInfoPtr_onButtonChanged;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr_Event_Advance_Public_Void_0;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003D3 RID: 979
		[Serializable]
		public class SelectionKindButton : Object
		{
			// Token: 0x060027B9 RID: 10169 RVA: 0x00090A1C File Offset: 0x0008EC1C
			// Note: this type is marked as 'beforefieldinit'.
			static SelectionKindButton()
			{
				Il2CppClassPointerStore<WormAdvanceSelectionButton.SelectionKindButton>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAdvanceSelectionButton>.NativeClassPtr, "SelectionKindButton");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAdvanceSelectionButton.SelectionKindButton>.NativeClassPtr);
				WormAdvanceSelectionButton.SelectionKindButton.NativeFieldInfoPtr_Kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAdvanceSelectionButton.SelectionKindButton>.NativeClassPtr, "Kind");
				WormAdvanceSelectionButton.SelectionKindButton.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAdvanceSelectionButton.SelectionKindButton>.NativeClassPtr, "Button");
				WormAdvanceSelectionButton.SelectionKindButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAdvanceSelectionButton.SelectionKindButton>.NativeClassPtr, 100666108);
			}

			// Token: 0x060027BA RID: 10170 RVA: 0x00090A84 File Offset: 0x0008EC84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714297, XrefRangeEnd = 714301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SelectionKindButton()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAdvanceSelectionButton.SelectionKindButton>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAdvanceSelectionButton.SelectionKindButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027BB RID: 10171 RVA: 0x00015D27 File Offset: 0x00013F27
			public SelectionKindButton(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B19 RID: 2841
			// (get) Token: 0x060027BC RID: 10172 RVA: 0x00090AC0 File Offset: 0x0008ECC0
			// (set) Token: 0x060027BD RID: 10173 RVA: 0x00015D30 File Offset: 0x00013F30
			public unsafe string Kind
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAdvanceSelectionButton.SelectionKindButton.NativeFieldInfoPtr_Kind);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAdvanceSelectionButton.SelectionKindButton.NativeFieldInfoPtr_Kind), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000B1A RID: 2842
			// (get) Token: 0x060027BE RID: 10174 RVA: 0x00090AE8 File Offset: 0x0008ECE8
			// (set) Token: 0x060027BF RID: 10175 RVA: 0x00015D4F File Offset: 0x00013F4F
			public unsafe Button Button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAdvanceSelectionButton.SelectionKindButton.NativeFieldInfoPtr_Button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAdvanceSelectionButton.SelectionKindButton.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016E3 RID: 5859
			private static readonly IntPtr NativeFieldInfoPtr_Kind;

			// Token: 0x040016E4 RID: 5860
			private static readonly IntPtr NativeFieldInfoPtr_Button;

			// Token: 0x040016E5 RID: 5861
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003D4 RID: 980
		[ObfuscatedName("worm.match.components.WormAdvanceSelectionButton+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x060027C0 RID: 10176 RVA: 0x00090B18 File Offset: 0x0008ED18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<WormAdvanceSelectionButton.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAdvanceSelectionButton>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAdvanceSelectionButton.__c__DisplayClass4_0>.NativeClassPtr);
				WormAdvanceSelectionButton.__c__DisplayClass4_0.NativeFieldInfoPtr_currentKind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAdvanceSelectionButton.__c__DisplayClass4_0>.NativeClassPtr, "currentKind");
				WormAdvanceSelectionButton.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAdvanceSelectionButton.__c__DisplayClass4_0>.NativeClassPtr, 100666109);
				WormAdvanceSelectionButton.__c__DisplayClass4_0.NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Boolean_SelectionKindButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAdvanceSelectionButton.__c__DisplayClass4_0>.NativeClassPtr, 100666110);
			}

			// Token: 0x060027C1 RID: 10177 RVA: 0x00090B80 File Offset: 0x0008ED80
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAdvanceSelectionButton.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAdvanceSelectionButton.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027C2 RID: 10178 RVA: 0x00090BBC File Offset: 0x0008EDBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__0(WormAdvanceSelectionButton.SelectionKindButton buttonKindPair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buttonKindPair);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAdvanceSelectionButton.__c__DisplayClass4_0.NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Boolean_SelectionKindButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060027C3 RID: 10179 RVA: 0x00015D6E File Offset: 0x00013F6E
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B1B RID: 2843
			// (get) Token: 0x060027C4 RID: 10180 RVA: 0x00090C0C File Offset: 0x0008EE0C
			// (set) Token: 0x060027C5 RID: 10181 RVA: 0x00015D77 File Offset: 0x00013F77
			public unsafe string currentKind
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAdvanceSelectionButton.__c__DisplayClass4_0.NativeFieldInfoPtr_currentKind);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAdvanceSelectionButton.__c__DisplayClass4_0.NativeFieldInfoPtr_currentKind), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040016E6 RID: 5862
			private static readonly IntPtr NativeFieldInfoPtr_currentKind;

			// Token: 0x040016E7 RID: 5863
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016E8 RID: 5864
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Boolean_SelectionKindButton_0;
		}
	}
}
