using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x0200003E RID: 62
	[StructLayout(2)]
	public struct NativeArrayDisposeJob
	{
		// Token: 0x06000239 RID: 569 RVA: 0x0001C130 File Offset: 0x0001A330
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArrayDisposeJob()
		{
			Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArrayDisposeJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr);
			NativeArrayDisposeJob.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr, "Data");
			NativeArrayDisposeJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr, 100663482);
			NativeArrayDisposeJob.NativeMethodInfoPtr_RegisterNativeArrayDisposeJobReflectionData_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr, 100663483);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0001C19C File Offset: 0x0001A39C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 643775, RefRangeEnd = 643776, XrefRangeStart = 643775, XrefRangeEnd = 643776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayDisposeJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0001C1C4 File Offset: 0x0001A3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643776, XrefRangeEnd = 643779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterNativeArrayDisposeJobReflectionData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayDisposeJob.NativeMethodInfoPtr_RegisterNativeArrayDisposeJobReflectionData_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000327F File Offset: 0x0000147F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr, ref this));
		}

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr_Data;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_RegisterNativeArrayDisposeJobReflectionData_Internal_Static_Void_0;

		// Token: 0x040001C6 RID: 454
		[FieldOffset(0)]
		public NativeArrayDispose Data;
	}
}
