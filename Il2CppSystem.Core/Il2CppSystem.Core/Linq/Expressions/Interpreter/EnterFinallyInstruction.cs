using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000A4 RID: 164
	public sealed class EnterFinallyInstruction : IndexedBranchInstruction
	{
		// Token: 0x060008C7 RID: 2247 RVA: 0x0003736C File Offset: 0x0003556C
		// Note: this type is marked as 'beforefieldinit'.
		static EnterFinallyInstruction()
		{
			Il2CppClassPointerStore<EnterFinallyInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "EnterFinallyInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnterFinallyInstruction>.NativeClassPtr);
			EnterFinallyInstruction.NativeFieldInfoPtr_s_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnterFinallyInstruction>.NativeClassPtr, "s_cache");
			EnterFinallyInstruction.NativeMethodInfoPtr__ctor_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterFinallyInstruction>.NativeClassPtr, 100664964);
			EnterFinallyInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterFinallyInstruction>.NativeClassPtr, 100664965);
			EnterFinallyInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterFinallyInstruction>.NativeClassPtr, 100664966);
			EnterFinallyInstruction.NativeMethodInfoPtr_get_ConsumedContinuations_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterFinallyInstruction>.NativeClassPtr, 100664967);
			EnterFinallyInstruction.NativeMethodInfoPtr_Create_Internal_Static_EnterFinallyInstruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterFinallyInstruction>.NativeClassPtr, 100664968);
			EnterFinallyInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterFinallyInstruction>.NativeClassPtr, 100664969);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00037428 File Offset: 0x00035628
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnterFinallyInstruction(int labelIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnterFinallyInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref labelIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterFinallyInstruction.NativeMethodInfoPtr__ctor_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x00037470 File Offset: 0x00035670
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016188, XrefRangeEnd = 1016190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterFinallyInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x000374A8 File Offset: 0x000356A8
		public unsafe override int ProducedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterFinallyInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x000374E4 File Offset: 0x000356E4
		public unsafe override int ConsumedContinuations
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterFinallyInstruction.NativeMethodInfoPtr_get_ConsumedContinuations_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00037520 File Offset: 0x00035720
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1016194, RefRangeEnd = 1016196, XrefRangeStart = 1016190, XrefRangeEnd = 1016194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EnterFinallyInstruction Create(int labelIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref labelIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterFinallyInstruction.NativeMethodInfoPtr_Create_Internal_Static_EnterFinallyInstruction_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnterFinallyInstruction>(intPtr3) : null;
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00037560 File Offset: 0x00035760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016196, XrefRangeEnd = 1016200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterFinallyInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00004588 File Offset: 0x00002788
		public EnterFinallyInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x000375B0 File Offset: 0x000357B0
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x00004591 File Offset: 0x00002791
		public unsafe static Il2CppReferenceArray<EnterFinallyInstruction> s_cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnterFinallyInstruction.NativeFieldInfoPtr_s_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EnterFinallyInstruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnterFinallyInstruction.NativeFieldInfoPtr_s_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr_s_cache;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedContinuations_Public_Virtual_get_Int32_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_EnterFinallyInstruction_Int32_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
