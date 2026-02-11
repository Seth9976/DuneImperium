using System;
using Canis.actions.timers;
using Canis.hasExecutionStack;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.messageRouters
{
	// Token: 0x0200006D RID: 109
	public class TimerMessageRouter : MessageRouter
	{
		// Token: 0x060005D6 RID: 1494 RVA: 0x00030488 File Offset: 0x0002E688
		// Note: this type is marked as 'beforefieldinit'.
		static TimerMessageRouter()
		{
			Il2CppClassPointerStore<TimerMessageRouter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.messageRouters", "TimerMessageRouter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerMessageRouter>.NativeClassPtr);
			TimerMessageRouter.NativeFieldInfoPtr_timerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerMessageRouter>.NativeClassPtr, "timerStack");
			TimerMessageRouter.NativeFieldInfoPtr_currentTimers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerMessageRouter>.NativeClassPtr, "currentTimers");
			TimerMessageRouter.NativeFieldInfoPtr_currentSimTimers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerMessageRouter>.NativeClassPtr, "currentSimTimers");
			TimerMessageRouter.NativeFieldInfoPtr_CLEAR_TIMER_MSG_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerMessageRouter>.NativeClassPtr, "CLEAR_TIMER_MSG_NAME");
			TimerMessageRouter.NativeFieldInfoPtr_SET_TIMER_MSG_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerMessageRouter>.NativeClassPtr, "SET_TIMER_MSG_NAME");
			TimerMessageRouter.NativeFieldInfoPtr_SET_SIMULTANEOUS_TIMER_MSG_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerMessageRouter>.NativeClassPtr, "SET_SIMULTANEOUS_TIMER_MSG_NAME");
			TimerMessageRouter.NativeFieldInfoPtr_CLEAR_SIMULTANEOUS_TIMER_MSG_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerMessageRouter>.NativeClassPtr, "CLEAR_SIMULTANEOUS_TIMER_MSG_NAME");
			TimerMessageRouter.NativeFieldInfoPtr_ADD_TIME_TIMER_MSG_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerMessageRouter>.NativeClassPtr, "ADD_TIME_TIMER_MSG_NAME");
			TimerMessageRouter.NativeFieldInfoPtr_ADD_TIME_SIMULTANEOUS_TIMER_MSG_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerMessageRouter>.NativeClassPtr, "ADD_TIME_SIMULTANEOUS_TIMER_MSG_NAME");
			TimerMessageRouter.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerMessageRouter>.NativeClassPtr, 100664490);
			TimerMessageRouter.NativeMethodInfoPtr_handle_Protected_Virtual_Boolean_Object_String_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerMessageRouter>.NativeClassPtr, 100664491);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00030594 File Offset: 0x0002E794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 555396, RefRangeEnd = 555397, XrefRangeStart = 555381, XrefRangeEnd = 555396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerMessageRouter(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerMessageRouter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerMessageRouter.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000305E0 File Offset: 0x0002E7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555397, XrefRangeEnd = 555492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool handle(Object response, string messageName, AccountID accountID = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(messageName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerMessageRouter.NativeMethodInfoPtr_handle_Protected_Virtual_Boolean_Object_String_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000047F7 File Offset: 0x000029F7
		public TimerMessageRouter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x0003065C File Offset: 0x0002E85C
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x00004800 File Offset: 0x00002A00
		public unsafe IHasExecutionStack timerStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerMessageRouter.NativeFieldInfoPtr_timerStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasExecutionStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerMessageRouter.NativeFieldInfoPtr_timerStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x0003068C File Offset: 0x0002E88C
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x0000481F File Offset: 0x00002A1F
		public unsafe Dictionary<TimerID, SetTimerAction> currentTimers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerMessageRouter.NativeFieldInfoPtr_currentTimers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TimerID, SetTimerAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerMessageRouter.NativeFieldInfoPtr_currentTimers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x000306BC File Offset: 0x0002E8BC
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x0000483E File Offset: 0x00002A3E
		public unsafe Dictionary<TimerID, SetSimultaneousTimerAction> currentSimTimers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerMessageRouter.NativeFieldInfoPtr_currentSimTimers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TimerID, SetSimultaneousTimerAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerMessageRouter.NativeFieldInfoPtr_currentSimTimers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x000306EC File Offset: 0x0002E8EC
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x0000485D File Offset: 0x00002A5D
		public unsafe static string CLEAR_TIMER_MSG_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerMessageRouter.NativeFieldInfoPtr_CLEAR_TIMER_MSG_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerMessageRouter.NativeFieldInfoPtr_CLEAR_TIMER_MSG_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0003070C File Offset: 0x0002E90C
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x0000486F File Offset: 0x00002A6F
		public unsafe static string SET_TIMER_MSG_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerMessageRouter.NativeFieldInfoPtr_SET_TIMER_MSG_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerMessageRouter.NativeFieldInfoPtr_SET_TIMER_MSG_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0003072C File Offset: 0x0002E92C
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00004881 File Offset: 0x00002A81
		public unsafe static string SET_SIMULTANEOUS_TIMER_MSG_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerMessageRouter.NativeFieldInfoPtr_SET_SIMULTANEOUS_TIMER_MSG_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerMessageRouter.NativeFieldInfoPtr_SET_SIMULTANEOUS_TIMER_MSG_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x0003074C File Offset: 0x0002E94C
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x00004893 File Offset: 0x00002A93
		public unsafe static string CLEAR_SIMULTANEOUS_TIMER_MSG_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerMessageRouter.NativeFieldInfoPtr_CLEAR_SIMULTANEOUS_TIMER_MSG_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerMessageRouter.NativeFieldInfoPtr_CLEAR_SIMULTANEOUS_TIMER_MSG_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x0003076C File Offset: 0x0002E96C
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x000048A5 File Offset: 0x00002AA5
		public unsafe static string ADD_TIME_TIMER_MSG_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerMessageRouter.NativeFieldInfoPtr_ADD_TIME_TIMER_MSG_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerMessageRouter.NativeFieldInfoPtr_ADD_TIME_TIMER_MSG_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0003078C File Offset: 0x0002E98C
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x000048B7 File Offset: 0x00002AB7
		public unsafe static string ADD_TIME_SIMULTANEOUS_TIMER_MSG_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerMessageRouter.NativeFieldInfoPtr_ADD_TIME_SIMULTANEOUS_TIMER_MSG_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerMessageRouter.NativeFieldInfoPtr_ADD_TIME_SIMULTANEOUS_TIMER_MSG_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeFieldInfoPtr_timerStack;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeFieldInfoPtr_currentTimers;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeFieldInfoPtr_currentSimTimers;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeFieldInfoPtr_CLEAR_TIMER_MSG_NAME;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeFieldInfoPtr_SET_TIMER_MSG_NAME;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeFieldInfoPtr_SET_SIMULTANEOUS_TIMER_MSG_NAME;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeFieldInfoPtr_CLEAR_SIMULTANEOUS_TIMER_MSG_NAME;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr_ADD_TIME_TIMER_MSG_NAME;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr_ADD_TIME_SIMULTANEOUS_TIMER_MSG_NAME;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_handle_Protected_Virtual_Boolean_Object_String_AccountID_0;
	}
}
