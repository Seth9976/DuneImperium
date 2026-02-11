using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x0200004F RID: 79
	[Serializable]
	public class FloatVariable : Variable<float>
	{
		// Token: 0x06000450 RID: 1104 RVA: 0x000039AB File Offset: 0x00001BAB
		// Note: this type is marked as 'beforefieldinit'.
		static FloatVariable()
		{
			Il2CppClassPointerStore<FloatVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "FloatVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatVariable>.NativeClassPtr);
			FloatVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatVariable>.NativeClassPtr, 100664111);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00019D38 File Offset: 0x00017F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071182, XrefRangeEnd = 1071185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloatVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000039E4 File Offset: 0x00001BE4
		public FloatVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
