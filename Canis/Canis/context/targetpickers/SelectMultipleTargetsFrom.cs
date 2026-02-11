using System;
using Canis.actions;
using Canis.actions.responseparsers;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;
using Networking.selection.messages.outgoing;

namespace Canis.context.targetpickers
{
	// Token: 0x02000123 RID: 291
	public class SelectMultipleTargetsFrom : TargetPicker<List<EntityIDEntityTargetsResponse>>
	{
		// Token: 0x06000D88 RID: 3464 RVA: 0x0005330C File Offset: 0x0005150C
		// Note: this type is marked as 'beforefieldinit'.
		static SelectMultipleTargetsFrom()
		{
			Il2CppClassPointerStore<SelectMultipleTargetsFrom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.targetpickers", "SelectMultipleTargetsFrom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectMultipleTargetsFrom>.NativeClassPtr);
			SelectMultipleTargetsFrom.NativeFieldInfoPtr_targetMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectMultipleTargetsFrom>.NativeClassPtr, "targetMap");
			SelectMultipleTargetsFrom.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectMultipleTargetsFrom>.NativeClassPtr, "forced");
			SelectMultipleTargetsFrom.NativeFieldInfoPtr_forcedTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectMultipleTargetsFrom>.NativeClassPtr, "forcedTargets");
			SelectMultipleTargetsFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_EntityID_MultipleTargetInformation_Match_Boolean_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectMultipleTargetsFrom>.NativeClassPtr, 100666319);
			SelectMultipleTargetsFrom.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_List_1_EntityIDEntityTargetsResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectMultipleTargetsFrom>.NativeClassPtr, 100666320);
			SelectMultipleTargetsFrom.NativeMethodInfoPtr_GetSelectionMessage_Public_Virtual_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectMultipleTargetsFrom>.NativeClassPtr, 100666321);
			SelectMultipleTargetsFrom.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectMultipleTargetsFrom>.NativeClassPtr, 100666322);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x000533C8 File Offset: 0x000515C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576664, XrefRangeEnd = 576690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectMultipleTargetsFrom(Dictionary<EntityID, MultipleTargetInformation> targetMap, Match m, bool forced = true, List<EntityID> forcedTargets = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectMultipleTargetsFrom>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forcedTargets);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectMultipleTargetsFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_EntityID_MultipleTargetInformation_Match_Boolean_List_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x00053448 File Offset: 0x00051648
		public unsafe override ResponseParser<List<EntityIDEntityTargetsResponse>> responseParser
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576690, XrefRangeEnd = 576694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectMultipleTargetsFrom.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_List_1_EntityIDEntityTargetsResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseParser<List<EntityIDEntityTargetsResponse>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00053494 File Offset: 0x00051694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576694, XrefRangeEnd = 576714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionMessage GetSelectionMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectMultipleTargetsFrom.NativeMethodInfoPtr_GetSelectionMessage_Public_Virtual_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr3) : null;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x000534E0 File Offset: 0x000516E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576714, XrefRangeEnd = 576723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionRequest PickTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectMultipleTargetsFrom.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRequest>(intPtr3) : null;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00006E44 File Offset: 0x00005044
		public SelectMultipleTargetsFrom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x0005352C File Offset: 0x0005172C
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x00006E4D File Offset: 0x0000504D
		public unsafe Dictionary<EntityID, MultipleTargetInformation> targetMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectMultipleTargetsFrom.NativeFieldInfoPtr_targetMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, MultipleTargetInformation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectMultipleTargetsFrom.NativeFieldInfoPtr_targetMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x0005355C File Offset: 0x0005175C
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x00006E6C File Offset: 0x0000506C
		public unsafe bool forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectMultipleTargetsFrom.NativeFieldInfoPtr_forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectMultipleTargetsFrom.NativeFieldInfoPtr_forced)) = value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x00053584 File Offset: 0x00051784
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x00006E87 File Offset: 0x00005087
		public unsafe List<EntityID> forcedTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectMultipleTargetsFrom.NativeFieldInfoPtr_forcedTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectMultipleTargetsFrom.NativeFieldInfoPtr_forcedTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeFieldInfoPtr_targetMap;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeFieldInfoPtr_forced;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeFieldInfoPtr_forcedTargets;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_EntityID_MultipleTargetInformation_Match_Boolean_List_1_EntityID_0;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_List_1_EntityIDEntityTargetsResponse_0;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionMessage_Public_Virtual_SelectionMessage_0;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0;
	}
}
