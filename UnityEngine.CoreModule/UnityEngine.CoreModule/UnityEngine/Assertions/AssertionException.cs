using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Assertions
{
	// Token: 0x02000288 RID: 648
	public class AssertionException : Exception
	{
		// Token: 0x06002C47 RID: 11335 RVA: 0x000B2184 File Offset: 0x000B0384
		// Note: this type is marked as 'beforefieldinit'.
		static AssertionException()
		{
			Il2CppClassPointerStore<AssertionException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Assertions", "AssertionException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssertionException>.NativeClassPtr);
			AssertionException.NativeFieldInfoPtr_m_UserMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssertionException>.NativeClassPtr, "m_UserMessage");
			AssertionException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionException>.NativeClassPtr, 100668689);
			AssertionException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionException>.NativeClassPtr, 100668690);
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000B21F0 File Offset: 0x000B03F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686641, XrefRangeEnd = 686646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssertionException(string message, string userMessage)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssertionException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x000B2250 File Offset: 0x000B0450
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686646, XrefRangeEnd = 686650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssertionException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x000112E8 File Offset: 0x0000F4E8
		public AssertionException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x000B2294 File Offset: 0x000B0494
		// (set) Token: 0x06002C4C RID: 11340 RVA: 0x000112F1 File Offset: 0x0000F4F1
		public unsafe string m_UserMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssertionException.NativeFieldInfoPtr_m_UserMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssertionException.NativeFieldInfoPtr_m_UserMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400278F RID: 10127
		private static readonly IntPtr NativeFieldInfoPtr_m_UserMessage;

		// Token: 0x04002790 RID: 10128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04002791 RID: 10129
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;
	}
}
