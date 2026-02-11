using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000A2 RID: 162
	public sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction
	{
		// Token: 0x060008AE RID: 2222 RVA: 0x00036D40 File Offset: 0x00034F40
		// Note: this type is marked as 'beforefieldinit'.
		static EnterTryCatchFinallyInstruction()
		{
			Il2CppClassPointerStore<EnterTryCatchFinallyInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "EnterTryCatchFinallyInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnterTryCatchFinallyInstruction>.NativeClassPtr);
			EnterTryCatchFinallyInstruction.NativeFieldInfoPtr__hasFinally = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnterTryCatchFinallyInstruction>.NativeClassPtr, "_hasFinally");
			EnterTryCatchFinallyInstruction.NativeFieldInfoPtr__tryHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnterTryCatchFinallyInstruction>.NativeClassPtr, "_tryHandler");
			EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_SetTryHandler_Internal_Void_TryCatchFinallyHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterTryCatchFinallyInstruction>.NativeClassPtr, 100664949);
			EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_get_Handler_Internal_get_TryCatchFinallyHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterTryCatchFinallyInstruction>.NativeClassPtr, 100664950);
			EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_get_ProducedContinuations_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterTryCatchFinallyInstruction>.NativeClassPtr, 100664951);
			EnterTryCatchFinallyInstruction.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterTryCatchFinallyInstruction>.NativeClassPtr, 100664952);
			EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_CreateTryFinally_Internal_Static_EnterTryCatchFinallyInstruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterTryCatchFinallyInstruction>.NativeClassPtr, 100664953);
			EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_CreateTryCatch_Internal_Static_EnterTryCatchFinallyInstruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterTryCatchFinallyInstruction>.NativeClassPtr, 100664954);
			EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterTryCatchFinallyInstruction>.NativeClassPtr, 100664955);
			EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterTryCatchFinallyInstruction>.NativeClassPtr, 100664956);
			EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterTryCatchFinallyInstruction>.NativeClassPtr, 100664957);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00036E4C File Offset: 0x0003504C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTryHandler(TryCatchFinallyHandler tryHandler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tryHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_SetTryHandler_Internal_Void_TryCatchFinallyHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00036E90 File Offset: 0x00035090
		public unsafe TryCatchFinallyHandler Handler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_get_Handler_Internal_get_TryCatchFinallyHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TryCatchFinallyHandler>(intPtr3) : null;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00036ED0 File Offset: 0x000350D0
		public unsafe override int ProducedContinuations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_get_ProducedContinuations_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00036F0C File Offset: 0x0003510C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016142, XrefRangeEnd = 1016143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnterTryCatchFinallyInstruction(int targetIndex, bool hasFinally)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnterTryCatchFinallyInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasFinally;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterTryCatchFinallyInstruction.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00036F64 File Offset: 0x00035164
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1016147, RefRangeEnd = 1016149, XrefRangeStart = 1016143, XrefRangeEnd = 1016147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref labelIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_CreateTryFinally_Internal_Static_EnterTryCatchFinallyInstruction_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnterTryCatchFinallyInstruction>(intPtr3) : null;
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00036FA4 File Offset: 0x000351A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1016153, RefRangeEnd = 1016155, XrefRangeStart = 1016149, XrefRangeEnd = 1016153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EnterTryCatchFinallyInstruction CreateTryCatch()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_CreateTryCatch_Internal_Static_EnterTryCatchFinallyInstruction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnterTryCatchFinallyInstruction>(intPtr3) : null;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00036FD8 File Offset: 0x000351D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016155, XrefRangeEnd = 1016168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00037028 File Offset: 0x00035228
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016168, XrefRangeEnd = 1016172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00037060 File Offset: 0x00035260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016172, XrefRangeEnd = 1016180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterTryCatchFinallyInstruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0000451D File Offset: 0x0000271D
		public EnterTryCatchFinallyInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00037098 File Offset: 0x00035298
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x00004526 File Offset: 0x00002726
		public unsafe bool _hasFinally
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterTryCatchFinallyInstruction.NativeFieldInfoPtr__hasFinally);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterTryCatchFinallyInstruction.NativeFieldInfoPtr__hasFinally)) = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x000370C0 File Offset: 0x000352C0
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x00004541 File Offset: 0x00002741
		public unsafe TryCatchFinallyHandler _tryHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterTryCatchFinallyInstruction.NativeFieldInfoPtr__tryHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TryCatchFinallyHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterTryCatchFinallyInstruction.NativeFieldInfoPtr__tryHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeFieldInfoPtr__hasFinally;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeFieldInfoPtr__tryHandler;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_SetTryHandler_Internal_Void_TryCatchFinallyHandler_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_get_Handler_Internal_get_TryCatchFinallyHandler_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedContinuations_Public_Virtual_get_Int32_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_CreateTryFinally_Internal_Static_EnterTryCatchFinallyInstruction_Int32_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_CreateTryCatch_Internal_Static_EnterTryCatchFinallyInstruction_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
