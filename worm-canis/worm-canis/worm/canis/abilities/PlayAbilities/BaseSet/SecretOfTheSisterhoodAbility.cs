using System;
using Canis.entities;
using Canis.gameLogs;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.BaseSet
{
	// Token: 0x02000493 RID: 1171
	public class SecretOfTheSisterhoodAbility : GainInfluenceIntrigueAbility
	{
		// Token: 0x06003451 RID: 13393 RVA: 0x00137F64 File Offset: 0x00136164
		// Note: this type is marked as 'beforefieldinit'.
		static SecretOfTheSisterhoodAbility()
		{
			Il2CppClassPointerStore<SecretOfTheSisterhoodAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.BaseSet", "SecretOfTheSisterhoodAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecretOfTheSisterhoodAbility>.NativeClassPtr);
			SecretOfTheSisterhoodAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretOfTheSisterhoodAbility>.NativeClassPtr, "AbilityName");
			SecretOfTheSisterhoodAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretOfTheSisterhoodAbility>.NativeClassPtr, "AbilityID");
			SecretOfTheSisterhoodAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretOfTheSisterhoodAbility>.NativeClassPtr, 100679786);
			SecretOfTheSisterhoodAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretOfTheSisterhoodAbility>.NativeClassPtr, 100679787);
			SecretOfTheSisterhoodAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretOfTheSisterhoodAbility>.NativeClassPtr, 100679788);
			SecretOfTheSisterhoodAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretOfTheSisterhoodAbility>.NativeClassPtr, 100679789);
			SecretOfTheSisterhoodAbility.NativeMethodInfoPtr_get_SpecifiedFaction_Public_Virtual_get_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretOfTheSisterhoodAbility>.NativeClassPtr, 100679790);
			SecretOfTheSisterhoodAbility.NativeMethodInfoPtr_WillClearUndo_Public_Virtual_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretOfTheSisterhoodAbility>.NativeClassPtr, 100679791);
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x00138034 File Offset: 0x00136234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238966, XrefRangeEnd = 238970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SecretOfTheSisterhoodAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x00138080 File Offset: 0x00136280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238970, XrefRangeEnd = 238976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SecretOfTheSisterhoodAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x001380DC File Offset: 0x001362DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238976, XrefRangeEnd = 238979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecretOfTheSisterhoodAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecretOfTheSisterhoodAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecretOfTheSisterhoodAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x00138128 File Offset: 0x00136328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecretOfTheSisterhoodAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecretOfTheSisterhoodAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecretOfTheSisterhoodAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06003456 RID: 13398 RVA: 0x00138198 File Offset: 0x00136398
		public unsafe override Factions SpecifiedFaction
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SecretOfTheSisterhoodAbility.NativeMethodInfoPtr_get_SpecifiedFaction_Public_Virtual_get_Factions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x001381E0 File Offset: 0x001363E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238979, XrefRangeEnd = 238980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool WillClearUndo(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SecretOfTheSisterhoodAbility.NativeMethodInfoPtr_WillClearUndo_Public_Virtual_Boolean_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x00011EC4 File Offset: 0x000100C4
		public SecretOfTheSisterhoodAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06003459 RID: 13401 RVA: 0x00138238 File Offset: 0x00136438
		// (set) Token: 0x0600345A RID: 13402 RVA: 0x00011ECD File Offset: 0x000100CD
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecretOfTheSisterhoodAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecretOfTheSisterhoodAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x0600345B RID: 13403 RVA: 0x00138258 File Offset: 0x00136458
		// (set) Token: 0x0600345C RID: 13404 RVA: 0x00011EDF File Offset: 0x000100DF
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecretOfTheSisterhoodAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecretOfTheSisterhoodAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002211 RID: 8721
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002212 RID: 8722
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002213 RID: 8723
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002214 RID: 8724
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x04002215 RID: 8725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04002216 RID: 8726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04002217 RID: 8727
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecifiedFaction_Public_Virtual_get_Factions_0;

		// Token: 0x04002218 RID: 8728
		private static readonly IntPtr NativeMethodInfoPtr_WillClearUndo_Public_Virtual_Boolean_WormPlayer_0;
	}
}
