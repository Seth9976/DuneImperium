using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000216 RID: 534
	public static class CommandBufferExtensions : Object
	{
		// Token: 0x06002453 RID: 9299 RVA: 0x0009C16C File Offset: 0x0009A36C
		// Note: this type is marked as 'beforefieldinit'.
		static CommandBufferExtensions()
		{
			Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CommandBufferExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr);
			CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100668043);
			CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100668044);
			CommandBufferExtensions.NativeMethodInfoPtr_SwitchIntoFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100668045);
			CommandBufferExtensions.NativeMethodInfoPtr_SwitchOutOfFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100668046);
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x0009C1EC File Offset: 0x0009A3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683094, XrefRangeEnd = 683096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SwitchIntoFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fastMemoryFlags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref residency;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyContents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x0009C25C File Offset: 0x0009A45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683096, XrefRangeEnd = 683098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SwitchOutOfFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, bool copyContents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyContents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x0009C2B0 File Offset: 0x0009A4B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 683100, RefRangeEnd = 683102, XrefRangeStart = 683098, XrefRangeEnd = 683100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SwitchIntoFastMemory(this CommandBuffer cmd, RenderTargetIdentifier rid, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fastMemoryFlags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref residency;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyContents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBufferExtensions.NativeMethodInfoPtr_SwitchIntoFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x0009C320 File Offset: 0x0009A520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683104, RefRangeEnd = 683105, XrefRangeStart = 683102, XrefRangeEnd = 683104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SwitchOutOfFastMemory(this CommandBuffer cmd, RenderTargetIdentifier rid, bool copyContents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyContents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBufferExtensions.NativeMethodInfoPtr_SwitchOutOfFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x0000E48B File Offset: 0x0000C68B
		public CommandBufferExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001FA6 RID: 8102
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0;

		// Token: 0x04001FA7 RID: 8103
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_Boolean_0;

		// Token: 0x04001FA8 RID: 8104
		private static readonly IntPtr NativeMethodInfoPtr_SwitchIntoFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0;

		// Token: 0x04001FA9 RID: 8105
		private static readonly IntPtr NativeMethodInfoPtr_SwitchOutOfFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Boolean_0;
	}
}
