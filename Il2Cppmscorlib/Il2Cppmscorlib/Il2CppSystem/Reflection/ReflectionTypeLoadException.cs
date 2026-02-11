using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000425 RID: 1061
	[Serializable]
	public sealed class ReflectionTypeLoadException : SystemException
	{
		// Token: 0x06003CDD RID: 15581 RVA: 0x00123B7C File Offset: 0x00121D7C
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionTypeLoadException()
		{
			Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ReflectionTypeLoadException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr);
			ReflectionTypeLoadException.NativeFieldInfoPtr__Types_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, "<Types>k__BackingField");
			ReflectionTypeLoadException.NativeFieldInfoPtr__LoaderExceptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, "<LoaderExceptions>k__BackingField");
			ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100672390);
			ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100672391);
			ReflectionTypeLoadException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100672392);
			ReflectionTypeLoadException.NativeMethodInfoPtr_get_Types_Public_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100672393);
			ReflectionTypeLoadException.NativeMethodInfoPtr_get_LoaderExceptions_Public_get_Il2CppReferenceArray_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100672394);
			ReflectionTypeLoadException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100672395);
			ReflectionTypeLoadException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100672396);
			ReflectionTypeLoadException.NativeMethodInfoPtr_CreateString_Private_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100672397);
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x00123C74 File Offset: 0x00121E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399053, XrefRangeEnd = 1399056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionTypeLoadException(Il2CppReferenceArray<Type> classes, Il2CppReferenceArray<Exception> exceptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exceptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x00123CD4 File Offset: 0x00121ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399056, XrefRangeEnd = 1399076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionTypeLoadException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x00123D38 File Offset: 0x00121F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399076, XrefRangeEnd = 1399092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06003CE1 RID: 15585 RVA: 0x00123D94 File Offset: 0x00121F94
		public unsafe Il2CppReferenceArray<Type> Types
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr_get_Types_Public_get_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06003CE2 RID: 15586 RVA: 0x00123DD4 File Offset: 0x00121FD4
		public unsafe Il2CppReferenceArray<Exception> LoaderExceptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr_get_LoaderExceptions_Public_get_Il2CppReferenceArray_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Exception>>(intPtr3) : null;
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06003CE3 RID: 15587 RVA: 0x00123E14 File Offset: 0x00122014
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399092, XrefRangeEnd = 1399093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x00123E4C File Offset: 0x0012204C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399093, XrefRangeEnd = 1399094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x00123E84 File Offset: 0x00122084
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1399105, RefRangeEnd = 1399107, XrefRangeStart = 1399094, XrefRangeEnd = 1399105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(bool isMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isMessage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr_CreateString_Private_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x00016851 File Offset: 0x00014A51
		public ReflectionTypeLoadException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06003CE7 RID: 15591 RVA: 0x00123EC8 File Offset: 0x001220C8
		// (set) Token: 0x06003CE8 RID: 15592 RVA: 0x0001685A File Offset: 0x00014A5A
		public unsafe Il2CppReferenceArray<Type> _Types_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionTypeLoadException.NativeFieldInfoPtr__Types_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionTypeLoadException.NativeFieldInfoPtr__Types_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06003CE9 RID: 15593 RVA: 0x00123EF8 File Offset: 0x001220F8
		// (set) Token: 0x06003CEA RID: 15594 RVA: 0x00016879 File Offset: 0x00014A79
		public unsafe Il2CppReferenceArray<Exception> _LoaderExceptions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionTypeLoadException.NativeFieldInfoPtr__LoaderExceptions_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Exception>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionTypeLoadException.NativeFieldInfoPtr__LoaderExceptions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031AA RID: 12714
		private static readonly IntPtr NativeFieldInfoPtr__Types_k__BackingField;

		// Token: 0x040031AB RID: 12715
		private static readonly IntPtr NativeFieldInfoPtr__LoaderExceptions_k__BackingField;

		// Token: 0x040031AC RID: 12716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Exception_0;

		// Token: 0x040031AD RID: 12717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040031AE RID: 12718
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040031AF RID: 12719
		private static readonly IntPtr NativeMethodInfoPtr_get_Types_Public_get_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040031B0 RID: 12720
		private static readonly IntPtr NativeMethodInfoPtr_get_LoaderExceptions_Public_get_Il2CppReferenceArray_1_Exception_0;

		// Token: 0x040031B1 RID: 12721
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x040031B2 RID: 12722
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040031B3 RID: 12723
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_Boolean_0;
	}
}
