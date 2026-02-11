using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core
{
	// Token: 0x02000024 RID: 36
	public sealed class InputIdListAttribute : PropertyAttribute
	{
		// Token: 0x0600010D RID: 269 RVA: 0x0000290F File Offset: 0x00000B0F
		// Note: this type is marked as 'beforefieldinit'.
		static InputIdListAttribute()
		{
			Il2CppClassPointerStore<InputIdListAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "InputIdListAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputIdListAttribute>.NativeClassPtr);
			InputIdListAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputIdListAttribute>.NativeClassPtr, 100663446);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000A780 File Offset: 0x00008980
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputIdListAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputIdListAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputIdListAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002948 File Offset: 0x00000B48
		public InputIdListAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
