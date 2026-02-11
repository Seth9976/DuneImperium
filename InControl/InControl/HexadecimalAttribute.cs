using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000039 RID: 57
	public class HexadecimalAttribute : PropertyAttribute
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x00003D94 File Offset: 0x00001F94
		// Note: this type is marked as 'beforefieldinit'.
		static HexadecimalAttribute()
		{
			Il2CppClassPointerStore<HexadecimalAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "HexadecimalAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HexadecimalAttribute>.NativeClassPtr);
			HexadecimalAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexadecimalAttribute>.NativeClassPtr, 100663934);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00019108 File Offset: 0x00017308
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HexadecimalAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HexadecimalAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexadecimalAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00003DCD File Offset: 0x00001FCD
		public HexadecimalAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
