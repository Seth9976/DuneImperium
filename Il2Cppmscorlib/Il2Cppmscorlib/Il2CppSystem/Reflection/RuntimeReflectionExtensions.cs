using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000435 RID: 1077
	public static class RuntimeReflectionExtensions : Object
	{
		// Token: 0x06003DF2 RID: 15858 RVA: 0x00016A02 File Offset: 0x00014C02
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeReflectionExtensions()
		{
			Il2CppClassPointerStore<RuntimeReflectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RuntimeReflectionExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeReflectionExtensions>.NativeClassPtr);
			RuntimeReflectionExtensions.NativeMethodInfoPtr_GetRuntimeField_Public_Static_FieldInfo_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeReflectionExtensions>.NativeClassPtr, 100672617);
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x00129510 File Offset: 0x00127710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1399709, RefRangeEnd = 1399711, XrefRangeStart = 1399697, XrefRangeEnd = 1399709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FieldInfo GetRuntimeField(this Type type, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeReflectionExtensions.NativeMethodInfoPtr_GetRuntimeField_Public_Static_FieldInfo_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x00016A3B File Offset: 0x00014C3B
		public RuntimeReflectionExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040032BB RID: 12987
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeField_Public_Static_FieldInfo_Type_String_0;
	}
}
