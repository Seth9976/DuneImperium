using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x0200001E RID: 30
	public class Type2Message : MessageBase
	{
		// Token: 0x060001E4 RID: 484 RVA: 0x0000B82C File Offset: 0x00009A2C
		// Note: this type is marked as 'beforefieldinit'.
		static Type2Message()
		{
			Il2CppClassPointerStore<Type2Message>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "Type2Message");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Type2Message>.NativeClassPtr);
			Type2Message.NativeFieldInfoPtr__nonce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, "_nonce");
			Type2Message.NativeFieldInfoPtr__targetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, "_targetName");
			Type2Message.NativeFieldInfoPtr__targetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, "_targetInfo");
			Type2Message.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, 100663599);
			Type2Message.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, 100663600);
			Type2Message.NativeMethodInfoPtr_get_Nonce_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, 100663601);
			Type2Message.NativeMethodInfoPtr_get_TargetName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, 100663602);
			Type2Message.NativeMethodInfoPtr_get_TargetInfo_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, 100663603);
			Type2Message.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, 100663604);
			Type2Message.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, 100663605);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000B924 File Offset: 0x00009B24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1149171, RefRangeEnd = 1149172, XrefRangeStart = 1149163, XrefRangeEnd = 1149171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type2Message(Il2CppStructArray<byte> message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Type2Message>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type2Message.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000B970 File Offset: 0x00009B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149172, XrefRangeEnd = 1149176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type2Message.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000B9AC File Offset: 0x00009BAC
		public unsafe Il2CppStructArray<byte> Nonce
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1149179, RefRangeEnd = 1149182, XrefRangeStart = 1149176, XrefRangeEnd = 1149179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type2Message.NativeMethodInfoPtr_get_Nonce_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000B9EC File Offset: 0x00009BEC
		public unsafe string TargetName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type2Message.NativeMethodInfoPtr_get_TargetName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000BA24 File Offset: 0x00009C24
		public unsafe Il2CppStructArray<byte> TargetInfo
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1149185, RefRangeEnd = 1149188, XrefRangeStart = 1149182, XrefRangeEnd = 1149185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type2Message.NativeMethodInfoPtr_get_TargetInfo_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000BA64 File Offset: 0x00009C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149188, XrefRangeEnd = 1149204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Decode(Il2CppStructArray<byte> message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type2Message.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000BAB4 File Offset: 0x00009CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149204, XrefRangeEnd = 1149206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type2Message.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002C5A File Offset: 0x00000E5A
		public Type2Message(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000BB00 File Offset: 0x00009D00
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00002C63 File Offset: 0x00000E63
		public unsafe Il2CppStructArray<byte> _nonce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type2Message.NativeFieldInfoPtr__nonce);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type2Message.NativeFieldInfoPtr__nonce), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000BB30 File Offset: 0x00009D30
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002C82 File Offset: 0x00000E82
		public unsafe string _targetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type2Message.NativeFieldInfoPtr__targetName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type2Message.NativeFieldInfoPtr__targetName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000BB58 File Offset: 0x00009D58
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002CA1 File Offset: 0x00000EA1
		public unsafe Il2CppStructArray<byte> _targetInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type2Message.NativeFieldInfoPtr__targetInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type2Message.NativeFieldInfoPtr__targetInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr__nonce;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr__targetName;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr__targetInfo;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_get_Nonce_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetName_Public_get_String_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetInfo_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0;
	}
}
