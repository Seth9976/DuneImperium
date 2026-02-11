using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000AB RID: 171
	public sealed class LeaveExceptionHandlerInstruction : IndexedBranchInstruction
	{
		// Token: 0x06000908 RID: 2312 RVA: 0x000381C4 File Offset: 0x000363C4
		// Note: this type is marked as 'beforefieldinit'.
		static LeaveExceptionHandlerInstruction()
		{
			Il2CppClassPointerStore<LeaveExceptionHandlerInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "LeaveExceptionHandlerInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaveExceptionHandlerInstruction>.NativeClassPtr);
			LeaveExceptionHandlerInstruction.NativeFieldInfoPtr_s_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaveExceptionHandlerInstruction>.NativeClassPtr, "s_cache");
			LeaveExceptionHandlerInstruction.NativeFieldInfoPtr__hasValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaveExceptionHandlerInstruction>.NativeClassPtr, "_hasValue");
			LeaveExceptionHandlerInstruction.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveExceptionHandlerInstruction>.NativeClassPtr, 100665004);
			LeaveExceptionHandlerInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveExceptionHandlerInstruction>.NativeClassPtr, 100665005);
			LeaveExceptionHandlerInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveExceptionHandlerInstruction>.NativeClassPtr, 100665006);
			LeaveExceptionHandlerInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveExceptionHandlerInstruction>.NativeClassPtr, 100665007);
			LeaveExceptionHandlerInstruction.NativeMethodInfoPtr_Create_Internal_Static_LeaveExceptionHandlerInstruction_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveExceptionHandlerInstruction>.NativeClassPtr, 100665008);
			LeaveExceptionHandlerInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveExceptionHandlerInstruction>.NativeClassPtr, 100665009);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00038294 File Offset: 0x00036494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaveExceptionHandlerInstruction(int labelIndex, bool hasValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaveExceptionHandlerInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref labelIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaveExceptionHandlerInstruction.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x000382EC File Offset: 0x000364EC
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016225, XrefRangeEnd = 1016227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaveExceptionHandlerInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x00038324 File Offset: 0x00036524
		public unsafe override int ConsumedStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaveExceptionHandlerInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00038360 File Offset: 0x00036560
		public unsafe override int ProducedStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaveExceptionHandlerInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0003839C File Offset: 0x0003659C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1016231, RefRangeEnd = 1016232, XrefRangeStart = 1016227, XrefRangeEnd = 1016231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LeaveExceptionHandlerInstruction Create(int labelIndex, bool hasValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref labelIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaveExceptionHandlerInstruction.NativeMethodInfoPtr_Create_Internal_Static_LeaveExceptionHandlerInstruction_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LeaveExceptionHandlerInstruction>(intPtr3) : null;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x000383EC File Offset: 0x000365EC
		[CallerCount(0)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaveExceptionHandlerInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00004672 File Offset: 0x00002872
		public LeaveExceptionHandlerInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x0003843C File Offset: 0x0003663C
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x0000467B File Offset: 0x0000287B
		public unsafe static Il2CppReferenceArray<LeaveExceptionHandlerInstruction> s_cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LeaveExceptionHandlerInstruction.NativeFieldInfoPtr_s_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LeaveExceptionHandlerInstruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeaveExceptionHandlerInstruction.NativeFieldInfoPtr_s_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00038464 File Offset: 0x00036664
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x0000468D File Offset: 0x0000288D
		public unsafe bool _hasValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaveExceptionHandlerInstruction.NativeFieldInfoPtr__hasValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaveExceptionHandlerInstruction.NativeFieldInfoPtr__hasValue)) = value;
			}
		}

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeFieldInfoPtr_s_cache;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeFieldInfoPtr__hasValue;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_LeaveExceptionHandlerInstruction_Int32_Boolean_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
