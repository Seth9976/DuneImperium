using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200043C RID: 1084
	[Serializable]
	public class MemberInfoSerializationHolder : Object
	{
		// Token: 0x06003E32 RID: 15922 RVA: 0x0012A60C File Offset: 0x0012880C
		// Note: this type is marked as 'beforefieldinit'.
		static MemberInfoSerializationHolder()
		{
			Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MemberInfoSerializationHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr);
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_memberName");
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_reflectedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_reflectedType");
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_signature");
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_signature2");
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_memberType");
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_info");
			MemberInfoSerializationHolder.NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, 100672655);
			MemberInfoSerializationHolder.NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_String_MemberTypes_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, 100672656);
			MemberInfoSerializationHolder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, 100672657);
			MemberInfoSerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, 100672658);
			MemberInfoSerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, 100672659);
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x0012A718 File Offset: 0x00128918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400135, XrefRangeEnd = 1400136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedClass);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInfoSerializationHolder.NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_MemberTypes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x0012A794 File Offset: 0x00128994
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1400185, RefRangeEnd = 1400191, XrefRangeStart = 1400136, XrefRangeEnd = 1400185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Il2CppReferenceArray<Type> genericArguments)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedClass);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature2);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericArguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInfoSerializationHolder.NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_String_MemberTypes_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x0012A834 File Offset: 0x00128A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400191, XrefRangeEnd = 1400251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberInfoSerializationHolder(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInfoSerializationHolder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x0012A898 File Offset: 0x00128A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400251, XrefRangeEnd = 1400258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfoSerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x0012A8FC File Offset: 0x00128AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400258, XrefRangeEnd = 1400298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfoSerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x00016BA9 File Offset: 0x00014DA9
		public MemberInfoSerializationHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06003E39 RID: 15929 RVA: 0x0012A95C File Offset: 0x00128B5C
		// (set) Token: 0x06003E3A RID: 15930 RVA: 0x00016BB2 File Offset: 0x00014DB2
		public unsafe string m_memberName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06003E3B RID: 15931 RVA: 0x0012A984 File Offset: 0x00128B84
		// (set) Token: 0x06003E3C RID: 15932 RVA: 0x00016BD1 File Offset: 0x00014DD1
		public unsafe RuntimeType m_reflectedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_reflectedType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_reflectedType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06003E3D RID: 15933 RVA: 0x0012A9B4 File Offset: 0x00128BB4
		// (set) Token: 0x06003E3E RID: 15934 RVA: 0x00016BF0 File Offset: 0x00014DF0
		public unsafe string m_signature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06003E3F RID: 15935 RVA: 0x0012A9DC File Offset: 0x00128BDC
		// (set) Token: 0x06003E40 RID: 15936 RVA: 0x00016C0F File Offset: 0x00014E0F
		public unsafe string m_signature2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature2);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature2), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06003E41 RID: 15937 RVA: 0x0012AA04 File Offset: 0x00128C04
		// (set) Token: 0x06003E42 RID: 15938 RVA: 0x00016C2E File Offset: 0x00014E2E
		public unsafe MemberTypes m_memberType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberType)) = value;
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06003E43 RID: 15939 RVA: 0x0012AA2C File Offset: 0x00128C2C
		// (set) Token: 0x06003E44 RID: 15940 RVA: 0x00016C49 File Offset: 0x00014E49
		public unsafe SerializationInfo m_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003348 RID: 13128
		private static readonly IntPtr NativeFieldInfoPtr_m_memberName;

		// Token: 0x04003349 RID: 13129
		private static readonly IntPtr NativeFieldInfoPtr_m_reflectedType;

		// Token: 0x0400334A RID: 13130
		private static readonly IntPtr NativeFieldInfoPtr_m_signature;

		// Token: 0x0400334B RID: 13131
		private static readonly IntPtr NativeFieldInfoPtr_m_signature2;

		// Token: 0x0400334C RID: 13132
		private static readonly IntPtr NativeFieldInfoPtr_m_memberType;

		// Token: 0x0400334D RID: 13133
		private static readonly IntPtr NativeFieldInfoPtr_m_info;

		// Token: 0x0400334E RID: 13134
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_MemberTypes_0;

		// Token: 0x0400334F RID: 13135
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_String_MemberTypes_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04003350 RID: 13136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003351 RID: 13137
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003352 RID: 13138
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0;
	}
}
