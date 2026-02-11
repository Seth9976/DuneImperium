using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;
using Networking.selection.targetresponse;

namespace dwd.core.match.selection.messages
{
	// Token: 0x0200015C RID: 348
	public static class Outgoing : Object
	{
		// Token: 0x06001488 RID: 5256 RVA: 0x00066A0C File Offset: 0x00064C0C
		// Note: this type is marked as 'beforefieldinit'.
		static Outgoing()
		{
			Il2CppClassPointerStore<Outgoing>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection.messages", "Outgoing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Outgoing>.NativeClassPtr);
			Outgoing.NativeMethodInfoPtr_SelectionWithTargets_Public_Static_Object_SelectionMessage_EntityID_IEnumerable_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outgoing>.NativeClassPtr, 100666401);
			Outgoing.NativeMethodInfoPtr_SelectionWithTargetsAndActions_Public_Static_Object_SelectionMessage_EntityID_AbilityID_IEnumerable_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outgoing>.NativeClassPtr, 100666402);
			Outgoing.NativeMethodInfoPtr_GameMulliganChoice_Public_Static_Object_SelectionMessage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outgoing>.NativeClassPtr, 100666403);
			Outgoing.NativeMethodInfoPtr_MultipleSelectionWithTargets_Public_Static_Object_SelectionMessage_IDictionary_2_EntityID_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outgoing>.NativeClassPtr, 100666404);
			Outgoing.NativeMethodInfoPtr_CustomChoice_Public_Static_Object_SelectionMessage_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outgoing>.NativeClassPtr, 100666405);
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00066AA0 File Offset: 0x00064CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874769, XrefRangeEnd = 874773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object SelectionWithTargets(SelectionMessage message, EntityID entityID, IEnumerable<TargetResponse> targetResponses)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetResponses);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Outgoing.NativeMethodInfoPtr_SelectionWithTargets_Public_Static_Object_SelectionMessage_EntityID_IEnumerable_1_TargetResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00066B08 File Offset: 0x00064D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 874862, RefRangeEnd = 874863, XrefRangeStart = 874773, XrefRangeEnd = 874862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object SelectionWithTargetsAndActions(SelectionMessage message, EntityID entityID, AbilityID abilityID, IEnumerable<TargetResponse> targets)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abilityID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targets);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Outgoing.NativeMethodInfoPtr_SelectionWithTargetsAndActions_Public_Static_Object_SelectionMessage_EntityID_AbilityID_IEnumerable_1_TargetResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00066B84 File Offset: 0x00064D84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 874902, RefRangeEnd = 874903, XrefRangeStart = 874863, XrefRangeEnd = 874902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GameMulliganChoice(SelectionMessage message, bool mulligan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mulligan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Outgoing.NativeMethodInfoPtr_GameMulliganChoice_Public_Static_Object_SelectionMessage_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00066BD8 File Offset: 0x00064DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 874939, RefRangeEnd = 874940, XrefRangeStart = 874903, XrefRangeEnd = 874939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object MultipleSelectionWithTargets(SelectionMessage message, IDictionary<EntityID, IList<EntityID>> targets)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targets);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Outgoing.NativeMethodInfoPtr_MultipleSelectionWithTargets_Public_Static_Object_SelectionMessage_IDictionary_2_EntityID_IList_1_EntityID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00066C30 File Offset: 0x00064E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874940, XrefRangeEnd = 874978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CustomChoice(SelectionMessage message, int choice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref choice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Outgoing.NativeMethodInfoPtr_CustomChoice_Public_Static_Object_SelectionMessage_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x000090EF File Offset: 0x000072EF
		public Outgoing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeMethodInfoPtr_SelectionWithTargets_Public_Static_Object_SelectionMessage_EntityID_IEnumerable_1_TargetResponse_0;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr_SelectionWithTargetsAndActions_Public_Static_Object_SelectionMessage_EntityID_AbilityID_IEnumerable_1_TargetResponse_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr_GameMulliganChoice_Public_Static_Object_SelectionMessage_Boolean_0;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeMethodInfoPtr_MultipleSelectionWithTargets_Public_Static_Object_SelectionMessage_IDictionary_2_EntityID_IList_1_EntityID_0;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr_CustomChoice_Public_Static_Object_SelectionMessage_Int32_0;
	}
}
