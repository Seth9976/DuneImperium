using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000A1 RID: 161
	public sealed class GotoInstruction : IndexedBranchInstruction
	{
		// Token: 0x0600089E RID: 2206 RVA: 0x000369C8 File Offset: 0x00034BC8
		// Note: this type is marked as 'beforefieldinit'.
		static GotoInstruction()
		{
			Il2CppClassPointerStore<GotoInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "GotoInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GotoInstruction>.NativeClassPtr);
			GotoInstruction.NativeFieldInfoPtr_s_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GotoInstruction>.NativeClassPtr, "s_cache");
			GotoInstruction.NativeFieldInfoPtr__hasResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GotoInstruction>.NativeClassPtr, "_hasResult");
			GotoInstruction.NativeFieldInfoPtr__hasValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GotoInstruction>.NativeClassPtr, "_hasValue");
			GotoInstruction.NativeFieldInfoPtr__labelTargetGetsValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GotoInstruction>.NativeClassPtr, "_labelTargetGetsValue");
			GotoInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoInstruction>.NativeClassPtr, 100664942);
			GotoInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoInstruction>.NativeClassPtr, 100664943);
			GotoInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoInstruction>.NativeClassPtr, 100664944);
			GotoInstruction.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoInstruction>.NativeClassPtr, 100664945);
			GotoInstruction.NativeMethodInfoPtr_Create_Internal_Static_GotoInstruction_Int32_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoInstruction>.NativeClassPtr, 100664946);
			GotoInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoInstruction>.NativeClassPtr, 100664947);
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x00036AC0 File Offset: 0x00034CC0
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016113, XrefRangeEnd = 1016115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00036AF8 File Offset: 0x00034CF8
		public unsafe override int ConsumedStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x00036B34 File Offset: 0x00034D34
		public unsafe override int ProducedStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00036B70 File Offset: 0x00034D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016115, XrefRangeEnd = 1016116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GotoInstruction(int targetIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GotoInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasResult;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref labelTargetGetsValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoInstruction.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00036BE4 File Offset: 0x00034DE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1016129, RefRangeEnd = 1016132, XrefRangeStart = 1016116, XrefRangeEnd = 1016129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GotoInstruction Create(int labelIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref labelIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasResult;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref labelTargetGetsValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoInstruction.NativeMethodInfoPtr_Create_Internal_Static_GotoInstruction_Int32_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GotoInstruction>(intPtr3) : null;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00036C50 File Offset: 0x00034E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016132, XrefRangeEnd = 1016142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000044B1 File Offset: 0x000026B1
		public GotoInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00036CA0 File Offset: 0x00034EA0
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x000044BA File Offset: 0x000026BA
		public unsafe static Il2CppReferenceArray<GotoInstruction> s_cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GotoInstruction.NativeFieldInfoPtr_s_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GotoInstruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GotoInstruction.NativeFieldInfoPtr_s_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00036CC8 File Offset: 0x00034EC8
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x000044CC File Offset: 0x000026CC
		public unsafe bool _hasResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoInstruction.NativeFieldInfoPtr__hasResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoInstruction.NativeFieldInfoPtr__hasResult)) = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x00036CF0 File Offset: 0x00034EF0
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x000044E7 File Offset: 0x000026E7
		public unsafe bool _hasValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoInstruction.NativeFieldInfoPtr__hasValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoInstruction.NativeFieldInfoPtr__hasValue)) = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00036D18 File Offset: 0x00034F18
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00004502 File Offset: 0x00002702
		public unsafe bool _labelTargetGetsValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoInstruction.NativeFieldInfoPtr__labelTargetGetsValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoInstruction.NativeFieldInfoPtr__labelTargetGetsValue)) = value;
			}
		}

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeFieldInfoPtr_s_cache;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeFieldInfoPtr__hasResult;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeFieldInfoPtr__hasValue;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeFieldInfoPtr__labelTargetGetsValue;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Boolean_Boolean_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_GotoInstruction_Int32_Boolean_Boolean_Boolean_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
