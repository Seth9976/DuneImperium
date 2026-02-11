using System;
using Canis.skirmishScripts;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace worm.match.commands
{
	// Token: 0x0200023F RID: 575
	public class WormShowEarnedSkirmishBadgeFlow : Command
	{
		// Token: 0x060018BF RID: 6335 RVA: 0x00063534 File Offset: 0x00061734
		// Note: this type is marked as 'beforefieldinit'.
		static WormShowEarnedSkirmishBadgeFlow()
		{
			Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands", "WormShowEarnedSkirmishBadgeFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow>.NativeClassPtr);
			WormShowEarnedSkirmishBadgeFlow.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow>.NativeClassPtr, "data");
			WormShowEarnedSkirmishBadgeFlow.NativeMethodInfoPtr__ctor_Public_Void_DailyChallengeBadgeEarned_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow>.NativeClassPtr, 100666778);
			WormShowEarnedSkirmishBadgeFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow>.NativeClassPtr, 100666779);
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x000635A0 File Offset: 0x000617A0
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShowEarnedSkirmishBadgeFlow(DailyChallengeBadgeEarned data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEarnedSkirmishBadgeFlow.NativeMethodInfoPtr__ctor_Public_Void_DailyChallengeBadgeEarned_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x000635EC File Offset: 0x000617EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719204, XrefRangeEnd = 719209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShowEarnedSkirmishBadgeFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0000E962 File Offset: 0x0000CB62
		public WormShowEarnedSkirmishBadgeFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x00063638 File Offset: 0x00061838
		// (set) Token: 0x060018C4 RID: 6340 RVA: 0x0000E96B File Offset: 0x0000CB6B
		public unsafe DailyChallengeBadgeEarned data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEarnedSkirmishBadgeFlow.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeBadgeEarned>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEarnedSkirmishBadgeFlow.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DailyChallengeBadgeEarned_0;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000410 RID: 1040
		[ObfuscatedName("worm.match.commands.WormShowEarnedSkirmishBadgeFlow+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06002ADB RID: 10971 RVA: 0x00099DE0 File Offset: 0x00097FE0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow._execute_d__2>.NativeClassPtr);
				WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow._execute_d__2>.NativeClassPtr, "<>1__state");
				WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow._execute_d__2>.NativeClassPtr, "<>2__current");
				WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow._execute_d__2>.NativeClassPtr, "<>4__this");
				WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow._execute_d__2>.NativeClassPtr, 100666780);
				WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow._execute_d__2>.NativeClassPtr, 100666781);
				WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow._execute_d__2>.NativeClassPtr, 100666782);
				WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow._execute_d__2>.NativeClassPtr, 100666783);
				WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow._execute_d__2>.NativeClassPtr, 100666784);
				WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow._execute_d__2>.NativeClassPtr, 100666785);
			}

			// Token: 0x06002ADC RID: 10972 RVA: 0x00099EC0 File Offset: 0x000980C0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowEarnedSkirmishBadgeFlow._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002ADD RID: 10973 RVA: 0x00099F08 File Offset: 0x00098108
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ADE RID: 10974 RVA: 0x00099F3C File Offset: 0x0009813C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719182, XrefRangeEnd = 719199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C34 RID: 3124
			// (get) Token: 0x06002ADF RID: 10975 RVA: 0x00099F78 File Offset: 0x00098178
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AE0 RID: 10976 RVA: 0x00099FB8 File Offset: 0x000981B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719199, XrefRangeEnd = 719204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C35 RID: 3125
			// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x00099FEC File Offset: 0x000981EC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AE2 RID: 10978 RVA: 0x00017680 File Offset: 0x00015880
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C31 RID: 3121
			// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x0009A02C File Offset: 0x0009822C
			// (set) Token: 0x06002AE4 RID: 10980 RVA: 0x00017689 File Offset: 0x00015889
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C32 RID: 3122
			// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x0009A054 File Offset: 0x00098254
			// (set) Token: 0x06002AE6 RID: 10982 RVA: 0x000176A4 File Offset: 0x000158A4
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C33 RID: 3123
			// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x0009A084 File Offset: 0x00098284
			// (set) Token: 0x06002AE8 RID: 10984 RVA: 0x000176C3 File Offset: 0x000158C3
			public unsafe WormShowEarnedSkirmishBadgeFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowEarnedSkirmishBadgeFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowEarnedSkirmishBadgeFlow._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018E0 RID: 6368
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018E1 RID: 6369
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040018E2 RID: 6370
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040018E3 RID: 6371
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040018E4 RID: 6372
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018E5 RID: 6373
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040018E6 RID: 6374
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040018E7 RID: 6375
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018E8 RID: 6376
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
