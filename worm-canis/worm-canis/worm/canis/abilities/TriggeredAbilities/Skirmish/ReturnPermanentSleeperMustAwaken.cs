using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.abilities.TriggeredAbilities.Skirmish
{
	// Token: 0x0200033E RID: 830
	public class ReturnPermanentSleeperMustAwaken : ReturnPermanentIntrigue
	{
		// Token: 0x060021D5 RID: 8661 RVA: 0x000DE5A8 File Offset: 0x000DC7A8
		// Note: this type is marked as 'beforefieldinit'.
		static ReturnPermanentSleeperMustAwaken()
		{
			Il2CppClassPointerStore<ReturnPermanentSleeperMustAwaken>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Skirmish", "ReturnPermanentSleeperMustAwaken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReturnPermanentSleeperMustAwaken>.NativeClassPtr);
			ReturnPermanentSleeperMustAwaken.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnPermanentSleeperMustAwaken>.NativeClassPtr, "AbilityName");
			ReturnPermanentSleeperMustAwaken.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnPermanentSleeperMustAwaken>.NativeClassPtr, "AbilityID");
			ReturnPermanentSleeperMustAwaken.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnPermanentSleeperMustAwaken>.NativeClassPtr, 100671840);
			ReturnPermanentSleeperMustAwaken.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnPermanentSleeperMustAwaken>.NativeClassPtr, 100671841);
			ReturnPermanentSleeperMustAwaken.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnPermanentSleeperMustAwaken>.NativeClassPtr, 100671842);
			ReturnPermanentSleeperMustAwaken.NativeMethodInfoPtr_get_CardArchetype_Protected_Virtual_get_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnPermanentSleeperMustAwaken>.NativeClassPtr, 100671843);
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x000DE650 File Offset: 0x000DC850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179177, XrefRangeEnd = 179181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReturnPermanentSleeperMustAwaken.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x000DE69C File Offset: 0x000DC89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179181, XrefRangeEnd = 179184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnPermanentSleeperMustAwaken(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReturnPermanentSleeperMustAwaken>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnPermanentSleeperMustAwaken.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x000DE6E8 File Offset: 0x000DC8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnPermanentSleeperMustAwaken(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReturnPermanentSleeperMustAwaken>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnPermanentSleeperMustAwaken.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x000DE758 File Offset: 0x000DC958
		public unsafe override ArchetypeID CardArchetype
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179184, XrefRangeEnd = 179188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReturnPermanentSleeperMustAwaken.NativeMethodInfoPtr_get_CardArchetype_Protected_Virtual_get_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x0000DB99 File Offset: 0x0000BD99
		public ReturnPermanentSleeperMustAwaken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x000DE7A4 File Offset: 0x000DC9A4
		// (set) Token: 0x060021DC RID: 8668 RVA: 0x0000DBA2 File Offset: 0x0000BDA2
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReturnPermanentSleeperMustAwaken.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReturnPermanentSleeperMustAwaken.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x000DE7C4 File Offset: 0x000DC9C4
		// (set) Token: 0x060021DE RID: 8670 RVA: 0x0000DBB4 File Offset: 0x0000BDB4
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReturnPermanentSleeperMustAwaken.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReturnPermanentSleeperMustAwaken.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeMethodInfoPtr_get_CardArchetype_Protected_Virtual_get_ArchetypeID_0;
	}
}
