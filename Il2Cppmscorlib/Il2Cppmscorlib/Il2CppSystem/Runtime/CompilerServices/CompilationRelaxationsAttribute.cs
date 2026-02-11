using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003D9 RID: 985
	[Serializable]
	public class CompilationRelaxationsAttribute : Attribute
	{
		// Token: 0x060039FA RID: 14842 RVA: 0x00117D84 File Offset: 0x00115F84
		// Note: this type is marked as 'beforefieldinit'.
		static CompilationRelaxationsAttribute()
		{
			Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "CompilationRelaxationsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr);
			CompilationRelaxationsAttribute.NativeFieldInfoPtr_m_relaxations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, "m_relaxations");
			CompilationRelaxationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, 100671953);
			CompilationRelaxationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_CompilationRelaxations_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, 100671954);
			CompilationRelaxationsAttribute.NativeMethodInfoPtr_get_CompilationRelaxations_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, 100671955);
		}

		// Token: 0x060039FB RID: 14843 RVA: 0x00117E04 File Offset: 0x00116004
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompilationRelaxationsAttribute(int relaxations)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relaxations;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilationRelaxationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039FC RID: 14844 RVA: 0x00117E4C File Offset: 0x0011604C
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompilationRelaxationsAttribute(CompilationRelaxations relaxations)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relaxations;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilationRelaxationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_CompilationRelaxations_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x060039FD RID: 14845 RVA: 0x00117E94 File Offset: 0x00116094
		public unsafe int CompilationRelaxations
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilationRelaxationsAttribute.NativeMethodInfoPtr_get_CompilationRelaxations_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x000158E4 File Offset: 0x00013AE4
		public CompilationRelaxationsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x060039FF RID: 14847 RVA: 0x00117ED0 File Offset: 0x001160D0
		// (set) Token: 0x06003A00 RID: 14848 RVA: 0x000158ED File Offset: 0x00013AED
		public unsafe int m_relaxations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompilationRelaxationsAttribute.NativeFieldInfoPtr_m_relaxations);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompilationRelaxationsAttribute.NativeFieldInfoPtr_m_relaxations)) = value;
			}
		}

		// Token: 0x04002EFF RID: 12031
		private static readonly IntPtr NativeFieldInfoPtr_m_relaxations;

		// Token: 0x04002F00 RID: 12032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002F01 RID: 12033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CompilationRelaxations_0;

		// Token: 0x04002F02 RID: 12034
		private static readonly IntPtr NativeMethodInfoPtr_get_CompilationRelaxations_Public_get_Int32_0;
	}
}
