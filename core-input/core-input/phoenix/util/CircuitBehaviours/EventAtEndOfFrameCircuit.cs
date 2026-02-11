using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace phoenix.util.CircuitBehaviours
{
	// Token: 0x0200000A RID: 10
	public class EventAtEndOfFrameCircuit : MonoBehaviour
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00007C28 File Offset: 0x00005E28
		// Note: this type is marked as 'beforefieldinit'.
		static EventAtEndOfFrameCircuit()
		{
			Il2CppClassPointerStore<EventAtEndOfFrameCircuit>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "phoenix.util.CircuitBehaviours", "EventAtEndOfFrameCircuit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventAtEndOfFrameCircuit>.NativeClassPtr);
			EventAtEndOfFrameCircuit.NativeFieldInfoPtr_output_onEndOfFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAtEndOfFrameCircuit>.NativeClassPtr, "output_onEndOfFrame");
			EventAtEndOfFrameCircuit.NativeFieldInfoPtr_delayedInvoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAtEndOfFrameCircuit>.NativeClassPtr, "delayedInvoke");
			EventAtEndOfFrameCircuit.NativeMethodInfoPtr_get_Output_OnEndOfFrame_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAtEndOfFrameCircuit>.NativeClassPtr, 100663319);
			EventAtEndOfFrameCircuit.NativeMethodInfoPtr_Input_BeginEndOfFrameWait_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAtEndOfFrameCircuit>.NativeClassPtr, 100663320);
			EventAtEndOfFrameCircuit.NativeMethodInfoPtr_performDelayedInvoke_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAtEndOfFrameCircuit>.NativeClassPtr, 100663321);
			EventAtEndOfFrameCircuit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAtEndOfFrameCircuit>.NativeClassPtr, 100663322);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00007CD0 File Offset: 0x00005ED0
		public unsafe UnityEvent Output_OnEndOfFrame
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAtEndOfFrameCircuit.NativeMethodInfoPtr_get_Output_OnEndOfFrame_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00007D10 File Offset: 0x00005F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119065, XrefRangeEnd = 1119078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Input_BeginEndOfFrameWait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAtEndOfFrameCircuit.NativeMethodInfoPtr_Input_BeginEndOfFrameWait_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00007D44 File Offset: 0x00005F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119078, XrefRangeEnd = 1119083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator performDelayedInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAtEndOfFrameCircuit.NativeMethodInfoPtr_performDelayedInvoke_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00007D84 File Offset: 0x00005F84
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventAtEndOfFrameCircuit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventAtEndOfFrameCircuit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAtEndOfFrameCircuit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000217F File Offset: 0x0000037F
		public EventAtEndOfFrameCircuit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00007DC0 File Offset: 0x00005FC0
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002188 File Offset: 0x00000388
		public unsafe UnityEvent output_onEndOfFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAtEndOfFrameCircuit.NativeFieldInfoPtr_output_onEndOfFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAtEndOfFrameCircuit.NativeFieldInfoPtr_output_onEndOfFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00007DF0 File Offset: 0x00005FF0
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000021A7 File Offset: 0x000003A7
		public unsafe InterruptableCommand delayedInvoke
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAtEndOfFrameCircuit.NativeFieldInfoPtr_delayedInvoke);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterruptableCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAtEndOfFrameCircuit.NativeFieldInfoPtr_delayedInvoke), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_output_onEndOfFrame;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_delayedInvoke;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_Output_OnEndOfFrame_Public_get_UnityEvent_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_Input_BeginEndOfFrameWait_Public_Void_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_performDelayedInvoke_Private_IEnumerator_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000B3 RID: 179
		[ObfuscatedName("phoenix.util.CircuitBehaviours.EventAtEndOfFrameCircuit+<performDelayedInvoke>d__5")]
		public sealed class _performDelayedInvoke_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x06000801 RID: 2049 RVA: 0x00020FD0 File Offset: 0x0001F1D0
			// Note: this type is marked as 'beforefieldinit'.
			static _performDelayedInvoke_d__5()
			{
				Il2CppClassPointerStore<EventAtEndOfFrameCircuit._performDelayedInvoke_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventAtEndOfFrameCircuit>.NativeClassPtr, "<performDelayedInvoke>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventAtEndOfFrameCircuit._performDelayedInvoke_d__5>.NativeClassPtr);
				EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAtEndOfFrameCircuit._performDelayedInvoke_d__5>.NativeClassPtr, "<>1__state");
				EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAtEndOfFrameCircuit._performDelayedInvoke_d__5>.NativeClassPtr, "<>2__current");
				EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAtEndOfFrameCircuit._performDelayedInvoke_d__5>.NativeClassPtr, "<>4__this");
				EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAtEndOfFrameCircuit._performDelayedInvoke_d__5>.NativeClassPtr, 100663323);
				EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAtEndOfFrameCircuit._performDelayedInvoke_d__5>.NativeClassPtr, 100663324);
				EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAtEndOfFrameCircuit._performDelayedInvoke_d__5>.NativeClassPtr, 100663325);
				EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAtEndOfFrameCircuit._performDelayedInvoke_d__5>.NativeClassPtr, 100663326);
				EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAtEndOfFrameCircuit._performDelayedInvoke_d__5>.NativeClassPtr, 100663327);
				EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAtEndOfFrameCircuit._performDelayedInvoke_d__5>.NativeClassPtr, 100663328);
			}

			// Token: 0x06000802 RID: 2050 RVA: 0x000210B0 File Offset: 0x0001F2B0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _performDelayedInvoke_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventAtEndOfFrameCircuit._performDelayedInvoke_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000803 RID: 2051 RVA: 0x000210F8 File Offset: 0x0001F2F8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000804 RID: 2052 RVA: 0x0002112C File Offset: 0x0001F32C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119055, XrefRangeEnd = 1119060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000249 RID: 585
			// (get) Token: 0x06000805 RID: 2053 RVA: 0x00021168 File Offset: 0x0001F368
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000806 RID: 2054 RVA: 0x000211A8 File Offset: 0x0001F3A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119060, XrefRangeEnd = 1119065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700024A RID: 586
			// (get) Token: 0x06000807 RID: 2055 RVA: 0x000211DC File Offset: 0x0001F3DC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000808 RID: 2056 RVA: 0x00006367 File Offset: 0x00004567
			public _performDelayedInvoke_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000246 RID: 582
			// (get) Token: 0x06000809 RID: 2057 RVA: 0x0002121C File Offset: 0x0001F41C
			// (set) Token: 0x0600080A RID: 2058 RVA: 0x00006370 File Offset: 0x00004570
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000247 RID: 583
			// (get) Token: 0x0600080B RID: 2059 RVA: 0x00021244 File Offset: 0x0001F444
			// (set) Token: 0x0600080C RID: 2060 RVA: 0x0000638B File Offset: 0x0000458B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000248 RID: 584
			// (get) Token: 0x0600080D RID: 2061 RVA: 0x00021274 File Offset: 0x0001F474
			// (set) Token: 0x0600080E RID: 2062 RVA: 0x000063AA File Offset: 0x000045AA
			public unsafe EventAtEndOfFrameCircuit __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventAtEndOfFrameCircuit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAtEndOfFrameCircuit._performDelayedInvoke_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004EE RID: 1262
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040004EF RID: 1263
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040004F0 RID: 1264
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040004F1 RID: 1265
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040004F2 RID: 1266
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040004F3 RID: 1267
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040004F4 RID: 1268
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040004F5 RID: 1269
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040004F6 RID: 1270
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
