using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x02000045 RID: 69
	[Serializable]
	public class BoolVariable : Variable<bool>
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x00003717 File Offset: 0x00001917
		// Note: this type is marked as 'beforefieldinit'.
		static BoolVariable()
		{
			Il2CppClassPointerStore<BoolVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "BoolVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolVariable>.NativeClassPtr);
			BoolVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolVariable>.NativeClassPtr, 100664101);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00019AE0 File Offset: 0x00017CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071152, XrefRangeEnd = 1071155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00003750 File Offset: 0x00001950
		public BoolVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
