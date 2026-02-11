using System;
using Canis.entities;
using Canis.json.events;
using Canis.obfuscation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.messages
{
	// Token: 0x0200016E RID: 366
	public class SerializedGameStateObfuscator : MessageObfuscator<SerializedGameState>
	{
		// Token: 0x0600104A RID: 4170 RVA: 0x0005B688 File Offset: 0x00059888
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGameStateObfuscator()
		{
			Il2CppClassPointerStore<SerializedGameStateObfuscator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.messages", "SerializedGameStateObfuscator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGameStateObfuscator>.NativeClassPtr);
			SerializedGameStateObfuscator.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameStateObfuscator>.NativeClassPtr, "Instance");
			SerializedGameStateObfuscator.NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_SerializedGameState_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameStateObfuscator>.NativeClassPtr, 100666634);
			SerializedGameStateObfuscator.NativeMethodInfoPtr_ObfuscateEntity_Private_SerializedEntity_Match_PlayerEntity_SerializedEntity_Visibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameStateObfuscator>.NativeClassPtr, 100666635);
			SerializedGameStateObfuscator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameStateObfuscator>.NativeClassPtr, 100666636);
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0005B708 File Offset: 0x00059908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579524, XrefRangeEnd = 579548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<NetworkMessageEvent> Obfuscate(SerializedGameState sgs, Match match, PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sgs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedGameStateObfuscator.NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_SerializedGameState_Match_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<NetworkMessageEvent>>(intPtr3) : null;
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0005B788 File Offset: 0x00059988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 579568, RefRangeEnd = 579569, XrefRangeStart = 579548, XrefRangeEnd = 579568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedEntity ObfuscateEntity(Match match, PlayerEntity player, SerializedEntity serEnt, Visibility ancestorVisibility)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serEnt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ancestorVisibility);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameStateObfuscator.NativeMethodInfoPtr_ObfuscateEntity_Private_SerializedEntity_Match_PlayerEntity_SerializedEntity_Visibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedEntity>(intPtr3) : null;
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0005B810 File Offset: 0x00059A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579569, XrefRangeEnd = 579572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGameStateObfuscator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGameStateObfuscator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameStateObfuscator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0000845F File Offset: 0x0000665F
		public SerializedGameStateObfuscator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x0005B84C File Offset: 0x00059A4C
		// (set) Token: 0x06001050 RID: 4176 RVA: 0x00008468 File Offset: 0x00006668
		public unsafe static SerializedGameStateObfuscator Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializedGameStateObfuscator.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameStateObfuscator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedGameStateObfuscator.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_SerializedGameState_Match_PlayerEntity_0;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr_ObfuscateEntity_Private_SerializedEntity_Match_PlayerEntity_SerializedEntity_Visibility_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
