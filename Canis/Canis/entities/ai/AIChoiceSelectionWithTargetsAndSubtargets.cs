using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;
using Networking.selection.messages.outgoing;
using Networking.selection.targetinformation;

namespace Canis.entities.ai
{
	// Token: 0x020000FD RID: 253
	public class AIChoiceSelectionWithTargetsAndSubtargets : AIChoice
	{
		// Token: 0x06000B3A RID: 2874 RVA: 0x0004932C File Offset: 0x0004752C
		// Note: this type is marked as 'beforefieldinit'.
		static AIChoiceSelectionWithTargetsAndSubtargets()
		{
			Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AIChoiceSelectionWithTargetsAndSubtargets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr);
			AIChoiceSelectionWithTargetsAndSubtargets.NativeFieldInfoPtr_ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr, "ability");
			AIChoiceSelectionWithTargetsAndSubtargets.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr, "selection");
			AIChoiceSelectionWithTargetsAndSubtargets.NativeFieldInfoPtr_targetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr, "targetID");
			AIChoiceSelectionWithTargetsAndSubtargets.NativeFieldInfoPtr_subtargetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr, "subtargetID");
			AIChoiceSelectionWithTargetsAndSubtargets.NativeFieldInfoPtr_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr, "Random");
			AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_AIChoiceContext_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr, 100665725);
			AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_EntityID_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr, 100665726);
			AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr, 100665727);
			AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr_GetTargetInfo_Public_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr, 100665728);
			AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr_SetTarget_Public_Void_EntityID_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr, 100665729);
			AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr_DefaultTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr, 100665730);
			AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr, 100665731);
			AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr, 100665732);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00049460 File Offset: 0x00047660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568615, XrefRangeEnd = 568629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIChoiceSelectionWithTargetsAndSubtargets(AbilityDefinition a, AIChoiceContext c, int r)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_AIChoiceContext_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000494CC File Offset: 0x000476CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568629, XrefRangeEnd = 568635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChoice(int newRank, EntityID target, EntityID subtarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newRank;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subtarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_EntityID_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00049530 File Offset: 0x00047730
		[CallerCount(0)]
		public unsafe void UpdateChoice(int newRank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newRank;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00049570 File Offset: 0x00047770
		[CallerCount(0)]
		public unsafe Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>> GetTargetInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr_GetTargetInfo_Public_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>>(intPtr3) : null;
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x000495B0 File Offset: 0x000477B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568635, XrefRangeEnd = 568637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTarget(EntityID target, EntityID subtarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subtarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr_SetTarget_Public_Void_EntityID_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00049604 File Offset: 0x00047804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568637, XrefRangeEnd = 568689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DefaultTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr_DefaultTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00049638 File Offset: 0x00047838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568689, XrefRangeEnd = 568726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionCounter GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionCounter>(intPtr3) : null;
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00049684 File Offset: 0x00047884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568726, XrefRangeEnd = 568773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIChoiceSelectionWithTargetsAndSubtargets.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0000619E File Offset: 0x0000439E
		public AIChoiceSelectionWithTargetsAndSubtargets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x000496C8 File Offset: 0x000478C8
		// (set) Token: 0x06000B45 RID: 2885 RVA: 0x000061A7 File Offset: 0x000043A7
		public unsafe AbilityDefinition ability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargetsAndSubtargets.NativeFieldInfoPtr_ability);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargetsAndSubtargets.NativeFieldInfoPtr_ability), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x000496F8 File Offset: 0x000478F8
		// (set) Token: 0x06000B47 RID: 2887 RVA: 0x000061C6 File Offset: 0x000043C6
		public unsafe SelectionWithTargetsRequired selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargetsAndSubtargets.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionWithTargetsRequired>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargetsAndSubtargets.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x00049728 File Offset: 0x00047928
		// (set) Token: 0x06000B49 RID: 2889 RVA: 0x000061E5 File Offset: 0x000043E5
		public unsafe EntityID targetID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargetsAndSubtargets.NativeFieldInfoPtr_targetID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargetsAndSubtargets.NativeFieldInfoPtr_targetID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x00049758 File Offset: 0x00047958
		// (set) Token: 0x06000B4B RID: 2891 RVA: 0x00006204 File Offset: 0x00004404
		public unsafe EntityID subtargetID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargetsAndSubtargets.NativeFieldInfoPtr_subtargetID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargetsAndSubtargets.NativeFieldInfoPtr_subtargetID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x00049788 File Offset: 0x00047988
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x00006223 File Offset: 0x00004423
		public unsafe static Random Random
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AIChoiceSelectionWithTargetsAndSubtargets.NativeFieldInfoPtr_Random, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AIChoiceSelectionWithTargetsAndSubtargets.NativeFieldInfoPtr_Random, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeFieldInfoPtr_ability;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeFieldInfoPtr_targetID;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeFieldInfoPtr_subtargetID;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeFieldInfoPtr_Random;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_AIChoiceContext_Int32_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_EntityID_EntityID_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetInfo_Public_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_EntityID_EntityID_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_DefaultTarget_Public_Void_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x02000344 RID: 836
		[ObfuscatedName("Canis.entities.ai.AIChoiceSelectionWithTargetsAndSubtargets+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060022EA RID: 8938 RVA: 0x0009CA38 File Offset: 0x0009AC38
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets.__c>.NativeClassPtr);
				AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets.__c>.NativeClassPtr, "<>9");
				AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets.__c>.NativeClassPtr, "<>9__10_1");
				AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets.__c>.NativeClassPtr, "<>9__10_0");
				AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeFieldInfoPtr___9__10_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets.__c>.NativeClassPtr, "<>9__10_2");
				AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets.__c>.NativeClassPtr, 100665735);
				AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeMethodInfoPtr__DefaultTarget_b__10_0_Internal_Boolean_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets.__c>.NativeClassPtr, 100665736);
				AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeMethodInfoPtr__DefaultTarget_b__10_1_Internal_Boolean_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets.__c>.NativeClassPtr, 100665737);
				AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeMethodInfoPtr__DefaultTarget_b__10_2_Internal_Boolean_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets.__c>.NativeClassPtr, 100665738);
			}

			// Token: 0x060022EB RID: 8939 RVA: 0x0009CB04 File Offset: 0x0009AD04
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsAndSubtargets.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022EC RID: 8940 RVA: 0x0009CB40 File Offset: 0x0009AD40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568583, XrefRangeEnd = 568602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DefaultTarget_b__10_0(KeyValuePair<EntityID, Il2CppReferenceArray<TargetInformation>> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeMethodInfoPtr__DefaultTarget_b__10_0_Internal_Boolean_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022ED RID: 8941 RVA: 0x0009CB94 File Offset: 0x0009AD94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568602, XrefRangeEnd = 568608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DefaultTarget_b__10_1(TargetInformation ti)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ti);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeMethodInfoPtr__DefaultTarget_b__10_1_Internal_Boolean_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022EE RID: 8942 RVA: 0x0009CBE4 File Offset: 0x0009ADE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568608, XrefRangeEnd = 568615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DefaultTarget_b__10_2(TargetInformation _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeMethodInfoPtr__DefaultTarget_b__10_2_Internal_Boolean_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022EF RID: 8943 RVA: 0x00010C97 File Offset: 0x0000EE97
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000885 RID: 2181
			// (get) Token: 0x060022F0 RID: 8944 RVA: 0x0009CC34 File Offset: 0x0009AE34
			// (set) Token: 0x060022F1 RID: 8945 RVA: 0x00010CA0 File Offset: 0x0000EEA0
			public unsafe static AIChoiceSelectionWithTargetsAndSubtargets.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AIChoiceSelectionWithTargetsAndSubtargets.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000886 RID: 2182
			// (get) Token: 0x060022F2 RID: 8946 RVA: 0x0009CC5C File Offset: 0x0009AE5C
			// (set) Token: 0x060022F3 RID: 8947 RVA: 0x00010CB2 File Offset: 0x0000EEB2
			public unsafe static Func<TargetInformation, bool> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000887 RID: 2183
			// (get) Token: 0x060022F4 RID: 8948 RVA: 0x0009CC84 File Offset: 0x0009AE84
			// (set) Token: 0x060022F5 RID: 8949 RVA: 0x00010CC4 File Offset: 0x0000EEC4
			public unsafe static Func<KeyValuePair<EntityID, Il2CppReferenceArray<TargetInformation>>, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, Il2CppReferenceArray<TargetInformation>>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000888 RID: 2184
			// (get) Token: 0x060022F6 RID: 8950 RVA: 0x0009CCAC File Offset: 0x0009AEAC
			// (set) Token: 0x060022F7 RID: 8951 RVA: 0x00010CD6 File Offset: 0x0000EED6
			public unsafe static Func<TargetInformation, bool> __9__10_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeFieldInfoPtr___9__10_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIChoiceSelectionWithTargetsAndSubtargets.__c.NativeFieldInfoPtr___9__10_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015F0 RID: 5616
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015F1 RID: 5617
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x040015F2 RID: 5618
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x040015F3 RID: 5619
			private static readonly IntPtr NativeFieldInfoPtr___9__10_2;

			// Token: 0x040015F4 RID: 5620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015F5 RID: 5621
			private static readonly IntPtr NativeMethodInfoPtr__DefaultTarget_b__10_0_Internal_Boolean_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0;

			// Token: 0x040015F6 RID: 5622
			private static readonly IntPtr NativeMethodInfoPtr__DefaultTarget_b__10_1_Internal_Boolean_TargetInformation_0;

			// Token: 0x040015F7 RID: 5623
			private static readonly IntPtr NativeMethodInfoPtr__DefaultTarget_b__10_2_Internal_Boolean_TargetInformation_0;
		}
	}
}
