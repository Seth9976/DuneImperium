using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.abilities.TriggeredAbilities.Skirmish
{
	// Token: 0x0200033D RID: 829
	public class ReturnPermanentChoamShares : ReturnPermanentIntrigue
	{
		// Token: 0x060021CB RID: 8651 RVA: 0x000DE364 File Offset: 0x000DC564
		// Note: this type is marked as 'beforefieldinit'.
		static ReturnPermanentChoamShares()
		{
			Il2CppClassPointerStore<ReturnPermanentChoamShares>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Skirmish", "ReturnPermanentChoamShares");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReturnPermanentChoamShares>.NativeClassPtr);
			ReturnPermanentChoamShares.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnPermanentChoamShares>.NativeClassPtr, "AbilityName");
			ReturnPermanentChoamShares.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnPermanentChoamShares>.NativeClassPtr, "AbilityID");
			ReturnPermanentChoamShares.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnPermanentChoamShares>.NativeClassPtr, 100671835);
			ReturnPermanentChoamShares.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnPermanentChoamShares>.NativeClassPtr, 100671836);
			ReturnPermanentChoamShares.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnPermanentChoamShares>.NativeClassPtr, 100671837);
			ReturnPermanentChoamShares.NativeMethodInfoPtr_get_CardArchetype_Protected_Virtual_get_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnPermanentChoamShares>.NativeClassPtr, 100671838);
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x000DE40C File Offset: 0x000DC60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179165, XrefRangeEnd = 179169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReturnPermanentChoamShares.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x000DE458 File Offset: 0x000DC658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179169, XrefRangeEnd = 179172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnPermanentChoamShares(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReturnPermanentChoamShares>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnPermanentChoamShares.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x000DE4A4 File Offset: 0x000DC6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179172, XrefRangeEnd = 179173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnPermanentChoamShares(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReturnPermanentChoamShares>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnPermanentChoamShares.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x000DE514 File Offset: 0x000DC714
		public unsafe override ArchetypeID CardArchetype
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179173, XrefRangeEnd = 179177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReturnPermanentChoamShares.NativeMethodInfoPtr_get_CardArchetype_Protected_Virtual_get_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x0000DB6C File Offset: 0x0000BD6C
		public ReturnPermanentChoamShares(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x000DE560 File Offset: 0x000DC760
		// (set) Token: 0x060021D2 RID: 8658 RVA: 0x0000DB75 File Offset: 0x0000BD75
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReturnPermanentChoamShares.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReturnPermanentChoamShares.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x000DE580 File Offset: 0x000DC780
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x0000DB87 File Offset: 0x0000BD87
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReturnPermanentChoamShares.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReturnPermanentChoamShares.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400155A RID: 5466
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x0400155B RID: 5467
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeMethodInfoPtr_get_CardArchetype_Protected_Virtual_get_ArchetypeID_0;
	}
}
