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
	// Token: 0x02000168 RID: 360
	public class AttributeRemovedObfuscator : MessageObfuscator<AttributeRemoved>
	{
		// Token: 0x06001024 RID: 4132 RVA: 0x0005AD88 File Offset: 0x00058F88
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeRemovedObfuscator()
		{
			Il2CppClassPointerStore<AttributeRemovedObfuscator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.messages", "AttributeRemovedObfuscator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeRemovedObfuscator>.NativeClassPtr);
			AttributeRemovedObfuscator.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeRemovedObfuscator>.NativeClassPtr, "Instance");
			AttributeRemovedObfuscator.NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_AttributeRemoved_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeRemovedObfuscator>.NativeClassPtr, 100666584);
			AttributeRemovedObfuscator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeRemovedObfuscator>.NativeClassPtr, 100666585);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0005ADF4 File Offset: 0x00058FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578972, XrefRangeEnd = 578994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<NetworkMessageEvent> Obfuscate(AttributeRemoved message, Match match, PlayerEntity player)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeRemovedObfuscator.NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_AttributeRemoved_Match_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<NetworkMessageEvent>>(intPtr3) : null;
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0005AE74 File Offset: 0x00059074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578994, XrefRangeEnd = 578997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeRemovedObfuscator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeRemovedObfuscator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeRemovedObfuscator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x000083BD File Offset: 0x000065BD
		public AttributeRemovedObfuscator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x0005AEB0 File Offset: 0x000590B0
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x000083C6 File Offset: 0x000065C6
		public unsafe static AttributeRemovedObfuscator Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeRemovedObfuscator.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeRemovedObfuscator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeRemovedObfuscator.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_AttributeRemoved_Match_PlayerEntity_0;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
