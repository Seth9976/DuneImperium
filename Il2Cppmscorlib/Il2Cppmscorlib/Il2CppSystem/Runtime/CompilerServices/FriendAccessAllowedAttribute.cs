using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003DB RID: 987
	public sealed class FriendAccessAllowedAttribute : Attribute
	{
		// Token: 0x06003A09 RID: 14857 RVA: 0x0001594B File Offset: 0x00013B4B
		// Note: this type is marked as 'beforefieldinit'.
		static FriendAccessAllowedAttribute()
		{
			Il2CppClassPointerStore<FriendAccessAllowedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "FriendAccessAllowedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendAccessAllowedAttribute>.NativeClassPtr);
			FriendAccessAllowedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendAccessAllowedAttribute>.NativeClassPtr, 100671958);
		}

		// Token: 0x06003A0A RID: 14858 RVA: 0x00118054 File Offset: 0x00116254
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendAccessAllowedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendAccessAllowedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendAccessAllowedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x00015984 File Offset: 0x00013B84
		public FriendAccessAllowedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002F07 RID: 12039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
