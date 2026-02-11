using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.attributes;
using Canis.context;
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
	// Token: 0x02000246 RID: 582
	public class GainResources : global::Canis.actions.Action
	{
		// Token: 0x06001953 RID: 6483 RVA: 0x000BB658 File Offset: 0x000B9858
		// Note: this type is marked as 'beforefieldinit'.
		static GainResources()
		{
			Il2CppClassPointerStore<GainResources>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "GainResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainResources>.NativeClassPtr);
			GainResources.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources>.NativeClassPtr, "attribute");
			GainResources.NativeFieldInfoPtr_toGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources>.NativeClassPtr, "toGain");
			GainResources.NativeFieldInfoPtr_withLeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources>.NativeClassPtr, "withLeader");
			GainResources.NativeFieldInfoPtr_LogTokenOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources>.NativeClassPtr, "LogTokenOverride");
			GainResources.NativeFieldInfoPtr__LogMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources>.NativeClassPtr, "<LogMode>k__BackingField");
			GainResources.NativeMethodInfoPtr_get_LogToken_Protected_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources>.NativeClassPtr, 100667861);
			GainResources.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources>.NativeClassPtr, 100667862);
			GainResources.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources>.NativeClassPtr, 100667863);
			GainResources.NativeMethodInfoPtr__ctor_Public_Void_AttributeDefinition_1_Nullable_1_Int32_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources>.NativeClassPtr, 100667864);
			GainResources.NativeMethodInfoPtr_WithLogTokenOverride_Public_GainResources_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources>.NativeClassPtr, 100667865);
			GainResources.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources>.NativeClassPtr, 100667866);
			GainResources.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources>.NativeClassPtr, 100667867);
			GainResources.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources>.NativeClassPtr, 100667868);
			GainResources.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources>.NativeClassPtr, 100667869);
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x000BB7A0 File Offset: 0x000B99A0
		public unsafe virtual string LogToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136535, XrefRangeEnd = 136537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainResources.NativeMethodInfoPtr_get_LogToken_Protected_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x000BB7E4 File Offset: 0x000B99E4
		// (set) Token: 0x06001956 RID: 6486 RVA: 0x000BB820 File Offset: 0x000B9A20
		public unsafe virtual ActionLogModes LogMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x000BB860 File Offset: 0x000B9A60
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 136539, RefRangeEnd = 136545, XrefRangeStart = 136537, XrefRangeEnd = 136539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainResources(AttributeDefinition<Nullable<int>> attribute, int amt, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainResources>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources.NativeMethodInfoPtr__ctor_Public_Void_AttributeDefinition_1_Nullable_1_Int32_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x000BB8CC File Offset: 0x000B9ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136545, XrefRangeEnd = 136546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainResources WithLogTokenOverride(string token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources.NativeMethodInfoPtr_WithLogTokenOverride_Public_GainResources_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GainResources>(intPtr3) : null;
			}
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x000BB91C File Offset: 0x000B9B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136546, XrefRangeEnd = 136554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(WormMatch wormMatch, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x000BB980 File Offset: 0x000B9B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136554, XrefRangeEnd = 136560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainResources.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x000BB9CC File Offset: 0x000B9BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136560, XrefRangeEnd = 136567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainResources.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x000BBA28 File Offset: 0x000B9C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136567, XrefRangeEnd = 136572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainResources.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x0000AE4B File Offset: 0x0000904B
		public GainResources(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x000BBA84 File Offset: 0x000B9C84
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x0000AE54 File Offset: 0x00009054
		public unsafe AttributeDefinition<Nullable<int>> attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources.NativeFieldInfoPtr_attribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources.NativeFieldInfoPtr_attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x000BBAB4 File Offset: 0x000B9CB4
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x0000AE73 File Offset: 0x00009073
		public unsafe int toGain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources.NativeFieldInfoPtr_toGain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources.NativeFieldInfoPtr_toGain)) = value;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x000BBADC File Offset: 0x000B9CDC
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x0000AE8E File Offset: 0x0000908E
		public unsafe bool withLeader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources.NativeFieldInfoPtr_withLeader);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources.NativeFieldInfoPtr_withLeader)) = value;
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x000BBB04 File Offset: 0x000B9D04
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x0000AEA9 File Offset: 0x000090A9
		public unsafe string LogTokenOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources.NativeFieldInfoPtr_LogTokenOverride);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources.NativeFieldInfoPtr_LogTokenOverride), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x000BBB2C File Offset: 0x000B9D2C
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x0000AEC8 File Offset: 0x000090C8
		public unsafe ActionLogModes _LogMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources.NativeFieldInfoPtr__LogMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources.NativeFieldInfoPtr__LogMode_k__BackingField)) = value;
			}
		}

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeFieldInfoPtr_attribute;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeFieldInfoPtr_toGain;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeFieldInfoPtr_withLeader;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeFieldInfoPtr_LogTokenOverride;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeFieldInfoPtr__LogMode_k__BackingField;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr_get_LogToken_Protected_Virtual_New_get_String_0;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDefinition_1_Nullable_1_Int32_Int32_Match_0;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeMethodInfoPtr_WithLogTokenOverride_Public_GainResources_String_0;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x02000682 RID: 1666
		[ObfuscatedName("worm.canis.actions.GainResources+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600561B RID: 22043 RVA: 0x001BB37C File Offset: 0x001B957C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GainResources.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainResources>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainResources.__c>.NativeClassPtr);
				GainResources.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources.__c>.NativeClassPtr, "<>9");
				GainResources.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources.__c>.NativeClassPtr, "<>9__13_0");
				GainResources.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources.__c>.NativeClassPtr, 100667871);
				GainResources.__c.NativeMethodInfoPtr__execute_b__13_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources.__c>.NativeClassPtr, 100667872);
			}

			// Token: 0x0600561C RID: 22044 RVA: 0x001BB3F8 File Offset: 0x001B95F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainResources.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600561D RID: 22045 RVA: 0x001BB434 File Offset: 0x001B9634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136159, XrefRangeEnd = 136160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__13_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources.__c.NativeMethodInfoPtr__execute_b__13_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600561E RID: 22046 RVA: 0x0001ED76 File Offset: 0x0001CF76
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015BC RID: 5564
			// (get) Token: 0x0600561F RID: 22047 RVA: 0x001BB484 File Offset: 0x001B9684
			// (set) Token: 0x06005620 RID: 22048 RVA: 0x0001ED7F File Offset: 0x0001CF7F
			public unsafe static GainResources.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainResources.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainResources.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainResources.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015BD RID: 5565
			// (get) Token: 0x06005621 RID: 22049 RVA: 0x001BB4AC File Offset: 0x001B96AC
			// (set) Token: 0x06005622 RID: 22050 RVA: 0x0001ED91 File Offset: 0x0001CF91
			public unsafe static Func<Entity, bool> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainResources.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainResources.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400383A RID: 14394
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400383B RID: 14395
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x0400383C RID: 14396
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400383D RID: 14397
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__13_0_Internal_Boolean_Entity_0;
		}

		// Token: 0x02000683 RID: 1667
		[ObfuscatedName("worm.canis.actions.GainResources+<MakeAnalyticsData>d__12")]
		public sealed class _MakeAnalyticsData_d__12 : Object
		{
			// Token: 0x06005623 RID: 22051 RVA: 0x001BB4D4 File Offset: 0x001B96D4
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__12()
			{
				Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainResources>.NativeClassPtr, "<MakeAnalyticsData>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr);
				GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, "<>1__state");
				GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, "<>2__current");
				GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, "<>l__initialThreadId");
				GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, "wormMatch");
				GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, "<>3__wormMatch");
				GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, "<>4__this");
				GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, "player");
				GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, "<>3__player");
				GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, 100667873);
				GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, 100667874);
				GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, 100667875);
				GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, 100667876);
				GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, 100667877);
				GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, 100667878);
				GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, 100667879);
				GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr, 100667880);
			}

			// Token: 0x06005624 RID: 22052 RVA: 0x001BB640 File Offset: 0x001B9840
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainResources._MakeAnalyticsData_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005625 RID: 22053 RVA: 0x001BB688 File Offset: 0x001B9888
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005626 RID: 22054 RVA: 0x001BB6BC File Offset: 0x001B98BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136160, XrefRangeEnd = 136181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170015C6 RID: 5574
			// (get) Token: 0x06005627 RID: 22055 RVA: 0x001BB6F8 File Offset: 0x001B98F8
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x06005628 RID: 22056 RVA: 0x001BB730 File Offset: 0x001B9930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136181, XrefRangeEnd = 136186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015C7 RID: 5575
			// (get) Token: 0x06005629 RID: 22057 RVA: 0x001BB764 File Offset: 0x001B9964
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136186, XrefRangeEnd = 136189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600562A RID: 22058 RVA: 0x001BB7A4 File Offset: 0x001B99A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136189, XrefRangeEnd = 136199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x0600562B RID: 22059 RVA: 0x001BB7E4 File Offset: 0x001B99E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._MakeAnalyticsData_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600562C RID: 22060 RVA: 0x0001EDA3 File Offset: 0x0001CFA3
			public _MakeAnalyticsData_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015BE RID: 5566
			// (get) Token: 0x0600562D RID: 22061 RVA: 0x001BB824 File Offset: 0x001B9A24
			// (set) Token: 0x0600562E RID: 22062 RVA: 0x0001EDAC File Offset: 0x0001CFAC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170015BF RID: 5567
			// (get) Token: 0x0600562F RID: 22063 RVA: 0x001BB84C File Offset: 0x001B9A4C
			// (set) Token: 0x06005630 RID: 22064 RVA: 0x0001EDC7 File Offset: 0x0001CFC7
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170015C0 RID: 5568
			// (get) Token: 0x06005631 RID: 22065 RVA: 0x001BB87C File Offset: 0x001B9A7C
			// (set) Token: 0x06005632 RID: 22066 RVA: 0x0001EDF5 File Offset: 0x0001CFF5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170015C1 RID: 5569
			// (get) Token: 0x06005633 RID: 22067 RVA: 0x001BB8A4 File Offset: 0x001B9AA4
			// (set) Token: 0x06005634 RID: 22068 RVA: 0x0001EE10 File Offset: 0x0001D010
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015C2 RID: 5570
			// (get) Token: 0x06005635 RID: 22069 RVA: 0x001BB8D4 File Offset: 0x001B9AD4
			// (set) Token: 0x06005636 RID: 22070 RVA: 0x0001EE2F File Offset: 0x0001D02F
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015C3 RID: 5571
			// (get) Token: 0x06005637 RID: 22071 RVA: 0x001BB904 File Offset: 0x001B9B04
			// (set) Token: 0x06005638 RID: 22072 RVA: 0x0001EE4E File Offset: 0x0001D04E
			public unsafe GainResources __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainResources>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015C4 RID: 5572
			// (get) Token: 0x06005639 RID: 22073 RVA: 0x001BB934 File Offset: 0x001B9B34
			// (set) Token: 0x0600563A RID: 22074 RVA: 0x0001EE6D File Offset: 0x0001D06D
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015C5 RID: 5573
			// (get) Token: 0x0600563B RID: 22075 RVA: 0x001BB964 File Offset: 0x001B9B64
			// (set) Token: 0x0600563C RID: 22076 RVA: 0x0001EE8C File Offset: 0x0001D08C
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._MakeAnalyticsData_d__12.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400383E RID: 14398
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400383F RID: 14399
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003840 RID: 14400
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003841 RID: 14401
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04003842 RID: 14402
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x04003843 RID: 14403
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003844 RID: 14404
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04003845 RID: 14405
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04003846 RID: 14406
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003847 RID: 14407
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003848 RID: 14408
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003849 RID: 14409
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x0400384A RID: 14410
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400384B RID: 14411
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400384C RID: 14412
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x0400384D RID: 14413
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000684 RID: 1668
		[ObfuscatedName("worm.canis.actions.GainResources+<execute>d__13")]
		public sealed class _execute_d__13 : Object
		{
			// Token: 0x0600563D RID: 22077 RVA: 0x001BB994 File Offset: 0x001B9B94
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__13()
			{
				Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainResources>.NativeClassPtr, "<execute>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr);
				GainResources._execute_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, "<>1__state");
				GainResources._execute_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, "<>2__current");
				GainResources._execute_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, "<>l__initialThreadId");
				GainResources._execute_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, "<>4__this");
				GainResources._execute_d__13.NativeFieldInfoPtr__wm_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, "<wm>5__2");
				GainResources._execute_d__13.NativeFieldInfoPtr__player_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, "<player>5__3");
				GainResources._execute_d__13.NativeFieldInfoPtr__final_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, "<final>5__4");
				GainResources._execute_d__13.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, "<>7__wrap4");
				GainResources._execute_d__13.NativeFieldInfoPtr__undoNode_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, "<undoNode>5__6");
				GainResources._execute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, 100667881);
				GainResources._execute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, 100667882);
				GainResources._execute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, 100667883);
				GainResources._execute_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, 100667884);
				GainResources._execute_d__13.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, 100667885);
				GainResources._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, 100667886);
				GainResources._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, 100667887);
				GainResources._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, 100667888);
				GainResources._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, 100667889);
				GainResources._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr, 100667890);
			}

			// Token: 0x0600563E RID: 22078 RVA: 0x001BBB3C File Offset: 0x001B9D3C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainResources._execute_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._execute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600563F RID: 22079 RVA: 0x001BBB84 File Offset: 0x001B9D84
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._execute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005640 RID: 22080 RVA: 0x001BBBB8 File Offset: 0x001B9DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136199, XrefRangeEnd = 136408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._execute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005641 RID: 22081 RVA: 0x001BBBF4 File Offset: 0x001B9DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136408, XrefRangeEnd = 136411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._execute_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005642 RID: 22082 RVA: 0x001BBC28 File Offset: 0x001B9E28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136411, XrefRangeEnd = 136414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._execute_d__13.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015D1 RID: 5585
			// (get) Token: 0x06005643 RID: 22083 RVA: 0x001BBC5C File Offset: 0x001B9E5C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005644 RID: 22084 RVA: 0x001BBC9C File Offset: 0x001B9E9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136414, XrefRangeEnd = 136419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015D2 RID: 5586
			// (get) Token: 0x06005645 RID: 22085 RVA: 0x001BBCD0 File Offset: 0x001B9ED0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005646 RID: 22086 RVA: 0x001BBD10 File Offset: 0x001B9F10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136419, XrefRangeEnd = 136421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005647 RID: 22087 RVA: 0x001BBD50 File Offset: 0x001B9F50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005648 RID: 22088 RVA: 0x0001EEAB File Offset: 0x0001D0AB
			public _execute_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015C8 RID: 5576
			// (get) Token: 0x06005649 RID: 22089 RVA: 0x001BBD90 File Offset: 0x001B9F90
			// (set) Token: 0x0600564A RID: 22090 RVA: 0x0001EEB4 File Offset: 0x0001D0B4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170015C9 RID: 5577
			// (get) Token: 0x0600564B RID: 22091 RVA: 0x001BBDB8 File Offset: 0x001B9FB8
			// (set) Token: 0x0600564C RID: 22092 RVA: 0x0001EECF File Offset: 0x0001D0CF
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015CA RID: 5578
			// (get) Token: 0x0600564D RID: 22093 RVA: 0x001BBDE8 File Offset: 0x001B9FE8
			// (set) Token: 0x0600564E RID: 22094 RVA: 0x0001EEEE File Offset: 0x0001D0EE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170015CB RID: 5579
			// (get) Token: 0x0600564F RID: 22095 RVA: 0x001BBE10 File Offset: 0x001BA010
			// (set) Token: 0x06005650 RID: 22096 RVA: 0x0001EF09 File Offset: 0x0001D109
			public unsafe GainResources __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainResources>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015CC RID: 5580
			// (get) Token: 0x06005651 RID: 22097 RVA: 0x001BBE40 File Offset: 0x001BA040
			// (set) Token: 0x06005652 RID: 22098 RVA: 0x0001EF28 File Offset: 0x0001D128
			public unsafe WormMatch _wm_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr__wm_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr__wm_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015CD RID: 5581
			// (get) Token: 0x06005653 RID: 22099 RVA: 0x001BBE70 File Offset: 0x001BA070
			// (set) Token: 0x06005654 RID: 22100 RVA: 0x0001EF47 File Offset: 0x0001D147
			public unsafe WormPlayer _player_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr__player_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr__player_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015CE RID: 5582
			// (get) Token: 0x06005655 RID: 22101 RVA: 0x001BBEA0 File Offset: 0x001BA0A0
			// (set) Token: 0x06005656 RID: 22102 RVA: 0x0001EF66 File Offset: 0x0001D166
			public unsafe int _final_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr__final_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr__final_5__4)) = value;
				}
			}

			// Token: 0x170015CF RID: 5583
			// (get) Token: 0x06005657 RID: 22103 RVA: 0x001BBEC8 File Offset: 0x001BA0C8
			// (set) Token: 0x06005658 RID: 22104 RVA: 0x0001EF81 File Offset: 0x0001D181
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015D0 RID: 5584
			// (get) Token: 0x06005659 RID: 22105 RVA: 0x001BBEF8 File Offset: 0x001BA0F8
			// (set) Token: 0x0600565A RID: 22106 RVA: 0x0001EFA0 File Offset: 0x0001D1A0
			public unsafe UndoNode _undoNode_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr__undoNode_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._execute_d__13.NativeFieldInfoPtr__undoNode_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400384E RID: 14414
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400384F RID: 14415
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003850 RID: 14416
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003851 RID: 14417
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003852 RID: 14418
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__2;

			// Token: 0x04003853 RID: 14419
			private static readonly IntPtr NativeFieldInfoPtr__player_5__3;

			// Token: 0x04003854 RID: 14420
			private static readonly IntPtr NativeFieldInfoPtr__final_5__4;

			// Token: 0x04003855 RID: 14421
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x04003856 RID: 14422
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__6;

			// Token: 0x04003857 RID: 14423
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003858 RID: 14424
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003859 RID: 14425
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400385A RID: 14426
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400385B RID: 14427
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x0400385C RID: 14428
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400385D RID: 14429
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400385E RID: 14430
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400385F RID: 14431
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003860 RID: 14432
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000685 RID: 1669
		[ObfuscatedName("worm.canis.actions.GainResources+<undo>d__14")]
		public sealed class _undo_d__14 : Object
		{
			// Token: 0x0600565B RID: 22107 RVA: 0x001BBF28 File Offset: 0x001BA128
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__14()
			{
				Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainResources>.NativeClassPtr, "<undo>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr);
				GainResources._undo_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, "<>1__state");
				GainResources._undo_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, "<>2__current");
				GainResources._undo_d__14.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, "<>l__initialThreadId");
				GainResources._undo_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, "<>4__this");
				GainResources._undo_d__14.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, "undoContext");
				GainResources._undo_d__14.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, "<>3__undoContext");
				GainResources._undo_d__14.NativeFieldInfoPtr__wm_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, "<wm>5__2");
				GainResources._undo_d__14.NativeFieldInfoPtr__player_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, "<player>5__3");
				GainResources._undo_d__14.NativeFieldInfoPtr__gained_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, "<gained>5__4");
				GainResources._undo_d__14.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, "<>7__wrap4");
				GainResources._undo_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, 100667891);
				GainResources._undo_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, 100667892);
				GainResources._undo_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, 100667893);
				GainResources._undo_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, 100667894);
				GainResources._undo_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, 100667895);
				GainResources._undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, 100667896);
				GainResources._undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, 100667897);
				GainResources._undo_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, 100667898);
				GainResources._undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr, 100667899);
			}

			// Token: 0x0600565C RID: 22108 RVA: 0x001BC0D0 File Offset: 0x001BA2D0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainResources._undo_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._undo_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600565D RID: 22109 RVA: 0x001BC118 File Offset: 0x001BA318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136421, XrefRangeEnd = 136426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._undo_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600565E RID: 22110 RVA: 0x001BC14C File Offset: 0x001BA34C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136426, XrefRangeEnd = 136518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._undo_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600565F RID: 22111 RVA: 0x001BC188 File Offset: 0x001BA388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136518, XrefRangeEnd = 136521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._undo_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015DD RID: 5597
			// (get) Token: 0x06005660 RID: 22112 RVA: 0x001BC1BC File Offset: 0x001BA3BC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._undo_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005661 RID: 22113 RVA: 0x001BC1FC File Offset: 0x001BA3FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136521, XrefRangeEnd = 136526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015DE RID: 5598
			// (get) Token: 0x06005662 RID: 22114 RVA: 0x001BC230 File Offset: 0x001BA430
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005663 RID: 22115 RVA: 0x001BC270 File Offset: 0x001BA470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136526, XrefRangeEnd = 136535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._undo_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005664 RID: 22116 RVA: 0x001BC2B0 File Offset: 0x001BA4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResources._undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005665 RID: 22117 RVA: 0x0001EFBF File Offset: 0x0001D1BF
			public _undo_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015D3 RID: 5587
			// (get) Token: 0x06005666 RID: 22118 RVA: 0x001BC2F0 File Offset: 0x001BA4F0
			// (set) Token: 0x06005667 RID: 22119 RVA: 0x0001EFC8 File Offset: 0x0001D1C8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170015D4 RID: 5588
			// (get) Token: 0x06005668 RID: 22120 RVA: 0x001BC318 File Offset: 0x001BA518
			// (set) Token: 0x06005669 RID: 22121 RVA: 0x0001EFE3 File Offset: 0x0001D1E3
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015D5 RID: 5589
			// (get) Token: 0x0600566A RID: 22122 RVA: 0x001BC348 File Offset: 0x001BA548
			// (set) Token: 0x0600566B RID: 22123 RVA: 0x0001F002 File Offset: 0x0001D202
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170015D6 RID: 5590
			// (get) Token: 0x0600566C RID: 22124 RVA: 0x001BC370 File Offset: 0x001BA570
			// (set) Token: 0x0600566D RID: 22125 RVA: 0x0001F01D File Offset: 0x0001D21D
			public unsafe GainResources __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainResources>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015D7 RID: 5591
			// (get) Token: 0x0600566E RID: 22126 RVA: 0x001BC3A0 File Offset: 0x001BA5A0
			// (set) Token: 0x0600566F RID: 22127 RVA: 0x0001F03C File Offset: 0x0001D23C
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015D8 RID: 5592
			// (get) Token: 0x06005670 RID: 22128 RVA: 0x001BC3D0 File Offset: 0x001BA5D0
			// (set) Token: 0x06005671 RID: 22129 RVA: 0x0001F05B File Offset: 0x0001D25B
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015D9 RID: 5593
			// (get) Token: 0x06005672 RID: 22130 RVA: 0x001BC400 File Offset: 0x001BA600
			// (set) Token: 0x06005673 RID: 22131 RVA: 0x0001F07A File Offset: 0x0001D27A
			public unsafe WormMatch _wm_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr__wm_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr__wm_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015DA RID: 5594
			// (get) Token: 0x06005674 RID: 22132 RVA: 0x001BC430 File Offset: 0x001BA630
			// (set) Token: 0x06005675 RID: 22133 RVA: 0x0001F099 File Offset: 0x0001D299
			public unsafe WormPlayer _player_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr__player_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr__player_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015DB RID: 5595
			// (get) Token: 0x06005676 RID: 22134 RVA: 0x001BC460 File Offset: 0x001BA660
			// (set) Token: 0x06005677 RID: 22135 RVA: 0x0001F0B8 File Offset: 0x0001D2B8
			public unsafe int _gained_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr__gained_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr__gained_5__4)) = value;
				}
			}

			// Token: 0x170015DC RID: 5596
			// (get) Token: 0x06005678 RID: 22136 RVA: 0x001BC488 File Offset: 0x001BA688
			// (set) Token: 0x06005679 RID: 22137 RVA: 0x0001F0D3 File Offset: 0x0001D2D3
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResources._undo_d__14.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003861 RID: 14433
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003862 RID: 14434
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003863 RID: 14435
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003864 RID: 14436
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003865 RID: 14437
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04003866 RID: 14438
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04003867 RID: 14439
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__2;

			// Token: 0x04003868 RID: 14440
			private static readonly IntPtr NativeFieldInfoPtr__player_5__3;

			// Token: 0x04003869 RID: 14441
			private static readonly IntPtr NativeFieldInfoPtr__gained_5__4;

			// Token: 0x0400386A RID: 14442
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x0400386B RID: 14443
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400386C RID: 14444
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400386D RID: 14445
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400386E RID: 14446
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400386F RID: 14447
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003870 RID: 14448
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003871 RID: 14449
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003872 RID: 14450
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003873 RID: 14451
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
