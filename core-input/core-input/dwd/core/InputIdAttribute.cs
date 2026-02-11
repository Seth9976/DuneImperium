using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core
{
	// Token: 0x02000023 RID: 35
	public sealed class InputIdAttribute : PropertyAttribute
	{
		// Token: 0x0600010A RID: 266 RVA: 0x000028CD File Offset: 0x00000ACD
		// Note: this type is marked as 'beforefieldinit'.
		static InputIdAttribute()
		{
			Il2CppClassPointerStore<InputIdAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "InputIdAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputIdAttribute>.NativeClassPtr);
			InputIdAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputIdAttribute>.NativeClassPtr, 100663445);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000A744 File Offset: 0x00008944
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputIdAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputIdAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputIdAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002906 File Offset: 0x00000B06
		public InputIdAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
