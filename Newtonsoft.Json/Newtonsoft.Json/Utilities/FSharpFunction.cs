using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000059 RID: 89
	public class FSharpFunction : Object
	{
		// Token: 0x060007F8 RID: 2040 RVA: 0x00037C78 File Offset: 0x00035E78
		// Note: this type is marked as 'beforefieldinit'.
		static FSharpFunction()
		{
			Il2CppClassPointerStore<FSharpFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "FSharpFunction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FSharpFunction>.NativeClassPtr);
			FSharpFunction.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpFunction>.NativeClassPtr, "_instance");
			FSharpFunction.NativeFieldInfoPtr__invoker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpFunction>.NativeClassPtr, "_invoker");
			FSharpFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodCall_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpFunction>.NativeClassPtr, 100664844);
			FSharpFunction.NativeMethodInfoPtr_Invoke_Public_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpFunction>.NativeClassPtr, 100664845);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00037CF8 File Offset: 0x00035EF8
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FSharpFunction(Object instance, MethodCall<Object, Object> invoker)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FSharpFunction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(invoker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodCall_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00037D58 File Offset: 0x00035F58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 743438, RefRangeEnd = 743441, XrefRangeStart = 743437, XrefRangeEnd = 743438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Invoke([Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpFunction.NativeMethodInfoPtr_Invoke_Public_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00004766 File Offset: 0x00002966
		public FSharpFunction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00037DB8 File Offset: 0x00035FB8
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x0000476F File Offset: 0x0000296F
		public unsafe Object _instance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpFunction.NativeFieldInfoPtr__instance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpFunction.NativeFieldInfoPtr__instance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00037DE8 File Offset: 0x00035FE8
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x0000478E File Offset: 0x0000298E
		public unsafe MethodCall<Object, Object> _invoker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpFunction.NativeFieldInfoPtr__invoker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpFunction.NativeFieldInfoPtr__invoker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeFieldInfoPtr__instance;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeFieldInfoPtr__invoker;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_MethodCall_2_Object_Object_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Object_Il2CppReferenceArray_1_Object_0;
	}
}
