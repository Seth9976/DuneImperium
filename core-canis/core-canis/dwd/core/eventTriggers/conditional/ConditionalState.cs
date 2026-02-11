using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.eventTriggers.conditional
{
	// Token: 0x020001AC RID: 428
	public class ConditionalState : Object
	{
		// Token: 0x06001845 RID: 6213 RVA: 0x00074EA4 File Offset: 0x000730A4
		// Note: this type is marked as 'beforefieldinit'.
		static ConditionalState()
		{
			Il2CppClassPointerStore<ConditionalState>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.eventTriggers.conditional", "ConditionalState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalState>.NativeClassPtr);
			ConditionalState.NativeMethodInfoPtr_Satisfied_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalState>.NativeClassPtr, 100667179);
			ConditionalState.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalState>.NativeClassPtr, 100667180);
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00074EFC File Offset: 0x000730FC
		[CallerCount(0)]
		public unsafe virtual bool Satisfied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionalState.NativeMethodInfoPtr_Satisfied_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00074F44 File Offset: 0x00073144
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConditionalState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalState.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0000AA67 File Offset: 0x00008C67
		public ConditionalState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeMethodInfoPtr_Satisfied_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
