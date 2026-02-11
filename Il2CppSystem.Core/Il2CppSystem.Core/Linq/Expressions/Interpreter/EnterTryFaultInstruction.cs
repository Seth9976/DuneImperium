using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000A3 RID: 163
	public sealed class EnterTryFaultInstruction : IndexedBranchInstruction
	{
		// Token: 0x060008BD RID: 2237 RVA: 0x000370F0 File Offset: 0x000352F0
		// Note: this type is marked as 'beforefieldinit'.
		static EnterTryFaultInstruction()
		{
			Il2CppClassPointerStore<EnterTryFaultInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "EnterTryFaultInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnterTryFaultInstruction>.NativeClassPtr);
			EnterTryFaultInstruction.NativeFieldInfoPtr__tryHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnterTryFaultInstruction>.NativeClassPtr, "_tryHandler");
			EnterTryFaultInstruction.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterTryFaultInstruction>.NativeClassPtr, 100664958);
			EnterTryFaultInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterTryFaultInstruction>.NativeClassPtr, 100664959);
			EnterTryFaultInstruction.NativeMethodInfoPtr_get_ProducedContinuations_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterTryFaultInstruction>.NativeClassPtr, 100664960);
			EnterTryFaultInstruction.NativeMethodInfoPtr_get_Handler_Internal_get_TryFaultHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterTryFaultInstruction>.NativeClassPtr, 100664961);
			EnterTryFaultInstruction.NativeMethodInfoPtr_SetTryHandler_Internal_Void_TryFaultHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterTryFaultInstruction>.NativeClassPtr, 100664962);
			EnterTryFaultInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterTryFaultInstruction>.NativeClassPtr, 100664963);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x000371AC File Offset: 0x000353AC
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnterTryFaultInstruction(int targetIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnterTryFaultInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterTryFaultInstruction.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x000371F4 File Offset: 0x000353F4
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016180, XrefRangeEnd = 1016182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterTryFaultInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0003722C File Offset: 0x0003542C
		public unsafe override int ProducedContinuations
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterTryFaultInstruction.NativeMethodInfoPtr_get_ProducedContinuations_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00037268 File Offset: 0x00035468
		public unsafe TryFaultHandler Handler
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterTryFaultInstruction.NativeMethodInfoPtr_get_Handler_Internal_get_TryFaultHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TryFaultHandler>(intPtr3) : null;
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x000372A8 File Offset: 0x000354A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTryHandler(TryFaultHandler tryHandler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tryHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterTryFaultInstruction.NativeMethodInfoPtr_SetTryHandler_Internal_Void_TryFaultHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000372EC File Offset: 0x000354EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016182, XrefRangeEnd = 1016188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterTryFaultInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00004560 File Offset: 0x00002760
		public EnterTryFaultInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0003733C File Offset: 0x0003553C
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x00004569 File Offset: 0x00002769
		public unsafe TryFaultHandler _tryHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterTryFaultInstruction.NativeFieldInfoPtr__tryHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TryFaultHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterTryFaultInstruction.NativeFieldInfoPtr__tryHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeFieldInfoPtr__tryHandler;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedContinuations_Public_Virtual_get_Int32_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_get_Handler_Internal_get_TryFaultHandler_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_SetTryHandler_Internal_Void_TryFaultHandler_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
