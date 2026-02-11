using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200013E RID: 318
	[Serializable]
	public class UnitySerializationHolder : Object
	{
		// Token: 0x060015C2 RID: 5570 RVA: 0x0008F934 File Offset: 0x0008DB34
		// Note: this type is marked as 'beforefieldinit'.
		static UnitySerializationHolder()
		{
			Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "UnitySerializationHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr);
			UnitySerializationHolder.NativeFieldInfoPtr_m_instantiation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_instantiation");
			UnitySerializationHolder.NativeFieldInfoPtr_m_elementTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_elementTypes");
			UnitySerializationHolder.NativeFieldInfoPtr_m_genericParameterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_genericParameterPosition");
			UnitySerializationHolder.NativeFieldInfoPtr_m_declaringType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_declaringType");
			UnitySerializationHolder.NativeFieldInfoPtr_m_declaringMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_declaringMethod");
			UnitySerializationHolder.NativeFieldInfoPtr_m_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_data");
			UnitySerializationHolder.NativeFieldInfoPtr_m_assemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_assemblyName");
			UnitySerializationHolder.NativeFieldInfoPtr_m_unityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_unityType");
			UnitySerializationHolder.NativeMethodInfoPtr_AddElementTypes_Internal_Static_RuntimeType_SerializationInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100667182);
			UnitySerializationHolder.NativeMethodInfoPtr_MakeElementTypes_Internal_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100667183);
			UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100667184);
			UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100667185);
			UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Int32_String_RuntimeAssembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100667186);
			UnitySerializationHolder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100667187);
			UnitySerializationHolder.NativeMethodInfoPtr_ThrowInsufficientInformation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100667188);
			UnitySerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100667189);
			UnitySerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100667190);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x0008FAB8 File Offset: 0x0008DCB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1343697, RefRangeEnd = 1343698, XrefRangeStart = 1343664, XrefRangeEnd = 1343697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_AddElementTypes_Internal_Static_RuntimeType_SerializationInfo_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x0008FB10 File Offset: 0x0008DD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343698, XrefRangeEnd = 1343701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type MakeElementTypes(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_MakeElementTypes_Internal_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x0008FB60 File Offset: 0x0008DD60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1343723, RefRangeEnd = 1343724, XrefRangeStart = 1343701, XrefRangeEnd = 1343723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetUnitySerializationInfo(SerializationInfo info, int unityType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0008FBA4 File Offset: 0x0008DDA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1343768, RefRangeEnd = 1343769, XrefRangeStart = 1343724, XrefRangeEnd = 1343768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x0008FBEC File Offset: 0x0008DDEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1343793, RefRangeEnd = 1343796, XrefRangeStart = 1343769, XrefRangeEnd = 1343793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Int32_String_RuntimeAssembly_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0008FC54 File Offset: 0x0008DE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343796, XrefRangeEnd = 1343840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitySerializationHolder(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0008FCB8 File Offset: 0x0008DEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343840, XrefRangeEnd = 1343852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowInsufficientInformation(string field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(field);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_ThrowInsufficientInformation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0008FCFC File Offset: 0x0008DEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343852, XrefRangeEnd = 1343859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitySerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0008FD60 File Offset: 0x0008DF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343859, XrefRangeEnd = 1343872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitySerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00006B7C File Offset: 0x00004D7C
		public UnitySerializationHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x0008FDC0 File Offset: 0x0008DFC0
		// (set) Token: 0x060015CE RID: 5582 RVA: 0x00006B85 File Offset: 0x00004D85
		public unsafe Il2CppReferenceArray<Type> m_instantiation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_instantiation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_instantiation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x0008FDF0 File Offset: 0x0008DFF0
		// (set) Token: 0x060015D0 RID: 5584 RVA: 0x00006BA4 File Offset: 0x00004DA4
		public unsafe Il2CppStructArray<int> m_elementTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_elementTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_elementTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x0008FE20 File Offset: 0x0008E020
		// (set) Token: 0x060015D2 RID: 5586 RVA: 0x00006BC3 File Offset: 0x00004DC3
		public unsafe int m_genericParameterPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_genericParameterPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_genericParameterPosition)) = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x0008FE48 File Offset: 0x0008E048
		// (set) Token: 0x060015D4 RID: 5588 RVA: 0x00006BDE File Offset: 0x00004DDE
		public unsafe Type m_declaringType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_declaringType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_declaringType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060015D5 RID: 5589 RVA: 0x0008FE78 File Offset: 0x0008E078
		// (set) Token: 0x060015D6 RID: 5590 RVA: 0x00006BFD File Offset: 0x00004DFD
		public unsafe MethodBase m_declaringMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_declaringMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_declaringMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060015D7 RID: 5591 RVA: 0x0008FEA8 File Offset: 0x0008E0A8
		// (set) Token: 0x060015D8 RID: 5592 RVA: 0x00006C1C File Offset: 0x00004E1C
		public unsafe string m_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_data);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_data), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x0008FED0 File Offset: 0x0008E0D0
		// (set) Token: 0x060015DA RID: 5594 RVA: 0x00006C3B File Offset: 0x00004E3B
		public unsafe string m_assemblyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_assemblyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_assemblyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x0008FEF8 File Offset: 0x0008E0F8
		// (set) Token: 0x060015DC RID: 5596 RVA: 0x00006C5A File Offset: 0x00004E5A
		public unsafe int m_unityType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_unityType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_unityType)) = value;
			}
		}

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeFieldInfoPtr_m_instantiation;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeFieldInfoPtr_m_elementTypes;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeFieldInfoPtr_m_genericParameterPosition;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeFieldInfoPtr_m_declaringType;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeFieldInfoPtr_m_declaringMethod;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeFieldInfoPtr_m_data;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeFieldInfoPtr_m_assemblyName;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeFieldInfoPtr_m_unityType;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeMethodInfoPtr_AddElementTypes_Internal_Static_RuntimeType_SerializationInfo_RuntimeType_0;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeMethodInfoPtr_MakeElementTypes_Internal_Type_Type_0;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Int32_0;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_RuntimeType_0;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Int32_String_RuntimeAssembly_0;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInsufficientInformation_Private_Void_String_0;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0;
	}
}
