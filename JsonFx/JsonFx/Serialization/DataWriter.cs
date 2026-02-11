using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace JsonFx.Serialization
{
	// Token: 0x02000007 RID: 7
	public class DataWriter : Object
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00004A88 File Offset: 0x00002C88
		// Note: this type is marked as 'beforefieldinit'.
		static DataWriter()
		{
			Il2CppClassPointerStore<DataWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization", "DataWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataWriter>.NativeClassPtr);
			DataWriter.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataWriter>.NativeClassPtr, "settings");
			DataWriter.NativeMethodInfoPtr__ctor_Protected_Void_DataWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriter>.NativeClassPtr, 100663330);
			DataWriter.NativeMethodInfoPtr_get_ContentEncoding_Public_Abstract_Virtual_New_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriter>.NativeClassPtr, 100663331);
			DataWriter.NativeMethodInfoPtr_get_ContentType_Public_Abstract_Virtual_New_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriter>.NativeClassPtr, 100663332);
			DataWriter.NativeMethodInfoPtr_get_FileExtension_Public_Abstract_Virtual_New_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriter>.NativeClassPtr, 100663333);
			DataWriter.NativeMethodInfoPtr_get_Settings_Public_get_DataWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriter>.NativeClassPtr, 100663334);
			DataWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Object_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriter>.NativeClassPtr, 100663335);
			DataWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriter>.NativeClassPtr, 100663336);
			DataWriter.NativeMethodInfoPtr_GetWalker_Protected_Abstract_Virtual_New_IObjectWalker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriter>.NativeClassPtr, 100663337);
			DataWriter.NativeMethodInfoPtr_GetFormatter_Protected_Abstract_Virtual_New_ITextFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriter>.NativeClassPtr, 100663338);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004B80 File Offset: 0x00002D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189771, XrefRangeEnd = 1189779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataWriter(DataWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriter.NativeMethodInfoPtr__ctor_Protected_Void_DataWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00004BCC File Offset: 0x00002DCC
		public unsafe virtual Encoding ContentEncoding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataWriter.NativeMethodInfoPtr_get_ContentEncoding_Public_Abstract_Virtual_New_get_Encoding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00004C18 File Offset: 0x00002E18
		public unsafe virtual IEnumerable<string> ContentType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataWriter.NativeMethodInfoPtr_get_ContentType_Public_Abstract_Virtual_New_get_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00004C64 File Offset: 0x00002E64
		public unsafe virtual IEnumerable<string> FileExtension
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataWriter.NativeMethodInfoPtr_get_FileExtension_Public_Abstract_Virtual_New_get_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00004CB0 File Offset: 0x00002EB0
		public unsafe DataWriterSettings Settings
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriter.NativeMethodInfoPtr_get_Settings_Public_get_DataWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataWriterSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004CF0 File Offset: 0x00002EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189779, XrefRangeEnd = 1189785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(Object data, TextWriter output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Object_TextWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00004D50 File Offset: 0x00002F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189785, XrefRangeEnd = 1189791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Write(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004DA4 File Offset: 0x00002FA4
		[CallerCount(0)]
		public unsafe virtual IObjectWalker GetWalker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataWriter.NativeMethodInfoPtr_GetWalker_Protected_Abstract_Virtual_New_IObjectWalker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IObjectWalker>(intPtr3) : null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004DF0 File Offset: 0x00002FF0
		[CallerCount(0)]
		public unsafe virtual ITextFormatter GetFormatter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataWriter.NativeMethodInfoPtr_GetFormatter_Protected_Abstract_Virtual_New_ITextFormatter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITextFormatter>(intPtr3) : null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002165 File Offset: 0x00000365
		public DataWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00004E3C File Offset: 0x0000303C
		// (set) Token: 0x06000048 RID: 72 RVA: 0x0000216E File Offset: 0x0000036E
		public unsafe DataWriterSettings settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataWriter.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataWriterSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataWriter.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_DataWriterSettings_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentEncoding_Public_Abstract_Virtual_New_get_Encoding_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_Abstract_Virtual_New_get_IEnumerable_1_String_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_FileExtension_Public_Abstract_Virtual_New_get_IEnumerable_1_String_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_DataWriterSettings_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Object_TextWriter_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_String_Object_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_GetWalker_Protected_Abstract_Virtual_New_IObjectWalker_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatter_Protected_Abstract_Virtual_New_ITextFormatter_0;
	}
}
