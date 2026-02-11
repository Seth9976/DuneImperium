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
	// Token: 0x0200023D RID: 573
	public class DrawIntrigue : global::Canis.actions.Action
	{
		// Token: 0x06001901 RID: 6401 RVA: 0x000BA32C File Offset: 0x000B852C
		// Note: this type is marked as 'beforefieldinit'.
		static DrawIntrigue()
		{
			Il2CppClassPointerStore<DrawIntrigue>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "DrawIntrigue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawIntrigue>.NativeClassPtr);
			DrawIntrigue.NativeFieldInfoPtr__LogMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue>.NativeClassPtr, "<LogMode>k__BackingField");
			DrawIntrigue.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue>.NativeClassPtr, 100667747);
			DrawIntrigue.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue>.NativeClassPtr, 100667748);
			DrawIntrigue.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue>.NativeClassPtr, 100667749);
			DrawIntrigue.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue>.NativeClassPtr, 100667750);
			DrawIntrigue.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue>.NativeClassPtr, 100667751);
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x000BA3D4 File Offset: 0x000B85D4
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x000BA410 File Offset: 0x000B8610
		public unsafe virtual ActionLogModes LogMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x000BA450 File Offset: 0x000B8650
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 135162, RefRangeEnd = 135196, XrefRangeStart = 135161, XrefRangeEnd = 135162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawIntrigue(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawIntrigue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x000BA49C File Offset: 0x000B869C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135196, XrefRangeEnd = 135204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x000BA510 File Offset: 0x000B8710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135204, XrefRangeEnd = 135210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrawIntrigue.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x0000AC62 File Offset: 0x00008E62
		public DrawIntrigue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x000BA55C File Offset: 0x000B875C
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x0000AC6B File Offset: 0x00008E6B
		public unsafe ActionLogModes _LogMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue.NativeFieldInfoPtr__LogMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue.NativeFieldInfoPtr__LogMode_k__BackingField)) = value;
			}
		}

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeFieldInfoPtr__LogMode_k__BackingField;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormIntriguePlayable_0;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x02000678 RID: 1656
		[ObfuscatedName("worm.canis.actions.DrawIntrigue+<MakeAnalyticsData>d__5")]
		public sealed class _MakeAnalyticsData_d__5 : Object
		{
			// Token: 0x06005515 RID: 21781 RVA: 0x001B842C File Offset: 0x001B662C
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__5()
			{
				Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawIntrigue>.NativeClassPtr, "<MakeAnalyticsData>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr);
				DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "<>1__state");
				DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "<>2__current");
				DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "<>l__initialThreadId");
				DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_cardToDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "cardToDraw");
				DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__cardToDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "<>3__cardToDraw");
				DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "wormMatch");
				DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "<>3__wormMatch");
				DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "player");
				DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, "<>3__player");
				DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100667752);
				DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100667753);
				DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100667754);
				DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100667755);
				DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100667756);
				DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100667757);
				DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100667758);
				DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr, 100667759);
			}

			// Token: 0x06005516 RID: 21782 RVA: 0x001B85AC File Offset: 0x001B67AC
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawIntrigue._MakeAnalyticsData_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005517 RID: 21783 RVA: 0x001B85F4 File Offset: 0x001B67F4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005518 RID: 21784 RVA: 0x001B8628 File Offset: 0x001B6828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134938, XrefRangeEnd = 134954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001561 RID: 5473
			// (get) Token: 0x06005519 RID: 21785 RVA: 0x001B8664 File Offset: 0x001B6864
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x0600551A RID: 21786 RVA: 0x001B869C File Offset: 0x001B689C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134954, XrefRangeEnd = 134959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001562 RID: 5474
			// (get) Token: 0x0600551B RID: 21787 RVA: 0x001B86D0 File Offset: 0x001B68D0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134959, XrefRangeEnd = 134962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600551C RID: 21788 RVA: 0x001B8710 File Offset: 0x001B6910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134962, XrefRangeEnd = 134972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x0600551D RID: 21789 RVA: 0x001B8750 File Offset: 0x001B6950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._MakeAnalyticsData_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600551E RID: 21790 RVA: 0x0001E37B File Offset: 0x0001C57B
			public _MakeAnalyticsData_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001558 RID: 5464
			// (get) Token: 0x0600551F RID: 21791 RVA: 0x001B8790 File Offset: 0x001B6990
			// (set) Token: 0x06005520 RID: 21792 RVA: 0x0001E384 File Offset: 0x0001C584
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001559 RID: 5465
			// (get) Token: 0x06005521 RID: 21793 RVA: 0x001B87B8 File Offset: 0x001B69B8
			// (set) Token: 0x06005522 RID: 21794 RVA: 0x0001E39F File Offset: 0x0001C59F
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700155A RID: 5466
			// (get) Token: 0x06005523 RID: 21795 RVA: 0x001B87E8 File Offset: 0x001B69E8
			// (set) Token: 0x06005524 RID: 21796 RVA: 0x0001E3CD File Offset: 0x0001C5CD
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700155B RID: 5467
			// (get) Token: 0x06005525 RID: 21797 RVA: 0x001B8810 File Offset: 0x001B6A10
			// (set) Token: 0x06005526 RID: 21798 RVA: 0x0001E3E8 File Offset: 0x0001C5E8
			public unsafe WormIntriguePlayable cardToDraw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_cardToDraw);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntriguePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_cardToDraw), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700155C RID: 5468
			// (get) Token: 0x06005527 RID: 21799 RVA: 0x001B8840 File Offset: 0x001B6A40
			// (set) Token: 0x06005528 RID: 21800 RVA: 0x0001E407 File Offset: 0x0001C607
			public unsafe WormIntriguePlayable __3__cardToDraw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__cardToDraw);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntriguePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__cardToDraw), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700155D RID: 5469
			// (get) Token: 0x06005529 RID: 21801 RVA: 0x001B8870 File Offset: 0x001B6A70
			// (set) Token: 0x0600552A RID: 21802 RVA: 0x0001E426 File Offset: 0x0001C626
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700155E RID: 5470
			// (get) Token: 0x0600552B RID: 21803 RVA: 0x001B88A0 File Offset: 0x001B6AA0
			// (set) Token: 0x0600552C RID: 21804 RVA: 0x0001E445 File Offset: 0x0001C645
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700155F RID: 5471
			// (get) Token: 0x0600552D RID: 21805 RVA: 0x001B88D0 File Offset: 0x001B6AD0
			// (set) Token: 0x0600552E RID: 21806 RVA: 0x0001E464 File Offset: 0x0001C664
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001560 RID: 5472
			// (get) Token: 0x0600552F RID: 21807 RVA: 0x001B8900 File Offset: 0x001B6B00
			// (set) Token: 0x06005530 RID: 21808 RVA: 0x0001E483 File Offset: 0x0001C683
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._MakeAnalyticsData_d__5.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400379A RID: 14234
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400379B RID: 14235
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400379C RID: 14236
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400379D RID: 14237
			private static readonly IntPtr NativeFieldInfoPtr_cardToDraw;

			// Token: 0x0400379E RID: 14238
			private static readonly IntPtr NativeFieldInfoPtr___3__cardToDraw;

			// Token: 0x0400379F RID: 14239
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x040037A0 RID: 14240
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x040037A1 RID: 14241
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040037A2 RID: 14242
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x040037A3 RID: 14243
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040037A4 RID: 14244
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040037A5 RID: 14245
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040037A6 RID: 14246
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x040037A7 RID: 14247
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040037A8 RID: 14248
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040037A9 RID: 14249
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x040037AA RID: 14250
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000679 RID: 1657
		[ObfuscatedName("worm.canis.actions.DrawIntrigue+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x06005531 RID: 21809 RVA: 0x001B8930 File Offset: 0x001B6B30
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawIntrigue>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr);
				DrawIntrigue._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, "<>1__state");
				DrawIntrigue._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, "<>2__current");
				DrawIntrigue._execute_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, "<>l__initialThreadId");
				DrawIntrigue._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, "<>4__this");
				DrawIntrigue._execute_d__6.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, "<player>5__2");
				DrawIntrigue._execute_d__6.NativeFieldInfoPtr__wm_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, "<wm>5__3");
				DrawIntrigue._execute_d__6.NativeFieldInfoPtr__wormPlaymat_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, "<wormPlaymat>5__4");
				DrawIntrigue._execute_d__6.NativeFieldInfoPtr__canDrawIntrigue_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, "<canDrawIntrigue>5__5");
				DrawIntrigue._execute_d__6.NativeFieldInfoPtr__cardToDraw_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, "<cardToDraw>5__6");
				DrawIntrigue._execute_d__6.NativeFieldInfoPtr__sequence_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, "<sequence>5__7");
				DrawIntrigue._execute_d__6.NativeFieldInfoPtr___7__wrap7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, "<>7__wrap7");
				DrawIntrigue._execute_d__6.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, "<>7__wrap8");
				DrawIntrigue._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, 100667760);
				DrawIntrigue._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, 100667761);
				DrawIntrigue._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, 100667762);
				DrawIntrigue._execute_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, 100667763);
				DrawIntrigue._execute_d__6.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, 100667764);
				DrawIntrigue._execute_d__6.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, 100667765);
				DrawIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, 100667766);
				DrawIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, 100667767);
				DrawIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, 100667768);
				DrawIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, 100667769);
				DrawIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr, 100667770);
			}

			// Token: 0x06005532 RID: 21810 RVA: 0x001B8B28 File Offset: 0x001B6D28
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawIntrigue._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005533 RID: 21811 RVA: 0x001B8B70 File Offset: 0x001B6D70
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005534 RID: 21812 RVA: 0x001B8BA4 File Offset: 0x001B6DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134972, XrefRangeEnd = 135144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005535 RID: 21813 RVA: 0x001B8BE0 File Offset: 0x001B6DE0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 135147, RefRangeEnd = 135148, XrefRangeStart = 135144, XrefRangeEnd = 135147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._execute_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005536 RID: 21814 RVA: 0x001B8C14 File Offset: 0x001B6E14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135148, XrefRangeEnd = 135151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._execute_d__6.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005537 RID: 21815 RVA: 0x001B8C48 File Offset: 0x001B6E48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135151, XrefRangeEnd = 135154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._execute_d__6.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700156F RID: 5487
			// (get) Token: 0x06005538 RID: 21816 RVA: 0x001B8C7C File Offset: 0x001B6E7C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005539 RID: 21817 RVA: 0x001B8CBC File Offset: 0x001B6EBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135154, XrefRangeEnd = 135159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001570 RID: 5488
			// (get) Token: 0x0600553A RID: 21818 RVA: 0x001B8CF0 File Offset: 0x001B6EF0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600553B RID: 21819 RVA: 0x001B8D30 File Offset: 0x001B6F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135159, XrefRangeEnd = 135161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600553C RID: 21820 RVA: 0x001B8D70 File Offset: 0x001B6F70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawIntrigue._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600553D RID: 21821 RVA: 0x0001E4A2 File Offset: 0x0001C6A2
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001563 RID: 5475
			// (get) Token: 0x0600553E RID: 21822 RVA: 0x001B8DB0 File Offset: 0x001B6FB0
			// (set) Token: 0x0600553F RID: 21823 RVA: 0x0001E4AB File Offset: 0x0001C6AB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001564 RID: 5476
			// (get) Token: 0x06005540 RID: 21824 RVA: 0x001B8DD8 File Offset: 0x001B6FD8
			// (set) Token: 0x06005541 RID: 21825 RVA: 0x0001E4C6 File Offset: 0x0001C6C6
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001565 RID: 5477
			// (get) Token: 0x06005542 RID: 21826 RVA: 0x001B8E08 File Offset: 0x001B7008
			// (set) Token: 0x06005543 RID: 21827 RVA: 0x0001E4E5 File Offset: 0x0001C6E5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001566 RID: 5478
			// (get) Token: 0x06005544 RID: 21828 RVA: 0x001B8E30 File Offset: 0x001B7030
			// (set) Token: 0x06005545 RID: 21829 RVA: 0x0001E500 File Offset: 0x0001C700
			public unsafe DrawIntrigue __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawIntrigue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001567 RID: 5479
			// (get) Token: 0x06005546 RID: 21830 RVA: 0x001B8E60 File Offset: 0x001B7060
			// (set) Token: 0x06005547 RID: 21831 RVA: 0x0001E51F File Offset: 0x0001C71F
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001568 RID: 5480
			// (get) Token: 0x06005548 RID: 21832 RVA: 0x001B8E90 File Offset: 0x001B7090
			// (set) Token: 0x06005549 RID: 21833 RVA: 0x0001E53E File Offset: 0x0001C73E
			public unsafe WormMatch _wm_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr__wm_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr__wm_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001569 RID: 5481
			// (get) Token: 0x0600554A RID: 21834 RVA: 0x001B8EC0 File Offset: 0x001B70C0
			// (set) Token: 0x0600554B RID: 21835 RVA: 0x0001E55D File Offset: 0x0001C75D
			public unsafe WormPlaymat _wormPlaymat_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr__wormPlaymat_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlaymat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr__wormPlaymat_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700156A RID: 5482
			// (get) Token: 0x0600554C RID: 21836 RVA: 0x001B8EF0 File Offset: 0x001B70F0
			// (set) Token: 0x0600554D RID: 21837 RVA: 0x0001E57C File Offset: 0x0001C77C
			public unsafe bool _canDrawIntrigue_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr__canDrawIntrigue_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr__canDrawIntrigue_5__5)) = value;
				}
			}

			// Token: 0x1700156B RID: 5483
			// (get) Token: 0x0600554E RID: 21838 RVA: 0x001B8F18 File Offset: 0x001B7118
			// (set) Token: 0x0600554F RID: 21839 RVA: 0x0001E597 File Offset: 0x0001C797
			public unsafe WormIntriguePlayable _cardToDraw_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr__cardToDraw_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntriguePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr__cardToDraw_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700156C RID: 5484
			// (get) Token: 0x06005550 RID: 21840 RVA: 0x001B8F48 File Offset: 0x001B7148
			// (set) Token: 0x06005551 RID: 21841 RVA: 0x0001E5B6 File Offset: 0x0001C7B6
			public unsafe SequenceHelper _sequence_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr__sequence_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr__sequence_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700156D RID: 5485
			// (get) Token: 0x06005552 RID: 21842 RVA: 0x001B8F78 File Offset: 0x001B7178
			// (set) Token: 0x06005553 RID: 21843 RVA: 0x0001E5D5 File Offset: 0x0001C7D5
			public List<Entity>.Enumerator __7__wrap7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr___7__wrap7);
					return new List<Entity>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr___7__wrap7), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700156E RID: 5486
			// (get) Token: 0x06005554 RID: 21844 RVA: 0x001B8FA8 File Offset: 0x001B71A8
			// (set) Token: 0x06005555 RID: 21845 RVA: 0x0001E603 File Offset: 0x0001C803
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr___7__wrap8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawIntrigue._execute_d__6.NativeFieldInfoPtr___7__wrap8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040037AB RID: 14251
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040037AC RID: 14252
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040037AD RID: 14253
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040037AE RID: 14254
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040037AF RID: 14255
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040037B0 RID: 14256
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__3;

			// Token: 0x040037B1 RID: 14257
			private static readonly IntPtr NativeFieldInfoPtr__wormPlaymat_5__4;

			// Token: 0x040037B2 RID: 14258
			private static readonly IntPtr NativeFieldInfoPtr__canDrawIntrigue_5__5;

			// Token: 0x040037B3 RID: 14259
			private static readonly IntPtr NativeFieldInfoPtr__cardToDraw_5__6;

			// Token: 0x040037B4 RID: 14260
			private static readonly IntPtr NativeFieldInfoPtr__sequence_5__7;

			// Token: 0x040037B5 RID: 14261
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap7;

			// Token: 0x040037B6 RID: 14262
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x040037B7 RID: 14263
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040037B8 RID: 14264
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040037B9 RID: 14265
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040037BA RID: 14266
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040037BB RID: 14267
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040037BC RID: 14268
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x040037BD RID: 14269
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040037BE RID: 14270
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040037BF RID: 14271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040037C0 RID: 14272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040037C1 RID: 14273
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
