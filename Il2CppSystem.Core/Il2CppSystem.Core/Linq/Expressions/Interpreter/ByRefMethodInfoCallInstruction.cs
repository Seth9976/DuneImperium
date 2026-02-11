using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x0200009A RID: 154
	public class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction
	{
		// Token: 0x0600085B RID: 2139 RVA: 0x00035988 File Offset: 0x00033B88
		// Note: this type is marked as 'beforefieldinit'.
		static ByRefMethodInfoCallInstruction()
		{
			Il2CppClassPointerStore<ByRefMethodInfoCallInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "ByRefMethodInfoCallInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByRefMethodInfoCallInstruction>.NativeClassPtr);
			ByRefMethodInfoCallInstruction.NativeFieldInfoPtr__byrefArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByRefMethodInfoCallInstruction>.NativeClassPtr, "_byrefArgs");
			ByRefMethodInfoCallInstruction.NativeMethodInfoPtr__ctor_Internal_Void_MethodInfo_Int32_Il2CppReferenceArray_1_ByRefUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByRefMethodInfoCallInstruction>.NativeClassPtr, 100664907);
			ByRefMethodInfoCallInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByRefMethodInfoCallInstruction>.NativeClassPtr, 100664908);
			ByRefMethodInfoCallInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Final_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByRefMethodInfoCallInstruction>.NativeClassPtr, 100664909);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00035A08 File Offset: 0x00033C08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1015967, RefRangeEnd = 1015969, XrefRangeStart = 1015964, XrefRangeEnd = 1015967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByRefMethodInfoCallInstruction(MethodInfo target, int argumentCount, Il2CppReferenceArray<ByRefUpdater> byrefArgs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByRefMethodInfoCallInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argumentCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(byrefArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByRefMethodInfoCallInstruction.NativeMethodInfoPtr__ctor_Internal_Void_MethodInfo_Int32_Il2CppReferenceArray_1_ByRefUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00035A74 File Offset: 0x00033C74
		public unsafe override int ProducedStack
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015969, XrefRangeEnd = 1015976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByRefMethodInfoCallInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00035ABC File Offset: 0x00033CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015976, XrefRangeEnd = 1016002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByRefMethodInfoCallInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Final_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0000439F File Offset: 0x0000259F
		public ByRefMethodInfoCallInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00035B0C File Offset: 0x00033D0C
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x000043A8 File Offset: 0x000025A8
		public unsafe Il2CppReferenceArray<ByRefUpdater> _byrefArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByRefMethodInfoCallInstruction.NativeFieldInfoPtr__byrefArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ByRefUpdater>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByRefMethodInfoCallInstruction.NativeFieldInfoPtr__byrefArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeFieldInfoPtr__byrefArgs;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MethodInfo_Int32_Il2CppReferenceArray_1_ByRefUpdater_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Final_Int32_InterpretedFrame_0;
	}
}
