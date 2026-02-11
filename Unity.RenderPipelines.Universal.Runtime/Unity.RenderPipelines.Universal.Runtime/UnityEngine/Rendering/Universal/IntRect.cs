using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000010 RID: 16
	[StructLayout(2)]
	public struct IntRect
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x00018530 File Offset: 0x00016730
		// Note: this type is marked as 'beforefieldinit'.
		static IntRect()
		{
			Il2CppClassPointerStore<IntRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "IntRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntRect>.NativeClassPtr);
			IntRect.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntRect>.NativeClassPtr, "left");
			IntRect.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntRect>.NativeClassPtr, "top");
			IntRect.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntRect>.NativeClassPtr, "right");
			IntRect.NativeFieldInfoPtr_bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntRect>.NativeClassPtr, "bottom");
			IntRect.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100663425);
			IntRect.NativeMethodInfoPtr__ctor_Public_Void_IntRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntRect>.NativeClassPtr, 100663426);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000185D8 File Offset: 0x000167D8
		[CallerCount(0)]
		public unsafe IntRect(long l, long t, long r, long b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref l;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntRect.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_Int64_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00018634 File Offset: 0x00016834
		[CallerCount(0)]
		public unsafe IntRect(IntRect ir)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ir;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntRect.NativeMethodInfoPtr__ctor_Public_Void_IntRect_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000025AF File Offset: 0x000007AF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IntRect>.NativeClassPtr, ref this));
		}

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_bottom;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_Int64_Int64_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntRect_0;

		// Token: 0x040000B4 RID: 180
		[FieldOffset(0)]
		public long left;

		// Token: 0x040000B5 RID: 181
		[FieldOffset(8)]
		public long top;

		// Token: 0x040000B6 RID: 182
		[FieldOffset(16)]
		public long right;

		// Token: 0x040000B7 RID: 183
		[FieldOffset(24)]
		public long bottom;
	}
}
