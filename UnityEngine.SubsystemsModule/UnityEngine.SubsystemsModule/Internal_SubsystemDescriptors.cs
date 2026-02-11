using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	public static class Internal_SubsystemDescriptors : Object
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002222 File Offset: 0x00000422
		// Note: this type is marked as 'beforefieldinit'.
		static Internal_SubsystemDescriptors()
		{
			Il2CppClassPointerStore<Internal_SubsystemDescriptors>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "Internal_SubsystemDescriptors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Internal_SubsystemDescriptors>.NativeClassPtr);
			Internal_SubsystemDescriptors.NativeMethodInfoPtr_Internal_AddDescriptor_Internal_Static_Void_SubsystemDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Internal_SubsystemDescriptors>.NativeClassPtr, 100663311);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002DDC File Offset: 0x00000FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270150, XrefRangeEnd = 1270160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_AddDescriptor(SubsystemDescriptor descriptor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Internal_SubsystemDescriptors.NativeMethodInfoPtr_Internal_AddDescriptor_Internal_Static_Void_SubsystemDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000225B File Offset: 0x0000045B
		public Internal_SubsystemDescriptors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_Internal_AddDescriptor_Internal_Static_Void_SubsystemDescriptor_0;
	}
}
