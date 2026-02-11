using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000194 RID: 404
	public class HttpVersion : Object
	{
		// Token: 0x0600188B RID: 6283 RVA: 0x0007CBF4 File Offset: 0x0007ADF4
		// Note: this type is marked as 'beforefieldinit'.
		static HttpVersion()
		{
			Il2CppClassPointerStore<HttpVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpVersion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpVersion>.NativeClassPtr);
			HttpVersion.NativeFieldInfoPtr_Unknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpVersion>.NativeClassPtr, "Unknown");
			HttpVersion.NativeFieldInfoPtr_Version10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpVersion>.NativeClassPtr, "Version10");
			HttpVersion.NativeFieldInfoPtr_Version11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpVersion>.NativeClassPtr, "Version11");
			HttpVersion.NativeFieldInfoPtr_Version20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpVersion>.NativeClassPtr, "Version20");
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0000A85F File Offset: 0x00008A5F
		public HttpVersion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x0007CC74 File Offset: 0x0007AE74
		// (set) Token: 0x0600188E RID: 6286 RVA: 0x0000A868 File Offset: 0x00008A68
		public unsafe static Version Unknown
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpVersion.NativeFieldInfoPtr_Unknown, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpVersion.NativeFieldInfoPtr_Unknown, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x0007CC9C File Offset: 0x0007AE9C
		// (set) Token: 0x06001890 RID: 6288 RVA: 0x0000A87A File Offset: 0x00008A7A
		public unsafe static Version Version10
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpVersion.NativeFieldInfoPtr_Version10, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpVersion.NativeFieldInfoPtr_Version10, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x0007CCC4 File Offset: 0x0007AEC4
		// (set) Token: 0x06001892 RID: 6290 RVA: 0x0000A88C File Offset: 0x00008A8C
		public unsafe static Version Version11
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpVersion.NativeFieldInfoPtr_Version11, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpVersion.NativeFieldInfoPtr_Version11, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x0007CCEC File Offset: 0x0007AEEC
		// (set) Token: 0x06001894 RID: 6292 RVA: 0x0000A89E File Offset: 0x00008A9E
		public unsafe static Version Version20
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpVersion.NativeFieldInfoPtr_Version20, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpVersion.NativeFieldInfoPtr_Version20, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeFieldInfoPtr_Unknown;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeFieldInfoPtr_Version10;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeFieldInfoPtr_Version11;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeFieldInfoPtr_Version20;
	}
}
