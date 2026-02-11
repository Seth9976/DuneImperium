using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000393 RID: 915
	public sealed class DllImportAttribute : Attribute
	{
		// Token: 0x060037CC RID: 14284 RVA: 0x00110628 File Offset: 0x0010E828
		// Note: this type is marked as 'beforefieldinit'.
		static DllImportAttribute()
		{
			Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "DllImportAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr);
			DllImportAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "_val");
			DllImportAttribute.NativeFieldInfoPtr_EntryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "EntryPoint");
			DllImportAttribute.NativeFieldInfoPtr_CharSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "CharSet");
			DllImportAttribute.NativeFieldInfoPtr_SetLastError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "SetLastError");
			DllImportAttribute.NativeFieldInfoPtr_ExactSpelling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "ExactSpelling");
			DllImportAttribute.NativeFieldInfoPtr_PreserveSig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "PreserveSig");
			DllImportAttribute.NativeFieldInfoPtr_CallingConvention = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "CallingConvention");
			DllImportAttribute.NativeFieldInfoPtr_BestFitMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "BestFitMapping");
			DllImportAttribute.NativeFieldInfoPtr_ThrowOnUnmappableChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "ThrowOnUnmappableChar");
			DllImportAttribute.NativeMethodInfoPtr_GetCustomAttribute_Internal_Static_Attribute_RuntimeMethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100671641);
			DllImportAttribute.NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_RuntimeMethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100671642);
			DllImportAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_String_CharSet_Boolean_Boolean_Boolean_CallingConvention_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100671643);
			DllImportAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100671644);
			DllImportAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100671645);
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x00110770 File Offset: 0x0010E970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391362, RefRangeEnd = 1391363, XrefRangeStart = 1391350, XrefRangeEnd = 1391362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(RuntimeMethodInfo method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllImportAttribute.NativeMethodInfoPtr_GetCustomAttribute_Internal_Static_Attribute_RuntimeMethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
			}
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x001107B4 File Offset: 0x0010E9B4
		[CallerCount(0)]
		public unsafe static bool IsDefined(RuntimeMethodInfo method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllImportAttribute.NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_RuntimeMethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x001107F8 File Offset: 0x0010E9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391363, XrefRangeEnd = 1391366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dllName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entryPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charSet;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exactSpelling;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setLastError;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveSig;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callingConvention;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bestFitMapping;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnUnmappableChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllImportAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_String_CharSet_Boolean_Boolean_Boolean_CallingConvention_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x001108B8 File Offset: 0x0010EAB8
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DllImportAttribute(string dllName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dllName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllImportAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x060037D1 RID: 14289 RVA: 0x00110904 File Offset: 0x0010EB04
		public unsafe string Value
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllImportAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x00014757 File Offset: 0x00012957
		public DllImportAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x060037D3 RID: 14291 RVA: 0x0011093C File Offset: 0x0010EB3C
		// (set) Token: 0x060037D4 RID: 14292 RVA: 0x00014760 File Offset: 0x00012960
		public unsafe string _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr__val);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr__val), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x060037D5 RID: 14293 RVA: 0x00110964 File Offset: 0x0010EB64
		// (set) Token: 0x060037D6 RID: 14294 RVA: 0x0001477F File Offset: 0x0001297F
		public unsafe string EntryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_EntryPoint);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_EntryPoint), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x060037D7 RID: 14295 RVA: 0x0011098C File Offset: 0x0010EB8C
		// (set) Token: 0x060037D8 RID: 14296 RVA: 0x0001479E File Offset: 0x0001299E
		public unsafe CharSet CharSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_CharSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_CharSet)) = value;
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x060037D9 RID: 14297 RVA: 0x001109B4 File Offset: 0x0010EBB4
		// (set) Token: 0x060037DA RID: 14298 RVA: 0x000147B9 File Offset: 0x000129B9
		public unsafe bool SetLastError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_SetLastError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_SetLastError)) = value;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x060037DB RID: 14299 RVA: 0x001109DC File Offset: 0x0010EBDC
		// (set) Token: 0x060037DC RID: 14300 RVA: 0x000147D4 File Offset: 0x000129D4
		public unsafe bool ExactSpelling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_ExactSpelling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_ExactSpelling)) = value;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x060037DD RID: 14301 RVA: 0x00110A04 File Offset: 0x0010EC04
		// (set) Token: 0x060037DE RID: 14302 RVA: 0x000147EF File Offset: 0x000129EF
		public unsafe bool PreserveSig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_PreserveSig);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_PreserveSig)) = value;
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x060037DF RID: 14303 RVA: 0x00110A2C File Offset: 0x0010EC2C
		// (set) Token: 0x060037E0 RID: 14304 RVA: 0x0001480A File Offset: 0x00012A0A
		public unsafe CallingConvention CallingConvention
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_CallingConvention);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_CallingConvention)) = value;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x060037E1 RID: 14305 RVA: 0x00110A54 File Offset: 0x0010EC54
		// (set) Token: 0x060037E2 RID: 14306 RVA: 0x00014825 File Offset: 0x00012A25
		public unsafe bool BestFitMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_BestFitMapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_BestFitMapping)) = value;
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x060037E3 RID: 14307 RVA: 0x00110A7C File Offset: 0x0010EC7C
		// (set) Token: 0x060037E4 RID: 14308 RVA: 0x00014840 File Offset: 0x00012A40
		public unsafe bool ThrowOnUnmappableChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_ThrowOnUnmappableChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_ThrowOnUnmappableChar)) = value;
			}
		}

		// Token: 0x04002D9F RID: 11679
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x04002DA0 RID: 11680
		private static readonly IntPtr NativeFieldInfoPtr_EntryPoint;

		// Token: 0x04002DA1 RID: 11681
		private static readonly IntPtr NativeFieldInfoPtr_CharSet;

		// Token: 0x04002DA2 RID: 11682
		private static readonly IntPtr NativeFieldInfoPtr_SetLastError;

		// Token: 0x04002DA3 RID: 11683
		private static readonly IntPtr NativeFieldInfoPtr_ExactSpelling;

		// Token: 0x04002DA4 RID: 11684
		private static readonly IntPtr NativeFieldInfoPtr_PreserveSig;

		// Token: 0x04002DA5 RID: 11685
		private static readonly IntPtr NativeFieldInfoPtr_CallingConvention;

		// Token: 0x04002DA6 RID: 11686
		private static readonly IntPtr NativeFieldInfoPtr_BestFitMapping;

		// Token: 0x04002DA7 RID: 11687
		private static readonly IntPtr NativeFieldInfoPtr_ThrowOnUnmappableChar;

		// Token: 0x04002DA8 RID: 11688
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Internal_Static_Attribute_RuntimeMethodInfo_0;

		// Token: 0x04002DA9 RID: 11689
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_RuntimeMethodInfo_0;

		// Token: 0x04002DAA RID: 11690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_CharSet_Boolean_Boolean_Boolean_CallingConvention_Boolean_Boolean_0;

		// Token: 0x04002DAB RID: 11691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002DAC RID: 11692
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
	}
}
