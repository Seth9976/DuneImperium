using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.data.Skirmish.RulesModifiers
{
	// Token: 0x0200009B RID: 155
	public static class RulesModifiers : Object
	{
		// Token: 0x06000C77 RID: 3191 RVA: 0x00092BA0 File Offset: 0x00090DA0
		// Note: this type is marked as 'beforefieldinit'.
		static RulesModifiers()
		{
			Il2CppClassPointerStore<RulesModifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers", "RulesModifiers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RulesModifiers>.NativeClassPtr);
			RulesModifiers.NativeFieldInfoPtr_allModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesModifiers>.NativeClassPtr, "allModifiers");
			RulesModifiers.NativeMethodInfoPtr_FindAllModifiers_Private_Static_IEnumerable_1_RulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifiers>.NativeClassPtr, 100665668);
			RulesModifiers.NativeMethodInfoPtr_get_All_Public_Static_get_IReadOnlyList_1_RulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifiers>.NativeClassPtr, 100665669);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00092C0C File Offset: 0x00090E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74244, XrefRangeEnd = 74249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<RulesModifier> FindAllModifiers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesModifiers.NativeMethodInfoPtr_FindAllModifiers_Private_Static_IEnumerable_1_RulesModifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<RulesModifier>>(intPtr3) : null;
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x00092C40 File Offset: 0x00090E40
		public unsafe static IReadOnlyList<RulesModifier> All
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74290, RefRangeEnd = 74291, XrefRangeStart = 74249, XrefRangeEnd = 74290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesModifiers.NativeMethodInfoPtr_get_All_Public_Static_get_IReadOnlyList_1_RulesModifier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<RulesModifier>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00006E9B File Offset: 0x0000509B
		public RulesModifiers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x00092C74 File Offset: 0x00090E74
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x00006EA4 File Offset: 0x000050A4
		public unsafe static List<RulesModifier> allModifiers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RulesModifiers.NativeFieldInfoPtr_allModifiers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RulesModifier>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RulesModifiers.NativeFieldInfoPtr_allModifiers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeFieldInfoPtr_allModifiers;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_FindAllModifiers_Private_Static_IEnumerable_1_RulesModifier_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_Static_get_IReadOnlyList_1_RulesModifier_0;

		// Token: 0x0200061D RID: 1565
		[ObfuscatedName("worm.canis.data.Skirmish.RulesModifiers.RulesModifiers+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004E67 RID: 20071 RVA: 0x001A2650 File Offset: 0x001A0850
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RulesModifiers.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RulesModifiers>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RulesModifiers.__c>.NativeClassPtr);
				RulesModifiers.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesModifiers.__c>.NativeClassPtr, "<>9");
				RulesModifiers.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesModifiers.__c>.NativeClassPtr, "<>9__3_0");
				RulesModifiers.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifiers.__c>.NativeClassPtr, 100665672);
				RulesModifiers.__c.NativeMethodInfoPtr__get_All_b__3_0_Internal_Int32_RulesModifier_RulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifiers.__c>.NativeClassPtr, 100665673);
			}

			// Token: 0x06004E68 RID: 20072 RVA: 0x001A26CC File Offset: 0x001A08CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RulesModifiers.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesModifiers.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E69 RID: 20073 RVA: 0x001A2708 File Offset: 0x001A0908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_All_b__3_0(RulesModifier a, RulesModifier b)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesModifiers.__c.NativeMethodInfoPtr__get_All_b__3_0_Internal_Int32_RulesModifier_RulesModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E6A RID: 20074 RVA: 0x0001B11D File Offset: 0x0001931D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001349 RID: 4937
			// (get) Token: 0x06004E6B RID: 20075 RVA: 0x001A2768 File Offset: 0x001A0968
			// (set) Token: 0x06004E6C RID: 20076 RVA: 0x0001B126 File Offset: 0x00019326
			public unsafe static RulesModifiers.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RulesModifiers.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RulesModifiers.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RulesModifiers.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700134A RID: 4938
			// (get) Token: 0x06004E6D RID: 20077 RVA: 0x001A2790 File Offset: 0x001A0990
			// (set) Token: 0x06004E6E RID: 20078 RVA: 0x0001B138 File Offset: 0x00019338
			public unsafe static Comparison<RulesModifier> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RulesModifiers.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<RulesModifier>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RulesModifiers.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400336F RID: 13167
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003370 RID: 13168
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04003371 RID: 13169
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003372 RID: 13170
			private static readonly IntPtr NativeMethodInfoPtr__get_All_b__3_0_Internal_Int32_RulesModifier_RulesModifier_0;
		}

		// Token: 0x0200061E RID: 1566
		[ObfuscatedName("worm.canis.data.Skirmish.RulesModifiers.RulesModifiers+<FindAllModifiers>d__1")]
		public sealed class _FindAllModifiers_d__1 : Object
		{
			// Token: 0x06004E6F RID: 20079 RVA: 0x001A27B8 File Offset: 0x001A09B8
			// Note: this type is marked as 'beforefieldinit'.
			static _FindAllModifiers_d__1()
			{
				Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RulesModifiers>.NativeClassPtr, "<FindAllModifiers>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr);
				RulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, "<>1__state");
				RulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, "<>2__current");
				RulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, "<>l__initialThreadId");
				RulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr__rulesModifierType_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, "<rulesModifierType>5__2");
				RulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, "<>7__wrap2");
				RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100665674);
				RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100665675);
				RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100665676);
				RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100665677);
				RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_data_Skirmish_RulesModifiers_RulesModifier__get_Current_Private_Virtual_Final_New_get_RulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100665678);
				RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100665679);
				RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100665680);
				RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_data_Skirmish_RulesModifiers_RulesModifier__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_RulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100665681);
				RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100665682);
			}

			// Token: 0x06004E70 RID: 20080 RVA: 0x001A28FC File Offset: 0x001A0AFC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FindAllModifiers_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RulesModifiers._FindAllModifiers_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E71 RID: 20081 RVA: 0x001A2944 File Offset: 0x001A0B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74184, XrefRangeEnd = 74189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E72 RID: 20082 RVA: 0x001A2978 File Offset: 0x001A0B78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74189, XrefRangeEnd = 74234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E73 RID: 20083 RVA: 0x001A29B4 File Offset: 0x001A0BB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74234, XrefRangeEnd = 74237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001350 RID: 4944
			// (get) Token: 0x06004E74 RID: 20084 RVA: 0x001A29E8 File Offset: 0x001A0BE8
			public unsafe RulesModifier System.Collections.Generic.IEnumerator<worm.canis.data.Skirmish.RulesModifiers.RulesModifier>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_data_Skirmish_RulesModifiers_RulesModifier__get_Current_Private_Virtual_Final_New_get_RulesModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RulesModifier>(intPtr3) : null;
				}
			}

			// Token: 0x06004E75 RID: 20085 RVA: 0x001A2A28 File Offset: 0x001A0C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74237, XrefRangeEnd = 74242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001351 RID: 4945
			// (get) Token: 0x06004E76 RID: 20086 RVA: 0x001A2A5C File Offset: 0x001A0C5C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E77 RID: 20087 RVA: 0x001A2A9C File Offset: 0x001A0C9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74242, XrefRangeEnd = 74244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<RulesModifier> System_Collections_Generic_IEnumerable_worm_canis_data_Skirmish_RulesModifiers_RulesModifier__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_data_Skirmish_RulesModifiers_RulesModifier__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_RulesModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<RulesModifier>>(intPtr3) : null;
			}

			// Token: 0x06004E78 RID: 20088 RVA: 0x001A2ADC File Offset: 0x001A0CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004E79 RID: 20089 RVA: 0x0001B14A File Offset: 0x0001934A
			public _FindAllModifiers_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700134B RID: 4939
			// (get) Token: 0x06004E7A RID: 20090 RVA: 0x001A2B1C File Offset: 0x001A0D1C
			// (set) Token: 0x06004E7B RID: 20091 RVA: 0x0001B153 File Offset: 0x00019353
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700134C RID: 4940
			// (get) Token: 0x06004E7C RID: 20092 RVA: 0x001A2B44 File Offset: 0x001A0D44
			// (set) Token: 0x06004E7D RID: 20093 RVA: 0x0001B16E File Offset: 0x0001936E
			public unsafe RulesModifier __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RulesModifier>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700134D RID: 4941
			// (get) Token: 0x06004E7E RID: 20094 RVA: 0x001A2B74 File Offset: 0x001A0D74
			// (set) Token: 0x06004E7F RID: 20095 RVA: 0x0001B18D File Offset: 0x0001938D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700134E RID: 4942
			// (get) Token: 0x06004E80 RID: 20096 RVA: 0x001A2B9C File Offset: 0x001A0D9C
			// (set) Token: 0x06004E81 RID: 20097 RVA: 0x0001B1A8 File Offset: 0x000193A8
			public unsafe Type _rulesModifierType_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr__rulesModifierType_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr__rulesModifierType_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700134F RID: 4943
			// (get) Token: 0x06004E82 RID: 20098 RVA: 0x001A2BCC File Offset: 0x001A0DCC
			// (set) Token: 0x06004E83 RID: 20099 RVA: 0x0001B1C7 File Offset: 0x000193C7
			public unsafe IEnumerator<Type> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Type>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003373 RID: 13171
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003374 RID: 13172
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003375 RID: 13173
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003376 RID: 13174
			private static readonly IntPtr NativeFieldInfoPtr__rulesModifierType_5__2;

			// Token: 0x04003377 RID: 13175
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04003378 RID: 13176
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003379 RID: 13177
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400337A RID: 13178
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400337B RID: 13179
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400337C RID: 13180
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_data_Skirmish_RulesModifiers_RulesModifier__get_Current_Private_Virtual_Final_New_get_RulesModifier_0;

			// Token: 0x0400337D RID: 13181
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400337E RID: 13182
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400337F RID: 13183
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_data_Skirmish_RulesModifiers_RulesModifier__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_RulesModifier_0;

			// Token: 0x04003380 RID: 13184
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
