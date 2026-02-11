using System;
using Canis.entities;
using Canis.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.abilities.TriggeredAbilities.Challenge
{
	// Token: 0x02000393 RID: 915
	public class RoundEndReplaceImperiumRow : ReplaceImperiumRow
	{
		// Token: 0x06002624 RID: 9764 RVA: 0x000F2E70 File Offset: 0x000F1070
		// Note: this type is marked as 'beforefieldinit'.
		static RoundEndReplaceImperiumRow()
		{
			Il2CppClassPointerStore<RoundEndReplaceImperiumRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Challenge", "RoundEndReplaceImperiumRow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundEndReplaceImperiumRow>.NativeClassPtr);
			RoundEndReplaceImperiumRow.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundEndReplaceImperiumRow>.NativeClassPtr, "AbilityName");
			RoundEndReplaceImperiumRow.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundEndReplaceImperiumRow>.NativeClassPtr, "AbilityID");
			RoundEndReplaceImperiumRow.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndReplaceImperiumRow>.NativeClassPtr, 100673928);
			RoundEndReplaceImperiumRow.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndReplaceImperiumRow>.NativeClassPtr, 100673929);
			RoundEndReplaceImperiumRow.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndReplaceImperiumRow>.NativeClassPtr, 100673930);
			RoundEndReplaceImperiumRow.NativeMethodInfoPtr_get_TriggeringEvent_Protected_Virtual_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndReplaceImperiumRow>.NativeClassPtr, 100673931);
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x000F2F18 File Offset: 0x000F1118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191254, XrefRangeEnd = 191258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoundEndReplaceImperiumRow.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x000F2F64 File Offset: 0x000F1164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191258, XrefRangeEnd = 191261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoundEndReplaceImperiumRow(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundEndReplaceImperiumRow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndReplaceImperiumRow.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x000F2FB0 File Offset: 0x000F11B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoundEndReplaceImperiumRow(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundEndReplaceImperiumRow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndReplaceImperiumRow.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x000F3020 File Offset: 0x000F1220
		public unsafe override SerializableEvent TriggeringEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191261, XrefRangeEnd = 191262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoundEndReplaceImperiumRow.NativeMethodInfoPtr_get_TriggeringEvent_Protected_Virtual_get_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x0000EA97 File Offset: 0x0000CC97
		public RoundEndReplaceImperiumRow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x000F306C File Offset: 0x000F126C
		// (set) Token: 0x0600262B RID: 9771 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RoundEndReplaceImperiumRow.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RoundEndReplaceImperiumRow.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x000F308C File Offset: 0x000F128C
		// (set) Token: 0x0600262D RID: 9773 RVA: 0x0000EAB2 File Offset: 0x0000CCB2
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RoundEndReplaceImperiumRow.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RoundEndReplaceImperiumRow.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeMethodInfoPtr_get_TriggeringEvent_Protected_Virtual_get_SerializableEvent_0;
	}
}
