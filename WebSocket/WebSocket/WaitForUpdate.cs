using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

// Token: 0x02000006 RID: 6
public class WaitForUpdate : CustomYieldInstruction
{
	// Token: 0x06000020 RID: 32 RVA: 0x00003104 File Offset: 0x00001304
	// Note: this type is marked as 'beforefieldinit'.
	static WaitForUpdate()
	{
		Il2CppClassPointerStore<WaitForUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("WebSocket.dll", "", "WaitForUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForUpdate>.NativeClassPtr);
		WaitForUpdate.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate>.NativeClassPtr, 100663314);
		WaitForUpdate.NativeMethodInfoPtr_GetAwaiter_Public_MainThreadAwaiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate>.NativeClassPtr, 100663315);
		WaitForUpdate.NativeMethodInfoPtr_CoroutineWrapper_Public_Static_IEnumerator_IEnumerator_MainThreadAwaiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate>.NativeClassPtr, 100663316);
		WaitForUpdate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate>.NativeClassPtr, 100663317);
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000021 RID: 33 RVA: 0x00003184 File Offset: 0x00001384
	public unsafe override bool keepWaiting
	{
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitForUpdate.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000031CC File Offset: 0x000013CC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1262452, RefRangeEnd = 1262453, XrefRangeStart = 1262441, XrefRangeEnd = 1262452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaitForUpdate.MainThreadAwaiter GetAwaiter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForUpdate.NativeMethodInfoPtr_GetAwaiter_Public_MainThreadAwaiter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitForUpdate.MainThreadAwaiter>(intPtr3) : null;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x0000320C File Offset: 0x0000140C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262453, XrefRangeEnd = 1262459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator CoroutineWrapper(IEnumerator theWorker, WaitForUpdate.MainThreadAwaiter awaiter)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(theWorker);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(awaiter);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForUpdate.NativeMethodInfoPtr_CoroutineWrapper_Public_Static_IEnumerator_IEnumerator_MainThreadAwaiter_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00003264 File Offset: 0x00001464
	[CallerCount(220)]
	[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaitForUpdate()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForUpdate>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForUpdate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002119 File Offset: 0x00000319
	public WaitForUpdate(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

	// Token: 0x04000014 RID: 20
	private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_MainThreadAwaiter_0;

	// Token: 0x04000015 RID: 21
	private static readonly IntPtr NativeMethodInfoPtr_CoroutineWrapper_Public_Static_IEnumerator_IEnumerator_MainThreadAwaiter_0;

	// Token: 0x04000016 RID: 22
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000010 RID: 16
	public class MainThreadAwaiter : global::Il2CppSystem.Object
	{
		// Token: 0x0600006C RID: 108 RVA: 0x0000401C File Offset: 0x0000221C
		// Note: this type is marked as 'beforefieldinit'.
		static MainThreadAwaiter()
		{
			Il2CppClassPointerStore<WaitForUpdate.MainThreadAwaiter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitForUpdate>.NativeClassPtr, "MainThreadAwaiter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForUpdate.MainThreadAwaiter>.NativeClassPtr);
			WaitForUpdate.MainThreadAwaiter.NativeFieldInfoPtr_continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForUpdate.MainThreadAwaiter>.NativeClassPtr, "continuation");
			WaitForUpdate.MainThreadAwaiter.NativeFieldInfoPtr__IsCompleted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForUpdate.MainThreadAwaiter>.NativeClassPtr, "<IsCompleted>k__BackingField");
			WaitForUpdate.MainThreadAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate.MainThreadAwaiter>.NativeClassPtr, 100663318);
			WaitForUpdate.MainThreadAwaiter.NativeMethodInfoPtr_set_IsCompleted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate.MainThreadAwaiter>.NativeClassPtr, 100663319);
			WaitForUpdate.MainThreadAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate.MainThreadAwaiter>.NativeClassPtr, 100663320);
			WaitForUpdate.MainThreadAwaiter.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate.MainThreadAwaiter>.NativeClassPtr, 100663321);
			WaitForUpdate.MainThreadAwaiter.NativeMethodInfoPtr_System_Runtime_CompilerServices_INotifyCompletion_OnCompleted_Private_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate.MainThreadAwaiter>.NativeClassPtr, 100663322);
			WaitForUpdate.MainThreadAwaiter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate.MainThreadAwaiter>.NativeClassPtr, 100663323);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000040E8 File Offset: 0x000022E8
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00004124 File Offset: 0x00002324
		public unsafe bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForUpdate.MainThreadAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForUpdate.MainThreadAwaiter.NativeMethodInfoPtr_set_IsCompleted_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004164 File Offset: 0x00002364
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForUpdate.MainThreadAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004198 File Offset: 0x00002398
		[CallerCount(0)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForUpdate.MainThreadAwaiter.NativeMethodInfoPtr_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000041CC File Offset: 0x000023CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_CompilerServices_INotifyCompletion_OnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForUpdate.MainThreadAwaiter.NativeMethodInfoPtr_System_Runtime_CompilerServices_INotifyCompletion_OnCompleted_Private_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004210 File Offset: 0x00002410
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainThreadAwaiter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForUpdate.MainThreadAwaiter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForUpdate.MainThreadAwaiter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002350 File Offset: 0x00000550
		public MainThreadAwaiter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000424C File Offset: 0x0000244C
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002359 File Offset: 0x00000559
		public unsafe Action continuation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForUpdate.MainThreadAwaiter.NativeFieldInfoPtr_continuation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForUpdate.MainThreadAwaiter.NativeFieldInfoPtr_continuation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000427C File Offset: 0x0000247C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002378 File Offset: 0x00000578
		public unsafe bool _IsCompleted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForUpdate.MainThreadAwaiter.NativeFieldInfoPtr__IsCompleted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForUpdate.MainThreadAwaiter.NativeFieldInfoPtr__IsCompleted_k__BackingField)) = value;
			}
		}

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_continuation;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr__IsCompleted_k__BackingField;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCompleted_Public_set_Void_Boolean_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_CompilerServices_INotifyCompletion_OnCompleted_Private_Virtual_Final_New_Void_Action_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x02000011 RID: 17
	[ObfuscatedName("WaitForUpdate+<CoroutineWrapper>d__4")]
	public sealed class _CoroutineWrapper_d__4 : global::Il2CppSystem.Object
	{
		// Token: 0x06000078 RID: 120 RVA: 0x000042A4 File Offset: 0x000024A4
		// Note: this type is marked as 'beforefieldinit'.
		static _CoroutineWrapper_d__4()
		{
			Il2CppClassPointerStore<WaitForUpdate._CoroutineWrapper_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitForUpdate>.NativeClassPtr, "<CoroutineWrapper>d__4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForUpdate._CoroutineWrapper_d__4>.NativeClassPtr);
			WaitForUpdate._CoroutineWrapper_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForUpdate._CoroutineWrapper_d__4>.NativeClassPtr, "<>1__state");
			WaitForUpdate._CoroutineWrapper_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForUpdate._CoroutineWrapper_d__4>.NativeClassPtr, "<>2__current");
			WaitForUpdate._CoroutineWrapper_d__4.NativeFieldInfoPtr_theWorker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForUpdate._CoroutineWrapper_d__4>.NativeClassPtr, "theWorker");
			WaitForUpdate._CoroutineWrapper_d__4.NativeFieldInfoPtr_awaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForUpdate._CoroutineWrapper_d__4>.NativeClassPtr, "awaiter");
			WaitForUpdate._CoroutineWrapper_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate._CoroutineWrapper_d__4>.NativeClassPtr, 100663324);
			WaitForUpdate._CoroutineWrapper_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate._CoroutineWrapper_d__4>.NativeClassPtr, 100663325);
			WaitForUpdate._CoroutineWrapper_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate._CoroutineWrapper_d__4>.NativeClassPtr, 100663326);
			WaitForUpdate._CoroutineWrapper_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate._CoroutineWrapper_d__4>.NativeClassPtr, 100663327);
			WaitForUpdate._CoroutineWrapper_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate._CoroutineWrapper_d__4>.NativeClassPtr, 100663328);
			WaitForUpdate._CoroutineWrapper_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForUpdate._CoroutineWrapper_d__4>.NativeClassPtr, 100663329);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004398 File Offset: 0x00002598
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _CoroutineWrapper_d__4(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForUpdate._CoroutineWrapper_d__4>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForUpdate._CoroutineWrapper_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000043E0 File Offset: 0x000025E0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForUpdate._CoroutineWrapper_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004414 File Offset: 0x00002614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262435, XrefRangeEnd = 1262436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForUpdate._CoroutineWrapper_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00004450 File Offset: 0x00002650
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForUpdate._CoroutineWrapper_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004490 File Offset: 0x00002690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262436, XrefRangeEnd = 1262441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForUpdate._CoroutineWrapper_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000044C4 File Offset: 0x000026C4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForUpdate._CoroutineWrapper_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002393 File Offset: 0x00000593
		public _CoroutineWrapper_d__4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00004504 File Offset: 0x00002704
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000239C File Offset: 0x0000059C
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForUpdate._CoroutineWrapper_d__4.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForUpdate._CoroutineWrapper_d__4.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000452C File Offset: 0x0000272C
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000023B7 File Offset: 0x000005B7
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForUpdate._CoroutineWrapper_d__4.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForUpdate._CoroutineWrapper_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000455C File Offset: 0x0000275C
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000023D6 File Offset: 0x000005D6
		public unsafe IEnumerator theWorker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForUpdate._CoroutineWrapper_d__4.NativeFieldInfoPtr_theWorker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForUpdate._CoroutineWrapper_d__4.NativeFieldInfoPtr_theWorker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000458C File Offset: 0x0000278C
		// (set) Token: 0x06000087 RID: 135 RVA: 0x000023F5 File Offset: 0x000005F5
		public unsafe WaitForUpdate.MainThreadAwaiter awaiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForUpdate._CoroutineWrapper_d__4.NativeFieldInfoPtr_awaiter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForUpdate.MainThreadAwaiter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForUpdate._CoroutineWrapper_d__4.NativeFieldInfoPtr_awaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_theWorker;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_awaiter;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
