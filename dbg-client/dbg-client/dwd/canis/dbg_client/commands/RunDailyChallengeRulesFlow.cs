using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.canis.dbg_client.commands
{
	// Token: 0x02000078 RID: 120
	public class RunDailyChallengeRulesFlow : Command
	{
		// Token: 0x0600047C RID: 1148 RVA: 0x0002B97C File Offset: 0x00029B7C
		// Note: this type is marked as 'beforefieldinit'.
		static RunDailyChallengeRulesFlow()
		{
			Il2CppClassPointerStore<RunDailyChallengeRulesFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.commands", "RunDailyChallengeRulesFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDailyChallengeRulesFlow>.NativeClassPtr);
			RunDailyChallengeRulesFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeRulesFlow>.NativeClassPtr, 100663969);
			RunDailyChallengeRulesFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeRulesFlow>.NativeClassPtr, 100663970);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0002B9D4 File Offset: 0x00029BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500783, XrefRangeEnd = 500787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunDailyChallengeRulesFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0002BA20 File Offset: 0x00029C20
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunDailyChallengeRulesFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDailyChallengeRulesFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeRulesFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00004044 File Offset: 0x00002244
		public RunDailyChallengeRulesFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002F4 RID: 756
		[ObfuscatedName("dwd.canis.dbg_client.commands.RunDailyChallengeRulesFlow+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x060023AF RID: 9135 RVA: 0x000933CC File Offset: 0x000915CC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<RunDailyChallengeRulesFlow._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunDailyChallengeRulesFlow>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDailyChallengeRulesFlow._execute_d__0>.NativeClassPtr);
				RunDailyChallengeRulesFlow._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengeRulesFlow._execute_d__0>.NativeClassPtr, "<>1__state");
				RunDailyChallengeRulesFlow._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengeRulesFlow._execute_d__0>.NativeClassPtr, "<>2__current");
				RunDailyChallengeRulesFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeRulesFlow._execute_d__0>.NativeClassPtr, 100663971);
				RunDailyChallengeRulesFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeRulesFlow._execute_d__0>.NativeClassPtr, 100663972);
				RunDailyChallengeRulesFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeRulesFlow._execute_d__0>.NativeClassPtr, 100663973);
				RunDailyChallengeRulesFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeRulesFlow._execute_d__0>.NativeClassPtr, 100663974);
				RunDailyChallengeRulesFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeRulesFlow._execute_d__0>.NativeClassPtr, 100663975);
				RunDailyChallengeRulesFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeRulesFlow._execute_d__0>.NativeClassPtr, 100663976);
			}

			// Token: 0x060023B0 RID: 9136 RVA: 0x00093498 File Offset: 0x00091698
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDailyChallengeRulesFlow._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeRulesFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023B1 RID: 9137 RVA: 0x000934E0 File Offset: 0x000916E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeRulesFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023B2 RID: 9138 RVA: 0x00093514 File Offset: 0x00091714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500757, XrefRangeEnd = 500778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeRulesFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009B5 RID: 2485
			// (get) Token: 0x060023B3 RID: 9139 RVA: 0x00093550 File Offset: 0x00091750
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeRulesFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060023B4 RID: 9140 RVA: 0x00093590 File Offset: 0x00091790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500778, XrefRangeEnd = 500783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeRulesFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009B6 RID: 2486
			// (get) Token: 0x060023B5 RID: 9141 RVA: 0x000935C4 File Offset: 0x000917C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeRulesFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060023B6 RID: 9142 RVA: 0x00012932 File Offset: 0x00010B32
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009B3 RID: 2483
			// (get) Token: 0x060023B7 RID: 9143 RVA: 0x00093604 File Offset: 0x00091804
			// (set) Token: 0x060023B8 RID: 9144 RVA: 0x0001293B File Offset: 0x00010B3B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengeRulesFlow._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengeRulesFlow._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009B4 RID: 2484
			// (get) Token: 0x060023B9 RID: 9145 RVA: 0x0009362C File Offset: 0x0009182C
			// (set) Token: 0x060023BA RID: 9146 RVA: 0x00012956 File Offset: 0x00010B56
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengeRulesFlow._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengeRulesFlow._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400166D RID: 5741
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400166E RID: 5742
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400166F RID: 5743
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001670 RID: 5744
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001671 RID: 5745
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001672 RID: 5746
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001673 RID: 5747
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001674 RID: 5748
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
