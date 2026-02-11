using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000DA RID: 218
	public class X509Extension : AsnEncodedData
	{
		// Token: 0x06000E9D RID: 3741 RVA: 0x000533F8 File Offset: 0x000515F8
		// Note: this type is marked as 'beforefieldinit'.
		static X509Extension()
		{
			Il2CppClassPointerStore<X509Extension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Extension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Extension>.NativeClassPtr);
			X509Extension.NativeFieldInfoPtr__critical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, "_critical");
			X509Extension.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100665421);
			X509Extension.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100665422);
			X509Extension.NativeMethodInfoPtr_get_Critical_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100665423);
			X509Extension.NativeMethodInfoPtr_set_Critical_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100665424);
			X509Extension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100665425);
			X509Extension.NativeMethodInfoPtr_FormatUnkownData_Internal_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100665426);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x000534B4 File Offset: 0x000516B4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Extension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Extension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x000534F0 File Offset: 0x000516F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 455514, RefRangeEnd = 455515, XrefRangeStart = 455507, XrefRangeEnd = 455514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Extension(string oid, Il2CppStructArray<byte> rawData, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Extension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0005355C File Offset: 0x0005175C
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x00053598 File Offset: 0x00051798
		public unsafe bool Critical
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr_get_Critical_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr_set_Critical_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x000535D8 File Offset: 0x000517D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455515, XrefRangeEnd = 455528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Extension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00053628 File Offset: 0x00051828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455528, XrefRangeEnd = 455539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatUnkownData(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr_FormatUnkownData_Internal_String_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x000074D3 File Offset: 0x000056D3
		public X509Extension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x00053670 File Offset: 0x00051870
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x000074DC File Offset: 0x000056DC
		public unsafe bool _critical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr__critical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr__critical)) = value;
			}
		}

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeFieldInfoPtr__critical;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeMethodInfoPtr_get_Critical_Public_get_Boolean_0;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr_set_Critical_Public_set_Void_Boolean_0;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr_FormatUnkownData_Internal_String_Il2CppStructArray_1_Byte_0;
	}
}
