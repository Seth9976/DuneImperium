using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;

namespace Canis.messages.timer
{
	// Token: 0x0200003A RID: 58
	public class SetSimultaneousTimer : NetworkMessageEvent
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x0000AB98 File Offset: 0x00008D98
		// Note: this type is marked as 'beforefieldinit'.
		static SetSimultaneousTimer()
		{
			Il2CppClassPointerStore<SetSimultaneousTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.timer", "SetSimultaneousTimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSimultaneousTimer>.NativeClassPtr);
			SetSimultaneousTimer.NativeFieldInfoPtr_TimerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimer>.NativeClassPtr, "TimerID");
			SetSimultaneousTimer.NativeFieldInfoPtr_Wait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimer>.NativeClassPtr, "Wait");
			SetSimultaneousTimer.NativeFieldInfoPtr_SelectionMessageMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimer>.NativeClassPtr, "SelectionMessageMap");
			SetSimultaneousTimer.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimer>.NativeClassPtr, "startTime");
			SetSimultaneousTimer.NativeFieldInfoPtr__GameID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimer>.NativeClassPtr, "<GameID>k__BackingField");
			SetSimultaneousTimer.NativeMethodInfoPtr_get_GameID_Public_Virtual_Final_New_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimer>.NativeClassPtr, 100663390);
			SetSimultaneousTimer.NativeMethodInfoPtr__ctor_Public_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimer>.NativeClassPtr, 100663391);
			SetSimultaneousTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimer>.NativeClassPtr, 100663392);
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000AC68 File Offset: 0x00008E68
		public unsafe virtual GameID GameID
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimer.NativeMethodInfoPtr_get_GameID_Public_Virtual_Final_New_get_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000ACA8 File Offset: 0x00008EA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1193708, RefRangeEnd = 1193709, XrefRangeStart = 1193702, XrefRangeEnd = 1193708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetSimultaneousTimer(GameID gameID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSimultaneousTimer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimer.NativeMethodInfoPtr__ctor_Public_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000ACF4 File Offset: 0x00008EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193709, XrefRangeEnd = 1193714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetSimultaneousTimer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSimultaneousTimer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000034AD File Offset: 0x000016AD
		public SetSimultaneousTimer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000AD30 File Offset: 0x00008F30
		// (set) Token: 0x060001EB RID: 491 RVA: 0x000034B6 File Offset: 0x000016B6
		public unsafe TimerID TimerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimer.NativeFieldInfoPtr_TimerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimer.NativeFieldInfoPtr_TimerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000AD60 File Offset: 0x00008F60
		// (set) Token: 0x060001ED RID: 493 RVA: 0x000034D5 File Offset: 0x000016D5
		public unsafe int Wait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimer.NativeFieldInfoPtr_Wait);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimer.NativeFieldInfoPtr_Wait)) = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000AD88 File Offset: 0x00008F88
		// (set) Token: 0x060001EF RID: 495 RVA: 0x000034F0 File Offset: 0x000016F0
		public unsafe Dictionary<AccountID, SelectionMessage> SelectionMessageMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimer.NativeFieldInfoPtr_SelectionMessageMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, SelectionMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimer.NativeFieldInfoPtr_SelectionMessageMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x0000350F File Offset: 0x0000170F
		public unsafe DateTime startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimer.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimer.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000ADE0 File Offset: 0x00008FE0
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0000352A File Offset: 0x0000172A
		public unsafe GameID _GameID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimer.NativeFieldInfoPtr__GameID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimer.NativeFieldInfoPtr__GameID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_TimerID;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_Wait;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_SelectionMessageMap;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr__GameID_k__BackingField;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_Virtual_Final_New_get_GameID_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
