using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x0200004A RID: 74
	[Serializable]
	public class IntVariable : Variable<int>
	{
		// Token: 0x06000441 RID: 1089 RVA: 0x00003861 File Offset: 0x00001A61
		// Note: this type is marked as 'beforefieldinit'.
		static IntVariable()
		{
			Il2CppClassPointerStore<IntVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "IntVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntVariable>.NativeClassPtr);
			IntVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVariable>.NativeClassPtr, 100664106);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00019C0C File Offset: 0x00017E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071167, XrefRangeEnd = 1071170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000389A File Offset: 0x00001A9A
		public IntVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
