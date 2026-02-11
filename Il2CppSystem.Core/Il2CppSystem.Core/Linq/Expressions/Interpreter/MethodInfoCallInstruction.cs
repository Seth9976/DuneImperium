using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000099 RID: 153
	public class MethodInfoCallInstruction : CallInstruction
	{
		// Token: 0x0600084F RID: 2127 RVA: 0x0003566C File Offset: 0x0003386C
		// Note: this type is marked as 'beforefieldinit'.
		static MethodInfoCallInstruction()
		{
			Il2CppClassPointerStore<MethodInfoCallInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "MethodInfoCallInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodInfoCallInstruction>.NativeClassPtr);
			MethodInfoCallInstruction.NativeFieldInfoPtr__target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodInfoCallInstruction>.NativeClassPtr, "_target");
			MethodInfoCallInstruction.NativeFieldInfoPtr__argumentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodInfoCallInstruction>.NativeClassPtr, "_argumentCount");
			MethodInfoCallInstruction.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfoCallInstruction>.NativeClassPtr, 100664901);
			MethodInfoCallInstruction.NativeMethodInfoPtr__ctor_Internal_Void_MethodInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfoCallInstruction>.NativeClassPtr, 100664902);
			MethodInfoCallInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfoCallInstruction>.NativeClassPtr, 100664903);
			MethodInfoCallInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfoCallInstruction>.NativeClassPtr, 100664904);
			MethodInfoCallInstruction.NativeMethodInfoPtr_GetArgs_Protected_Il2CppReferenceArray_1_Object_InterpretedFrame_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfoCallInstruction>.NativeClassPtr, 100664905);
			MethodInfoCallInstruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfoCallInstruction>.NativeClassPtr, 100664906);
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x0003573C File Offset: 0x0003393C
		public unsafe override int ArgumentCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfoCallInstruction.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00035784 File Offset: 0x00033984
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 660727, RefRangeEnd = 660732, XrefRangeStart = 660727, XrefRangeEnd = 660732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfoCallInstruction(MethodInfo target, int argumentCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodInfoCallInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argumentCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoCallInstruction.NativeMethodInfoPtr__ctor_Internal_Void_MethodInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x000357E0 File Offset: 0x000339E0
		public unsafe override int ProducedStack
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015912, XrefRangeEnd = 1015919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfoCallInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00035828 File Offset: 0x00033A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015919, XrefRangeEnd = 1015941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfoCallInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00035880 File Offset: 0x00033A80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1015954, RefRangeEnd = 1015958, XrefRangeStart = 1015941, XrefRangeEnd = 1015954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetArgs(InterpretedFrame frame, int first, int skip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoCallInstruction.NativeMethodInfoPtr_GetArgs_Protected_Il2CppReferenceArray_1_Object_InterpretedFrame_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000358EC File Offset: 0x00033AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015958, XrefRangeEnd = 1015964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfoCallInstruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0000435C File Offset: 0x0000255C
		public MethodInfoCallInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00035930 File Offset: 0x00033B30
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x00004365 File Offset: 0x00002565
		public unsafe MethodInfo _target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodInfoCallInstruction.NativeFieldInfoPtr__target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodInfoCallInstruction.NativeFieldInfoPtr__target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00035960 File Offset: 0x00033B60
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x00004384 File Offset: 0x00002584
		public unsafe int _argumentCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodInfoCallInstruction.NativeFieldInfoPtr__argumentCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodInfoCallInstruction.NativeFieldInfoPtr__argumentCount)) = value;
			}
		}

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeFieldInfoPtr__target;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeFieldInfoPtr__argumentCount;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MethodInfo_Int32_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_GetArgs_Protected_Il2CppReferenceArray_1_Object_InterpretedFrame_Int32_Int32_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
