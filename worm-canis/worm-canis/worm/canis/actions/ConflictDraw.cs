using System;
using Canis;
using Canis.actions;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000233 RID: 563
	public class ConflictDraw : global::Canis.actions.Action
	{
		// Token: 0x060018A2 RID: 6306 RVA: 0x000B8CB0 File Offset: 0x000B6EB0
		// Note: this type is marked as 'beforefieldinit'.
		static ConflictDraw()
		{
			Il2CppClassPointerStore<ConflictDraw>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "ConflictDraw");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConflictDraw>.NativeClassPtr);
			ConflictDraw.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw>.NativeClassPtr, 100667576);
			ConflictDraw.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormConflictPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw>.NativeClassPtr, 100667577);
			ConflictDraw.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw>.NativeClassPtr, 100667578);
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x000B8D1C File Offset: 0x000B6F1C
		[CallerCount(191)]
		[CachedScanResults(RefRangeStart = 51381, RefRangeEnd = 51572, XrefRangeStart = 51381, XrefRangeEnd = 51572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConflictDraw(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConflictDraw>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x000B8D68 File Offset: 0x000B6F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132948, XrefRangeEnd = 132955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(WormMatch wormMatch, WormConflictPlayable cardToDraw)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cardToDraw);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormConflictPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x000B8DCC File Offset: 0x000B6FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132955, XrefRangeEnd = 132961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConflictDraw.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0000A9FA File Offset: 0x00008BFA
		public ConflictDraw(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormConflictPlayable_0;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x02000662 RID: 1634
		[ObfuscatedName("worm.canis.actions.ConflictDraw+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600535B RID: 21339 RVA: 0x001B348C File Offset: 0x001B168C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConflictDraw.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConflictDraw>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConflictDraw.__c>.NativeClassPtr);
				ConflictDraw.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw.__c>.NativeClassPtr, "<>9");
				ConflictDraw.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw.__c>.NativeClassPtr, "<>9__2_0");
				ConflictDraw.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw.__c>.NativeClassPtr, "<>9__2_1");
				ConflictDraw.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw.__c>.NativeClassPtr, 100667580);
				ConflictDraw.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw.__c>.NativeClassPtr, 100667581);
				ConflictDraw.__c.NativeMethodInfoPtr__execute_b__2_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw.__c>.NativeClassPtr, 100667582);
			}

			// Token: 0x0600535C RID: 21340 RVA: 0x001B3530 File Offset: 0x001B1730
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConflictDraw.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600535D RID: 21341 RVA: 0x001B356C File Offset: 0x001B176C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132665, XrefRangeEnd = 132672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__2_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600535E RID: 21342 RVA: 0x001B35BC File Offset: 0x001B17BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132672, XrefRangeEnd = 132679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__2_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw.__c.NativeMethodInfoPtr__execute_b__2_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600535F RID: 21343 RVA: 0x0001D35F File Offset: 0x0001B55F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014B9 RID: 5305
			// (get) Token: 0x06005360 RID: 21344 RVA: 0x001B360C File Offset: 0x001B180C
			// (set) Token: 0x06005361 RID: 21345 RVA: 0x0001D368 File Offset: 0x0001B568
			public unsafe static ConflictDraw.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConflictDraw.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConflictDraw.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConflictDraw.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014BA RID: 5306
			// (get) Token: 0x06005362 RID: 21346 RVA: 0x001B3634 File Offset: 0x001B1834
			// (set) Token: 0x06005363 RID: 21347 RVA: 0x0001D37A File Offset: 0x0001B57A
			public unsafe static Func<Entity, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConflictDraw.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConflictDraw.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014BB RID: 5307
			// (get) Token: 0x06005364 RID: 21348 RVA: 0x001B365C File Offset: 0x001B185C
			// (set) Token: 0x06005365 RID: 21349 RVA: 0x0001D38C File Offset: 0x0001B58C
			public unsafe static Func<Entity, bool> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConflictDraw.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConflictDraw.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003693 RID: 13971
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003694 RID: 13972
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04003695 RID: 13973
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04003696 RID: 13974
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003697 RID: 13975
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_0_Internal_Boolean_Entity_0;

			// Token: 0x04003698 RID: 13976
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_1_Internal_Boolean_Entity_0;
		}

		// Token: 0x02000663 RID: 1635
		[ObfuscatedName("worm.canis.actions.ConflictDraw+<MakeAnalyticsData>d__1")]
		public sealed class _MakeAnalyticsData_d__1 : Object
		{
			// Token: 0x06005366 RID: 21350 RVA: 0x001B3684 File Offset: 0x001B1884
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__1()
			{
				Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConflictDraw>.NativeClassPtr, "<MakeAnalyticsData>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr);
				ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr, "<>1__state");
				ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr, "<>2__current");
				ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr, "<>l__initialThreadId");
				ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr_cardToDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr, "cardToDraw");
				ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr___3__cardToDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr, "<>3__cardToDraw");
				ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr, "wormMatch");
				ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr, "<>3__wormMatch");
				ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr, 100667583);
				ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr, 100667584);
				ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr, 100667585);
				ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr, 100667586);
				ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr, 100667587);
				ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr, 100667588);
				ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr, 100667589);
				ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr, 100667590);
			}

			// Token: 0x06005367 RID: 21351 RVA: 0x001B37DC File Offset: 0x001B19DC
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConflictDraw._MakeAnalyticsData_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005368 RID: 21352 RVA: 0x001B3824 File Offset: 0x001B1A24
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005369 RID: 21353 RVA: 0x001B3858 File Offset: 0x001B1A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132679, XrefRangeEnd = 132683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170014C3 RID: 5315
			// (get) Token: 0x0600536A RID: 21354 RVA: 0x001B3894 File Offset: 0x001B1A94
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x0600536B RID: 21355 RVA: 0x001B38CC File Offset: 0x001B1ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132683, XrefRangeEnd = 132688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170014C4 RID: 5316
			// (get) Token: 0x0600536C RID: 21356 RVA: 0x001B3900 File Offset: 0x001B1B00
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132688, XrefRangeEnd = 132691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600536D RID: 21357 RVA: 0x001B3940 File Offset: 0x001B1B40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132691, XrefRangeEnd = 132700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x0600536E RID: 21358 RVA: 0x001B3980 File Offset: 0x001B1B80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._MakeAnalyticsData_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600536F RID: 21359 RVA: 0x0001D39E File Offset: 0x0001B59E
			public _MakeAnalyticsData_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014BC RID: 5308
			// (get) Token: 0x06005370 RID: 21360 RVA: 0x001B39C0 File Offset: 0x001B1BC0
			// (set) Token: 0x06005371 RID: 21361 RVA: 0x0001D3A7 File Offset: 0x0001B5A7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170014BD RID: 5309
			// (get) Token: 0x06005372 RID: 21362 RVA: 0x001B39E8 File Offset: 0x001B1BE8
			// (set) Token: 0x06005373 RID: 21363 RVA: 0x0001D3C2 File Offset: 0x0001B5C2
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170014BE RID: 5310
			// (get) Token: 0x06005374 RID: 21364 RVA: 0x001B3A18 File Offset: 0x001B1C18
			// (set) Token: 0x06005375 RID: 21365 RVA: 0x0001D3F0 File Offset: 0x0001B5F0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170014BF RID: 5311
			// (get) Token: 0x06005376 RID: 21366 RVA: 0x001B3A40 File Offset: 0x001B1C40
			// (set) Token: 0x06005377 RID: 21367 RVA: 0x0001D40B File Offset: 0x0001B60B
			public unsafe WormConflictPlayable cardToDraw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr_cardToDraw);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr_cardToDraw), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014C0 RID: 5312
			// (get) Token: 0x06005378 RID: 21368 RVA: 0x001B3A70 File Offset: 0x001B1C70
			// (set) Token: 0x06005379 RID: 21369 RVA: 0x0001D42A File Offset: 0x0001B62A
			public unsafe WormConflictPlayable __3__cardToDraw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr___3__cardToDraw);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr___3__cardToDraw), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014C1 RID: 5313
			// (get) Token: 0x0600537A RID: 21370 RVA: 0x001B3AA0 File Offset: 0x001B1CA0
			// (set) Token: 0x0600537B RID: 21371 RVA: 0x0001D449 File Offset: 0x0001B649
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014C2 RID: 5314
			// (get) Token: 0x0600537C RID: 21372 RVA: 0x001B3AD0 File Offset: 0x001B1CD0
			// (set) Token: 0x0600537D RID: 21373 RVA: 0x0001D468 File Offset: 0x0001B668
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._MakeAnalyticsData_d__1.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003699 RID: 13977
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400369A RID: 13978
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400369B RID: 13979
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400369C RID: 13980
			private static readonly IntPtr NativeFieldInfoPtr_cardToDraw;

			// Token: 0x0400369D RID: 13981
			private static readonly IntPtr NativeFieldInfoPtr___3__cardToDraw;

			// Token: 0x0400369E RID: 13982
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x0400369F RID: 13983
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x040036A0 RID: 13984
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040036A1 RID: 13985
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036A2 RID: 13986
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040036A3 RID: 13987
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x040036A4 RID: 13988
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036A5 RID: 13989
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040036A6 RID: 13990
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x040036A7 RID: 13991
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000664 RID: 1636
		[ObfuscatedName("worm.canis.actions.ConflictDraw+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x0600537E RID: 21374 RVA: 0x001B3B00 File Offset: 0x001B1D00
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConflictDraw>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr);
				ConflictDraw._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, "<>1__state");
				ConflictDraw._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, "<>2__current");
				ConflictDraw._execute_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, "<>l__initialThreadId");
				ConflictDraw._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, "<>4__this");
				ConflictDraw._execute_d__2.NativeFieldInfoPtr__wormMatch_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, "<wormMatch>5__2");
				ConflictDraw._execute_d__2.NativeFieldInfoPtr__board_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, "<board>5__3");
				ConflictDraw._execute_d__2.NativeFieldInfoPtr__conflictCard_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, "<conflictCard>5__4");
				ConflictDraw._execute_d__2.NativeFieldInfoPtr__revealCardSequence_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, "<revealCardSequence>5__5");
				ConflictDraw._execute_d__2.NativeFieldInfoPtr__lastRoundSequence_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, "<lastRoundSequence>5__6");
				ConflictDraw._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, 100667591);
				ConflictDraw._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, 100667592);
				ConflictDraw._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, 100667593);
				ConflictDraw._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, 100667594);
				ConflictDraw._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, 100667595);
				ConflictDraw._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, 100667596);
				ConflictDraw._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, 100667597);
				ConflictDraw._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr, 100667598);
			}

			// Token: 0x0600537F RID: 21375 RVA: 0x001B3C80 File Offset: 0x001B1E80
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConflictDraw._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005380 RID: 21376 RVA: 0x001B3CC8 File Offset: 0x001B1EC8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005381 RID: 21377 RVA: 0x001B3CFC File Offset: 0x001B1EFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132700, XrefRangeEnd = 132941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170014CE RID: 5326
			// (get) Token: 0x06005382 RID: 21378 RVA: 0x001B3D38 File Offset: 0x001B1F38
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005383 RID: 21379 RVA: 0x001B3D78 File Offset: 0x001B1F78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132941, XrefRangeEnd = 132946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170014CF RID: 5327
			// (get) Token: 0x06005384 RID: 21380 RVA: 0x001B3DAC File Offset: 0x001B1FAC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005385 RID: 21381 RVA: 0x001B3DEC File Offset: 0x001B1FEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132946, XrefRangeEnd = 132948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005386 RID: 21382 RVA: 0x001B3E2C File Offset: 0x001B202C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConflictDraw._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005387 RID: 21383 RVA: 0x0001D487 File Offset: 0x0001B687
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014C5 RID: 5317
			// (get) Token: 0x06005388 RID: 21384 RVA: 0x001B3E6C File Offset: 0x001B206C
			// (set) Token: 0x06005389 RID: 21385 RVA: 0x0001D490 File Offset: 0x0001B690
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170014C6 RID: 5318
			// (get) Token: 0x0600538A RID: 21386 RVA: 0x001B3E94 File Offset: 0x001B2094
			// (set) Token: 0x0600538B RID: 21387 RVA: 0x0001D4AB File Offset: 0x0001B6AB
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014C7 RID: 5319
			// (get) Token: 0x0600538C RID: 21388 RVA: 0x001B3EC4 File Offset: 0x001B20C4
			// (set) Token: 0x0600538D RID: 21389 RVA: 0x0001D4CA File Offset: 0x0001B6CA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170014C8 RID: 5320
			// (get) Token: 0x0600538E RID: 21390 RVA: 0x001B3EEC File Offset: 0x001B20EC
			// (set) Token: 0x0600538F RID: 21391 RVA: 0x0001D4E5 File Offset: 0x0001B6E5
			public unsafe ConflictDraw __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConflictDraw>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014C9 RID: 5321
			// (get) Token: 0x06005390 RID: 21392 RVA: 0x001B3F1C File Offset: 0x001B211C
			// (set) Token: 0x06005391 RID: 21393 RVA: 0x0001D504 File Offset: 0x0001B704
			public unsafe WormMatch _wormMatch_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr__wormMatch_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr__wormMatch_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014CA RID: 5322
			// (get) Token: 0x06005392 RID: 21394 RVA: 0x001B3F4C File Offset: 0x001B214C
			// (set) Token: 0x06005393 RID: 21395 RVA: 0x0001D523 File Offset: 0x0001B723
			public unsafe WormBoard _board_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr__board_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormBoard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr__board_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014CB RID: 5323
			// (get) Token: 0x06005394 RID: 21396 RVA: 0x001B3F7C File Offset: 0x001B217C
			// (set) Token: 0x06005395 RID: 21397 RVA: 0x0001D542 File Offset: 0x0001B742
			public unsafe WormConflictPlayable _conflictCard_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr__conflictCard_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr__conflictCard_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014CC RID: 5324
			// (get) Token: 0x06005396 RID: 21398 RVA: 0x001B3FAC File Offset: 0x001B21AC
			// (set) Token: 0x06005397 RID: 21399 RVA: 0x0001D561 File Offset: 0x0001B761
			public unsafe SequenceHelper _revealCardSequence_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr__revealCardSequence_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr__revealCardSequence_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014CD RID: 5325
			// (get) Token: 0x06005398 RID: 21400 RVA: 0x001B3FDC File Offset: 0x001B21DC
			// (set) Token: 0x06005399 RID: 21401 RVA: 0x0001D580 File Offset: 0x0001B780
			public unsafe SequenceHelper _lastRoundSequence_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr__lastRoundSequence_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConflictDraw._execute_d__2.NativeFieldInfoPtr__lastRoundSequence_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036A8 RID: 13992
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040036A9 RID: 13993
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040036AA RID: 13994
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040036AB RID: 13995
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040036AC RID: 13996
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__2;

			// Token: 0x040036AD RID: 13997
			private static readonly IntPtr NativeFieldInfoPtr__board_5__3;

			// Token: 0x040036AE RID: 13998
			private static readonly IntPtr NativeFieldInfoPtr__conflictCard_5__4;

			// Token: 0x040036AF RID: 13999
			private static readonly IntPtr NativeFieldInfoPtr__revealCardSequence_5__5;

			// Token: 0x040036B0 RID: 14000
			private static readonly IntPtr NativeFieldInfoPtr__lastRoundSequence_5__6;

			// Token: 0x040036B1 RID: 14001
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040036B2 RID: 14002
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036B3 RID: 14003
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040036B4 RID: 14004
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040036B5 RID: 14005
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036B6 RID: 14006
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040036B7 RID: 14007
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040036B8 RID: 14008
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
