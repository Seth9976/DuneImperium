using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x02000049 RID: 73
	[Serializable]
	public class UShortVariable : Variable<ushort>
	{
		// Token: 0x0600043E RID: 1086 RVA: 0x0000381F File Offset: 0x00001A1F
		// Note: this type is marked as 'beforefieldinit'.
		static UShortVariable()
		{
			Il2CppClassPointerStore<UShortVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "UShortVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UShortVariable>.NativeClassPtr);
			UShortVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UShortVariable>.NativeClassPtr, 100664105);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00019BD0 File Offset: 0x00017DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071164, XrefRangeEnd = 1071167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UShortVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UShortVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UShortVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00003858 File Offset: 0x00001A58
		public UShortVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
