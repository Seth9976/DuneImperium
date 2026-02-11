using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.data.enums;

namespace worm.canis.abilities.ActivatedAbilities.Skirmish
{
	// Token: 0x020004BC RID: 1212
	public class AcquireFremenTrashCard : AcquireFactionTrashCard
	{
		// Token: 0x0600368E RID: 13966 RVA: 0x001434DC File Offset: 0x001416DC
		// Note: this type is marked as 'beforefieldinit'.
		static AcquireFremenTrashCard()
		{
			Il2CppClassPointerStore<AcquireFremenTrashCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.Skirmish", "AcquireFremenTrashCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcquireFremenTrashCard>.NativeClassPtr);
			AcquireFremenTrashCard.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireFremenTrashCard>.NativeClassPtr, "AbilityName");
			AcquireFremenTrashCard.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireFremenTrashCard>.NativeClassPtr, "AbilityID");
			AcquireFremenTrashCard.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireFremenTrashCard>.NativeClassPtr, 100680575);
			AcquireFremenTrashCard.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireFremenTrashCard>.NativeClassPtr, 100680576);
			AcquireFremenTrashCard.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireFremenTrashCard>.NativeClassPtr, 100680577);
			AcquireFremenTrashCard.NativeMethodInfoPtr_get_SpecifiedFaction_Public_Virtual_get_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireFremenTrashCard>.NativeClassPtr, 100680578);
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x00143584 File Offset: 0x00141784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244916, XrefRangeEnd = 244920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AcquireFremenTrashCard.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x001435D0 File Offset: 0x001417D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244920, XrefRangeEnd = 244923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AcquireFremenTrashCard(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AcquireFremenTrashCard>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireFremenTrashCard.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x0014361C File Offset: 0x0014181C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AcquireFremenTrashCard(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AcquireFremenTrashCard>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireFremenTrashCard.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06003692 RID: 13970 RVA: 0x0014368C File Offset: 0x0014188C
		public unsafe override Factions SpecifiedFaction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AcquireFremenTrashCard.NativeMethodInfoPtr_get_SpecifiedFaction_Public_Virtual_get_Factions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x000125E6 File Offset: 0x000107E6
		public AcquireFremenTrashCard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06003694 RID: 13972 RVA: 0x001436D4 File Offset: 0x001418D4
		// (set) Token: 0x06003695 RID: 13973 RVA: 0x000125EF File Offset: 0x000107EF
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AcquireFremenTrashCard.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AcquireFremenTrashCard.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06003696 RID: 13974 RVA: 0x001436F4 File Offset: 0x001418F4
		// (set) Token: 0x06003697 RID: 13975 RVA: 0x00012601 File Offset: 0x00010801
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AcquireFremenTrashCard.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AcquireFremenTrashCard.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023A9 RID: 9129
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040023AA RID: 9130
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040023AB RID: 9131
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040023AC RID: 9132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040023AD RID: 9133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040023AE RID: 9134
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecifiedFaction_Public_Virtual_get_Factions_0;
	}
}
