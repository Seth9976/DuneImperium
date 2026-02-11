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
	// Token: 0x0200032F RID: 815
	public class DoubleBeneGesseritCards : DoubleFactionCardCounts
	{
		// Token: 0x06002133 RID: 8499 RVA: 0x000DBB00 File Offset: 0x000D9D00
		// Note: this type is marked as 'beforefieldinit'.
		static DoubleBeneGesseritCards()
		{
			Il2CppClassPointerStore<DoubleBeneGesseritCards>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Skirmish", "DoubleBeneGesseritCards");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleBeneGesseritCards>.NativeClassPtr);
			DoubleBeneGesseritCards.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleBeneGesseritCards>.NativeClassPtr, "AbilityName");
			DoubleBeneGesseritCards.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleBeneGesseritCards>.NativeClassPtr, "AbilityID");
			DoubleBeneGesseritCards.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleBeneGesseritCards>.NativeClassPtr, 100671573);
			DoubleBeneGesseritCards.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleBeneGesseritCards>.NativeClassPtr, 100671574);
			DoubleBeneGesseritCards.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleBeneGesseritCards>.NativeClassPtr, 100671575);
			DoubleBeneGesseritCards.NativeMethodInfoPtr_get_ToCardsOfFaction_Protected_Virtual_get_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleBeneGesseritCards>.NativeClassPtr, 100671576);
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x000DBBA8 File Offset: 0x000D9DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178002, XrefRangeEnd = 178006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleBeneGesseritCards.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x000DBBF4 File Offset: 0x000D9DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178006, XrefRangeEnd = 178009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleBeneGesseritCards(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleBeneGesseritCards>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleBeneGesseritCards.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x000DBC40 File Offset: 0x000D9E40
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176275, XrefRangeEnd = 176589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleBeneGesseritCards(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleBeneGesseritCards>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleBeneGesseritCards.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x000DBCB0 File Offset: 0x000D9EB0
		public unsafe override Factions ToCardsOfFaction
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleBeneGesseritCards.NativeMethodInfoPtr_get_ToCardsOfFaction_Protected_Virtual_get_Factions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x0000D8EE File Offset: 0x0000BAEE
		public DoubleBeneGesseritCards(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x000DBCF8 File Offset: 0x000D9EF8
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x0000D8F7 File Offset: 0x0000BAF7
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DoubleBeneGesseritCards.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoubleBeneGesseritCards.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x000DBD18 File Offset: 0x000D9F18
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x0000D909 File Offset: 0x0000BB09
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DoubleBeneGesseritCards.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoubleBeneGesseritCards.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeMethodInfoPtr_get_ToCardsOfFaction_Protected_Virtual_get_Factions_0;
	}
}
