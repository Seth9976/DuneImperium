using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine._Scripting.APIUpdating
{
	// Token: 0x02000182 RID: 386
	public class APIUpdaterRuntimeHelpers : Object
	{
		// Token: 0x06001D0F RID: 7439 RVA: 0x00085D24 File Offset: 0x00083F24
		// Note: this type is marked as 'beforefieldinit'.
		static APIUpdaterRuntimeHelpers()
		{
			Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine._Scripting.APIUpdating", "APIUpdaterRuntimeHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr);
			APIUpdaterRuntimeHelpers.NativeMethodInfoPtr_GetMovedFromAttributeDataForType_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr, 100667383);
			APIUpdaterRuntimeHelpers.NativeMethodInfoPtr_GetObsoleteTypeRedirection_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr, 100667384);
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00085D7C File Offset: 0x00083F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677376, XrefRangeEnd = 677390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMovedFromAttributeDataForType(Type sourceType, out string assembly, out string nsp, out string klass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(APIUpdaterRuntimeHelpers.NativeMethodInfoPtr_GetMovedFromAttributeDataForType_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			assembly = IL2CPP.Il2CppStringToManaged(intPtr);
			nsp = IL2CPP.Il2CppStringToManaged(intPtr2);
			klass = IL2CPP.Il2CppStringToManaged(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00085E10 File Offset: 0x00084010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677390, XrefRangeEnd = 677424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetObsoleteTypeRedirection(Type sourceType, out string assemblyName, out string nsp, out string className)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(APIUpdaterRuntimeHelpers.NativeMethodInfoPtr_GetObsoleteTypeRedirection_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			assemblyName = IL2CPP.Il2CppStringToManaged(intPtr);
			nsp = IL2CPP.Il2CppStringToManaged(intPtr2);
			className = IL2CPP.Il2CppStringToManaged(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x0000AD09 File Offset: 0x00008F09
		public APIUpdaterRuntimeHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeMethodInfoPtr_GetMovedFromAttributeDataForType_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeMethodInfoPtr_GetObsoleteTypeRedirection_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0;
	}
}
