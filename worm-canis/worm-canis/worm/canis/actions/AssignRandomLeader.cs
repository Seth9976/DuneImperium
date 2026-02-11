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
	// Token: 0x0200022C RID: 556
	public class AssignRandomLeader : AssignLeader
	{
		// Token: 0x0600187A RID: 6266 RVA: 0x000B8180 File Offset: 0x000B6380
		// Note: this type is marked as 'beforefieldinit'.
		static AssignRandomLeader()
		{
			Il2CppClassPointerStore<AssignRandomLeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "AssignRandomLeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignRandomLeader>.NativeClassPtr);
			AssignRandomLeader.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_IEnumerable_1_ArchetypeID_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader>.NativeClassPtr, 100667494);
			AssignRandomLeader.NativeMethodInfoPtr__ctor_Public_Void_SerializedAssignRandomLeader_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader>.NativeClassPtr, 100667495);
			AssignRandomLeader.NativeMethodInfoPtr_get_Options_Protected_Virtual_get_IReadOnlyList_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader>.NativeClassPtr, 100667496);
			AssignRandomLeader.NativeMethodInfoPtr_get_WithTargeting_Public_Virtual_get_TargetPicker_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader>.NativeClassPtr, 100667497);
			AssignRandomLeader.NativeMethodInfoPtr_MakeAnalyticsData_Protected_Virtual_IEnumerable_1_ValueTuple_2_String_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader>.NativeClassPtr, 100667498);
			AssignRandomLeader.NativeMethodInfoPtr_MakeSerializedAssignLeader_Protected_Virtual_SerializedAssignLeader_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader>.NativeClassPtr, 100667499);
			AssignRandomLeader.NativeMethodInfoPtr__get_Options_b__3_0_Private_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader>.NativeClassPtr, 100667500);
			AssignRandomLeader.NativeMethodInfoPtr__get_WithTargeting_b__5_0_Private_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader>.NativeClassPtr, 100667501);
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x000B8250 File Offset: 0x000B6450
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131800, RefRangeEnd = 131803, XrefRangeStart = 131800, XrefRangeEnd = 131803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssignRandomLeader(WormPlayer player, IEnumerable<ArchetypeID> options, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignRandomLeader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_IEnumerable_1_ArchetypeID_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x000B82C0 File Offset: 0x000B64C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132183, XrefRangeEnd = 132184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssignRandomLeader(SerializedAssignRandomLeader serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignRandomLeader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader.NativeMethodInfoPtr__ctor_Public_Void_SerializedAssignRandomLeader_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x000B8320 File Offset: 0x000B6520
		public unsafe override IReadOnlyList<ArchetypeID> Options
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132184, XrefRangeEnd = 132196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignRandomLeader.NativeMethodInfoPtr_get_Options_Protected_Virtual_get_IReadOnlyList_1_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ArchetypeID>>(intPtr3) : null;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x000B836C File Offset: 0x000B656C
		public unsafe override TargetPicker<int> WithTargeting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132196, XrefRangeEnd = 132252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignRandomLeader.NativeMethodInfoPtr_get_WithTargeting_Public_Virtual_get_TargetPicker_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker<int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x000B83B8 File Offset: 0x000B65B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132252, XrefRangeEnd = 132257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignRandomLeader.NativeMethodInfoPtr_MakeAnalyticsData_Protected_Virtual_IEnumerable_1_ValueTuple_2_String_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x000B8410 File Offset: 0x000B6610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132257, XrefRangeEnd = 132265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAssignLeader MakeSerializedAssignLeader(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignRandomLeader.NativeMethodInfoPtr_MakeSerializedAssignLeader_Protected_Virtual_SerializedAssignLeader_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAssignLeader>(intPtr3) : null;
			}
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x000B846C File Offset: 0x000B666C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132265, XrefRangeEnd = 132281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_Options_b__3_0(ArchetypeID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader.NativeMethodInfoPtr__get_Options_b__3_0_Private_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x000B84BC File Offset: 0x000B66BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132281, XrefRangeEnd = 132284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_WithTargeting_b__5_0(ArchetypeID _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader.NativeMethodInfoPtr__get_WithTargeting_b__5_0_Private_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0000A99C File Offset: 0x00008B9C
		public AssignRandomLeader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_IEnumerable_1_ArchetypeID_WormMatch_0;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedAssignRandomLeader_WormMatch_0;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Protected_Virtual_get_IReadOnlyList_1_ArchetypeID_0;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeMethodInfoPtr_get_WithTargeting_Public_Virtual_get_TargetPicker_1_Int32_0;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Protected_Virtual_IEnumerable_1_ValueTuple_2_String_Object_Int32_0;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAssignLeader_Protected_Virtual_SerializedAssignLeader_Match_0;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeMethodInfoPtr__get_Options_b__3_0_Private_Boolean_ArchetypeID_0;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeMethodInfoPtr__get_WithTargeting_b__5_0_Private_Boolean_ArchetypeID_0;

		// Token: 0x02000658 RID: 1624
		[ObfuscatedName("worm.canis.actions.AssignRandomLeader+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060052BA RID: 21178 RVA: 0x001B15C4 File Offset: 0x001AF7C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<AssignRandomLeader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssignRandomLeader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignRandomLeader.__c__DisplayClass3_0>.NativeClassPtr);
				AssignRandomLeader.__c__DisplayClass3_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignRandomLeader.__c__DisplayClass3_0>.NativeClassPtr, "id");
				AssignRandomLeader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader.__c__DisplayClass3_0>.NativeClassPtr, 100667502);
				AssignRandomLeader.__c__DisplayClass3_0.NativeMethodInfoPtr__get_Options_b__1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader.__c__DisplayClass3_0>.NativeClassPtr, 100667503);
			}

			// Token: 0x060052BB RID: 21179 RVA: 0x001B162C File Offset: 0x001AF82C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignRandomLeader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052BC RID: 21180 RVA: 0x001B1668 File Offset: 0x001AF868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132154, XrefRangeEnd = 132161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_Options_b__1(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader.__c__DisplayClass3_0.NativeMethodInfoPtr__get_Options_b__1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060052BD RID: 21181 RVA: 0x0001CE2A File Offset: 0x0001B02A
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001483 RID: 5251
			// (get) Token: 0x060052BE RID: 21182 RVA: 0x001B16B8 File Offset: 0x001AF8B8
			// (set) Token: 0x060052BF RID: 21183 RVA: 0x0001CE33 File Offset: 0x0001B033
			public unsafe ArchetypeID id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignRandomLeader.__c__DisplayClass3_0.NativeFieldInfoPtr_id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignRandomLeader.__c__DisplayClass3_0.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003630 RID: 13872
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04003631 RID: 13873
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003632 RID: 13874
			private static readonly IntPtr NativeMethodInfoPtr__get_Options_b__1_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000659 RID: 1625
		[ObfuscatedName("worm.canis.actions.AssignRandomLeader+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x060052C0 RID: 21184 RVA: 0x001B16E8 File Offset: 0x001AF8E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<AssignRandomLeader.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssignRandomLeader>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignRandomLeader.__c__DisplayClass5_0>.NativeClassPtr);
				AssignRandomLeader.__c__DisplayClass5_0.NativeFieldInfoPtr_leaderArchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignRandomLeader.__c__DisplayClass5_0>.NativeClassPtr, "leaderArchID");
				AssignRandomLeader.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader.__c__DisplayClass5_0>.NativeClassPtr, 100667504);
				AssignRandomLeader.__c__DisplayClass5_0.NativeMethodInfoPtr__get_WithTargeting_b__1_Internal_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader.__c__DisplayClass5_0>.NativeClassPtr, 100667505);
			}

			// Token: 0x060052C1 RID: 21185 RVA: 0x001B1750 File Offset: 0x001AF950
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignRandomLeader.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052C2 RID: 21186 RVA: 0x001B178C File Offset: 0x001AF98C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132161, XrefRangeEnd = 132165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_WithTargeting_b__1(ArchetypeID _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader.__c__DisplayClass5_0.NativeMethodInfoPtr__get_WithTargeting_b__1_Internal_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060052C3 RID: 21187 RVA: 0x0001CE52 File Offset: 0x0001B052
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001484 RID: 5252
			// (get) Token: 0x060052C4 RID: 21188 RVA: 0x001B17DC File Offset: 0x001AF9DC
			// (set) Token: 0x060052C5 RID: 21189 RVA: 0x0001CE5B File Offset: 0x0001B05B
			public unsafe ArchetypeID leaderArchID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignRandomLeader.__c__DisplayClass5_0.NativeFieldInfoPtr_leaderArchID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignRandomLeader.__c__DisplayClass5_0.NativeFieldInfoPtr_leaderArchID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003633 RID: 13875
			private static readonly IntPtr NativeFieldInfoPtr_leaderArchID;

			// Token: 0x04003634 RID: 13876
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003635 RID: 13877
			private static readonly IntPtr NativeMethodInfoPtr__get_WithTargeting_b__1_Internal_Boolean_ArchetypeID_0;
		}

		// Token: 0x0200065A RID: 1626
		[ObfuscatedName("worm.canis.actions.AssignRandomLeader+<MakeAnalyticsData>d__6")]
		public sealed class _MakeAnalyticsData_d__6 : Object
		{
			// Token: 0x060052C6 RID: 21190 RVA: 0x001B180C File Offset: 0x001AFA0C
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__6()
			{
				Il2CppClassPointerStore<AssignRandomLeader._MakeAnalyticsData_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssignRandomLeader>.NativeClassPtr, "<MakeAnalyticsData>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignRandomLeader._MakeAnalyticsData_d__6>.NativeClassPtr);
				AssignRandomLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignRandomLeader._MakeAnalyticsData_d__6>.NativeClassPtr, "<>1__state");
				AssignRandomLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignRandomLeader._MakeAnalyticsData_d__6>.NativeClassPtr, "<>2__current");
				AssignRandomLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignRandomLeader._MakeAnalyticsData_d__6>.NativeClassPtr, "<>l__initialThreadId");
				AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667506);
				AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667507);
				AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667508);
				AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667509);
				AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667510);
				AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667511);
				AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667512);
				AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignRandomLeader._MakeAnalyticsData_d__6>.NativeClassPtr, 100667513);
			}

			// Token: 0x060052C7 RID: 21191 RVA: 0x001B1914 File Offset: 0x001AFB14
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignRandomLeader._MakeAnalyticsData_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052C8 RID: 21192 RVA: 0x001B195C File Offset: 0x001AFB5C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052C9 RID: 21193 RVA: 0x001B1990 File Offset: 0x001AFB90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132165, XrefRangeEnd = 132173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001488 RID: 5256
			// (get) Token: 0x060052CA RID: 21194 RVA: 0x001B19CC File Offset: 0x001AFBCC
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x060052CB RID: 21195 RVA: 0x001B1A04 File Offset: 0x001AFC04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132173, XrefRangeEnd = 132178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001489 RID: 5257
			// (get) Token: 0x060052CC RID: 21196 RVA: 0x001B1A38 File Offset: 0x001AFC38
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132178, XrefRangeEnd = 132181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052CD RID: 21197 RVA: 0x001B1A78 File Offset: 0x001AFC78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132181, XrefRangeEnd = 132183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x060052CE RID: 21198 RVA: 0x001B1AB8 File Offset: 0x001AFCB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignRandomLeader._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060052CF RID: 21199 RVA: 0x0001CE7A File Offset: 0x0001B07A
			public _MakeAnalyticsData_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001485 RID: 5253
			// (get) Token: 0x060052D0 RID: 21200 RVA: 0x001B1AF8 File Offset: 0x001AFCF8
			// (set) Token: 0x060052D1 RID: 21201 RVA: 0x0001CE83 File Offset: 0x0001B083
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignRandomLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignRandomLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001486 RID: 5254
			// (get) Token: 0x060052D2 RID: 21202 RVA: 0x001B1B20 File Offset: 0x001AFD20
			// (set) Token: 0x060052D3 RID: 21203 RVA: 0x0001CE9E File Offset: 0x0001B09E
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignRandomLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignRandomLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001487 RID: 5255
			// (get) Token: 0x060052D4 RID: 21204 RVA: 0x001B1B50 File Offset: 0x001AFD50
			// (set) Token: 0x060052D5 RID: 21205 RVA: 0x0001CECC File Offset: 0x0001B0CC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignRandomLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignRandomLeader._MakeAnalyticsData_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04003636 RID: 13878
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003637 RID: 13879
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003638 RID: 13880
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003639 RID: 13881
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400363A RID: 13882
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400363B RID: 13883
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400363C RID: 13884
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x0400363D RID: 13885
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400363E RID: 13886
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400363F RID: 13887
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x04003640 RID: 13888
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
