using System;
using Canis.actions;
using Canis.actions.responseparsers;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages.outgoing;
using Networking.selection.targetinformation;

namespace Canis.context.targetpickers
{
	// Token: 0x02000120 RID: 288
	public class SelectedAbility : TargetPicker<EntityIDTargetResponses>
	{
		// Token: 0x06000D3E RID: 3390 RVA: 0x00052238 File Offset: 0x00050438
		// Note: this type is marked as 'beforefieldinit'.
		static SelectedAbility()
		{
			Il2CppClassPointerStore<SelectedAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.targetpickers", "SelectedAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedAbility>.NativeClassPtr);
			SelectedAbility.NativeFieldInfoPtr_fromAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedAbility>.NativeClassPtr, "fromAbilities");
			SelectedAbility.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedAbility>.NativeClassPtr, "forced");
			SelectedAbility.NativeFieldInfoPtr_sourceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedAbility>.NativeClassPtr, "sourceEntity");
			SelectedAbility.NativeFieldInfoPtr_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedAbility>.NativeClassPtr, "parameters");
			SelectedAbility.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_AbilityDefinition_Match_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedAbility>.NativeClassPtr, 100666278);
			SelectedAbility.NativeMethodInfoPtr_WithParam_Public_SelectedAbility_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedAbility>.NativeClassPtr, 100666279);
			SelectedAbility.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_EntityIDTargetResponses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedAbility>.NativeClassPtr, 100666280);
			SelectedAbility.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedAbility>.NativeClassPtr, 100666281);
			SelectedAbility.NativeMethodInfoPtr__PickTargets_b__8_1_Private_Il2CppReferenceArray_1_TargetInformation_AbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedAbility>.NativeClassPtr, 100666282);
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x0005231C File Offset: 0x0005051C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576284, XrefRangeEnd = 576299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedAbility(IEnumerable<AbilityDefinition> fromAbilities, Match m, bool forced = true, EntityID sourceEntity = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromAbilities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceEntity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedAbility.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_AbilityDefinition_Match_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x0005239C File Offset: 0x0005059C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576299, XrefRangeEnd = 576302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedAbility WithParam(string key, Object val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedAbility.NativeMethodInfoPtr_WithParam_Public_SelectedAbility_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectedAbility>(intPtr3) : null;
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00052400 File Offset: 0x00050600
		public unsafe override ResponseParser<EntityIDTargetResponses> responseParser
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576302, XrefRangeEnd = 576306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedAbility.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_EntityIDTargetResponses_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseParser<EntityIDTargetResponses>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x0005244C File Offset: 0x0005064C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576306, XrefRangeEnd = 576360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionRequest PickTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedAbility.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRequest>(intPtr3) : null;
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00052498 File Offset: 0x00050698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576360, XrefRangeEnd = 576364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TargetInformation> _PickTargets_b__8_1(AbilityDefinition _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedAbility.NativeMethodInfoPtr__PickTargets_b__8_1_Private_Il2CppReferenceArray_1_TargetInformation_AbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TargetInformation>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00006BDD File Offset: 0x00004DDD
		public SelectedAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x000524E8 File Offset: 0x000506E8
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x00006BE6 File Offset: 0x00004DE6
		public unsafe List<AbilityDefinition> fromAbilities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedAbility.NativeFieldInfoPtr_fromAbilities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AbilityDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedAbility.NativeFieldInfoPtr_fromAbilities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x00052518 File Offset: 0x00050718
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x00006C05 File Offset: 0x00004E05
		public unsafe bool forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedAbility.NativeFieldInfoPtr_forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedAbility.NativeFieldInfoPtr_forced)) = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x00052540 File Offset: 0x00050740
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x00006C20 File Offset: 0x00004E20
		public unsafe EntityID sourceEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedAbility.NativeFieldInfoPtr_sourceEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedAbility.NativeFieldInfoPtr_sourceEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00052570 File Offset: 0x00050770
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x00006C3F File Offset: 0x00004E3F
		public unsafe Dictionary<string, Object> parameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedAbility.NativeFieldInfoPtr_parameters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedAbility.NativeFieldInfoPtr_parameters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeFieldInfoPtr_fromAbilities;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr_forced;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeFieldInfoPtr_sourceEntity;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeFieldInfoPtr_parameters;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_AbilityDefinition_Match_Boolean_EntityID_0;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeMethodInfoPtr_WithParam_Public_SelectedAbility_String_Object_0;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_EntityIDTargetResponses_0;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__8_1_Private_Il2CppReferenceArray_1_TargetInformation_AbilityDefinition_0;

		// Token: 0x02000385 RID: 901
		[ObfuscatedName("Canis.context.targetpickers.SelectedAbility+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060025AA RID: 9642 RVA: 0x000A6C68 File Offset: 0x000A4E68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SelectedAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectedAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedAbility.__c>.NativeClassPtr);
				SelectedAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedAbility.__c>.NativeClassPtr, "<>9");
				SelectedAbility.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedAbility.__c>.NativeClassPtr, "<>9__8_0");
				SelectedAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedAbility.__c>.NativeClassPtr, 100666284);
				SelectedAbility.__c.NativeMethodInfoPtr__PickTargets_b__8_0_Internal_EntityID_AbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedAbility.__c>.NativeClassPtr, 100666285);
			}

			// Token: 0x060025AB RID: 9643 RVA: 0x000A6CE4 File Offset: 0x000A4EE4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025AC RID: 9644 RVA: 0x000A6D20 File Offset: 0x000A4F20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityID _PickTargets_b__8_0(AbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedAbility.__c.NativeMethodInfoPtr__PickTargets_b__8_0_Internal_EntityID_AbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060025AD RID: 9645 RVA: 0x00011FAB File Offset: 0x000101AB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000942 RID: 2370
			// (get) Token: 0x060025AE RID: 9646 RVA: 0x000A6D70 File Offset: 0x000A4F70
			// (set) Token: 0x060025AF RID: 9647 RVA: 0x00011FB4 File Offset: 0x000101B4
			public unsafe static SelectedAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectedAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectedAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectedAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000943 RID: 2371
			// (get) Token: 0x060025B0 RID: 9648 RVA: 0x000A6D98 File Offset: 0x000A4F98
			// (set) Token: 0x060025B1 RID: 9649 RVA: 0x00011FC6 File Offset: 0x000101C6
			public unsafe static Func<AbilityDefinition, EntityID> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectedAbility.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AbilityDefinition, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectedAbility.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400178B RID: 6027
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400178C RID: 6028
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400178D RID: 6029
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400178E RID: 6030
			private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__8_0_Internal_EntityID_AbilityDefinition_0;
		}
	}
}
