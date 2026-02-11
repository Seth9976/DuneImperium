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
	// Token: 0x02000167 RID: 359
	public class AttributeModifiedObfuscator : MessageObfuscator<AttributeModified>
	{
		// Token: 0x0600101E RID: 4126 RVA: 0x0005AC38 File Offset: 0x00058E38
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeModifiedObfuscator()
		{
			Il2CppClassPointerStore<AttributeModifiedObfuscator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.messages", "AttributeModifiedObfuscator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeModifiedObfuscator>.NativeClassPtr);
			AttributeModifiedObfuscator.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeModifiedObfuscator>.NativeClassPtr, "Instance");
			AttributeModifiedObfuscator.NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_AttributeModified_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeModifiedObfuscator>.NativeClassPtr, 100666581);
			AttributeModifiedObfuscator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeModifiedObfuscator>.NativeClassPtr, 100666582);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0005ACA4 File Offset: 0x00058EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578947, XrefRangeEnd = 578969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<NetworkMessageEvent> Obfuscate(AttributeModified message, Match match, PlayerEntity player)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeModifiedObfuscator.NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_AttributeModified_Match_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<NetworkMessageEvent>>(intPtr3) : null;
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0005AD24 File Offset: 0x00058F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578969, XrefRangeEnd = 578972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeModifiedObfuscator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeModifiedObfuscator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeModifiedObfuscator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x000083A2 File Offset: 0x000065A2
		public AttributeModifiedObfuscator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x0005AD60 File Offset: 0x00058F60
		// (set) Token: 0x06001023 RID: 4131 RVA: 0x000083AB File Offset: 0x000065AB
		public unsafe static AttributeModifiedObfuscator Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeModifiedObfuscator.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeModifiedObfuscator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeModifiedObfuscator.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_AttributeModified_Match_PlayerEntity_0;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
