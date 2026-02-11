using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x0200000D RID: 13
	[StructLayout(2)]
	public struct FontEngineUtilities
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00002A83 File Offset: 0x00000C83
		// Note: this type is marked as 'beforefieldinit'.
		static FontEngineUtilities()
		{
			Il2CppClassPointerStore<FontEngineUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "FontEngineUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontEngineUtilities>.NativeClassPtr);
			FontEngineUtilities.NativeMethodInfoPtr_MaxValue_Internal_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngineUtilities>.NativeClassPtr, 100663399);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00006A18 File Offset: 0x00004C18
		[CallerCount(0)]
		public unsafe static int MaxValue(int a, int b, int c)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngineUtilities.NativeMethodInfoPtr_MaxValue_Internal_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002ABC File Offset: 0x00000CBC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FontEngineUtilities>.NativeClassPtr, ref this));
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00006A74 File Offset: 0x00004C74
		public static bool Approximately(float a, float b)
		{
			return Mathf.Abs(a - b) < 0.001f;
		}

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_MaxValue_Internal_Static_Int32_Int32_Int32_Int32_0;
	}
}
