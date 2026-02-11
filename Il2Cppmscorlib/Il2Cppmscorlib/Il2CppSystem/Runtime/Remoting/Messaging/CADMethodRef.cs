using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002ED RID: 749
	[Serializable]
	public class CADMethodRef : Object
	{
		// Token: 0x06002E69 RID: 11881 RVA: 0x000EFC2C File Offset: 0x000EDE2C
		// Note: this type is marked as 'beforefieldinit'.
		static CADMethodRef()
		{
			Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADMethodRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr);
			CADMethodRef.NativeFieldInfoPtr_ctor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "ctor");
			CADMethodRef.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "typeName");
			CADMethodRef.NativeFieldInfoPtr_methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "methodName");
			CADMethodRef.NativeFieldInfoPtr_param_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "param_names");
			CADMethodRef.NativeFieldInfoPtr_generic_arg_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "generic_arg_names");
			CADMethodRef.NativeMethodInfoPtr_GetTypes_Private_Il2CppReferenceArray_1_Type_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, 100670689);
			CADMethodRef.NativeMethodInfoPtr_Resolve_Public_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, 100670690);
			CADMethodRef.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, 100670691);
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x000EFCFC File Offset: 0x000EDEFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1382530, RefRangeEnd = 1382533, XrefRangeStart = 1382516, XrefRangeEnd = 1382530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Type> GetTypes(Il2CppStringArray typeArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodRef.NativeMethodInfoPtr_GetTypes_Private_Il2CppReferenceArray_1_Type_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x000EFD4C File Offset: 0x000EDF4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1382559, RefRangeEnd = 1382560, XrefRangeStart = 1382533, XrefRangeEnd = 1382559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodBase Resolve()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodRef.NativeMethodInfoPtr_Resolve_Public_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x000EFD8C File Offset: 0x000EDF8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1382578, RefRangeEnd = 1382579, XrefRangeStart = 1382560, XrefRangeEnd = 1382578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADMethodRef(IMethodMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodRef.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x0000FC0A File Offset: 0x0000DE0A
		public CADMethodRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06002E6E RID: 11886 RVA: 0x000EFDD8 File Offset: 0x000EDFD8
		// (set) Token: 0x06002E6F RID: 11887 RVA: 0x0000FC13 File Offset: 0x0000DE13
		public unsafe bool ctor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_ctor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_ctor)) = value;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06002E70 RID: 11888 RVA: 0x000EFE00 File Offset: 0x000EE000
		// (set) Token: 0x06002E71 RID: 11889 RVA: 0x0000FC2E File Offset: 0x0000DE2E
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06002E72 RID: 11890 RVA: 0x000EFE28 File Offset: 0x000EE028
		// (set) Token: 0x06002E73 RID: 11891 RVA: 0x0000FC4D File Offset: 0x0000DE4D
		public unsafe string methodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_methodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_methodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06002E74 RID: 11892 RVA: 0x000EFE50 File Offset: 0x000EE050
		// (set) Token: 0x06002E75 RID: 11893 RVA: 0x0000FC6C File Offset: 0x0000DE6C
		public unsafe Il2CppStringArray param_names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_param_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_param_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002E76 RID: 11894 RVA: 0x000EFE80 File Offset: 0x000EE080
		// (set) Token: 0x06002E77 RID: 11895 RVA: 0x0000FC8B File Offset: 0x0000DE8B
		public unsafe Il2CppStringArray generic_arg_names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_generic_arg_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_generic_arg_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026B1 RID: 9905
		private static readonly IntPtr NativeFieldInfoPtr_ctor;

		// Token: 0x040026B2 RID: 9906
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x040026B3 RID: 9907
		private static readonly IntPtr NativeFieldInfoPtr_methodName;

		// Token: 0x040026B4 RID: 9908
		private static readonly IntPtr NativeFieldInfoPtr_param_names;

		// Token: 0x040026B5 RID: 9909
		private static readonly IntPtr NativeFieldInfoPtr_generic_arg_names;

		// Token: 0x040026B6 RID: 9910
		private static readonly IntPtr NativeMethodInfoPtr_GetTypes_Private_Il2CppReferenceArray_1_Type_Il2CppStringArray_0;

		// Token: 0x040026B7 RID: 9911
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_MethodBase_0;

		// Token: 0x040026B8 RID: 9912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0;
	}
}
