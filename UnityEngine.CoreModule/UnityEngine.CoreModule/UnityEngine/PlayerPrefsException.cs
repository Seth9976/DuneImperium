using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200010B RID: 267
	public class PlayerPrefsException : Exception
	{
		// Token: 0x06001667 RID: 5735 RVA: 0x00008D24 File Offset: 0x00006F24
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerPrefsException()
		{
			Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PlayerPrefsException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr);
			PlayerPrefsException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr, 100666410);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x0006C428 File Offset: 0x0006A628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660052, XrefRangeEnd = 660056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerPrefsException(string error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefsException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00008D5D File Offset: 0x00006F5D
		public PlayerPrefsException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
