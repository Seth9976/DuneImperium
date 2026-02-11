using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x0200004B RID: 75
	[Serializable]
	public class UIntVariable : Variable<uint>
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x000038A3 File Offset: 0x00001AA3
		// Note: this type is marked as 'beforefieldinit'.
		static UIntVariable()
		{
			Il2CppClassPointerStore<UIntVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "UIntVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIntVariable>.NativeClassPtr);
			UIntVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntVariable>.NativeClassPtr, 100664107);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00019C48 File Offset: 0x00017E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071170, XrefRangeEnd = 1071173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIntVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIntVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000038DC File Offset: 0x00001ADC
		public UIntVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
