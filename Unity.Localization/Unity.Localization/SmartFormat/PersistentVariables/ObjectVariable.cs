using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x02000051 RID: 81
	[Serializable]
	public class ObjectVariable : Variable<Object>
	{
		// Token: 0x06000456 RID: 1110 RVA: 0x00003A2F File Offset: 0x00001C2F
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectVariable()
		{
			Il2CppClassPointerStore<ObjectVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "ObjectVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectVariable>.NativeClassPtr);
			ObjectVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectVariable>.NativeClassPtr, 100664113);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00019DB0 File Offset: 0x00017FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071188, XrefRangeEnd = 1071191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00003A68 File Offset: 0x00001C68
		public ObjectVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
