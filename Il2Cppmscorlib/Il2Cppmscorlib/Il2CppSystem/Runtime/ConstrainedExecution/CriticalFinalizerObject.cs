using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.ConstrainedExecution
{
	// Token: 0x020003A7 RID: 935
	public class CriticalFinalizerObject : Object
	{
		// Token: 0x060038B3 RID: 14515 RVA: 0x00113C48 File Offset: 0x00111E48
		// Note: this type is marked as 'beforefieldinit'.
		static CriticalFinalizerObject()
		{
			Il2CppClassPointerStore<CriticalFinalizerObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ConstrainedExecution", "CriticalFinalizerObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CriticalFinalizerObject>.NativeClassPtr);
			CriticalFinalizerObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CriticalFinalizerObject>.NativeClassPtr, 100671772);
			CriticalFinalizerObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CriticalFinalizerObject>.NativeClassPtr, 100671773);
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x00113CA0 File Offset: 0x00111EA0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CriticalFinalizerObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CriticalFinalizerObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CriticalFinalizerObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x00113CDC File Offset: 0x00111EDC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 867019, RefRangeEnd = 867033, XrefRangeStart = 867019, XrefRangeEnd = 867033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CriticalFinalizerObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x00014CF3 File Offset: 0x00012EF3
		public CriticalFinalizerObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E4F RID: 11855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002E50 RID: 11856
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
