using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.util
{
	// Token: 0x0200008B RID: 139
	public class EnumFlagsAttribute : PropertyAttribute
	{
		// Token: 0x06000A10 RID: 2576 RVA: 0x00005893 File Offset: 0x00003A93
		// Note: this type is marked as 'beforefieldinit'.
		static EnumFlagsAttribute()
		{
			Il2CppClassPointerStore<EnumFlagsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "EnumFlagsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumFlagsAttribute>.NativeClassPtr);
			EnumFlagsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumFlagsAttribute>.NativeClassPtr, 100664696);
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x0003A020 File Offset: 0x00038220
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumFlagsAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumFlagsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumFlagsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x000058CC File Offset: 0x00003ACC
		public EnumFlagsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
