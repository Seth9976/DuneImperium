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
	// Token: 0x02000169 RID: 361
	public class AttributesResetObfuscator : MessageObfuscator<AttributesReset>
	{
		// Token: 0x0600102A RID: 4138 RVA: 0x0005AED8 File Offset: 0x000590D8
		// Note: this type is marked as 'beforefieldinit'.
		static AttributesResetObfuscator()
		{
			Il2CppClassPointerStore<AttributesResetObfuscator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.messages", "AttributesResetObfuscator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributesResetObfuscator>.NativeClassPtr);
			AttributesResetObfuscator.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributesResetObfuscator>.NativeClassPtr, "Instance");
			AttributesResetObfuscator.NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_AttributesReset_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesResetObfuscator>.NativeClassPtr, 100666587);
			AttributesResetObfuscator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesResetObfuscator>.NativeClassPtr, 100666588);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0005AF44 File Offset: 0x00059144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578997, XrefRangeEnd = 579019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<NetworkMessageEvent> Obfuscate(AttributesReset message, Match match, PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributesResetObfuscator.NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_AttributesReset_Match_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<NetworkMessageEvent>>(intPtr3) : null;
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0005AFC4 File Offset: 0x000591C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579019, XrefRangeEnd = 579022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributesResetObfuscator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributesResetObfuscator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributesResetObfuscator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x000083D8 File Offset: 0x000065D8
		public AttributesResetObfuscator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x0005B000 File Offset: 0x00059200
		// (set) Token: 0x0600102F RID: 4143 RVA: 0x000083E1 File Offset: 0x000065E1
		public unsafe static AttributesResetObfuscator Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributesResetObfuscator.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributesResetObfuscator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributesResetObfuscator.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_AttributesReset_Match_PlayerEntity_0;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
