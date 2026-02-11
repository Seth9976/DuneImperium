using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public class AndroidJavaClass : AndroidJavaObject
	{
		// Token: 0x0600007B RID: 123 RVA: 0x000052C4 File Offset: 0x000034C4
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJavaClass()
		{
			Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJavaClass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr);
			AndroidJavaClass.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr, 100663342);
			AndroidJavaClass.NativeMethodInfoPtr__AndroidJavaClass_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr, 100663343);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000531C File Offset: 0x0000351C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1228401, RefRangeEnd = 1228406, XrefRangeStart = 1228380, XrefRangeEnd = 1228401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaClass(string className)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaClass.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00005368 File Offset: 0x00003568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228406, XrefRangeEnd = 1228426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AndroidJavaClass(string className)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaClass.NativeMethodInfoPtr__AndroidJavaClass_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002347 File Offset: 0x00000547
		public AndroidJavaClass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr__AndroidJavaClass_Private_Void_String_0;
	}
}
