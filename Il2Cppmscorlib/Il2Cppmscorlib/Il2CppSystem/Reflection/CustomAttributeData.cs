using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200043F RID: 1087
	[Serializable]
	public class CustomAttributeData : Object
	{
		// Token: 0x06003EB5 RID: 16053 RVA: 0x0012CBD0 File Offset: 0x0012ADD0
		// Note: this type is marked as 'beforefieldinit'.
		static CustomAttributeData()
		{
			Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "CustomAttributeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr);
			CustomAttributeData.NativeFieldInfoPtr_ctorInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, "ctorInfo");
			CustomAttributeData.NativeFieldInfoPtr_ctorArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, "ctorArgs");
			CustomAttributeData.NativeFieldInfoPtr_namedArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, "namedArgs");
			CustomAttributeData.NativeFieldInfoPtr_lazyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, "lazyData");
			CustomAttributeData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672737);
			CustomAttributeData.NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_Assembly_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672738);
			CustomAttributeData.NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672739);
			CustomAttributeData.NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_IList_1_CustomAttributeTypedArgument_IList_1_CustomAttributeNamedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672740);
			CustomAttributeData.NativeMethodInfoPtr_ResolveArgumentsInternal_Private_Static_Void_ConstructorInfo_Assembly_IntPtr_UInt32_byref_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672741);
			CustomAttributeData.NativeMethodInfoPtr_ResolveArguments_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672742);
			CustomAttributeData.NativeMethodInfoPtr_get_Constructor_Public_Virtual_New_get_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672743);
			CustomAttributeData.NativeMethodInfoPtr_get_ConstructorArguments_Public_Virtual_New_get_IList_1_CustomAttributeTypedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672744);
			CustomAttributeData.NativeMethodInfoPtr_get_NamedArguments_Public_Virtual_New_get_IList_1_CustomAttributeNamedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672745);
			CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672746);
			CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672747);
			CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_IList_1_CustomAttributeData_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672748);
			CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672749);
			CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672750);
			CustomAttributeData.NativeMethodInfoPtr_get_AttributeType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672751);
			CustomAttributeData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672752);
			CustomAttributeData.NativeMethodInfoPtr_UnboxValues_Private_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672753);
			CustomAttributeData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672754);
			CustomAttributeData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100672755);
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x0012CDCC File Offset: 0x0012AFCC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x0012CE08 File Offset: 0x0012B008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400876, XrefRangeEnd = 1400884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data_length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_Assembly_IntPtr_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x0012CE84 File Offset: 0x0012B084
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1400894, RefRangeEnd = 1400901, XrefRangeStart = 1400884, XrefRangeEnd = 1400894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeData(ConstructorInfo ctorInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x0012CED0 File Offset: 0x0012B0D0
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 487194, RefRangeEnd = 487225, XrefRangeStart = 487194, XrefRangeEnd = 487225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeData(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctorArgs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namedArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_IList_1_CustomAttributeTypedArgument_IList_1_CustomAttributeNamedArgument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x0012CF40 File Offset: 0x0012B140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400901, XrefRangeEnd = 1400902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out Il2CppReferenceArray<Object> ctorArgs, out Il2CppReferenceArray<Object> namedArgs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data_length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_ResolveArgumentsInternal_Private_Static_Void_ConstructorInfo_Assembly_IntPtr_UInt32_byref_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			ctorArgs = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			namedArgs = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr6));
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x0012CFEC File Offset: 0x0012B1EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1400926, RefRangeEnd = 1400929, XrefRangeStart = 1400902, XrefRangeEnd = 1400926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResolveArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_ResolveArguments_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06003EBC RID: 16060 RVA: 0x0012D020 File Offset: 0x0012B220
		public unsafe virtual ConstructorInfo Constructor
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_get_Constructor_Public_Virtual_New_get_ConstructorInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06003EBD RID: 16061 RVA: 0x0012D06C File Offset: 0x0012B26C
		public unsafe virtual IList<CustomAttributeTypedArgument> ConstructorArguments
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400929, XrefRangeEnd = 1400930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_get_ConstructorArguments_Public_Virtual_New_get_IList_1_CustomAttributeTypedArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeTypedArgument>>(intPtr3) : null;
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06003EBE RID: 16062 RVA: 0x0012D0B8 File Offset: 0x0012B2B8
		public unsafe virtual IList<CustomAttributeNamedArgument> NamedArguments
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400930, XrefRangeEnd = 1400931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_get_NamedArguments_Public_Virtual_New_get_IList_1_CustomAttributeNamedArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeNamedArgument>>(intPtr3) : null;
			}
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x0012D104 File Offset: 0x0012B304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1400935, RefRangeEnd = 1400936, XrefRangeStart = 1400931, XrefRangeEnd = 1400935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributes(Assembly target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x0012D148 File Offset: 0x0012B348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1400940, RefRangeEnd = 1400942, XrefRangeStart = 1400936, XrefRangeEnd = 1400940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x0012D18C File Offset: 0x0012B38C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1400946, RefRangeEnd = 1400947, XrefRangeStart = 1400942, XrefRangeEnd = 1400946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_IList_1_CustomAttributeData_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x0012D1D0 File Offset: 0x0012B3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400947, XrefRangeEnd = 1400951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributes(Module target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Module_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x0012D214 File Offset: 0x0012B414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400951, XrefRangeEnd = 1400955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_ParameterInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06003EC4 RID: 16068 RVA: 0x0012D258 File Offset: 0x0012B458
		public unsafe Type AttributeType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 367110, RefRangeEnd = 367113, XrefRangeStart = 367110, XrefRangeEnd = 367113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_get_AttributeType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x0012D298 File Offset: 0x0012B498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400955, XrefRangeEnd = 1401010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x0012D2DC File Offset: 0x0012B4DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1401017, RefRangeEnd = 1401018, XrefRangeStart = 1401010, XrefRangeEnd = 1401017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> UnboxValues<T>(Il2CppReferenceArray<Object> values)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.MethodInfoStoreGeneric_UnboxValues_Private_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x0012D318 File Offset: 0x0012B518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401018, XrefRangeEnd = 1401071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x0012D370 File Offset: 0x0012B570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401071, XrefRangeEnd = 1401101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x00016E46 File Offset: 0x00015046
		public CustomAttributeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06003ECA RID: 16074 RVA: 0x0012D3B8 File Offset: 0x0012B5B8
		// (set) Token: 0x06003ECB RID: 16075 RVA: 0x00016E4F File Offset: 0x0001504F
		public unsafe ConstructorInfo ctorInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_ctorInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_ctorInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06003ECC RID: 16076 RVA: 0x0012D3E8 File Offset: 0x0012B5E8
		// (set) Token: 0x06003ECD RID: 16077 RVA: 0x00016E6E File Offset: 0x0001506E
		public unsafe IList<CustomAttributeTypedArgument> ctorArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_ctorArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeTypedArgument>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_ctorArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06003ECE RID: 16078 RVA: 0x0012D418 File Offset: 0x0012B618
		// (set) Token: 0x06003ECF RID: 16079 RVA: 0x00016E8D File Offset: 0x0001508D
		public unsafe IList<CustomAttributeNamedArgument> namedArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_namedArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeNamedArgument>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_namedArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06003ED0 RID: 16080 RVA: 0x0012D448 File Offset: 0x0012B648
		// (set) Token: 0x06003ED1 RID: 16081 RVA: 0x00016EAC File Offset: 0x000150AC
		public unsafe CustomAttributeData.LazyCAttrData lazyData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_lazyData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomAttributeData.LazyCAttrData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_lazyData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033AF RID: 13231
		private static readonly IntPtr NativeFieldInfoPtr_ctorInfo;

		// Token: 0x040033B0 RID: 13232
		private static readonly IntPtr NativeFieldInfoPtr_ctorArgs;

		// Token: 0x040033B1 RID: 13233
		private static readonly IntPtr NativeFieldInfoPtr_namedArgs;

		// Token: 0x040033B2 RID: 13234
		private static readonly IntPtr NativeFieldInfoPtr_lazyData;

		// Token: 0x040033B3 RID: 13235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040033B4 RID: 13236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_Assembly_IntPtr_UInt32_0;

		// Token: 0x040033B5 RID: 13237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_0;

		// Token: 0x040033B6 RID: 13238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_IList_1_CustomAttributeTypedArgument_IList_1_CustomAttributeNamedArgument_0;

		// Token: 0x040033B7 RID: 13239
		private static readonly IntPtr NativeMethodInfoPtr_ResolveArgumentsInternal_Private_Static_Void_ConstructorInfo_Assembly_IntPtr_UInt32_byref_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040033B8 RID: 13240
		private static readonly IntPtr NativeMethodInfoPtr_ResolveArguments_Private_Void_0;

		// Token: 0x040033B9 RID: 13241
		private static readonly IntPtr NativeMethodInfoPtr_get_Constructor_Public_Virtual_New_get_ConstructorInfo_0;

		// Token: 0x040033BA RID: 13242
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructorArguments_Public_Virtual_New_get_IList_1_CustomAttributeTypedArgument_0;

		// Token: 0x040033BB RID: 13243
		private static readonly IntPtr NativeMethodInfoPtr_get_NamedArguments_Public_Virtual_New_get_IList_1_CustomAttributeNamedArgument_0;

		// Token: 0x040033BC RID: 13244
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Assembly_0;

		// Token: 0x040033BD RID: 13245
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_MemberInfo_0;

		// Token: 0x040033BE RID: 13246
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_IList_1_CustomAttributeData_RuntimeType_0;

		// Token: 0x040033BF RID: 13247
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Module_0;

		// Token: 0x040033C0 RID: 13248
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_ParameterInfo_0;

		// Token: 0x040033C1 RID: 13249
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeType_Public_get_Type_0;

		// Token: 0x040033C2 RID: 13250
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040033C3 RID: 13251
		private static readonly IntPtr NativeMethodInfoPtr_UnboxValues_Private_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040033C4 RID: 13252
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040033C5 RID: 13253
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x020006BF RID: 1727
		public class LazyCAttrData : Object
		{
			// Token: 0x06005CA3 RID: 23715 RVA: 0x001A4270 File Offset: 0x001A2470
			// Note: this type is marked as 'beforefieldinit'.
			static LazyCAttrData()
			{
				Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, "LazyCAttrData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr);
				CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr, "assembly");
				CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr, "data");
				CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr, "data_length");
				CustomAttributeData.LazyCAttrData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr, 100672756);
			}

			// Token: 0x06005CA4 RID: 23716 RVA: 0x001A42EC File Offset: 0x001A24EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LazyCAttrData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.LazyCAttrData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005CA5 RID: 23717 RVA: 0x000219D6 File Offset: 0x0001FBD6
			public LazyCAttrData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017B6 RID: 6070
			// (get) Token: 0x06005CA6 RID: 23718 RVA: 0x001A4328 File Offset: 0x001A2528
			// (set) Token: 0x06005CA7 RID: 23719 RVA: 0x000219DF File Offset: 0x0001FBDF
			public unsafe Assembly assembly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_assembly);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_assembly), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017B7 RID: 6071
			// (get) Token: 0x06005CA8 RID: 23720 RVA: 0x001A4358 File Offset: 0x001A2558
			// (set) Token: 0x06005CA9 RID: 23721 RVA: 0x000219FE File Offset: 0x0001FBFE
			public unsafe IntPtr data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data)) = value;
				}
			}

			// Token: 0x170017B8 RID: 6072
			// (get) Token: 0x06005CAA RID: 23722 RVA: 0x001A4380 File Offset: 0x001A2580
			// (set) Token: 0x06005CAB RID: 23723 RVA: 0x00021A19 File Offset: 0x0001FC19
			public unsafe uint data_length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data_length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data_length)) = value;
				}
			}

			// Token: 0x04004B40 RID: 19264
			private static readonly IntPtr NativeFieldInfoPtr_assembly;

			// Token: 0x04004B41 RID: 19265
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04004B42 RID: 19266
			private static readonly IntPtr NativeFieldInfoPtr_data_length;

			// Token: 0x04004B43 RID: 19267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020006C0 RID: 1728
		private sealed class MethodInfoStoreGeneric_UnboxValues_Private_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0<T>
		{
			// Token: 0x04004B44 RID: 19268
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomAttributeData.NativeMethodInfoPtr_UnboxValues_Private_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
