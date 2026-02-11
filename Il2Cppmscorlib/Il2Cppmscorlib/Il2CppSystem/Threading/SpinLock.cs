using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001A4 RID: 420
	[StructLayout(2)]
	public struct SpinLock
	{
		// Token: 0x06001B52 RID: 6994 RVA: 0x000A4C88 File Offset: 0x000A2E88
		// Note: this type is marked as 'beforefieldinit'.
		static SpinLock()
		{
			Il2CppClassPointerStore<SpinLock>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SpinLock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpinLock>.NativeClassPtr);
			SpinLock.NativeFieldInfoPtr_m_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, "m_owner");
			SpinLock.NativeFieldInfoPtr_MAXIMUM_WAITERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, "MAXIMUM_WAITERS");
			SpinLock.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100668009);
			SpinLock.NativeMethodInfoPtr_Enter_Public_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100668010);
			SpinLock.NativeMethodInfoPtr_TryEnter_Public_Void_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100668011);
			SpinLock.NativeMethodInfoPtr_ContinueTryEnter_Private_Void_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100668012);
			SpinLock.NativeMethodInfoPtr_DecrementWaiters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100668013);
			SpinLock.NativeMethodInfoPtr_ContinueTryEnterWithThreadTracking_Private_Void_Int32_UInt32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100668014);
			SpinLock.NativeMethodInfoPtr_Exit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100668015);
			SpinLock.NativeMethodInfoPtr_ExitSlowPath_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100668016);
			SpinLock.NativeMethodInfoPtr_get_IsHeldByCurrentThread_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100668017);
			SpinLock.NativeMethodInfoPtr_get_IsThreadOwnerTrackingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100668018);
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x000A4DA8 File Offset: 0x000A2FA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1353313, RefRangeEnd = 1353315, XrefRangeStart = 1353310, XrefRangeEnd = 1353313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpinLock(bool enableThreadOwnerTracking)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enableThreadOwnerTracking;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x000A4DDC File Offset: 0x000A2FDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1353323, RefRangeEnd = 1353327, XrefRangeStart = 1353315, XrefRangeEnd = 1353323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enter(ref bool lockTaken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &lockTaken;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_Enter_Public_Void_byref_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x000A4E10 File Offset: 0x000A3010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1353335, RefRangeEnd = 1353336, XrefRangeStart = 1353327, XrefRangeEnd = 1353335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryEnter(int millisecondsTimeout, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_TryEnter_Public_Void_Int32_byref_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x000A4E50 File Offset: 0x000A3050
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1353381, RefRangeEnd = 1353383, XrefRangeStart = 1353336, XrefRangeEnd = 1353381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_ContinueTryEnter_Private_Void_Int32_byref_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x000A4E90 File Offset: 0x000A3090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1353394, RefRangeEnd = 1353395, XrefRangeStart = 1353383, XrefRangeEnd = 1353394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecrementWaiters()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_DecrementWaiters_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x000A4EB8 File Offset: 0x000A30B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353395, XrefRangeEnd = 1353418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockTaken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_ContinueTryEnterWithThreadTracking_Private_Void_Int32_UInt32_byref_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x000A4F08 File Offset: 0x000A3108
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1353427, RefRangeEnd = 1353436, XrefRangeStart = 1353418, XrefRangeEnd = 1353427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(bool useMemoryBarrier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useMemoryBarrier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_Exit_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x000A4F3C File Offset: 0x000A313C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1353443, RefRangeEnd = 1353444, XrefRangeStart = 1353436, XrefRangeEnd = 1353443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitSlowPath(bool useMemoryBarrier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useMemoryBarrier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_ExitSlowPath_Private_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x000A4F70 File Offset: 0x000A3170
		public unsafe bool IsHeldByCurrentThread
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1353451, RefRangeEnd = 1353452, XrefRangeStart = 1353444, XrefRangeEnd = 1353451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_get_IsHeldByCurrentThread_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x000A4FA0 File Offset: 0x000A31A0
		public unsafe bool IsThreadOwnerTrackingEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353452, XrefRangeEnd = 1353453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinLock.NativeMethodInfoPtr_get_IsThreadOwnerTrackingEnabled_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x00008CAC File Offset: 0x00006EAC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, ref this));
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x000A4FD0 File Offset: 0x000A31D0
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x00008CBE File Offset: 0x00006EBE
		public unsafe static int MAXIMUM_WAITERS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SpinLock.NativeFieldInfoPtr_MAXIMUM_WAITERS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpinLock.NativeFieldInfoPtr_MAXIMUM_WAITERS, (void*)(&value));
			}
		}

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeFieldInfoPtr_m_owner;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeFieldInfoPtr_MAXIMUM_WAITERS;

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Void_byref_Boolean_0;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeMethodInfoPtr_TryEnter_Public_Void_Int32_byref_Boolean_0;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeMethodInfoPtr_ContinueTryEnter_Private_Void_Int32_byref_Boolean_0;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr_DecrementWaiters_Private_Void_0;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeMethodInfoPtr_ContinueTryEnterWithThreadTracking_Private_Void_Int32_UInt32_byref_Boolean_0;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_Boolean_0;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeMethodInfoPtr_ExitSlowPath_Private_Void_Boolean_0;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHeldByCurrentThread_Public_get_Boolean_0;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeMethodInfoPtr_get_IsThreadOwnerTrackingEnabled_Public_get_Boolean_0;

		// Token: 0x0400190C RID: 6412
		[FieldOffset(0)]
		public int m_owner;

		// Token: 0x0200060B RID: 1547
		public class SystemThreading_SpinLockDebugView : Object
		{
			// Token: 0x06005860 RID: 22624 RVA: 0x0001F797 File Offset: 0x0001D997
			// Note: this type is marked as 'beforefieldinit'.
			static SystemThreading_SpinLockDebugView()
			{
				Il2CppClassPointerStore<SpinLock.SystemThreading_SpinLockDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, "SystemThreading_SpinLockDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpinLock.SystemThreading_SpinLockDebugView>.NativeClassPtr);
			}

			// Token: 0x06005861 RID: 22625 RVA: 0x0001F7B7 File Offset: 0x0001D9B7
			public SystemThreading_SpinLockDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
