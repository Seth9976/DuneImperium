using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003AD RID: 941
	public sealed class CallerMemberNameAttribute : Attribute
	{
		// Token: 0x060038E4 RID: 14564 RVA: 0x00014EA6 File Offset: 0x000130A6
		// Note: this type is marked as 'beforefieldinit'.
		static CallerMemberNameAttribute()
		{
			Il2CppClassPointerStore<CallerMemberNameAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "CallerMemberNameAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallerMemberNameAttribute>.NativeClassPtr);
			CallerMemberNameAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallerMemberNameAttribute>.NativeClassPtr, 100671791);
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x00114704 File Offset: 0x00112904
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallerMemberNameAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallerMemberNameAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallerMemberNameAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x00014EDF File Offset: 0x000130DF
		public CallerMemberNameAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E6A RID: 11882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
