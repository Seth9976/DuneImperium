using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x02000047 RID: 71
	[Serializable]
	public class ByteVariable : Variable<byte>
	{
		// Token: 0x06000438 RID: 1080 RVA: 0x0000379B File Offset: 0x0000199B
		// Note: this type is marked as 'beforefieldinit'.
		static ByteVariable()
		{
			Il2CppClassPointerStore<ByteVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "ByteVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteVariable>.NativeClassPtr);
			ByteVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteVariable>.NativeClassPtr, 100664103);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00019B58 File Offset: 0x00017D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071158, XrefRangeEnd = 1071161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByteVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000037D4 File Offset: 0x000019D4
		public ByteVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
