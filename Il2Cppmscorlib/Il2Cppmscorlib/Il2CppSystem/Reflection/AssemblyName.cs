using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono;
using Il2CppSystem.Configuration.Assemblies;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200043E RID: 1086
	[Serializable]
	public sealed class AssemblyName : Object
	{
		// Token: 0x06003E78 RID: 15992 RVA: 0x0012BE1C File Offset: 0x0012A01C
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyName()
		{
			Il2CppClassPointerStore<AssemblyName>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr);
			AssemblyName.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "name");
			AssemblyName.NativeFieldInfoPtr_codebase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "codebase");
			AssemblyName.NativeFieldInfoPtr_major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "major");
			AssemblyName.NativeFieldInfoPtr_minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "minor");
			AssemblyName.NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "build");
			AssemblyName.NativeFieldInfoPtr_revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "revision");
			AssemblyName.NativeFieldInfoPtr_cultureinfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "cultureinfo");
			AssemblyName.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "flags");
			AssemblyName.NativeFieldInfoPtr_hashalg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "hashalg");
			AssemblyName.NativeFieldInfoPtr_keypair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "keypair");
			AssemblyName.NativeFieldInfoPtr_publicKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "publicKey");
			AssemblyName.NativeFieldInfoPtr_keyToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "keyToken");
			AssemblyName.NativeFieldInfoPtr_versioncompat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "versioncompat");
			AssemblyName.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "version");
			AssemblyName.NativeFieldInfoPtr_processor_architecture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "processor_architecture");
			AssemblyName.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "contentType");
			AssemblyName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672710);
			AssemblyName.NativeMethodInfoPtr_ParseAssemblyName_Private_Static_Boolean_IntPtr_byref_MonoAssemblyName_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672711);
			AssemblyName.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672712);
			AssemblyName.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672713);
			AssemblyName.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672714);
			AssemblyName.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672715);
			AssemblyName.NativeMethodInfoPtr_get_CultureInfo_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672716);
			AssemblyName.NativeMethodInfoPtr_set_CultureInfo_Public_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672717);
			AssemblyName.NativeMethodInfoPtr_get_Flags_Public_get_AssemblyNameFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672718);
			AssemblyName.NativeMethodInfoPtr_set_Flags_Public_set_Void_AssemblyNameFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672719);
			AssemblyName.NativeMethodInfoPtr_get_FullName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672720);
			AssemblyName.NativeMethodInfoPtr_get_Version_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672721);
			AssemblyName.NativeMethodInfoPtr_set_Version_Public_set_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672722);
			AssemblyName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672723);
			AssemblyName.NativeMethodInfoPtr_GetPublicKey_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672724);
			AssemblyName.NativeMethodInfoPtr_GetPublicKeyToken_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672725);
			AssemblyName.NativeMethodInfoPtr_get_IsPublicKeyValid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672726);
			AssemblyName.NativeMethodInfoPtr_InternalGetPublicKeyToken_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672727);
			AssemblyName.NativeMethodInfoPtr_get_public_token_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672728);
			AssemblyName.NativeMethodInfoPtr_ComputePublicKeyToken_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672729);
			AssemblyName.NativeMethodInfoPtr_SetPublicKey_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672730);
			AssemblyName.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672731);
			AssemblyName.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672732);
			AssemblyName.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672733);
			AssemblyName.NativeMethodInfoPtr_GetNativeName_Private_Static_ptr_MonoAssemblyName_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672734);
			AssemblyName.NativeMethodInfoPtr_FillName_Internal_Void_ptr_MonoAssemblyName_String_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672735);
			AssemblyName.NativeMethodInfoPtr_Create_Internal_Static_AssemblyName_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100672736);
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x0012C1A8 File Offset: 0x0012A3A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1400572, RefRangeEnd = 1400573, XrefRangeStart = 1400571, XrefRangeEnd = 1400572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x0012C1E4 File Offset: 0x0012A3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400573, XrefRangeEnd = 1400574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &aname;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &is_version_definited;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &is_token_defined;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_ParseAssemblyName_Private_Static_Boolean_IntPtr_byref_MonoAssemblyName_byref_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x0012C24C File Offset: 0x0012A44C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1400584, RefRangeEnd = 1400592, XrefRangeStart = 1400574, XrefRangeEnd = 1400584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyName(string assemblyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x0012C298 File Offset: 0x0012A498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400592, XrefRangeEnd = 1400685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyName(SerializationInfo si, StreamingContext sc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(si);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06003E7D RID: 15997 RVA: 0x0012C2FC File Offset: 0x0012A4FC
		// (set) Token: 0x06003E7E RID: 15998 RVA: 0x0012C334 File Offset: 0x0012A534
		public unsafe string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06003E7F RID: 15999 RVA: 0x0012C378 File Offset: 0x0012A578
		// (set) Token: 0x06003E80 RID: 16000 RVA: 0x0012C3B8 File Offset: 0x0012A5B8
		public unsafe CultureInfo CultureInfo
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_CultureInfo_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_set_CultureInfo_Public_set_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06003E81 RID: 16001 RVA: 0x0012C3FC File Offset: 0x0012A5FC
		// (set) Token: 0x06003E82 RID: 16002 RVA: 0x0012C438 File Offset: 0x0012A638
		public unsafe AssemblyNameFlags Flags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_Flags_Public_get_AssemblyNameFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_set_Flags_Public_set_Void_AssemblyNameFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06003E83 RID: 16003 RVA: 0x0012C478 File Offset: 0x0012A678
		public unsafe string FullName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1400739, RefRangeEnd = 1400741, XrefRangeStart = 1400685, XrefRangeEnd = 1400739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_FullName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06003E84 RID: 16004 RVA: 0x0012C4B0 File Offset: 0x0012A6B0
		// (set) Token: 0x06003E85 RID: 16005 RVA: 0x0012C4F0 File Offset: 0x0012A6F0
		public unsafe Version Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_Version_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400741, XrefRangeEnd = 1400743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_set_Version_Public_set_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x0012C534 File Offset: 0x0012A734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400743, XrefRangeEnd = 1400745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x0012C56C File Offset: 0x0012A76C
		[CallerCount(0)]
		public unsafe Il2CppStructArray<byte> GetPublicKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_GetPublicKey_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x0012C5AC File Offset: 0x0012A7AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1400749, RefRangeEnd = 1400754, XrefRangeStart = 1400745, XrefRangeEnd = 1400749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetPublicKeyToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_GetPublicKeyToken_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06003E89 RID: 16009 RVA: 0x0012C5EC File Offset: 0x0012A7EC
		public unsafe bool IsPublicKeyValid
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1400756, RefRangeEnd = 1400759, XrefRangeStart = 1400754, XrefRangeEnd = 1400756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_IsPublicKeyValid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x0012C628 File Offset: 0x0012A828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400759, XrefRangeEnd = 1400765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> InternalGetPublicKeyToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_InternalGetPublicKeyToken_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x0012C668 File Offset: 0x0012A868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400765, XrefRangeEnd = 1400766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_public_token(byte* token, byte* pubkey, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pubkey;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_public_token_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E8C RID: 16012 RVA: 0x0012C6B4 File Offset: 0x0012A8B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1400771, RefRangeEnd = 1400774, XrefRangeStart = 1400766, XrefRangeEnd = 1400771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ComputePublicKeyToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_ComputePublicKeyToken_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003E8D RID: 16013 RVA: 0x0012C6F4 File Offset: 0x0012A8F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1400775, RefRangeEnd = 1400776, XrefRangeStart = 1400774, XrefRangeEnd = 1400775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPublicKey(Il2CppStructArray<byte> publicKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(publicKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_SetPublicKey_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x0012C738 File Offset: 0x0012A938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400776, XrefRangeEnd = 1400824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E8F RID: 16015 RVA: 0x0012C794 File Offset: 0x0012A994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400824, XrefRangeEnd = 1400835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003E90 RID: 16016 RVA: 0x0012C7D4 File Offset: 0x0012A9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400835, XrefRangeEnd = 1400837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x0012C818 File Offset: 0x0012AA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400837, XrefRangeEnd = 1400838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref assembly_ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_GetNativeName_Private_Static_ptr_MonoAssemblyName_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x0012C84C File Offset: 0x0012AA4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1400866, RefRangeEnd = 1400869, XrefRangeStart = 1400838, XrefRangeEnd = 1400866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = native;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(codeBase);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addVersion;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addPublickey;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultToken;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemblyRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_FillName_Internal_Void_ptr_MonoAssemblyName_String_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x0012C8D4 File Offset: 0x0012AAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400869, XrefRangeEnd = 1400876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssemblyName Create(Assembly assembly, bool fillCodebase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillCodebase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_Create_Internal_Static_AssemblyName_Assembly_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssemblyName>(intPtr3) : null;
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x00016C71 File Offset: 0x00014E71
		public AssemblyName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06003E95 RID: 16021 RVA: 0x0012C928 File Offset: 0x0012AB28
		// (set) Token: 0x06003E96 RID: 16022 RVA: 0x00016C7A File Offset: 0x00014E7A
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06003E97 RID: 16023 RVA: 0x0012C950 File Offset: 0x0012AB50
		// (set) Token: 0x06003E98 RID: 16024 RVA: 0x00016C99 File Offset: 0x00014E99
		public unsafe string codebase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_codebase);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_codebase), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06003E99 RID: 16025 RVA: 0x0012C978 File Offset: 0x0012AB78
		// (set) Token: 0x06003E9A RID: 16026 RVA: 0x00016CB8 File Offset: 0x00014EB8
		public unsafe int major
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_major);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_major)) = value;
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06003E9B RID: 16027 RVA: 0x0012C9A0 File Offset: 0x0012ABA0
		// (set) Token: 0x06003E9C RID: 16028 RVA: 0x00016CD3 File Offset: 0x00014ED3
		public unsafe int minor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_minor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_minor)) = value;
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06003E9D RID: 16029 RVA: 0x0012C9C8 File Offset: 0x0012ABC8
		// (set) Token: 0x06003E9E RID: 16030 RVA: 0x00016CEE File Offset: 0x00014EEE
		public unsafe int build
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_build);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_build)) = value;
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06003E9F RID: 16031 RVA: 0x0012C9F0 File Offset: 0x0012ABF0
		// (set) Token: 0x06003EA0 RID: 16032 RVA: 0x00016D09 File Offset: 0x00014F09
		public unsafe int revision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_revision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_revision)) = value;
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06003EA1 RID: 16033 RVA: 0x0012CA18 File Offset: 0x0012AC18
		// (set) Token: 0x06003EA2 RID: 16034 RVA: 0x00016D24 File Offset: 0x00014F24
		public unsafe CultureInfo cultureinfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_cultureinfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_cultureinfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06003EA3 RID: 16035 RVA: 0x0012CA48 File Offset: 0x0012AC48
		// (set) Token: 0x06003EA4 RID: 16036 RVA: 0x00016D43 File Offset: 0x00014F43
		public unsafe AssemblyNameFlags flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06003EA5 RID: 16037 RVA: 0x0012CA70 File Offset: 0x0012AC70
		// (set) Token: 0x06003EA6 RID: 16038 RVA: 0x00016D5E File Offset: 0x00014F5E
		public unsafe AssemblyHashAlgorithm hashalg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_hashalg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_hashalg)) = value;
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06003EA7 RID: 16039 RVA: 0x0012CA98 File Offset: 0x0012AC98
		// (set) Token: 0x06003EA8 RID: 16040 RVA: 0x00016D79 File Offset: 0x00014F79
		public unsafe StrongNameKeyPair keypair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_keypair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StrongNameKeyPair>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_keypair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06003EA9 RID: 16041 RVA: 0x0012CAC8 File Offset: 0x0012ACC8
		// (set) Token: 0x06003EAA RID: 16042 RVA: 0x00016D98 File Offset: 0x00014F98
		public unsafe Il2CppStructArray<byte> publicKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_publicKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_publicKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06003EAB RID: 16043 RVA: 0x0012CAF8 File Offset: 0x0012ACF8
		// (set) Token: 0x06003EAC RID: 16044 RVA: 0x00016DB7 File Offset: 0x00014FB7
		public unsafe Il2CppStructArray<byte> keyToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_keyToken);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_keyToken), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06003EAD RID: 16045 RVA: 0x0012CB28 File Offset: 0x0012AD28
		// (set) Token: 0x06003EAE RID: 16046 RVA: 0x00016DD6 File Offset: 0x00014FD6
		public unsafe AssemblyVersionCompatibility versioncompat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_versioncompat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_versioncompat)) = value;
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06003EAF RID: 16047 RVA: 0x0012CB50 File Offset: 0x0012AD50
		// (set) Token: 0x06003EB0 RID: 16048 RVA: 0x00016DF1 File Offset: 0x00014FF1
		public unsafe Version version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06003EB1 RID: 16049 RVA: 0x0012CB80 File Offset: 0x0012AD80
		// (set) Token: 0x06003EB2 RID: 16050 RVA: 0x00016E10 File Offset: 0x00015010
		public unsafe ProcessorArchitecture processor_architecture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_processor_architecture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_processor_architecture)) = value;
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06003EB3 RID: 16051 RVA: 0x0012CBA8 File Offset: 0x0012ADA8
		// (set) Token: 0x06003EB4 RID: 16052 RVA: 0x00016E2B File Offset: 0x0001502B
		public unsafe AssemblyContentType contentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_contentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_contentType)) = value;
			}
		}

		// Token: 0x04003384 RID: 13188
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003385 RID: 13189
		private static readonly IntPtr NativeFieldInfoPtr_codebase;

		// Token: 0x04003386 RID: 13190
		private static readonly IntPtr NativeFieldInfoPtr_major;

		// Token: 0x04003387 RID: 13191
		private static readonly IntPtr NativeFieldInfoPtr_minor;

		// Token: 0x04003388 RID: 13192
		private static readonly IntPtr NativeFieldInfoPtr_build;

		// Token: 0x04003389 RID: 13193
		private static readonly IntPtr NativeFieldInfoPtr_revision;

		// Token: 0x0400338A RID: 13194
		private static readonly IntPtr NativeFieldInfoPtr_cultureinfo;

		// Token: 0x0400338B RID: 13195
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x0400338C RID: 13196
		private static readonly IntPtr NativeFieldInfoPtr_hashalg;

		// Token: 0x0400338D RID: 13197
		private static readonly IntPtr NativeFieldInfoPtr_keypair;

		// Token: 0x0400338E RID: 13198
		private static readonly IntPtr NativeFieldInfoPtr_publicKey;

		// Token: 0x0400338F RID: 13199
		private static readonly IntPtr NativeFieldInfoPtr_keyToken;

		// Token: 0x04003390 RID: 13200
		private static readonly IntPtr NativeFieldInfoPtr_versioncompat;

		// Token: 0x04003391 RID: 13201
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04003392 RID: 13202
		private static readonly IntPtr NativeFieldInfoPtr_processor_architecture;

		// Token: 0x04003393 RID: 13203
		private static readonly IntPtr NativeFieldInfoPtr_contentType;

		// Token: 0x04003394 RID: 13204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003395 RID: 13205
		private static readonly IntPtr NativeMethodInfoPtr_ParseAssemblyName_Private_Static_Boolean_IntPtr_byref_MonoAssemblyName_byref_Boolean_byref_Boolean_0;

		// Token: 0x04003396 RID: 13206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04003397 RID: 13207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003398 RID: 13208
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04003399 RID: 13209
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x0400339A RID: 13210
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureInfo_Public_get_CultureInfo_0;

		// Token: 0x0400339B RID: 13211
		private static readonly IntPtr NativeMethodInfoPtr_set_CultureInfo_Public_set_Void_CultureInfo_0;

		// Token: 0x0400339C RID: 13212
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_get_AssemblyNameFlags_0;

		// Token: 0x0400339D RID: 13213
		private static readonly IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_AssemblyNameFlags_0;

		// Token: 0x0400339E RID: 13214
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_get_String_0;

		// Token: 0x0400339F RID: 13215
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Version_0;

		// Token: 0x040033A0 RID: 13216
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Public_set_Void_Version_0;

		// Token: 0x040033A1 RID: 13217
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040033A2 RID: 13218
		private static readonly IntPtr NativeMethodInfoPtr_GetPublicKey_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x040033A3 RID: 13219
		private static readonly IntPtr NativeMethodInfoPtr_GetPublicKeyToken_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x040033A4 RID: 13220
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPublicKeyValid_Private_get_Boolean_0;

		// Token: 0x040033A5 RID: 13221
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetPublicKeyToken_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x040033A6 RID: 13222
		private static readonly IntPtr NativeMethodInfoPtr_get_public_token_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x040033A7 RID: 13223
		private static readonly IntPtr NativeMethodInfoPtr_ComputePublicKeyToken_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x040033A8 RID: 13224
		private static readonly IntPtr NativeMethodInfoPtr_SetPublicKey_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040033A9 RID: 13225
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040033AA RID: 13226
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x040033AB RID: 13227
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x040033AC RID: 13228
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeName_Private_Static_ptr_MonoAssemblyName_IntPtr_0;

		// Token: 0x040033AD RID: 13229
		private static readonly IntPtr NativeMethodInfoPtr_FillName_Internal_Void_ptr_MonoAssemblyName_String_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040033AE RID: 13230
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_AssemblyName_Assembly_Boolean_0;
	}
}
