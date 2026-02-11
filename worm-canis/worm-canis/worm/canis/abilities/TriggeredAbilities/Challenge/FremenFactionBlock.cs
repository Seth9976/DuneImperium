using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.data.enums;

namespace worm.canis.abilities.TriggeredAbilities.Challenge
{
	// Token: 0x02000389 RID: 905
	public class FremenFactionBlock : FactionBlock
	{
		// Token: 0x060025BD RID: 9661 RVA: 0x000F1214 File Offset: 0x000EF414
		// Note: this type is marked as 'beforefieldinit'.
		static FremenFactionBlock()
		{
			Il2CppClassPointerStore<FremenFactionBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Challenge", "FremenFactionBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FremenFactionBlock>.NativeClassPtr);
			FremenFactionBlock.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FremenFactionBlock>.NativeClassPtr, "AbilityName");
			FremenFactionBlock.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FremenFactionBlock>.NativeClassPtr, "AbilityID");
			FremenFactionBlock.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FremenFactionBlock>.NativeClassPtr, 100673722);
			FremenFactionBlock.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FremenFactionBlock>.NativeClassPtr, 100673723);
			FremenFactionBlock.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FremenFactionBlock>.NativeClassPtr, 100673724);
			FremenFactionBlock.NativeMethodInfoPtr_get_SpecifiedFaction_Public_Virtual_get_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FremenFactionBlock>.NativeClassPtr, 100673725);
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x000F12BC File Offset: 0x000EF4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190268, XrefRangeEnd = 190272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FremenFactionBlock.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x000F1308 File Offset: 0x000EF508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190272, XrefRangeEnd = 190275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FremenFactionBlock(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FremenFactionBlock>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FremenFactionBlock.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x000F1354 File Offset: 0x000EF554
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FremenFactionBlock(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FremenFactionBlock>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FremenFactionBlock.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060025C1 RID: 9665 RVA: 0x000F13C4 File Offset: 0x000EF5C4
		public unsafe override Factions SpecifiedFaction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FremenFactionBlock.NativeMethodInfoPtr_get_SpecifiedFaction_Public_Virtual_get_Factions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x0000E91D File Offset: 0x0000CB1D
		public FremenFactionBlock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x060025C3 RID: 9667 RVA: 0x000F140C File Offset: 0x000EF60C
		// (set) Token: 0x060025C4 RID: 9668 RVA: 0x0000E926 File Offset: 0x0000CB26
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FremenFactionBlock.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FremenFactionBlock.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x000F142C File Offset: 0x000EF62C
		// (set) Token: 0x060025C6 RID: 9670 RVA: 0x0000E938 File Offset: 0x0000CB38
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FremenFactionBlock.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FremenFactionBlock.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001815 RID: 6165
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001816 RID: 6166
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001817 RID: 6167
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecifiedFaction_Public_Virtual_get_Factions_0;
	}
}
