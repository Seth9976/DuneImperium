using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Mail
{
	// Token: 0x0200024D RID: 589
	public static class MailAddressParser : Object
	{
		// Token: 0x0600275D RID: 10077 RVA: 0x000B3D1C File Offset: 0x000B1F1C
		// Note: this type is marked as 'beforefieldinit'.
		static MailAddressParser()
		{
			Il2CppClassPointerStore<MailAddressParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Mail", "MailAddressParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MailAddressParser>.NativeClassPtr);
			MailAddressParser.NativeMethodInfoPtr_ParseAddress_Internal_Static_MailAddress_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddressParser>.NativeClassPtr, 100669148);
			MailAddressParser.NativeMethodInfoPtr_ParseAddress_Private_Static_MailAddress_String_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddressParser>.NativeClassPtr, 100669149);
			MailAddressParser.NativeMethodInfoPtr_ReadCfwsAndThrowIfIncomplete_Private_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddressParser>.NativeClassPtr, 100669150);
			MailAddressParser.NativeMethodInfoPtr_ParseDomain_Private_Static_String_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddressParser>.NativeClassPtr, 100669151);
			MailAddressParser.NativeMethodInfoPtr_ParseLocalPart_Private_Static_String_String_byref_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddressParser>.NativeClassPtr, 100669152);
			MailAddressParser.NativeMethodInfoPtr_ParseDisplayName_Private_Static_String_String_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddressParser>.NativeClassPtr, 100669153);
			MailAddressParser.NativeMethodInfoPtr_NormalizeOrThrow_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddressParser>.NativeClassPtr, 100669154);
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x000B3DD8 File Offset: 0x000B1FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490809, XrefRangeEnd = 490810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MailAddress ParseAddress(string data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailAddressParser.NativeMethodInfoPtr_ParseAddress_Internal_Static_MailAddress_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MailAddress>(intPtr3) : null;
			}
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x000B3E1C File Offset: 0x000B201C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 490850, RefRangeEnd = 490852, XrefRangeStart = 490810, XrefRangeEnd = 490850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MailAddress ParseAddress(string data, bool expectMultipleAddresses, ref int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expectMultipleAddresses;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailAddressParser.NativeMethodInfoPtr_ParseAddress_Private_Static_MailAddress_String_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MailAddress>(intPtr3) : null;
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x000B3E7C File Offset: 0x000B207C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490852, XrefRangeEnd = 490853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadCfwsAndThrowIfIncomplete(string data, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailAddressParser.NativeMethodInfoPtr_ReadCfwsAndThrowIfIncomplete_Private_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x000B3ECC File Offset: 0x000B20CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490878, RefRangeEnd = 490879, XrefRangeStart = 490853, XrefRangeEnd = 490878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseDomain(string data, ref int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailAddressParser.NativeMethodInfoPtr_ParseDomain_Private_Static_String_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x000B3F18 File Offset: 0x000B2118
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490939, RefRangeEnd = 490940, XrefRangeStart = 490879, XrefRangeEnd = 490939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseLocalPart(string data, ref int index, bool expectAngleBracket, bool expectMultipleAddresses)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expectAngleBracket;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expectMultipleAddresses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailAddressParser.NativeMethodInfoPtr_ParseLocalPart_Private_Static_String_String_byref_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x000B3F80 File Offset: 0x000B2180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490998, RefRangeEnd = 490999, XrefRangeStart = 490940, XrefRangeEnd = 490998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseDisplayName(string data, ref int index, bool expectMultipleAddresses)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expectMultipleAddresses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailAddressParser.NativeMethodInfoPtr_ParseDisplayName_Private_Static_String_String_byref_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x000B3FD8 File Offset: 0x000B21D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 491000, RefRangeEnd = 491004, XrefRangeStart = 490999, XrefRangeEnd = 491000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NormalizeOrThrow(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailAddressParser.NativeMethodInfoPtr_NormalizeOrThrow_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x0001100F File Offset: 0x0000F20F
		public MailAddressParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F4E RID: 8014
		private static readonly IntPtr NativeMethodInfoPtr_ParseAddress_Internal_Static_MailAddress_String_0;

		// Token: 0x04001F4F RID: 8015
		private static readonly IntPtr NativeMethodInfoPtr_ParseAddress_Private_Static_MailAddress_String_Boolean_byref_Int32_0;

		// Token: 0x04001F50 RID: 8016
		private static readonly IntPtr NativeMethodInfoPtr_ReadCfwsAndThrowIfIncomplete_Private_Static_Int32_String_Int32_0;

		// Token: 0x04001F51 RID: 8017
		private static readonly IntPtr NativeMethodInfoPtr_ParseDomain_Private_Static_String_String_byref_Int32_0;

		// Token: 0x04001F52 RID: 8018
		private static readonly IntPtr NativeMethodInfoPtr_ParseLocalPart_Private_Static_String_String_byref_Int32_Boolean_Boolean_0;

		// Token: 0x04001F53 RID: 8019
		private static readonly IntPtr NativeMethodInfoPtr_ParseDisplayName_Private_Static_String_String_byref_Int32_Boolean_0;

		// Token: 0x04001F54 RID: 8020
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeOrThrow_Internal_Static_String_String_0;
	}
}
