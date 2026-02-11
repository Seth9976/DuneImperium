using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lib.canis.Networking.game.messages.effect;

namespace Canis.messages.effect
{
	// Token: 0x02000041 RID: 65
	public class AbilityUseEffectMessage : EffectMessage
	{
		// Token: 0x0600022F RID: 559 RVA: 0x0000B7E8 File Offset: 0x000099E8
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityUseEffectMessage()
		{
			Il2CppClassPointerStore<AbilityUseEffectMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.effect", "AbilityUseEffectMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityUseEffectMessage>.NativeClassPtr);
			AbilityUseEffectMessage.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityUseEffectMessage>.NativeClassPtr, "EntityID");
			AbilityUseEffectMessage.NativeFieldInfoPtr_abilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityUseEffectMessage>.NativeClassPtr, "abilityID");
			AbilityUseEffectMessage.NativeFieldInfoPtr_passiveEffectState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityUseEffectMessage>.NativeClassPtr, "passiveEffectState");
			AbilityUseEffectMessage.NativeFieldInfoPtr_causeEntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityUseEffectMessage>.NativeClassPtr, "causeEntityID");
			AbilityUseEffectMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityUseEffectMessage>.NativeClassPtr, 100663406);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000B87C File Offset: 0x00009A7C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityUseEffectMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityUseEffectMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityUseEffectMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00003786 File Offset: 0x00001986
		public AbilityUseEffectMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0000378F File Offset: 0x0000198F
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityUseEffectMessage.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityUseEffectMessage.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0000B8E8 File Offset: 0x00009AE8
		// (set) Token: 0x06000235 RID: 565 RVA: 0x000037AE File Offset: 0x000019AE
		public unsafe AbilityID abilityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityUseEffectMessage.NativeFieldInfoPtr_abilityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityUseEffectMessage.NativeFieldInfoPtr_abilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0000B918 File Offset: 0x00009B18
		// (set) Token: 0x06000237 RID: 567 RVA: 0x000037CD File Offset: 0x000019CD
		public unsafe PassiveEffectState passiveEffectState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityUseEffectMessage.NativeFieldInfoPtr_passiveEffectState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityUseEffectMessage.NativeFieldInfoPtr_passiveEffectState)) = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000B940 File Offset: 0x00009B40
		// (set) Token: 0x06000239 RID: 569 RVA: 0x000037E8 File Offset: 0x000019E8
		public unsafe EntityID causeEntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityUseEffectMessage.NativeFieldInfoPtr_causeEntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityUseEffectMessage.NativeFieldInfoPtr_causeEntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_abilityID;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_passiveEffectState;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_causeEntityID;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
