using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000009 RID: 9
	public class VisibleToOtherModulesAttribute : Attribute
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002CF4 File Offset: 0x00000EF4
		// Note: this type is marked as 'beforefieldinit'.
		static VisibleToOtherModulesAttribute()
		{
			Il2CppClassPointerStore<VisibleToOtherModulesAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "VisibleToOtherModulesAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibleToOtherModulesAttribute>.NativeClassPtr);
			VisibleToOtherModulesAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleToOtherModulesAttribute>.NativeClassPtr, 100663307);
			VisibleToOtherModulesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleToOtherModulesAttribute>.NativeClassPtr, 100663308);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002D4C File Offset: 0x00000F4C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibleToOtherModulesAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibleToOtherModulesAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleToOtherModulesAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002D88 File Offset: 0x00000F88
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibleToOtherModulesAttribute([Optional] Il2CppStringArray modules)
		{
			if (modules == null)
			{
				modules = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibleToOtherModulesAttribute>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(modules);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleToOtherModulesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002265 File Offset: 0x00000465
		public VisibleToOtherModulesAttribute(params string[] modules)
			: this(new Il2CppStringArray(modules))
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002273 File Offset: 0x00000473
		public VisibleToOtherModulesAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;
	}
}
