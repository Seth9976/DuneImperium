using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x02000050 RID: 80
	[Serializable]
	public class DoubleVariable : Variable<double>
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x000039ED File Offset: 0x00001BED
		// Note: this type is marked as 'beforefieldinit'.
		static DoubleVariable()
		{
			Il2CppClassPointerStore<DoubleVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "DoubleVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleVariable>.NativeClassPtr);
			DoubleVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleVariable>.NativeClassPtr, 100664112);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00019D74 File Offset: 0x00017F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071185, XrefRangeEnd = 1071188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00003A26 File Offset: 0x00001C26
		public DoubleVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
