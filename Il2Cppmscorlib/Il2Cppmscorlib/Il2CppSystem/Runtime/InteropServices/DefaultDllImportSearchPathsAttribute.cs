using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000392 RID: 914
	public sealed class DefaultDllImportSearchPathsAttribute : Attribute
	{
		// Token: 0x060037C7 RID: 14279 RVA: 0x00110560 File Offset: 0x0010E760
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultDllImportSearchPathsAttribute()
		{
			Il2CppClassPointerStore<DefaultDllImportSearchPathsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "DefaultDllImportSearchPathsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultDllImportSearchPathsAttribute>.NativeClassPtr);
			DefaultDllImportSearchPathsAttribute.NativeFieldInfoPtr__paths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultDllImportSearchPathsAttribute>.NativeClassPtr, "_paths");
			DefaultDllImportSearchPathsAttribute.NativeMethodInfoPtr__ctor_Public_Void_DllImportSearchPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDllImportSearchPathsAttribute>.NativeClassPtr, 100671640);
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x001105B8 File Offset: 0x0010E7B8
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultDllImportSearchPathsAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref paths;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDllImportSearchPathsAttribute.NativeMethodInfoPtr__ctor_Public_Void_DllImportSearchPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x00014733 File Offset: 0x00012933
		public DefaultDllImportSearchPathsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x060037CA RID: 14282 RVA: 0x00110600 File Offset: 0x0010E800
		// (set) Token: 0x060037CB RID: 14283 RVA: 0x0001473C File Offset: 0x0001293C
		public unsafe DllImportSearchPath _paths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDllImportSearchPathsAttribute.NativeFieldInfoPtr__paths);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDllImportSearchPathsAttribute.NativeFieldInfoPtr__paths)) = value;
			}
		}

		// Token: 0x04002D9D RID: 11677
		private static readonly IntPtr NativeFieldInfoPtr__paths;

		// Token: 0x04002D9E RID: 11678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DllImportSearchPath_0;
	}
}
