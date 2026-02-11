using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.BaseSet
{
	// Token: 0x02000480 RID: 1152
	public class FirmGripRevealAbility : RevealAbility
	{
		// Token: 0x06003337 RID: 13111 RVA: 0x001325D4 File Offset: 0x001307D4
		// Note: this type is marked as 'beforefieldinit'.
		static FirmGripRevealAbility()
		{
			Il2CppClassPointerStore<FirmGripRevealAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.BaseSet", "FirmGripRevealAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirmGripRevealAbility>.NativeClassPtr);
			FirmGripRevealAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirmGripRevealAbility>.NativeClassPtr, "AbilityName");
			FirmGripRevealAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirmGripRevealAbility>.NativeClassPtr, "AbilityID");
			FirmGripRevealAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirmGripRevealAbility>.NativeClassPtr, 100679275);
			FirmGripRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirmGripRevealAbility>.NativeClassPtr, 100679276);
			FirmGripRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirmGripRevealAbility>.NativeClassPtr, 100679277);
			FirmGripRevealAbility.NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirmGripRevealAbility>.NativeClassPtr, 100679278);
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x0013267C File Offset: 0x0013087C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234177, XrefRangeEnd = 234181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FirmGripRevealAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x001326C8 File Offset: 0x001308C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234181, XrefRangeEnd = 234197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FirmGripRevealAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirmGripRevealAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirmGripRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x00132714 File Offset: 0x00130914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234197, XrefRangeEnd = 234201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FirmGripRevealAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirmGripRevealAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirmGripRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x00132784 File Offset: 0x00130984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234201, XrefRangeEnd = 234213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dictionary<string, int> GetRevealPreviewValue(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FirmGripRevealAbility.NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr3) : null;
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x00011B22 File Offset: 0x0000FD22
		public FirmGripRevealAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x0600333D RID: 13117 RVA: 0x001327F4 File Offset: 0x001309F4
		// (set) Token: 0x0600333E RID: 13118 RVA: 0x00011B2B File Offset: 0x0000FD2B
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FirmGripRevealAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FirmGripRevealAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x0600333F RID: 13119 RVA: 0x00132814 File Offset: 0x00130A14
		// (set) Token: 0x06003340 RID: 13120 RVA: 0x00011B3D File Offset: 0x0000FD3D
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FirmGripRevealAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FirmGripRevealAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002148 RID: 8520
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002149 RID: 8521
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400214A RID: 8522
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400214B RID: 8523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400214C RID: 8524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400214D RID: 8525
		private static readonly IntPtr NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0;
	}
}
