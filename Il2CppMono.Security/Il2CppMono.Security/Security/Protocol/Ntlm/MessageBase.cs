using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x02000019 RID: 25
	public class MessageBase : Object
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x0000B160 File Offset: 0x00009360
		// Note: this type is marked as 'beforefieldinit'.
		static MessageBase()
		{
			Il2CppClassPointerStore<MessageBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "MessageBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageBase>.NativeClassPtr);
			MessageBase.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, "header");
			MessageBase.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, "_type");
			MessageBase.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, "_flags");
			MessageBase.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663583);
			MessageBase.NativeMethodInfoPtr_get_Flags_Public_get_NtlmFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663584);
			MessageBase.NativeMethodInfoPtr_set_Flags_Public_set_Void_NtlmFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663585);
			MessageBase.NativeMethodInfoPtr_get_Type_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663586);
			MessageBase.NativeMethodInfoPtr_PrepareMessage_Protected_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663587);
			MessageBase.NativeMethodInfoPtr_Decode_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663588);
			MessageBase.NativeMethodInfoPtr_CheckHeader_Protected_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663589);
			MessageBase.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663590);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000B26C File Offset: 0x0000946C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageBase(int messageType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBase.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000B2B4 File Offset: 0x000094B4
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0000B2F0 File Offset: 0x000094F0
		public unsafe NtlmFlags Flags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBase.NativeMethodInfoPtr_get_Flags_Public_get_NtlmFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBase.NativeMethodInfoPtr_set_Flags_Public_set_Void_NtlmFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000B330 File Offset: 0x00009530
		public unsafe int Type
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBase.NativeMethodInfoPtr_get_Type_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000B36C File Offset: 0x0000956C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1149097, RefRangeEnd = 1149100, XrefRangeStart = 1149089, XrefRangeEnd = 1149097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> PrepareMessage(int messageSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBase.NativeMethodInfoPtr_PrepareMessage_Protected_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000B3B8 File Offset: 0x000095B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1149108, RefRangeEnd = 1149111, XrefRangeStart = 1149100, XrefRangeEnd = 1149108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Decode(Il2CppStructArray<byte> message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBase.NativeMethodInfoPtr_Decode_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000B408 File Offset: 0x00009608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149111, XrefRangeEnd = 1149118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckHeader(Il2CppStructArray<byte> message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBase.NativeMethodInfoPtr_CheckHeader_Protected_Boolean_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000B458 File Offset: 0x00009658
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBase.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002BAB File Offset: 0x00000DAB
		public MessageBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0000B4A4 File Offset: 0x000096A4
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00002BB4 File Offset: 0x00000DB4
		public unsafe static Il2CppStructArray<byte> header
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MessageBase.NativeFieldInfoPtr_header, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBase.NativeFieldInfoPtr_header, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000B4CC File Offset: 0x000096CC
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00002BC6 File Offset: 0x00000DC6
		public unsafe int _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBase.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBase.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000B4F4 File Offset: 0x000096F4
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002BE1 File Offset: 0x00000DE1
		public unsafe NtlmFlags _flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBase.NativeFieldInfoPtr__flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBase.NativeFieldInfoPtr__flags)) = value;
			}
		}

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_header;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_get_NtlmFlags_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_NtlmFlags_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Int32_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_PrepareMessage_Protected_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_CheckHeader_Protected_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0;
	}
}
