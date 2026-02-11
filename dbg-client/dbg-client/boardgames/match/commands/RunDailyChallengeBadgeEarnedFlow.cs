using System;
using Canis.skirmishScripts;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.match.commands
{
	// Token: 0x02000294 RID: 660
	public class RunDailyChallengeBadgeEarnedFlow : Command
	{
		// Token: 0x06001F12 RID: 7954 RVA: 0x00085378 File Offset: 0x00083578
		// Note: this type is marked as 'beforefieldinit'.
		static RunDailyChallengeBadgeEarnedFlow()
		{
			Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.commands", "RunDailyChallengeBadgeEarnedFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow>.NativeClassPtr);
			RunDailyChallengeBadgeEarnedFlow.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow>.NativeClassPtr, "data");
			RunDailyChallengeBadgeEarnedFlow.NativeMethodInfoPtr__ctor_Public_Void_DailyChallengeBadgeEarned_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow>.NativeClassPtr, 100668477);
			RunDailyChallengeBadgeEarnedFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow>.NativeClassPtr, 100668478);
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x000853E4 File Offset: 0x000835E4
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunDailyChallengeBadgeEarnedFlow(DailyChallengeBadgeEarned data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeBadgeEarnedFlow.NativeMethodInfoPtr__ctor_Public_Void_DailyChallengeBadgeEarned_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00085430 File Offset: 0x00083630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540785, XrefRangeEnd = 540790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunDailyChallengeBadgeEarnedFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00010583 File Offset: 0x0000E783
		public RunDailyChallengeBadgeEarnedFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x0008547C File Offset: 0x0008367C
		// (set) Token: 0x06001F17 RID: 7959 RVA: 0x0001058C File Offset: 0x0000E78C
		public unsafe DailyChallengeBadgeEarned data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengeBadgeEarnedFlow.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeBadgeEarned>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengeBadgeEarnedFlow.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DailyChallengeBadgeEarned_0;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000491 RID: 1169
		[ObfuscatedName("boardgames.match.commands.RunDailyChallengeBadgeEarnedFlow+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x0600376C RID: 14188 RVA: 0x000CE1A0 File Offset: 0x000CC3A0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow._execute_d__2>.NativeClassPtr);
				RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow._execute_d__2>.NativeClassPtr, "<>1__state");
				RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow._execute_d__2>.NativeClassPtr, "<>2__current");
				RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow._execute_d__2>.NativeClassPtr, "<>4__this");
				RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow._execute_d__2>.NativeClassPtr, 100668479);
				RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow._execute_d__2>.NativeClassPtr, 100668480);
				RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow._execute_d__2>.NativeClassPtr, 100668481);
				RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow._execute_d__2>.NativeClassPtr, 100668482);
				RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow._execute_d__2>.NativeClassPtr, 100668483);
				RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow._execute_d__2>.NativeClassPtr, 100668484);
			}

			// Token: 0x0600376D RID: 14189 RVA: 0x000CE280 File Offset: 0x000CC480
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDailyChallengeBadgeEarnedFlow._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600376E RID: 14190 RVA: 0x000CE2C8 File Offset: 0x000CC4C8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600376F RID: 14191 RVA: 0x000CE2FC File Offset: 0x000CC4FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540748, XrefRangeEnd = 540780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001059 RID: 4185
			// (get) Token: 0x06003770 RID: 14192 RVA: 0x000CE338 File Offset: 0x000CC538
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003771 RID: 14193 RVA: 0x000CE378 File Offset: 0x000CC578
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540780, XrefRangeEnd = 540785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700105A RID: 4186
			// (get) Token: 0x06003772 RID: 14194 RVA: 0x000CE3AC File Offset: 0x000CC5AC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003773 RID: 14195 RVA: 0x0001C7F7 File Offset: 0x0001A9F7
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001056 RID: 4182
			// (get) Token: 0x06003774 RID: 14196 RVA: 0x000CE3EC File Offset: 0x000CC5EC
			// (set) Token: 0x06003775 RID: 14197 RVA: 0x0001C800 File Offset: 0x0001AA00
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001057 RID: 4183
			// (get) Token: 0x06003776 RID: 14198 RVA: 0x000CE414 File Offset: 0x000CC614
			// (set) Token: 0x06003777 RID: 14199 RVA: 0x0001C81B File Offset: 0x0001AA1B
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001058 RID: 4184
			// (get) Token: 0x06003778 RID: 14200 RVA: 0x000CE444 File Offset: 0x000CC644
			// (set) Token: 0x06003779 RID: 14201 RVA: 0x0001C83A File Offset: 0x0001AA3A
			public unsafe RunDailyChallengeBadgeEarnedFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunDailyChallengeBadgeEarnedFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengeBadgeEarnedFlow._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002219 RID: 8729
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400221A RID: 8730
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400221B RID: 8731
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400221C RID: 8732
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400221D RID: 8733
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400221E RID: 8734
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400221F RID: 8735
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002220 RID: 8736
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002221 RID: 8737
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
