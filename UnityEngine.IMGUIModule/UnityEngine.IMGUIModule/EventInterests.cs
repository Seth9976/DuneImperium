using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	[StructLayout(2)]
	public struct EventInterests
	{
		// Token: 0x0600005A RID: 90 RVA: 0x000063FC File Offset: 0x000045FC
		// Note: this type is marked as 'beforefieldinit'.
		static EventInterests()
		{
			Il2CppClassPointerStore<EventInterests>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "EventInterests");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventInterests>.NativeClassPtr);
			EventInterests.NativeFieldInfoPtr__wantsMouseMove_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, "<wantsMouseMove>k__BackingField");
			EventInterests.NativeFieldInfoPtr__wantsMouseEnterLeaveWindow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, "<wantsMouseEnterLeaveWindow>k__BackingField");
			EventInterests.NativeFieldInfoPtr__wantsLessLayoutEvents_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, "<wantsLessLayoutEvents>k__BackingField");
			EventInterests.NativeMethodInfoPtr_get_wantsMouseMove_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663352);
			EventInterests.NativeMethodInfoPtr_set_wantsMouseMove_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663353);
			EventInterests.NativeMethodInfoPtr_get_wantsMouseEnterLeaveWindow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663354);
			EventInterests.NativeMethodInfoPtr_set_wantsMouseEnterLeaveWindow_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663355);
			EventInterests.NativeMethodInfoPtr_get_wantsLessLayoutEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663356);
			EventInterests.NativeMethodInfoPtr_WantsEvent_Public_Boolean_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663357);
			EventInterests.NativeMethodInfoPtr_WantsLayoutPass_Public_Boolean_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663358);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000064F4 File Offset: 0x000046F4
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00006524 File Offset: 0x00004724
		public unsafe bool wantsMouseMove
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 441993, RefRangeEnd = 442038, XrefRangeStart = 441993, XrefRangeEnd = 442038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterests.NativeMethodInfoPtr_get_wantsMouseMove_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterests.NativeMethodInfoPtr_set_wantsMouseMove_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00006558 File Offset: 0x00004758
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00006588 File Offset: 0x00004788
		public unsafe bool wantsMouseEnterLeaveWindow
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterests.NativeMethodInfoPtr_get_wantsMouseEnterLeaveWindow_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685102, RefRangeEnd = 685103, XrefRangeStart = 685102, XrefRangeEnd = 685103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterests.NativeMethodInfoPtr_set_wantsMouseEnterLeaveWindow_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000065BC File Offset: 0x000047BC
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000021A3 File Offset: 0x000003A3
		public unsafe bool wantsLessLayoutEvents
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1185388, RefRangeEnd = 1185389, XrefRangeStart = 1185388, XrefRangeEnd = 1185388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterests.NativeMethodInfoPtr_get_wantsLessLayoutEvents_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._wantsLessLayoutEvents_k__BackingField = value;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000065EC File Offset: 0x000047EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1185389, RefRangeEnd = 1185390, XrefRangeStart = 1185389, XrefRangeEnd = 1185389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WantsEvent(EventType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterests.NativeMethodInfoPtr_WantsEvent_Public_Boolean_EventType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000662C File Offset: 0x0000482C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1185391, RefRangeEnd = 1185392, XrefRangeStart = 1185390, XrefRangeEnd = 1185391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WantsLayoutPass(EventType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterests.NativeMethodInfoPtr_WantsLayoutPass_Public_Boolean_EventType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002191 File Offset: 0x00000391
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, ref this));
		}

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr__wantsMouseMove_k__BackingField;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr__wantsMouseEnterLeaveWindow_k__BackingField;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr__wantsLessLayoutEvents_k__BackingField;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_wantsMouseMove_Public_get_Boolean_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_set_wantsMouseMove_Public_set_Void_Boolean_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_get_wantsMouseEnterLeaveWindow_Public_get_Boolean_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_set_wantsMouseEnterLeaveWindow_Public_set_Void_Boolean_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_wantsLessLayoutEvents_Public_get_Boolean_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_WantsEvent_Public_Boolean_EventType_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_WantsLayoutPass_Public_Boolean_EventType_0;

		// Token: 0x04000085 RID: 133
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool _wantsMouseMove_k__BackingField;

		// Token: 0x04000086 RID: 134
		[FieldOffset(1)]
		[MarshalAs(4)]
		public bool _wantsMouseEnterLeaveWindow_k__BackingField;

		// Token: 0x04000087 RID: 135
		[FieldOffset(2)]
		[MarshalAs(4)]
		public bool _wantsLessLayoutEvents_k__BackingField;
	}
}
