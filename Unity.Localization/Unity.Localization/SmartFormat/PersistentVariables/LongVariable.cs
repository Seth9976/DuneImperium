using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x0200004C RID: 76
	[Serializable]
	public class LongVariable : Variable<long>
	{
		// Token: 0x06000447 RID: 1095 RVA: 0x000038E5 File Offset: 0x00001AE5
		// Note: this type is marked as 'beforefieldinit'.
		static LongVariable()
		{
			Il2CppClassPointerStore<LongVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "LongVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongVariable>.NativeClassPtr);
			LongVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongVariable>.NativeClassPtr, 100664108);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00019C84 File Offset: 0x00017E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071173, XrefRangeEnd = 1071176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LongVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000391E File Offset: 0x00001B1E
		public LongVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
