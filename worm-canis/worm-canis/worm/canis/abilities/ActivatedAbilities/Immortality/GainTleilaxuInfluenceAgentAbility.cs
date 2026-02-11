using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.abilities.ActivatedAbilities.Immortality
{
	// Token: 0x02000510 RID: 1296
	public class GainTleilaxuInfluenceAgentAbility : GainTleilaxuInfluenceAbility
	{
		// Token: 0x06003C02 RID: 15362 RVA: 0x0015FE1C File Offset: 0x0015E01C
		// Note: this type is marked as 'beforefieldinit'.
		static GainTleilaxuInfluenceAgentAbility()
		{
			Il2CppClassPointerStore<GainTleilaxuInfluenceAgentAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.Immortality", "GainTleilaxuInfluenceAgentAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainTleilaxuInfluenceAgentAbility>.NativeClassPtr);
			GainTleilaxuInfluenceAgentAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluenceAgentAbility>.NativeClassPtr, "AbilityName");
			GainTleilaxuInfluenceAgentAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluenceAgentAbility>.NativeClassPtr, "AbilityID");
			GainTleilaxuInfluenceAgentAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluenceAgentAbility>.NativeClassPtr, 100682867);
			GainTleilaxuInfluenceAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluenceAgentAbility>.NativeClassPtr, 100682868);
			GainTleilaxuInfluenceAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluenceAgentAbility>.NativeClassPtr, 100682869);
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x0015FEB0 File Offset: 0x0015E0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265578, XrefRangeEnd = 265582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainTleilaxuInfluenceAgentAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x0015FEFC File Offset: 0x0015E0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265582, XrefRangeEnd = 265595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainTleilaxuInfluenceAgentAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainTleilaxuInfluenceAgentAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluenceAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x0015FF48 File Offset: 0x0015E148
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainTleilaxuInfluenceAgentAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainTleilaxuInfluenceAgentAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluenceAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x000136A8 File Offset: 0x000118A8
		public GainTleilaxuInfluenceAgentAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x0015FFB8 File Offset: 0x0015E1B8
		// (set) Token: 0x06003C08 RID: 15368 RVA: 0x000136B1 File Offset: 0x000118B1
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GainTleilaxuInfluenceAgentAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GainTleilaxuInfluenceAgentAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06003C09 RID: 15369 RVA: 0x0015FFD8 File Offset: 0x0015E1D8
		// (set) Token: 0x06003C0A RID: 15370 RVA: 0x000136C3 File Offset: 0x000118C3
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GainTleilaxuInfluenceAgentAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GainTleilaxuInfluenceAgentAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027A9 RID: 10153
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040027AA RID: 10154
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040027AB RID: 10155
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040027AC RID: 10156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040027AD RID: 10157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;
	}
}
