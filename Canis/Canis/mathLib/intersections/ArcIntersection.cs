using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.mathLib.intersections
{
	// Token: 0x0200007D RID: 125
	[StructLayout(2)]
	public struct ArcIntersection
	{
		// Token: 0x060006F7 RID: 1783 RVA: 0x00035EC0 File Offset: 0x000340C0
		// Note: this type is marked as 'beforefieldinit'.
		static ArcIntersection()
		{
			Il2CppClassPointerStore<ArcIntersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib.intersections", "ArcIntersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcIntersection>.NativeClassPtr);
			ArcIntersection.NativeFieldInfoPtr_Arc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcIntersection>.NativeClassPtr, "Arc");
			ArcIntersection.NativeMethodInfoPtr__ctor_Public_Void_Arc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcIntersection>.NativeClassPtr, 100664742);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00035F18 File Offset: 0x00034118
		[CallerCount(0)]
		public unsafe ArcIntersection(Arc arc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcIntersection.NativeMethodInfoPtr__ctor_Public_Void_Arc_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00004A7E File Offset: 0x00002C7E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArcIntersection>.NativeClassPtr, ref this));
		}

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeFieldInfoPtr_Arc;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Arc_0;

		// Token: 0x040004D7 RID: 1239
		[FieldOffset(0)]
		public readonly Arc Arc;
	}
}
