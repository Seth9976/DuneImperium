using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x02000228 RID: 552
	public class RequestCache : Object
	{
		// Token: 0x060024CA RID: 9418 RVA: 0x00010001 File Offset: 0x0000E201
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCache()
		{
			Il2CppClassPointerStore<RequestCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCache>.NativeClassPtr);
			RequestCache.NativeFieldInfoPtr_LineSplits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCache>.NativeClassPtr, "LineSplits");
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x0001003A File Offset: 0x0000E23A
		public RequestCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x000A963C File Offset: 0x000A783C
		// (set) Token: 0x060024CD RID: 9421 RVA: 0x00010043 File Offset: 0x0000E243
		public unsafe static Il2CppStructArray<char> LineSplits
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RequestCache.NativeFieldInfoPtr_LineSplits, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestCache.NativeFieldInfoPtr_LineSplits, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C7B RID: 7291
		private static readonly IntPtr NativeFieldInfoPtr_LineSplits;
	}
}
