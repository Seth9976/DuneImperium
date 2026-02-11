using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Util
{
	// Token: 0x0200000A RID: 10
	public class RequestParameterAttribute : Attribute
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00005268 File Offset: 0x00003468
		// Note: this type is marked as 'beforefieldinit'.
		static RequestParameterAttribute()
		{
			Il2CppClassPointerStore<RequestParameterAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Util", "RequestParameterAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestParameterAttribute>.NativeClassPtr);
			RequestParameterAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestParameterAttribute>.NativeClassPtr, "name");
			RequestParameterAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestParameterAttribute>.NativeClassPtr, "type");
			RequestParameterAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestParameterAttribute>.NativeClassPtr, 100663333);
			RequestParameterAttribute.NativeMethodInfoPtr_get_Type_Public_get_RequestParameterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestParameterAttribute>.NativeClassPtr, 100663334);
			RequestParameterAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestParameterAttribute>.NativeClassPtr, 100663335);
			RequestParameterAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_RequestParameterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestParameterAttribute>.NativeClassPtr, 100663336);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00005310 File Offset: 0x00003510
		public unsafe string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestParameterAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00005348 File Offset: 0x00003548
		public unsafe RequestParameterType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestParameterAttribute.NativeMethodInfoPtr_get_Type_Public_get_RequestParameterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005384 File Offset: 0x00003584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209971, XrefRangeEnd = 1209973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestParameterAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestParameterAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestParameterAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000053D0 File Offset: 0x000035D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 660727, RefRangeEnd = 660732, XrefRangeStart = 660727, XrefRangeEnd = 660732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestParameterAttribute(string name, RequestParameterType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestParameterAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestParameterAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_RequestParameterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002197 File Offset: 0x00000397
		public RequestParameterAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0000542C File Offset: 0x0000362C
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000021A0 File Offset: 0x000003A0
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestParameterAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestParameterAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00005454 File Offset: 0x00003654
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000021BF File Offset: 0x000003BF
		public unsafe RequestParameterType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestParameterAttribute.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestParameterAttribute.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_RequestParameterType_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_RequestParameterType_0;
	}
}
