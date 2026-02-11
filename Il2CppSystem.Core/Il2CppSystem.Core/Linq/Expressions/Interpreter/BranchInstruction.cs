using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x0200009F RID: 159
	public class BranchInstruction : OffsetInstruction
	{
		// Token: 0x06000887 RID: 2183 RVA: 0x0003642C File Offset: 0x0003462C
		// Note: this type is marked as 'beforefieldinit'.
		static BranchInstruction()
		{
			Il2CppClassPointerStore<BranchInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "BranchInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BranchInstruction>.NativeClassPtr);
			BranchInstruction.NativeFieldInfoPtr_s_caches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchInstruction>.NativeClassPtr, "s_caches");
			BranchInstruction.NativeFieldInfoPtr__hasResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchInstruction>.NativeClassPtr, "_hasResult");
			BranchInstruction.NativeFieldInfoPtr__hasValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchInstruction>.NativeClassPtr, "_hasValue");
			BranchInstruction.NativeMethodInfoPtr_get_Cache_Public_Virtual_get_Il2CppReferenceArray_1_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchInstruction>.NativeClassPtr, 100664931);
			BranchInstruction.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchInstruction>.NativeClassPtr, 100664932);
			BranchInstruction.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchInstruction>.NativeClassPtr, 100664933);
			BranchInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchInstruction>.NativeClassPtr, 100664934);
			BranchInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchInstruction>.NativeClassPtr, 100664935);
			BranchInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchInstruction>.NativeClassPtr, 100664936);
			BranchInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchInstruction>.NativeClassPtr, 100664937);
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00036524 File Offset: 0x00034724
		public unsafe override Il2CppReferenceArray<Instruction> Cache
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016069, XrefRangeEnd = 1016093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BranchInstruction.NativeMethodInfoPtr_get_Cache_Public_Virtual_get_Il2CppReferenceArray_1_Instruction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00036570 File Offset: 0x00034770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1016094, RefRangeEnd = 1016095, XrefRangeStart = 1016093, XrefRangeEnd = 1016094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BranchInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchInstruction.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000365AC File Offset: 0x000347AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1016096, RefRangeEnd = 1016097, XrefRangeStart = 1016095, XrefRangeEnd = 1016096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchInstruction(bool hasResult, bool hasValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BranchInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchInstruction.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x00036604 File Offset: 0x00034804
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016097, XrefRangeEnd = 1016099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BranchInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00036648 File Offset: 0x00034848
		public unsafe override int ConsumedStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BranchInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x00036690 File Offset: 0x00034890
		public unsafe override int ProducedStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BranchInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000366D8 File Offset: 0x000348D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BranchInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0000443C File Offset: 0x0000263C
		public BranchInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00036730 File Offset: 0x00034930
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x00004445 File Offset: 0x00002645
		public unsafe static Il2CppReferenceArray<Il2CppReferenceArray<Il2CppReferenceArray<Instruction>>> s_caches
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BranchInstruction.NativeFieldInfoPtr_s_caches, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<Il2CppReferenceArray<Instruction>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BranchInstruction.NativeFieldInfoPtr_s_caches, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00036758 File Offset: 0x00034958
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00004457 File Offset: 0x00002657
		public unsafe bool _hasResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchInstruction.NativeFieldInfoPtr__hasResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchInstruction.NativeFieldInfoPtr__hasResult)) = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00036780 File Offset: 0x00034980
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00004472 File Offset: 0x00002672
		public unsafe bool _hasValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchInstruction.NativeFieldInfoPtr__hasValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchInstruction.NativeFieldInfoPtr__hasValue)) = value;
			}
		}

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeFieldInfoPtr_s_caches;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr__hasResult;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr__hasValue;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_get_Cache_Public_Virtual_get_Il2CppReferenceArray_1_Instruction_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
