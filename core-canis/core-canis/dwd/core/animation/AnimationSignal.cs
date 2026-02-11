using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x02000216 RID: 534
	public class AnimationSignal : MonoBehaviour
	{
		// Token: 0x06001D41 RID: 7489 RVA: 0x00087858 File Offset: 0x00085A58
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationSignal()
		{
			Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.animation", "AnimationSignal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr);
			AnimationSignal.NativeFieldInfoPtr_signals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr, "signals");
			AnimationSignal.NativeFieldInfoPtr_waiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr, "waiting");
			AnimationSignal.NativeMethodInfoPtr_RaiseSignal_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr, 100668003);
			AnimationSignal.NativeMethodInfoPtr_IsWaiting_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr, 100668004);
			AnimationSignal.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr, 100668005);
			AnimationSignal.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr, 100668006);
			AnimationSignal.NativeMethodInfoPtr_WaitForSignal_Public_Coroutine_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr, 100668007);
			AnimationSignal.NativeMethodInfoPtr_GetWaitForSignal_Public_Command_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr, 100668008);
			AnimationSignal.NativeMethodInfoPtr_waitForSignal_Private_IEnumerator_AnimationSignal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr, 100668009);
			AnimationSignal.NativeMethodInfoPtr_waitForSignal_Private_IEnumerator_AnimationSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr, 100668010);
			AnimationSignal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr, 100668011);
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x00087964 File Offset: 0x00085B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886262, XrefRangeEnd = 886266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseSignal(string signal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(signal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal.NativeMethodInfoPtr_RaiseSignal_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x000879A8 File Offset: 0x00085BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886266, XrefRangeEnd = 886270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWaiting(string signal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(signal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal.NativeMethodInfoPtr_IsWaiting_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x000879F8 File Offset: 0x00085BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886270, XrefRangeEnd = 886276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00087A2C File Offset: 0x00085C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00087A60 File Offset: 0x00085C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886276, XrefRangeEnd = 886295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine WaitForSignal(string signal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(signal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal.NativeMethodInfoPtr_WaitForSignal_Public_Coroutine_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00087AB0 File Offset: 0x00085CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886295, XrefRangeEnd = 886313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command GetWaitForSignal(string signal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(signal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal.NativeMethodInfoPtr_GetWaitForSignal_Public_Command_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00087B00 File Offset: 0x00085D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886313, XrefRangeEnd = 886320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator waitForSignal(AnimationSignal signaller, string signal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(signaller);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal.NativeMethodInfoPtr_waitForSignal_Private_IEnumerator_AnimationSignal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00087B64 File Offset: 0x00085D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886320, XrefRangeEnd = 886326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator waitForSignal(AnimationSignal signaller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(signaller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal.NativeMethodInfoPtr_waitForSignal_Private_IEnumerator_AnimationSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00087BB4 File Offset: 0x00085DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886326, XrefRangeEnd = 886339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationSignal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x0000C790 File Offset: 0x0000A990
		public AnimationSignal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x00087BF0 File Offset: 0x00085DF0
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x0000C799 File Offset: 0x0000A999
		public unsafe HashSet<string> signals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal.NativeFieldInfoPtr_signals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal.NativeFieldInfoPtr_signals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x00087C20 File Offset: 0x00085E20
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x0000C7B8 File Offset: 0x0000A9B8
		public unsafe HashSet<string> waiting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal.NativeFieldInfoPtr_waiting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal.NativeFieldInfoPtr_waiting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeFieldInfoPtr_signals;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeFieldInfoPtr_waiting;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeMethodInfoPtr_RaiseSignal_Public_Void_String_0;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeMethodInfoPtr_IsWaiting_Public_Boolean_String_0;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeMethodInfoPtr_WaitForSignal_Public_Coroutine_String_0;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeMethodInfoPtr_GetWaitForSignal_Public_Command_String_0;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeMethodInfoPtr_waitForSignal_Private_IEnumerator_AnimationSignal_String_0;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeMethodInfoPtr_waitForSignal_Private_IEnumerator_AnimationSignal_0;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003A2 RID: 930
		[ObfuscatedName("dwd.core.animation.AnimationSignal+<waitForSignal>d__8")]
		public sealed class _waitForSignal_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x06002967 RID: 10599 RVA: 0x000ADAD0 File Offset: 0x000ABCD0
			// Note: this type is marked as 'beforefieldinit'.
			static _waitForSignal_d__8()
			{
				Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr, "<waitForSignal>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__8>.NativeClassPtr);
				AnimationSignal._waitForSignal_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__8>.NativeClassPtr, "<>1__state");
				AnimationSignal._waitForSignal_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__8>.NativeClassPtr, "<>2__current");
				AnimationSignal._waitForSignal_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__8>.NativeClassPtr, "<>4__this");
				AnimationSignal._waitForSignal_d__8.NativeFieldInfoPtr_signal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__8>.NativeClassPtr, "signal");
				AnimationSignal._waitForSignal_d__8.NativeFieldInfoPtr_signaller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__8>.NativeClassPtr, "signaller");
				AnimationSignal._waitForSignal_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__8>.NativeClassPtr, 100668012);
				AnimationSignal._waitForSignal_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__8>.NativeClassPtr, 100668013);
				AnimationSignal._waitForSignal_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__8>.NativeClassPtr, 100668014);
				AnimationSignal._waitForSignal_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__8>.NativeClassPtr, 100668015);
				AnimationSignal._waitForSignal_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__8>.NativeClassPtr, 100668016);
				AnimationSignal._waitForSignal_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__8>.NativeClassPtr, 100668017);
			}

			// Token: 0x06002968 RID: 10600 RVA: 0x000ADBD8 File Offset: 0x000ABDD8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _waitForSignal_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal._waitForSignal_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002969 RID: 10601 RVA: 0x000ADC20 File Offset: 0x000ABE20
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal._waitForSignal_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600296A RID: 10602 RVA: 0x000ADC54 File Offset: 0x000ABE54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886224, XrefRangeEnd = 886237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal._waitForSignal_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BC5 RID: 3013
			// (get) Token: 0x0600296B RID: 10603 RVA: 0x000ADC90 File Offset: 0x000ABE90
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal._waitForSignal_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600296C RID: 10604 RVA: 0x000ADCD0 File Offset: 0x000ABED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886237, XrefRangeEnd = 886242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal._waitForSignal_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BC6 RID: 3014
			// (get) Token: 0x0600296D RID: 10605 RVA: 0x000ADD04 File Offset: 0x000ABF04
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal._waitForSignal_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600296E RID: 10606 RVA: 0x00012D09 File Offset: 0x00010F09
			public _waitForSignal_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BC0 RID: 3008
			// (get) Token: 0x0600296F RID: 10607 RVA: 0x000ADD44 File Offset: 0x000ABF44
			// (set) Token: 0x06002970 RID: 10608 RVA: 0x00012D12 File Offset: 0x00010F12
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BC1 RID: 3009
			// (get) Token: 0x06002971 RID: 10609 RVA: 0x000ADD6C File Offset: 0x000ABF6C
			// (set) Token: 0x06002972 RID: 10610 RVA: 0x00012D2D File Offset: 0x00010F2D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC2 RID: 3010
			// (get) Token: 0x06002973 RID: 10611 RVA: 0x000ADD9C File Offset: 0x000ABF9C
			// (set) Token: 0x06002974 RID: 10612 RVA: 0x00012D4C File Offset: 0x00010F4C
			public unsafe AnimationSignal __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationSignal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC3 RID: 3011
			// (get) Token: 0x06002975 RID: 10613 RVA: 0x000ADDCC File Offset: 0x000ABFCC
			// (set) Token: 0x06002976 RID: 10614 RVA: 0x00012D6B File Offset: 0x00010F6B
			public unsafe string signal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__8.NativeFieldInfoPtr_signal);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__8.NativeFieldInfoPtr_signal), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000BC4 RID: 3012
			// (get) Token: 0x06002977 RID: 10615 RVA: 0x000ADDF4 File Offset: 0x000ABFF4
			// (set) Token: 0x06002978 RID: 10616 RVA: 0x00012D8A File Offset: 0x00010F8A
			public unsafe AnimationSignal signaller
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__8.NativeFieldInfoPtr_signaller);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationSignal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__8.NativeFieldInfoPtr_signaller), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C01 RID: 7169
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C02 RID: 7170
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C03 RID: 7171
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C04 RID: 7172
			private static readonly IntPtr NativeFieldInfoPtr_signal;

			// Token: 0x04001C05 RID: 7173
			private static readonly IntPtr NativeFieldInfoPtr_signaller;

			// Token: 0x04001C06 RID: 7174
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C07 RID: 7175
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C08 RID: 7176
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C09 RID: 7177
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C0A RID: 7178
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C0B RID: 7179
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003A3 RID: 931
		[ObfuscatedName("dwd.core.animation.AnimationSignal+<waitForSignal>d__9")]
		public sealed class _waitForSignal_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x06002979 RID: 10617 RVA: 0x000ADE24 File Offset: 0x000AC024
			// Note: this type is marked as 'beforefieldinit'.
			static _waitForSignal_d__9()
			{
				Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationSignal>.NativeClassPtr, "<waitForSignal>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__9>.NativeClassPtr);
				AnimationSignal._waitForSignal_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__9>.NativeClassPtr, "<>1__state");
				AnimationSignal._waitForSignal_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__9>.NativeClassPtr, "<>2__current");
				AnimationSignal._waitForSignal_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__9>.NativeClassPtr, "<>4__this");
				AnimationSignal._waitForSignal_d__9.NativeFieldInfoPtr_signaller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__9>.NativeClassPtr, "signaller");
				AnimationSignal._waitForSignal_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__9>.NativeClassPtr, 100668018);
				AnimationSignal._waitForSignal_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__9>.NativeClassPtr, 100668019);
				AnimationSignal._waitForSignal_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__9>.NativeClassPtr, 100668020);
				AnimationSignal._waitForSignal_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__9>.NativeClassPtr, 100668021);
				AnimationSignal._waitForSignal_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__9>.NativeClassPtr, 100668022);
				AnimationSignal._waitForSignal_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__9>.NativeClassPtr, 100668023);
			}

			// Token: 0x0600297A RID: 10618 RVA: 0x000ADF18 File Offset: 0x000AC118
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _waitForSignal_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationSignal._waitForSignal_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal._waitForSignal_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600297B RID: 10619 RVA: 0x000ADF60 File Offset: 0x000AC160
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal._waitForSignal_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600297C RID: 10620 RVA: 0x000ADF94 File Offset: 0x000AC194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886242, XrefRangeEnd = 886257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal._waitForSignal_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BCB RID: 3019
			// (get) Token: 0x0600297D RID: 10621 RVA: 0x000ADFD0 File Offset: 0x000AC1D0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal._waitForSignal_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600297E RID: 10622 RVA: 0x000AE010 File Offset: 0x000AC210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886257, XrefRangeEnd = 886262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal._waitForSignal_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BCC RID: 3020
			// (get) Token: 0x0600297F RID: 10623 RVA: 0x000AE044 File Offset: 0x000AC244
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignal._waitForSignal_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002980 RID: 10624 RVA: 0x00012DA9 File Offset: 0x00010FA9
			public _waitForSignal_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BC7 RID: 3015
			// (get) Token: 0x06002981 RID: 10625 RVA: 0x000AE084 File Offset: 0x000AC284
			// (set) Token: 0x06002982 RID: 10626 RVA: 0x00012DB2 File Offset: 0x00010FB2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BC8 RID: 3016
			// (get) Token: 0x06002983 RID: 10627 RVA: 0x000AE0AC File Offset: 0x000AC2AC
			// (set) Token: 0x06002984 RID: 10628 RVA: 0x00012DCD File Offset: 0x00010FCD
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC9 RID: 3017
			// (get) Token: 0x06002985 RID: 10629 RVA: 0x000AE0DC File Offset: 0x000AC2DC
			// (set) Token: 0x06002986 RID: 10630 RVA: 0x00012DEC File Offset: 0x00010FEC
			public unsafe AnimationSignal __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationSignal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BCA RID: 3018
			// (get) Token: 0x06002987 RID: 10631 RVA: 0x000AE10C File Offset: 0x000AC30C
			// (set) Token: 0x06002988 RID: 10632 RVA: 0x00012E0B File Offset: 0x0001100B
			public unsafe AnimationSignal signaller
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__9.NativeFieldInfoPtr_signaller);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationSignal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignal._waitForSignal_d__9.NativeFieldInfoPtr_signaller), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C0C RID: 7180
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C0D RID: 7181
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C0E RID: 7182
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C0F RID: 7183
			private static readonly IntPtr NativeFieldInfoPtr_signaller;

			// Token: 0x04001C10 RID: 7184
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C11 RID: 7185
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C12 RID: 7186
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C13 RID: 7187
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C14 RID: 7188
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C15 RID: 7189
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
