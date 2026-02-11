using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F9 RID: 249
	[StructLayout(2)]
	public struct GradientColorKey
	{
		// Token: 0x06001386 RID: 4998 RVA: 0x00061B04 File Offset: 0x0005FD04
		// Note: this type is marked as 'beforefieldinit'.
		static GradientColorKey()
		{
			Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GradientColorKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr);
			GradientColorKey.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr, "color");
			GradientColorKey.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr, "time");
			GradientColorKey.NativeMethodInfoPtr__ctor_Public_Void_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr, 100666051);
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00061B70 File Offset: 0x0005FD70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 658282, RefRangeEnd = 658284, XrefRangeStart = 658282, XrefRangeEnd = 658282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GradientColorKey(Color col, float time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref col;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientColorKey.NativeMethodInfoPtr__ctor_Public_Void_Color_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00008060 File Offset: 0x00006260
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr, ref this));
		}

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400128B RID: 4747
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Single_0;

		// Token: 0x0400128D RID: 4749
		[FieldOffset(0)]
		public Color color;

		// Token: 0x0400128E RID: 4750
		[FieldOffset(16)]
		public float time;
	}
}
