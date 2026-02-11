using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000BD RID: 189
	public sealed class InstructionArray : ValueType
	{
		// Token: 0x06000A71 RID: 2673 RVA: 0x0003C0FC File Offset: 0x0003A2FC
		// Note: this type is marked as 'beforefieldinit'.
		static InstructionArray()
		{
			Il2CppClassPointerStore<InstructionArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "InstructionArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstructionArray>.NativeClassPtr);
			InstructionArray.NativeFieldInfoPtr_MaxStackDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionArray>.NativeClassPtr, "MaxStackDepth");
			InstructionArray.NativeFieldInfoPtr_MaxContinuationDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionArray>.NativeClassPtr, "MaxContinuationDepth");
			InstructionArray.NativeFieldInfoPtr_Instructions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionArray>.NativeClassPtr, "Instructions");
			InstructionArray.NativeFieldInfoPtr_Objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionArray>.NativeClassPtr, "Objects");
			InstructionArray.NativeFieldInfoPtr_Labels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionArray>.NativeClassPtr, "Labels");
			InstructionArray.NativeFieldInfoPtr_DebugCookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionArray>.NativeClassPtr, "DebugCookies");
			InstructionArray.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Il2CppReferenceArray_1_Instruction_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_RuntimeLabel_List_1_KeyValuePair_2_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionArray>.NativeClassPtr, 100665257);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0003C1B8 File Offset: 0x0003A3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017371, XrefRangeEnd = 1017375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstructionArray(int maxStackDepth, int maxContinuationDepth, Il2CppReferenceArray<Instruction> instructions, Il2CppReferenceArray<Object> objects, Il2CppStructArray<RuntimeLabel> labels, List<KeyValuePair<int, Object>> debugCookies)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstructionArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxStackDepth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxContinuationDepth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instructions);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(labels);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(debugCookies);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionArray.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Il2CppReferenceArray_1_Instruction_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_RuntimeLabel_List_1_KeyValuePair_2_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00004FC4 File Offset: 0x000031C4
		public InstructionArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00004FCD File Offset: 0x000031CD
		public InstructionArray()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstructionArray>.NativeClassPtr))
		{
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0003C260 File Offset: 0x0003A460
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x00004FDF File Offset: 0x000031DF
		public unsafe int MaxStackDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionArray.NativeFieldInfoPtr_MaxStackDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionArray.NativeFieldInfoPtr_MaxStackDepth)) = value;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0003C288 File Offset: 0x0003A488
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x00004FFA File Offset: 0x000031FA
		public unsafe int MaxContinuationDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionArray.NativeFieldInfoPtr_MaxContinuationDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionArray.NativeFieldInfoPtr_MaxContinuationDepth)) = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x0003C2B0 File Offset: 0x0003A4B0
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x00005015 File Offset: 0x00003215
		public unsafe Il2CppReferenceArray<Instruction> Instructions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionArray.NativeFieldInfoPtr_Instructions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionArray.NativeFieldInfoPtr_Instructions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0003C2E0 File Offset: 0x0003A4E0
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x00005034 File Offset: 0x00003234
		public unsafe Il2CppReferenceArray<Object> Objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionArray.NativeFieldInfoPtr_Objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionArray.NativeFieldInfoPtr_Objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0003C310 File Offset: 0x0003A510
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x00005053 File Offset: 0x00003253
		public unsafe Il2CppStructArray<RuntimeLabel> Labels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionArray.NativeFieldInfoPtr_Labels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RuntimeLabel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionArray.NativeFieldInfoPtr_Labels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x0003C340 File Offset: 0x0003A540
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x00005072 File Offset: 0x00003272
		public unsafe List<KeyValuePair<int, Object>> DebugCookies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionArray.NativeFieldInfoPtr_DebugCookies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<int, Object>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionArray.NativeFieldInfoPtr_DebugCookies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeFieldInfoPtr_MaxStackDepth;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeFieldInfoPtr_MaxContinuationDepth;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeFieldInfoPtr_Instructions;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeFieldInfoPtr_Objects;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr_Labels;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr_DebugCookies;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Il2CppReferenceArray_1_Instruction_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_RuntimeLabel_List_1_KeyValuePair_2_Int32_Object_0;

		// Token: 0x0200024E RID: 590
		public sealed class DebugView : Object
		{
			// Token: 0x06001808 RID: 6152 RVA: 0x00073A4C File Offset: 0x00071C4C
			// Note: this type is marked as 'beforefieldinit'.
			static DebugView()
			{
				Il2CppClassPointerStore<InstructionArray.DebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstructionArray>.NativeClassPtr, "DebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstructionArray.DebugView>.NativeClassPtr);
				InstructionArray.DebugView.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionArray.DebugView>.NativeClassPtr, "_array");
				InstructionArray.DebugView.NativeMethodInfoPtr__ctor_Public_Void_InstructionArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionArray.DebugView>.NativeClassPtr, 100665258);
				InstructionArray.DebugView.NativeMethodInfoPtr_GetInstructionViews_Public_Il2CppReferenceArray_1_InstructionView_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionArray.DebugView>.NativeClassPtr, 100665259);
				InstructionArray.DebugView.NativeMethodInfoPtr__GetInstructionViews_b__4_0_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionArray.DebugView>.NativeClassPtr, 100665260);
			}

			// Token: 0x06001809 RID: 6153 RVA: 0x00073AC8 File Offset: 0x00071CC8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1017361, RefRangeEnd = 1017362, XrefRangeStart = 1017353, XrefRangeEnd = 1017361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebugView(InstructionArray array)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstructionArray.DebugView>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(array));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionArray.DebugView.NativeMethodInfoPtr__ctor_Public_Void_InstructionArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600180A RID: 6154 RVA: 0x00073B18 File Offset: 0x00071D18
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1017370, RefRangeEnd = 1017371, XrefRangeStart = 1017362, XrefRangeEnd = 1017370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<InstructionList.DebugView.InstructionView> GetInstructionViews(bool includeDebugCookies = false)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref includeDebugCookies;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionArray.DebugView.NativeMethodInfoPtr_GetInstructionViews_Public_Il2CppReferenceArray_1_InstructionView_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InstructionList.DebugView.InstructionView>>(intPtr3) : null;
				}
			}

			// Token: 0x0600180B RID: 6155 RVA: 0x00073B64 File Offset: 0x00071D64
			[CallerCount(0)]
			public unsafe int _GetInstructionViews_b__4_0(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionArray.DebugView.NativeMethodInfoPtr__GetInstructionViews_b__4_0_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600180C RID: 6156 RVA: 0x00009BFE File Offset: 0x00007DFE
			public DebugView(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A8 RID: 1704
			// (get) Token: 0x0600180D RID: 6157 RVA: 0x00073BB0 File Offset: 0x00071DB0
			// (set) Token: 0x0600180E RID: 6158 RVA: 0x00009C07 File Offset: 0x00007E07
			public InstructionArray _array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionArray.DebugView.NativeFieldInfoPtr__array);
					return new InstructionArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstructionArray>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionArray.DebugView.NativeFieldInfoPtr__array), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InstructionArray>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001095 RID: 4245
			private static readonly IntPtr NativeFieldInfoPtr__array;

			// Token: 0x04001096 RID: 4246
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InstructionArray_0;

			// Token: 0x04001097 RID: 4247
			private static readonly IntPtr NativeMethodInfoPtr_GetInstructionViews_Public_Il2CppReferenceArray_1_InstructionView_Boolean_0;

			// Token: 0x04001098 RID: 4248
			private static readonly IntPtr NativeMethodInfoPtr__GetInstructionViews_b__4_0_Private_Int32_Int32_0;
		}
	}
}
