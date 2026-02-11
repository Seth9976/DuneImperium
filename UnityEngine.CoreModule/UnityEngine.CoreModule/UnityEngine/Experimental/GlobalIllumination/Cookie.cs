using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000276 RID: 630
	[StructLayout(2)]
	public struct Cookie
	{
		// Token: 0x06002B17 RID: 11031 RVA: 0x000AEB24 File Offset: 0x000ACD24
		// Note: this type is marked as 'beforefieldinit'.
		static Cookie()
		{
			Il2CppClassPointerStore<Cookie>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "Cookie");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cookie>.NativeClassPtr);
			Cookie.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "instanceID");
			Cookie.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "scale");
			Cookie.NativeFieldInfoPtr_sizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "sizes");
			Cookie.NativeMethodInfoPtr_Defaults_Public_Static_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100668591);
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000AEBA4 File Offset: 0x000ACDA4
		[CallerCount(0)]
		public unsafe static Cookie Defaults()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_Defaults_Public_Static_Cookie_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x00010DD3 File Offset: 0x0000EFD3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Cookie>.NativeClassPtr, ref this));
		}

		// Token: 0x04002619 RID: 9753
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x0400261A RID: 9754
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x0400261B RID: 9755
		private static readonly IntPtr NativeFieldInfoPtr_sizes;

		// Token: 0x0400261C RID: 9756
		private static readonly IntPtr NativeMethodInfoPtr_Defaults_Public_Static_Cookie_0;

		// Token: 0x0400261D RID: 9757
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x0400261E RID: 9758
		[FieldOffset(4)]
		public float scale;

		// Token: 0x0400261F RID: 9759
		[FieldOffset(8)]
		public Vector2 sizes;
	}
}
