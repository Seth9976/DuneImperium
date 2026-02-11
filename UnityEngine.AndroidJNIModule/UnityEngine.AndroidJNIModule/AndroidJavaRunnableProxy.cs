using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public class AndroidJavaRunnableProxy : AndroidJavaProxy
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00003084 File Offset: 0x00001284
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJavaRunnableProxy()
		{
			Il2CppClassPointerStore<AndroidJavaRunnableProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJavaRunnableProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJavaRunnableProxy>.NativeClassPtr);
			AndroidJavaRunnableProxy.NativeFieldInfoPtr_mRunnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaRunnableProxy>.NativeClassPtr, "mRunnable");
			AndroidJavaRunnableProxy.NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaRunnable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaRunnableProxy>.NativeClassPtr, 100663305);
			AndroidJavaRunnableProxy.NativeMethodInfoPtr_run_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaRunnableProxy>.NativeClassPtr, 100663306);
			AndroidJavaRunnableProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_IntPtr_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaRunnableProxy>.NativeClassPtr, 100663307);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003104 File Offset: 0x00001304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227307, XrefRangeEnd = 1227319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaRunnableProxy(AndroidJavaRunnable runnable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaRunnableProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(runnable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaRunnableProxy.NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaRunnable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003150 File Offset: 0x00001350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227319, XrefRangeEnd = 1227320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaRunnableProxy.NativeMethodInfoPtr_run_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003184 File Offset: 0x00001384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227320, XrefRangeEnd = 1227326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr Invoke(string methodName, IntPtr javaArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref javaArgs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaRunnableProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_IntPtr_String_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020E7 File Offset: 0x000002E7
		public AndroidJavaRunnableProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000031EC File Offset: 0x000013EC
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020F0 File Offset: 0x000002F0
		public unsafe AndroidJavaRunnable mRunnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaRunnableProxy.NativeFieldInfoPtr_mRunnable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidJavaRunnable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaRunnableProxy.NativeFieldInfoPtr_mRunnable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_mRunnable;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaRunnable_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_run_Public_Void_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_IntPtr_String_IntPtr_0;
	}
}
