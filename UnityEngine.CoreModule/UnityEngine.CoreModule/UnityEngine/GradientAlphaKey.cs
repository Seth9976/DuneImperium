using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000FA RID: 250
	[StructLayout(2)]
	public struct GradientAlphaKey
	{
		// Token: 0x06001389 RID: 5001 RVA: 0x00061BB0 File Offset: 0x0005FDB0
		// Note: this type is marked as 'beforefieldinit'.
		static GradientAlphaKey()
		{
			Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GradientAlphaKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr);
			GradientAlphaKey.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, "alpha");
			GradientAlphaKey.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, "time");
			GradientAlphaKey.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, 100666052);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00061C1C File Offset: 0x0005FE1C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 611799, RefRangeEnd = 611804, XrefRangeStart = 611799, XrefRangeEnd = 611804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GradientAlphaKey(float alpha, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientAlphaKey.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00008072 File Offset: 0x00006272
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, ref this));
		}

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeFieldInfoPtr_alpha;

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04001292 RID: 4754
		[FieldOffset(0)]
		public float alpha;

		// Token: 0x04001293 RID: 4755
		[FieldOffset(4)]
		public float time;
	}
}
