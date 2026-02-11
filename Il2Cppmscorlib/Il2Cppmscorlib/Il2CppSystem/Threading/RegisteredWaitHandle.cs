using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001C1 RID: 449
	public sealed class RegisteredWaitHandle : MarshalByRefObject
	{
		// Token: 0x06001D33 RID: 7475 RVA: 0x000AC1D8 File Offset: 0x000AA3D8
		// Note: this type is marked as 'beforefieldinit'.
		static RegisteredWaitHandle()
		{
			Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "RegisteredWaitHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr);
			RegisteredWaitHandle.NativeFieldInfoPtr__waitObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_waitObject");
			RegisteredWaitHandle.NativeFieldInfoPtr__callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_callback");
			RegisteredWaitHandle.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_state");
			RegisteredWaitHandle.NativeFieldInfoPtr__finalEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_finalEvent");
			RegisteredWaitHandle.NativeFieldInfoPtr__cancelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_cancelEvent");
			RegisteredWaitHandle.NativeFieldInfoPtr__timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_timeout");
			RegisteredWaitHandle.NativeFieldInfoPtr__callsInProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_callsInProcess");
			RegisteredWaitHandle.NativeFieldInfoPtr__executeOnlyOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_executeOnlyOnce");
			RegisteredWaitHandle.NativeFieldInfoPtr__unregistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_unregistered");
			RegisteredWaitHandle.NativeMethodInfoPtr__ctor_Internal_Void_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, 100668314);
			RegisteredWaitHandle.NativeMethodInfoPtr_Wait_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, 100668315);
			RegisteredWaitHandle.NativeMethodInfoPtr_DoCallBack_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, 100668316);
			RegisteredWaitHandle.NativeMethodInfoPtr_Unregister_Public_Boolean_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, 100668317);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x000AC30C File Offset: 0x000AA50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357398, XrefRangeEnd = 1357408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisteredWaitHandle(WaitHandle waitObject, WaitOrTimerCallback callback, Object state, TimeSpan timeout, bool executeOnlyOnce)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref executeOnlyOnce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredWaitHandle.NativeMethodInfoPtr__ctor_Internal_Void_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x000AC398 File Offset: 0x000AA598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357408, XrefRangeEnd = 1357456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Wait(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredWaitHandle.NativeMethodInfoPtr_Wait_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x000AC3DC File Offset: 0x000AA5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357456, XrefRangeEnd = 1357462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCallBack(Object timedOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timedOut);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredWaitHandle.NativeMethodInfoPtr_DoCallBack_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x000AC420 File Offset: 0x000AA620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1357470, RefRangeEnd = 1357471, XrefRangeStart = 1357462, XrefRangeEnd = 1357470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Unregister(WaitHandle waitObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredWaitHandle.NativeMethodInfoPtr_Unregister_Public_Boolean_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x000095DA File Offset: 0x000077DA
		public RegisteredWaitHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x000AC470 File Offset: 0x000AA670
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x000095E3 File Offset: 0x000077E3
		public unsafe WaitHandle _waitObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__waitObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__waitObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x000AC4A0 File Offset: 0x000AA6A0
		// (set) Token: 0x06001D3C RID: 7484 RVA: 0x00009602 File Offset: 0x00007802
		public unsafe WaitOrTimerCallback _callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitOrTimerCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x000AC4D0 File Offset: 0x000AA6D0
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x00009621 File Offset: 0x00007821
		public unsafe Object _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x000AC500 File Offset: 0x000AA700
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x00009640 File Offset: 0x00007840
		public unsafe WaitHandle _finalEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__finalEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__finalEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x000AC530 File Offset: 0x000AA730
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x0000965F File Offset: 0x0000785F
		public unsafe ManualResetEvent _cancelEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__cancelEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__cancelEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x000AC560 File Offset: 0x000AA760
		// (set) Token: 0x06001D44 RID: 7492 RVA: 0x0000967E File Offset: 0x0000787E
		public unsafe TimeSpan _timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__timeout)) = value;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x000AC588 File Offset: 0x000AA788
		// (set) Token: 0x06001D46 RID: 7494 RVA: 0x00009699 File Offset: 0x00007899
		public unsafe int _callsInProcess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__callsInProcess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__callsInProcess)) = value;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x000AC5B0 File Offset: 0x000AA7B0
		// (set) Token: 0x06001D48 RID: 7496 RVA: 0x000096B4 File Offset: 0x000078B4
		public unsafe bool _executeOnlyOnce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__executeOnlyOnce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__executeOnlyOnce)) = value;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x000AC5D8 File Offset: 0x000AA7D8
		// (set) Token: 0x06001D4A RID: 7498 RVA: 0x000096CF File Offset: 0x000078CF
		public unsafe bool _unregistered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__unregistered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisteredWaitHandle.NativeFieldInfoPtr__unregistered)) = value;
			}
		}

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeFieldInfoPtr__waitObject;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeFieldInfoPtr__callback;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeFieldInfoPtr__finalEvent;

		// Token: 0x04001A62 RID: 6754
		private static readonly IntPtr NativeFieldInfoPtr__cancelEvent;

		// Token: 0x04001A63 RID: 6755
		private static readonly IntPtr NativeFieldInfoPtr__timeout;

		// Token: 0x04001A64 RID: 6756
		private static readonly IntPtr NativeFieldInfoPtr__callsInProcess;

		// Token: 0x04001A65 RID: 6757
		private static readonly IntPtr NativeFieldInfoPtr__executeOnlyOnce;

		// Token: 0x04001A66 RID: 6758
		private static readonly IntPtr NativeFieldInfoPtr__unregistered;

		// Token: 0x04001A67 RID: 6759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0;

		// Token: 0x04001A68 RID: 6760
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Internal_Void_Object_0;

		// Token: 0x04001A69 RID: 6761
		private static readonly IntPtr NativeMethodInfoPtr_DoCallBack_Private_Void_Object_0;

		// Token: 0x04001A6A RID: 6762
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Boolean_WaitHandle_0;
	}
}
