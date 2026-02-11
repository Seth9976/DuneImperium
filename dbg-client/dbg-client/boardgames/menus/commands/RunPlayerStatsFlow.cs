using System;
using dwd.core.commands;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x02000230 RID: 560
	public class RunPlayerStatsFlow : FailableCommand
	{
		// Token: 0x06001975 RID: 6517 RVA: 0x00070584 File Offset: 0x0006E784
		// Note: this type is marked as 'beforefieldinit'.
		static RunPlayerStatsFlow()
		{
			Il2CppClassPointerStore<RunPlayerStatsFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunPlayerStatsFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunPlayerStatsFlow>.NativeClassPtr);
			RunPlayerStatsFlow.NativeFieldInfoPtr__promptFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerStatsFlow>.NativeClassPtr, "_promptFlavors");
			RunPlayerStatsFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerStatsFlow>.NativeClassPtr, 100667251);
			RunPlayerStatsFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerStatsFlow>.NativeClassPtr, 100667252);
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x000705F0 File Offset: 0x0006E7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529506, XrefRangeEnd = 529511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunPlayerStatsFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x0007063C File Offset: 0x0006E83C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 529522, RefRangeEnd = 529523, XrefRangeStart = 529511, XrefRangeEnd = 529522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunPlayerStatsFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPlayerStatsFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerStatsFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x0000DFA7 File Offset: 0x0000C1A7
		public RunPlayerStatsFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x00070678 File Offset: 0x0006E878
		// (set) Token: 0x0600197A RID: 6522 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		public PrefabFlavorContext _promptFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerStatsFlow.NativeFieldInfoPtr__promptFlavors);
				return new PrefabFlavorContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerStatsFlow.NativeFieldInfoPtr__promptFlavors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeFieldInfoPtr__promptFlavors;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000413 RID: 1043
		[ObfuscatedName("boardgames.menus.commands.RunPlayerStatsFlow+<execute>d__1")]
		public sealed class _execute_d__1 : Object
		{
			// Token: 0x06003142 RID: 12610 RVA: 0x000BB870 File Offset: 0x000B9A70
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__1()
			{
				Il2CppClassPointerStore<RunPlayerStatsFlow._execute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunPlayerStatsFlow>.NativeClassPtr, "<execute>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunPlayerStatsFlow._execute_d__1>.NativeClassPtr);
				RunPlayerStatsFlow._execute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerStatsFlow._execute_d__1>.NativeClassPtr, "<>1__state");
				RunPlayerStatsFlow._execute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerStatsFlow._execute_d__1>.NativeClassPtr, "<>2__current");
				RunPlayerStatsFlow._execute_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerStatsFlow._execute_d__1>.NativeClassPtr, "<>4__this");
				RunPlayerStatsFlow._execute_d__1.NativeFieldInfoPtr__login_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerStatsFlow._execute_d__1>.NativeClassPtr, "<login>5__2");
				RunPlayerStatsFlow._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerStatsFlow._execute_d__1>.NativeClassPtr, 100667253);
				RunPlayerStatsFlow._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerStatsFlow._execute_d__1>.NativeClassPtr, 100667254);
				RunPlayerStatsFlow._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerStatsFlow._execute_d__1>.NativeClassPtr, 100667255);
				RunPlayerStatsFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerStatsFlow._execute_d__1>.NativeClassPtr, 100667256);
				RunPlayerStatsFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerStatsFlow._execute_d__1>.NativeClassPtr, 100667257);
				RunPlayerStatsFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerStatsFlow._execute_d__1>.NativeClassPtr, 100667258);
			}

			// Token: 0x06003143 RID: 12611 RVA: 0x000BB964 File Offset: 0x000B9B64
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPlayerStatsFlow._execute_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerStatsFlow._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003144 RID: 12612 RVA: 0x000BB9AC File Offset: 0x000B9BAC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerStatsFlow._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003145 RID: 12613 RVA: 0x000BB9E0 File Offset: 0x000B9BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529490, XrefRangeEnd = 529501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerStatsFlow._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E4B RID: 3659
			// (get) Token: 0x06003146 RID: 12614 RVA: 0x000BBA1C File Offset: 0x000B9C1C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerStatsFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003147 RID: 12615 RVA: 0x000BBA5C File Offset: 0x000B9C5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529501, XrefRangeEnd = 529506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerStatsFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E4C RID: 3660
			// (get) Token: 0x06003148 RID: 12616 RVA: 0x000BBA90 File Offset: 0x000B9C90
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerStatsFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003149 RID: 12617 RVA: 0x00019781 File Offset: 0x00017981
			public _execute_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E47 RID: 3655
			// (get) Token: 0x0600314A RID: 12618 RVA: 0x000BBAD0 File Offset: 0x000B9CD0
			// (set) Token: 0x0600314B RID: 12619 RVA: 0x0001978A File Offset: 0x0001798A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerStatsFlow._execute_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerStatsFlow._execute_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E48 RID: 3656
			// (get) Token: 0x0600314C RID: 12620 RVA: 0x000BBAF8 File Offset: 0x000B9CF8
			// (set) Token: 0x0600314D RID: 12621 RVA: 0x000197A5 File Offset: 0x000179A5
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerStatsFlow._execute_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerStatsFlow._execute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E49 RID: 3657
			// (get) Token: 0x0600314E RID: 12622 RVA: 0x000BBB28 File Offset: 0x000B9D28
			// (set) Token: 0x0600314F RID: 12623 RVA: 0x000197C4 File Offset: 0x000179C4
			public unsafe RunPlayerStatsFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerStatsFlow._execute_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunPlayerStatsFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerStatsFlow._execute_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E4A RID: 3658
			// (get) Token: 0x06003150 RID: 12624 RVA: 0x000BBB58 File Offset: 0x000B9D58
			// (set) Token: 0x06003151 RID: 12625 RVA: 0x000197E3 File Offset: 0x000179E3
			public unsafe LoginIfNeeded _login_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerStatsFlow._execute_d__1.NativeFieldInfoPtr__login_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginIfNeeded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerStatsFlow._execute_d__1.NativeFieldInfoPtr__login_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E73 RID: 7795
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E74 RID: 7796
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E75 RID: 7797
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E76 RID: 7798
			private static readonly IntPtr NativeFieldInfoPtr__login_5__2;

			// Token: 0x04001E77 RID: 7799
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001E78 RID: 7800
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E79 RID: 7801
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001E7A RID: 7802
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001E7B RID: 7803
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E7C RID: 7804
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
