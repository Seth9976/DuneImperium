using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public sealed class AndroidJavaException : Exception
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002DC0 File Offset: 0x00000FC0
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJavaException()
		{
			Il2CppClassPointerStore<AndroidJavaException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJavaException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJavaException>.NativeClassPtr);
			AndroidJavaException.NativeFieldInfoPtr_mJavaStackTrace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaException>.NativeClassPtr, "mJavaStackTrace");
			AndroidJavaException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaException>.NativeClassPtr, 100663299);
			AndroidJavaException.NativeMethodInfoPtr_get_StackTrace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaException>.NativeClassPtr, 100663300);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002E2C File Offset: 0x0000102C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227289, XrefRangeEnd = 1227294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaException(string message, string javaStackTrace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(javaStackTrace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002E8C File Offset: 0x0000108C
		public unsafe override string StackTrace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227294, XrefRangeEnd = 1227296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaException.NativeMethodInfoPtr_get_StackTrace_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002080 File Offset: 0x00000280
		public AndroidJavaException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002EC4 File Offset: 0x000010C4
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002089 File Offset: 0x00000289
		public unsafe string mJavaStackTrace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaException.NativeFieldInfoPtr_mJavaStackTrace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaException.NativeFieldInfoPtr_mJavaStackTrace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_mJavaStackTrace;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_StackTrace_Public_Virtual_get_String_0;
	}
}
