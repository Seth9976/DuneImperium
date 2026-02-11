using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Networking.selection.messages.outgoing;
using Networking.selection.targetresponse;

namespace Canis.entities.ai
{
	// Token: 0x020000FB RID: 251
	public class AIChoiceEntityGrouping : AIChoice
	{
		// Token: 0x06000B1A RID: 2842 RVA: 0x00048B70 File Offset: 0x00046D70
		// Note: this type is marked as 'beforefieldinit'.
		static AIChoiceEntityGrouping()
		{
			Il2CppClassPointerStore<AIChoiceEntityGrouping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AIChoiceEntityGrouping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIChoiceEntityGrouping>.NativeClassPtr);
			AIChoiceEntityGrouping.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceEntityGrouping>.NativeClassPtr, "response");
			AIChoiceEntityGrouping.NativeFieldInfoPtr_ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIChoiceEntityGrouping>.NativeClassPtr, "ability");
			AIChoiceEntityGrouping.NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_AIChoiceContext_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceEntityGrouping>.NativeClassPtr, 100665708);
			AIChoiceEntityGrouping.NativeMethodInfoPtr_SetTarget_Public_Void_Il2CppReferenceArray_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceEntityGrouping>.NativeClassPtr, 100665709);
			AIChoiceEntityGrouping.NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceEntityGrouping>.NativeClassPtr, 100665710);
			AIChoiceEntityGrouping.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIChoiceEntityGrouping>.NativeClassPtr, 100665711);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00048C18 File Offset: 0x00046E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568335, XrefRangeEnd = 568341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIChoiceEntityGrouping(AbilityDefinition ability, AIChoiceContext c, int r)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIChoiceEntityGrouping>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceEntityGrouping.NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_AIChoiceContext_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00048C84 File Offset: 0x00046E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568341, XrefRangeEnd = 568346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTarget(Il2CppReferenceArray<EntityID> responses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(responses);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIChoiceEntityGrouping.NativeMethodInfoPtr_SetTarget_Public_Void_Il2CppReferenceArray_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00048CC8 File Offset: 0x00046EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568346, XrefRangeEnd = 568356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionCounter GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIChoiceEntityGrouping.NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionCounter>(intPtr3) : null;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00048D14 File Offset: 0x00046F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568356, XrefRangeEnd = 568376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIChoiceEntityGrouping.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x000060DF File Offset: 0x000042DF
		public AIChoiceEntityGrouping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00048D58 File Offset: 0x00046F58
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x000060E8 File Offset: 0x000042E8
		public unsafe EntityListTargetResponse response
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceEntityGrouping.NativeFieldInfoPtr_response);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityListTargetResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceEntityGrouping.NativeFieldInfoPtr_response), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x00048D88 File Offset: 0x00046F88
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x00006107 File Offset: 0x00004307
		public unsafe AbilityDefinition ability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceEntityGrouping.NativeFieldInfoPtr_ability);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIChoiceEntityGrouping.NativeFieldInfoPtr_ability), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeFieldInfoPtr_response;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeFieldInfoPtr_ability;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AbilityDefinition_AIChoiceContext_Int32_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_Il2CppReferenceArray_1_EntityID_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
