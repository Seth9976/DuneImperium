using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.ui.prompt
{
	// Token: 0x0200000B RID: 11
	public class ScopedPrompter : MonoBehaviour
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00005458 File Offset: 0x00003658
		// Note: this type is marked as 'beforefieldinit'.
		static ScopedPrompter()
		{
			Il2CppClassPointerStore<ScopedPrompter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt", "ScopedPrompter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScopedPrompter>.NativeClassPtr);
			ScopedPrompter.NativeFieldInfoPtr_allowNoScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopedPrompter>.NativeClassPtr, "allowNoScope");
			ScopedPrompter.NativeFieldInfoPtr_scopes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopedPrompter>.NativeClassPtr, "scopes");
			ScopedPrompter.NativeMethodInfoPtr_get_IsPrompting_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedPrompter>.NativeClassPtr, 100663351);
			ScopedPrompter.NativeMethodInfoPtr_get_CurrentPrompt_Public_Abstract_Virtual_New_get_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedPrompter>.NativeClassPtr, 100663352);
			ScopedPrompter.NativeMethodInfoPtr_GetScopes_Public_List_1_ModalScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedPrompter>.NativeClassPtr, 100663353);
			ScopedPrompter.NativeMethodInfoPtr_HandlesScope_Public_Virtual_Final_New_Boolean_ModalScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedPrompter>.NativeClassPtr, 100663354);
			ScopedPrompter.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedPrompter>.NativeClassPtr, 100663355);
			ScopedPrompter.NativeMethodInfoPtr_Prompt_Public_Abstract_Virtual_New_IEnumerator_IPrompt_ScopedPromptDisplayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedPrompter>.NativeClassPtr, 100663356);
			ScopedPrompter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedPrompter>.NativeClassPtr, 100663357);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000553C File Offset: 0x0000373C
		public unsafe virtual bool IsPrompting
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1213408, RefRangeEnd = 1213410, XrefRangeStart = 1213408, XrefRangeEnd = 1213408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopedPrompter.NativeMethodInfoPtr_get_IsPrompting_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00005578 File Offset: 0x00003778
		public unsafe virtual IPrompt CurrentPrompt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScopedPrompter.NativeMethodInfoPtr_get_CurrentPrompt_Public_Abstract_Virtual_New_get_IPrompt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPrompt>(intPtr3) : null;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000055C4 File Offset: 0x000037C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ModalScope> GetScopes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopedPrompter.NativeMethodInfoPtr_GetScopes_Public_List_1_ModalScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ModalScope>>(intPtr3) : null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005604 File Offset: 0x00003804
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1213417, RefRangeEnd = 1213419, XrefRangeStart = 1213410, XrefRangeEnd = 1213417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HandlesScope(ModalScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scope);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopedPrompter.NativeMethodInfoPtr_HandlesScope_Public_Virtual_Final_New_Boolean_ModalScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00005654 File Offset: 0x00003854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213419, XrefRangeEnd = 1213439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopedPrompter.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00005688 File Offset: 0x00003888
		[CallerCount(0)]
		public unsafe virtual IEnumerator Prompt(IPrompt prompt, ScopedPromptDisplayData displayData = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prompt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(displayData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScopedPrompter.NativeMethodInfoPtr_Prompt_Public_Abstract_Virtual_New_IEnumerator_IPrompt_ScopedPromptDisplayData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000056F8 File Offset: 0x000038F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213439, XrefRangeEnd = 1213447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScopedPrompter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScopedPrompter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopedPrompter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002360 File Offset: 0x00000560
		public ScopedPrompter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00005734 File Offset: 0x00003934
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002369 File Offset: 0x00000569
		public unsafe bool allowNoScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedPrompter.NativeFieldInfoPtr_allowNoScope);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedPrompter.NativeFieldInfoPtr_allowNoScope)) = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000575C File Offset: 0x0000395C
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002384 File Offset: 0x00000584
		public unsafe List<ModalScope> scopes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedPrompter.NativeFieldInfoPtr_scopes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ModalScope>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedPrompter.NativeFieldInfoPtr_scopes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_allowNoScope;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_scopes;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPrompting_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPrompt_Public_Abstract_Virtual_New_get_IPrompt_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_GetScopes_Public_List_1_ModalScope_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_HandlesScope_Public_Virtual_Final_New_Boolean_ModalScope_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_Prompt_Public_Abstract_Virtual_New_IEnumerator_IPrompt_ScopedPromptDisplayData_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
