using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001A9 RID: 425
	public static class Monitor : Object
	{
		// Token: 0x06001BB0 RID: 7088 RVA: 0x000A6308 File Offset: 0x000A4508
		// Note: this type is marked as 'beforefieldinit'.
		static Monitor()
		{
			Il2CppClassPointerStore<Monitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Monitor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Monitor>.NativeClassPtr);
			Monitor.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668072);
			Monitor.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668073);
			Monitor.NativeMethodInfoPtr_ThrowLockTakenException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668074);
			Monitor.NativeMethodInfoPtr_Exit_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668075);
			Monitor.NativeMethodInfoPtr_TryEnter_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668076);
			Monitor.NativeMethodInfoPtr_TryEnter_Public_Static_Void_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668077);
			Monitor.NativeMethodInfoPtr_TryEnter_Public_Static_Void_Object_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668078);
			Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668079);
			Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668080);
			Monitor.NativeMethodInfoPtr_Pulse_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668081);
			Monitor.NativeMethodInfoPtr_PulseAll_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668082);
			Monitor.NativeMethodInfoPtr_Monitor_test_synchronised_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668083);
			Monitor.NativeMethodInfoPtr_Monitor_pulse_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668084);
			Monitor.NativeMethodInfoPtr_ObjPulse_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668085);
			Monitor.NativeMethodInfoPtr_Monitor_pulse_all_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668086);
			Monitor.NativeMethodInfoPtr_ObjPulseAll_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668087);
			Monitor.NativeMethodInfoPtr_Monitor_wait_Private_Static_Boolean_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668088);
			Monitor.NativeMethodInfoPtr_ObjWait_Private_Static_Boolean_Boolean_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668089);
			Monitor.NativeMethodInfoPtr_try_enter_with_atomic_var_Private_Static_Void_Object_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668090);
			Monitor.NativeMethodInfoPtr_ReliableEnterTimeout_Private_Static_Void_Object_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668091);
			Monitor.NativeMethodInfoPtr_ReliableEnter_Private_Static_Void_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100668092);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x000A64DC File Offset: 0x000A46DC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1353838, RefRangeEnd = 1353846, XrefRangeStart = 1353837, XrefRangeEnd = 1353838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Enter(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x000A6514 File Offset: 0x000A4714
		[CallerCount(482)]
		[CachedScanResults(RefRangeStart = 1353854, RefRangeEnd = 1354336, XrefRangeStart = 1353846, XrefRangeEnd = 1353854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Enter(Object obj, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x000A6558 File Offset: 0x000A4758
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1354344, RefRangeEnd = 1354348, XrefRangeStart = 1354336, XrefRangeEnd = 1354344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowLockTakenException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ThrowLockTakenException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x000A6580 File Offset: 0x000A4780
		[CallerCount(1127)]
		[CachedScanResults(RefRangeStart = 1354349, RefRangeEnd = 1355476, XrefRangeStart = 1354348, XrefRangeEnd = 1354349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Exit(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Exit_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x000A65B8 File Offset: 0x000A47B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1355477, RefRangeEnd = 1355478, XrefRangeStart = 1355476, XrefRangeEnd = 1355477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryEnter(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_TryEnter_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x000A65FC File Offset: 0x000A47FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1355486, RefRangeEnd = 1355488, XrefRangeStart = 1355478, XrefRangeEnd = 1355486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryEnter(Object obj, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_TryEnter_Public_Static_Void_Object_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x000A6640 File Offset: 0x000A4840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355488, XrefRangeEnd = 1355502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryEnter(Object obj, int millisecondsTimeout, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_TryEnter_Public_Static_Void_Object_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x000A6694 File Offset: 0x000A4894
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1355522, RefRangeEnd = 1355525, XrefRangeStart = 1355502, XrefRangeEnd = 1355522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Wait(Object obj, int millisecondsTimeout, bool exitContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x000A66F4 File Offset: 0x000A48F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1355522, RefRangeEnd = 1355525, XrefRangeStart = 1355522, XrefRangeEnd = 1355525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Wait(Object obj, int millisecondsTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x000A6744 File Offset: 0x000A4944
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1355539, RefRangeEnd = 1355541, XrefRangeStart = 1355525, XrefRangeEnd = 1355539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pulse(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Pulse_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x000A677C File Offset: 0x000A497C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1355555, RefRangeEnd = 1355560, XrefRangeStart = 1355541, XrefRangeEnd = 1355555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PulseAll(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_PulseAll_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x000A67B4 File Offset: 0x000A49B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355560, XrefRangeEnd = 1355561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Monitor_test_synchronised(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Monitor_test_synchronised_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x000A67F8 File Offset: 0x000A49F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355561, XrefRangeEnd = 1355562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Monitor_pulse(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Monitor_pulse_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x000A6830 File Offset: 0x000A4A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355562, XrefRangeEnd = 1355570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ObjPulse(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ObjPulse_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x000A6868 File Offset: 0x000A4A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355570, XrefRangeEnd = 1355571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Monitor_pulse_all(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Monitor_pulse_all_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x000A68A0 File Offset: 0x000A4AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355571, XrefRangeEnd = 1355579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ObjPulseAll(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ObjPulseAll_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x000A68D8 File Offset: 0x000A4AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355579, XrefRangeEnd = 1355580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Monitor_wait(Object obj, int ms)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ms;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_Monitor_wait_Private_Static_Boolean_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x000A6928 File Offset: 0x000A4B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355580, XrefRangeEnd = 1355594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ObjWait(bool exitContext, int millisecondsTimeout, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exitContext;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ObjWait_Private_Static_Boolean_Boolean_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x000A6988 File Offset: 0x000A4B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355594, XrefRangeEnd = 1355595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void try_enter_with_atomic_var(Object obj, int millisecondsTimeout, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_try_enter_with_atomic_var_Private_Static_Void_Object_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x000A69DC File Offset: 0x000A4BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355595, XrefRangeEnd = 1355608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReliableEnterTimeout(Object obj, int timeout, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ReliableEnterTimeout_Private_Static_Void_Object_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x000A6A30 File Offset: 0x000A4C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355608, XrefRangeEnd = 1355615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReliableEnter(Object obj, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_ReliableEnter_Private_Static_Void_Object_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00008EA9 File Offset: 0x000070A9
		public Monitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001944 RID: 6468
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Static_Void_Object_0;

		// Token: 0x04001945 RID: 6469
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Static_Void_Object_byref_Boolean_0;

		// Token: 0x04001946 RID: 6470
		private static readonly IntPtr NativeMethodInfoPtr_ThrowLockTakenException_Private_Static_Void_0;

		// Token: 0x04001947 RID: 6471
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Static_Void_Object_0;

		// Token: 0x04001948 RID: 6472
		private static readonly IntPtr NativeMethodInfoPtr_TryEnter_Public_Static_Boolean_Object_0;

		// Token: 0x04001949 RID: 6473
		private static readonly IntPtr NativeMethodInfoPtr_TryEnter_Public_Static_Void_Object_byref_Boolean_0;

		// Token: 0x0400194A RID: 6474
		private static readonly IntPtr NativeMethodInfoPtr_TryEnter_Public_Static_Void_Object_Int32_byref_Boolean_0;

		// Token: 0x0400194B RID: 6475
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_Boolean_0;

		// Token: 0x0400194C RID: 6476
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_0;

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeMethodInfoPtr_Pulse_Public_Static_Void_Object_0;

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeMethodInfoPtr_PulseAll_Public_Static_Void_Object_0;

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeMethodInfoPtr_Monitor_test_synchronised_Private_Static_Boolean_Object_0;

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeMethodInfoPtr_Monitor_pulse_Private_Static_Void_Object_0;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeMethodInfoPtr_ObjPulse_Private_Static_Void_Object_0;

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeMethodInfoPtr_Monitor_pulse_all_Private_Static_Void_Object_0;

		// Token: 0x04001953 RID: 6483
		private static readonly IntPtr NativeMethodInfoPtr_ObjPulseAll_Private_Static_Void_Object_0;

		// Token: 0x04001954 RID: 6484
		private static readonly IntPtr NativeMethodInfoPtr_Monitor_wait_Private_Static_Boolean_Object_Int32_0;

		// Token: 0x04001955 RID: 6485
		private static readonly IntPtr NativeMethodInfoPtr_ObjWait_Private_Static_Boolean_Boolean_Int32_Object_0;

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeMethodInfoPtr_try_enter_with_atomic_var_Private_Static_Void_Object_Int32_byref_Boolean_0;

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeMethodInfoPtr_ReliableEnterTimeout_Private_Static_Void_Object_Int32_byref_Boolean_0;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeMethodInfoPtr_ReliableEnter_Private_Static_Void_Object_byref_Boolean_0;
	}
}
