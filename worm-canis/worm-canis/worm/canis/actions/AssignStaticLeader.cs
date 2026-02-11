using System;
using Canis;
using Canis.actions;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000228 RID: 552
	public class AssignStaticLeader : AssignLeader
	{
		// Token: 0x06001856 RID: 6230 RVA: 0x000B7774 File Offset: 0x000B5974
		// Note: this type is marked as 'beforefieldinit'.
		static AssignStaticLeader()
		{
			Il2CppClassPointerStore<AssignStaticLeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "AssignStaticLeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignStaticLeader>.NativeClassPtr);
			AssignStaticLeader.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_ArchetypeID_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignStaticLeader>.NativeClassPtr, 100667454);
			AssignStaticLeader.NativeMethodInfoPtr__ctor_Public_Void_SerializedAssignStaticLeader_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignStaticLeader>.NativeClassPtr, 100667455);
			AssignStaticLeader.NativeMethodInfoPtr_get_Options_Protected_Virtual_get_IReadOnlyList_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignStaticLeader>.NativeClassPtr, 100667456);
			AssignStaticLeader.NativeMethodInfoPtr_get_WithTargeting_Public_Virtual_get_TargetPicker_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignStaticLeader>.NativeClassPtr, 100667457);
			AssignStaticLeader.NativeMethodInfoPtr_MakeAnalyticsData_Protected_Virtual_IEnumerable_1_ValueTuple_2_String_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignStaticLeader>.NativeClassPtr, 100667458);
			AssignStaticLeader.NativeMethodInfoPtr_MakeSerializedAssignLeader_Protected_Virtual_SerializedAssignLeader_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignStaticLeader>.NativeClassPtr, 100667459);
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x000B781C File Offset: 0x000B5A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131859, XrefRangeEnd = 131878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssignStaticLeader(WormPlayer player, ArchetypeID option, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignStaticLeader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(option);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignStaticLeader.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_ArchetypeID_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x000B788C File Offset: 0x000B5A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131878, XrefRangeEnd = 131885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssignStaticLeader(SerializedAssignStaticLeader serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignStaticLeader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignStaticLeader.NativeMethodInfoPtr__ctor_Public_Void_SerializedAssignStaticLeader_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001859 RID: 6233 RVA: 0x000B78EC File Offset: 0x000B5AEC
		public unsafe override IReadOnlyList<ArchetypeID> Options
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignStaticLeader.NativeMethodInfoPtr_get_Options_Protected_Virtual_get_IReadOnlyList_1_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ArchetypeID>>(intPtr3) : null;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x000B7938 File Offset: 0x000B5B38
		public unsafe override TargetPicker<int> WithTargeting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131899, XrefRangeEnd = 131915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignStaticLeader.NativeMethodInfoPtr_get_WithTargeting_Public_Virtual_get_TargetPicker_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker<int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x000B7984 File Offset: 0x000B5B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131915, XrefRangeEnd = 131920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignStaticLeader.NativeMethodInfoPtr_MakeAnalyticsData_Protected_Virtual_IEnumerable_1_ValueTuple_2_String_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x000B79DC File Offset: 0x000B5BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131920, XrefRangeEnd = 131928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAssignLeader MakeSerializedAssignLeader(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignStaticLeader.NativeMethodInfoPtr_MakeSerializedAssignLeader_Protected_Virtual_SerializedAssignLeader_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAssignLeader>(intPtr3) : null;
			}
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0000A8FC File Offset: 0x00008AFC
		public AssignStaticLeader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_ArchetypeID_WormMatch_0;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedAssignStaticLeader_WormMatch_0;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Protected_Virtual_get_IReadOnlyList_1_ArchetypeID_0;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeMethodInfoPtr_get_WithTargeting_Public_Virtual_get_TargetPicker_1_Int32_0;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Protected_Virtual_IEnumerable_1_ValueTuple_2_String_Object_Int32_0;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAssignLeader_Protected_Virtual_SerializedAssignLeader_Match_0;

		// Token: 0x02000654 RID: 1620
		[ObfuscatedName("worm.canis.actions.AssignStaticLeader+<MakeAnalyticsData>d__6")]
		public sealed class _MakeAnalyticsData_d__6 : Object
		{
			// Token: 0x0600528C RID: 21132 RVA: 0x001B0C60 File Offset: 0x001AEE60
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__6()
			{
				Il2CppClassPointerStore<AssignStaticLeader._MakeAnalyticsData_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssignStaticLeader>.NativeClassPtr, "<MakeAnalyticsData>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignStaticLeader._MakeAnalyticsData_d__6>.NativeClassPtr);
				AssignStaticLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignStaticLeader._MakeAnalyticsData_d__6>.NativeClassPtr, "<>1__state");
				AssignStaticLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignStaticLeader._MakeAnalyticsData_d__6>.NativeClassPtr, "<>2__current");
				AssignStaticLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignStaticLeader._MakeAnalyticsData_d__6>.NativeClassPtr, "<>l__initialThreadId");
				AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignStaticLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667460);
				AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignStaticLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667461);
				AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignStaticLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667462);
				AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignStaticLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667463);
				AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignStaticLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667464);
				AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignStaticLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667465);
				AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignStaticLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667466);
				AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignStaticLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667467);
			}

			// Token: 0x0600528D RID: 21133 RVA: 0x001B0D68 File Offset: 0x001AEF68
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignStaticLeader._MakeAnalyticsData_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600528E RID: 21134 RVA: 0x001B0DB0 File Offset: 0x001AEFB0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600528F RID: 21135 RVA: 0x001B0DE4 File Offset: 0x001AEFE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131841, XrefRangeEnd = 131849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001479 RID: 5241
			// (get) Token: 0x06005290 RID: 21136 RVA: 0x001B0E20 File Offset: 0x001AF020
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x06005291 RID: 21137 RVA: 0x001B0E58 File Offset: 0x001AF058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131849, XrefRangeEnd = 131854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700147A RID: 5242
			// (get) Token: 0x06005292 RID: 21138 RVA: 0x001B0E8C File Offset: 0x001AF08C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131854, XrefRangeEnd = 131857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005293 RID: 21139 RVA: 0x001B0ECC File Offset: 0x001AF0CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131857, XrefRangeEnd = 131859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x06005294 RID: 21140 RVA: 0x001B0F0C File Offset: 0x001AF10C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignStaticLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005295 RID: 21141 RVA: 0x0001CCE1 File Offset: 0x0001AEE1
			public _MakeAnalyticsData_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001476 RID: 5238
			// (get) Token: 0x06005296 RID: 21142 RVA: 0x001B0F4C File Offset: 0x001AF14C
			// (set) Token: 0x06005297 RID: 21143 RVA: 0x0001CCEA File Offset: 0x0001AEEA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignStaticLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignStaticLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001477 RID: 5239
			// (get) Token: 0x06005298 RID: 21144 RVA: 0x001B0F74 File Offset: 0x001AF174
			// (set) Token: 0x06005299 RID: 21145 RVA: 0x0001CD05 File Offset: 0x0001AF05
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignStaticLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignStaticLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001478 RID: 5240
			// (get) Token: 0x0600529A RID: 21146 RVA: 0x001B0FA4 File Offset: 0x001AF1A4
			// (set) Token: 0x0600529B RID: 21147 RVA: 0x0001CD33 File Offset: 0x0001AF33
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignStaticLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignStaticLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04003613 RID: 13843
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003614 RID: 13844
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003615 RID: 13845
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003616 RID: 13846
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003617 RID: 13847
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003618 RID: 13848
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003619 RID: 13849
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x0400361A RID: 13850
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400361B RID: 13851
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400361C RID: 13852
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x0400361D RID: 13853
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
