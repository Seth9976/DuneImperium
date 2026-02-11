using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace lib.canis.worm_canis.data.Skirmish.ScoringMethods
{
	// Token: 0x0200000A RID: 10
	public static class SkirmishScoringMethods : Object
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00069538 File Offset: 0x00067738
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishScoringMethods()
		{
			Il2CppClassPointerStore<SkirmishScoringMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "lib.canis.worm_canis.data.Skirmish.ScoringMethods", "SkirmishScoringMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishScoringMethods>.NativeClassPtr);
			SkirmishScoringMethods.NativeFieldInfoPtr_allScoringMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishScoringMethods>.NativeClassPtr, "allScoringMethods");
			SkirmishScoringMethods.NativeMethodInfoPtr_FindAllScoringMethods_Private_Static_IEnumerable_1_SkirmishScoringMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethods>.NativeClassPtr, 100663311);
			SkirmishScoringMethods.NativeMethodInfoPtr_get_All_Public_Static_get_IReadOnlyList_1_SkirmishScoringMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethods>.NativeClassPtr, 100663312);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000695A4 File Offset: 0x000677A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3304, XrefRangeEnd = 3309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<SkirmishScoringMethod> FindAllScoringMethods()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoringMethods.NativeMethodInfoPtr_FindAllScoringMethods_Private_Static_IEnumerable_1_SkirmishScoringMethod_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SkirmishScoringMethod>>(intPtr3) : null;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000695D8 File Offset: 0x000677D8
		public unsafe static IReadOnlyList<SkirmishScoringMethod> All
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 3350, RefRangeEnd = 3351, XrefRangeStart = 3309, XrefRangeEnd = 3350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoringMethods.NativeMethodInfoPtr_get_All_Public_Static_get_IReadOnlyList_1_SkirmishScoringMethod_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SkirmishScoringMethod>>(intPtr3) : null;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000214B File Offset: 0x0000034B
		public SkirmishScoringMethods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0006960C File Offset: 0x0006780C
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002154 File Offset: 0x00000354
		public unsafe static List<SkirmishScoringMethod> allScoringMethods
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SkirmishScoringMethods.NativeFieldInfoPtr_allScoringMethods, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SkirmishScoringMethod>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkirmishScoringMethods.NativeFieldInfoPtr_allScoringMethods, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_allScoringMethods;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_FindAllScoringMethods_Private_Static_IEnumerable_1_SkirmishScoringMethod_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_Static_get_IReadOnlyList_1_SkirmishScoringMethod_0;

		// Token: 0x02000550 RID: 1360
		[ObfuscatedName("lib.canis.worm_canis.data.Skirmish.ScoringMethods.SkirmishScoringMethods+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004070 RID: 16496 RVA: 0x001767D8 File Offset: 0x001749D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SkirmishScoringMethods.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkirmishScoringMethods>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishScoringMethods.__c>.NativeClassPtr);
				SkirmishScoringMethods.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishScoringMethods.__c>.NativeClassPtr, "<>9");
				SkirmishScoringMethods.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishScoringMethods.__c>.NativeClassPtr, "<>9__3_0");
				SkirmishScoringMethods.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethods.__c>.NativeClassPtr, 100663315);
				SkirmishScoringMethods.__c.NativeMethodInfoPtr__get_All_b__3_0_Internal_Int32_SkirmishScoringMethod_SkirmishScoringMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethods.__c>.NativeClassPtr, 100663316);
			}

			// Token: 0x06004071 RID: 16497 RVA: 0x00176854 File Offset: 0x00174A54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishScoringMethods.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoringMethods.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004072 RID: 16498 RVA: 0x00176890 File Offset: 0x00174A90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3100, XrefRangeEnd = 3101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_All_b__3_0(SkirmishScoringMethod a, SkirmishScoringMethod b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoringMethods.__c.NativeMethodInfoPtr__get_All_b__3_0_Internal_Int32_SkirmishScoringMethod_SkirmishScoringMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004073 RID: 16499 RVA: 0x000145E4 File Offset: 0x000127E4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EF8 RID: 3832
			// (get) Token: 0x06004074 RID: 16500 RVA: 0x001768F0 File Offset: 0x00174AF0
			// (set) Token: 0x06004075 RID: 16501 RVA: 0x000145ED File Offset: 0x000127ED
			public unsafe static SkirmishScoringMethods.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SkirmishScoringMethods.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkirmishScoringMethods.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SkirmishScoringMethods.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EF9 RID: 3833
			// (get) Token: 0x06004076 RID: 16502 RVA: 0x00176918 File Offset: 0x00174B18
			// (set) Token: 0x06004077 RID: 16503 RVA: 0x000145FF File Offset: 0x000127FF
			public unsafe static Comparison<SkirmishScoringMethod> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SkirmishScoringMethods.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<SkirmishScoringMethod>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SkirmishScoringMethods.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002AD7 RID: 10967
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002AD8 RID: 10968
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002AD9 RID: 10969
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002ADA RID: 10970
			private static readonly IntPtr NativeMethodInfoPtr__get_All_b__3_0_Internal_Int32_SkirmishScoringMethod_SkirmishScoringMethod_0;
		}

		// Token: 0x02000551 RID: 1361
		[ObfuscatedName("lib.canis.worm_canis.data.Skirmish.ScoringMethods.SkirmishScoringMethods+<FindAllScoringMethods>d__1")]
		public sealed class _FindAllScoringMethods_d__1 : Object
		{
			// Token: 0x06004078 RID: 16504 RVA: 0x00176940 File Offset: 0x00174B40
			// Note: this type is marked as 'beforefieldinit'.
			static _FindAllScoringMethods_d__1()
			{
				Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkirmishScoringMethods>.NativeClassPtr, "<FindAllScoringMethods>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr);
				SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr, "<>1__state");
				SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr, "<>2__current");
				SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr, "<>l__initialThreadId");
				SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeFieldInfoPtr__rulesModifierType_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr, "<rulesModifierType>5__2");
				SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr, "<>7__wrap2");
				SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr, 100663317);
				SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr, 100663318);
				SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr, 100663319);
				SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr, 100663320);
				SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_lib_canis_worm_canis_data_Skirmish_ScoringMethods_SkirmishScoringMethod__get_Current_Private_Virtual_Final_New_get_SkirmishScoringMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr, 100663321);
				SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr, 100663322);
				SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr, 100663323);
				SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_lib_canis_worm_canis_data_Skirmish_ScoringMethods_SkirmishScoringMethod__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SkirmishScoringMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr, 100663324);
				SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr, 100663325);
			}

			// Token: 0x06004079 RID: 16505 RVA: 0x00176A84 File Offset: 0x00174C84
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3101, XrefRangeEnd = 3103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FindAllScoringMethods_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishScoringMethods._FindAllScoringMethods_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600407A RID: 16506 RVA: 0x00176ACC File Offset: 0x00174CCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3229, XrefRangeEnd = 3234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600407B RID: 16507 RVA: 0x00176B00 File Offset: 0x00174D00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3234, XrefRangeEnd = 3279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600407C RID: 16508 RVA: 0x00176B3C File Offset: 0x00174D3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3279, XrefRangeEnd = 3282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000EFF RID: 3839
			// (get) Token: 0x0600407D RID: 16509 RVA: 0x00176B70 File Offset: 0x00174D70
			public unsafe SkirmishScoringMethod System.Collections.Generic.IEnumerator<lib.canis.worm_canis.data.Skirmish.ScoringMethods.SkirmishScoringMethod>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_lib_canis_worm_canis_data_Skirmish_ScoringMethods_SkirmishScoringMethod__get_Current_Private_Virtual_Final_New_get_SkirmishScoringMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishScoringMethod>(intPtr3) : null;
				}
			}

			// Token: 0x0600407E RID: 16510 RVA: 0x00176BB0 File Offset: 0x00174DB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3297, XrefRangeEnd = 3302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F00 RID: 3840
			// (get) Token: 0x0600407F RID: 16511 RVA: 0x00176BE4 File Offset: 0x00174DE4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004080 RID: 16512 RVA: 0x00176C24 File Offset: 0x00174E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3302, XrefRangeEnd = 3304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<SkirmishScoringMethod> System_Collections_Generic_IEnumerable_lib_canis_worm_canis_data_Skirmish_ScoringMethods_SkirmishScoringMethod__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_lib_canis_worm_canis_data_Skirmish_ScoringMethods_SkirmishScoringMethod__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SkirmishScoringMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<SkirmishScoringMethod>>(intPtr3) : null;
			}

			// Token: 0x06004081 RID: 16513 RVA: 0x00176C64 File Offset: 0x00174E64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004082 RID: 16514 RVA: 0x00014611 File Offset: 0x00012811
			public _FindAllScoringMethods_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EFA RID: 3834
			// (get) Token: 0x06004083 RID: 16515 RVA: 0x00176CA4 File Offset: 0x00174EA4
			// (set) Token: 0x06004084 RID: 16516 RVA: 0x0001461A File Offset: 0x0001281A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000EFB RID: 3835
			// (get) Token: 0x06004085 RID: 16517 RVA: 0x00176CCC File Offset: 0x00174ECC
			// (set) Token: 0x06004086 RID: 16518 RVA: 0x00014635 File Offset: 0x00012835
			public unsafe SkirmishScoringMethod __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkirmishScoringMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EFC RID: 3836
			// (get) Token: 0x06004087 RID: 16519 RVA: 0x00176CFC File Offset: 0x00174EFC
			// (set) Token: 0x06004088 RID: 16520 RVA: 0x00014654 File Offset: 0x00012854
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000EFD RID: 3837
			// (get) Token: 0x06004089 RID: 16521 RVA: 0x00176D24 File Offset: 0x00174F24
			// (set) Token: 0x0600408A RID: 16522 RVA: 0x0001466F File Offset: 0x0001286F
			public unsafe Type _rulesModifierType_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeFieldInfoPtr__rulesModifierType_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeFieldInfoPtr__rulesModifierType_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EFE RID: 3838
			// (get) Token: 0x0600408B RID: 16523 RVA: 0x00176D54 File Offset: 0x00174F54
			// (set) Token: 0x0600408C RID: 16524 RVA: 0x0001468E File Offset: 0x0001288E
			public unsafe IEnumerator<Type> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Type>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoringMethods._FindAllScoringMethods_d__1.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002ADB RID: 10971
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002ADC RID: 10972
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002ADD RID: 10973
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002ADE RID: 10974
			private static readonly IntPtr NativeFieldInfoPtr__rulesModifierType_5__2;

			// Token: 0x04002ADF RID: 10975
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04002AE0 RID: 10976
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002AE1 RID: 10977
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002AE2 RID: 10978
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002AE3 RID: 10979
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002AE4 RID: 10980
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_lib_canis_worm_canis_data_Skirmish_ScoringMethods_SkirmishScoringMethod__get_Current_Private_Virtual_Final_New_get_SkirmishScoringMethod_0;

			// Token: 0x04002AE5 RID: 10981
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002AE6 RID: 10982
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002AE7 RID: 10983
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_lib_canis_worm_canis_data_Skirmish_ScoringMethods_SkirmishScoringMethod__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SkirmishScoringMethod_0;

			// Token: 0x04002AE8 RID: 10984
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
