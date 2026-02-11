using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000158 RID: 344
	public class GDKUnionGamepadProfile : InputDeviceProfile
	{
		// Token: 0x06000E96 RID: 3734 RVA: 0x0003B6C4 File Offset: 0x000398C4
		// Note: this type is marked as 'beforefieldinit'.
		static GDKUnionGamepadProfile()
		{
			Il2CppClassPointerStore<GDKUnionGamepadProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "GDKUnionGamepadProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GDKUnionGamepadProfile>.NativeClassPtr);
			GDKUnionGamepadProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GDKUnionGamepadProfile>.NativeClassPtr, 100665282);
			GDKUnionGamepadProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GDKUnionGamepadProfile>.NativeClassPtr, 100665283);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x0003B71C File Offset: 0x0003991C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816584, XrefRangeEnd = 816785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GDKUnionGamepadProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0003B758 File Offset: 0x00039958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816785, XrefRangeEnd = 816789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GDKUnionGamepadProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GDKUnionGamepadProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GDKUnionGamepadProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0000693E File Offset: 0x00004B3E
		public GDKUnionGamepadProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
