using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;
using Networking.selection.messages.outgoing;
using Networking.selection.targetinformation;
using Networking.selection.targetresponse;

namespace Canis.entities.ai
{
	// Token: 0x020000FC RID: 252
	public class AIChoiceSelectionWithTargets : AIChoice
	{
		// Token: 0x06000B24 RID: 2852 RVA: 0x00048DB8 File Offset: 0x00046FB8
		// Note: this type is marked as 'beforefieldinit'.
		static AIChoiceSelectionWithTargets()
		{
			Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AIChoiceSelectionWithTargets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr);
			AIChoiceSelectionWithTargets.NativeFieldInfoPtr_ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, "ability");
			AIChoiceSelectionWithTargets.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, "response");
			AIChoiceSelectionWithTargets.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, "selection");
			AIChoiceSelectionWithTargets.NativeFieldInfoPtr_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, "Random");
			AIChoiceSelectionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_AIChoiceContext_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, 100665712);
			AIChoiceSelectionWithTargets.NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, 100665713);
			AIChoiceSelectionWithTargets.NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, 100665714);
			AIChoiceSelectionWithTargets.NativeMethodInfoPtr_DefaultTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, 100665715);
			AIChoiceSelectionWithTargets.NativeMethodInfoPtr_FirstTarget_Public_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, 100665716);
			AIChoiceSelectionWithTargets.NativeMethodInfoPtr_FirstResponse_Public_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, 100665717);
			AIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetTargetInfo_Public_EntityListTargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, 100665718);
			AIChoiceSelectionWithTargets.NativeMethodInfoPtr_SetTarget_Public_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, 100665719);
			AIChoiceSelectionWithTargets.NativeMethodInfoPtr_SetTargets_Public_Void_IEnumerable_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, 100665720);
			AIChoiceSelectionWithTargets.NativeMethodInfoPtr_AddTarget_Public_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, 100665721);
			AIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, 100665722);
			AIChoiceSelectionWithTargets.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr, 100665723);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00048F28 File Offset: 0x00047128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568376, XrefRangeEnd = 568390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIChoiceSelectionWithTargets(AbilityDefinition a, AIChoiceContext c, int r)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIChoiceSelectionWithTargets>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_AIChoiceContext_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00048F94 File Offset: 0x00047194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568390, XrefRangeEnd = 568402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChoice(int newRank, EntityID target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newRank;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargets.NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00048FE4 File Offset: 0x000471E4
		[CallerCount(0)]
		public unsafe void UpdateChoice(int newRank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newRank;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargets.NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00049024 File Offset: 0x00047224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568402, XrefRangeEnd = 568439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DefaultTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargets.NativeMethodInfoPtr_DefaultTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00049058 File Offset: 0x00047258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568439, XrefRangeEnd = 568444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityID FirstTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargets.NativeMethodInfoPtr_FirstTarget_Public_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00049098 File Offset: 0x00047298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568444, XrefRangeEnd = 568449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityID FirstResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargets.NativeMethodInfoPtr_FirstResponse_Public_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x000490D8 File Offset: 0x000472D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 568458, RefRangeEnd = 568461, XrefRangeStart = 568449, XrefRangeEnd = 568458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityListTargetInformation GetTargetInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetTargetInfo_Public_EntityListTargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityListTargetInformation>(intPtr3) : null;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00049118 File Offset: 0x00047318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568461, XrefRangeEnd = 568475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTarget(EntityID target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargets.NativeMethodInfoPtr_SetTarget_Public_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0004915C File Offset: 0x0004735C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 568493, RefRangeEnd = 568497, XrefRangeStart = 568475, XrefRangeEnd = 568493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargets(IEnumerable<EntityID> targets)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targets);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargets.NativeMethodInfoPtr_SetTargets_Public_Void_IEnumerable_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x000491A0 File Offset: 0x000473A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568497, XrefRangeEnd = 568525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTarget(EntityID target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargets.NativeMethodInfoPtr_AddTarget_Public_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x000491E4 File Offset: 0x000473E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568525, XrefRangeEnd = 568541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionCounter GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionCounter>(intPtr3) : null;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00049230 File Offset: 0x00047430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568541, XrefRangeEnd = 568583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIChoiceSelectionWithTargets.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00006126 File Offset: 0x00004326
		public AIChoiceSelectionWithTargets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x00049274 File Offset: 0x00047474
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x0000612F File Offset: 0x0000432F
		public unsafe AbilityDefinition ability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargets.NativeFieldInfoPtr_ability);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargets.NativeFieldInfoPtr_ability), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x000492A4 File Offset: 0x000474A4
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x0000614E File Offset: 0x0000434E
		public unsafe List<TargetResponse> response
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargets.NativeFieldInfoPtr_response);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TargetResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargets.NativeFieldInfoPtr_response), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x000492D4 File Offset: 0x000474D4
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x0000616D File Offset: 0x0000436D
		public unsafe SelectionWithTargetsRequired selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargets.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionWithTargetsRequired>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargets.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00049304 File Offset: 0x00047504
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x0000618C File Offset: 0x0000438C
		public unsafe static Random Random
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AIChoiceSelectionWithTargets.NativeFieldInfoPtr_Random, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AIChoiceSelectionWithTargets.NativeFieldInfoPtr_Random, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeFieldInfoPtr_ability;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeFieldInfoPtr_response;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeFieldInfoPtr_Random;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_AIChoiceContext_Int32_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_EntityID_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_DefaultTarget_Public_Void_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_FirstTarget_Public_EntityID_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_FirstResponse_Public_EntityID_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetInfo_Public_EntityListTargetInformation_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_EntityID_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_SetTargets_Public_Void_IEnumerable_1_EntityID_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_AddTarget_Public_Void_EntityID_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
