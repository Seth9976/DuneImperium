using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x0200004D RID: 77
	[Serializable]
	public class ULongVariable : Variable<ulong>
	{
		// Token: 0x0600044A RID: 1098 RVA: 0x00003927 File Offset: 0x00001B27
		// Note: this type is marked as 'beforefieldinit'.
		static ULongVariable()
		{
			Il2CppClassPointerStore<ULongVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "ULongVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ULongVariable>.NativeClassPtr);
			ULongVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ULongVariable>.NativeClassPtr, 100664109);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00019CC0 File Offset: 0x00017EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071176, XrefRangeEnd = 1071179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ULongVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ULongVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ULongVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00003960 File Offset: 0x00001B60
		public ULongVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
