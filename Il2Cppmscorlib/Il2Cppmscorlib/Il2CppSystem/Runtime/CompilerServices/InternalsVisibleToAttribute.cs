using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003DA RID: 986
	public sealed class InternalsVisibleToAttribute : Attribute
	{
		// Token: 0x06003A01 RID: 14849 RVA: 0x00117EF8 File Offset: 0x001160F8
		// Note: this type is marked as 'beforefieldinit'.
		static InternalsVisibleToAttribute()
		{
			Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "InternalsVisibleToAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr);
			InternalsVisibleToAttribute.NativeFieldInfoPtr__assemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, "_assemblyName");
			InternalsVisibleToAttribute.NativeFieldInfoPtr__allInternalsVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, "_allInternalsVisible");
			InternalsVisibleToAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, 100671956);
			InternalsVisibleToAttribute.NativeMethodInfoPtr_set_AllInternalsVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, 100671957);
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x00117F78 File Offset: 0x00116178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395792, XrefRangeEnd = 1395794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalsVisibleToAttribute(string assemblyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalsVisibleToAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (set) Token: 0x06003A03 RID: 14851 RVA: 0x00117FC4 File Offset: 0x001161C4
		public unsafe bool AllInternalsVisible
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalsVisibleToAttribute.NativeMethodInfoPtr_set_AllInternalsVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x00015908 File Offset: 0x00013B08
		public InternalsVisibleToAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06003A05 RID: 14853 RVA: 0x00118004 File Offset: 0x00116204
		// (set) Token: 0x06003A06 RID: 14854 RVA: 0x00015911 File Offset: 0x00013B11
		public unsafe string _assemblyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalsVisibleToAttribute.NativeFieldInfoPtr__assemblyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalsVisibleToAttribute.NativeFieldInfoPtr__assemblyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06003A07 RID: 14855 RVA: 0x0011802C File Offset: 0x0011622C
		// (set) Token: 0x06003A08 RID: 14856 RVA: 0x00015930 File Offset: 0x00013B30
		public unsafe bool _allInternalsVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalsVisibleToAttribute.NativeFieldInfoPtr__allInternalsVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalsVisibleToAttribute.NativeFieldInfoPtr__allInternalsVisible)) = value;
			}
		}

		// Token: 0x04002F03 RID: 12035
		private static readonly IntPtr NativeFieldInfoPtr__assemblyName;

		// Token: 0x04002F04 RID: 12036
		private static readonly IntPtr NativeFieldInfoPtr__allInternalsVisible;

		// Token: 0x04002F05 RID: 12037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002F06 RID: 12038
		private static readonly IntPtr NativeMethodInfoPtr_set_AllInternalsVisible_Public_set_Void_Boolean_0;
	}
}
