using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x02000520 RID: 1312
	[Serializable]
	public class FileLoadException : IOException
	{
		// Token: 0x06004FF8 RID: 20472 RVA: 0x00174288 File Offset: 0x00172488
		// Note: this type is marked as 'beforefieldinit'.
		static FileLoadException()
		{
			Il2CppClassPointerStore<FileLoadException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileLoadException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr);
			FileLoadException.NativeFieldInfoPtr__FileName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, "<FileName>k__BackingField");
			FileLoadException.NativeFieldInfoPtr__FusionLog_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, "<FusionLog>k__BackingField");
			FileLoadException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100675377);
			FileLoadException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100675378);
			FileLoadException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100675379);
			FileLoadException.NativeMethodInfoPtr_get_FileName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100675380);
			FileLoadException.NativeMethodInfoPtr_get_FusionLog_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100675381);
			FileLoadException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100675382);
			FileLoadException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100675383);
			FileLoadException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100675384);
			FileLoadException.NativeMethodInfoPtr_FormatFileLoadExceptionMessage_Internal_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr, 100675385);
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x00174394 File Offset: 0x00172594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427236, XrefRangeEnd = 1427239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileLoadException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileLoadException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FFA RID: 20474 RVA: 0x001743D0 File Offset: 0x001725D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427239, XrefRangeEnd = 1427240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileLoadException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileLoadException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x06004FFB RID: 20475 RVA: 0x0017441C File Offset: 0x0017261C
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427240, XrefRangeEnd = 1427247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileLoadException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x06004FFC RID: 20476 RVA: 0x00174460 File Offset: 0x00172660
		public unsafe string FileName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileLoadException.NativeMethodInfoPtr_get_FileName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x06004FFD RID: 20477 RVA: 0x00174498 File Offset: 0x00172698
		public unsafe string FusionLog
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileLoadException.NativeMethodInfoPtr_get_FusionLog_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004FFE RID: 20478 RVA: 0x001744D0 File Offset: 0x001726D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427247, XrefRangeEnd = 1427268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileLoadException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x00174514 File Offset: 0x00172714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427268, XrefRangeEnd = 1427278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileLoadException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileLoadException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileLoadException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005000 RID: 20480 RVA: 0x00174578 File Offset: 0x00172778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427278, XrefRangeEnd = 1427293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileLoadException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005001 RID: 20481 RVA: 0x001745DC File Offset: 0x001727DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427296, RefRangeEnd = 1427297, XrefRangeStart = 1427293, XrefRangeEnd = 1427296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatFileLoadExceptionMessage(string fileName, int hResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileLoadException.NativeMethodInfoPtr_FormatFileLoadExceptionMessage_Internal_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005002 RID: 20482 RVA: 0x0001CA15 File Offset: 0x0001AC15
		public FileLoadException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x06005003 RID: 20483 RVA: 0x00174628 File Offset: 0x00172828
		// (set) Token: 0x06005004 RID: 20484 RVA: 0x0001CA1E File Offset: 0x0001AC1E
		public unsafe string _FileName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileLoadException.NativeFieldInfoPtr__FileName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileLoadException.NativeFieldInfoPtr__FileName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x06005005 RID: 20485 RVA: 0x00174650 File Offset: 0x00172850
		// (set) Token: 0x06005006 RID: 20486 RVA: 0x0001CA3D File Offset: 0x0001AC3D
		public unsafe string _FusionLog_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileLoadException.NativeFieldInfoPtr__FusionLog_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileLoadException.NativeFieldInfoPtr__FusionLog_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400412E RID: 16686
		private static readonly IntPtr NativeFieldInfoPtr__FileName_k__BackingField;

		// Token: 0x0400412F RID: 16687
		private static readonly IntPtr NativeFieldInfoPtr__FusionLog_k__BackingField;

		// Token: 0x04004130 RID: 16688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004131 RID: 16689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04004132 RID: 16690
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04004133 RID: 16691
		private static readonly IntPtr NativeMethodInfoPtr_get_FileName_Public_get_String_0;

		// Token: 0x04004134 RID: 16692
		private static readonly IntPtr NativeMethodInfoPtr_get_FusionLog_Public_get_String_0;

		// Token: 0x04004135 RID: 16693
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04004136 RID: 16694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04004137 RID: 16695
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04004138 RID: 16696
		private static readonly IntPtr NativeMethodInfoPtr_FormatFileLoadExceptionMessage_Internal_Static_String_String_Int32_0;
	}
}
