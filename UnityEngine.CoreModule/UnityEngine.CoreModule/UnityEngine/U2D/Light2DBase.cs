using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.U2D
{
	// Token: 0x02000184 RID: 388
	public class Light2DBase : MonoBehaviour
	{
		// Token: 0x06001D19 RID: 7449 RVA: 0x0000AD1B File Offset: 0x00008F1B
		// Note: this type is marked as 'beforefieldinit'.
		static Light2DBase()
		{
			Il2CppClassPointerStore<Light2DBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "Light2DBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Light2DBase>.NativeClassPtr);
			Light2DBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DBase>.NativeClassPtr, 100667389);
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00086034 File Offset: 0x00084234
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Light2DBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Light2DBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x0000AD54 File Offset: 0x00008F54
		public Light2DBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
