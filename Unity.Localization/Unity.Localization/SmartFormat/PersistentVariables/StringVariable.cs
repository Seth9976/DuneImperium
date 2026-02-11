using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x0200004E RID: 78
	[Serializable]
	public class StringVariable : Variable<string>
	{
		// Token: 0x0600044D RID: 1101 RVA: 0x00003969 File Offset: 0x00001B69
		// Note: this type is marked as 'beforefieldinit'.
		static StringVariable()
		{
			Il2CppClassPointerStore<StringVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "StringVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringVariable>.NativeClassPtr);
			StringVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringVariable>.NativeClassPtr, 100664110);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00019CFC File Offset: 0x00017EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071179, XrefRangeEnd = 1071182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000039A2 File Offset: 0x00001BA2
		public StringVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
