using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.entities
{
	// Token: 0x020000EA RID: 234
	public static class IUndoableSelectionUtils : Object
	{
		// Token: 0x06000A65 RID: 2661 RVA: 0x000459C4 File Offset: 0x00043BC4
		// Note: this type is marked as 'beforefieldinit'.
		static IUndoableSelectionUtils()
		{
			Il2CppClassPointerStore<IUndoableSelectionUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IUndoableSelectionUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IUndoableSelectionUtils>.NativeClassPtr);
			IUndoableSelectionUtils.NativeMethodInfoPtr_AddUndoToSelection_Public_Static_Void_IUndoableSelection_List_1_Entity_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelectionUtils>.NativeClassPtr, 100665492);
			IUndoableSelectionUtils.NativeMethodInfoPtr_AddUndoToSelection_Public_Static_Void_IUndoableSelection_List_1_AbilityDefinition_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelectionUtils>.NativeClassPtr, 100665493);
			IUndoableSelectionUtils.NativeMethodInfoPtr_AddUndoToSelection_Public_Static_IEnumerable_1_AbilityDefinition_IUndoableSelection_IEnumerable_1_AbilityDefinition_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelectionUtils>.NativeClassPtr, 100665494);
			IUndoableSelectionUtils.NativeMethodInfoPtr_UndoIsAvailable_Public_Static_Boolean_TMatchWithUndos_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelectionUtils>.NativeClassPtr, 100665495);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00045A44 File Offset: 0x00043C44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 565964, RefRangeEnd = 565965, XrefRangeStart = 565938, XrefRangeEnd = 565964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddUndoToSelection(this IUndoableSelection undoable, List<Entity> entities, PlayerEntity selectingPlayer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entities);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUndoableSelectionUtils.NativeMethodInfoPtr_AddUndoToSelection_Public_Static_Void_IUndoableSelection_List_1_Entity_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00045AA0 File Offset: 0x00043CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565965, XrefRangeEnd = 565991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddUndoToSelection(this IUndoableSelection undoable, List<AbilityDefinition> entities, PlayerEntity selectingPlayer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entities);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUndoableSelectionUtils.NativeMethodInfoPtr_AddUndoToSelection_Public_Static_Void_IUndoableSelection_List_1_AbilityDefinition_PlayerEntity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00045AFC File Offset: 0x00043CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565991, XrefRangeEnd = 565998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<AbilityDefinition> AddUndoToSelection<TMatchWithUndos>(this IUndoableSelection undoable, IEnumerable<AbilityDefinition> entities, PlayerEntity selectingPlayer) where TMatchWithUndos : Match
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entities);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUndoableSelectionUtils.MethodInfoStoreGeneric_AddUndoToSelection_Public_Static_IEnumerable_1_AbilityDefinition_IUndoableSelection_IEnumerable_1_AbilityDefinition_PlayerEntity_0<TMatchWithUndos>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinition>>(intPtr3) : null;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00045B64 File Offset: 0x00043D64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 566012, RefRangeEnd = 566015, XrefRangeStart = 565998, XrefRangeEnd = 566012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UndoIsAvailable<TMatchWithUndos>(this TMatchWithUndos matchWithUndos, PlayerEntity selectingPlayer = null) where TMatchWithUndos : Match
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TMatchWithUndos).IsValueType)
				{
					TMatchWithUndos tmatchWithUndos = matchWithUndos;
					intPtr = ((tmatchWithUndos is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatchWithUndos as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatchWithUndos as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref matchWithUndos;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IUndoableSelectionUtils.MethodInfoStoreGeneric_UndoIsAvailable_Public_Static_Boolean_TMatchWithUndos_PlayerEntity_0<TMatchWithUndos>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00005D45 File Offset: 0x00003F45
		public IUndoableSelectionUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_AddUndoToSelection_Public_Static_Void_IUndoableSelection_List_1_Entity_PlayerEntity_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_AddUndoToSelection_Public_Static_Void_IUndoableSelection_List_1_AbilityDefinition_PlayerEntity_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_AddUndoToSelection_Public_Static_IEnumerable_1_AbilityDefinition_IUndoableSelection_IEnumerable_1_AbilityDefinition_PlayerEntity_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_UndoIsAvailable_Public_Static_Boolean_TMatchWithUndos_PlayerEntity_0;

		// Token: 0x02000326 RID: 806
		[ObfuscatedName("Canis.entities.IUndoableSelectionUtils+<AddUndoToSelection>d__2`1")]
		public sealed class _AddUndoToSelection_d__2<TMatchWithUndos> : Object where TMatchWithUndos : Match
		{
			// Token: 0x06002180 RID: 8576 RVA: 0x00098238 File Offset: 0x00096438
			// Note: this type is marked as 'beforefieldinit'.
			static _AddUndoToSelection_d__2()
			{
				Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IUndoableSelectionUtils>.NativeClassPtr, "<AddUndoToSelection>d__2`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatchWithUndos>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr);
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, "<>1__state");
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, "<>2__current");
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, "<>l__initialThreadId");
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, "entities");
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___3__entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, "<>3__entities");
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr_undoable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, "undoable");
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___3__undoable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, "<>3__undoable");
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, "selectingPlayer");
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___3__selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, "<>3__selectingPlayer");
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, "<>7__wrap1");
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr__abilityEnt_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, "<abilityEnt>5__3");
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, 100665496);
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, 100665497);
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, 100665498);
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, 100665499);
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, 100665500);
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_AbilityDefinition__get_Current_Private_Virtual_Final_New_get_AbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, 100665501);
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, 100665502);
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, 100665503);
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_AbilityDefinition__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, 100665504);
				IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr, 100665505);
			}

			// Token: 0x06002181 RID: 8577 RVA: 0x00098444 File Offset: 0x00096644
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AddUndoToSelection_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002182 RID: 8578 RVA: 0x0009848C File Offset: 0x0009668C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565860, XrefRangeEnd = 565870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002183 RID: 8579 RVA: 0x000984C0 File Offset: 0x000966C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565870, XrefRangeEnd = 565914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002184 RID: 8580 RVA: 0x000984FC File Offset: 0x000966FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565914, XrefRangeEnd = 565917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002185 RID: 8581 RVA: 0x00098530 File Offset: 0x00096730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565917, XrefRangeEnd = 565920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700081B RID: 2075
			// (get) Token: 0x06002186 RID: 8582 RVA: 0x00098564 File Offset: 0x00096764
			public unsafe AbilityDefinition System.Collections.Generic.IEnumerator<Canis.entities.AbilityDefinition>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_AbilityDefinition__get_Current_Private_Virtual_Final_New_get_AbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityDefinition>(intPtr3) : null;
				}
			}

			// Token: 0x06002187 RID: 8583 RVA: 0x000985A4 File Offset: 0x000967A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700081C RID: 2076
			// (get) Token: 0x06002188 RID: 8584 RVA: 0x000985D8 File Offset: 0x000967D8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002189 RID: 8585 RVA: 0x00098618 File Offset: 0x00096818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565920, XrefRangeEnd = 565929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<AbilityDefinition> System_Collections_Generic_IEnumerable_Canis_entities_AbilityDefinition__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_AbilityDefinition__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<AbilityDefinition>>(intPtr3) : null;
			}

			// Token: 0x0600218A RID: 8586 RVA: 0x00098658 File Offset: 0x00096858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565929, XrefRangeEnd = 565938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600218B RID: 8587 RVA: 0x000100F5 File Offset: 0x0000E2F5
			public _AddUndoToSelection_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000810 RID: 2064
			// (get) Token: 0x0600218C RID: 8588 RVA: 0x00098698 File Offset: 0x00096898
			// (set) Token: 0x0600218D RID: 8589 RVA: 0x000100FE File Offset: 0x0000E2FE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000811 RID: 2065
			// (get) Token: 0x0600218E RID: 8590 RVA: 0x000986C0 File Offset: 0x000968C0
			// (set) Token: 0x0600218F RID: 8591 RVA: 0x00010119 File Offset: 0x0000E319
			public unsafe AbilityDefinition __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000812 RID: 2066
			// (get) Token: 0x06002190 RID: 8592 RVA: 0x000986F0 File Offset: 0x000968F0
			// (set) Token: 0x06002191 RID: 8593 RVA: 0x00010138 File Offset: 0x0000E338
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000813 RID: 2067
			// (get) Token: 0x06002192 RID: 8594 RVA: 0x00098718 File Offset: 0x00096918
			// (set) Token: 0x06002193 RID: 8595 RVA: 0x00010153 File Offset: 0x0000E353
			public unsafe IEnumerable<AbilityDefinition> entities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr_entities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000814 RID: 2068
			// (get) Token: 0x06002194 RID: 8596 RVA: 0x00098748 File Offset: 0x00096948
			// (set) Token: 0x06002195 RID: 8597 RVA: 0x00010172 File Offset: 0x0000E372
			public unsafe IEnumerable<AbilityDefinition> __3__entities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___3__entities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___3__entities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000815 RID: 2069
			// (get) Token: 0x06002196 RID: 8598 RVA: 0x00098778 File Offset: 0x00096978
			// (set) Token: 0x06002197 RID: 8599 RVA: 0x00010191 File Offset: 0x0000E391
			public unsafe IUndoableSelection undoable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr_undoable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUndoableSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr_undoable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000816 RID: 2070
			// (get) Token: 0x06002198 RID: 8600 RVA: 0x000987A8 File Offset: 0x000969A8
			// (set) Token: 0x06002199 RID: 8601 RVA: 0x000101B0 File Offset: 0x0000E3B0
			public unsafe IUndoableSelection __3__undoable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___3__undoable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUndoableSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___3__undoable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000817 RID: 2071
			// (get) Token: 0x0600219A RID: 8602 RVA: 0x000987D8 File Offset: 0x000969D8
			// (set) Token: 0x0600219B RID: 8603 RVA: 0x000101CF File Offset: 0x0000E3CF
			public unsafe PlayerEntity selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr_selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000818 RID: 2072
			// (get) Token: 0x0600219C RID: 8604 RVA: 0x00098808 File Offset: 0x00096A08
			// (set) Token: 0x0600219D RID: 8605 RVA: 0x000101EE File Offset: 0x0000E3EE
			public unsafe PlayerEntity __3__selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___3__selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___3__selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000819 RID: 2073
			// (get) Token: 0x0600219E RID: 8606 RVA: 0x00098838 File Offset: 0x00096A38
			// (set) Token: 0x0600219F RID: 8607 RVA: 0x0001020D File Offset: 0x0000E40D
			public unsafe IEnumerator<AbilityDefinition> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<AbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700081A RID: 2074
			// (get) Token: 0x060021A0 RID: 8608 RVA: 0x00098868 File Offset: 0x00096A68
			// (set) Token: 0x060021A1 RID: 8609 RVA: 0x0001022C File Offset: 0x0000E42C
			public unsafe AbilityDefinition _abilityEnt_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr__abilityEnt_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUndoableSelectionUtils._AddUndoToSelection_d__2<TMatchWithUndos>.NativeFieldInfoPtr__abilityEnt_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001514 RID: 5396
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001515 RID: 5397
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001516 RID: 5398
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001517 RID: 5399
			private static readonly IntPtr NativeFieldInfoPtr_entities;

			// Token: 0x04001518 RID: 5400
			private static readonly IntPtr NativeFieldInfoPtr___3__entities;

			// Token: 0x04001519 RID: 5401
			private static readonly IntPtr NativeFieldInfoPtr_undoable;

			// Token: 0x0400151A RID: 5402
			private static readonly IntPtr NativeFieldInfoPtr___3__undoable;

			// Token: 0x0400151B RID: 5403
			private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

			// Token: 0x0400151C RID: 5404
			private static readonly IntPtr NativeFieldInfoPtr___3__selectingPlayer;

			// Token: 0x0400151D RID: 5405
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400151E RID: 5406
			private static readonly IntPtr NativeFieldInfoPtr__abilityEnt_5__3;

			// Token: 0x0400151F RID: 5407
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001520 RID: 5408
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001521 RID: 5409
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001522 RID: 5410
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001523 RID: 5411
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001524 RID: 5412
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_AbilityDefinition__get_Current_Private_Virtual_Final_New_get_AbilityDefinition_0;

			// Token: 0x04001525 RID: 5413
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001526 RID: 5414
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001527 RID: 5415
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_AbilityDefinition__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AbilityDefinition_0;

			// Token: 0x04001528 RID: 5416
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000327 RID: 807
		private sealed class MethodInfoStoreGeneric_AddUndoToSelection_Public_Static_IEnumerable_1_AbilityDefinition_IUndoableSelection_IEnumerable_1_AbilityDefinition_PlayerEntity_0<TMatchWithUndos>
		{
			// Token: 0x04001529 RID: 5417
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IUndoableSelectionUtils.NativeMethodInfoPtr_AddUndoToSelection_Public_Static_IEnumerable_1_AbilityDefinition_IUndoableSelection_IEnumerable_1_AbilityDefinition_PlayerEntity_0, Il2CppClassPointerStore<IUndoableSelectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatchWithUndos>.NativeClassPtr)) }))));
		}

		// Token: 0x02000328 RID: 808
		private sealed class MethodInfoStoreGeneric_UndoIsAvailable_Public_Static_Boolean_TMatchWithUndos_PlayerEntity_0<TMatchWithUndos>
		{
			// Token: 0x0400152A RID: 5418
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IUndoableSelectionUtils.NativeMethodInfoPtr_UndoIsAvailable_Public_Static_Boolean_TMatchWithUndos_PlayerEntity_0, Il2CppClassPointerStore<IUndoableSelectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatchWithUndos>.NativeClassPtr)) }))));
		}
	}
}
