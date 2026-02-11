using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.mathLib.intersections
{
	// Token: 0x0200007E RID: 126
	[StructLayout(2)]
	public struct CircleIntersection
	{
		// Token: 0x060006FA RID: 1786 RVA: 0x00035F4C File Offset: 0x0003414C
		// Note: this type is marked as 'beforefieldinit'.
		static CircleIntersection()
		{
			Il2CppClassPointerStore<CircleIntersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib.intersections", "CircleIntersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircleIntersection>.NativeClassPtr);
			CircleIntersection.NativeFieldInfoPtr_Circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleIntersection>.NativeClassPtr, "Circle");
			CircleIntersection.NativeMethodInfoPtr__ctor_Public_Void_Circle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleIntersection>.NativeClassPtr, 100664743);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00035FA4 File Offset: 0x000341A4
		[CallerCount(0)]
		public unsafe CircleIntersection(Circle circle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref circle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleIntersection.NativeMethodInfoPtr__ctor_Public_Void_Circle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00004A90 File Offset: 0x00002C90
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CircleIntersection>.NativeClassPtr, ref this));
		}

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeFieldInfoPtr_Circle;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Circle_0;

		// Token: 0x040004DA RID: 1242
		[FieldOffset(0)]
		public readonly Circle Circle;
	}
}
