using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.data.enums;

namespace worm.canis.abilities.TriggeredAbilities.Skirmish
{
	// Token: 0x02000338 RID: 824
	public class ReduceBeneGesseritPersuasionCost : ReducePersuasionCost
	{
		// Token: 0x06002196 RID: 8598 RVA: 0x000DD4C0 File Offset: 0x000DB6C0
		// Note: this type is marked as 'beforefieldinit'.
		static ReduceBeneGesseritPersuasionCost()
		{
			Il2CppClassPointerStore<ReduceBeneGesseritPersuasionCost>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Skirmish", "ReduceBeneGesseritPersuasionCost");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReduceBeneGesseritPersuasionCost>.NativeClassPtr);
			ReduceBeneGesseritPersuasionCost.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReduceBeneGesseritPersuasionCost>.NativeClassPtr, "AbilityName");
			ReduceBeneGesseritPersuasionCost.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReduceBeneGesseritPersuasionCost>.NativeClassPtr, "AbilityID");
			ReduceBeneGesseritPersuasionCost.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReduceBeneGesseritPersuasionCost>.NativeClassPtr, 100671754);
			ReduceBeneGesseritPersuasionCost.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReduceBeneGesseritPersuasionCost>.NativeClassPtr, 100671755);
			ReduceBeneGesseritPersuasionCost.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReduceBeneGesseritPersuasionCost>.NativeClassPtr, 100671756);
			ReduceBeneGesseritPersuasionCost.NativeMethodInfoPtr_get_ToCardsOfFaction_Protected_Virtual_get_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReduceBeneGesseritPersuasionCost>.NativeClassPtr, 100671757);
			ReduceBeneGesseritPersuasionCost.NativeMethodInfoPtr_get_Amount_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReduceBeneGesseritPersuasionCost>.NativeClassPtr, 100671758);
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x000DD57C File Offset: 0x000DB77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178841, XrefRangeEnd = 178845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReduceBeneGesseritPersuasionCost.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x000DD5C8 File Offset: 0x000DB7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178845, XrefRangeEnd = 178848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReduceBeneGesseritPersuasionCost(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReduceBeneGesseritPersuasionCost>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReduceBeneGesseritPersuasionCost.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x000DD614 File Offset: 0x000DB814
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176275, XrefRangeEnd = 176589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReduceBeneGesseritPersuasionCost(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReduceBeneGesseritPersuasionCost>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReduceBeneGesseritPersuasionCost.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x000DD684 File Offset: 0x000DB884
		public unsafe override Factions ToCardsOfFaction
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReduceBeneGesseritPersuasionCost.NativeMethodInfoPtr_get_ToCardsOfFaction_Protected_Virtual_get_Factions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x0600219B RID: 8603 RVA: 0x000DD6CC File Offset: 0x000DB8CC
		public unsafe override int Amount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReduceBeneGesseritPersuasionCost.NativeMethodInfoPtr_get_Amount_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x0000DA95 File Offset: 0x0000BC95
		public ReduceBeneGesseritPersuasionCost(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x000DD714 File Offset: 0x000DB914
		// (set) Token: 0x0600219E RID: 8606 RVA: 0x0000DA9E File Offset: 0x0000BC9E
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReduceBeneGesseritPersuasionCost.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReduceBeneGesseritPersuasionCost.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x0600219F RID: 8607 RVA: 0x000DD734 File Offset: 0x000DB934
		// (set) Token: 0x060021A0 RID: 8608 RVA: 0x0000DAB0 File Offset: 0x0000BCB0
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReduceBeneGesseritPersuasionCost.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReduceBeneGesseritPersuasionCost.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr_get_ToCardsOfFaction_Protected_Virtual_get_Factions_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_get_Amount_Protected_Virtual_get_Int32_0;
	}
}
