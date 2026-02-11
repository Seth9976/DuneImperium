using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.skirmishScripts
{
	// Token: 0x0200004F RID: 79
	public static class SkirmishRulesModifiers : Object
	{
		// Token: 0x060004DF RID: 1247 RVA: 0x0002C4B8 File Offset: 0x0002A6B8
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishRulesModifiers()
		{
			Il2CppClassPointerStore<SkirmishRulesModifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.skirmishScripts", "SkirmishRulesModifiers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishRulesModifiers>.NativeClassPtr);
			SkirmishRulesModifiers.NativeFieldInfoPtr_AllModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishRulesModifiers>.NativeClassPtr, "AllModifiers");
			SkirmishRulesModifiers.NativeMethodInfoPtr_FindAllModifiers_Private_Static_IEnumerable_1_SkirmishRulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifiers>.NativeClassPtr, 100664278);
			SkirmishRulesModifiers.NativeMethodInfoPtr_get_All_Public_Static_get_IReadOnlyList_1_SkirmishRulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifiers>.NativeClassPtr, 100664279);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0002C524 File Offset: 0x0002A724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553748, XrefRangeEnd = 553753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<SkirmishRulesModifier> FindAllModifiers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRulesModifiers.NativeMethodInfoPtr_FindAllModifiers_Private_Static_IEnumerable_1_SkirmishRulesModifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SkirmishRulesModifier>>(intPtr3) : null;
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0002C558 File Offset: 0x0002A758
		public unsafe static IReadOnlyList<SkirmishRulesModifier> All
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553753, XrefRangeEnd = 553794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRulesModifiers.NativeMethodInfoPtr_get_All_Public_Static_get_IReadOnlyList_1_SkirmishRulesModifier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SkirmishRulesModifier>>(intPtr3) : null;
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00004272 File Offset: 0x00002472
		public SkirmishRulesModifiers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0002C58C File Offset: 0x0002A78C
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x0000427B File Offset: 0x0000247B
		public unsafe static List<SkirmishRulesModifier> AllModifiers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SkirmishRulesModifiers.NativeFieldInfoPtr_AllModifiers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SkirmishRulesModifier>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkirmishRulesModifiers.NativeFieldInfoPtr_AllModifiers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeFieldInfoPtr_AllModifiers;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_FindAllModifiers_Private_Static_IEnumerable_1_SkirmishRulesModifier_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_Static_get_IReadOnlyList_1_SkirmishRulesModifier_0;

		// Token: 0x020002A2 RID: 674
		[ObfuscatedName("Canis.skirmishScripts.SkirmishRulesModifiers+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001C90 RID: 7312 RVA: 0x00087CFC File Offset: 0x00085EFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SkirmishRulesModifiers.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkirmishRulesModifiers>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishRulesModifiers.__c>.NativeClassPtr);
				SkirmishRulesModifiers.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishRulesModifiers.__c>.NativeClassPtr, "<>9");
				SkirmishRulesModifiers.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishRulesModifiers.__c>.NativeClassPtr, "<>9__3_0");
				SkirmishRulesModifiers.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifiers.__c>.NativeClassPtr, 100664282);
				SkirmishRulesModifiers.__c.NativeMethodInfoPtr__get_All_b__3_0_Internal_Int32_SkirmishRulesModifier_SkirmishRulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifiers.__c>.NativeClassPtr, 100664283);
			}

			// Token: 0x06001C91 RID: 7313 RVA: 0x00087D78 File Offset: 0x00085F78
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishRulesModifiers.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRulesModifiers.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C92 RID: 7314 RVA: 0x00087DB4 File Offset: 0x00085FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_All_b__3_0(SkirmishRulesModifier a, SkirmishRulesModifier b)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRulesModifiers.__c.NativeMethodInfoPtr__get_All_b__3_0_Internal_Int32_SkirmishRulesModifier_SkirmishRulesModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C93 RID: 7315 RVA: 0x0000DA31 File Offset: 0x0000BC31
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700069D RID: 1693
			// (get) Token: 0x06001C94 RID: 7316 RVA: 0x00087E14 File Offset: 0x00086014
			// (set) Token: 0x06001C95 RID: 7317 RVA: 0x0000DA3A File Offset: 0x0000BC3A
			public unsafe static SkirmishRulesModifiers.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SkirmishRulesModifiers.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkirmishRulesModifiers.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SkirmishRulesModifiers.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069E RID: 1694
			// (get) Token: 0x06001C96 RID: 7318 RVA: 0x00087E3C File Offset: 0x0008603C
			// (set) Token: 0x06001C97 RID: 7319 RVA: 0x0000DA4C File Offset: 0x0000BC4C
			public unsafe static Comparison<SkirmishRulesModifier> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SkirmishRulesModifiers.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<SkirmishRulesModifier>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SkirmishRulesModifiers.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001239 RID: 4665
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400123A RID: 4666
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400123B RID: 4667
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400123C RID: 4668
			private static readonly IntPtr NativeMethodInfoPtr__get_All_b__3_0_Internal_Int32_SkirmishRulesModifier_SkirmishRulesModifier_0;
		}

		// Token: 0x020002A3 RID: 675
		[ObfuscatedName("Canis.skirmishScripts.SkirmishRulesModifiers+<FindAllModifiers>d__1")]
		public sealed class _FindAllModifiers_d__1 : Object
		{
			// Token: 0x06001C98 RID: 7320 RVA: 0x00087E64 File Offset: 0x00086064
			// Note: this type is marked as 'beforefieldinit'.
			static _FindAllModifiers_d__1()
			{
				Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkirmishRulesModifiers>.NativeClassPtr, "<FindAllModifiers>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr);
				SkirmishRulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, "<>1__state");
				SkirmishRulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, "<>2__current");
				SkirmishRulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, "<>l__initialThreadId");
				SkirmishRulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr__rulesModifierType_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, "<rulesModifierType>5__2");
				SkirmishRulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, "<>7__wrap2");
				SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100664284);
				SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100664285);
				SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100664286);
				SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100664287);
				SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_skirmishScripts_SkirmishRulesModifier__get_Current_Private_Virtual_Final_New_get_SkirmishRulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100664288);
				SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100664289);
				SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100664290);
				SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_skirmishScripts_SkirmishRulesModifier__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SkirmishRulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100664291);
				SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr, 100664292);
			}

			// Token: 0x06001C99 RID: 7321 RVA: 0x00087FA8 File Offset: 0x000861A8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FindAllModifiers_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishRulesModifiers._FindAllModifiers_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C9A RID: 7322 RVA: 0x00087FF0 File Offset: 0x000861F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553689, XrefRangeEnd = 553694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C9B RID: 7323 RVA: 0x00088024 File Offset: 0x00086224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553694, XrefRangeEnd = 553738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C9C RID: 7324 RVA: 0x00088060 File Offset: 0x00086260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553738, XrefRangeEnd = 553741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006A4 RID: 1700
			// (get) Token: 0x06001C9D RID: 7325 RVA: 0x00088094 File Offset: 0x00086294
			public unsafe SkirmishRulesModifier System.Collections.Generic.IEnumerator<Canis.skirmishScripts.SkirmishRulesModifier>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_skirmishScripts_SkirmishRulesModifier__get_Current_Private_Virtual_Final_New_get_SkirmishRulesModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishRulesModifier>(intPtr3) : null;
				}
			}

			// Token: 0x06001C9E RID: 7326 RVA: 0x000880D4 File Offset: 0x000862D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553741, XrefRangeEnd = 553746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006A5 RID: 1701
			// (get) Token: 0x06001C9F RID: 7327 RVA: 0x00088108 File Offset: 0x00086308
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001CA0 RID: 7328 RVA: 0x00088148 File Offset: 0x00086348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553746, XrefRangeEnd = 553748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<SkirmishRulesModifier> System_Collections_Generic_IEnumerable_Canis_skirmishScripts_SkirmishRulesModifier__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_skirmishScripts_SkirmishRulesModifier__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SkirmishRulesModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<SkirmishRulesModifier>>(intPtr3) : null;
			}

			// Token: 0x06001CA1 RID: 7329 RVA: 0x00088188 File Offset: 0x00086388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001CA2 RID: 7330 RVA: 0x0000DA5E File Offset: 0x0000BC5E
			public _FindAllModifiers_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700069F RID: 1695
			// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x000881C8 File Offset: 0x000863C8
			// (set) Token: 0x06001CA4 RID: 7332 RVA: 0x0000DA67 File Offset: 0x0000BC67
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006A0 RID: 1696
			// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x000881F0 File Offset: 0x000863F0
			// (set) Token: 0x06001CA6 RID: 7334 RVA: 0x0000DA82 File Offset: 0x0000BC82
			public unsafe SkirmishRulesModifier __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkirmishRulesModifier>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A1 RID: 1697
			// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x00088220 File Offset: 0x00086420
			// (set) Token: 0x06001CA8 RID: 7336 RVA: 0x0000DAA1 File Offset: 0x0000BCA1
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170006A2 RID: 1698
			// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x00088248 File Offset: 0x00086448
			// (set) Token: 0x06001CAA RID: 7338 RVA: 0x0000DABC File Offset: 0x0000BCBC
			public unsafe Type _rulesModifierType_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr__rulesModifierType_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr__rulesModifierType_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A3 RID: 1699
			// (get) Token: 0x06001CAB RID: 7339 RVA: 0x00088278 File Offset: 0x00086478
			// (set) Token: 0x06001CAC RID: 7340 RVA: 0x0000DADB File Offset: 0x0000BCDB
			public unsafe IEnumerator<Type> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Type>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishRulesModifiers._FindAllModifiers_d__1.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400123D RID: 4669
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400123E RID: 4670
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400123F RID: 4671
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001240 RID: 4672
			private static readonly IntPtr NativeFieldInfoPtr__rulesModifierType_5__2;

			// Token: 0x04001241 RID: 4673
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001242 RID: 4674
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001243 RID: 4675
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001244 RID: 4676
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001245 RID: 4677
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001246 RID: 4678
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_skirmishScripts_SkirmishRulesModifier__get_Current_Private_Virtual_Final_New_get_SkirmishRulesModifier_0;

			// Token: 0x04001247 RID: 4679
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001248 RID: 4680
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001249 RID: 4681
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_skirmishScripts_SkirmishRulesModifier__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SkirmishRulesModifier_0;

			// Token: 0x0400124A RID: 4682
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
