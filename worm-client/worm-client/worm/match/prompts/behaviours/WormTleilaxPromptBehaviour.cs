using System;
using dwd.core.input.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000E8 RID: 232
	public class WormTleilaxPromptBehaviour : MonoBehaviour
	{
		// Token: 0x06000A54 RID: 2644 RVA: 0x00037824 File Offset: 0x00035A24
		// Note: this type is marked as 'beforefieldinit'.
		static WormTleilaxPromptBehaviour()
		{
			Il2CppClassPointerStore<WormTleilaxPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormTleilaxPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTleilaxPromptBehaviour>.NativeClassPtr);
			WormTleilaxPromptBehaviour.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxPromptBehaviour>.NativeClassPtr, "toggle");
			WormTleilaxPromptBehaviour.NativeFieldInfoPtr_inputContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxPromptBehaviour>.NativeClassPtr, "inputContext");
			WormTleilaxPromptBehaviour.NativeFieldInfoPtr__OverrideToggle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxPromptBehaviour>.NativeClassPtr, "<OverrideToggle>k__BackingField");
			WormTleilaxPromptBehaviour.NativeMethodInfoPtr_get_OverrideToggle_Public_Virtual_Final_New_get_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxPromptBehaviour>.NativeClassPtr, 100664716);
			WormTleilaxPromptBehaviour.NativeMethodInfoPtr_set_OverrideToggle_Public_Virtual_Final_New_set_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxPromptBehaviour>.NativeClassPtr, 100664717);
			WormTleilaxPromptBehaviour.NativeMethodInfoPtr_get_Toggle_Public_get_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxPromptBehaviour>.NativeClassPtr, 100664718);
			WormTleilaxPromptBehaviour.NativeMethodInfoPtr_get_InputContext_Public_get_CreateInputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxPromptBehaviour>.NativeClassPtr, 100664719);
			WormTleilaxPromptBehaviour.NativeMethodInfoPtr_Event_ToggleRow_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxPromptBehaviour>.NativeClassPtr, 100664720);
			WormTleilaxPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxPromptBehaviour>.NativeClassPtr, 100664721);
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00037908 File Offset: 0x00035B08
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00037948 File Offset: 0x00035B48
		public unsafe virtual Toggle OverrideToggle
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxPromptBehaviour.NativeMethodInfoPtr_get_OverrideToggle_Public_Virtual_Final_New_get_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxPromptBehaviour.NativeMethodInfoPtr_set_OverrideToggle_Public_Virtual_Final_New_set_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0003798C File Offset: 0x00035B8C
		public unsafe Toggle Toggle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 701462, RefRangeEnd = 701469, XrefRangeStart = 701462, XrefRangeEnd = 701462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxPromptBehaviour.NativeMethodInfoPtr_get_Toggle_Public_get_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr3) : null;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x000379CC File Offset: 0x00035BCC
		public unsafe CreateInputContext InputContext
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxPromptBehaviour.NativeMethodInfoPtr_get_InputContext_Public_get_CreateInputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CreateInputContext>(intPtr3) : null;
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00037A0C File Offset: 0x00035C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701469, XrefRangeEnd = 701471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_ToggleRow(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isOn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxPromptBehaviour.NativeMethodInfoPtr_Event_ToggleRow_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00037A4C File Offset: 0x00035C4C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTleilaxPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTleilaxPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00007671 File Offset: 0x00005871
		public WormTleilaxPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00037A88 File Offset: 0x00035C88
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x0000767A File Offset: 0x0000587A
		public unsafe Toggle toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxPromptBehaviour.NativeFieldInfoPtr_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxPromptBehaviour.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00037AB8 File Offset: 0x00035CB8
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00007699 File Offset: 0x00005899
		public unsafe CreateInputContext inputContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxPromptBehaviour.NativeFieldInfoPtr_inputContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateInputContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxPromptBehaviour.NativeFieldInfoPtr_inputContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00037AE8 File Offset: 0x00035CE8
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x000076B8 File Offset: 0x000058B8
		public unsafe Toggle _OverrideToggle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxPromptBehaviour.NativeFieldInfoPtr__OverrideToggle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxPromptBehaviour.NativeFieldInfoPtr__OverrideToggle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeFieldInfoPtr_toggle;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeFieldInfoPtr_inputContext;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeFieldInfoPtr__OverrideToggle_k__BackingField;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideToggle_Public_Virtual_Final_New_get_Toggle_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_set_OverrideToggle_Public_Virtual_Final_New_set_Void_Toggle_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_get_Toggle_Public_get_Toggle_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_get_InputContext_Public_get_CreateInputContext_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleRow_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
