using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000CC RID: 204
	public sealed class DebugInfo : Object
	{
		// Token: 0x06000C54 RID: 3156 RVA: 0x000428AC File Offset: 0x00040AAC
		// Note: this type is marked as 'beforefieldinit'.
		static DebugInfo()
		{
			Il2CppClassPointerStore<DebugInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "DebugInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugInfo>.NativeClassPtr);
			DebugInfo.NativeFieldInfoPtr_StartLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInfo>.NativeClassPtr, "StartLine");
			DebugInfo.NativeFieldInfoPtr_EndLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInfo>.NativeClassPtr, "EndLine");
			DebugInfo.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInfo>.NativeClassPtr, "Index");
			DebugInfo.NativeFieldInfoPtr_FileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInfo>.NativeClassPtr, "FileName");
			DebugInfo.NativeFieldInfoPtr_IsClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInfo>.NativeClassPtr, "IsClear");
			DebugInfo.NativeFieldInfoPtr_s_debugComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInfo>.NativeClassPtr, "s_debugComparer");
			DebugInfo.NativeMethodInfoPtr_GetMatchingDebugInfo_Public_Static_DebugInfo_Il2CppReferenceArray_1_DebugInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInfo>.NativeClassPtr, 100665530);
			DebugInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInfo>.NativeClassPtr, 100665531);
			DebugInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInfo>.NativeClassPtr, 100665532);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00042990 File Offset: 0x00040B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020023, XrefRangeEnd = 1020034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DebugInfo GetMatchingDebugInfo(Il2CppReferenceArray<DebugInfo> debugInfos, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(debugInfos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInfo.NativeMethodInfoPtr_GetMatchingDebugInfo_Public_Static_DebugInfo_Il2CppReferenceArray_1_DebugInfo_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugInfo>(intPtr3) : null;
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x000429E4 File Offset: 0x00040BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020034, XrefRangeEnd = 1020060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00042A1C File Offset: 0x00040C1C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00005C58 File Offset: 0x00003E58
		public DebugInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00042A58 File Offset: 0x00040C58
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x00005C61 File Offset: 0x00003E61
		public unsafe int StartLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInfo.NativeFieldInfoPtr_StartLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInfo.NativeFieldInfoPtr_StartLine)) = value;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x00042A80 File Offset: 0x00040C80
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x00005C7C File Offset: 0x00003E7C
		public unsafe int EndLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInfo.NativeFieldInfoPtr_EndLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInfo.NativeFieldInfoPtr_EndLine)) = value;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x00042AA8 File Offset: 0x00040CA8
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x00005C97 File Offset: 0x00003E97
		public unsafe int Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInfo.NativeFieldInfoPtr_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInfo.NativeFieldInfoPtr_Index)) = value;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00042AD0 File Offset: 0x00040CD0
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x00005CB2 File Offset: 0x00003EB2
		public unsafe string FileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInfo.NativeFieldInfoPtr_FileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInfo.NativeFieldInfoPtr_FileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x00042AF8 File Offset: 0x00040CF8
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x00005CD1 File Offset: 0x00003ED1
		public unsafe bool IsClear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInfo.NativeFieldInfoPtr_IsClear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInfo.NativeFieldInfoPtr_IsClear)) = value;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00042B20 File Offset: 0x00040D20
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x00005CEC File Offset: 0x00003EEC
		public unsafe static DebugInfo.DebugInfoComparer s_debugComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugInfo.NativeFieldInfoPtr_s_debugComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugInfo.DebugInfoComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugInfo.NativeFieldInfoPtr_s_debugComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeFieldInfoPtr_StartLine;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeFieldInfoPtr_EndLine;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeFieldInfoPtr_Index;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr_FileName;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeFieldInfoPtr_IsClear;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeFieldInfoPtr_s_debugComparer;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchingDebugInfo_Public_Static_DebugInfo_Il2CppReferenceArray_1_DebugInfo_Int32_0;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000272 RID: 626
		public class DebugInfoComparer : Object
		{
			// Token: 0x060018A8 RID: 6312 RVA: 0x00075DF0 File Offset: 0x00073FF0
			// Note: this type is marked as 'beforefieldinit'.
			static DebugInfoComparer()
			{
				Il2CppClassPointerStore<DebugInfo.DebugInfoComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugInfo>.NativeClassPtr, "DebugInfoComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugInfo.DebugInfoComparer>.NativeClassPtr);
				DebugInfo.DebugInfoComparer.NativeMethodInfoPtr_System_Collections_Generic_IComparer_System_Linq_Expressions_Interpreter_DebugInfo__Compare_Private_Virtual_Final_New_Int32_DebugInfo_DebugInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInfo.DebugInfoComparer>.NativeClassPtr, 100665534);
				DebugInfo.DebugInfoComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInfo.DebugInfoComparer>.NativeClassPtr, 100665535);
			}

			// Token: 0x060018A9 RID: 6313 RVA: 0x00075E44 File Offset: 0x00074044
			[CallerCount(0)]
			public unsafe virtual int System_Collections_Generic_IComparer_System_Linq_Expressions_Interpreter_DebugInfo__Compare(DebugInfo d1, DebugInfo d2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInfo.DebugInfoComparer.NativeMethodInfoPtr_System_Collections_Generic_IComparer_System_Linq_Expressions_Interpreter_DebugInfo__Compare_Private_Virtual_Final_New_Int32_DebugInfo_DebugInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060018AA RID: 6314 RVA: 0x00075EA4 File Offset: 0x000740A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebugInfoComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugInfo.DebugInfoComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInfo.DebugInfoComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018AB RID: 6315 RVA: 0x00009E58 File Offset: 0x00008058
			public DebugInfoComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010E9 RID: 4329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IComparer_System_Linq_Expressions_Interpreter_DebugInfo__Compare_Private_Virtual_Final_New_Int32_DebugInfo_DebugInfo_0;

			// Token: 0x040010EA RID: 4330
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
