using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x02000023 RID: 35
	public class Level2Map : Object
	{
		// Token: 0x0600010F RID: 271 RVA: 0x000294D4 File Offset: 0x000276D4
		// Note: this type is marked as 'beforefieldinit'.
		static Level2Map()
		{
			Il2CppClassPointerStore<Level2Map>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "Level2Map");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Level2Map>.NativeClassPtr);
			Level2Map.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level2Map>.NativeClassPtr, "Source");
			Level2Map.NativeFieldInfoPtr_Replace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level2Map>.NativeClassPtr, "Replace");
			Level2Map.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Level2Map>.NativeClassPtr, 100663493);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00029540 File Offset: 0x00027740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276476, XrefRangeEnd = 1276477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Level2Map(byte source, byte replace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Level2Map>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Level2Map.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002757 File Offset: 0x00000957
		public Level2Map(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00029598 File Offset: 0x00027798
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002760 File Offset: 0x00000960
		public unsafe byte Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level2Map.NativeFieldInfoPtr_Source);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level2Map.NativeFieldInfoPtr_Source)) = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000114 RID: 276 RVA: 0x000295C0 File Offset: 0x000277C0
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0000277B File Offset: 0x0000097B
		public unsafe byte Replace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level2Map.NativeFieldInfoPtr_Replace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level2Map.NativeFieldInfoPtr_Replace)) = value;
			}
		}

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_Source;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_Replace;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_0;
	}
}
