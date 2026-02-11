using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.canis.lib.canis.dbg_client.behaviours
{
	// Token: 0x02000063 RID: 99
	public class EventsForSpecificChallenge : MonoBehaviour
	{
		// Token: 0x060003B7 RID: 951 RVA: 0x00029528 File Offset: 0x00027728
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForSpecificChallenge()
		{
			Il2CppClassPointerStore<EventsForSpecificChallenge>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.behaviours", "EventsForSpecificChallenge");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForSpecificChallenge>.NativeClassPtr);
			EventsForSpecificChallenge.NativeFieldInfoPtr_challenges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForSpecificChallenge>.NativeClassPtr, "challenges");
			EventsForSpecificChallenge.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForSpecificChallenge>.NativeClassPtr, 100663875);
			EventsForSpecificChallenge.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForSpecificChallenge>.NativeClassPtr, 100663876);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00029594 File Offset: 0x00027794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499992, XrefRangeEnd = 499997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForSpecificChallenge.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000295D4 File Offset: 0x000277D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499997, XrefRangeEnd = 500005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForSpecificChallenge()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForSpecificChallenge>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForSpecificChallenge.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00003A06 File Offset: 0x00001C06
		public EventsForSpecificChallenge(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00029610 File Offset: 0x00027810
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00003A0F File Offset: 0x00001C0F
		public unsafe Il2CppReferenceArray<ChallengeAndEvents> challenges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSpecificChallenge.NativeFieldInfoPtr_challenges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ChallengeAndEvents>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSpecificChallenge.NativeFieldInfoPtr_challenges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeFieldInfoPtr_challenges;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002ED RID: 749
		[ObfuscatedName("dwd.canis.lib.canis.dbg_client.behaviours.EventsForSpecificChallenge+<Start>d__1")]
		public sealed class _Start_d__1 : global::Il2CppSystem.Object
		{
			// Token: 0x06002358 RID: 9048 RVA: 0x00092340 File Offset: 0x00090540
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__1()
			{
				Il2CppClassPointerStore<EventsForSpecificChallenge._Start_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventsForSpecificChallenge>.NativeClassPtr, "<Start>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForSpecificChallenge._Start_d__1>.NativeClassPtr);
				EventsForSpecificChallenge._Start_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForSpecificChallenge._Start_d__1>.NativeClassPtr, "<>1__state");
				EventsForSpecificChallenge._Start_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForSpecificChallenge._Start_d__1>.NativeClassPtr, "<>2__current");
				EventsForSpecificChallenge._Start_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForSpecificChallenge._Start_d__1>.NativeClassPtr, "<>4__this");
				EventsForSpecificChallenge._Start_d__1.NativeFieldInfoPtr__matchHub_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForSpecificChallenge._Start_d__1>.NativeClassPtr, "<matchHub>5__2");
				EventsForSpecificChallenge._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForSpecificChallenge._Start_d__1>.NativeClassPtr, 100663877);
				EventsForSpecificChallenge._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForSpecificChallenge._Start_d__1>.NativeClassPtr, 100663878);
				EventsForSpecificChallenge._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForSpecificChallenge._Start_d__1>.NativeClassPtr, 100663879);
				EventsForSpecificChallenge._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForSpecificChallenge._Start_d__1>.NativeClassPtr, 100663880);
				EventsForSpecificChallenge._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForSpecificChallenge._Start_d__1>.NativeClassPtr, 100663881);
				EventsForSpecificChallenge._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForSpecificChallenge._Start_d__1>.NativeClassPtr, 100663882);
			}

			// Token: 0x06002359 RID: 9049 RVA: 0x00092434 File Offset: 0x00090634
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForSpecificChallenge._Start_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForSpecificChallenge._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600235A RID: 9050 RVA: 0x0009247C File Offset: 0x0009067C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForSpecificChallenge._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600235B RID: 9051 RVA: 0x000924B0 File Offset: 0x000906B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499973, XrefRangeEnd = 499987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForSpecificChallenge._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700099A RID: 2458
			// (get) Token: 0x0600235C RID: 9052 RVA: 0x000924EC File Offset: 0x000906EC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForSpecificChallenge._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600235D RID: 9053 RVA: 0x0009252C File Offset: 0x0009072C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499987, XrefRangeEnd = 499992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForSpecificChallenge._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700099B RID: 2459
			// (get) Token: 0x0600235E RID: 9054 RVA: 0x00092560 File Offset: 0x00090760
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForSpecificChallenge._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600235F RID: 9055 RVA: 0x0001269A File Offset: 0x0001089A
			public _Start_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000996 RID: 2454
			// (get) Token: 0x06002360 RID: 9056 RVA: 0x000925A0 File Offset: 0x000907A0
			// (set) Token: 0x06002361 RID: 9057 RVA: 0x000126A3 File Offset: 0x000108A3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSpecificChallenge._Start_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSpecificChallenge._Start_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000997 RID: 2455
			// (get) Token: 0x06002362 RID: 9058 RVA: 0x000925C8 File Offset: 0x000907C8
			// (set) Token: 0x06002363 RID: 9059 RVA: 0x000126BE File Offset: 0x000108BE
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSpecificChallenge._Start_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSpecificChallenge._Start_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000998 RID: 2456
			// (get) Token: 0x06002364 RID: 9060 RVA: 0x000925F8 File Offset: 0x000907F8
			// (set) Token: 0x06002365 RID: 9061 RVA: 0x000126DD File Offset: 0x000108DD
			public unsafe EventsForSpecificChallenge __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSpecificChallenge._Start_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventsForSpecificChallenge>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSpecificChallenge._Start_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000999 RID: 2457
			// (get) Token: 0x06002366 RID: 9062 RVA: 0x00092628 File Offset: 0x00090828
			// (set) Token: 0x06002367 RID: 9063 RVA: 0x000126FC File Offset: 0x000108FC
			public unsafe DBGMatchHub _matchHub_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSpecificChallenge._Start_d__1.NativeFieldInfoPtr__matchHub_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchHub>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForSpecificChallenge._Start_d__1.NativeFieldInfoPtr__matchHub_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001639 RID: 5689
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400163A RID: 5690
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400163B RID: 5691
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400163C RID: 5692
			private static readonly IntPtr NativeFieldInfoPtr__matchHub_5__2;

			// Token: 0x0400163D RID: 5693
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400163E RID: 5694
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400163F RID: 5695
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001640 RID: 5696
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001641 RID: 5697
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001642 RID: 5698
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
