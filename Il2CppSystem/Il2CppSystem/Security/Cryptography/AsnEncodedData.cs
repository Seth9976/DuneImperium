using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020000B9 RID: 185
	public class AsnEncodedData : Object
	{
		// Token: 0x06000CE0 RID: 3296 RVA: 0x0004C074 File Offset: 0x0004A274
		// Note: this type is marked as 'beforefieldinit'.
		static AsnEncodedData()
		{
			Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography", "AsnEncodedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr);
			AsnEncodedData.NativeFieldInfoPtr__oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, "_oid");
			AsnEncodedData.NativeFieldInfoPtr__raw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, "_raw");
			AsnEncodedData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665142);
			AsnEncodedData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665143);
			AsnEncodedData.NativeMethodInfoPtr__ctor_Public_Void_Oid_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665144);
			AsnEncodedData.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665145);
			AsnEncodedData.NativeMethodInfoPtr_get_Oid_Public_get_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665146);
			AsnEncodedData.NativeMethodInfoPtr_set_Oid_Public_set_Void_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665147);
			AsnEncodedData.NativeMethodInfoPtr_get_RawData_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665148);
			AsnEncodedData.NativeMethodInfoPtr_set_RawData_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665149);
			AsnEncodedData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_New_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665150);
			AsnEncodedData.NativeMethodInfoPtr_Format_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665151);
			AsnEncodedData.NativeMethodInfoPtr_ToString_Internal_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665152);
			AsnEncodedData.NativeMethodInfoPtr_Default_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665153);
			AsnEncodedData.NativeMethodInfoPtr_BasicConstraintsExtension_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665154);
			AsnEncodedData.NativeMethodInfoPtr_EnhancedKeyUsageExtension_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665155);
			AsnEncodedData.NativeMethodInfoPtr_KeyUsageExtension_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665156);
			AsnEncodedData.NativeMethodInfoPtr_SubjectKeyIdentifierExtension_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665157);
			AsnEncodedData.NativeMethodInfoPtr_SubjectAltName_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665158);
			AsnEncodedData.NativeMethodInfoPtr_NetscapeCertType_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr, 100665159);
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0004C234 File Offset: 0x0004A434
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnEncodedData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x0004C270 File Offset: 0x0004A470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452452, XrefRangeEnd = 452459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnEncodedData(string oid, Il2CppStructArray<byte> rawData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0004C2D0 File Offset: 0x0004A4D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 452469, RefRangeEnd = 452471, XrefRangeStart = 452459, XrefRangeEnd = 452469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnEncodedData(Oid oid, Il2CppStructArray<byte> rawData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr__ctor_Public_Void_Oid_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x0004C330 File Offset: 0x0004A530
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 452486, RefRangeEnd = 452488, XrefRangeStart = 452471, XrefRangeEnd = 452486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnEncodedData(AsnEncodedData asnEncodedData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsnEncodedData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0004C37C File Offset: 0x0004A57C
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x0004C3BC File Offset: 0x0004A5BC
		public unsafe Oid Oid
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_get_Oid_Public_get_Oid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 452496, RefRangeEnd = 452499, XrefRangeStart = 452488, XrefRangeEnd = 452496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_set_Oid_Public_set_Void_Oid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x0004C400 File Offset: 0x0004A600
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x0004C440 File Offset: 0x0004A640
		public unsafe Il2CppStructArray<byte> RawData
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_get_RawData_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 452515, RefRangeEnd = 452531, XrefRangeStart = 452499, XrefRangeEnd = 452515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_set_RawData_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0004C484 File Offset: 0x0004A684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452531, XrefRangeEnd = 452548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsnEncodedData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_New_Void_AsnEncodedData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x0004C4D4 File Offset: 0x0004A6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452548, XrefRangeEnd = 452551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Format(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsnEncodedData.NativeMethodInfoPtr_Format_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0004C524 File Offset: 0x0004A724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452551, XrefRangeEnd = 452577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsnEncodedData.NativeMethodInfoPtr_ToString_Internal_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0004C574 File Offset: 0x0004A774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 452591, RefRangeEnd = 452593, XrefRangeStart = 452577, XrefRangeEnd = 452591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Default(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_Default_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0004C5B8 File Offset: 0x0004A7B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452612, RefRangeEnd = 452613, XrefRangeStart = 452593, XrefRangeEnd = 452612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string BasicConstraintsExtension(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_BasicConstraintsExtension_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0004C5FC File Offset: 0x0004A7FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452632, RefRangeEnd = 452633, XrefRangeStart = 452613, XrefRangeEnd = 452632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string EnhancedKeyUsageExtension(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_EnhancedKeyUsageExtension_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0004C640 File Offset: 0x0004A840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452652, RefRangeEnd = 452653, XrefRangeStart = 452633, XrefRangeEnd = 452652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string KeyUsageExtension(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_KeyUsageExtension_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0004C684 File Offset: 0x0004A884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452672, RefRangeEnd = 452673, XrefRangeStart = 452653, XrefRangeEnd = 452672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SubjectKeyIdentifierExtension(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_SubjectKeyIdentifierExtension_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0004C6C8 File Offset: 0x0004A8C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452714, RefRangeEnd = 452715, XrefRangeStart = 452673, XrefRangeEnd = 452714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SubjectAltName(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_SubjectAltName_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0004C70C File Offset: 0x0004A90C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452775, RefRangeEnd = 452776, XrefRangeStart = 452715, XrefRangeEnd = 452775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string NetscapeCertType(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsnEncodedData.NativeMethodInfoPtr_NetscapeCertType_Internal_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00006C73 File Offset: 0x00004E73
		public AsnEncodedData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x0004C750 File Offset: 0x0004A950
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x00006C7C File Offset: 0x00004E7C
		public unsafe Oid _oid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsnEncodedData.NativeFieldInfoPtr__oid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsnEncodedData.NativeFieldInfoPtr__oid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0004C780 File Offset: 0x0004A980
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x00006C9B File Offset: 0x00004E9B
		public unsafe Il2CppStructArray<byte> _raw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsnEncodedData.NativeFieldInfoPtr__raw);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsnEncodedData.NativeFieldInfoPtr__raw), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeFieldInfoPtr__oid;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeFieldInfoPtr__raw;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Oid_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_get_Oid_Public_get_Oid_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr_set_Oid_Public_set_Void_Oid_0;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_get_RawData_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_set_RawData_Public_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_New_Void_AsnEncodedData_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Virtual_New_String_Boolean_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_New_String_Boolean_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_Default_Internal_String_Boolean_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_BasicConstraintsExtension_Internal_String_Boolean_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr_EnhancedKeyUsageExtension_Internal_String_Boolean_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr_KeyUsageExtension_Internal_String_Boolean_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr_SubjectKeyIdentifierExtension_Internal_String_Boolean_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_SubjectAltName_Internal_String_Boolean_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_NetscapeCertType_Internal_String_Boolean_0;
	}
}
