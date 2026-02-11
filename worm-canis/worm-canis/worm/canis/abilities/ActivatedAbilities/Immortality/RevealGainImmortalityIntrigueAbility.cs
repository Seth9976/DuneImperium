using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.abilities.ActivatedAbilities.Immortality
{
	// Token: 0x0200050A RID: 1290
	public class RevealGainImmortalityIntrigueAbility : GainImmortalityIntrigueAbility
	{
		// Token: 0x06003BBF RID: 15295 RVA: 0x0015E9AC File Offset: 0x0015CBAC
		// Note: this type is marked as 'beforefieldinit'.
		static RevealGainImmortalityIntrigueAbility()
		{
			Il2CppClassPointerStore<RevealGainImmortalityIntrigueAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.Immortality", "RevealGainImmortalityIntrigueAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealGainImmortalityIntrigueAbility>.NativeClassPtr);
			RevealGainImmortalityIntrigueAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealGainImmortalityIntrigueAbility>.NativeClassPtr, "AbilityName");
			RevealGainImmortalityIntrigueAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealGainImmortalityIntrigueAbility>.NativeClassPtr, "AbilityID");
			RevealGainImmortalityIntrigueAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealGainImmortalityIntrigueAbility>.NativeClassPtr, 100682774);
			RevealGainImmortalityIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealGainImmortalityIntrigueAbility>.NativeClassPtr, 100682775);
			RevealGainImmortalityIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealGainImmortalityIntrigueAbility>.NativeClassPtr, 100682776);
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x0015EA40 File Offset: 0x0015CC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265008, XrefRangeEnd = 265012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RevealGainImmortalityIntrigueAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x0015EA8C File Offset: 0x0015CC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265012, XrefRangeEnd = 265025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RevealGainImmortalityIntrigueAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealGainImmortalityIntrigueAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealGainImmortalityIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x0015EAD8 File Offset: 0x0015CCD8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RevealGainImmortalityIntrigueAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealGainImmortalityIntrigueAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealGainImmortalityIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x000135C4 File Offset: 0x000117C4
		public RevealGainImmortalityIntrigueAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06003BC4 RID: 15300 RVA: 0x0015EB48 File Offset: 0x0015CD48
		// (set) Token: 0x06003BC5 RID: 15301 RVA: 0x000135CD File Offset: 0x000117CD
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RevealGainImmortalityIntrigueAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RevealGainImmortalityIntrigueAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06003BC6 RID: 15302 RVA: 0x0015EB68 File Offset: 0x0015CD68
		// (set) Token: 0x06003BC7 RID: 15303 RVA: 0x000135DF File Offset: 0x000117DF
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RevealGainImmortalityIntrigueAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RevealGainImmortalityIntrigueAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400277C RID: 10108
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x0400277D RID: 10109
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400277E RID: 10110
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400277F RID: 10111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04002780 RID: 10112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;
	}
}
