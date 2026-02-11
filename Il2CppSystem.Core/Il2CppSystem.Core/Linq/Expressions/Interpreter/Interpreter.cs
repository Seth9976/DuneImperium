using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000C0 RID: 192
	public sealed class Interpreter : Object
	{
		// Token: 0x06000B59 RID: 2905 RVA: 0x0003FCB4 File Offset: 0x0003DEB4
		// Note: this type is marked as 'beforefieldinit'.
		static Interpreter()
		{
			Il2CppClassPointerStore<Interpreter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "Interpreter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interpreter>.NativeClassPtr);
			Interpreter.NativeFieldInfoPtr_NoValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpreter>.NativeClassPtr, "NoValue");
			Interpreter.NativeFieldInfoPtr__instructions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpreter>.NativeClassPtr, "_instructions");
			Interpreter.NativeFieldInfoPtr__objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpreter>.NativeClassPtr, "_objects");
			Interpreter.NativeFieldInfoPtr__labels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpreter>.NativeClassPtr, "_labels");
			Interpreter.NativeFieldInfoPtr__debugInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpreter>.NativeClassPtr, "_debugInfos");
			Interpreter.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpreter>.NativeClassPtr, "<Name>k__BackingField");
			Interpreter.NativeFieldInfoPtr__LocalCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpreter>.NativeClassPtr, "<LocalCount>k__BackingField");
			Interpreter.NativeFieldInfoPtr__ClosureVariables_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpreter>.NativeClassPtr, "<ClosureVariables>k__BackingField");
			Interpreter.NativeMethodInfoPtr__ctor_Internal_Void_String_LocalVariables_InstructionArray_Il2CppReferenceArray_1_DebugInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpreter>.NativeClassPtr, 100665413);
			Interpreter.NativeMethodInfoPtr_get_Name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpreter>.NativeClassPtr, 100665414);
			Interpreter.NativeMethodInfoPtr_get_LocalCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpreter>.NativeClassPtr, 100665415);
			Interpreter.NativeMethodInfoPtr_get_ClosureSize_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpreter>.NativeClassPtr, 100665416);
			Interpreter.NativeMethodInfoPtr_get_Instructions_Internal_get_InstructionArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpreter>.NativeClassPtr, 100665417);
			Interpreter.NativeMethodInfoPtr_get_ClosureVariables_Internal_get_Dictionary_2_ParameterExpression_LocalVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpreter>.NativeClassPtr, 100665418);
			Interpreter.NativeMethodInfoPtr_Run_Public_Void_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpreter>.NativeClassPtr, 100665419);
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0003FE10 File Offset: 0x0003E010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019359, XrefRangeEnd = 1019367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Interpreter(string name, LocalVariables locals, InstructionArray instructions, Il2CppReferenceArray<DebugInfo> debugInfos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpreter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locals);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instructions));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(debugInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpreter.NativeMethodInfoPtr__ctor_Internal_Void_String_LocalVariables_InstructionArray_Il2CppReferenceArray_1_DebugInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0003FE98 File Offset: 0x0003E098
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpreter.NativeMethodInfoPtr_get_Name_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0003FED0 File Offset: 0x0003E0D0
		public unsafe int LocalCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpreter.NativeMethodInfoPtr_get_LocalCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x0003FF0C File Offset: 0x0003E10C
		public unsafe int ClosureSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1019370, RefRangeEnd = 1019371, XrefRangeStart = 1019367, XrefRangeEnd = 1019370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpreter.NativeMethodInfoPtr_get_ClosureSize_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0003FF48 File Offset: 0x0003E148
		public unsafe InstructionArray Instructions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpreter.NativeMethodInfoPtr_get_Instructions_Internal_get_InstructionArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new InstructionArray(intPtr);
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x0003FF80 File Offset: 0x0003E180
		public unsafe Dictionary<ParameterExpression, LocalVariable> ClosureVariables
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpreter.NativeMethodInfoPtr_get_ClosureVariables_Internal_get_Dictionary_2_ParameterExpression_LocalVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<ParameterExpression, LocalVariable>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0003FFC0 File Offset: 0x0003E1C0
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 1019372, RefRangeEnd = 1019407, XrefRangeStart = 1019371, XrefRangeEnd = 1019372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpreter.NativeMethodInfoPtr_Run_Public_Void_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x000053FE File Offset: 0x000035FE
		public Interpreter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x00040004 File Offset: 0x0003E204
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x00005407 File Offset: 0x00003607
		public unsafe static Object NoValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Interpreter.NativeFieldInfoPtr_NoValue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Interpreter.NativeFieldInfoPtr_NoValue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0004002C File Offset: 0x0003E22C
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x00005419 File Offset: 0x00003619
		public InstructionArray _instructions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpreter.NativeFieldInfoPtr__instructions);
				return new InstructionArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstructionArray>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpreter.NativeFieldInfoPtr__instructions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InstructionArray>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0004005C File Offset: 0x0003E25C
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00005447 File Offset: 0x00003647
		public unsafe Il2CppReferenceArray<Object> _objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpreter.NativeFieldInfoPtr__objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpreter.NativeFieldInfoPtr__objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0004008C File Offset: 0x0003E28C
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x00005466 File Offset: 0x00003666
		public unsafe Il2CppStructArray<RuntimeLabel> _labels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpreter.NativeFieldInfoPtr__labels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RuntimeLabel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpreter.NativeFieldInfoPtr__labels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x000400BC File Offset: 0x0003E2BC
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x00005485 File Offset: 0x00003685
		public unsafe Il2CppReferenceArray<DebugInfo> _debugInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpreter.NativeFieldInfoPtr__debugInfos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DebugInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpreter.NativeFieldInfoPtr__debugInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x000400EC File Offset: 0x0003E2EC
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x000054A4 File Offset: 0x000036A4
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpreter.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpreter.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00040114 File Offset: 0x0003E314
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x000054C3 File Offset: 0x000036C3
		public unsafe int _LocalCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpreter.NativeFieldInfoPtr__LocalCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpreter.NativeFieldInfoPtr__LocalCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0004013C File Offset: 0x0003E33C
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x000054DE File Offset: 0x000036DE
		public unsafe Dictionary<ParameterExpression, LocalVariable> _ClosureVariables_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpreter.NativeFieldInfoPtr__ClosureVariables_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ParameterExpression, LocalVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpreter.NativeFieldInfoPtr__ClosureVariables_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeFieldInfoPtr_NoValue;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeFieldInfoPtr__instructions;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeFieldInfoPtr__objects;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeFieldInfoPtr__labels;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeFieldInfoPtr__debugInfos;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeFieldInfoPtr__LocalCount_k__BackingField;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeFieldInfoPtr__ClosureVariables_k__BackingField;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_LocalVariables_InstructionArray_Il2CppReferenceArray_1_DebugInfo_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_String_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalCount_Internal_get_Int32_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_get_ClosureSize_Internal_get_Int32_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_get_Instructions_Internal_get_InstructionArray_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_get_ClosureVariables_Internal_get_Dictionary_2_ParameterExpression_LocalVariable_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Void_InterpretedFrame_0;
	}
}
