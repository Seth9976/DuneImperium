using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200013D RID: 317
	[Serializable]
	public class TypeLoadException : SystemException
	{
		// Token: 0x060015B0 RID: 5552 RVA: 0x0008F4CC File Offset: 0x0008D6CC
		// Note: this type is marked as 'beforefieldinit'.
		static TypeLoadException()
		{
			Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeLoadException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr);
			TypeLoadException.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, "ClassName");
			TypeLoadException.NativeFieldInfoPtr_AssemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, "AssemblyName");
			TypeLoadException.NativeFieldInfoPtr_MessageArg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, "MessageArg");
			TypeLoadException.NativeFieldInfoPtr_ResourceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, "ResourceId");
			TypeLoadException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100667174);
			TypeLoadException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100667175);
			TypeLoadException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100667176);
			TypeLoadException.NativeMethodInfoPtr_SetMessageField_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100667177);
			TypeLoadException.NativeMethodInfoPtr__ctor_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100667178);
			TypeLoadException.NativeMethodInfoPtr__ctor_Private_Void_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100667179);
			TypeLoadException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100667180);
			TypeLoadException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr, 100667181);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x0008F5EC File Offset: 0x0008D7EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1343573, RefRangeEnd = 1343575, XrefRangeStart = 1343569, XrefRangeEnd = 1343573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeLoadException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x0008F628 File Offset: 0x0008D828
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1343577, RefRangeEnd = 1343584, XrefRangeStart = 1343575, XrefRangeEnd = 1343577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeLoadException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x0008F674 File Offset: 0x0008D874
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343584, XrefRangeEnd = 1343585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeLoadException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x0008F6B8 File Offset: 0x0008D8B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1343601, RefRangeEnd = 1343604, XrefRangeStart = 1343585, XrefRangeEnd = 1343601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMessageField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadException.NativeMethodInfoPtr_SetMessageField_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x0008F6EC File Offset: 0x0008D8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343604, XrefRangeEnd = 1343610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeLoadException(string className, string assemblyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadException.NativeMethodInfoPtr__ctor_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0008F74C File Offset: 0x0008D94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343610, XrefRangeEnd = 1343616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeLoadException(string className, string assemblyName, string messageArg, int resourceId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(messageArg);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resourceId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadException.NativeMethodInfoPtr__ctor_Private_Void_String_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0008F7CC File Offset: 0x0008D9CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1343632, RefRangeEnd = 1343635, XrefRangeStart = 1343616, XrefRangeEnd = 1343632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeLoadException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeLoadException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x0008F830 File Offset: 0x0008DA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343635, XrefRangeEnd = 1343664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeLoadException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00006AFB File Offset: 0x00004CFB
		public TypeLoadException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x0008F894 File Offset: 0x0008DA94
		// (set) Token: 0x060015BB RID: 5563 RVA: 0x00006B04 File Offset: 0x00004D04
		public unsafe string ClassName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_ClassName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_ClassName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x0008F8BC File Offset: 0x0008DABC
		// (set) Token: 0x060015BD RID: 5565 RVA: 0x00006B23 File Offset: 0x00004D23
		public unsafe string AssemblyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_AssemblyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_AssemblyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x0008F8E4 File Offset: 0x0008DAE4
		// (set) Token: 0x060015BF RID: 5567 RVA: 0x00006B42 File Offset: 0x00004D42
		public unsafe string MessageArg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_MessageArg);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_MessageArg), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x0008F90C File Offset: 0x0008DB0C
		// (set) Token: 0x060015C1 RID: 5569 RVA: 0x00006B61 File Offset: 0x00004D61
		public unsafe int ResourceId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_ResourceId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeLoadException.NativeFieldInfoPtr_ResourceId)) = value;
			}
		}

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeFieldInfoPtr_AssemblyName;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeFieldInfoPtr_MessageArg;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeFieldInfoPtr_ResourceId;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_SetMessageField_Private_Void_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_String_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_String_String_Int32_0;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;
	}
}
