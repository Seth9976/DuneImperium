using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000038 RID: 56
	public class ConstantBufferBase : Object
	{
		// Token: 0x060004B5 RID: 1205 RVA: 0x0001EA48 File Offset: 0x0001CC48
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantBufferBase()
		{
			Il2CppClassPointerStore<ConstantBufferBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ConstantBufferBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantBufferBase>.NativeClassPtr);
			ConstantBufferBase.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBufferBase>.NativeClassPtr, 100663873);
			ConstantBufferBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBufferBase>.NativeClassPtr, 100663874);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0001EAA0 File Offset: 0x0001CCA0
		[CallerCount(0)]
		public unsafe virtual void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstantBufferBase.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0001EADC File Offset: 0x0001CCDC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantBufferBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantBufferBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantBufferBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00003F6A File Offset: 0x0000216A
		public ConstantBufferBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
