using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000095 RID: 149
	public static class ConvertHelper : Object
	{
		// Token: 0x06000825 RID: 2085 RVA: 0x0000426B File Offset: 0x0000246B
		// Note: this type is marked as 'beforefieldinit'.
		static ConvertHelper()
		{
			Il2CppClassPointerStore<ConvertHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "ConvertHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConvertHelper>.NativeClassPtr);
			ConvertHelper.NativeMethodInfoPtr_ToInt32NoNull_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertHelper>.NativeClassPtr, 100664877);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00034B98 File Offset: 0x00032D98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1015692, RefRangeEnd = 1015696, XrefRangeStart = 1015685, XrefRangeEnd = 1015692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32NoNull(Object val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvertHelper.NativeMethodInfoPtr_ToInt32NoNull_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000042A4 File Offset: 0x000024A4
		public ConvertHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32NoNull_Public_Static_Int32_Object_0;
	}
}
