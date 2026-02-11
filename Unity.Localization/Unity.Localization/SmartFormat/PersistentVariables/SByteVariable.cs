using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x02000046 RID: 70
	[Serializable]
	public class SByteVariable : Variable<sbyte>
	{
		// Token: 0x06000435 RID: 1077 RVA: 0x00003759 File Offset: 0x00001959
		// Note: this type is marked as 'beforefieldinit'.
		static SByteVariable()
		{
			Il2CppClassPointerStore<SByteVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "SByteVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SByteVariable>.NativeClassPtr);
			SByteVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SByteVariable>.NativeClassPtr, 100664102);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00019B1C File Offset: 0x00017D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071155, XrefRangeEnd = 1071158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SByteVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SByteVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SByteVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00003792 File Offset: 0x00001992
		public SByteVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
