using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Android
{
	// Token: 0x0200000F RID: 15
	public static class AndroidApp : Object
	{
		// Token: 0x0600024C RID: 588 RVA: 0x00002A58 File Offset: 0x00000C58
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidApp()
		{
			Il2CppClassPointerStore<AndroidApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine.Android", "AndroidApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidApp>.NativeClassPtr);
			AndroidApp.NativeMethodInfoPtr_get_UnityPlayerRaw_Public_Static_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidApp>.NativeClassPtr, 100663531);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000BC34 File Offset: 0x00009E34
		public unsafe static IntPtr UnityPlayerRaw
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230375, XrefRangeEnd = 1230377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidApp.NativeMethodInfoPtr_get_UnityPlayerRaw_Public_Static_get_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002A91 File Offset: 0x00000C91
		public AndroidApp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00002A9A File Offset: 0x00000C9A
		public static AndroidJavaObject Context
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00002AA7 File Offset: 0x00000CA7
		public static AndroidJavaObject Activity
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002AB4 File Offset: 0x00000CB4
		public static void AcquireContextAndActivity()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00002AC1 File Offset: 0x00000CC1
		public static AndroidJavaObject UnityPlayer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_get_UnityPlayerRaw_Public_Static_get_IntPtr_0;
	}
}
