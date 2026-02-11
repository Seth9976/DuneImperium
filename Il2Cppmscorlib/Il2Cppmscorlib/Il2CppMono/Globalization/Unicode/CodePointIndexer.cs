using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x0200001F RID: 31
	public class CodePointIndexer : Object
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x00028E20 File Offset: 0x00027020
		// Note: this type is marked as 'beforefieldinit'.
		static CodePointIndexer()
		{
			Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "CodePointIndexer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr);
			CodePointIndexer.NativeFieldInfoPtr_ranges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, "ranges");
			CodePointIndexer.NativeFieldInfoPtr_TotalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, "TotalCount");
			CodePointIndexer.NativeFieldInfoPtr_defaultIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, "defaultIndex");
			CodePointIndexer.NativeFieldInfoPtr_defaultCP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, "defaultCP");
			CodePointIndexer.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, 100663485);
			CodePointIndexer.NativeMethodInfoPtr_ToIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, 100663486);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00028EC8 File Offset: 0x000270C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1276448, RefRangeEnd = 1276453, XrefRangeStart = 1276440, XrefRangeEnd = 1276448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CodePointIndexer(Il2CppStructArray<int> starts, Il2CppStructArray<int> ends, int defaultIndex, int defaultCP)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(starts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ends);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultCP;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePointIndexer.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00028F44 File Offset: 0x00027144
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1276454, RefRangeEnd = 1276467, XrefRangeStart = 1276453, XrefRangeEnd = 1276454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ToIndex(int cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePointIndexer.NativeMethodInfoPtr_ToIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000025CD File Offset: 0x000007CD
		public CodePointIndexer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00028F90 File Offset: 0x00027190
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000025D6 File Offset: 0x000007D6
		public unsafe Il2CppStructArray<CodePointIndexer.TableRange> ranges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_ranges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CodePointIndexer.TableRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_ranges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00028FC0 File Offset: 0x000271C0
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000025F5 File Offset: 0x000007F5
		public unsafe int TotalCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_TotalCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_TotalCount)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00028FE8 File Offset: 0x000271E8
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002610 File Offset: 0x00000810
		public unsafe int defaultIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_defaultIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_defaultIndex)) = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00029010 File Offset: 0x00027210
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000262B File Offset: 0x0000082B
		public unsafe int defaultCP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_defaultCP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_defaultCP)) = value;
			}
		}

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr_ranges;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr_TotalCount;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr_defaultIndex;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_defaultCP;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_ToIndex_Public_Int32_Int32_0;

		// Token: 0x02000568 RID: 1384
		[Serializable]
		[StructLayout(2)]
		public struct TableRange
		{
			// Token: 0x060055B8 RID: 21944 RVA: 0x0018C5A0 File Offset: 0x0018A7A0
			// Note: this type is marked as 'beforefieldinit'.
			static TableRange()
			{
				Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, "TableRange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr);
				CodePointIndexer.TableRange.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr, "Start");
				CodePointIndexer.TableRange.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr, "End");
				CodePointIndexer.TableRange.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr, "Count");
				CodePointIndexer.TableRange.NativeFieldInfoPtr_IndexStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr, "IndexStart");
				CodePointIndexer.TableRange.NativeFieldInfoPtr_IndexEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr, "IndexEnd");
				CodePointIndexer.TableRange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr, 100663487);
			}

			// Token: 0x060055B9 RID: 21945 RVA: 0x0018C644 File Offset: 0x0018A844
			[CallerCount(0)]
			public unsafe TableRange(int start, int end, int indexStart)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexStart;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePointIndexer.TableRange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055BA RID: 21946 RVA: 0x0001E6BC File Offset: 0x0001C8BC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr, ref this));
			}

			// Token: 0x040045DE RID: 17886
			private static readonly IntPtr NativeFieldInfoPtr_Start;

			// Token: 0x040045DF RID: 17887
			private static readonly IntPtr NativeFieldInfoPtr_End;

			// Token: 0x040045E0 RID: 17888
			private static readonly IntPtr NativeFieldInfoPtr_Count;

			// Token: 0x040045E1 RID: 17889
			private static readonly IntPtr NativeFieldInfoPtr_IndexStart;

			// Token: 0x040045E2 RID: 17890
			private static readonly IntPtr NativeFieldInfoPtr_IndexEnd;

			// Token: 0x040045E3 RID: 17891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

			// Token: 0x040045E4 RID: 17892
			[FieldOffset(0)]
			public readonly int Start;

			// Token: 0x040045E5 RID: 17893
			[FieldOffset(4)]
			public readonly int End;

			// Token: 0x040045E6 RID: 17894
			[FieldOffset(8)]
			public readonly int Count;

			// Token: 0x040045E7 RID: 17895
			[FieldOffset(12)]
			public readonly int IndexStart;

			// Token: 0x040045E8 RID: 17896
			[FieldOffset(16)]
			public readonly int IndexEnd;
		}
	}
}
