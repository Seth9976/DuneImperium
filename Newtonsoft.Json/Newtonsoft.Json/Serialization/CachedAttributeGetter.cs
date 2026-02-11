using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000070 RID: 112
	public static class CachedAttributeGetter<T> : Object where T : Attribute
	{
		// Token: 0x06000997 RID: 2455 RVA: 0x0003ED8C File Offset: 0x0003CF8C
		// Note: this type is marked as 'beforefieldinit'.
		static CachedAttributeGetter()
		{
			Il2CppClassPointerStore<CachedAttributeGetter<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "CachedAttributeGetter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedAttributeGetter<T>>.NativeClassPtr);
			CachedAttributeGetter<T>.NativeFieldInfoPtr_TypeAttributeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedAttributeGetter<T>>.NativeClassPtr, "TypeAttributeCache");
			CachedAttributeGetter<T>.NativeMethodInfoPtr_GetAttribute_Public_Static_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedAttributeGetter<T>>.NativeClassPtr, 100665139);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0003EE20 File Offset: 0x0003D020
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 746751, RefRangeEnd = 746756, XrefRangeStart = 746727, XrefRangeEnd = 746751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetAttribute(Object type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedAttributeGetter<T>.NativeMethodInfoPtr_GetAttribute_Public_Static_T_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00004EF8 File Offset: 0x000030F8
		public CachedAttributeGetter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0003EE60 File Offset: 0x0003D060
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x00004F01 File Offset: 0x00003101
		public unsafe static ThreadSafeStore<Object, T> TypeAttributeCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CachedAttributeGetter<T>.NativeFieldInfoPtr_TypeAttributeCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadSafeStore<Object, T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CachedAttributeGetter<T>.NativeFieldInfoPtr_TypeAttributeCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeFieldInfoPtr_TypeAttributeCache;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Static_T_Object_0;
	}
}
