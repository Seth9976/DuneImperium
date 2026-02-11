using System;
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
	// Token: 0x020000FE RID: 254
	public class AIChoiceSelectionWithTargetsCustomChoice : AIChoice
	{
		// Token: 0x06000B4E RID: 2894 RVA: 0x000497B0 File Offset: 0x000479B0
		// Note: this type is marked as 'beforefieldinit'.
		static AIChoiceSelectionWithTargetsCustomChoice()
		{
			Il2CppClassPointerStore<AIChoiceSelectionWithTargetsCustomChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AIChoiceSelectionWithTargetsCustomChoice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsCustomChoice>.NativeClassPtr);
			AIChoiceSelectionWithTargetsCustomChoice.NativeFieldInfoPtr_ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsCustomChoice>.NativeClassPtr, "ability");
			AIChoiceSelectionWithTargetsCustomChoice.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsCustomChoice>.NativeClassPtr, "response");
			AIChoiceSelectionWithTargetsCustomChoice.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsCustomChoice>.NativeClassPtr, "selection");
			AIChoiceSelectionWithTargetsCustomChoice.NativeFieldInfoPtr_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsCustomChoice>.NativeClassPtr, "Random");
			AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_AIChoiceContext_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsCustomChoice>.NativeClassPtr, 100665739);
			AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsCustomChoice>.NativeClassPtr, 100665740);
			AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsCustomChoice>.NativeClassPtr, 100665741);
			AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr_DefaultTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsCustomChoice>.NativeClassPtr, 100665742);
			AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr_GetTargetInfo_Public_CustomChoiceTargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsCustomChoice>.NativeClassPtr, 100665743);
			AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr_SetTarget_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsCustomChoice>.NativeClassPtr, 100665744);
			AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsCustomChoice>.NativeClassPtr, 100665745);
			AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsCustomChoice>.NativeClassPtr, 100665746);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x000498D0 File Offset: 0x00047AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568773, XrefRangeEnd = 568787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIChoiceSelectionWithTargetsCustomChoice(AbilityDefinition a, AIChoiceContext c, int r)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIChoiceSelectionWithTargetsCustomChoice>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_AIChoiceContext_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0004993C File Offset: 0x00047B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568787, XrefRangeEnd = 568788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChoice(int newRank, int target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newRank;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00049988 File Offset: 0x00047B88
		[CallerCount(0)]
		public unsafe void UpdateChoice(int newRank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newRank;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x000499C8 File Offset: 0x00047BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568788, XrefRangeEnd = 568808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DefaultTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr_DefaultTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x000499FC File Offset: 0x00047BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568808, XrefRangeEnd = 568817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceTargetInformation GetTargetInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr_GetTargetInfo_Public_CustomChoiceTargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomChoiceTargetInformation>(intPtr3) : null;
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00049A3C File Offset: 0x00047C3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 568834, RefRangeEnd = 568837, XrefRangeStart = 568817, XrefRangeEnd = 568834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTarget(int target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr_SetTarget_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00049A7C File Offset: 0x00047C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568837, XrefRangeEnd = 568853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionCounter GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionCounter>(intPtr3) : null;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00049AC8 File Offset: 0x00047CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568853, XrefRangeEnd = 568880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIChoiceSelectionWithTargetsCustomChoice.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00006235 File Offset: 0x00004435
		public AIChoiceSelectionWithTargetsCustomChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x00049B0C File Offset: 0x00047D0C
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x0000623E File Offset: 0x0000443E
		public unsafe AbilityDefinition ability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargetsCustomChoice.NativeFieldInfoPtr_ability);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargetsCustomChoice.NativeFieldInfoPtr_ability), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x00049B3C File Offset: 0x00047D3C
		// (set) Token: 0x06000B5B RID: 2907 RVA: 0x0000625D File Offset: 0x0000445D
		public unsafe List<TargetResponse> response
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargetsCustomChoice.NativeFieldInfoPtr_response);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TargetResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargetsCustomChoice.NativeFieldInfoPtr_response), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x00049B6C File Offset: 0x00047D6C
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x0000627C File Offset: 0x0000447C
		public unsafe SelectionWithTargetsRequired selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargetsCustomChoice.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionWithTargetsRequired>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceSelectionWithTargetsCustomChoice.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x00049B9C File Offset: 0x00047D9C
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x0000629B File Offset: 0x0000449B
		public unsafe static Random Random
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AIChoiceSelectionWithTargetsCustomChoice.NativeFieldInfoPtr_Random, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AIChoiceSelectionWithTargetsCustomChoice.NativeFieldInfoPtr_Random, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeFieldInfoPtr_ability;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeFieldInfoPtr_response;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeFieldInfoPtr_Random;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_AIChoiceContext_Int32_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_Int32_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChoice_Public_Void_Int32_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_DefaultTarget_Public_Void_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetInfo_Public_CustomChoiceTargetInformation_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_Int32_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
