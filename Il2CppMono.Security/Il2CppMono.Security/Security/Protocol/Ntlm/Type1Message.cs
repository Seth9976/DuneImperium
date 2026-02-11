using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x0200001D RID: 29
	public class Type1Message : MessageBase
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x0000B5C0 File Offset: 0x000097C0
		// Note: this type is marked as 'beforefieldinit'.
		static Type1Message()
		{
			Il2CppClassPointerStore<Type1Message>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "Type1Message");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Type1Message>.NativeClassPtr);
			Type1Message.NativeFieldInfoPtr__host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type1Message>.NativeClassPtr, "_host");
			Type1Message.NativeFieldInfoPtr__domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type1Message>.NativeClassPtr, "_domain");
			Type1Message.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type1Message>.NativeClassPtr, 100663594);
			Type1Message.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type1Message>.NativeClassPtr, 100663595);
			Type1Message.NativeMethodInfoPtr_set_Host_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type1Message>.NativeClassPtr, 100663596);
			Type1Message.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type1Message>.NativeClassPtr, 100663597);
			Type1Message.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type1Message>.NativeClassPtr, 100663598);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000B67C File Offset: 0x0000987C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1149130, RefRangeEnd = 1149131, XrefRangeStart = 1149122, XrefRangeEnd = 1149130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type1Message()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Type1Message>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type1Message.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000A5 RID: 165
		// (set) Token: 0x060001DB RID: 475 RVA: 0x0000B6B8 File Offset: 0x000098B8
		public unsafe string Domain
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1149135, RefRangeEnd = 1149136, XrefRangeStart = 1149131, XrefRangeEnd = 1149135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type1Message.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0000B6FC File Offset: 0x000098FC
		public unsafe string Host
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1149140, RefRangeEnd = 1149141, XrefRangeStart = 1149136, XrefRangeEnd = 1149140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type1Message.NativeMethodInfoPtr_set_Host_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000B740 File Offset: 0x00009940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149141, XrefRangeEnd = 1149151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Decode(Il2CppStructArray<byte> message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type1Message.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000B790 File Offset: 0x00009990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149151, XrefRangeEnd = 1149163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type1Message.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002C13 File Offset: 0x00000E13
		public Type1Message(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000B7DC File Offset: 0x000099DC
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002C1C File Offset: 0x00000E1C
		public unsafe string _host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type1Message.NativeFieldInfoPtr__host);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type1Message.NativeFieldInfoPtr__host), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000B804 File Offset: 0x00009A04
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002C3B File Offset: 0x00000E3B
		public unsafe string _domain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type1Message.NativeFieldInfoPtr__domain);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type1Message.NativeFieldInfoPtr__domain), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr__host;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr__domain;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_set_Host_Public_set_Void_String_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0;
	}
}
