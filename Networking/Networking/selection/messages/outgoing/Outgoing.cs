using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetresponse;

namespace Networking.selection.messages.outgoing
{
	// Token: 0x02000089 RID: 137
	public static class Outgoing : Object
	{
		// Token: 0x0600049A RID: 1178 RVA: 0x00012358 File Offset: 0x00010558
		// Note: this type is marked as 'beforefieldinit'.
		static Outgoing()
		{
			Il2CppClassPointerStore<Outgoing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.messages.outgoing", "Outgoing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Outgoing>.NativeClassPtr);
			Outgoing.NativeMethodInfoPtr_SelectionWithTargets_Public_Static_Object_SelectionMessage_EntityID_IEnumerable_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outgoing>.NativeClassPtr, 100663596);
			Outgoing.NativeMethodInfoPtr_SelectionWithTargetsAndActions_Public_Static_Object_SelectionMessage_EntityID_AbilityID_IEnumerable_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outgoing>.NativeClassPtr, 100663597);
			Outgoing.NativeMethodInfoPtr_GameMulliganChoice_Public_Static_Object_SelectionMessage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outgoing>.NativeClassPtr, 100663598);
			Outgoing.NativeMethodInfoPtr_MultipleSelectionWithTargets_Public_Static_Object_SelectionMessage_IDictionary_2_EntityID_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outgoing>.NativeClassPtr, 100663599);
			Outgoing.NativeMethodInfoPtr_CustomChoice_Public_Static_Object_SelectionMessage_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outgoing>.NativeClassPtr, 100663600);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000123EC File Offset: 0x000105EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194703, XrefRangeEnd = 1194726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600049C RID: 1180 RVA: 0x00012454 File Offset: 0x00010654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194726, XrefRangeEnd = 1194811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600049D RID: 1181 RVA: 0x000124D0 File Offset: 0x000106D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194811, XrefRangeEnd = 1194850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600049E RID: 1182 RVA: 0x00012524 File Offset: 0x00010724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194850, XrefRangeEnd = 1194886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600049F RID: 1183 RVA: 0x0001257C File Offset: 0x0001077C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194886, XrefRangeEnd = 1194924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060004A0 RID: 1184 RVA: 0x00004D7E File Offset: 0x00002F7E
		public Outgoing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_SelectionWithTargets_Public_Static_Object_SelectionMessage_EntityID_IEnumerable_1_TargetResponse_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_SelectionWithTargetsAndActions_Public_Static_Object_SelectionMessage_EntityID_AbilityID_IEnumerable_1_TargetResponse_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_GameMulliganChoice_Public_Static_Object_SelectionMessage_Boolean_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_MultipleSelectionWithTargets_Public_Static_Object_SelectionMessage_IDictionary_2_EntityID_IList_1_EntityID_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_CustomChoice_Public_Static_Object_SelectionMessage_Int32_0;
	}
}
