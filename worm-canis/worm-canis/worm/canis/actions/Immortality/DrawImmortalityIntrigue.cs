using System;
using Canis;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions.Immortality
{
	// Token: 0x020002DD RID: 733
	public class DrawImmortalityIntrigue : global::Canis.actions.Action
	{
		// Token: 0x06001E21 RID: 7713 RVA: 0x000CE910 File Offset: 0x000CCB10
		// Note: this type is marked as 'beforefieldinit'.
		static DrawImmortalityIntrigue()
		{
			Il2CppClassPointerStore<DrawImmortalityIntrigue>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.Immortality", "DrawImmortalityIntrigue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawImmortalityIntrigue>.NativeClassPtr);
			DrawImmortalityIntrigue.NativeFieldInfoPtr__LogMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue>.NativeClassPtr, "<LogMode>k__BackingField");
			DrawImmortalityIntrigue.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue>.NativeClassPtr, 100670323);
			DrawImmortalityIntrigue.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue>.NativeClassPtr, 100670324);
			DrawImmortalityIntrigue.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue>.NativeClassPtr, 100670325);
			DrawImmortalityIntrigue.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue>.NativeClassPtr, 100670326);
			DrawImmortalityIntrigue.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue>.NativeClassPtr, 100670327);
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x000CE9B8 File Offset: 0x000CCBB8
		// (set) Token: 0x06001E23 RID: 7715 RVA: 0x000CE9F4 File Offset: 0x000CCBF4
		public unsafe virtual ActionLogModes LogMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x000CEA34 File Offset: 0x000CCC34
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 135162, RefRangeEnd = 135196, XrefRangeStart = 135162, XrefRangeEnd = 135196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawImmortalityIntrigue(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawImmortalityIntrigue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x000CEA80 File Offset: 0x000CCC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170198, XrefRangeEnd = 170206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(WormMatch wormMatch, WormPlayer player, WormIntriguePlayable cardToDraw)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cardToDraw);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x000CEAF4 File Offset: 0x000CCCF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170206, XrefRangeEnd = 170212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrawImmortalityIntrigue.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0000C9CF File Offset: 0x0000ABCF
		public DrawImmortalityIntrigue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x000CEB40 File Offset: 0x000CCD40
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		public unsafe ActionLogModes _LogMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue.NativeFieldInfoPtr__LogMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue.NativeFieldInfoPtr__LogMode_k__BackingField)) = value;
			}
		}

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeFieldInfoPtr__LogMode_k__BackingField;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0;

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormIntriguePlayable_0;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0200077D RID: 1917
		[ObfuscatedName("worm.canis.actions.Immortality.DrawImmortalityIntrigue+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06006B9A RID: 27546 RVA: 0x001FC614 File Offset: 0x001FA814
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DrawImmortalityIntrigue.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawImmortalityIntrigue>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawImmortalityIntrigue.__c>.NativeClassPtr);
				DrawImmortalityIntrigue.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue.__c>.NativeClassPtr, "<>9");
				DrawImmortalityIntrigue.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue.__c>.NativeClassPtr, "<>9__6_0");
				DrawImmortalityIntrigue.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue.__c>.NativeClassPtr, "<>9__6_1");
				DrawImmortalityIntrigue.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue.__c>.NativeClassPtr, 100670329);
				DrawImmortalityIntrigue.__c.NativeMethodInfoPtr__execute_b__6_0_Internal_Boolean_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue.__c>.NativeClassPtr, 100670330);
				DrawImmortalityIntrigue.__c.NativeMethodInfoPtr__execute_b__6_1_Internal_Boolean_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue.__c>.NativeClassPtr, 100670331);
			}

			// Token: 0x06006B9B RID: 27547 RVA: 0x001FC6B8 File Offset: 0x001FA8B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawImmortalityIntrigue.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006B9C RID: 27548 RVA: 0x001FC6F4 File Offset: 0x001FA8F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169968, XrefRangeEnd = 169985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__6_0(WormIntriguePlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue.__c.NativeMethodInfoPtr__execute_b__6_0_Internal_Boolean_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006B9D RID: 27549 RVA: 0x001FC744 File Offset: 0x001FA944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169985, XrefRangeEnd = 170002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__6_1(WormIntriguePlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue.__c.NativeMethodInfoPtr__execute_b__6_1_Internal_Boolean_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006B9E RID: 27550 RVA: 0x0002A70B File Offset: 0x0002890B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D47 RID: 7495
			// (get) Token: 0x06006B9F RID: 27551 RVA: 0x001FC794 File Offset: 0x001FA994
			// (set) Token: 0x06006BA0 RID: 27552 RVA: 0x0002A714 File Offset: 0x00028914
			public unsafe static DrawImmortalityIntrigue.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DrawImmortalityIntrigue.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawImmortalityIntrigue.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DrawImmortalityIntrigue.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D48 RID: 7496
			// (get) Token: 0x06006BA1 RID: 27553 RVA: 0x001FC7BC File Offset: 0x001FA9BC
			// (set) Token: 0x06006BA2 RID: 27554 RVA: 0x0002A726 File Offset: 0x00028926
			public unsafe static Func<WormIntriguePlayable, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DrawImmortalityIntrigue.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormIntriguePlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DrawImmortalityIntrigue.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D49 RID: 7497
			// (get) Token: 0x06006BA3 RID: 27555 RVA: 0x001FC7E4 File Offset: 0x001FA9E4
			// (set) Token: 0x06006BA4 RID: 27556 RVA: 0x0002A738 File Offset: 0x00028938
			public unsafe static Func<WormIntriguePlayable, bool> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DrawImmortalityIntrigue.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormIntriguePlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DrawImmortalityIntrigue.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004592 RID: 17810
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004593 RID: 17811
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04004594 RID: 17812
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04004595 RID: 17813
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004596 RID: 17814
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__6_0_Internal_Boolean_WormIntriguePlayable_0;

			// Token: 0x04004597 RID: 17815
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__6_1_Internal_Boolean_WormIntriguePlayable_0;
		}

		// Token: 0x0200077E RID: 1918
		[ObfuscatedName("worm.canis.actions.Immortality.DrawImmortalityIntrigue+<MakeAnalyticsData>d__5")]
		public sealed class _MakeAnalyticsData_d__5 : Object
		{
			// Token: 0x06006BA5 RID: 27557 RVA: 0x001FC80C File Offset: 0x001FAA0C
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__5()
			{
				Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawImmortalityIntrigue>.NativeClassPtr, "<MakeAnalyticsData>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr);
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "<>1__state");
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "<>2__current");
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "<>l__initialThreadId");
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_cardToDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "cardToDraw");
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__cardToDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "<>3__cardToDraw");
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "wormMatch");
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "<>3__wormMatch");
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "player");
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "<>3__player");
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100670332);
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100670333);
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100670334);
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100670335);
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100670336);
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100670337);
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100670338);
				DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100670339);
			}

			// Token: 0x06006BA6 RID: 27558 RVA: 0x001FC98C File Offset: 0x001FAB8C
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawImmortalityIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006BA7 RID: 27559 RVA: 0x001FC9D4 File Offset: 0x001FABD4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006BA8 RID: 27560 RVA: 0x001FCA08 File Offset: 0x001FAC08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170002, XrefRangeEnd = 170018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D53 RID: 7507
			// (get) Token: 0x06006BA9 RID: 27561 RVA: 0x001FCA44 File Offset: 0x001FAC44
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x06006BAA RID: 27562 RVA: 0x001FCA7C File Offset: 0x001FAC7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170018, XrefRangeEnd = 170023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D54 RID: 7508
			// (get) Token: 0x06006BAB RID: 27563 RVA: 0x001FCAB0 File Offset: 0x001FACB0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170023, XrefRangeEnd = 170026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006BAC RID: 27564 RVA: 0x001FCAF0 File Offset: 0x001FACF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170026, XrefRangeEnd = 170036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x06006BAD RID: 27565 RVA: 0x001FCB30 File Offset: 0x001FAD30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006BAE RID: 27566 RVA: 0x0002A74A File Offset: 0x0002894A
			public _MakeAnalyticsData_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D4A RID: 7498
			// (get) Token: 0x06006BAF RID: 27567 RVA: 0x001FCB70 File Offset: 0x001FAD70
			// (set) Token: 0x06006BB0 RID: 27568 RVA: 0x0002A753 File Offset: 0x00028953
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D4B RID: 7499
			// (get) Token: 0x06006BB1 RID: 27569 RVA: 0x001FCB98 File Offset: 0x001FAD98
			// (set) Token: 0x06006BB2 RID: 27570 RVA: 0x0002A76E File Offset: 0x0002896E
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001D4C RID: 7500
			// (get) Token: 0x06006BB3 RID: 27571 RVA: 0x001FCBC8 File Offset: 0x001FADC8
			// (set) Token: 0x06006BB4 RID: 27572 RVA: 0x0002A79C File Offset: 0x0002899C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001D4D RID: 7501
			// (get) Token: 0x06006BB5 RID: 27573 RVA: 0x001FCBF0 File Offset: 0x001FADF0
			// (set) Token: 0x06006BB6 RID: 27574 RVA: 0x0002A7B7 File Offset: 0x000289B7
			public unsafe WormIntriguePlayable cardToDraw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_cardToDraw);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntriguePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_cardToDraw), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D4E RID: 7502
			// (get) Token: 0x06006BB7 RID: 27575 RVA: 0x001FCC20 File Offset: 0x001FAE20
			// (set) Token: 0x06006BB8 RID: 27576 RVA: 0x0002A7D6 File Offset: 0x000289D6
			public unsafe WormIntriguePlayable __3__cardToDraw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__cardToDraw);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntriguePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__cardToDraw), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D4F RID: 7503
			// (get) Token: 0x06006BB9 RID: 27577 RVA: 0x001FCC50 File Offset: 0x001FAE50
			// (set) Token: 0x06006BBA RID: 27578 RVA: 0x0002A7F5 File Offset: 0x000289F5
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D50 RID: 7504
			// (get) Token: 0x06006BBB RID: 27579 RVA: 0x001FCC80 File Offset: 0x001FAE80
			// (set) Token: 0x06006BBC RID: 27580 RVA: 0x0002A814 File Offset: 0x00028A14
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D51 RID: 7505
			// (get) Token: 0x06006BBD RID: 27581 RVA: 0x001FCCB0 File Offset: 0x001FAEB0
			// (set) Token: 0x06006BBE RID: 27582 RVA: 0x0002A833 File Offset: 0x00028A33
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D52 RID: 7506
			// (get) Token: 0x06006BBF RID: 27583 RVA: 0x001FCCE0 File Offset: 0x001FAEE0
			// (set) Token: 0x06006BC0 RID: 27584 RVA: 0x0002A852 File Offset: 0x00028A52
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004598 RID: 17816
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004599 RID: 17817
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400459A RID: 17818
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400459B RID: 17819
			private static readonly IntPtr NativeFieldInfoPtr_cardToDraw;

			// Token: 0x0400459C RID: 17820
			private static readonly IntPtr NativeFieldInfoPtr___3__cardToDraw;

			// Token: 0x0400459D RID: 17821
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x0400459E RID: 17822
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x0400459F RID: 17823
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040045A0 RID: 17824
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x040045A1 RID: 17825
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040045A2 RID: 17826
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040045A3 RID: 17827
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040045A4 RID: 17828
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x040045A5 RID: 17829
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040045A6 RID: 17830
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040045A7 RID: 17831
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x040045A8 RID: 17832
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200077F RID: 1919
		[ObfuscatedName("worm.canis.actions.Immortality.DrawImmortalityIntrigue+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x06006BC1 RID: 27585 RVA: 0x001FCD10 File Offset: 0x001FAF10
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawImmortalityIntrigue>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr);
				DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, "<>1__state");
				DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, "<>2__current");
				DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, "<>l__initialThreadId");
				DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, "<>4__this");
				DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, "<player>5__2");
				DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr__wm_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, "<wm>5__3");
				DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr__cardToDraw_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, "<cardToDraw>5__4");
				DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, "<>7__wrap4");
				DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, 100670340);
				DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, 100670341);
				DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, 100670342);
				DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, 100670343);
				DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, 100670344);
				DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, 100670345);
				DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, 100670346);
				DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, 100670347);
				DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr, 100670348);
			}

			// Token: 0x06006BC2 RID: 27586 RVA: 0x001FCE90 File Offset: 0x001FB090
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawImmortalityIntrigue._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006BC3 RID: 27587 RVA: 0x001FCED8 File Offset: 0x001FB0D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170036, XrefRangeEnd = 170041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006BC4 RID: 27588 RVA: 0x001FCF0C File Offset: 0x001FB10C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170041, XrefRangeEnd = 170188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006BC5 RID: 27589 RVA: 0x001FCF48 File Offset: 0x001FB148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170188, XrefRangeEnd = 170191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D5D RID: 7517
			// (get) Token: 0x06006BC6 RID: 27590 RVA: 0x001FCF7C File Offset: 0x001FB17C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006BC7 RID: 27591 RVA: 0x001FCFBC File Offset: 0x001FB1BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170191, XrefRangeEnd = 170196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D5E RID: 7518
			// (get) Token: 0x06006BC8 RID: 27592 RVA: 0x001FCFF0 File Offset: 0x001FB1F0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006BC9 RID: 27593 RVA: 0x001FD030 File Offset: 0x001FB230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170196, XrefRangeEnd = 170198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006BCA RID: 27594 RVA: 0x001FD070 File Offset: 0x001FB270
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawImmortalityIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006BCB RID: 27595 RVA: 0x0002A871 File Offset: 0x00028A71
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D55 RID: 7509
			// (get) Token: 0x06006BCC RID: 27596 RVA: 0x001FD0B0 File Offset: 0x001FB2B0
			// (set) Token: 0x06006BCD RID: 27597 RVA: 0x0002A87A File Offset: 0x00028A7A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D56 RID: 7510
			// (get) Token: 0x06006BCE RID: 27598 RVA: 0x001FD0D8 File Offset: 0x001FB2D8
			// (set) Token: 0x06006BCF RID: 27599 RVA: 0x0002A895 File Offset: 0x00028A95
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D57 RID: 7511
			// (get) Token: 0x06006BD0 RID: 27600 RVA: 0x001FD108 File Offset: 0x001FB308
			// (set) Token: 0x06006BD1 RID: 27601 RVA: 0x0002A8B4 File Offset: 0x00028AB4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001D58 RID: 7512
			// (get) Token: 0x06006BD2 RID: 27602 RVA: 0x001FD130 File Offset: 0x001FB330
			// (set) Token: 0x06006BD3 RID: 27603 RVA: 0x0002A8CF File Offset: 0x00028ACF
			public unsafe DrawImmortalityIntrigue __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawImmortalityIntrigue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D59 RID: 7513
			// (get) Token: 0x06006BD4 RID: 27604 RVA: 0x001FD160 File Offset: 0x001FB360
			// (set) Token: 0x06006BD5 RID: 27605 RVA: 0x0002A8EE File Offset: 0x00028AEE
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D5A RID: 7514
			// (get) Token: 0x06006BD6 RID: 27606 RVA: 0x001FD190 File Offset: 0x001FB390
			// (set) Token: 0x06006BD7 RID: 27607 RVA: 0x0002A90D File Offset: 0x00028B0D
			public unsafe WormMatch _wm_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr__wm_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr__wm_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D5B RID: 7515
			// (get) Token: 0x06006BD8 RID: 27608 RVA: 0x001FD1C0 File Offset: 0x001FB3C0
			// (set) Token: 0x06006BD9 RID: 27609 RVA: 0x0002A92C File Offset: 0x00028B2C
			public unsafe WormIntriguePlayable _cardToDraw_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr__cardToDraw_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntriguePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr__cardToDraw_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D5C RID: 7516
			// (get) Token: 0x06006BDA RID: 27610 RVA: 0x001FD1F0 File Offset: 0x001FB3F0
			// (set) Token: 0x06006BDB RID: 27611 RVA: 0x0002A94B File Offset: 0x00028B4B
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawImmortalityIntrigue._execute_d__6.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045A9 RID: 17833
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040045AA RID: 17834
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040045AB RID: 17835
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040045AC RID: 17836
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040045AD RID: 17837
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040045AE RID: 17838
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__3;

			// Token: 0x040045AF RID: 17839
			private static readonly IntPtr NativeFieldInfoPtr__cardToDraw_5__4;

			// Token: 0x040045B0 RID: 17840
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x040045B1 RID: 17841
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040045B2 RID: 17842
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040045B3 RID: 17843
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040045B4 RID: 17844
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040045B5 RID: 17845
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040045B6 RID: 17846
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040045B7 RID: 17847
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040045B8 RID: 17848
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040045B9 RID: 17849
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
