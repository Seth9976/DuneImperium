using System;
using Canis;
using Canis.actions;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.archetypes;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x0200022A RID: 554
	public class AssignChosenLeader : AssignLeader
	{
		// Token: 0x06001864 RID: 6244 RVA: 0x000B7B6C File Offset: 0x000B5D6C
		// Note: this type is marked as 'beforefieldinit'.
		static AssignChosenLeader()
		{
			Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "AssignChosenLeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr);
			AssignChosenLeader.NativeFieldInfoPtr_assignmentMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr, "assignmentMethod");
			AssignChosenLeader.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_String_IEnumerable_1_ArchetypeID_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr, 100667470);
			AssignChosenLeader.NativeMethodInfoPtr__ctor_Public_Void_SerializedAssignChosenLeader_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr, 100667471);
			AssignChosenLeader.NativeMethodInfoPtr_get_Options_Protected_Virtual_get_IReadOnlyList_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr, 100667472);
			AssignChosenLeader.NativeMethodInfoPtr_get_WithTargeting_Public_Virtual_get_TargetPicker_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr, 100667473);
			AssignChosenLeader.NativeMethodInfoPtr_MakeAnalyticsData_Protected_Virtual_IEnumerable_1_ValueTuple_2_String_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr, 100667474);
			AssignChosenLeader.NativeMethodInfoPtr_MakeSerializedAssignLeader_Protected_Virtual_SerializedAssignLeader_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr, 100667475);
			AssignChosenLeader.NativeMethodInfoPtr__get_WithTargeting_b__6_0_Private_IEnumerable_1_WormArchetype_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr, 100667476);
			AssignChosenLeader.NativeMethodInfoPtr__get_WithTargeting_b__6_1_Private_SerializableAttributes_WormArchetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr, 100667477);
			AssignChosenLeader.NativeMethodInfoPtr__MakeAnalyticsData_b__7_0_Private_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr, 100667478);
			AssignChosenLeader.NativeMethodInfoPtr__MakeAnalyticsData_b__7_1_Private_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr, 100667479);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x000B7C78 File Offset: 0x000B5E78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131995, RefRangeEnd = 131997, XrefRangeStart = 131975, XrefRangeEnd = 131995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssignChosenLeader(WormPlayer player, string assignmentMethod, IEnumerable<ArchetypeID> options, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assignmentMethod);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_String_IEnumerable_1_ArchetypeID_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x000B7CFC File Offset: 0x000B5EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131997, XrefRangeEnd = 132006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssignChosenLeader(SerializedAssignChosenLeader serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader.NativeMethodInfoPtr__ctor_Public_Void_SerializedAssignChosenLeader_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x000B7D5C File Offset: 0x000B5F5C
		public unsafe override IReadOnlyList<ArchetypeID> Options
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132006, XrefRangeEnd = 132009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignChosenLeader.NativeMethodInfoPtr_get_Options_Protected_Virtual_get_IReadOnlyList_1_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ArchetypeID>>(intPtr3) : null;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x000B7DA8 File Offset: 0x000B5FA8
		public unsafe override TargetPicker<int> WithTargeting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132009, XrefRangeEnd = 132062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignChosenLeader.NativeMethodInfoPtr_get_WithTargeting_Public_Virtual_get_TargetPicker_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x000B7DF4 File Offset: 0x000B5FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132062, XrefRangeEnd = 132068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignChosenLeader.NativeMethodInfoPtr_MakeAnalyticsData_Protected_Virtual_IEnumerable_1_ValueTuple_2_String_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x000B7E4C File Offset: 0x000B604C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132068, XrefRangeEnd = 132077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAssignLeader MakeSerializedAssignLeader(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignChosenLeader.NativeMethodInfoPtr_MakeSerializedAssignLeader_Protected_Virtual_SerializedAssignLeader_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAssignLeader>(intPtr3) : null;
			}
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x000B7EA8 File Offset: 0x000B60A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132077, XrefRangeEnd = 132091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<WormArchetype> _get_WithTargeting_b__6_0(ArchetypeID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader.NativeMethodInfoPtr__get_WithTargeting_b__6_0_Private_IEnumerable_1_WormArchetype_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormArchetype>>(intPtr3) : null;
			}
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x000B7EF8 File Offset: 0x000B60F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132091, XrefRangeEnd = 132123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableAttributes _get_WithTargeting_b__6_1(WormArchetype wa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader.NativeMethodInfoPtr__get_WithTargeting_b__6_1_Private_SerializableAttributes_WormArchetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x000B7F48 File Offset: 0x000B6148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132123, XrefRangeEnd = 132147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _MakeAnalyticsData_b__7_0(ArchetypeID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader.NativeMethodInfoPtr__MakeAnalyticsData_b__7_0_Private_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x000B7F98 File Offset: 0x000B6198
		[CallerCount(0)]
		public unsafe bool _MakeAnalyticsData_b__7_1(WormPlayer p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader.NativeMethodInfoPtr__MakeAnalyticsData_b__7_1_Private_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0000A92D File Offset: 0x00008B2D
		public AssignChosenLeader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x000B7FE8 File Offset: 0x000B61E8
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x0000A936 File Offset: 0x00008B36
		public unsafe string assignmentMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignChosenLeader.NativeFieldInfoPtr_assignmentMethod);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignChosenLeader.NativeFieldInfoPtr_assignmentMethod), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeFieldInfoPtr_assignmentMethod;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_String_IEnumerable_1_ArchetypeID_WormMatch_0;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedAssignChosenLeader_WormMatch_0;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Protected_Virtual_get_IReadOnlyList_1_ArchetypeID_0;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeMethodInfoPtr_get_WithTargeting_Public_Virtual_get_TargetPicker_1_Int32_0;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Protected_Virtual_IEnumerable_1_ValueTuple_2_String_Object_Int32_0;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAssignLeader_Protected_Virtual_SerializedAssignLeader_Match_0;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeMethodInfoPtr__get_WithTargeting_b__6_0_Private_IEnumerable_1_WormArchetype_ArchetypeID_0;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeMethodInfoPtr__get_WithTargeting_b__6_1_Private_SerializableAttributes_WormArchetype_0;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeMethodInfoPtr__MakeAnalyticsData_b__7_0_Private_Boolean_ArchetypeID_0;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeMethodInfoPtr__MakeAnalyticsData_b__7_1_Private_Boolean_WormPlayer_0;

		// Token: 0x02000655 RID: 1621
		[ObfuscatedName("worm.canis.actions.AssignChosenLeader+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600529C RID: 21148 RVA: 0x001B0FCC File Offset: 0x001AF1CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<AssignChosenLeader.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignChosenLeader.__c__DisplayClass6_0>.NativeClassPtr);
				AssignChosenLeader.__c__DisplayClass6_0.NativeFieldInfoPtr_wa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignChosenLeader.__c__DisplayClass6_0>.NativeClassPtr, "wa");
				AssignChosenLeader.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader.__c__DisplayClass6_0>.NativeClassPtr, 100667480);
				AssignChosenLeader.__c__DisplayClass6_0.NativeMethodInfoPtr__get_WithTargeting_b__2_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader.__c__DisplayClass6_0>.NativeClassPtr, 100667481);
			}

			// Token: 0x0600529D RID: 21149 RVA: 0x001B1034 File Offset: 0x001AF234
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignChosenLeader.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600529E RID: 21150 RVA: 0x001B1070 File Offset: 0x001AF270
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131940, XrefRangeEnd = 131947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_WithTargeting_b__2(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader.__c__DisplayClass6_0.NativeMethodInfoPtr__get_WithTargeting_b__2_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600529F RID: 21151 RVA: 0x0001CD4E File Offset: 0x0001AF4E
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700147B RID: 5243
			// (get) Token: 0x060052A0 RID: 21152 RVA: 0x001B10C0 File Offset: 0x001AF2C0
			// (set) Token: 0x060052A1 RID: 21153 RVA: 0x0001CD57 File Offset: 0x0001AF57
			public unsafe WormArchetype wa
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignChosenLeader.__c__DisplayClass6_0.NativeFieldInfoPtr_wa);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormArchetype>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignChosenLeader.__c__DisplayClass6_0.NativeFieldInfoPtr_wa), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400361E RID: 13854
			private static readonly IntPtr NativeFieldInfoPtr_wa;

			// Token: 0x0400361F RID: 13855
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003620 RID: 13856
			private static readonly IntPtr NativeMethodInfoPtr__get_WithTargeting_b__2_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000656 RID: 1622
		[ObfuscatedName("worm.canis.actions.AssignChosenLeader+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x060052A2 RID: 21154 RVA: 0x001B10F0 File Offset: 0x001AF2F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<AssignChosenLeader.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignChosenLeader.__c__DisplayClass7_0>.NativeClassPtr);
				AssignChosenLeader.__c__DisplayClass7_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignChosenLeader.__c__DisplayClass7_0>.NativeClassPtr, "id");
				AssignChosenLeader.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader.__c__DisplayClass7_0>.NativeClassPtr, 100667482);
				AssignChosenLeader.__c__DisplayClass7_0.NativeMethodInfoPtr__MakeAnalyticsData_b__2_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader.__c__DisplayClass7_0>.NativeClassPtr, 100667483);
			}

			// Token: 0x060052A3 RID: 21155 RVA: 0x001B1158 File Offset: 0x001AF358
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignChosenLeader.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052A4 RID: 21156 RVA: 0x001B1194 File Offset: 0x001AF394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131947, XrefRangeEnd = 131954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MakeAnalyticsData_b__2(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader.__c__DisplayClass7_0.NativeMethodInfoPtr__MakeAnalyticsData_b__2_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060052A5 RID: 21157 RVA: 0x0001CD76 File Offset: 0x0001AF76
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700147C RID: 5244
			// (get) Token: 0x060052A6 RID: 21158 RVA: 0x001B11E4 File Offset: 0x001AF3E4
			// (set) Token: 0x060052A7 RID: 21159 RVA: 0x0001CD7F File Offset: 0x0001AF7F
			public unsafe ArchetypeID id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignChosenLeader.__c__DisplayClass7_0.NativeFieldInfoPtr_id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignChosenLeader.__c__DisplayClass7_0.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003621 RID: 13857
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04003622 RID: 13858
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003623 RID: 13859
			private static readonly IntPtr NativeMethodInfoPtr__MakeAnalyticsData_b__2_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000657 RID: 1623
		[ObfuscatedName("worm.canis.actions.AssignChosenLeader+<MakeAnalyticsData>d__7")]
		public sealed class _MakeAnalyticsData_d__7 : Object
		{
			// Token: 0x060052A8 RID: 21160 RVA: 0x001B1214 File Offset: 0x001AF414
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__7()
			{
				Il2CppClassPointerStore<AssignChosenLeader._MakeAnalyticsData_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssignChosenLeader>.NativeClassPtr, "<MakeAnalyticsData>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignChosenLeader._MakeAnalyticsData_d__7>.NativeClassPtr);
				AssignChosenLeader._MakeAnalyticsData_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignChosenLeader._MakeAnalyticsData_d__7>.NativeClassPtr, "<>1__state");
				AssignChosenLeader._MakeAnalyticsData_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignChosenLeader._MakeAnalyticsData_d__7>.NativeClassPtr, "<>2__current");
				AssignChosenLeader._MakeAnalyticsData_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignChosenLeader._MakeAnalyticsData_d__7>.NativeClassPtr, "<>l__initialThreadId");
				AssignChosenLeader._MakeAnalyticsData_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignChosenLeader._MakeAnalyticsData_d__7>.NativeClassPtr, "<>4__this");
				AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader._MakeAnalyticsData_d__7>.NativeClassPtr, 100667484);
				AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader._MakeAnalyticsData_d__7>.NativeClassPtr, 100667485);
				AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader._MakeAnalyticsData_d__7>.NativeClassPtr, 100667486);
				AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader._MakeAnalyticsData_d__7>.NativeClassPtr, 100667487);
				AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader._MakeAnalyticsData_d__7>.NativeClassPtr, 100667488);
				AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader._MakeAnalyticsData_d__7>.NativeClassPtr, 100667489);
				AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader._MakeAnalyticsData_d__7>.NativeClassPtr, 100667490);
				AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignChosenLeader._MakeAnalyticsData_d__7>.NativeClassPtr, 100667491);
			}

			// Token: 0x060052A9 RID: 21161 RVA: 0x001B1330 File Offset: 0x001AF530
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignChosenLeader._MakeAnalyticsData_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052AA RID: 21162 RVA: 0x001B1378 File Offset: 0x001AF578
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052AB RID: 21163 RVA: 0x001B13AC File Offset: 0x001AF5AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131954, XrefRangeEnd = 131965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001481 RID: 5249
			// (get) Token: 0x060052AC RID: 21164 RVA: 0x001B13E8 File Offset: 0x001AF5E8
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x060052AD RID: 21165 RVA: 0x001B1420 File Offset: 0x001AF620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131965, XrefRangeEnd = 131970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001482 RID: 5250
			// (get) Token: 0x060052AE RID: 21166 RVA: 0x001B1454 File Offset: 0x001AF654
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131970, XrefRangeEnd = 131973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052AF RID: 21167 RVA: 0x001B1494 File Offset: 0x001AF694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131973, XrefRangeEnd = 131975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x060052B0 RID: 21168 RVA: 0x001B14D4 File Offset: 0x001AF6D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignChosenLeader._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060052B1 RID: 21169 RVA: 0x0001CD9E File Offset: 0x0001AF9E
			public _MakeAnalyticsData_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700147D RID: 5245
			// (get) Token: 0x060052B2 RID: 21170 RVA: 0x001B1514 File Offset: 0x001AF714
			// (set) Token: 0x060052B3 RID: 21171 RVA: 0x0001CDA7 File Offset: 0x0001AFA7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignChosenLeader._MakeAnalyticsData_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignChosenLeader._MakeAnalyticsData_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700147E RID: 5246
			// (get) Token: 0x060052B4 RID: 21172 RVA: 0x001B153C File Offset: 0x001AF73C
			// (set) Token: 0x060052B5 RID: 21173 RVA: 0x0001CDC2 File Offset: 0x0001AFC2
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignChosenLeader._MakeAnalyticsData_d__7.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignChosenLeader._MakeAnalyticsData_d__7.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700147F RID: 5247
			// (get) Token: 0x060052B6 RID: 21174 RVA: 0x001B156C File Offset: 0x001AF76C
			// (set) Token: 0x060052B7 RID: 21175 RVA: 0x0001CDF0 File Offset: 0x0001AFF0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignChosenLeader._MakeAnalyticsData_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignChosenLeader._MakeAnalyticsData_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001480 RID: 5248
			// (get) Token: 0x060052B8 RID: 21176 RVA: 0x001B1594 File Offset: 0x001AF794
			// (set) Token: 0x060052B9 RID: 21177 RVA: 0x0001CE0B File Offset: 0x0001B00B
			public unsafe AssignChosenLeader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignChosenLeader._MakeAnalyticsData_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssignChosenLeader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignChosenLeader._MakeAnalyticsData_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003624 RID: 13860
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003625 RID: 13861
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003626 RID: 13862
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003627 RID: 13863
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003628 RID: 13864
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003629 RID: 13865
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400362A RID: 13866
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400362B RID: 13867
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x0400362C RID: 13868
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400362D RID: 13869
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400362E RID: 13870
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x0400362F RID: 13871
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
