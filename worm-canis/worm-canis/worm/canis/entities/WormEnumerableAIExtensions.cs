using System;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace worm.canis.entities
{
	// Token: 0x02000032 RID: 50
	public static class WormEnumerableAIExtensions : Object
	{
		// Token: 0x0600045B RID: 1115 RVA: 0x0007B2DC File Offset: 0x000794DC
		// Note: this type is marked as 'beforefieldinit'.
		static WormEnumerableAIExtensions()
		{
			Il2CppClassPointerStore<WormEnumerableAIExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormEnumerableAIExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEnumerableAIExtensions>.NativeClassPtr);
			WormEnumerableAIExtensions.NativeMethodInfoPtr_GetCombinations_Private_Static_IEnumerable_1_IEnumerable_1_T_List_1_T_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions>.NativeClassPtr, 100664382);
			WormEnumerableAIExtensions.NativeMethodInfoPtr_GetCombinations_Public_Static_IEnumerable_1_IEnumerable_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions>.NativeClassPtr, 100664383);
			WormEnumerableAIExtensions.NativeMethodInfoPtr_FilterNonexistentEntities_Public_Static_IEnumerable_1_Entity_IEnumerable_1_EntityID_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions>.NativeClassPtr, 100664384);
			WormEnumerableAIExtensions.NativeMethodInfoPtr_FilterNonexistentEntities_Public_Static_IEnumerable_1_T_IEnumerable_1_EntityID_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions>.NativeClassPtr, 100664385);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0007B35C File Offset: 0x0007955C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43468, RefRangeEnd = 43470, XrefRangeStart = 43462, XrefRangeEnd = 43468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IEnumerable<T>> GetCombinations<T>(List<T> currentCombo, List<T> remaining, int toSelect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentCombo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remaining);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toSelect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions.MethodInfoStoreGeneric_GetCombinations_Private_Static_IEnumerable_1_IEnumerable_1_T_List_1_T_List_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<T>>>(intPtr3) : null;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0007B3C0 File Offset: 0x000795C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43475, RefRangeEnd = 43477, XrefRangeStart = 43470, XrefRangeEnd = 43475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IEnumerable<T>> GetCombinations<T>(this List<T> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions.MethodInfoStoreGeneric_GetCombinations_Public_Static_IEnumerable_1_IEnumerable_1_T_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<T>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0007B404 File Offset: 0x00079604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43477, XrefRangeEnd = 43492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Entity> FilterNonexistentEntities(this IEnumerable<EntityID> source, WormMatch match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions.NativeMethodInfoPtr_FilterNonexistentEntities_Public_Static_IEnumerable_1_Entity_IEnumerable_1_EntityID_WormMatch_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0007B45C File Offset: 0x0007965C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43492, XrefRangeEnd = 43504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> FilterNonexistentEntities<T>(this IEnumerable<EntityID> source, WormMatch match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions.MethodInfoStoreGeneric_FilterNonexistentEntities_Public_Static_IEnumerable_1_T_IEnumerable_1_EntityID_WormMatch_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00003A40 File Offset: 0x00001C40
		public WormEnumerableAIExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_GetCombinations_Private_Static_IEnumerable_1_IEnumerable_1_T_List_1_T_List_1_T_Int32_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_GetCombinations_Public_Static_IEnumerable_1_IEnumerable_1_T_List_1_T_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_FilterNonexistentEntities_Public_Static_IEnumerable_1_Entity_IEnumerable_1_EntityID_WormMatch_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_FilterNonexistentEntities_Public_Static_IEnumerable_1_T_IEnumerable_1_EntityID_WormMatch_0;

		// Token: 0x020005B6 RID: 1462
		[ObfuscatedName("worm.canis.entities.WormEnumerableAIExtensions+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06004674 RID: 18036 RVA: 0x001887A0 File Offset: 0x001869A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<WormEnumerableAIExtensions.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEnumerableAIExtensions>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEnumerableAIExtensions.__c__DisplayClass2_0>.NativeClassPtr);
				WormEnumerableAIExtensions.__c__DisplayClass2_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions.__c__DisplayClass2_0>.NativeClassPtr, "match");
				WormEnumerableAIExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions.__c__DisplayClass2_0>.NativeClassPtr, 100664386);
				WormEnumerableAIExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__FilterNonexistentEntities_b__0_Internal_IEnumerable_1_Entity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions.__c__DisplayClass2_0>.NativeClassPtr, 100664387);
			}

			// Token: 0x06004675 RID: 18037 RVA: 0x00188808 File Offset: 0x00186A08
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEnumerableAIExtensions.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004676 RID: 18038 RVA: 0x00188844 File Offset: 0x00186A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43321, XrefRangeEnd = 43331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Entity> _FilterNonexistentEntities_b__0(EntityID _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__FilterNonexistentEntities_b__0_Internal_IEnumerable_1_Entity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004677 RID: 18039 RVA: 0x000177CE File Offset: 0x000159CE
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010E2 RID: 4322
			// (get) Token: 0x06004678 RID: 18040 RVA: 0x00188894 File Offset: 0x00186A94
			// (set) Token: 0x06004679 RID: 18041 RVA: 0x000177D7 File Offset: 0x000159D7
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions.__c__DisplayClass2_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions.__c__DisplayClass2_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E69 RID: 11881
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04002E6A RID: 11882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E6B RID: 11883
			private static readonly IntPtr NativeMethodInfoPtr__FilterNonexistentEntities_b__0_Internal_IEnumerable_1_Entity_EntityID_0;
		}

		// Token: 0x020005B7 RID: 1463
		[ObfuscatedName("worm.canis.entities.WormEnumerableAIExtensions+<>c__DisplayClass3_0`1")]
		public sealed class __c__DisplayClass3_0<T> : Object
		{
			// Token: 0x0600467A RID: 18042 RVA: 0x001888C4 File Offset: 0x00186AC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormEnumerableAIExtensions.__c__DisplayClass3_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEnumerableAIExtensions>.NativeClassPtr, "<>c__DisplayClass3_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEnumerableAIExtensions.__c__DisplayClass3_0<T>>.NativeClassPtr);
				WormEnumerableAIExtensions.__c__DisplayClass3_0<T>.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions.__c__DisplayClass3_0<T>>.NativeClassPtr, "match");
				WormEnumerableAIExtensions.__c__DisplayClass3_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions.__c__DisplayClass3_0<T>>.NativeClassPtr, 100664388);
				WormEnumerableAIExtensions.__c__DisplayClass3_0<T>.NativeMethodInfoPtr__FilterNonexistentEntities_b__0_Internal_IEnumerable_1_T_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions.__c__DisplayClass3_0<T>>.NativeClassPtr, 100664389);
			}

			// Token: 0x0600467B RID: 18043 RVA: 0x00188968 File Offset: 0x00186B68
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEnumerableAIExtensions.__c__DisplayClass3_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions.__c__DisplayClass3_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600467C RID: 18044 RVA: 0x001889A4 File Offset: 0x00186BA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43331, XrefRangeEnd = 43348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<T> _FilterNonexistentEntities_b__0(EntityID _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions.__c__DisplayClass3_0<T>.NativeMethodInfoPtr__FilterNonexistentEntities_b__0_Internal_IEnumerable_1_T_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
				}
			}

			// Token: 0x0600467D RID: 18045 RVA: 0x000177F6 File Offset: 0x000159F6
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010E3 RID: 4323
			// (get) Token: 0x0600467E RID: 18046 RVA: 0x001889F4 File Offset: 0x00186BF4
			// (set) Token: 0x0600467F RID: 18047 RVA: 0x000177FF File Offset: 0x000159FF
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions.__c__DisplayClass3_0<T>.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions.__c__DisplayClass3_0<T>.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E6C RID: 11884
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04002E6D RID: 11885
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E6E RID: 11886
			private static readonly IntPtr NativeMethodInfoPtr__FilterNonexistentEntities_b__0_Internal_IEnumerable_1_T_EntityID_0;
		}

		// Token: 0x020005B8 RID: 1464
		[ObfuscatedName("worm.canis.entities.WormEnumerableAIExtensions+<GetCombinations>d__0`1")]
		public sealed class _GetCombinations_d__0<T> : Object
		{
			// Token: 0x06004680 RID: 18048 RVA: 0x00188A24 File Offset: 0x00186C24
			// Note: this type is marked as 'beforefieldinit'.
			static _GetCombinations_d__0()
			{
				Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEnumerableAIExtensions>.NativeClassPtr, "<GetCombinations>d__0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr);
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, "<>1__state");
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, "<>2__current");
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, "<>l__initialThreadId");
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr_toSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, "toSelect");
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___3__toSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, "<>3__toSelect");
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr_currentCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, "currentCombo");
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___3__currentCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, "<>3__currentCombo");
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr_remaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, "remaining");
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___3__remaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, "<>3__remaining");
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, "<i>5__2");
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, "<>7__wrap2");
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, 100664390);
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, 100664391);
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, 100664392);
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, 100664393);
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_T___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, 100664394);
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, 100664395);
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, 100664396);
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, 100664397);
				WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr, 100664398);
			}

			// Token: 0x06004681 RID: 18049 RVA: 0x00188C1C File Offset: 0x00186E1C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetCombinations_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__0<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004682 RID: 18050 RVA: 0x00188C64 File Offset: 0x00186E64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43348, XrefRangeEnd = 43353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004683 RID: 18051 RVA: 0x00188C98 File Offset: 0x00186E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43353, XrefRangeEnd = 43379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004684 RID: 18052 RVA: 0x00188CD4 File Offset: 0x00186ED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43379, XrefRangeEnd = 43382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010EF RID: 4335
			// (get) Token: 0x06004685 RID: 18053 RVA: 0x00188D08 File Offset: 0x00186F08
			public unsafe IEnumerable<T> System.Collections.Generic.IEnumerator<System.Collections.Generic.IEnumerable<T>>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_T___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
				}
			}

			// Token: 0x06004686 RID: 18054 RVA: 0x00188D48 File Offset: 0x00186F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43382, XrefRangeEnd = 43386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010F0 RID: 4336
			// (get) Token: 0x06004687 RID: 18055 RVA: 0x00188D7C File Offset: 0x00186F7C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004688 RID: 18056 RVA: 0x00188DBC File Offset: 0x00186FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43386, XrefRangeEnd = 43394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IEnumerable<T>> System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerable<T>>>(intPtr3) : null;
			}

			// Token: 0x06004689 RID: 18057 RVA: 0x00188DFC File Offset: 0x00186FFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43394, XrefRangeEnd = 43402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600468A RID: 18058 RVA: 0x0001781E File Offset: 0x00015A1E
			public _GetCombinations_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010E4 RID: 4324
			// (get) Token: 0x0600468B RID: 18059 RVA: 0x00188E3C File Offset: 0x0018703C
			// (set) Token: 0x0600468C RID: 18060 RVA: 0x00017827 File Offset: 0x00015A27
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170010E5 RID: 4325
			// (get) Token: 0x0600468D RID: 18061 RVA: 0x00188E64 File Offset: 0x00187064
			// (set) Token: 0x0600468E RID: 18062 RVA: 0x00017842 File Offset: 0x00015A42
			public unsafe IEnumerable<T> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E6 RID: 4326
			// (get) Token: 0x0600468F RID: 18063 RVA: 0x00188E94 File Offset: 0x00187094
			// (set) Token: 0x06004690 RID: 18064 RVA: 0x00017861 File Offset: 0x00015A61
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170010E7 RID: 4327
			// (get) Token: 0x06004691 RID: 18065 RVA: 0x00188EBC File Offset: 0x001870BC
			// (set) Token: 0x06004692 RID: 18066 RVA: 0x0001787C File Offset: 0x00015A7C
			public unsafe int toSelect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr_toSelect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr_toSelect)) = value;
				}
			}

			// Token: 0x170010E8 RID: 4328
			// (get) Token: 0x06004693 RID: 18067 RVA: 0x00188EE4 File Offset: 0x001870E4
			// (set) Token: 0x06004694 RID: 18068 RVA: 0x00017897 File Offset: 0x00015A97
			public unsafe int __3__toSelect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___3__toSelect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___3__toSelect)) = value;
				}
			}

			// Token: 0x170010E9 RID: 4329
			// (get) Token: 0x06004695 RID: 18069 RVA: 0x00188F0C File Offset: 0x0018710C
			// (set) Token: 0x06004696 RID: 18070 RVA: 0x000178B2 File Offset: 0x00015AB2
			public unsafe List<T> currentCombo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr_currentCombo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr_currentCombo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010EA RID: 4330
			// (get) Token: 0x06004697 RID: 18071 RVA: 0x00188F3C File Offset: 0x0018713C
			// (set) Token: 0x06004698 RID: 18072 RVA: 0x000178D1 File Offset: 0x00015AD1
			public unsafe List<T> __3__currentCombo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___3__currentCombo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___3__currentCombo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010EB RID: 4331
			// (get) Token: 0x06004699 RID: 18073 RVA: 0x00188F6C File Offset: 0x0018716C
			// (set) Token: 0x0600469A RID: 18074 RVA: 0x000178F0 File Offset: 0x00015AF0
			public unsafe List<T> remaining
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr_remaining);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr_remaining), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010EC RID: 4332
			// (get) Token: 0x0600469B RID: 18075 RVA: 0x00188F9C File Offset: 0x0018719C
			// (set) Token: 0x0600469C RID: 18076 RVA: 0x0001790F File Offset: 0x00015B0F
			public unsafe List<T> __3__remaining
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___3__remaining);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___3__remaining), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010ED RID: 4333
			// (get) Token: 0x0600469D RID: 18077 RVA: 0x00188FCC File Offset: 0x001871CC
			// (set) Token: 0x0600469E RID: 18078 RVA: 0x0001792E File Offset: 0x00015B2E
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x170010EE RID: 4334
			// (get) Token: 0x0600469F RID: 18079 RVA: 0x00188FF4 File Offset: 0x001871F4
			// (set) Token: 0x060046A0 RID: 18080 RVA: 0x00017949 File Offset: 0x00015B49
			public unsafe IEnumerator<IEnumerable<T>> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerable<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__0<T>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E6F RID: 11887
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002E70 RID: 11888
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002E71 RID: 11889
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002E72 RID: 11890
			private static readonly IntPtr NativeFieldInfoPtr_toSelect;

			// Token: 0x04002E73 RID: 11891
			private static readonly IntPtr NativeFieldInfoPtr___3__toSelect;

			// Token: 0x04002E74 RID: 11892
			private static readonly IntPtr NativeFieldInfoPtr_currentCombo;

			// Token: 0x04002E75 RID: 11893
			private static readonly IntPtr NativeFieldInfoPtr___3__currentCombo;

			// Token: 0x04002E76 RID: 11894
			private static readonly IntPtr NativeFieldInfoPtr_remaining;

			// Token: 0x04002E77 RID: 11895
			private static readonly IntPtr NativeFieldInfoPtr___3__remaining;

			// Token: 0x04002E78 RID: 11896
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04002E79 RID: 11897
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04002E7A RID: 11898
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002E7B RID: 11899
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E7C RID: 11900
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002E7D RID: 11901
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002E7E RID: 11902
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_T___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_T_0;

			// Token: 0x04002E7F RID: 11903
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E80 RID: 11904
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002E81 RID: 11905
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_T_0;

			// Token: 0x04002E82 RID: 11906
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020005B9 RID: 1465
		[ObfuscatedName("worm.canis.entities.WormEnumerableAIExtensions+<GetCombinations>d__1`1")]
		public sealed class _GetCombinations_d__1<T> : Object
		{
			// Token: 0x060046A1 RID: 18081 RVA: 0x00189024 File Offset: 0x00187224
			// Note: this type is marked as 'beforefieldinit'.
			static _GetCombinations_d__1()
			{
				Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEnumerableAIExtensions>.NativeClassPtr, "<GetCombinations>d__1`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr);
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, "<>1__state");
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, "<>2__current");
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, "<>l__initialThreadId");
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, "source");
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, "<>3__source");
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr__count_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, "<count>5__2");
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr__startTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, "<startTime>5__3");
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, "<i>5__4");
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, "<>7__wrap4");
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, 100664399);
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, 100664400);
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, 100664401);
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, 100664402);
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_T___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, 100664403);
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, 100664404);
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, 100664405);
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, 100664406);
				WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr, 100664407);
			}

			// Token: 0x060046A2 RID: 18082 RVA: 0x001891F4 File Offset: 0x001873F4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetCombinations_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEnumerableAIExtensions._GetCombinations_d__1<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060046A3 RID: 18083 RVA: 0x0018923C File Offset: 0x0018743C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43402, XrefRangeEnd = 43407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060046A4 RID: 18084 RVA: 0x00189270 File Offset: 0x00187470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43407, XrefRangeEnd = 43445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060046A5 RID: 18085 RVA: 0x001892AC File Offset: 0x001874AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43445, XrefRangeEnd = 43448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010FA RID: 4346
			// (get) Token: 0x060046A6 RID: 18086 RVA: 0x001892E0 File Offset: 0x001874E0
			public unsafe IEnumerable<T> System.Collections.Generic.IEnumerator<System.Collections.Generic.IEnumerable<T>>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_T___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
				}
			}

			// Token: 0x060046A7 RID: 18087 RVA: 0x00189320 File Offset: 0x00187520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010FB RID: 4347
			// (get) Token: 0x060046A8 RID: 18088 RVA: 0x00189354 File Offset: 0x00187554
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060046A9 RID: 18089 RVA: 0x00189394 File Offset: 0x00187594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43448, XrefRangeEnd = 43455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IEnumerable<T>> System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerable<T>>>(intPtr3) : null;
			}

			// Token: 0x060046AA RID: 18090 RVA: 0x001893D4 File Offset: 0x001875D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43455, XrefRangeEnd = 43462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060046AB RID: 18091 RVA: 0x00017968 File Offset: 0x00015B68
			public _GetCombinations_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010F1 RID: 4337
			// (get) Token: 0x060046AC RID: 18092 RVA: 0x00189414 File Offset: 0x00187614
			// (set) Token: 0x060046AD RID: 18093 RVA: 0x00017971 File Offset: 0x00015B71
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170010F2 RID: 4338
			// (get) Token: 0x060046AE RID: 18094 RVA: 0x0018943C File Offset: 0x0018763C
			// (set) Token: 0x060046AF RID: 18095 RVA: 0x0001798C File Offset: 0x00015B8C
			public unsafe IEnumerable<T> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010F3 RID: 4339
			// (get) Token: 0x060046B0 RID: 18096 RVA: 0x0018946C File Offset: 0x0018766C
			// (set) Token: 0x060046B1 RID: 18097 RVA: 0x000179AB File Offset: 0x00015BAB
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170010F4 RID: 4340
			// (get) Token: 0x060046B2 RID: 18098 RVA: 0x00189494 File Offset: 0x00187694
			// (set) Token: 0x060046B3 RID: 18099 RVA: 0x000179C6 File Offset: 0x00015BC6
			public unsafe List<T> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010F5 RID: 4341
			// (get) Token: 0x060046B4 RID: 18100 RVA: 0x001894C4 File Offset: 0x001876C4
			// (set) Token: 0x060046B5 RID: 18101 RVA: 0x000179E5 File Offset: 0x00015BE5
			public unsafe List<T> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010F6 RID: 4342
			// (get) Token: 0x060046B6 RID: 18102 RVA: 0x001894F4 File Offset: 0x001876F4
			// (set) Token: 0x060046B7 RID: 18103 RVA: 0x00017A04 File Offset: 0x00015C04
			public unsafe int _count_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr__count_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr__count_5__2)) = value;
				}
			}

			// Token: 0x170010F7 RID: 4343
			// (get) Token: 0x060046B8 RID: 18104 RVA: 0x0018951C File Offset: 0x0018771C
			// (set) Token: 0x060046B9 RID: 18105 RVA: 0x00017A1F File Offset: 0x00015C1F
			public unsafe int _startTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr__startTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr__startTime_5__3)) = value;
				}
			}

			// Token: 0x170010F8 RID: 4344
			// (get) Token: 0x060046BA RID: 18106 RVA: 0x00189544 File Offset: 0x00187744
			// (set) Token: 0x060046BB RID: 18107 RVA: 0x00017A3A File Offset: 0x00015C3A
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x170010F9 RID: 4345
			// (get) Token: 0x060046BC RID: 18108 RVA: 0x0018956C File Offset: 0x0018776C
			// (set) Token: 0x060046BD RID: 18109 RVA: 0x00017A55 File Offset: 0x00015C55
			public unsafe IEnumerator<IEnumerable<T>> __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerable<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEnumerableAIExtensions._GetCombinations_d__1<T>.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E83 RID: 11907
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002E84 RID: 11908
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002E85 RID: 11909
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002E86 RID: 11910
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04002E87 RID: 11911
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04002E88 RID: 11912
			private static readonly IntPtr NativeFieldInfoPtr__count_5__2;

			// Token: 0x04002E89 RID: 11913
			private static readonly IntPtr NativeFieldInfoPtr__startTime_5__3;

			// Token: 0x04002E8A RID: 11914
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04002E8B RID: 11915
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x04002E8C RID: 11916
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002E8D RID: 11917
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E8E RID: 11918
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002E8F RID: 11919
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002E90 RID: 11920
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_T___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_T_0;

			// Token: 0x04002E91 RID: 11921
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E92 RID: 11922
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002E93 RID: 11923
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_T_0;

			// Token: 0x04002E94 RID: 11924
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020005BA RID: 1466
		private sealed class MethodInfoStoreGeneric_GetCombinations_Private_Static_IEnumerable_1_IEnumerable_1_T_List_1_T_List_1_T_Int32_0<T>
		{
			// Token: 0x04002E95 RID: 11925
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(WormEnumerableAIExtensions.NativeMethodInfoPtr_GetCombinations_Private_Static_IEnumerable_1_IEnumerable_1_T_List_1_T_List_1_T_Int32_0, Il2CppClassPointerStore<WormEnumerableAIExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005BB RID: 1467
		private sealed class MethodInfoStoreGeneric_GetCombinations_Public_Static_IEnumerable_1_IEnumerable_1_T_List_1_T_0<T>
		{
			// Token: 0x04002E96 RID: 11926
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(WormEnumerableAIExtensions.NativeMethodInfoPtr_GetCombinations_Public_Static_IEnumerable_1_IEnumerable_1_T_List_1_T_0, Il2CppClassPointerStore<WormEnumerableAIExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005BC RID: 1468
		private sealed class MethodInfoStoreGeneric_FilterNonexistentEntities_Public_Static_IEnumerable_1_T_IEnumerable_1_EntityID_WormMatch_0<T>
		{
			// Token: 0x04002E97 RID: 11927
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(WormEnumerableAIExtensions.NativeMethodInfoPtr_FilterNonexistentEntities_Public_Static_IEnumerable_1_T_IEnumerable_1_EntityID_WormMatch_0, Il2CppClassPointerStore<WormEnumerableAIExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
