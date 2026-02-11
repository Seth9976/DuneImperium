using System;
using dbgclient.dataProviders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dbgclient.menus.behaviours
{
	// Token: 0x020000A2 RID: 162
	public class NewDailyChallengeAlertBehaviour : MonoBehaviour
	{
		// Token: 0x06000660 RID: 1632 RVA: 0x00031DA8 File Offset: 0x0002FFA8
		// Note: this type is marked as 'beforefieldinit'.
		static NewDailyChallengeAlertBehaviour()
		{
			Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.menus.behaviours", "NewDailyChallengeAlertBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour>.NativeClassPtr);
			NewDailyChallengeAlertBehaviour.NativeFieldInfoPtr_Enable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour>.NativeClassPtr, "Enable");
			NewDailyChallengeAlertBehaviour.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour>.NativeClassPtr, "animator");
			NewDailyChallengeAlertBehaviour.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour>.NativeClassPtr, 100664300);
			NewDailyChallengeAlertBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour>.NativeClassPtr, 100664301);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00031E28 File Offset: 0x00030028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503290, XrefRangeEnd = 503295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDailyChallengeAlertBehaviour.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00031E68 File Offset: 0x00030068
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewDailyChallengeAlertBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDailyChallengeAlertBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00004E1C File Offset: 0x0000301C
		public NewDailyChallengeAlertBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00031EA4 File Offset: 0x000300A4
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00004E25 File Offset: 0x00003025
		public unsafe static int Enable
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NewDailyChallengeAlertBehaviour.NativeFieldInfoPtr_Enable, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NewDailyChallengeAlertBehaviour.NativeFieldInfoPtr_Enable, (void*)(&value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00031EC0 File Offset: 0x000300C0
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00004E33 File Offset: 0x00003033
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDailyChallengeAlertBehaviour.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDailyChallengeAlertBehaviour.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeFieldInfoPtr_Enable;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000313 RID: 787
		[ObfuscatedName("dbgclient.menus.behaviours.NewDailyChallengeAlertBehaviour+<Start>d__2")]
		public sealed class _Start_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x0600253D RID: 9533 RVA: 0x00097D78 File Offset: 0x00095F78
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__2()
			{
				Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour._Start_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour>.NativeClassPtr, "<Start>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour._Start_d__2>.NativeClassPtr);
				NewDailyChallengeAlertBehaviour._Start_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour._Start_d__2>.NativeClassPtr, "<>1__state");
				NewDailyChallengeAlertBehaviour._Start_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour._Start_d__2>.NativeClassPtr, "<>2__current");
				NewDailyChallengeAlertBehaviour._Start_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour._Start_d__2>.NativeClassPtr, "<>4__this");
				NewDailyChallengeAlertBehaviour._Start_d__2.NativeFieldInfoPtr__dailyChallengeProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour._Start_d__2>.NativeClassPtr, "<dailyChallengeProvider>5__2");
				NewDailyChallengeAlertBehaviour._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour._Start_d__2>.NativeClassPtr, 100664303);
				NewDailyChallengeAlertBehaviour._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour._Start_d__2>.NativeClassPtr, 100664304);
				NewDailyChallengeAlertBehaviour._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour._Start_d__2>.NativeClassPtr, 100664305);
				NewDailyChallengeAlertBehaviour._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour._Start_d__2>.NativeClassPtr, 100664306);
				NewDailyChallengeAlertBehaviour._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour._Start_d__2>.NativeClassPtr, 100664307);
				NewDailyChallengeAlertBehaviour._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour._Start_d__2>.NativeClassPtr, 100664308);
			}

			// Token: 0x0600253E RID: 9534 RVA: 0x00097E6C File Offset: 0x0009606C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewDailyChallengeAlertBehaviour._Start_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDailyChallengeAlertBehaviour._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600253F RID: 9535 RVA: 0x00097EB4 File Offset: 0x000960B4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDailyChallengeAlertBehaviour._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002540 RID: 9536 RVA: 0x00097EE8 File Offset: 0x000960E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503282, XrefRangeEnd = 503285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDailyChallengeAlertBehaviour._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A43 RID: 2627
			// (get) Token: 0x06002541 RID: 9537 RVA: 0x00097F24 File Offset: 0x00096124
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDailyChallengeAlertBehaviour._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002542 RID: 9538 RVA: 0x00097F64 File Offset: 0x00096164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503285, XrefRangeEnd = 503290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDailyChallengeAlertBehaviour._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A44 RID: 2628
			// (get) Token: 0x06002543 RID: 9539 RVA: 0x00097F98 File Offset: 0x00096198
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDailyChallengeAlertBehaviour._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002544 RID: 9540 RVA: 0x00013597 File Offset: 0x00011797
			public _Start_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A3F RID: 2623
			// (get) Token: 0x06002545 RID: 9541 RVA: 0x00097FD8 File Offset: 0x000961D8
			// (set) Token: 0x06002546 RID: 9542 RVA: 0x000135A0 File Offset: 0x000117A0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDailyChallengeAlertBehaviour._Start_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDailyChallengeAlertBehaviour._Start_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A40 RID: 2624
			// (get) Token: 0x06002547 RID: 9543 RVA: 0x00098000 File Offset: 0x00096200
			// (set) Token: 0x06002548 RID: 9544 RVA: 0x000135BB File Offset: 0x000117BB
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDailyChallengeAlertBehaviour._Start_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDailyChallengeAlertBehaviour._Start_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A41 RID: 2625
			// (get) Token: 0x06002549 RID: 9545 RVA: 0x00098030 File Offset: 0x00096230
			// (set) Token: 0x0600254A RID: 9546 RVA: 0x000135DA File Offset: 0x000117DA
			public unsafe NewDailyChallengeAlertBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDailyChallengeAlertBehaviour._Start_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewDailyChallengeAlertBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDailyChallengeAlertBehaviour._Start_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A42 RID: 2626
			// (get) Token: 0x0600254B RID: 9547 RVA: 0x00098060 File Offset: 0x00096260
			// (set) Token: 0x0600254C RID: 9548 RVA: 0x000135F9 File Offset: 0x000117F9
			public unsafe DailyChallengeProvider _dailyChallengeProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDailyChallengeAlertBehaviour._Start_d__2.NativeFieldInfoPtr__dailyChallengeProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDailyChallengeAlertBehaviour._Start_d__2.NativeFieldInfoPtr__dailyChallengeProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001762 RID: 5986
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001763 RID: 5987
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001764 RID: 5988
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001765 RID: 5989
			private static readonly IntPtr NativeFieldInfoPtr__dailyChallengeProvider_5__2;

			// Token: 0x04001766 RID: 5990
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001767 RID: 5991
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001768 RID: 5992
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001769 RID: 5993
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400176A RID: 5994
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400176B RID: 5995
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
