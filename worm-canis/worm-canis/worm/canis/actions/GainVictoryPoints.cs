using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using canis.archetypes;
using Canis.attributes;
using Canis.context;
using Canis.entities;
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
	// Token: 0x02000252 RID: 594
	public class GainVictoryPoints : global::Canis.actions.Action
	{
		// Token: 0x060019A2 RID: 6562 RVA: 0x000BC7E0 File Offset: 0x000BA9E0
		// Note: this type is marked as 'beforefieldinit'.
		static GainVictoryPoints()
		{
			Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "GainVictoryPoints");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr);
			GainVictoryPoints.NativeFieldInfoPtr_sourceAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, "sourceAttributes");
			GainVictoryPoints.NativeFieldInfoPtr__LogMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, "<LogMode>k__BackingField");
			GainVictoryPoints.NativeFieldInfoPtr_ReportSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, "ReportSource");
			GainVictoryPoints.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, 100667976);
			GainVictoryPoints.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, 100667977);
			GainVictoryPoints.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyAttributes_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, 100667978);
			GainVictoryPoints.NativeMethodInfoPtr__ctor_Public_Void_Archetype_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, 100667979);
			GainVictoryPoints.NativeMethodInfoPtr__ctor_Public_Void_Int32_EntityID_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, 100667980);
			GainVictoryPoints.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_Int32_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, 100667981);
			GainVictoryPoints.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, 100667982);
			GainVictoryPoints.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, 100667983);
			GainVictoryPoints.NativeMethodInfoPtr_UpdateVPSources_Private_Action_WormPlayer_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, 100667984);
			GainVictoryPoints.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, 100667985);
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x000BC914 File Offset: 0x000BAB14
		// (set) Token: 0x060019A4 RID: 6564 RVA: 0x000BC950 File Offset: 0x000BAB50
		public unsafe virtual ActionLogModes LogMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x000BC990 File Offset: 0x000BAB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137952, XrefRangeEnd = 137961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainVictoryPoints(ReadOnlyAttributes sourceAttributes, Match m, string source = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceAttributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyAttributes_Match_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x000BCA00 File Offset: 0x000BAC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137961, XrefRangeEnd = 137974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainVictoryPoints(Archetype sourceArchetype, Match m, string source = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceArchetype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints.NativeMethodInfoPtr__ctor_Public_Void_Archetype_Match_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x000BCA70 File Offset: 0x000BAC70
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 138010, RefRangeEnd = 138044, XrefRangeStart = 137974, XrefRangeEnd = 138010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainVictoryPoints(int amount, EntityID sourceEntityID, Match m, string source = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceEntityID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints.NativeMethodInfoPtr__ctor_Public_Void_Int32_EntityID_Match_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x000BCAF0 File Offset: 0x000BACF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138044, XrefRangeEnd = 138052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(WormMatch wormMatch, WormPlayer player, int amount, WormEntity sourceEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceEntity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_Int32_WormEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x000BCB74 File Offset: 0x000BAD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138052, XrefRangeEnd = 138058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainVictoryPoints.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x000BCBC0 File Offset: 0x000BADC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138058, XrefRangeEnd = 138065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainVictoryPoints.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x000BCC1C File Offset: 0x000BAE1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138127, RefRangeEnd = 138128, XrefRangeStart = 138065, XrefRangeEnd = 138127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe global::Canis.actions.Action UpdateVPSources(WormPlayer player, EntityID sourceEntityID, int toGain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceEntityID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toGain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints.NativeMethodInfoPtr_UpdateVPSources_Private_Action_WormPlayer_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x000BCC8C File Offset: 0x000BAE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138128, XrefRangeEnd = 138138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainVictoryPoints.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x0000B0EE File Offset: 0x000092EE
		public GainVictoryPoints(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x000BCCE8 File Offset: 0x000BAEE8
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x0000B0F7 File Offset: 0x000092F7
		public unsafe ReadOnlyAttributes sourceAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints.NativeFieldInfoPtr_sourceAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints.NativeFieldInfoPtr_sourceAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x000BCD18 File Offset: 0x000BAF18
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x0000B116 File Offset: 0x00009316
		public unsafe ActionLogModes _LogMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints.NativeFieldInfoPtr__LogMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints.NativeFieldInfoPtr__LogMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x000BCD40 File Offset: 0x000BAF40
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x0000B131 File Offset: 0x00009331
		public unsafe string ReportSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints.NativeFieldInfoPtr_ReportSource);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints.NativeFieldInfoPtr_ReportSource), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeFieldInfoPtr_sourceAttributes;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeFieldInfoPtr__LogMode_k__BackingField;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeFieldInfoPtr_ReportSource;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyAttributes_Match_String_0;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Archetype_Match_String_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_EntityID_Match_String_0;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_Int32_WormEntity_0;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVPSources_Private_Action_WormPlayer_EntityID_Int32_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x0200068C RID: 1676
		[ObfuscatedName("worm.canis.actions.GainVictoryPoints+<MakeAnalyticsData>d__9")]
		public sealed class _MakeAnalyticsData_d__9 : Object
		{
			// Token: 0x06005719 RID: 22297 RVA: 0x001BE2F0 File Offset: 0x001BC4F0
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__9()
			{
				Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, "<MakeAnalyticsData>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr);
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, "<>1__state");
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, "<>2__current");
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, "<>l__initialThreadId");
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, "wormMatch");
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, "<>3__wormMatch");
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr_sourceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, "sourceEntity");
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__sourceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, "<>3__sourceEntity");
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, "amount");
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, "<>3__amount");
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, "player");
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, "<>3__player");
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, 100667986);
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, 100667987);
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, 100667988);
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, 100667989);
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, 100667990);
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, 100667991);
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, 100667992);
				GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr, 100667993);
			}

			// Token: 0x0600571A RID: 22298 RVA: 0x001BE498 File Offset: 0x001BC698
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainVictoryPoints._MakeAnalyticsData_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600571B RID: 22299 RVA: 0x001BE4E0 File Offset: 0x001BC6E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600571C RID: 22300 RVA: 0x001BE514 File Offset: 0x001BC714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137592, XrefRangeEnd = 137614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001625 RID: 5669
			// (get) Token: 0x0600571D RID: 22301 RVA: 0x001BE550 File Offset: 0x001BC750
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x0600571E RID: 22302 RVA: 0x001BE588 File Offset: 0x001BC788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137614, XrefRangeEnd = 137619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001626 RID: 5670
			// (get) Token: 0x0600571F RID: 22303 RVA: 0x001BE5BC File Offset: 0x001BC7BC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137619, XrefRangeEnd = 137622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005720 RID: 22304 RVA: 0x001BE5FC File Offset: 0x001BC7FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137622, XrefRangeEnd = 137632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x06005721 RID: 22305 RVA: 0x001BE63C File Offset: 0x001BC83C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005722 RID: 22306 RVA: 0x0001F697 File Offset: 0x0001D897
			public _MakeAnalyticsData_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700161A RID: 5658
			// (get) Token: 0x06005723 RID: 22307 RVA: 0x001BE67C File Offset: 0x001BC87C
			// (set) Token: 0x06005724 RID: 22308 RVA: 0x0001F6A0 File Offset: 0x0001D8A0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700161B RID: 5659
			// (get) Token: 0x06005725 RID: 22309 RVA: 0x001BE6A4 File Offset: 0x001BC8A4
			// (set) Token: 0x06005726 RID: 22310 RVA: 0x0001F6BB File Offset: 0x0001D8BB
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700161C RID: 5660
			// (get) Token: 0x06005727 RID: 22311 RVA: 0x001BE6D4 File Offset: 0x001BC8D4
			// (set) Token: 0x06005728 RID: 22312 RVA: 0x0001F6E9 File Offset: 0x0001D8E9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700161D RID: 5661
			// (get) Token: 0x06005729 RID: 22313 RVA: 0x001BE6FC File Offset: 0x001BC8FC
			// (set) Token: 0x0600572A RID: 22314 RVA: 0x0001F704 File Offset: 0x0001D904
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700161E RID: 5662
			// (get) Token: 0x0600572B RID: 22315 RVA: 0x001BE72C File Offset: 0x001BC92C
			// (set) Token: 0x0600572C RID: 22316 RVA: 0x0001F723 File Offset: 0x0001D923
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700161F RID: 5663
			// (get) Token: 0x0600572D RID: 22317 RVA: 0x001BE75C File Offset: 0x001BC95C
			// (set) Token: 0x0600572E RID: 22318 RVA: 0x0001F742 File Offset: 0x0001D942
			public unsafe WormEntity sourceEntity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr_sourceEntity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr_sourceEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001620 RID: 5664
			// (get) Token: 0x0600572F RID: 22319 RVA: 0x001BE78C File Offset: 0x001BC98C
			// (set) Token: 0x06005730 RID: 22320 RVA: 0x0001F761 File Offset: 0x0001D961
			public unsafe WormEntity __3__sourceEntity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__sourceEntity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__sourceEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001621 RID: 5665
			// (get) Token: 0x06005731 RID: 22321 RVA: 0x001BE7BC File Offset: 0x001BC9BC
			// (set) Token: 0x06005732 RID: 22322 RVA: 0x0001F780 File Offset: 0x0001D980
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x17001622 RID: 5666
			// (get) Token: 0x06005733 RID: 22323 RVA: 0x001BE7E4 File Offset: 0x001BC9E4
			// (set) Token: 0x06005734 RID: 22324 RVA: 0x0001F79B File Offset: 0x0001D99B
			public unsafe int __3__amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__amount)) = value;
				}
			}

			// Token: 0x17001623 RID: 5667
			// (get) Token: 0x06005735 RID: 22325 RVA: 0x001BE80C File Offset: 0x001BCA0C
			// (set) Token: 0x06005736 RID: 22326 RVA: 0x0001F7B6 File Offset: 0x0001D9B6
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001624 RID: 5668
			// (get) Token: 0x06005737 RID: 22327 RVA: 0x001BE83C File Offset: 0x001BCA3C
			// (set) Token: 0x06005738 RID: 22328 RVA: 0x0001F7D5 File Offset: 0x0001D9D5
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040038D6 RID: 14550
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040038D7 RID: 14551
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040038D8 RID: 14552
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040038D9 RID: 14553
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x040038DA RID: 14554
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x040038DB RID: 14555
			private static readonly IntPtr NativeFieldInfoPtr_sourceEntity;

			// Token: 0x040038DC RID: 14556
			private static readonly IntPtr NativeFieldInfoPtr___3__sourceEntity;

			// Token: 0x040038DD RID: 14557
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x040038DE RID: 14558
			private static readonly IntPtr NativeFieldInfoPtr___3__amount;

			// Token: 0x040038DF RID: 14559
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040038E0 RID: 14560
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x040038E1 RID: 14561
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040038E2 RID: 14562
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040038E3 RID: 14563
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040038E4 RID: 14564
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x040038E5 RID: 14565
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040038E6 RID: 14566
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040038E7 RID: 14567
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x040038E8 RID: 14568
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200068D RID: 1677
		[ObfuscatedName("worm.canis.actions.GainVictoryPoints+<execute>d__10")]
		public sealed class _execute_d__10 : Object
		{
			// Token: 0x06005739 RID: 22329 RVA: 0x001BE86C File Offset: 0x001BCA6C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__10()
			{
				Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, "<execute>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr);
				GainVictoryPoints._execute_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, "<>1__state");
				GainVictoryPoints._execute_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, "<>2__current");
				GainVictoryPoints._execute_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, "<>l__initialThreadId");
				GainVictoryPoints._execute_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, "<>4__this");
				GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__toGain_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, "<toGain>5__2");
				GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__sourceEntityID_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, "<sourceEntityID>5__3");
				GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__wm_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, "<wm>5__4");
				GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__player_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, "<player>5__5");
				GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__currentAmount_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, "<currentAmount>5__6");
				GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__sourceEntity_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, "<sourceEntity>5__7");
				GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__childUndo_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, "<childUndo>5__8");
				GainVictoryPoints._execute_d__10.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, "<>7__wrap8");
				GainVictoryPoints._execute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, 100667994);
				GainVictoryPoints._execute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, 100667995);
				GainVictoryPoints._execute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, 100667996);
				GainVictoryPoints._execute_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, 100667997);
				GainVictoryPoints._execute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, 100667998);
				GainVictoryPoints._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, 100667999);
				GainVictoryPoints._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, 100668000);
				GainVictoryPoints._execute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, 100668001);
				GainVictoryPoints._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr, 100668002);
			}

			// Token: 0x0600573A RID: 22330 RVA: 0x001BEA3C File Offset: 0x001BCC3C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainVictoryPoints._execute_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._execute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600573B RID: 22331 RVA: 0x001BEA84 File Offset: 0x001BCC84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137632, XrefRangeEnd = 137637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._execute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600573C RID: 22332 RVA: 0x001BEAB8 File Offset: 0x001BCCB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137637, XrefRangeEnd = 137910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._execute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600573D RID: 22333 RVA: 0x001BEAF4 File Offset: 0x001BCCF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137910, XrefRangeEnd = 137913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._execute_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001633 RID: 5683
			// (get) Token: 0x0600573E RID: 22334 RVA: 0x001BEB28 File Offset: 0x001BCD28
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._execute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600573F RID: 22335 RVA: 0x001BEB68 File Offset: 0x001BCD68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137913, XrefRangeEnd = 137918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001634 RID: 5684
			// (get) Token: 0x06005740 RID: 22336 RVA: 0x001BEB9C File Offset: 0x001BCD9C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005741 RID: 22337 RVA: 0x001BEBDC File Offset: 0x001BCDDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137918, XrefRangeEnd = 137920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._execute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005742 RID: 22338 RVA: 0x001BEC1C File Offset: 0x001BCE1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005743 RID: 22339 RVA: 0x0001F7F4 File Offset: 0x0001D9F4
			public _execute_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001627 RID: 5671
			// (get) Token: 0x06005744 RID: 22340 RVA: 0x001BEC5C File Offset: 0x001BCE5C
			// (set) Token: 0x06005745 RID: 22341 RVA: 0x0001F7FD File Offset: 0x0001D9FD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001628 RID: 5672
			// (get) Token: 0x06005746 RID: 22342 RVA: 0x001BEC84 File Offset: 0x001BCE84
			// (set) Token: 0x06005747 RID: 22343 RVA: 0x0001F818 File Offset: 0x0001DA18
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001629 RID: 5673
			// (get) Token: 0x06005748 RID: 22344 RVA: 0x001BECB4 File Offset: 0x001BCEB4
			// (set) Token: 0x06005749 RID: 22345 RVA: 0x0001F837 File Offset: 0x0001DA37
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700162A RID: 5674
			// (get) Token: 0x0600574A RID: 22346 RVA: 0x001BECDC File Offset: 0x001BCEDC
			// (set) Token: 0x0600574B RID: 22347 RVA: 0x0001F852 File Offset: 0x0001DA52
			public unsafe GainVictoryPoints __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainVictoryPoints>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700162B RID: 5675
			// (get) Token: 0x0600574C RID: 22348 RVA: 0x001BED0C File Offset: 0x001BCF0C
			// (set) Token: 0x0600574D RID: 22349 RVA: 0x0001F871 File Offset: 0x0001DA71
			public unsafe int _toGain_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__toGain_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__toGain_5__2)) = value;
				}
			}

			// Token: 0x1700162C RID: 5676
			// (get) Token: 0x0600574E RID: 22350 RVA: 0x001BED34 File Offset: 0x001BCF34
			// (set) Token: 0x0600574F RID: 22351 RVA: 0x0001F88C File Offset: 0x0001DA8C
			public unsafe EntityID _sourceEntityID_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__sourceEntityID_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__sourceEntityID_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700162D RID: 5677
			// (get) Token: 0x06005750 RID: 22352 RVA: 0x001BED64 File Offset: 0x001BCF64
			// (set) Token: 0x06005751 RID: 22353 RVA: 0x0001F8AB File Offset: 0x0001DAAB
			public unsafe WormMatch _wm_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__wm_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__wm_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700162E RID: 5678
			// (get) Token: 0x06005752 RID: 22354 RVA: 0x001BED94 File Offset: 0x001BCF94
			// (set) Token: 0x06005753 RID: 22355 RVA: 0x0001F8CA File Offset: 0x0001DACA
			public unsafe WormPlayer _player_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__player_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__player_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700162F RID: 5679
			// (get) Token: 0x06005754 RID: 22356 RVA: 0x001BEDC4 File Offset: 0x001BCFC4
			// (set) Token: 0x06005755 RID: 22357 RVA: 0x0001F8E9 File Offset: 0x0001DAE9
			public unsafe int _currentAmount_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__currentAmount_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__currentAmount_5__6)) = value;
				}
			}

			// Token: 0x17001630 RID: 5680
			// (get) Token: 0x06005756 RID: 22358 RVA: 0x001BEDEC File Offset: 0x001BCFEC
			// (set) Token: 0x06005757 RID: 22359 RVA: 0x0001F904 File Offset: 0x0001DB04
			public unsafe WormEntity _sourceEntity_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__sourceEntity_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__sourceEntity_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001631 RID: 5681
			// (get) Token: 0x06005758 RID: 22360 RVA: 0x001BEE1C File Offset: 0x001BD01C
			// (set) Token: 0x06005759 RID: 22361 RVA: 0x0001F923 File Offset: 0x0001DB23
			public unsafe UndoNode _childUndo_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__childUndo_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr__childUndo_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001632 RID: 5682
			// (get) Token: 0x0600575A RID: 22362 RVA: 0x001BEE4C File Offset: 0x001BD04C
			// (set) Token: 0x0600575B RID: 22363 RVA: 0x0001F942 File Offset: 0x0001DB42
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr___7__wrap8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._execute_d__10.NativeFieldInfoPtr___7__wrap8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040038E9 RID: 14569
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040038EA RID: 14570
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040038EB RID: 14571
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040038EC RID: 14572
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040038ED RID: 14573
			private static readonly IntPtr NativeFieldInfoPtr__toGain_5__2;

			// Token: 0x040038EE RID: 14574
			private static readonly IntPtr NativeFieldInfoPtr__sourceEntityID_5__3;

			// Token: 0x040038EF RID: 14575
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__4;

			// Token: 0x040038F0 RID: 14576
			private static readonly IntPtr NativeFieldInfoPtr__player_5__5;

			// Token: 0x040038F1 RID: 14577
			private static readonly IntPtr NativeFieldInfoPtr__currentAmount_5__6;

			// Token: 0x040038F2 RID: 14578
			private static readonly IntPtr NativeFieldInfoPtr__sourceEntity_5__7;

			// Token: 0x040038F3 RID: 14579
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__8;

			// Token: 0x040038F4 RID: 14580
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x040038F5 RID: 14581
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040038F6 RID: 14582
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040038F7 RID: 14583
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040038F8 RID: 14584
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040038F9 RID: 14585
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040038FA RID: 14586
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040038FB RID: 14587
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040038FC RID: 14588
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040038FD RID: 14589
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200068E RID: 1678
		[ObfuscatedName("worm.canis.actions.GainVictoryPoints+<undo>d__11")]
		public sealed class _undo_d__11 : Object
		{
			// Token: 0x0600575C RID: 22364 RVA: 0x001BEE7C File Offset: 0x001BD07C
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__11()
			{
				Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainVictoryPoints>.NativeClassPtr, "<undo>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr);
				GainVictoryPoints._undo_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, "<>1__state");
				GainVictoryPoints._undo_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, "<>2__current");
				GainVictoryPoints._undo_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, "<>l__initialThreadId");
				GainVictoryPoints._undo_d__11.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, "undoContext");
				GainVictoryPoints._undo_d__11.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, "<>3__undoContext");
				GainVictoryPoints._undo_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, "<>4__this");
				GainVictoryPoints._undo_d__11.NativeFieldInfoPtr__undoNode_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, "<undoNode>5__2");
				GainVictoryPoints._undo_d__11.NativeFieldInfoPtr__player_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, "<player>5__3");
				GainVictoryPoints._undo_d__11.NativeFieldInfoPtr__originalVP_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, "<originalVP>5__4");
				GainVictoryPoints._undo_d__11.NativeFieldInfoPtr__currentVP_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, "<currentVP>5__5");
				GainVictoryPoints._undo_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, 100668003);
				GainVictoryPoints._undo_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, 100668004);
				GainVictoryPoints._undo_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, 100668005);
				GainVictoryPoints._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, 100668006);
				GainVictoryPoints._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, 100668007);
				GainVictoryPoints._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, 100668008);
				GainVictoryPoints._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, 100668009);
				GainVictoryPoints._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr, 100668010);
			}

			// Token: 0x0600575D RID: 22365 RVA: 0x001BF010 File Offset: 0x001BD210
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainVictoryPoints._undo_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._undo_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600575E RID: 22366 RVA: 0x001BF058 File Offset: 0x001BD258
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._undo_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600575F RID: 22367 RVA: 0x001BF08C File Offset: 0x001BD28C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137920, XrefRangeEnd = 137936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._undo_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700163F RID: 5695
			// (get) Token: 0x06005760 RID: 22368 RVA: 0x001BF0C8 File Offset: 0x001BD2C8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005761 RID: 22369 RVA: 0x001BF108 File Offset: 0x001BD308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137936, XrefRangeEnd = 137941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001640 RID: 5696
			// (get) Token: 0x06005762 RID: 22370 RVA: 0x001BF13C File Offset: 0x001BD33C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005763 RID: 22371 RVA: 0x001BF17C File Offset: 0x001BD37C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137941, XrefRangeEnd = 137950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005764 RID: 22372 RVA: 0x001BF1BC File Offset: 0x001BD3BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainVictoryPoints._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005765 RID: 22373 RVA: 0x0001F961 File Offset: 0x0001DB61
			public _undo_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001635 RID: 5685
			// (get) Token: 0x06005766 RID: 22374 RVA: 0x001BF1FC File Offset: 0x001BD3FC
			// (set) Token: 0x06005767 RID: 22375 RVA: 0x0001F96A File Offset: 0x0001DB6A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001636 RID: 5686
			// (get) Token: 0x06005768 RID: 22376 RVA: 0x001BF224 File Offset: 0x001BD424
			// (set) Token: 0x06005769 RID: 22377 RVA: 0x0001F985 File Offset: 0x0001DB85
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001637 RID: 5687
			// (get) Token: 0x0600576A RID: 22378 RVA: 0x001BF254 File Offset: 0x001BD454
			// (set) Token: 0x0600576B RID: 22379 RVA: 0x0001F9A4 File Offset: 0x0001DBA4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001638 RID: 5688
			// (get) Token: 0x0600576C RID: 22380 RVA: 0x001BF27C File Offset: 0x001BD47C
			// (set) Token: 0x0600576D RID: 22381 RVA: 0x0001F9BF File Offset: 0x0001DBBF
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001639 RID: 5689
			// (get) Token: 0x0600576E RID: 22382 RVA: 0x001BF2AC File Offset: 0x001BD4AC
			// (set) Token: 0x0600576F RID: 22383 RVA: 0x0001F9DE File Offset: 0x0001DBDE
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700163A RID: 5690
			// (get) Token: 0x06005770 RID: 22384 RVA: 0x001BF2DC File Offset: 0x001BD4DC
			// (set) Token: 0x06005771 RID: 22385 RVA: 0x0001F9FD File Offset: 0x0001DBFD
			public unsafe GainVictoryPoints __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainVictoryPoints>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700163B RID: 5691
			// (get) Token: 0x06005772 RID: 22386 RVA: 0x001BF30C File Offset: 0x001BD50C
			// (set) Token: 0x06005773 RID: 22387 RVA: 0x0001FA1C File Offset: 0x0001DC1C
			public unsafe UndoNode _undoNode_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr__undoNode_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr__undoNode_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700163C RID: 5692
			// (get) Token: 0x06005774 RID: 22388 RVA: 0x001BF33C File Offset: 0x001BD53C
			// (set) Token: 0x06005775 RID: 22389 RVA: 0x0001FA3B File Offset: 0x0001DC3B
			public unsafe WormPlayer _player_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr__player_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr__player_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700163D RID: 5693
			// (get) Token: 0x06005776 RID: 22390 RVA: 0x001BF36C File Offset: 0x001BD56C
			// (set) Token: 0x06005777 RID: 22391 RVA: 0x0001FA5A File Offset: 0x0001DC5A
			public unsafe int _originalVP_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr__originalVP_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr__originalVP_5__4)) = value;
				}
			}

			// Token: 0x1700163E RID: 5694
			// (get) Token: 0x06005778 RID: 22392 RVA: 0x001BF394 File Offset: 0x001BD594
			// (set) Token: 0x06005779 RID: 22393 RVA: 0x0001FA75 File Offset: 0x0001DC75
			public unsafe int _currentVP_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr__currentVP_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainVictoryPoints._undo_d__11.NativeFieldInfoPtr__currentVP_5__5)) = value;
				}
			}

			// Token: 0x040038FE RID: 14590
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040038FF RID: 14591
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003900 RID: 14592
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003901 RID: 14593
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04003902 RID: 14594
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04003903 RID: 14595
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003904 RID: 14596
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__2;

			// Token: 0x04003905 RID: 14597
			private static readonly IntPtr NativeFieldInfoPtr__player_5__3;

			// Token: 0x04003906 RID: 14598
			private static readonly IntPtr NativeFieldInfoPtr__originalVP_5__4;

			// Token: 0x04003907 RID: 14599
			private static readonly IntPtr NativeFieldInfoPtr__currentVP_5__5;

			// Token: 0x04003908 RID: 14600
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003909 RID: 14601
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400390A RID: 14602
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400390B RID: 14603
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400390C RID: 14604
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400390D RID: 14605
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400390E RID: 14606
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400390F RID: 14607
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
