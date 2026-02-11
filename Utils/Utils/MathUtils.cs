using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Utils
{
	// Token: 0x0200003B RID: 59
	public static class MathUtils : Object
	{
		// Token: 0x0600026D RID: 621 RVA: 0x00002AC8 File Offset: 0x00000CC8
		// Note: this type is marked as 'beforefieldinit'.
		static MathUtils()
		{
			Il2CppClassPointerStore<MathUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Utils", "MathUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathUtils>.NativeClassPtr);
			MathUtils.NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100663882);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000E9D8 File Offset: 0x0000CBD8
		[CallerCount(0)]
		public unsafe static int Clamp(int val, int min, int max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathUtils.NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002B01 File Offset: 0x00000D01
		public MathUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0;
	}
}
