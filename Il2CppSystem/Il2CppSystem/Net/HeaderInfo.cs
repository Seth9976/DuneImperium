using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001CD RID: 461
	public class HeaderInfo : Object
	{
		// Token: 0x06001C76 RID: 7286 RVA: 0x0008B420 File Offset: 0x00089620
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderInfo()
		{
			Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HeaderInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr);
			HeaderInfo.NativeFieldInfoPtr_IsRequestRestricted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "IsRequestRestricted");
			HeaderInfo.NativeFieldInfoPtr_IsResponseRestricted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "IsResponseRestricted");
			HeaderInfo.NativeFieldInfoPtr_Parser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "Parser");
			HeaderInfo.NativeFieldInfoPtr_HeaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "HeaderName");
			HeaderInfo.NativeFieldInfoPtr_AllowMultiValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "AllowMultiValues");
			HeaderInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_Boolean_HeaderParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, 100667668);
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0008B4C8 File Offset: 0x000896C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476065, XrefRangeEnd = 476068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestRestricted;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref responseRestricted;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multi;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_Boolean_HeaderParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x0000C16B File Offset: 0x0000A36B
		public HeaderInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x0008B550 File Offset: 0x00089750
		// (set) Token: 0x06001C7A RID: 7290 RVA: 0x0000C174 File Offset: 0x0000A374
		public unsafe bool IsRequestRestricted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_IsRequestRestricted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_IsRequestRestricted)) = value;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x0008B578 File Offset: 0x00089778
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x0000C18F File Offset: 0x0000A38F
		public unsafe bool IsResponseRestricted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_IsResponseRestricted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_IsResponseRestricted)) = value;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x0008B5A0 File Offset: 0x000897A0
		// (set) Token: 0x06001C7E RID: 7294 RVA: 0x0000C1AA File Offset: 0x0000A3AA
		public unsafe HeaderParser Parser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_Parser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderParser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_Parser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x0008B5D0 File Offset: 0x000897D0
		// (set) Token: 0x06001C80 RID: 7296 RVA: 0x0000C1C9 File Offset: 0x0000A3C9
		public unsafe string HeaderName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_HeaderName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_HeaderName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x0008B5F8 File Offset: 0x000897F8
		// (set) Token: 0x06001C82 RID: 7298 RVA: 0x0000C1E8 File Offset: 0x0000A3E8
		public unsafe bool AllowMultiValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_AllowMultiValues);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_AllowMultiValues)) = value;
			}
		}

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeFieldInfoPtr_IsRequestRestricted;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeFieldInfoPtr_IsResponseRestricted;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeFieldInfoPtr_Parser;

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeFieldInfoPtr_HeaderName;

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeFieldInfoPtr_AllowMultiValues;

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_Boolean_HeaderParser_0;
	}
}
