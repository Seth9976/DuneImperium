using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.abilities.TriggeredAbilities.Skirmish
{
	// Token: 0x02000326 RID: 806
	public class AddPermanentSleeperMustAwaken : AddPermanentIntrigue
	{
		// Token: 0x060020D4 RID: 8404 RVA: 0x000DA184 File Offset: 0x000D8384
		// Note: this type is marked as 'beforefieldinit'.
		static AddPermanentSleeperMustAwaken()
		{
			Il2CppClassPointerStore<AddPermanentSleeperMustAwaken>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Skirmish", "AddPermanentSleeperMustAwaken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddPermanentSleeperMustAwaken>.NativeClassPtr);
			AddPermanentSleeperMustAwaken.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPermanentSleeperMustAwaken>.NativeClassPtr, "AbilityName");
			AddPermanentSleeperMustAwaken.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddPermanentSleeperMustAwaken>.NativeClassPtr, "AbilityID");
			AddPermanentSleeperMustAwaken.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentSleeperMustAwaken>.NativeClassPtr, 100671404);
			AddPermanentSleeperMustAwaken.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentSleeperMustAwaken>.NativeClassPtr, 100671405);
			AddPermanentSleeperMustAwaken.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentSleeperMustAwaken>.NativeClassPtr, 100671406);
			AddPermanentSleeperMustAwaken.NativeMethodInfoPtr_get_CardArchetype_Protected_Virtual_get_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPermanentSleeperMustAwaken>.NativeClassPtr, 100671407);
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x000DA22C File Offset: 0x000D842C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177219, XrefRangeEnd = 177223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddPermanentSleeperMustAwaken.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x000DA278 File Offset: 0x000D8478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177223, XrefRangeEnd = 177226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddPermanentSleeperMustAwaken(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddPermanentSleeperMustAwaken>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPermanentSleeperMustAwaken.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x000DA2C4 File Offset: 0x000D84C4
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176275, XrefRangeEnd = 176589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddPermanentSleeperMustAwaken(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddPermanentSleeperMustAwaken>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddPermanentSleeperMustAwaken.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x000DA334 File Offset: 0x000D8534
		public unsafe override ArchetypeID CardArchetype
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177226, XrefRangeEnd = 177230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddPermanentSleeperMustAwaken.NativeMethodInfoPtr_get_CardArchetype_Protected_Virtual_get_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x0000D76B File Offset: 0x0000B96B
		public AddPermanentSleeperMustAwaken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x000DA380 File Offset: 0x000D8580
		// (set) Token: 0x060020DB RID: 8411 RVA: 0x0000D774 File Offset: 0x0000B974
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddPermanentSleeperMustAwaken.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddPermanentSleeperMustAwaken.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x000DA3A0 File Offset: 0x000D85A0
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x0000D786 File Offset: 0x0000B986
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddPermanentSleeperMustAwaken.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddPermanentSleeperMustAwaken.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeMethodInfoPtr_get_CardArchetype_Protected_Virtual_get_ArchetypeID_0;
	}
}
