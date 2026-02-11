using System;
using boardgames.match.selection;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000CC RID: 204
	public class WormCustomConfirmOrDenyPromptBehaviour : PromptBehaviour<CustomChoiceInfoPrompt>
	{
		// Token: 0x0600089F RID: 2207 RVA: 0x00032A64 File Offset: 0x00030C64
		// Note: this type is marked as 'beforefieldinit'.
		static WormCustomConfirmOrDenyPromptBehaviour()
		{
			Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormCustomConfirmOrDenyPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptBehaviour>.NativeClassPtr);
			WormCustomConfirmOrDenyPromptBehaviour.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptBehaviour>.NativeClassPtr, "buttons");
			WormCustomConfirmOrDenyPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptBehaviour>.NativeClassPtr, 100664477);
			WormCustomConfirmOrDenyPromptBehaviour.NativeMethodInfoPtr_Event_SelectChoice_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptBehaviour>.NativeClassPtr, 100664478);
			WormCustomConfirmOrDenyPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptBehaviour>.NativeClassPtr, 100664479);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00032AE4 File Offset: 0x00030CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698776, XrefRangeEnd = 698817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCustomConfirmOrDenyPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00032B20 File Offset: 0x00030D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698817, XrefRangeEnd = 698824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SelectChoice(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomConfirmOrDenyPromptBehaviour.NativeMethodInfoPtr_Event_SelectChoice_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00032B60 File Offset: 0x00030D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698824, XrefRangeEnd = 698831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCustomConfirmOrDenyPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomConfirmOrDenyPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00006687 File Offset: 0x00004887
		public WormCustomConfirmOrDenyPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00032B9C File Offset: 0x00030D9C
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00006690 File Offset: 0x00004890
		public unsafe Il2CppReferenceArray<Button> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomConfirmOrDenyPromptBehaviour.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomConfirmOrDenyPromptBehaviour.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_Event_SelectChoice_Public_Void_Int32_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200032F RID: 815
		[ObfuscatedName("worm.match.prompts.behaviours.WormCustomConfirmOrDenyPromptBehaviour+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x060020EE RID: 8430 RVA: 0x0007C644 File Offset: 0x0007A844
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr);
				WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_buttonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr, "buttonIndex");
				WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr, 100664480);
				WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr, 100664481);
			}

			// Token: 0x060020EF RID: 8431 RVA: 0x0007C6C0 File Offset: 0x0007A8C0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020F0 RID: 8432 RVA: 0x0007C6FC File Offset: 0x0007A8FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698769, XrefRangeEnd = 698776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _initialize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020F1 RID: 8433 RVA: 0x000128AF File Offset: 0x00010AAF
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700090E RID: 2318
			// (get) Token: 0x060020F2 RID: 8434 RVA: 0x0007C730 File Offset: 0x0007A930
			// (set) Token: 0x060020F3 RID: 8435 RVA: 0x000128B8 File Offset: 0x00010AB8
			public unsafe int buttonIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_buttonIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_buttonIndex)) = value;
				}
			}

			// Token: 0x1700090F RID: 2319
			// (get) Token: 0x060020F4 RID: 8436 RVA: 0x0007C758 File Offset: 0x0007A958
			// (set) Token: 0x060020F5 RID: 8437 RVA: 0x000128D3 File Offset: 0x00010AD3
			public unsafe WormCustomConfirmOrDenyPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormCustomConfirmOrDenyPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomConfirmOrDenyPromptBehaviour.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012F9 RID: 4857
			private static readonly IntPtr NativeFieldInfoPtr_buttonIndex;

			// Token: 0x040012FA RID: 4858
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012FB RID: 4859
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012FC RID: 4860
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__0_Internal_Void_0;
		}
	}
}
