using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace CanisData.parsers
{
	// Token: 0x0200000C RID: 12
	public class ParserException : Exception
	{
		// Token: 0x06000037 RID: 55 RVA: 0x000042D0 File Offset: 0x000024D0
		// Note: this type is marked as 'beforefieldinit'.
		static ParserException()
		{
			Il2CppClassPointerStore<ParserException>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers", "ParserException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParserException>.NativeClassPtr);
			ParserException.NativeFieldInfoPtr_Column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParserException>.NativeClassPtr, "Column");
			ParserException.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParserException>.NativeClassPtr, "Contents");
			ParserException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParserException>.NativeClassPtr, 100663321);
			ParserException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParserException>.NativeClassPtr, 100663322);
			ParserException.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParserException>.NativeClassPtr, 100663323);
			ParserException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParserException>.NativeClassPtr, 100663324);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00004378 File Offset: 0x00002578
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222089, XrefRangeEnd = 1222105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParserException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000043BC File Offset: 0x000025BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1222113, RefRangeEnd = 1222114, XrefRangeStart = 1222105, XrefRangeEnd = 1222113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParserException(string column, string contents)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParserException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParserException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000441C File Offset: 0x0000261C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222114, XrefRangeEnd = 1222120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParserException(string message, string column, string contents)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParserException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(column);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParserException.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000448C File Offset: 0x0000268C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222120, XrefRangeEnd = 1222126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParserException(string message, Exception innerException, string column, string contents)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParserException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(column);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParserException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002233 File Offset: 0x00000433
		public ParserException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00004510 File Offset: 0x00002710
		// (set) Token: 0x0600003E RID: 62 RVA: 0x0000223C File Offset: 0x0000043C
		public unsafe string Column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParserException.NativeFieldInfoPtr_Column);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParserException.NativeFieldInfoPtr_Column), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00004538 File Offset: 0x00002738
		// (set) Token: 0x06000040 RID: 64 RVA: 0x0000225B File Offset: 0x0000045B
		public unsafe string Contents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParserException.NativeFieldInfoPtr_Contents);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParserException.NativeFieldInfoPtr_Contents), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_Column;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_Contents;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_String_String_0;
	}
}
