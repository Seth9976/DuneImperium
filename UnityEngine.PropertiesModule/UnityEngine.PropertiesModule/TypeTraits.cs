using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x0200001C RID: 28
	public static class TypeTraits : Object
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x000026E4 File Offset: 0x000008E4
		// Note: this type is marked as 'beforefieldinit'.
		static TypeTraits()
		{
			Il2CppClassPointerStore<TypeTraits>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "TypeTraits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeTraits>.NativeClassPtr);
			TypeTraits.NativeMethodInfoPtr_IsContainer_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTraits>.NativeClassPtr, 100663384);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00006098 File Offset: 0x00004298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230940, RefRangeEnd = 1230941, XrefRangeStart = 1230928, XrefRangeEnd = 1230940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsContainer(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTraits.NativeMethodInfoPtr_IsContainer_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000271D File Offset: 0x0000091D
		public TypeTraits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_IsContainer_Public_Static_Boolean_Type_0;
	}
}
