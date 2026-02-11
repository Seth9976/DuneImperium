using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000411 RID: 1041
	public static class IntrospectionExtensions : Object
	{
		// Token: 0x06003C0D RID: 15373 RVA: 0x000164F4 File Offset: 0x000146F4
		// Note: this type is marked as 'beforefieldinit'.
		static IntrospectionExtensions()
		{
			Il2CppClassPointerStore<IntrospectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "IntrospectionExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntrospectionExtensions>.NativeClassPtr);
			IntrospectionExtensions.NativeMethodInfoPtr_GetTypeInfo_Public_Static_TypeInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntrospectionExtensions>.NativeClassPtr, 100672255);
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x00120074 File Offset: 0x0011E274
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1398515, RefRangeEnd = 1398527, XrefRangeStart = 1398496, XrefRangeEnd = 1398515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeInfo GetTypeInfo(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntrospectionExtensions.NativeMethodInfoPtr_GetTypeInfo_Public_Static_TypeInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x0001652D File Offset: 0x0001472D
		public IntrospectionExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040030BF RID: 12479
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInfo_Public_Static_TypeInfo_Type_0;
	}
}
