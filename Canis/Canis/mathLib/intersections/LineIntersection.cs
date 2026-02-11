using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.mathLib.intersections
{
	// Token: 0x02000085 RID: 133
	[StructLayout(2)]
	public struct LineIntersection
	{
		// Token: 0x0600071B RID: 1819 RVA: 0x00036710 File Offset: 0x00034910
		// Note: this type is marked as 'beforefieldinit'.
		static LineIntersection()
		{
			Il2CppClassPointerStore<LineIntersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib.intersections", "LineIntersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineIntersection>.NativeClassPtr);
			LineIntersection.NativeFieldInfoPtr_Line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineIntersection>.NativeClassPtr, "Line");
			LineIntersection.NativeMethodInfoPtr__ctor_Public_Void_Line_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineIntersection>.NativeClassPtr, 100664769);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00036768 File Offset: 0x00034968
		[CallerCount(0)]
		public unsafe LineIntersection(Line line)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref line;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineIntersection.NativeMethodInfoPtr__ctor_Public_Void_Line_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00004B44 File Offset: 0x00002D44
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LineIntersection>.NativeClassPtr, ref this));
		}

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeFieldInfoPtr_Line;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Line_0;

		// Token: 0x040004F1 RID: 1265
		[FieldOffset(0)]
		public readonly Line Line;
	}
}
