using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x02000095 RID: 149
	public class TraceFilter : Object
	{
		// Token: 0x06000AEA RID: 2794 RVA: 0x000457FC File Offset: 0x000439FC
		// Note: this type is marked as 'beforefieldinit'.
		static TraceFilter()
		{
			Il2CppClassPointerStore<TraceFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "TraceFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceFilter>.NativeClassPtr);
			TraceFilter.NativeMethodInfoPtr_ShouldTrace_Public_Abstract_Virtual_New_Boolean_TraceEventCache_String_TraceEventType_Int32_String_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceFilter>.NativeClassPtr, 100664926);
			TraceFilter.NativeMethodInfoPtr_ShouldTrace_Internal_Boolean_TraceEventCache_String_TraceEventType_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceFilter>.NativeClassPtr, 100664927);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00045854 File Offset: 0x00043A54
		[CallerCount(0)]
		public unsafe virtual bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, Il2CppReferenceArray<Object> args, Object data1, Il2CppReferenceArray<Object> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cache);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(formatOrMessage);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data1);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceFilter.NativeMethodInfoPtr_ShouldTrace_Public_Abstract_Virtual_New_Boolean_TraceEventCache_String_TraceEventType_Int32_String_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00045928 File Offset: 0x00043B28
		[CallerCount(0)]
		public unsafe bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cache);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(formatOrMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceFilter.NativeMethodInfoPtr_ShouldTrace_Internal_Boolean_TraceEventCache_String_TraceEventType_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00005D4E File Offset: 0x00003F4E
		public TraceFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_ShouldTrace_Public_Abstract_Virtual_New_Boolean_TraceEventCache_String_TraceEventType_Int32_String_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_ShouldTrace_Internal_Boolean_TraceEventCache_String_TraceEventType_Int32_String_0;
	}
}
