using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x02000048 RID: 72
	[Serializable]
	public class ShortVariable : Variable<short>
	{
		// Token: 0x0600043B RID: 1083 RVA: 0x000037DD File Offset: 0x000019DD
		// Note: this type is marked as 'beforefieldinit'.
		static ShortVariable()
		{
			Il2CppClassPointerStore<ShortVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "ShortVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortVariable>.NativeClassPtr);
			ShortVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortVariable>.NativeClassPtr, 100664104);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00019B94 File Offset: 0x00017D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071161, XrefRangeEnd = 1071164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShortVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00003816 File Offset: 0x00001A16
		public ShortVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
