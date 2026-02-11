using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace dwd.core.widgets.input
{
	// Token: 0x0200000C RID: 12
	public class EventOnButtonPress : MonoBehaviour
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00004284 File Offset: 0x00002484
		// Note: this type is marked as 'beforefieldinit'.
		static EventOnButtonPress()
		{
			Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "dwd.core.widgets.input", "EventOnButtonPress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr);
			EventOnButtonPress.NativeFieldInfoPtr_OnDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr, "OnDown");
			EventOnButtonPress.NativeFieldInfoPtr_OnRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr, "OnRelease");
			EventOnButtonPress.NativeFieldInfoPtr_ActionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr, "ActionName");
			EventOnButtonPress.NativeFieldInfoPtr_OnPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr, "OnPress");
			EventOnButtonPress.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr, 100663364);
			EventOnButtonPress.NativeMethodInfoPtr_call_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr, 100663365);
			EventOnButtonPress.NativeMethodInfoPtr_ButtonPressed_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr, 100663366);
			EventOnButtonPress.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr, 100663367);
			EventOnButtonPress.NativeMethodInfoPtr__OnEnable_b__5_0_Private_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr, 100663368);
			EventOnButtonPress.NativeMethodInfoPtr__OnEnable_b__5_1_Private_Boolean_Until_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr, 100663369);
			EventOnButtonPress.NativeMethodInfoPtr__OnEnable_b__5_2_Private_Void_Until_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr, 100663370);
			EventOnButtonPress.NativeMethodInfoPtr__OnEnable_b__5_3_Private_Boolean_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr, 100663371);
			EventOnButtonPress.NativeMethodInfoPtr__OnEnable_b__5_4_Private_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr, 100663372);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000043B8 File Offset: 0x000025B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254033, XrefRangeEnd = 1254041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnButtonPress.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000043EC File Offset: 0x000025EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1254053, RefRangeEnd = 1254055, XrefRangeStart = 1254041, XrefRangeEnd = 1254053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void call()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnButtonPress.NativeMethodInfoPtr_call_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004420 File Offset: 0x00002620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254055, XrefRangeEnd = 1254076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnButtonPress.NativeMethodInfoPtr_ButtonPressed_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000445C File Offset: 0x0000265C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254076, XrefRangeEnd = 1254081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventOnButtonPress()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnButtonPress.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004498 File Offset: 0x00002698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254081, XrefRangeEnd = 1254131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command _OnEnable_b__5_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnButtonPress.NativeMethodInfoPtr__OnEnable_b__5_0_Private_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000044D8 File Offset: 0x000026D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnEnable_b__5_1(Until _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnButtonPress.NativeMethodInfoPtr__OnEnable_b__5_1_Private_Boolean_Until_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004528 File Offset: 0x00002728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254131, XrefRangeEnd = 1254132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnEnable_b__5_2(Until _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnButtonPress.NativeMethodInfoPtr__OnEnable_b__5_2_Private_Void_Until_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000456C File Offset: 0x0000276C
		[CallerCount(0)]
		public unsafe bool _OnEnable_b__5_3(IEnumerator _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnButtonPress.NativeMethodInfoPtr__OnEnable_b__5_3_Private_Boolean_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000045BC File Offset: 0x000027BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnEnable_b__5_4(IEnumerator _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnButtonPress.NativeMethodInfoPtr__OnEnable_b__5_4_Private_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000022DA File Offset: 0x000004DA
		public EventOnButtonPress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00004600 File Offset: 0x00002800
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000022E3 File Offset: 0x000004E3
		public unsafe bool OnDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventOnButtonPress.NativeFieldInfoPtr_OnDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventOnButtonPress.NativeFieldInfoPtr_OnDown)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00004628 File Offset: 0x00002828
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000022FE File Offset: 0x000004FE
		public unsafe bool OnRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventOnButtonPress.NativeFieldInfoPtr_OnRelease);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventOnButtonPress.NativeFieldInfoPtr_OnRelease)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00004650 File Offset: 0x00002850
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002319 File Offset: 0x00000519
		public unsafe string ActionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventOnButtonPress.NativeFieldInfoPtr_ActionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventOnButtonPress.NativeFieldInfoPtr_ActionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00004678 File Offset: 0x00002878
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002338 File Offset: 0x00000538
		public unsafe EventOnButtonPress.PressEvent OnPress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventOnButtonPress.NativeFieldInfoPtr_OnPress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventOnButtonPress.PressEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventOnButtonPress.NativeFieldInfoPtr_OnPress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_OnDown;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_OnRelease;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_ActionName;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_OnPress;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_call_Private_Void_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_ButtonPressed_Private_Boolean_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__5_0_Private_Command_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__5_1_Private_Boolean_Until_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__5_2_Private_Void_Until_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__5_3_Private_Boolean_IEnumerator_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__5_4_Private_Void_IEnumerator_0;

		// Token: 0x02000024 RID: 36
		[Serializable]
		public class PressEvent : UnityEvent<BaseEventData>
		{
			// Token: 0x0600016D RID: 365 RVA: 0x00002AA0 File Offset: 0x00000CA0
			// Note: this type is marked as 'beforefieldinit'.
			static PressEvent()
			{
				Il2CppClassPointerStore<EventOnButtonPress.PressEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventOnButtonPress>.NativeClassPtr, "PressEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventOnButtonPress.PressEvent>.NativeClassPtr);
				EventOnButtonPress.PressEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventOnButtonPress.PressEvent>.NativeClassPtr, 100663373);
			}

			// Token: 0x0600016E RID: 366 RVA: 0x0000734C File Offset: 0x0000554C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254030, XrefRangeEnd = 1254033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PressEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventOnButtonPress.PressEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventOnButtonPress.PressEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600016F RID: 367 RVA: 0x00002AD4 File Offset: 0x00000CD4
			public PressEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040000DD RID: 221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
